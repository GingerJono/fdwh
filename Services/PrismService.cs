using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Sandbox.Models.Prism;
using Sandbox.Models.ORI;
using ClosedXML.Excel;
using System.Numerics;
using System.Diagnostics;

namespace Sandbox.Services
{
    public class PrismService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        public PrismService(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
        }

        // Get Runs and Logs
        public async Task<RunModel> GetRun(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                var run = await connection.QuerySingleOrDefaultAsync<RunModel>(
                    "dbo.spGetRun",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                if (run != null)
                {
                    // Load child collections in parallel
                    var logsTask = GetRunLogs(runID);
                    var incurredClaimsMappingTask = GetORIPolicyIncurredClaimsMapping(runID);
                    var ultimateClaimsMappingTask = GetORIPolicyUltimateClaimsMapping(runID);
                    var incurredByEventTask = GetIncurredClaimsByORIPolicyByEvent(runID);
                    var ultimateByEventTask = GetUltimateClaimsByORIPolicyByEvent(runID);
                    var combinedCommutedRecoveriesAndRIPSTask = GetCombinedCommutedRecoveriesAndRIPs(runID);
                    

                    await Task.WhenAll(
                        logsTask,
                        incurredClaimsMappingTask,
                        ultimateClaimsMappingTask,
                        incurredByEventTask,
                        ultimateByEventTask,
                        combinedCommutedRecoveriesAndRIPSTask                        
                    );

                    //Assign the collections
                    run.Logs = logsTask.Result;
                    run.ORIPolicyIncurredClaimsMapping = incurredClaimsMappingTask.Result;
                    run.ORIPolicyUltimateClaimsMapping = ultimateClaimsMappingTask.Result;
                    run.IncurredClaimsByEvent = incurredByEventTask.Result;
                    run.UltimateClaimsByEvent = ultimateByEventTask.Result;
                    run.CombinedCommutedRecoveriesAndRIPs = combinedCommutedRecoveriesAndRIPSTask.Result;
                    
                    return run;
                }

                return null;
            }
        }

        public async Task<List<RunModel>> GetRuns()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var results = await connection.QueryAsync<RunModel>(
                    "dbo.spGetRuns",
                    commandType: System.Data.CommandType.StoredProcedure);

                return results.ToList();
            }
        }

        public async Task<List<RunLogModel>> GetRunLogs(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                var results = await connection.QueryAsync<RunLogModel>(
                    "dbo.spGetRunLogs",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return results.ToList();
            }
        }

        // Get Outputs

        public async Task<List<ORIPolicyIncurredClaimsMappingModel>> GetORIPolicyIncurredClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyIncurredClaimsMappingModel>(
                        "outputs.spGetd01_ORIPolIncurredClaimsMapping",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPolicyUltimateClaimsMappingModel>> GetORIPolicyUltimateClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);
                try
                {
                    var results = await connection.QueryAsync<ORIPolicyUltimateClaimsMappingModel>(
                    "outputs.spGetd02_ORIPolUltimateClaimsMapping",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<IncurredClaimsByORIPolicyByEventModel>> GetIncurredClaimsByORIPolicyByEvent(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<IncurredClaimsByORIPolicyByEventModel>(
                    "outputs.spGetd03_IncurredClaimsByORIPolicyByEvent",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<UltimateClaimsByORIPolicyByEventModel>> GetUltimateClaimsByORIPolicyByEvent(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<UltimateClaimsByORIPolicyByEventModel>(
                    "outputs.spGetd04_UltimateClaimsByORIPolicyByEvent",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<CombinedCommutedRecoveriesAndRIPsModel>> GetCombinedCommutedRecoveriesAndRIPs(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();
                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);
                try
                {
                    var results = await connection.QueryAsync<CombinedCommutedRecoveriesAndRIPsModel>(
                    "outputs.spGetd11_CombinedCommutedRecoveriesAndRIPs",
                    parameters,
                    commandType: CommandType.StoredProcedure);
                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }


        }

        public async Task<List<ORIAdjustmentUploadModel>> GetORIAdjustmentUploads()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                try
                {
                    var results = await connection.QueryAsync<ORIAdjustmentUploadModel>(
                        "ORI.spGetORIAdjustmentUploads",
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIAdjustmentUploads: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<int> UploadAdjustmentsAsync(Stream excelStream, string uploadedBy, string adjustmentFileName)
        {
            using var workbook = new XLWorkbook(excelStream);
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Insert and get the new AdjustmentID, storing the original filename
                var adjustmentID = await connection.ExecuteScalarAsync<int>(
                    @"INSERT INTO ORI.AdjustmentUploads (UploadedBy, AdjustmentFileName)
                      OUTPUT INSERTED.AdjustmentID
                      VALUES (@User, @FileName);",
                    new { User = uploadedBy, FileName = adjustmentFileName },
                    transaction);

                // Insert sheets
                await InsertSheetAsync(workbook.Worksheet("Incurred Claims"), "ORI.AdjustmentsInputIncurredClaims", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("ORI Policies"), "ORI.AdjustmentsInputORIPolicies", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("Ultimate Claims"), "ORI.AdjustmentsInputUltimateClaims", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("Allocated Recoveries and RIPs"), "ORI.AdjustmentsOutputAllocatedRecoveriesAndRIPs", adjustmentID, uploadedBy, connection, transaction);

                // Save file to wwwroot/uploads/prismadjustments with AdjustmentID prepended
                var safeFileName = Path.GetFileName(adjustmentFileName);
                var finalFileName = $"{adjustmentID}_{safeFileName}";

                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "prismadjustments");
                Directory.CreateDirectory(uploadFolder);

                var savedPath = Path.Combine(uploadFolder, finalFileName);
                excelStream.Position = 0;
                using (var fileStream = new FileStream(savedPath, FileMode.Create))
                {
                    await excelStream.CopyToAsync(fileStream);
                }

                transaction.Commit();
                return adjustmentID;
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }

        private async Task InsertSheetAsync(IXLWorksheet sheet, string tableName, int adjustmentID, string user, SqlConnection conn, SqlTransaction tx)
        {
            var dataTable = new DataTable();

            foreach (var headerCell in sheet.Row(1).Cells())
                dataTable.Columns.Add(headerCell.GetValue<string>());

            if (!dataTable.Columns.Contains("AdjustmentID"))
                dataTable.Columns.Add("AdjustmentID", typeof(long)).SetOrdinal(0);

            foreach (var row in sheet.RowsUsed().Skip(1))
            {
                var dataRow = dataTable.NewRow();

                // Start from column 1 because AdjustmentID is not in the Excel file
                for (int colIndex = 1; colIndex < dataTable.Columns.Count; colIndex++)
                {
                    var colName = dataTable.Columns[colIndex].ColumnName;
                    var cellValue = row.Cell(colIndex).Value;

                    var cell = row.Cell(colIndex);
                    dataRow[colName] = (cell.IsEmpty() || string.IsNullOrWhiteSpace(cell.GetFormattedString()))
                        ? DBNull.Value
                        : cell.Value;
                }

                // Assign AdjustmentID (first column)
                dataRow["AdjustmentID"] = adjustmentID;

                dataTable.Rows.Add(dataRow);
            }


            using var bulk = new SqlBulkCopy(conn, SqlBulkCopyOptions.Default, tx)
            {
                DestinationTableName = tableName,
                BatchSize = 5000
            };          

            await bulk.WriteToServerAsync(dataTable);
        }


    }
}