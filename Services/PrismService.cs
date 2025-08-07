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
        public async Task<List<string>> GetProcessingMonths()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                try
                {
                    var results = await connection.QueryAsync<string>(
                        "dbo.spGetProcessingMonths",  
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetProcessingMonths: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task StartRun(string processingMonth, string notes)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@ProcessingMonth", processingMonth, DbType.String);
                parameters.Add("@Notes", notes, DbType.String);

                try
                {
                    await connection.ExecuteAsync(
                        "dbo.spStartRun",
                        parameters,
                        commandType: CommandType.StoredProcedure);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in StartPrismRun: " + ex.Message);
                    throw;
                }
            }
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
                    var allocatedPremiumSignedTask = GetAllocatedPremiumSigned(runID);
                    var allocatedPremiumWrittenTask = GetAllocatedPremiumWritten(runID);
                    var allocatedRecoveriesAndRIPsTask = GetAllocatedRecoveriesAndRIPs(runID);
                    var oriPolicyIncurredClaimsByEventTask = GetORIPolicyIncurredClaimsByEvent(runID);
                    var oriPolicyUltimatedClaimsByEventTask = GetORIPolicyUltimateClaimsByEvent(runID);
                    var oriActualRecoveriesTask = GetORIActualRecoveries(runID);
                    var oriActualRIPsTask = GetORIActualRIPs(runID);
                    var oriPoliciesTask = GetORIPolicies(runID);
                    var oriPolicyToIncurredClaimsMappingTask = GetORIPolicyToIncurredClaimsMapping(runID);
                    var oriPolicyToInwardPolicyMappingTask = GetORIPolicyToInwardPolicyMapping(runID);
                    var oriPolicyToUltimateClaimsMappingTask = GetORIPolicyToUltimateClaimsMapping(runID);

                    await Task.WhenAll(
                        logsTask,
                        allocatedPremiumSignedTask,
                        allocatedPremiumWrittenTask,
                        allocatedRecoveriesAndRIPsTask,
                        oriPolicyIncurredClaimsByEventTask,
                        oriActualRecoveriesTask,
                        oriActualRIPsTask,
                        oriPoliciesTask,
                        oriPolicyToIncurredClaimsMappingTask,
                        oriPolicyToInwardPolicyMappingTask,
                        oriPolicyToUltimateClaimsMappingTask
                    );

                    // Assign the collections
                    run.Logs = logsTask.Result;
                    run.AllocatedPremiumSigned = allocatedPremiumSignedTask.Result;
                    run.AllocatedPremiumWritten = allocatedPremiumWrittenTask.Result;
                    run.AllocatedRecoveriesAndRIPs = allocatedRecoveriesAndRIPsTask.Result;
                    run.ORIPolicyIncurredClaimsByEvent = oriPolicyIncurredClaimsByEventTask.Result;
                    run.ORIPolicyUltimateClaimsByEvent = oriPolicyUltimatedClaimsByEventTask.Result;
                    run.ORIActualRecoveries = oriActualRecoveriesTask.Result;
                    run.ORIActualRIPs = oriActualRIPsTask.Result;
                    run.ORIPolicies = oriPoliciesTask.Result;
                    run.ORIPolicyToIncurredClaimsMapping = oriPolicyToIncurredClaimsMappingTask.Result;
                    run.ORIPolicyToInwardPolicyMapping = oriPolicyToInwardPolicyMappingTask.Result;
                    run.ORIPolicyToUltimateClaimsMapping = oriPolicyToUltimateClaimsMappingTask.Result;

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
        public async Task<List<AllocatedPremiumSignedModel>> GetAllocatedPremiumSigned(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedPremiumSignedModel>(
                        "outputs.spGetreporting_AllocatedPremiumSigned",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedPremium: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<AllocatedPremiumWrittenModel>> GetAllocatedPremiumWritten(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedPremiumWrittenModel>(
                        "outputs.spGetreporting_AllocatedPremiumWritten",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedPremium: " + ex.Message);
                    throw;
                }
            }
        }


        public async Task<List<AllocatedRecoveriesAndRIPsModel>> GetAllocatedRecoveriesAndRIPs(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedRecoveriesAndRIPsModel>(
                        "outputs.spGetreporting_AllocatedRecoveriesAndRIPs",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedRecoveriesAndRIPs: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPolicyIncurredClaimsByEventModel>> GetORIPolicyIncurredClaimsByEvent(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyIncurredClaimsByEventModel>(
                        "outputs.spGetanalytics_ORIPolicyIncurredClaimsByEvent",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicyIncurredClaimsByEvent: " + ex.Message);
                    throw;
                }
            }
        }
        public async Task<List<ORIPolicyUltimateClaimsByEventModel>> GetORIPolicyUltimateClaimsByEvent(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyUltimateClaimsByEventModel>(
                        "outputs.spGetanalytics_ORIPolicyUltimateClaimsByEvent",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicyUltimateClaimsByEvent: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIActualRecoveriesModel>> GetORIActualRecoveries(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIActualRecoveriesModel>(
                        "outputs.spGetanalytics_ORIActualRecoveries",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIActualRecoveries: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIActualRIPsModel>> GetORIActualRIPs(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIActualRIPsModel>(
                        "outputs.spGetanalytics_ORIActualRIPs",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIActualRIPs: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPoliciesModel>> GetORIPolicies(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPoliciesModel>(
                        "outputs.spGetanalytics_ORIPolicies",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicies: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPolicyToIncurredClaimsMappingModel>> GetORIPolicyToIncurredClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyToIncurredClaimsMappingModel>(
                        "outputs.spGetanalytics_ORIPolicyToIncurredClaimsMapping",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicyToIncurredClaimsMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPolicyToInwardPolicyMappingModel>> GetORIPolicyToInwardPolicyMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyToInwardPolicyMappingModel>(
                        "outputs.spGetanalytics_ORIPolicyToInwardPolicyMaping",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicyToInwardPolicyMapping: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<ORIPolicyToUltimateClaimsMappingModel>> GetORIPolicyToUltimateClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolicyToUltimateClaimsMappingModel>(
                        "outputs.spGetanalytics_ORIPolicyToUltimateClaimsMapping",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetORIPolicyToUltimateClaimsMapping: " + ex.Message);
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