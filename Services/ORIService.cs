using Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Sandbox.Models;
using System.Data;
using System.Text;
using System.Web;
using Sandbox.Models.Windowpane;
using Sandbox.Helpers;
using Microsoft.AspNetCore.Mvc.Routing;
using Sandbox.Models.Pricing;
using Sandbox.Models.Reporting;
using Sandbox.Models.ORI;
using Microsoft.AspNetCore.Http;

namespace Sandbox.Services
{
	public class ORIService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IConfiguration _configuration;

		public ORIService(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
		{
			_configuration = configuration;
			_httpContextAccessor = httpContextAccessor;
		}
		public async Task<IEnumerable<ORIPolicyListModel>> GetORIPolicies()
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				//parameters.Add("UserName", userName, DbType.String);

				var result = await connection.QueryAsync<ORIPolicyListModel>(
					"ORI.spGetORIPolicies",
					parameters,
					commandType: CommandType.StoredProcedure
				);

				return result.ToList();
			}
		}
		private async Task<EditableORIMetadataList<T>> GetEditableList<T>(SqlConnection connection, string storedProcedure, DynamicParameters parameters)
		{
			return new EditableORIMetadataList<T>
			{
				Current = (await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure)).ToList()
			};
		}
		public async Task<ORIPolicyModel> GetORIPolicyDetails(string ORIPolicyReference)
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				parameters.Add("ORIPolicyReference", ORIPolicyReference, DbType.String);

				var policyDetails = await connection.QuerySingleOrDefaultAsync<ORIPolicyModel>(
					"ORI.spGetORIPolicyDetails",
					parameters,
					commandType: CommandType.StoredProcedure
				);
				if (policyDetails != null)
				{

					// Excluded Filters
					policyDetails.ExcludedDomicileCountries = await GetEditableList<ExcludedDomicileCountry>(connection, "ORI.spGetORIFiltersExcludedDomicileCountry", parameters);
					policyDetails.ExcludedInwardPolicyReferences = await GetEditableList<ExcludedInwardPolicyReference>(connection, "ORI.spGetORIFiltersExcludedInwardPolicyReference", parameters);
					policyDetails.ExcludedPlacementUMRs = await GetEditableList<ExcludedPlacementUMR>(connection, "ORI.spGetORIFiltersExcludedPlacementUMR", parameters);
					policyDetails.ExcludedReservingClasses = await GetEditableList<ExcludedReservingClass>(connection, "ORI.spGetORIFiltersExcludedReservingClass", parameters);
					policyDetails.ExcludedRiskCodes = await GetEditableList<ExcludedRiskCode>(connection, "ORI.spGetORIFiltersExcludedRiskCodes", parameters);
					policyDetails.ExcludedStatCode2s = await GetEditableList<ExcludedStatCode2>(connection, "ORI.spGetORIFiltersExcludedStatCode2", parameters);

					// Included Filters
					policyDetails.IncludedClasses = await GetEditableList<IncludedClass>(connection, "ORI.spGetORIFiltersIncludedClass", parameters);
					policyDetails.IncludedDomicileCountries = await GetEditableList<IncludedDomicileCountry>(connection, "ORI.spGetORIFiltersIncludedDomicileCountry", parameters);
					policyDetails.IncludedInwardPolicyReferences = await GetEditableList<IncludedInwardPolicyReference>(connection, "ORI.spGetORIFiltersIncludedInwardPolicyReference", parameters);
					policyDetails.IncludedPerils = await GetEditableList<IncludedPeril>(connection, "ORI.spGetORIFiltersIncludedPeril", parameters);
					policyDetails.IncludedPlacementUMRs = await GetEditableList<IncludedPlacementUMR>(connection, "ORI.spGetORIFiltersIncludedPlacementUMR", parameters);
					policyDetails.IncludedReservingClasses = await GetEditableList<IncludedReservingClass>(connection, "ORI.spGetORIFiltersIncludedReservingClass", parameters);
					policyDetails.IncludedRiskCodes = await GetEditableList<IncludedRiskCodes>(connection, "ORI.spGetORIFiltersIncludedRiskCodes", parameters);
					policyDetails.IncludedStatCode1s = await GetEditableList<IncludedStatCode1>(connection, "ORI.spGetORIFiltersIncludedStatCode1", parameters);
					policyDetails.IncludedStatCode2s = await GetEditableList<IncludedStatCode2>(connection, "ORI.spGetORIFiltersIncludedStatCode2", parameters);

					policyDetails.Securities = await connection.QueryAsync<PolicySecurity>(
						"ORI.spGetORIPolicySecurity",
						parameters,
						commandType: CommandType.StoredProcedure
					);

					policyDetails.Narratives = await connection.QueryAsync<Narrative>(
						"ORI.spGetORIPolicyNarratives",
						parameters,
						commandType: CommandType.StoredProcedure
					);
					// Populate Dropdown Lists Inline
					policyDetails.Classes = (await connection.QueryAsync<ClassItem>(
						"ORI.spGetListClass",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.DomicileCountries = (await connection.QueryAsync<DomicileCountry>(
						"ORI.spGetListDomicileCountry",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.Perils = (await connection.QueryAsync<Peril>(
						"ORI.spGetListPeril",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.ReservingClasses = (await connection.QueryAsync<ReservingClass>(
						"ORI.spGetListReservingClass",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.RiskCodes = (await connection.QueryAsync<RiskCode>(
						"ORI.spGetListRiskCode",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.StatCode1s = (await connection.QueryAsync<StatCode>(
						"ORI.spGetListStatCode1",
						commandType: CommandType.StoredProcedure
					)).ToList();

					policyDetails.StatCode2s = (await connection.QueryAsync<StatCode>(
						"ORI.spGetListStatCode2",
						commandType: CommandType.StoredProcedure
					)).ToList();
				}


				return policyDetails;
			}
		}

		public async Task<IEnumerable<ORIUSMListModel>> GetORIUSMs()
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				//parameters.Add("UserName", userName, DbType.String);

				var result = await connection.QueryAsync<ORIUSMListModel>(
					"ORI.spGetORIUSMList",
					parameters,
					commandType: CommandType.StoredProcedure
				);

				return result.ToList();
			}
		}
		public async Task<ORIUSMModel> GetORIUSMDetails(string ORIUSMID)
		{
			using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
			{
				await connection.OpenAsync();

				var parameters = new DynamicParameters();
				parameters.Add("ORIUSMID", ORIUSMID, DbType.String);

				var usmDetails = await connection.QuerySingleOrDefaultAsync<ORIUSMModel>(
					"ORI.spGetORIUSMDetails",
					parameters,
					commandType: CommandType.StoredProcedure
				);
				if (usmDetails != null)
				{
					// Excluded
					usmDetails.Narratives = await connection.QueryAsync<USMNarrative>(
						"ORI.spGetORIUSMNarrative",
						parameters,
						commandType: CommandType.StoredProcedure
					);

					// Fetch YOA allocations
					usmDetails.YOAAllocations = await connection.QueryAsync<YOAAllocation>(
						"ORI.spGetORIUSMAllocationsYOA",
						parameters,
						commandType: CommandType.StoredProcedure
					);

					// Fetch COB allocations
					usmDetails.COBAllocations = await connection.QueryAsync<COBAllocation>(
						"ORI.spGetORIUSMAllocationsCOB",
						parameters,
						commandType: CommandType.StoredProcedure
					);

					// Fetch Security allocations
					usmDetails.SecurityAllocations = await connection.QueryAsync<SecurityAllocation>(
						"ORI.spGetORIUSMAllocationsSecurity",
						parameters,
						commandType: CommandType.StoredProcedure
					);

					// Fetch Event allocations
					usmDetails.EventAllocations = await connection.QueryAsync<EventAllocation>(
						"ORI.spGetORIUSMAllocationsEvent",
						parameters,
						commandType: CommandType.StoredProcedure
					);
				}

				return usmDetails;
			}
		}

		public async Task SaveORIPolicyMetadata(ORIPolicyModel model)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			var context = _httpContextAccessor.HttpContext;

			// Retrieve user information
			var userNameOverride = context?.Items["UserNameOverride"] as string;
			string userNameFinal = string.IsNullOrEmpty(userNameOverride) ? context?.User?.Identity?.Name ?? "" : userNameOverride;

			if (db.State == ConnectionState.Closed)
			{
				await db.OpenAsync();
			}

			using var transaction = db.BeginTransaction();
			try
			{
				Console.WriteLine($"[INFO] Saving ORI Policy Metadata for {model.ORIPolicyReference}");

				// Define a dictionary for all metadata sections
				var metadataSections = new Dictionary<string, (dynamic List, string AddSP, string RemoveSP)>
		{
            // Excluded Metadata
            { "ExcludedDomicileCountries", (model.ExcludedDomicileCountries, "ORI.spAddORIFiltersExcludedDomicileCountry", "ORI.spRemoveORIFiltersExcludedDomicileCountry") },
			{ "ExcludedInwardPolicyReferences", (model.ExcludedInwardPolicyReferences, "ORI.spAddORIFiltersExcludedInwardPolicyReference", "ORI.spRemoveORIFiltersExcludedInwardPolicyReference") },
			{ "ExcludedPlacementUMRs", (model.ExcludedPlacementUMRs, "ORI.spAddORIFiltersExcludedPlacementUMR", "ORI.spRemoveORIFiltersExcludedPlacementUMR") },
			{ "ExcludedReservingClasses", (model.ExcludedReservingClasses, "ORI.spAddORIFiltersExcludedReservingClass", "ORI.spRemoveORIFiltersExcludedReservingClass") },
			{ "ExcludedRiskCodes", (model.ExcludedRiskCodes, "ORI.spAddORIFiltersExcludedRiskCodes", "ORI.spRemoveORIFiltersExcludedRiskCodes") },
			{ "ExcludedStatCode2s", (model.ExcludedStatCode2s, "ORI.spAddORIFiltersExcludedStatCode2", "ORI.spRemoveORIFiltersExcludedStatCode2") },

            // Included Metadata
            { "IncludedClasses", (model.IncludedClasses, "ORI.spAddORIFiltersIncludedClass", "ORI.spRemoveORIFiltersIncludedClass") },
			{ "IncludedDomicileCountries", (model.IncludedDomicileCountries, "ORI.spAddORIFiltersIncludedDomicileCountry", "ORI.spRemoveORIFiltersIncludedDomicileCountry") },
			{ "IncludedInwardPolicyReferences", (model.IncludedInwardPolicyReferences, "ORI.spAddORIFiltersIncludedInwardPolicyReference", "ORI.spRemoveORIFiltersIncludedInwardPolicyReference") },
			{ "IncludedPerils", (model.IncludedPerils, "ORI.spAddORIFiltersIncludedPeril", "ORI.spRemoveORIFiltersIncludedPeril") },
			{ "IncludedPlacementUMRs", (model.IncludedPlacementUMRs, "ORI.spAddORIFiltersIncludedPlacementUMR", "ORI.spRemoveORIFiltersIncludedPlacementUMR") },
			{ "IncludedReservingClasses", (model.IncludedReservingClasses, "ORI.spAddORIFiltersIncludedReservingClass", "ORI.spRemoveORIFiltersIncludedReservingClass") },
			{ "IncludedRiskCodes", (model.IncludedRiskCodes, "ORI.spAddORIFiltersIncludedRiskCodes", "ORI.spRemoveORIFiltersIncludedRiskCodes") },
			{ "IncludedStatCode1s", (model.IncludedStatCode1s, "ORI.spAddORIFiltersIncludedStatCode1", "ORI.spRemoveORIFiltersIncludedStatCode1") },
			{ "IncludedStatCode2s", (model.IncludedStatCode2s, "ORI.spAddORIFiltersIncludedStatCode2", "ORI.spRemoveORIFiltersIncludedStatCode2") }
			};

				var fieldMappings = new Dictionary<string, string>
				{
					{ "ExcludedDomicileCountries", "DomicileCountry" },
					{ "ExcludedInwardPolicyReferences", "InwardPolicyReference" },
					{ "ExcludedPlacementUMRs", "PlacementUMR" },
					{ "ExcludedReservingClasses", "ReservingClass" },
					{ "ExcludedRiskCodes", "PolicyMainRiskCode" },
					{ "ExcludedStatCode2s", "StatCode2" },
					{ "IncludedClasses", "Class" },
					{ "IncludedDomicileCountries", "DomicileCountry" },
					{ "IncludedInwardPolicyReferences", "InwardPolicyReference" },
					{ "IncludedPerils", "Peril" },
					{ "IncludedPlacementUMRs", "PlacementUMR" },
					{ "IncludedReservingClasses", "ReservingClass" },
					{ "IncludedRiskCodes", "PolicyMainRiskCode" },
					{ "IncludedStatCode1s", "StatCode1" },
					{ "IncludedStatCode2s", "StatCode2" }
				};

				// Process all metadata sections dynamically
				foreach (var section in metadataSections)
				{
					var sectionName = section.Key;
					var (metadataList, addSP, removeSP) = section.Value;

					// Process Added Items
					foreach (var item in metadataList.Added)
					{
						Console.WriteLine($"[INFO] Adding {sectionName}: {item}");

						var parameters = new DynamicParameters();
						parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);

						// Get correct field name
						if (fieldMappings.TryGetValue(sectionName, out var fieldName))
						{
							// Ensure item is not null and extract the property dynamically
							var value = item.GetType().GetProperty(fieldName)?.GetValue(item, null);

							if (value != null)
							{
								parameters.Add($"@{fieldName}", value);
							}
							else
							{
								throw new Exception($"Property '{fieldName}' not found on item: {item}");
							}
						}
						else
						{
							throw new Exception($"Unknown section name: {sectionName}");
						}

						parameters.Add("@Note", item.Note);
						parameters.Add("@LastUpdatedBy", userNameFinal);

						await db.ExecuteAsync(addSP, parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
					}

					// Process Removed Items
					foreach (var item in metadataList.Removed)
					{
						Console.WriteLine($"[INFO] Removing {sectionName}: {item}");

						var parameters = new DynamicParameters();
						parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);

						// Get correct field name
						if (fieldMappings.TryGetValue(sectionName, out var fieldName))
						{
							// Ensure item is not null and extract the property dynamically
							var value = item.GetType().GetProperty(fieldName)?.GetValue(item, null);

							if (value != null)
							{
								parameters.Add($"@{fieldName}", value);
							}
							else
							{
								throw new Exception($"Property '{fieldName}' not found on item: {item}");
							}
						}
						else
						{
							throw new Exception($"Unknown section name: {sectionName}");
						}
						parameters.Add("@LastUpdatedBy", userNameFinal);

						await db.ExecuteAsync(removeSP, parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
					}

					// Clear Added/Removed lists after successful save
					metadataList.Added.Clear();
					metadataList.Removed.Clear();
				}

				// Commit transaction if all commands succeed
				transaction.Commit();
				Console.WriteLine($"[SUCCESS] ORI Policy Metadata saved successfully for {model.ORIPolicyReference}");
			}
			catch (Exception ex)
			{
				transaction.Rollback();
				Console.WriteLine($"[ERROR] Transaction failed: {ex.Message}");
				throw;
			}
		}
	}
}