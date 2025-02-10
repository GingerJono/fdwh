using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;
using System.Text;
using System.Web;
using Sandbox.Helpers;
using Microsoft.Extensions.Logging;
using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Sandbox.Models.RiskReview;

namespace Sandbox.Services
{
	public class RiskReviewService
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<ReservingService> _logger;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public RiskReviewService(IConfiguration configuration, ILogger<ReservingService> logger, IHttpContextAccessor httpContextAccessor)
		{
			_configuration = configuration;
			_logger = logger;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<List<RiskReviewModel>> GetRiskReviewListAsync()
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				var riskReviews = await db.QueryAsync<RiskReviewModel>("[RiskReview].[spGetRiskReviewList]", commandType: CommandType.StoredProcedure);
				return riskReviews.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task<List<CompletedRiskReviewModel>> GetCompletedRiskReviewsListAsync()
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				var riskReviews = await db.QueryAsync<CompletedRiskReviewModel>("[RiskReview].[spGetCompletedRiskReviewsList]", commandType: CommandType.StoredProcedure);
				return riskReviews.ToList();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<RiskReviewModel> GetRiskReviewAsync(int id)
		{
			var parameters = new DynamicParameters();
			parameters.Add("@RiskReviewID", id, DbType.Int32);
			try
			{
				using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				await connection.OpenAsync();

				var riskReview = await connection.QuerySingleOrDefaultAsync<RiskReviewModel>("[RiskReview].[spGetRiskReviewDetail]", parameters, commandType: CommandType.StoredProcedure);

				// Decode the sanitized input
				riskReview.ProgramRef = InputSanitizer.UnsanitizeHtml(riskReview.ProgramRef);
				riskReview.ReviewerNarrative = InputSanitizer.UnsanitizeHtml(riskReview.ReviewerNarrative);
				riskReview.AUWNarrative = InputSanitizer.UnsanitizeHtml(riskReview.AUWNarrative);

				// Fetch associated policies
				var policies = await connection.QueryAsync<Policy>("RiskReview.spGetRiskReviewPolicies", parameters, commandType: CommandType.StoredProcedure);
				riskReview.Policies = policies.ToList();

				// Query for metadata
				var metadataRow = await connection.QueryFirstAsync<dynamic>(
					"[RiskReview].[spGetRiskReviewMetadata]",
					parameters,
					commandType: CommandType.StoredProcedure);

				// Convert metadata to dictionary
				var metadataDict = new Dictionary<string, string>();
				foreach (var pair in metadataRow)
				{
					metadataDict.Add(pair.Key, pair.Value != null ? pair.Value.ToString() : "");
				}
				riskReview.Metadata = metadataDict;

				return riskReview;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
	
		public async Task EditRiskReview(RiskReviewModel model)
		{
			// Access the HttpContext from IHttpContextAccessor
			var context = _httpContextAccessor.HttpContext;

			// must repeat logic from ViewStart in here
			var userNameOverride = _httpContextAccessor.HttpContext?.Items["UserNameOverride"] as string;
			string userNameFinal = string.IsNullOrEmpty(userNameOverride) ? context?.User?.Identity?.Name ?? "" : userNameOverride;

			// THIS GETS INVOKED from the CONTROLLER!

			// Sanitize the input
			string reviewernarrative = InputSanitizer.SanitizeHtml(model.ReviewerNarrative ?? "");
			string auwnarrative = InputSanitizer.SanitizeHtml(model.AUWNarrative ?? "");
			string commissionOKNote = InputSanitizer.SanitizeHtml(model.CommissionOKNote ?? "");
			string withinScopeOfSBFProtocolsGuidelinesNote = InputSanitizer.SanitizeHtml(model.WithinScopeOfSBFProtocolsGuidelinesNote ?? "");
			string clearUnderwritingRationaleNote = InputSanitizer.SanitizeHtml(model.ClearUnderwritingRationaleNote ?? "");
			string premiumSufficientNote = InputSanitizer.SanitizeHtml(model.PremiumSufficientNote ?? "");
			string natureOfRiskNote = InputSanitizer.SanitizeHtml(model.NatureOfRiskNote ?? "");
			string numberOfReinstAggCoverOKNote = InputSanitizer.SanitizeHtml(model.NumberOfReinstAggCoverOKNote ?? "");
			string rateMovementSensibleNote = InputSanitizer.SanitizeHtml(model.RateMovementSensibleNote ?? "");
			string progFitWithORINote = InputSanitizer.SanitizeHtml(model.ProgFitWithORINote ?? "");
			string coverIssuesNote = InputSanitizer.SanitizeHtml(model.CoverIssuesNote ?? "");
			string signedOffNote = InputSanitizer.SanitizeHtml(model.SignedOffNote ?? "");

			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				var cmd = new SqlCommand("[RiskReview].[spUpdateRiskReview]", db)
				{
					CommandType = CommandType.StoredProcedure
				};
				cmd.Parameters.Add(new SqlParameter("@RiskReviewID", SqlDbType.BigInt) { Value = model.RiskReviewID });
				cmd.Parameters.Add(new SqlParameter("@ReviewerNarrative", SqlDbType.NVarChar) { Value = reviewernarrative });
				cmd.Parameters.Add(new SqlParameter("@AUWNarrative", SqlDbType.NVarChar) { Value = auwnarrative });

				// The bool fields
				cmd.Parameters.Add(new SqlParameter("@CommissionOK", SqlDbType.Bit) { Value = model.CommissionOK });
				cmd.Parameters.Add(new SqlParameter("@WithinScopeOfSBFProtocolsGuidelines", SqlDbType.Bit) { Value = model.WithinScopeOfSBFProtocolsGuidelines });
				cmd.Parameters.Add(new SqlParameter("@ClearUnderwritingRationale", SqlDbType.Bit) { Value = model.ClearUnderwritingRationale });
				cmd.Parameters.Add(new SqlParameter("@PremiumSufficient", SqlDbType.Bit) { Value = model.PremiumSufficient });
				cmd.Parameters.Add(new SqlParameter("@NatureOfRisk", SqlDbType.Bit) { Value = model.NatureOfRisk });
				cmd.Parameters.Add(new SqlParameter("@NumberOfReinstAggCoverOK", SqlDbType.Bit) { Value = model.NumberOfReinstAggCoverOK });
				cmd.Parameters.Add(new SqlParameter("@RateMovementSensible", SqlDbType.Bit) { Value = model.RateMovementSensible });
				cmd.Parameters.Add(new SqlParameter("@ProgFitWithORI", SqlDbType.Bit) { Value = model.ProgFitWithORI });
				cmd.Parameters.Add(new SqlParameter("@CoverIssues", SqlDbType.Bit) { Value = model.CoverIssues });
				cmd.Parameters.Add(new SqlParameter("@SignedOff", SqlDbType.Bit) { Value = model.SignedOff });

				// The Note fields
				cmd.Parameters.Add(new SqlParameter("@CommissionOKNote", SqlDbType.NVarChar) { Value = commissionOKNote });
				cmd.Parameters.Add(new SqlParameter("@WithinScopeOfSBFProtocolsGuidelinesNote", SqlDbType.NVarChar) { Value = withinScopeOfSBFProtocolsGuidelinesNote });
				cmd.Parameters.Add(new SqlParameter("@ClearUnderwritingRationaleNote", SqlDbType.NVarChar) { Value = clearUnderwritingRationaleNote });
				cmd.Parameters.Add(new SqlParameter("@PremiumSufficientNote", SqlDbType.NVarChar) { Value = premiumSufficientNote });
				cmd.Parameters.Add(new SqlParameter("@NatureOfRiskNote", SqlDbType.NVarChar) { Value = natureOfRiskNote });
				cmd.Parameters.Add(new SqlParameter("@NumberOfReinstAggCoverOKNote", SqlDbType.NVarChar) { Value = numberOfReinstAggCoverOKNote });
				cmd.Parameters.Add(new SqlParameter("@RateMovementSensibleNote", SqlDbType.NVarChar) { Value = rateMovementSensibleNote });
				cmd.Parameters.Add(new SqlParameter("@ProgFitWithORINote", SqlDbType.NVarChar) { Value = progFitWithORINote });
				cmd.Parameters.Add(new SqlParameter("@CoverIssuesNote", SqlDbType.NVarChar) { Value = coverIssuesNote });
				cmd.Parameters.Add(new SqlParameter("@SignedOffNote", SqlDbType.NVarChar) { Value = signedOffNote });
				cmd.Parameters.Add(new SqlParameter("@LastUpdater", SqlDbType.NVarChar) { Value = userNameFinal });

				db.Open();
				await cmd.ExecuteNonQueryAsync();

				foreach (var policy in model.Policies)
				{
					var cmd2 = new SqlCommand("[RiskReview].[spUpdateRiskReviewPolicy]", db)
					{
						CommandType = CommandType.StoredProcedure
					};

					string Narrative = InputSanitizer.SanitizeHtml(policy.Narrative ?? "");

					cmd2.Parameters.Add(new SqlParameter("@RiskReviewID", SqlDbType.Int) { Value = model.RiskReviewID });
					cmd2.Parameters.Add(new SqlParameter("@PolicyRef", SqlDbType.NVarChar, 50) { Value = policy.PolicyRef });
					cmd2.Parameters.Add(new SqlParameter("@Narrative", SqlDbType.NVarChar, -1) { Value = Narrative ?? (object)DBNull.Value });
					cmd2.Parameters.Add(new SqlParameter("@RiskReviewStatus", SqlDbType.NVarChar, 50) { Value = policy.RiskReviewStatus });
					cmd2.Parameters.Add(new SqlParameter("@RiskReviewScore", SqlDbType.Int) { Value = policy.RiskReviewScore ?? (object)DBNull.Value });
					cmd2.Parameters.Add(new SqlParameter("@LastUpdater", SqlDbType.NVarChar) { Value = userNameFinal });


					await cmd2.ExecuteNonQueryAsync();
				}

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task SetMultiRiskReviewsToNotReviewing(string riskReviewIDs)
		{
			// var Username = "test user";
			// Ensure that you have the necessary inputs
			if (string.IsNullOrEmpty(riskReviewIDs))
			{
				throw new ArgumentException("riskReviewIDs must be provided.");
			}

			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				var cmd = new SqlCommand("[RiskReview].[spSetMultiRiskReviewsToNotReviewing]", db)
				{
					CommandType = CommandType.StoredProcedure
				};

				// Add parameters for the stored procedure
				cmd.Parameters.Add(new SqlParameter("@RiskReviewIDs", SqlDbType.NVarChar, -1) { Value = riskReviewIDs }); // Assuming the stored procedure takes the ProgramRefs as nvarchar(max)
				// cmd.Parameters.Add(new SqlParameter("@LastUpdater", SqlDbType.NVarChar, 50) { Value = Username }); // Assuming the stored procedure takes the Username as nvarchar(50)

				db.Open();
				await cmd.ExecuteNonQueryAsync();
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method SetMultiRiskReviewsToNotReviewing.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task<List<Dictionary<string, object>>> GetRiskReviewDocuments(int _riskReviewID)
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewDocuments",
					new { RiskReviewID = _riskReviewID }
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task<List<Dictionary<string, object>>> GetRiskReviewPolicyInfo(int _riskReviewID)
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewPolicyInfo",
					new { RiskReviewID = _riskReviewID }
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task<List<Dictionary<string, object>>> GetRiskReviewProgramNotes(int _riskReviewID)
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewProgramNotes",
					new { RiskReviewID = _riskReviewID }
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewProgramHistory(int _riskReviewID)
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewProgramHistory",
					new { RiskReviewID = _riskReviewID }
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewFlagging(int _riskReviewID)
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewFlagging",
					new { RiskReviewID = _riskReviewID }
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewSummaryByYOA()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewSummaryByYOA"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewSummaryByClassThisYOA()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewSummaryByClassThisYOA"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewSummaryByReservingClassThisYOA()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewSummaryByReservingClassThisYOA"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewSummaryByUWThisYOA()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewSummaryByUWThisYOA"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		public async Task<List<Dictionary<string, object>>> GetRiskReviewFlaggingSummaryByClassThisYOA()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewFlaggingSummaryByClassThisYOA"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}
		public async Task<List<Dictionary<string, object>>> GetRiskReviewFlaggingCriteriaByClass()
		{
			try
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"RiskReview.spGetRiskReviewFlaggingCriteriaByClass"
				);

			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}


		// method for Headers - put everything into viewbag
		public Dictionary<string, string> GetProgramHeaderKeyValuePairs(int id)
		{
			return SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"RiskReview.spGetRiskReviewProgramHeader",
				new { RiskReviewID = id }
			);
		}
	}
}