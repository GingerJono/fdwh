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
    }
}