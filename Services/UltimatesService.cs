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
        /// Returns the new version number
        /// </summary>
        public async Task<int> SavePremium(PremiumModel model)
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

                // Manual Entry Fields
                parameters.Add("@ManualGrossPremiumGBP", model.ManualGrossPremiumGBP, DbType.Decimal);
                parameters.Add("@ManualNetPremiumGBP", model.ManualNetPremiumGBP, DbType.Decimal);
                parameters.Add("@ManualDeductions", model.ManualDeductions, DbType.Decimal);
                parameters.Add("@ManualSplitGBP", model.ManualSplitGBP, DbType.Decimal);
                parameters.Add("@ManualSplitUSD", model.ManualSplitUSD, DbType.Decimal);
                parameters.Add("@ManualSplitCAD", model.ManualSplitCAD, DbType.Decimal);
                parameters.Add("@ManualSplitEUR", model.ManualSplitEUR, DbType.Decimal);
                parameters.Add("@ManualSplitJPY", model.ManualSplitJPY, DbType.Decimal);
                parameters.Add("@ManualEUSplit", model.ManualEUSplit, DbType.Decimal);

                await connection.ExecuteAsync(
                    "Ultimates.spUpsertUltimatePremium",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                _logger.LogInformation("Successfully saved Premium for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}, Version={Version} by {User}",
                    model.Class, model.ReservingClass, model.YOA, newVersion, userName);

                // Return the new version so caller can use it for PremiumCcy
                return newVersion;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving Premium for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}",
                    model.Class, model.ReservingClass, model.YOA);
                throw;
            }
        }

        /// <summary>
        /// Save PremiumCcy record (insert-only)
        /// </summary>
        public async Task SavePremiumCcy(PremiumCcyModel model)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@Class", model.Class, DbType.String);
                parameters.Add("@ReservingClass", model.ReservingClass, DbType.String);
                parameters.Add("@YOA", model.YOA, DbType.Int32);
                parameters.Add("@Version", model.Version, DbType.Int32);
                parameters.Add("@Currency", model.Currency, DbType.String);

                // Selected
                parameters.Add("@SelectedGGWP", model.SelectedGGWP, DbType.Decimal);
                parameters.Add("@SelectedDeductions", model.SelectedDeductions, DbType.Decimal);
                parameters.Add("@SelectedGNWP", model.SelectedGNWP, DbType.Decimal);
                parameters.Add("@SelectedEU", model.SelectedEU, DbType.Decimal);

                // Manual
                parameters.Add("@ManualGGWP", model.ManualGGWP, DbType.Decimal);
                parameters.Add("@ManualDeductions", model.ManualDeductions, DbType.Decimal);
                parameters.Add("@ManualGNWP", model.ManualGNWP, DbType.Decimal);
                parameters.Add("@ManualEU", model.ManualEU, DbType.Decimal);

                // Plan
                parameters.Add("@PlanGGWP", model.PlanGGWP, DbType.Decimal);
                parameters.Add("@PlanDeductions", model.PlanDeductions, DbType.Decimal);
                parameters.Add("@PlanGNWP", model.PlanGNWP, DbType.Decimal);
                parameters.Add("@PlanEU", model.PlanEU, DbType.Decimal);

                // Written
                parameters.Add("@WrittenGGWP", model.WrittenGGWP, DbType.Decimal);
                parameters.Add("@WrittenDeductions", model.WrittenDeductions, DbType.Decimal);
                parameters.Add("@WrittenGNWP", model.WrittenGNWP, DbType.Decimal);
                parameters.Add("@WrittenEU", model.WrittenEU, DbType.Decimal);

                // Signed
                parameters.Add("@SignedGGWP", model.SignedGGWP, DbType.Decimal);
                parameters.Add("@SignedDeductions", model.SignedDeductions, DbType.Decimal);
                parameters.Add("@SignedGNWP", model.SignedGNWP, DbType.Decimal);
                parameters.Add("@SignedEU", model.SignedEU, DbType.Decimal);

                await connection.ExecuteAsync(
                    "Ultimates.spUpsertUltimatePremiumCurrency",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                _logger.LogInformation("Successfully saved PremiumCcy for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}, Version={Version}, Currency={Currency}",
                    model.Class, model.ReservingClass, model.YOA, model.Version, model.Currency);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error saving PremiumCcy for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}, Version={Version}, Currency={Currency}",
                    model.Class, model.ReservingClass, model.YOA, model.Version, model.Currency);
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

        /// <summary>
        /// Get PremiumCcy records for a specific Premium record
        /// </summary>
        public async Task<IEnumerable<PremiumCcyModel>> GetPremiumCcy(string className, string reservingClass, int yoa, int version)
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var sql = @"
                    SELECT
                        Class,
                        ReservingClass,
                        YOA,
                        Version,
                        Currency,
                        SelectedGGWP,
                        SelectedDeductions,
                        SelectedGNWP,
                        SelectedEU,
                        ManualGGWP,
                        ManualDeductions,
                        ManualGNWP,
                        ManualEU,
                        PlanGGWP,
                        PlanDeductions,
                        PlanGNWP,
                        PlanEU,
                        WrittenGGWP,
                        WrittenDeductions,
                        WrittenGNWP,
                        WrittenEU,
                        SignedGGWP,
                        SignedDeductions,
                        SignedGNWP,
                        SignedEU
                    FROM Ultimates.PremiumCcy
                    WHERE Class = @Class
                      AND ReservingClass = @ReservingClass
                      AND YOA = @YOA
                      AND Version = @Version
                    ORDER BY Currency";

                var result = await connection.QueryAsync<PremiumCcyModel>(sql, new
                {
                    Class = className,
                    ReservingClass = reservingClass,
                    YOA = yoa,
                    Version = version
                });

                return result ?? Enumerable.Empty<PremiumCcyModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving PremiumCcy for Class={Class}, ReservingClass={ReservingClass}, YOA={YOA}, Version={Version}",
                    className, reservingClass, yoa, version);
                throw;
            }
        }

        /// <summary>
        /// Get all Reserving Classes with their display names
        /// </summary>
        public async Task<IEnumerable<ReservingClassModel>> GetReservingClasses()
        {
            try
            {
                using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
                await connection.OpenAsync();

                var result = await connection.QueryAsync<ReservingClassModel>(
                    "Ultimates.spGetListReservingClass",
                    commandType: CommandType.StoredProcedure
                );

                return result ?? Enumerable.Empty<ReservingClassModel>();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error retrieving Reserving Classes");
                throw;
            }
        }

		public async Task<long> GetNextWatchlistIdAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QuerySingleAsync<long>(
				"[Ultimates].[spWatchlist_GetNextID]",
				commandType: CommandType.StoredProcedure);
		}

		public async Task AddWatchlistItemAsync(WatchlistItem watchlistItem)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			await db.ExecuteAsync(
				"[Ultimates].[spWatchlist_Add]",
				new
				{
					watchlistItem.WatchlistID,
					watchlistItem.TeamMember,
					watchlistItem.WatchlistType,
					watchlistItem.PolicyReference,
					watchlistItem.UCR,
					watchlistItem.COR,
					watchlistItem.DOL,
					watchlistItem.WLCode,
					watchlistItem.Claimant,
					watchlistItem.LossType,
					watchlistItem.WatchlistDescription,
					watchlistItem.InLitigation,
					watchlistItem.Jurisdiction,
					watchlistItem.IsActive
				},
				commandType: CommandType.StoredProcedure);
		}

		public async Task AddWatchlistUpdateAsync(WatchlistUpdate update)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			await db.ExecuteAsync(
				"[Ultimates].[spWatchlistUpdates_Add]",
				new
				{
					update.WatchlistID,
					update.UpdatedBy,
					update.UpdateDate,
					update.IsChaser,
					update.IsUpdate,
					update.ReservingConfidenceRating,
					update.IBNRRecommended,
					update.DaleShareUltimateUSD,
					update.RIApplicable,
					update.UpdateNarrative,
					update.Probability
				},
				commandType: CommandType.StoredProcedure);
		}

		public async Task<IEnumerable<WatchlistWithLatestUpdate>> GetWatchlistWithLatestUpdateAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<WatchlistWithLatestUpdate>(
				"[Ultimates].[spWatchlist_GetAllWithLatestUpdate]",
				commandType: CommandType.StoredProcedure);
		}

		public async Task<IEnumerable<WatchlistUpdate>> GetWatchlistUpdatesByIdAsync(long watchlistId)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<WatchlistUpdate>(
				"[Ultimates].[spWatchlistUpdates_GetByWatchlistID]",
				new { WatchlistID = watchlistId },
				commandType: CommandType.StoredProcedure);
		}
    }
}
