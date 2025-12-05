using System.Data;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using Sandbox.Models.FDWH;

namespace Sandbox.Services
{
	public class FDWHReportingService
	{
		private readonly IConfiguration _config;
		private readonly string _exportRoot;

		public FDWHReportingService(IConfiguration config)
		{
			_config = config;
			_exportRoot = Path.Combine(AppContext.BaseDirectory, "Exports");
			Directory.CreateDirectory(_exportRoot);
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
		}

		private string GetFDWHConnection() => _config.GetConnectionString("FDWHConnection");
		private string GetSandboxConnection() => _config.GetConnectionString("DaleSandboxConnection");

		public async Task<int> LogRunAsync(int reportId, string runBy, string paramsJson, int version, string filePath, int rowCount)
		{
			using var conn = new SqlConnection(GetSandboxConnection());
			using var cmd = new SqlCommand(@"
				INSERT INTO dbo.ReportRuns
					(ReportID, RunBy, ParametersJSON, ReportVersion, FilePath, [RowCount])
				OUTPUT INSERTED.RunID
				VALUES (@ReportID, @RunBy, @Params, @Version, @FilePath, @RowCount)", conn);

			cmd.Parameters.AddWithValue("@ReportID", reportId);
			cmd.Parameters.AddWithValue("@RunBy", runBy);
			cmd.Parameters.AddWithValue("@Params", paramsJson);
			cmd.Parameters.AddWithValue("@Version", version);
			cmd.Parameters.AddWithValue("@FilePath", filePath ?? (object)DBNull.Value);
			cmd.Parameters.AddWithValue("@RowCount", rowCount);

			await conn.OpenAsync();
			return (int)await cmd.ExecuteScalarAsync();
		}

		public async Task<byte[]> RunReportAndExportAsync(
			int reportId,
			string storedProc,
			Dictionary<string, object> parameters,
			string runBy,
			int version)
		{
			try
			{
				var dt = new DataTable();
				using var conn = new SqlConnection(GetFDWHConnection());
				using var cmd = new SqlCommand(storedProc, conn) { CommandType = CommandType.StoredProcedure, CommandTimeout = 300 };
				foreach (var p in parameters) cmd.Parameters.AddWithValue(p.Key, p.Value ?? DBNull.Value);
				await conn.OpenAsync();
				using var adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);

				using var package = new ExcelPackage();
				var outputSheet = package.Workbook.Worksheets.Add("Output");
				outputSheet.Cells["A1"].LoadFromDataTable(dt, true);

				var controlSheet = package.Workbook.Worksheets.Add("Control");
				controlSheet.Cells["A1"].Value = "Report ID";
				controlSheet.Cells["B1"].Value = reportId;
				controlSheet.Cells["A2"].Value = "Run By";
				controlSheet.Cells["B2"].Value = runBy;
				controlSheet.Cells["A3"].Value = "Run Date (UTC)";
				controlSheet.Cells["B3"].Value = DateTime.UtcNow;
				controlSheet.Cells["A4"].Value = "Version";
				controlSheet.Cells["B4"].Value = version;
				controlSheet.Cells["A5"].Value = "Parameters JSON";
				controlSheet.Cells["B5"].Value = System.Text.Json.JsonSerializer.Serialize(parameters);
				controlSheet.Cells.AutoFitColumns();

				await LogRunAsync(reportId, runBy,
					System.Text.Json.JsonSerializer.Serialize(parameters),
					version, null, dt.Rows.Count);

				return await package.GetAsByteArrayAsync();
			}
			catch (SqlException ex)
			{
				throw new Exception($"SQL Error executing {storedProc}: {ex.Message}", ex);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error generating report {storedProc}: {ex.Message}", ex);
			}
		}



		public async Task<List<FDWHReportRun>> GetReportRunsAsync()
		{
			var runs = new List<FDWHReportRun>();
			using var conn = new SqlConnection(GetSandboxConnection());
			using var cmd = new SqlCommand(
				"SELECT RunID, ReportID, RunBy, RunDate, ReportVersion, [RowCount], FilePath, ParametersJSON FROM dbo.ReportRuns ORDER BY RunDate DESC", conn);
			await conn.OpenAsync();
			using var reader = await cmd.ExecuteReaderAsync();
			while (await reader.ReadAsync())
			{
				runs.Add(new FDWHReportRun
				{
					RunID = reader.GetInt32(0),
					ReportID = reader.GetInt32(1),
					RunBy = reader.GetString(2),
					RunDate = reader.GetDateTime(3),
					ReportVersion = reader.GetInt32(4),
					RowCount = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
					FilePath = reader.IsDBNull(6) ? null : reader.GetString(6),
					ParametersJSON = reader.IsDBNull(7) ? null : reader.GetString(7)
				});
			}
			return runs;
		}

		public async Task<List<FDWHReport>> GetReportListAsync()
		{
			var reports = new List<FDWHReport>();
			using var conn = new SqlConnection(GetFDWHConnection());
			using var cmd = new SqlCommand("SELECT * FROM reporting.ReportList WHERE IsActive = 1 ORDER BY ReportName", conn);
			await conn.OpenAsync();

			using var reader = await cmd.ExecuteReaderAsync();
			while (await reader.ReadAsync())
			{
				var report = new FDWHReport
				{
					ReportID = reader.GetInt32(reader.GetOrdinal("ReportID")),
					ReportName = reader.GetString(reader.GetOrdinal("ReportName")),
					StoredProcName = reader.GetString(reader.GetOrdinal("StoredProcName")),
					VersionNumber = reader.GetInt32(reader.GetOrdinal("VersionNumber")),
					Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
					IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive"))
				};
				reports.Add(report);
			}

			return reports;
		}

	}
}
