using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using Sandbox.Models.Prism;

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
                    var incurredClaimsMappingTask = GetORIPolIncurredClaimsMapping(runID);
                    var ultimateClaimsMappingTask = GetORIPolUltimateClaimsMapping(runID);
                    var incurredByEventTask = GetIncurredClaimsByORIPolicyByEvent(runID);
                    var ultimateByEventTask = GetUltimateClaimsByORIPolicyByEvent(runID);
                    var allocatedPaidTask = GetAllocatedPaidRecoveries(runID);
                    var allocatedIncurredTask = GetAllocatedIncurredRecoveries(runID);
                    var allocatedUltimateTask = GetAllocatedUltimateRecoveries(runID);
                    var allocatedMergedTask = GetAllocatedRecoveriesMerged(runID);

                    await Task.WhenAll(
                        logsTask,
                        incurredClaimsMappingTask,
                        ultimateClaimsMappingTask,
                        incurredByEventTask,
                        ultimateByEventTask,
                        allocatedPaidTask,
                        allocatedIncurredTask,
                        allocatedUltimateTask,
                        allocatedMergedTask
                    );

                    //Assign the collections
                    run.Logs = logsTask.Result;
                    run.ORIPolIncurredClaimsMapping = incurredClaimsMappingTask.Result;
                    run.ORIPolUltimateClaimsMapping = ultimateClaimsMappingTask.Result;
                    run.IncurredClaimsByEvent = incurredByEventTask.Result;
                    run.UltimateClaimsByEvent = ultimateByEventTask.Result;
                    run.AllocatedPaidRecoveries = allocatedPaidTask.Result;
                    run.AllocatedIncurredRecoveries = allocatedIncurredTask.Result;
                    run.AllocatedUltimateRecoveries = allocatedUltimateTask.Result;
                    run.AllocatedRecoveriesMerged = allocatedMergedTask.Result;

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

        public async Task<List<ORIPolIncurredClaimsMappingModel>> GetORIPolIncurredClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<ORIPolIncurredClaimsMappingModel>(
                        "outputs.spGet01_ORIPolIncurredClaimsMapping",
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

        public async Task<List<ORIPolUltimateClaimsMappingModel>> GetORIPolUltimateClaimsMapping(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);
                try
                {
                    var results = await connection.QueryAsync<ORIPolUltimateClaimsMappingModel>(
                    "outputs.spGet02_ORIPolUltimateClaimsMapping",
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
                    "outputs.spGet03_IncurredClaimsByORIPolicyByEvent",
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
                    "outputs.spGet04_UltimateClaimsByORIPolicyByEvent",
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

        public async Task<List<AllocatedPaidRecoveriesByORIPolicyEventClassYOAModel>> GetAllocatedPaidRecoveries(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<AllocatedPaidRecoveriesByORIPolicyEventClassYOAModel>(
                    "outputs.spGet05_AllocatedPaidRecoveriesByORIPolicyByEventByClassByYOA",
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

        public async Task<List<AllocatedIncurredRecoveriesByORIPolicyEventClassYOAModel>> GetAllocatedIncurredRecoveries(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<AllocatedIncurredRecoveriesByORIPolicyEventClassYOAModel>(
                    "outputs.spGet06_AllocatedIncurredRecoveriesByORIPolicyByEventByClassByYOA",
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

        public async Task<List<AllocatedUltimateRecoveriesByORIPolicyEventClassYOAModel>> GetAllocatedUltimateRecoveries(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<AllocatedUltimateRecoveriesByORIPolicyEventClassYOAModel>(
                    "outputs.spGet07_AllocatedUltimateRecoveriesByORIPolicyByEventByClassByYOA",
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

        public async Task<List<AllocatedRecoveryModel>> GetAllocatedRecoveriesMerged(int runID)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("PrismConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("RunID", runID, DbType.Int32);

                try
                {
                    var results = await connection.QueryAsync<AllocatedRecoveryModel>(
                    "outputs.spGet08_AllocatedRecoveriesMerged",
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
    }
}