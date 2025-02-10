using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Sandbox.Models;
using System.Data;
using System.Text;
using System.Web;
using Sandbox.Helpers;
using Sandbox.Models.Reserving;
using System.Configuration;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sandbox.Models.Reserving.Types;
using Sandbox.Models.Reserving.DataExtracts;
using Azure.Identity;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Security.Cryptography;

namespace Sandbox.Services
{
	public class ReservingService
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<ReservingService> _logger;
		private readonly IHttpContextAccessor _httpContextAccessor;
		public bool _isOfflineMode;

		public ReservingService(IConfiguration configuration, ILogger<ReservingService> logger, IHttpContextAccessor httpContextAccessor)
		{
			_configuration = configuration;
			_isOfflineMode = configuration.GetValue<bool>("IsOfflineMode");
			_logger = logger;
			_httpContextAccessor = httpContextAccessor;
		}

		// get list of info for SELECTIONS page
		public IEnumerable<SelectionsListModel> GetAllReservingSelections(int reservingHeaderID)
		{
			try
			{
				var parameters = new DynamicParameters();
				parameters.Add("@ReservingHeaderID", reservingHeaderID);

				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				return db.Query<SelectionsListModel>("Reserving.spGetAllSelections", parameters, commandType: CommandType.StoredProcedure);
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}

		}

		// gets SELECTION info for EditSelections page (Returns MODEL)
		public SelectionsModel GetSelectionByKeys(int reservingHeaderID, string Class, string reservingClass, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@Class", Class);
					parameters.Add("@ReservingClass", reservingClass);
					parameters.Add("@YOA", yoa);

					var result = db.QueryFirstOrDefault<SelectionsModel>(
						"[Reserving].[spGetSelectionForEdit]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);
					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		// gets STATUS info when ID is provided
		public StatusModel GetStatusByKeys(int reservingHeaderID)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);

					var result = db.QueryFirstOrDefault<StatusModel>(
						"[Reserving].[spGetReservingHeaderStatus]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);
					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method spGetStatusForEdit.");
				throw; // rethrow the exception after logging
			}
		}

		// gets SELECTION info for EditSelections page (Returns MODEL)
		public async Task<IEnumerable<StatusModel>> GetReservingHeaderList()
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();

					var result = await db.QueryAsync<StatusModel>(
						"[Reserving].[spGetAllReservingHeaders]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);
					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method spGetStatusForEdit.");
				throw; // rethrow the exception after logging
			}
		}

		// gets SELECTION CURRENCY LEVEL info for EditSelections page (e.g. Premiums at Ccy level and so on)
		public IEnumerable<SelectionCurrencyData> GetSelectionCurrencyByKeys(int reservingHeaderID, string Class, string reservingClass, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@Class", Class);
					parameters.Add("@ReservingClass", reservingClass);
					parameters.Add("@YOA", yoa);

					var result = db.Query<SelectionCurrencyData>(
						"[Reserving].[spGetSelectionCurrencyForEdit]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);

					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}

		}

		// gets SPECIFIC LOSS info for EditSelections page
		public IEnumerable<SpecificLossData> GetSpecificLossesByKeys(int reservingHeaderID, string Class, string reservingClass, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@Class", Class);
					parameters.Add("@ReservingClass", reservingClass);
					parameters.Add("@YOA", yoa);

					var result = db.Query<SpecificLossData>(
						"[Reserving].[spGetSpecificLossesForEdit]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);

					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}

		}

		// gets SPECIFIC LOSS BY CURRENCY info for EditSelections page
		public IEnumerable<SpecificLossCurrencyData> GetSpecificLossesCurrencyByKeys(int reservingHeaderID, string Class, string reservingClass, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@Class", Class);
					parameters.Add("@ReservingClass", reservingClass);
					parameters.Add("@YOA", yoa);

					var result = db.Query<SpecificLossCurrencyData>(
						"[Reserving].[spGetSpecificLossesCurrencyForEdit]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);

					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}

		// gets SPECIFIC LOSS info for EditSelections page
		public IEnumerable<SpecificLossData> GetSpecificLossesForReservingHeader(int reservingHeaderID)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);

					var result = db.Query<SpecificLossData>(
						"[Reserving].[spGetSpecificLossesForEdit]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);
					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}
		}



		// gets OUTPUTS AT CLASS-YOA LEVEL info for comparison purposes
		public IEnumerable<OutputsCYCurrencyData> GetOutputsCYCurrencyDataByKeys(int reservingHeaderID, string Class, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@Class", Class);
					parameters.Add("@YOA", yoa);

					var result = db.Query<OutputsCYCurrencyData>(
						"[Reserving].[spGetOutputsCYForComparison]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);

					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}

		}


		// gets OUTPUTS AT CLASS-YOA LEVEL info for comparison purposes
		public IEnumerable<OutputsCYCurrencyData> GetOutputsYCurrencyDataByKeys(int reservingHeaderID, string Class, int yoa)
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ReservingHeaderID", reservingHeaderID);
					parameters.Add("@YOA", yoa);

					var result = db.Query<OutputsCYCurrencyData>(
						"[Reserving].[spGetOutputsYForComparison]",  // Assuming you have this SP for fetching by keys
						parameters,
						commandType: CommandType.StoredProcedure
					);

					return result;
				}
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method XYZ.");
				throw; // rethrow the exception after logging
			}

		}

		// WRITES BACK to the database on EditSelections page

		// 3 methods, one per SP:

		public async Task LogChange(SqlConnection db, SqlTransaction transaction, SelectionsModel model, string modelJSON, string modelBeforeChangesJSON)
		{
			// Access the HttpContext from IHttpContextAccessor
			var context = _httpContextAccessor.HttpContext;

			// must repeat logic from ViewStart in here
			var userNameOverride = _httpContextAccessor.HttpContext?.Items["UserNameOverride"] as string;
			string userNameFinal = string.IsNullOrEmpty(userNameOverride) ? context?.User?.Identity?.Name ?? "" : userNameOverride;

			var parameters = new DynamicParameters();
			parameters.Add("@ReservingHeaderID", model.ReservingHeaderID);
			parameters.Add("@Class", model.Class);
			parameters.Add("@ReservingClass", model.ReservingClass);
			parameters.Add("@YOA", model.YOA);
			parameters.Add("@ChangedBy", userNameFinal);

			// Additional parameters specific to LOGGING
			parameters.Add("@modelJSON", modelJSON);
			parameters.Add("@modelBeforeChangesJSON", modelBeforeChangesJSON);

			await db.ExecuteAsync(
				"[Reserving].[spApplicationLogChange]",
				parameters,
				commandType: CommandType.StoredProcedure,
				transaction: transaction
			);
		}

		public async Task SaveSelections(SqlConnection db, SqlTransaction transaction, SelectionsModel model)
		{
			var parameters = new DynamicParameters();
			parameters.Add("@ReservingHeaderID", model.ReservingHeaderID);
			parameters.Add("@Class", model.Class);
			parameters.Add("@ReservingClass", model.ReservingClass);
			parameters.Add("@YOA", model.YOA);

			// Additional parameters specific to SELECTIONS
			parameters.Add("@GrossWrittenPremiumSelection", model.UltimateGGWPSelection);
			parameters.Add("@NCBPCSwingSelection", model.NCBPCSwingSelection);
			parameters.Add("@InwardsRIPsSelection", model.InwardsRIPsSelection);
			parameters.Add("@DeductionsSelection", model.DeductionsSelection);
			parameters.Add("@InwardsRIPsSetPercentageOfClaims", model.InwardsRIPsSetPercentageOfClaims);
			parameters.Add("@DeductionsSetPercentage", model.DeductionsSetPercentage);
			parameters.Add("@UltimateLossRatioSelection", model.UltimateLossRatioSelection);
			parameters.Add("@UltimateLossRatioSetValue", model.UltimateLossRatioSetValue);
			parameters.Add("@UnearnedLossRatioSetValue", model.UnearnedLossRatioSetValue);
			parameters.Add("@NonSpecificIBNRCatSplit", model.NonSpecificIBNRCatSplit);
			parameters.Add("@NonSpecificIBNRLargeSplit", model.NonSpecificIBNRLargeSplit);
			parameters.Add("@NonSpecificIBNRAttritionalSplit", model.NonSpecificIBNRAttritionalSplit);

			// Additional parameters specific to OUTPUTS
			parameters.Add("@GGILR", model.GGILR);
			parameters.Add("@GNILR", model.GNILR);
			parameters.Add("@GGULR", model.GGULR);
			parameters.Add("@GNULR", model.GNULR);
			parameters.Add("@GGELR", model.GGELR);
			parameters.Add("@GNELR", model.GNELR);

			// Execute the command
			// command.ExecuteNonQuery(); // Uncomment this line to execute the command


			await db.ExecuteAsync(
				"[Reserving].[spEditSelectionDetails]",
				parameters,
				commandType: CommandType.StoredProcedure,
				transaction: transaction
			);
		}

		public async Task SaveSelectionsByCurrency(SqlConnection db, SqlTransaction transaction, SelectionsModel model)
		{
			foreach (SettCcyEnum ccy in Enum.GetValues(typeof(SettCcyEnum)))
			{
				var parameters = new DynamicParameters();
				// Common parameters
				parameters.Add("@ReservingHeaderID", model.ReservingHeaderID);
				parameters.Add("@Class", model.Class);
				parameters.Add("@ReservingClass", model.ReservingClass);
				parameters.Add("@YOA", model.YOA);

				// Additional parameters specific to SELECTIONS BY CURRENCY
				parameters.Add("@SettCcy", ccy.ToString());  // Convert enum to string
				parameters.Add("@GrossWrittenPremiumSetValue", model.UltimateGGWPSetValue.SetValues[ccy].Value);
				parameters.Add("@NCBPCSwingSetValue", model.NCBPCSwingSetValue.SetValues[ccy].Value);
				parameters.Add("@InwardsRIPsSetValue", model.InwardsRIPsSetValue.SetValues[ccy].Value);

				// Additional parameters specific to OUTPUTS
				parameters.Add("@UltimateGGWP", model.UltimateGGWP[ccy].Value);
				parameters.Add("@UltimateDeductions", model.UltimateDeductions);
				parameters.Add("@UltimateGNWP", model.UltimateGNWP[ccy].Value);
				parameters.Add("@UltimateInwardsRIPs", model.UltimateInwardsRIPs[ccy].Value);
				parameters.Add("@UltimateNCBPCSwing", model.UltimateNCBPCSwing[ccy].Value);
				parameters.Add("@UltimateLossRatio", model.UltimateLossRatio);
				parameters.Add("@UnwrittenGGWP", model.UnwrittenGGWP[ccy].Value);
				parameters.Add("@UnwrittenGNWP", model.UnwrittenGNWP[ccy].Value);
				parameters.Add("@EarnedGGWP", model.EarnedGGWP[ccy].Value);
				parameters.Add("@EarnedGNWP", model.EarnedGNWP[ccy].Value);
				parameters.Add("@UnearnedGGWP", model.UnearnedGGWP[ccy].Value);
				parameters.Add("@UnearnedGNWP", model.UnearnedGNWP[ccy].Value);
				parameters.Add("@SpecificUltimateRIPs", model.SpecificUltimateRIPs[ccy].Value);
				parameters.Add("@SpecificUltimateRIPsCat", model.SpecificUltimateRIPsCat[ccy].Value);
				parameters.Add("@SpecificUltimateRIPsLarge", model.SpecificUltimateRIPsLarge[ccy].Value);
				parameters.Add("@FutureRIPs", model.FutureRIPs[ccy].Value);
				parameters.Add("@WrittenDeductions", model.WrittenDeductions);
				parameters.Add("@PlanDeductions", model.PlanDeductions);
				parameters.Add("@SpecificUltimateClaims", model.SpecificUltimateClaims[ccy].Value);
				parameters.Add("@SpecificIncurredClaims", model.SpecificIncurredClaims[ccy].Value);
				parameters.Add("@SpecificUltimateClaimsCat", model.SpecificUltimateClaimsCat[ccy].Value);
				parameters.Add("@SpecificIncurredClaimsCat", model.SpecificIncurredClaimsCat[ccy].Value);
				parameters.Add("@SpecificUltimateClaimsLarge", model.SpecificUltimateClaimsLarge[ccy].Value);
				parameters.Add("@SpecificIncurredClaimsLarge", model.SpecificIncurredClaimsLarge[ccy].Value);
				parameters.Add("@TotalUltimateClaims", model.TotalUltimateClaims[ccy].Value);
				parameters.Add("@TotalPaidExLF", model.TotalPaidExLF[ccy].Value);
				parameters.Add("@TotalLF", model.TotalLF[ccy].Value);
				parameters.Add("@TotalPaid", model.TotalPaid[ccy].Value);
				parameters.Add("@TotalOS", model.TotalOS[ccy].Value);
				parameters.Add("@TotalIncurred", model.TotalIncurred[ccy].Value);
				parameters.Add("@TotalIBNR", model.TotalIBNR[ccy].Value);
				parameters.Add("@SpecificIBNR", model.SpecificIBNR[ccy].Value);
				parameters.Add("@NonSpecificIBNR", model.NonSpecificIBNR[ccy].Value);
				parameters.Add("@PaidCat", model.PaidCat[ccy].Value);
				parameters.Add("@IncurredCat", model.IncurredCat[ccy].Value);
				parameters.Add("@SpecificIBNRCat", model.SpecificIBNRCat[ccy].Value);
				parameters.Add("@NonSpecificIBNRCat", model.NonSpecificIBNRCat[ccy].Value);
				parameters.Add("@IBNRCat", model.IBNRCat[ccy].Value);
				parameters.Add("@UltimateCat", model.UltimateCat[ccy].Value);
				parameters.Add("@EarnedCatClaims", model.EarnedCatClaims[ccy].Value);
				parameters.Add("@PaidLarge", model.PaidLarge[ccy].Value);
				parameters.Add("@IncurredLarge", model.IncurredLarge[ccy].Value);
				parameters.Add("@SpecificIBNRLarge", model.SpecificIBNRLarge[ccy].Value);
				parameters.Add("@NonSpecificIBNRLarge", model.NonSpecificIBNRLarge[ccy].Value);
				parameters.Add("@IBNRLarge", model.IBNRLarge[ccy].Value);
				parameters.Add("@UltimateLarge", model.UltimateLarge[ccy].Value);
				parameters.Add("@EarnedLargeClaims", model.EarnedLargeClaims[ccy].Value);
				parameters.Add("@PaidAttr", model.PaidAttr[ccy].Value);
				parameters.Add("@IncurredAttr", model.IncurredAttr[ccy].Value);
				parameters.Add("@IBNRAttr", model.IBNRAttr[ccy].Value);
				parameters.Add("@UltimateAttr", model.UltimateAttr[ccy].Value);
				parameters.Add("@EarnedClaims", model.EarnedClaims[ccy].Value);
				parameters.Add("@IBNRandLF", model.IBNRandLF[ccy].Value);

				await db.ExecuteAsync(
					"[Reserving].[spEditSelectionCurrencyDetails]",
					parameters,
					commandType: CommandType.StoredProcedure,
					transaction: transaction
				);
			}
		}

		public async Task SaveSpecificLosses(SqlConnection db, SqlTransaction transaction, SelectionsModel model)
		{
			// First, delete all specific losses associated with the ReservingHeaderID
			var deleteParameters = new DynamicParameters();
			deleteParameters.Add("@ReservingHeaderID", model.ReservingHeaderID);
			deleteParameters.Add("@Class", model.Class);
			deleteParameters.Add("@ReservingClass", model.ReservingClass);
			deleteParameters.Add("@YOA", model.YOA);
			await db.ExecuteAsync(
				"[Reserving].[spDeleteSpecificLossRCY]",
				deleteParameters,
				commandType: CommandType.StoredProcedure,
				transaction: transaction
			);

			foreach (var specificLoss in model.SpecificLosses)
			{
				var parameters = new DynamicParameters();
				// Common parameters
				parameters.Add("@ReservingHeaderID", specificLoss.ReservingHeaderID);
				parameters.Add("@Class", specificLoss.Class);
				parameters.Add("@ReservingClass", specificLoss.ReservingClass);
				parameters.Add("@YOA", specificLoss.YOA);
				parameters.Add("@Event", specificLoss.Event);
				parameters.Add("@EventType", specificLoss.EventType);
				parameters.Add("@UltimateClaimsSelection", specificLoss.UltimateClaimsSelection);
				parameters.Add("@UltimateRIPsSelection", specificLoss.UltimateRIPsSelection);
				parameters.Add("@UltimateRIPsSetPercentageOfClaims", specificLoss.UltimateRIPsSetPercentageOfClaims);
				parameters.Add("@UltimateClaims", 0); // to-do - should be SUM of UltimateClaims
				parameters.Add("@UltimateRIPs", 0); // to-do - should be SUM of UltimateClaims

				await db.ExecuteAsync(
					"[Reserving].[spInsertSpecificLossDetails]",
					parameters,
					commandType: CommandType.StoredProcedure,
					transaction: transaction
				);

				foreach (SettCcyEnum ccy in Enum.GetValues(typeof(SettCcyEnum)))
				{
					var parametersToRemove = new List<string> { "EventType", "UltimateClaims", "UltimateRIPs", "UltimateClaimsSelection", "UltimateRIPsSelection", "UltimateRIPsSetPercentageOfClaims" };
					var parametersCcy = new DynamicParameters();

					// build up parametersCcy with all but the 3 quoted Params
					foreach (var paramName in parameters.ParameterNames)
					{
						if (!parametersToRemove.Contains(paramName))
						{
							var paramValue = parameters.Get<object>(paramName);
							parametersCcy.Add(paramName, paramValue);
						}
					}

					parametersCcy.Add("@SettCcy", ccy.ToString());
					parametersCcy.Add("@UltimateClaimsSetValue", specificLoss.UltimateClaimsSetValue.SetValues[ccy].Value);
					parametersCcy.Add("@UltimateRIPsSetValue", specificLoss.UltimateRIPsSetValue.SetValues[ccy].Value);
					parametersCcy.Add("@UltimateClaims", specificLoss.UltimateClaims[ccy].Value);
					parametersCcy.Add("@UltimateRIPs", specificLoss.UltimateRIPs[ccy].Value);

					await db.ExecuteAsync(
						"[Reserving].[spInsertSpecificLossDetailsCurrency]",
						parametersCcy,
						commandType: CommandType.StoredProcedure,
						transaction: transaction
					);
				}
			}
		}

		public async Task SaveHeader(SqlConnection db, SqlTransaction transaction, SelectionsModel model)
		{
			var parameters = new DynamicParameters();
			parameters.Add("@ReservingHeaderID", model.ReservingHeaderID);
			parameters.Add("@Editor", "editor");
			await db.ExecuteAsync(
					"[Reserving].[spEditHeader]",
					parameters,
					commandType: CommandType.StoredProcedure,
					transaction: transaction
				);
		}

		public async Task UpdateSelection(SelectionsModel model, SelectionsModel modelBeforeChanges)
		{
			string modelJSON = JsonSerializer.Serialize(model, new JsonSerializerOptions { WriteIndented = true });
			string modelBeforeChangesJSON = JsonSerializer.Serialize(modelBeforeChanges, new JsonSerializerOptions { WriteIndented = true });

			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			{
				if (db.State == ConnectionState.Closed)
				{
					db.Open();
				}
				// Start a transaction
				using var transaction = db.BeginTransaction();
				try
				{
					// await LogChange(db, transaction, model, modelJSON, modelBeforeChangesJSON); // full logging - turned off at the moment due to size constraints
					await LogChange(db, transaction, model, "", ""); // light logging - not logging full model just for size constraints
					await SaveSelections(db, transaction, model);
					await SaveSelectionsByCurrency(db, transaction, model);
					await SaveSpecificLosses(db, transaction, model);
					await SaveHeader(db, transaction, model);

					// Commit transaction if all commands succeed
					transaction.Commit();
				}
				catch
				{
					// Rollback transaction if any command fails
					transaction.Rollback();
					throw;
				}
			}
		}

		public async Task<IEnumerable<SpecificLossEventDropDownModel>> GetEventsDropdownItemsAsync()
		{
			var items = new List<SpecificLossEventDropDownModel>();

			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				// Use QueryAsync and await the operation, then convert the result to a list
				var result = await db.QueryAsync<SpecificLossEventDropDownModel>("Reserving.spGetEventListForDropDown", commandType: CommandType.StoredProcedure);
				items = result.ToList(); // Convert the result to a List
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method Reserving.spGetEventListForDropDown.");
				throw; // rethrow the exception after logging
			}

			return items; // Return the populated list
		}
		public async Task<IEnumerable<SpecificLossEventTypeDropDownModel>> GetEventTypesDropdownItemsAsync()
		{
			var items = new List<SpecificLossEventTypeDropDownModel>();

			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				// Use QueryAsync and await the operation, then convert the result to a list
				var result = await db.QueryAsync<SpecificLossEventTypeDropDownModel>("Reserving.spGetEventTypeListForDropDown", commandType: CommandType.StoredProcedure);
				items = result.ToList(); // Convert the result to a List
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while executing method Reserving.spGetEventTypeListForDropDown.");
				throw; // rethrow the exception after logging
			}

			return items; // Return the populated list
		}

		// GET FX rates from Database
		public Dictionary<SettCcyEnum, double> GetFXRates()
		{
			// Placeholder: Retrieve the FX rates from your database or external source
			// The returned dictionary should look something like:
			// { { SettCcyEnum.JPY, 1.23 }, { SettCcyEnum.GBP, 1.0 }, ... }

			// For demonstration purposes, let's use a static dictionary:
			return new Dictionary<SettCcyEnum, double>
			{
				{ SettCcyEnum.JPY, 175.75 },
				{ SettCcyEnum.GBP, 1.0 },
				{ SettCcyEnum.CAD, 1.31 },
				{ SettCcyEnum.EUR, 1.15 },
				{ SettCcyEnum.AUD, 1.75 },
				{ SettCcyEnum.USD, 1.24 }
			};
		}
	}

	public class WindowsUserClass
	{
		private readonly IHttpContextAccessor? _httpContextAccessor;
		public string GetUserName()
		{
			return _httpContextAccessor?.HttpContext?.User?.Identity?.Name ?? "";
		}
	}
}
