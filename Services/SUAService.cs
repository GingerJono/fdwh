using System.Data;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using Sandbox.Models.SUA;

namespace Sandbox.Services
{
	public class SUAService
	{
		private readonly IConfiguration _config;
		private readonly string[] RequiredColumns = new[]
		{
			"Version", "YOA", "ClassCode", "ClassName", "ReservingClass",
			"DistributionChannel", "SettCCY", "Item", "ClaimsDetail",
			"RIType", "ValueSCC", "Comment"
		};

		public SUAService(IConfiguration config)
		{
			_config = config;
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
		}

		private string GetConnectionString() => _config.GetConnectionString("DaleSandboxConnection");

		public async Task<(bool Success, string Message, int? VersionID)> UploadSUAFileAsync(
			Stream fileStream,
			int processingMonth,
			int syndicate,
			string comments,
			string uploadedBy)
		{
			try
			{
				// Copy to MemoryStream to avoid "Synchronous reads are not supported" error
				using var memoryStream = new MemoryStream();
				await fileStream.CopyToAsync(memoryStream);
				memoryStream.Position = 0;

				// Load Excel file
				using var package = new ExcelPackage(memoryStream);

				// Find worksheet that starts with "SUA"
				var worksheet = package.Workbook.Worksheets.FirstOrDefault(ws => ws.Name.StartsWith("SUA", StringComparison.OrdinalIgnoreCase));
				if (worksheet == null)
				{
					return (false, "Error: File must contain a worksheet with name starting with 'SUA'", null);
				}

				// Validate headers in row 1
				var headerRow = 1;
				var columnMapping = new Dictionary<string, int>();
				for (int col = 1; col <= worksheet.Dimension.Columns; col++)
				{
					var headerValue = worksheet.Cells[headerRow, col].Value?.ToString()?.Trim();
					if (!string.IsNullOrEmpty(headerValue))
					{
						columnMapping[headerValue] = col;
					}
				}

				// Check all required columns are present
				var missingColumns = RequiredColumns.Where(rc => !columnMapping.ContainsKey(rc)).ToList();
				if (missingColumns.Any())
				{
					return (false, $"Error: Missing required columns: {string.Join(", ", missingColumns)}", null);
				}

				// Check we have data rows
				if (worksheet.Dimension.Rows <= 1)
				{
					return (false, "Error: File must contain at least one data row", null);
				}

				// Generate version number
				var version = await GetNextVersionNumberAsync(processingMonth);

				// Read data rows
				var suaRecords = new List<SUA>();
				for (int row = 2; row <= worksheet.Dimension.Rows; row++)
				{
					// Skip empty rows
					if (worksheet.Cells[row, 1, row, worksheet.Dimension.Columns].All(c => c.Value == null))
						continue;

					var record = new SUA
					{
						Version = worksheet.Cells[row, columnMapping["Version"]].Value?.ToString(),
						YOA = int.TryParse(worksheet.Cells[row, columnMapping["YOA"]].Value?.ToString(), out int yoa) ? yoa : (int?)null,
						ClassCode = worksheet.Cells[row, columnMapping["ClassCode"]].Value?.ToString(),
						ClassName = worksheet.Cells[row, columnMapping["ClassName"]].Value?.ToString(),
						ReservingClass = worksheet.Cells[row, columnMapping["ReservingClass"]].Value?.ToString(),
						DistributionChannel = worksheet.Cells[row, columnMapping["DistributionChannel"]].Value?.ToString(),
						SettCCY = worksheet.Cells[row, columnMapping["SettCCY"]].Value?.ToString(),
						Item = worksheet.Cells[row, columnMapping["Item"]].Value?.ToString(),
						ClaimsDetail = worksheet.Cells[row, columnMapping["ClaimsDetail"]].Value?.ToString(),
						RIType = worksheet.Cells[row, columnMapping["RIType"]].Value?.ToString(),
						ValueSCC = decimal.TryParse(worksheet.Cells[row, columnMapping["ValueSCC"]].Value?.ToString(), out decimal val) ? val : (decimal?)null,
						Comment = worksheet.Cells[row, columnMapping["Comment"]].Value?.ToString()
					};

					suaRecords.Add(record);
				}

				if (suaRecords.Count == 0)
				{
					return (false, "Error: No valid data rows found in file", null);
				}

				// Insert into database
				var versionID = await InsertSUADataAsync(version, processingMonth, syndicate, comments, uploadedBy, suaRecords);

				return (true, $"Successfully uploaded {suaRecords.Count} rows as version {version}", versionID);
			}
			catch (Exception ex)
			{
				return (false, $"Error processing file: {ex.Message}", null);
			}
		}

		private async Task<string> GetNextVersionNumberAsync(int processingMonth)
		{
			using var conn = new SqlConnection(GetConnectionString());
			using var cmd = new SqlCommand(@"
				SELECT MAX(CAST(SUBSTRING(Version, CHARINDEX('.', Version) + 1, LEN(Version)) AS INT))
				FROM dbo.SUAVersions
				WHERE ProcessingMonth = @ProcessingMonth", conn);

			cmd.Parameters.AddWithValue("@ProcessingMonth", processingMonth);

			await conn.OpenAsync();
			var result = await cmd.ExecuteScalarAsync();

			int nextIncrement = 1;
			if (result != null && result != DBNull.Value)
			{
				nextIncrement = Convert.ToInt32(result) + 1;
			}

			return $"{processingMonth}.{nextIncrement:D2}";
		}

		private async Task<int> InsertSUADataAsync(
			string version,
			int processingMonth,
			int syndicate,
			string comments,
			string uploadedBy,
			List<SUA> records)
		{
			using var conn = new SqlConnection(GetConnectionString());
			await conn.OpenAsync();

			using var transaction = conn.BeginTransaction();
			try
			{
				// Insert SUAVersion
				int versionID;
				using (var cmd = new SqlCommand(@"
					INSERT INTO dbo.SUAVersions (Version, ProcessingMonth, Syndicate, Comments, UploadedDate, UploadedBy, IsActive)
					OUTPUT INSERTED.VersionID
					VALUES (@Version, @ProcessingMonth, @Syndicate, @Comments, @UploadedDate, @UploadedBy, @IsActive)", conn, transaction))
				{
					cmd.Parameters.AddWithValue("@Version", version);
					cmd.Parameters.AddWithValue("@ProcessingMonth", processingMonth);
					cmd.Parameters.AddWithValue("@Syndicate", syndicate);
					cmd.Parameters.AddWithValue("@Comments", comments ?? (object)DBNull.Value);
					cmd.Parameters.AddWithValue("@UploadedDate", DateTime.UtcNow);
					cmd.Parameters.AddWithValue("@UploadedBy", uploadedBy);
					cmd.Parameters.AddWithValue("@IsActive", true);

					versionID = (int)await cmd.ExecuteScalarAsync();
				}

				// Insert SUA records
				using (var cmd = new SqlCommand(@"
					INSERT INTO dbo.SUA (Version, YOA, ClassCode, ClassName, ReservingClass,
						DistributionChannel, SettCCY, Item, ClaimsDetail, RIType, ValueSCC, Comment)
					VALUES (@Version, @YOA, @ClassCode, @ClassName, @ReservingClass,
						@DistributionChannel, @SettCCY, @Item, @ClaimsDetail, @RIType, @ValueSCC, @Comment)", conn, transaction))
				{
					foreach (var record in records)
					{
						cmd.Parameters.Clear();
						cmd.Parameters.AddWithValue("@Version", version); // Use the version from SUAVersions
						cmd.Parameters.AddWithValue("@YOA", record.YOA ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@ClassCode", record.ClassCode ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@ClassName", record.ClassName ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@ReservingClass", record.ReservingClass ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@DistributionChannel", record.DistributionChannel ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@SettCCY", record.SettCCY ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@Item", record.Item ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@ClaimsDetail", record.ClaimsDetail ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@RIType", record.RIType ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@ValueSCC", record.ValueSCC ?? (object)DBNull.Value);
						cmd.Parameters.AddWithValue("@Comment", record.Comment ?? (object)DBNull.Value);

						await cmd.ExecuteNonQueryAsync();
					}
				}

				transaction.Commit();
				return versionID;
			}
			catch
			{
				transaction.Rollback();
				throw;
			}
		}

		public async Task<List<SUAVersionSummary>> GetAllVersionsAsync()
		{
			var versions = new List<SUAVersionSummary>();
			using var conn = new SqlConnection(GetConnectionString());
			using var cmd = new SqlCommand(@"
				SELECT
					sv.VersionID,
					sv.Version,
					sv.ProcessingMonth,
					sv.Syndicate,
					sv.Comments,
					sv.UploadedDate,
					sv.UploadedBy,
					sv.IsActive,
					COUNT(s.Version) as RowCount,
					ISNULL(SUM(s.ValueSCC), 0) as TotalValueSCC
				FROM dbo.SUAVersions sv
				LEFT JOIN dbo.SUA s ON sv.Version = s.Version
				GROUP BY sv.VersionID, sv.Version, sv.ProcessingMonth, sv.Syndicate, sv.Comments,
					sv.UploadedDate, sv.UploadedBy, sv.IsActive
				ORDER BY sv.UploadedDate DESC", conn);

			await conn.OpenAsync();
			using var reader = await cmd.ExecuteReaderAsync();
			while (await reader.ReadAsync())
			{
				versions.Add(new SUAVersionSummary
				{
					VersionID = reader.GetInt32(0),
					Version = reader.GetString(1),
					ProcessingMonth = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
					Syndicate = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3),
					Comments = reader.IsDBNull(4) ? null : reader.GetString(4),
					UploadedDate = reader.IsDBNull(5) ? (DateTime?)null : reader.GetDateTime(5),
					UploadedBy = reader.IsDBNull(6) ? null : reader.GetString(6),
					IsActive = reader.IsDBNull(7) ? (bool?)null : reader.GetBoolean(7),
					RowCount = reader.GetInt32(8),
					TotalValueSCC = reader.GetDecimal(9)
				});
			}

			return versions;
		}

		public async Task<byte[]> DownloadVersionAsync(string version)
		{
			using var conn = new SqlConnection(GetConnectionString());
			using var cmd = new SqlCommand(@"
				SELECT Version, YOA, ClassCode, ClassName, ReservingClass, DistributionChannel,
					SettCCY, Item, ClaimsDetail, RIType, ValueSCC, Comment
				FROM dbo.SUA
				WHERE Version = @Version", conn);

			cmd.Parameters.AddWithValue("@Version", version);

			await conn.OpenAsync();
			var dt = new DataTable();
			using var adapter = new SqlDataAdapter(cmd);
			adapter.Fill(dt);

			using var package = new ExcelPackage();
			var worksheet = package.Workbook.Worksheets.Add("SUA Data");
			worksheet.Cells["A1"].LoadFromDataTable(dt, true);
			worksheet.Cells.AutoFitColumns();

			return await package.GetAsByteArrayAsync();
		}

		public byte[] GenerateEmptyTemplate()
		{
			using var package = new ExcelPackage();
			var worksheet = package.Workbook.Worksheets.Add("SUA Template");

			// Add headers
			var headers = RequiredColumns;
			for (int i = 0; i < headers.Length; i++)
			{
				worksheet.Cells[1, i + 1].Value = headers[i];
				worksheet.Cells[1, i + 1].Style.Font.Bold = true;
			}

			worksheet.Cells.AutoFitColumns();

			return package.GetAsByteArray();
		}
	}
}
