using Dapper;
using Microsoft.Data.SqlClient;
using sandboxapp.Models.Ultimates;
using System.Data;

namespace sandboxapp.Services
{
    /// <summary>
    /// Service for Premium tracking operations
    /// Uses insert-only, versioned snapshot model
    /// All operations via stored procedures
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
        /// Get all latest Premium records
        /// </summary>
        public async Task<IEnumerable<PremiumListItemModel>> GetLatestPremiumList()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var result = await connection.QueryAsync<PremiumListItemModel>(
                    "Ultimates.spGetLatestUltimatePremium",
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<PremiumListItemModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving latest Premium list");
                throw;
            }
        }

        /// <summary>
        /// Get latest Premium record for a specific combination
        /// </summary>
        public async Task<PremiumModel?> GetLatestPremiumByKey(string className, string reservingClass, int yoa)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", className, DbType.String);
                parameters.Add("@ReservingClass", reservingClass, DbType.String);
                parameters.Add("@YOA", yoa, DbType.Int32);

                var result = await connection.QueryFirstOrDefaultAsync<PremiumModel>(
                    "Ultimates.spGetLatestUltimatePremiumByClassRsvClassYOA",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Premium for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}",
                    className, reservingClass, yoa);
                throw;
            }
        }

        /// <summary>
        /// Get new version number for a combination
        /// </summary>
        public async Task<int> GetNewVersionNumber(string className, string reservingClass, int yoa)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", className, DbType.String);
                parameters.Add("@ReservingClass", reservingClass, DbType.String);
                parameters.Add("@YOA", yoa, DbType.Int32);
                parameters.Add("@NewVersionNo", dbType: DbType.Int32, direction: ParameterDirection.Output);

                await connection.ExecuteAsync(
                    "Ultimates.spGetNewVersionNo",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return parameters.Get<int>("@NewVersionNo");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting new version number for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}",
                    className, reservingClass, yoa);
                throw;
            }
        }

        /// <summary>
        /// Save Premium record (insert-only)
        /// </summary>
        public async Task SavePremium(PremiumModel model)
        {
            try
            {
                var context = _httpContextAccessor.HttpContext;
                string userName = context?.User?.Identity?.Name ?? "UnknownUser";

                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                // Get new version number
                var newVersion = await GetNewVersionNumber(model.Class, model.ReservingClass, model.YOA);

                var parameters = new DynamicParameters();
                parameters.Add("@Class", model.Class, DbType.String);
                parameters.Add("@ReservingClass", model.ReservingClass, DbType.String);
                parameters.Add("@YOA", model.YOA, DbType.Int32);
                parameters.Add("@Version", newVersion, DbType.Int32);
                parameters.Add("@Selection", model.Selection, DbType.String);
                parameters.Add("@GrossNetEntry", model.GrossNetEntry, DbType.String);
                parameters.Add("@UpdatedBy", userName, DbType.String);
                parameters.Add("@UpdateComments", model.UpdateComments, DbType.String);

                await connection.ExecuteAsync(
                    "Ultimates.spUpsertUltimatePremium",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                _logger.LogInformation("Successfully saved Premium for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}, Version={Version} by {User}",
                    model.Class, model.ReservingClass, model.YOA, newVersion, userName);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving Premium for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}",
                    model.Class, model.ReservingClass, model.YOA);
                throw;
            }
        }

        /// <summary>
        /// Get all FX rate sets
        /// </summary>
        public async Task<IEnumerable<FxRateSetModel>> GetFxRateSets()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var sql = @"
                    SELECT
                        FxRateSetID,
                        RateSetName,
                        RateSetDescription,
                        EffectiveDate,
                        IsActive
                    FROM Ultimates.FxRateSets
                    ORDER BY EffectiveDate DESC, RateSetName";

                var result = await connection.QueryAsync<FxRateSetModel>(sql);
                return result ?? Enumerable.Empty<FxRateSetModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving FX rate sets");
                throw;
            }
        }

        /// <summary>
        /// Get FX rates for a specific rate set
        /// </summary>
        public async Task<IEnumerable<FxRateModel>> GetFxRates(int fxRateSetId)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var sql = @"
                    SELECT
                        r.FxRateID,
                        r.FxRateSetID,
                        rs.RateSetName,
                        rs.RateSetDescription,
                        rs.EffectiveDate,
                        r.FromCurrency,
                        r.ToCurrency,
                        r.Rate
                    FROM Ultimates.FxRates r
                    INNER JOIN Ultimates.FxRateSets rs ON r.FxRateSetID = rs.FxRateSetID
                    WHERE r.FxRateSetID = @FxRateSetID
                    ORDER BY r.FromCurrency, r.ToCurrency";

                var result = await connection.QueryAsync<FxRateModel>(sql, new { FxRateSetID = fxRateSetId });
                return result ?? Enumerable.Empty<FxRateModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving FX rates for rate set {FxRateSetId}", fxRateSetId);
                throw;
            }
        }
    }
}
