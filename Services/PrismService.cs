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
            try
            {
                using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
                {
                    await connection.OpenAsync();

                    var parameters = new DynamicParameters();
                    parameters.Add("RunID", runID, DbType.Int64);

                    RunModel run;

                    try
                    {
                        run = await connection.QuerySingleOrDefaultAsync<RunModel>(
                            "dbo.spGetRun",
                            parameters,
                            commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error executing spGetRun: {ex.Message}");
                        throw;
                    }

                    if (run == null)
                        return null;

                    // Kick off child calls
                    var logsTask = GetRunLogs(runID);
                    var allocatedPremiumSignedTask = GetAllocatedPremiumSigned(runID);
                    var allocatedPremiumWrittenTask = GetAllocatedPremiumWritten(runID);
                    var allocatedOverridersAndProfitCommissionTask = GetAllocatedOverridersAndProfitCommission(runID);
                    var allocatedRecoveriesAndRIPsTask = GetAllocatedRecoveriesAndRIPs(runID);
                    var allocatedActualRecoveriesTask = GetAllocatedActualRecoveries(runID);
                    var allocatedActualRIPsTask = GetAllocatedActualRIPs(runID);
                    var subjectClaimsTask = GetSubjectClaims(runID, null);
                    var subjectPoliciesTask = GetSubjectPolicies(runID, null);
                    var oriActualRecoveriesTask = GetORIActualRecoveries(runID);
                    var oriActualRIPsTask = GetORIActualRIPs(runID);
                    var oriPoliciesTask = GetORIPolicies(runID);

                    try
                    {
                        // Await all in parallel
                        await Task.WhenAll(
                            logsTask,
                            allocatedPremiumSignedTask,
                            allocatedPremiumWrittenTask,
                            allocatedOverridersAndProfitCommissionTask,
                            allocatedRecoveriesAndRIPsTask,
                            allocatedActualRecoveriesTask,
                            allocatedActualRIPsTask,
                            subjectClaimsTask,
                            subjectPoliciesTask,
                            oriActualRecoveriesTask,
                            oriActualRIPsTask,
                            oriPoliciesTask
                        );
                    }
                    catch (Exception ex)
                    {
                        // WhenAll wraps exceptions in AggregateException -> expose the real inner failure
                        var inner = ex.InnerException?.Message ?? ex.Message;
                        Console.WriteLine($"Error loading child collections for run {runID}: {inner}");
                        throw;
                    }

                    // Populate the run object
                    run.Logs = logsTask.Result;
                    run.AllocatedPremiumSigned = allocatedPremiumSignedTask.Result;
                    run.AllocatedPremiumWritten = allocatedPremiumWrittenTask.Result;
                    run.AllocatedOverridersAndProfitCommission = allocatedOverridersAndProfitCommissionTask.Result;
                    run.AllocatedRecoveriesAndRIPs = allocatedRecoveriesAndRIPsTask.Result;
                    run.AllocatedActualRecoveries = allocatedActualRecoveriesTask.Result;
                    run.AllocatedActualRIPs = allocatedActualRIPsTask.Result;
                    run.SubjectClaims = subjectClaimsTask.Result;
                    run.SubjectPolicies = subjectPoliciesTask.Result;
                    run.ORIActualRecoveries = oriActualRecoveriesTask.Result;
                    run.ORIActualRIPs = oriActualRIPsTask.Result;
                    run.ORIPolicies = oriPoliciesTask.Result;

                    return run;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unhandled error in GetRun({runID}): {ex.Message}");
                throw;
            }
        }


        public async Task<int> GetRunIDForSandbox()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                try
                {
                    var result = await connection.ExecuteScalarAsync<int>(
                        "dbo.spGetRunIDForSandbox",
                        commandType: CommandType.StoredProcedure);

                    return result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetRunIDForSandbox: " + ex.Message);
                    throw;
                }
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

        public async Task<List<RunLogModel>> GetRunLogsForORIPolicy(int runID, string ORIPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", ORIPolicyReference, DbType.String);

                var results = await connection.QueryAsync<RunLogModel>(
                    "dbo.spGetRunLogsForORIPolicy",
                    parameters,
                    commandType: CommandType.StoredProcedure);

                return results.ToList();
            }
        }

        public async Task<List<RunLogModel>> GetRunLogsForEvent(int runID, string EventCode)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("EventCode", EventCode, DbType.String);

                var results = await connection.QueryAsync<RunLogModel>(
                    "dbo.spGetRunLogsForEvent",
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

        public async Task<List<AllocatedOverridersAndProfitCommissionModel>> GetAllocatedOverridersAndProfitCommission(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedOverridersAndProfitCommissionModel>(
                        "outputs.spGetreporting_AllocatedOverridersAndProfitCommission",
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

        public async Task<List<SubjectClaimsModel>> GetSubjectClaims(int runID, string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", oriPolicyReference, DbType.String);

                try
                {
                    var results = await connection.QueryAsync<SubjectClaimsModel>(
                        "outputs.spGetanalytics_ORIPolicyToIncurredAndUltimateClaimsMapping",
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

        public async Task<List<SubjectPoliciesModel>> GetSubjectPolicies(int runID, string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", oriPolicyReference, DbType.String);

                try
                {
                    var results = await connection.QueryAsync<SubjectPoliciesModel>(
                        "outputs.spGetanalytics_ORIPolicyToInwardPolicyMapping",
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

        public async Task<List<ClaimsByEventModel>> GetClaimsByEvent(int runID, string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", oriPolicyReference, DbType.String);

                try
                {
                    var results = await connection.QueryAsync<ClaimsByEventModel>(
                        "outputs.spGetanalytics_ORIPolicyClaimsByEvent",
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

        public async Task<List<UnAdjustedAdjustedModel>> GetUnadjustedAdjusted(int runID, string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();
               
                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", oriPolicyReference, DbType.String);

                try
                {
                    var results = await connection.QueryAsync<UnAdjustedAdjustedModel>(
                         "rec.spGet_UnadjustedAdjusted",
                         parameters,
                         commandType: CommandType.StoredProcedure,
                         commandTimeout: 300  
                     );

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedRecoveriesAndRIPs: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<WrittenPremiumDimensionAllocationsModel>> GetWrittenPremiumDimensionAllocations(int runID, string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);
                parameters.Add("ORIPolicyReference", oriPolicyReference, DbType.String);

                try
                {
                    var results = await connection.QueryAsync<WrittenPremiumDimensionAllocationsModel>(
                        "reporting.spGetWrittenPremiumDimensionAllocations",
                        parameters,
                        commandType: CommandType.StoredProcedure,
                        commandTimeout: 300
                    );

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedRecoveriesAndRIPs: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<AllocatedActualRecoveriesModel>> GetAllocatedActualRecoveries(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedActualRecoveriesModel>(
                        "outputs.spGetreporting_AllocatedActualRecoveries",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedActualRecoveries: " + ex.Message);
                    throw;
                }
            }
        }

        public async Task<List<AllocatedActualRIPsModel>> GetAllocatedActualRIPs(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<AllocatedActualRIPsModel>(
                        "outputs.spGetreporting_AllocatedActualRIPs",
                        parameters,
                        commandType: CommandType.StoredProcedure);

                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetAllocatedActualRIPs: " + ex.Message);
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

        public async Task<int> UploadAdjustmentsAsync(Stream excelStream, string uploadedBy, string adjustmentFileName, string processingMonth)
        {
            using var workbook = new XLWorkbook(excelStream);
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            using var transaction = connection.BeginTransaction();

            try
            {
                // Insert and get the new AdjustmentID, storing the original filename
                var adjustmentID = await connection.ExecuteScalarAsync<int>(
                    @"INSERT INTO ORI.AdjustmentUploads (UploadedBy, AdjustmentFileName, ProcessingMonth)
                      OUTPUT INSERTED.AdjustmentID
                      VALUES (@User, @FileName, @ProcessingMonth);",
                    new { User = uploadedBy, FileName = adjustmentFileName, ProcessingMonth = processingMonth },
                    transaction);

                // Insert sheets
                await InsertSheetAsync(workbook.Worksheet("Incurred Claims"), "ORI.AdjustmentsInputIncurredClaims", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("ORI Policies"), "ORI.AdjustmentsInputORIPolicies", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("Ultimate Claims"), "ORI.AdjustmentsInputUltimateClaims", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("Allocated Recoveries and RIPs"), "ORI.AdjustmentsOutputAllocatedRecoveriesAndRIPs", adjustmentID, uploadedBy, connection, transaction);
                await InsertSheetAsync(workbook.Worksheet("Claims By Event"), "ORI.AdjustmentsPreAllocationORIPolicyClaimsByEvent", adjustmentID, uploadedBy, connection, transaction);

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
