using Dapper;
using Microsoft.Data.SqlClient;
using sandboxapp.Models.Ultimates;
using System.Data;

namespace sandboxapp.Services
{
    /// <summary>
    /// Service for Ultimate Premium tracking operations
    /// Handles CRUD operations for underwriter selections
    /// </summary>
    public class UltimatesService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IConfiguration _configuration;
        private readonly ILogger<UltimatesService> _logger;

        public UltimatesService(
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor,
            ILogger<UltimatesService> logger)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _logger = logger;
        }

        /// <summary>
        /// Get complete snapshot of all Ultimate Premium data (current latest versions)
        /// </summary>
        public async Task<IEnumerable<UltimatePremiumRecordModel>> GetUltimatePremiumSnapshot()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var result = await connection.QueryAsync<UltimatePremiumRecordModel>(
                    "Ultimates.spGetUltimatePremiumSnapshot",
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<UltimatePremiumRecordModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium snapshot");
                throw;
            }
        }

        /// <summary>
        /// Get Ultimate Premium data for a specific Class/YOA (for editing)
        /// </summary>
        public async Task<UltimatePremiumEditModel> GetUltimatePremiumByClassYOA(string className, int yoa)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", className, DbType.String);
                parameters.Add("@YOA", yoa, DbType.Int32);

                var records = await connection.QueryAsync<UltimatePremiumRecordModel>(
                    "Ultimates.spGetUltimatePremiumByClassYOA",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                var model = new UltimatePremiumEditModel
                {
                    Class = className,
                    YOA = yoa,
                    Records = records?.ToList() ?? new List<UltimatePremiumRecordModel>(),
                    LastUpdatedDate = records?.Max(r => r.LastUpdatedDate),
                    LastUpdatedBy = records?.FirstOrDefault()?.LastUpdatedBy
                };

                return model;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium for Class={Class}, YOA={YOA}", className, yoa);
                throw;
            }
        }

        /// <summary>
        /// Get historical updates for a specific Class/YOA
        /// Returns aggregated summary by UpdateID
        /// </summary>
        public async Task<IEnumerable<UltimatePremiumHistoryModel>> GetUltimatePremiumHistory(string className, int yoa)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", className, DbType.String);
                parameters.Add("@YOA", yoa, DbType.Int32);

                var result = await connection.QueryAsync<UltimatePremiumHistoryModel>(
                    "Ultimates.spGetUltimatePremiumHistoryByClassYOA",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<UltimatePremiumHistoryModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium history for Class={Class}, YOA={YOA}", className, yoa);
                throw;
            }
        }

        /// <summary>
        /// Get detailed records for a specific UpdateID
        /// </summary>
        public async Task<IEnumerable<UltimatePremiumRecordModel>> GetUltimatePremiumHistoryDetail(int updateId)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@UpdateID", updateId, DbType.Int32);

                var result = await connection.QueryAsync<UltimatePremiumRecordModel>(
                    "Ultimates.spGetUltimatePremiumHistoryDetail",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<UltimatePremiumRecordModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium history detail for UpdateID={UpdateID}", updateId);
                throw;
            }
        }

        /// <summary>
        /// Get list of all Class/YOA combinations with summary data
        /// </summary>
        public async Task<IEnumerable<UltimatePremiumSummaryModel>> GetUltimatePremiumList()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var result = await connection.QueryAsync<UltimatePremiumSummaryModel>(
                    "Ultimates.spGetUltimatePremiumListClassYOA",
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<UltimatePremiumSummaryModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium list");
                throw;
            }
        }

        /// <summary>
        /// Save Ultimate Premium data for a Class/YOA
        /// Creates new versions (UpdateIDs) for audit trail
        /// </summary>
        public async Task SaveUltimatePremium(UltimatePremiumEditModel model)
        {
            try
            {
                var context = _httpContextAccessor.HttpContext;
                string userName = context?.User?.Identity?.Name ?? "UnknownUser";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                using var transaction = connection.BeginTransaction();

                try
                {
                    // Insert new versions for all modified or new records
                    // This creates a new UpdateID for each record
                    foreach (var record in model.Records.Where(r => r.IsModified || r.IsNew))
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@Class", model.Class, DbType.String);
                        parameters.Add("@ReservingClass", record.ReservingClass, DbType.String);
                        parameters.Add("@YOA", model.YOA, DbType.Int32);
                        parameters.Add("@DistributionChannel", record.DistributionChannel, DbType.String);
                        parameters.Add("@Currency", record.Currency, DbType.String);
                        parameters.Add("@UltimateGrossPremium", record.UltimateGrossPremium, DbType.Decimal);
                        parameters.Add("@UltimateNetPremium", record.UltimateNetPremium, DbType.Decimal);
                        parameters.Add("@UltimateRIPs", record.UltimateRIPs, DbType.Decimal);
                        parameters.Add("@UltimatePC", record.UltimatePC, DbType.Decimal);
                        parameters.Add("@LastUpdatedBy", userName, DbType.String);

                        await connection.ExecuteAsync(
                            "Ultimates.spUpsertUltimatePremium",
                            parameters,
                            commandType: CommandType.StoredProcedure,
                            transaction: transaction
                        );
                    }

                    transaction.Commit();
                    _logger.LogInformation("Successfully saved Ultimate Premium for Class={Class}, YOA={YOA} by {User}",
                        model.Class, model.YOA, userName);
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving Ultimate Premium for Class={Class}, YOA={YOA}", model.Class, model.YOA);
                throw;
            }
        }

        /// <summary>
        /// Get distinct list of Classes with Ultimate Premium data
        /// </summary>
        public async Task<IEnumerable<string>> GetClasses()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var result = await connection.QueryAsync<dynamic>(
                    "Ultimates.spGetUltimatePremiumListClasses",
                    commandType: CommandType.StoredProcedure
                );

                return result?.Select(r => (string)r.Class) ?? Enumerable.Empty<string>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Ultimate Premium classes");
                throw;
            }
        }

        /// <summary>
        /// Get YOAs for a specific Class
        /// </summary>
        public async Task<IEnumerable<int>> GetYOAsByClass(string className)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", className, DbType.String);

                var result = await connection.QueryAsync<dynamic>(
                    "Ultimates.spGetUltimatePremiumYOAsByClass",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result?.Select(r => (int)r.YOA) ?? Enumerable.Empty<int>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving YOAs for Class={Class}", className);
                throw;
            }
        }
    }
}
