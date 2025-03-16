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

				// Fetch the core policy details
				var policyDetails = await connection.QuerySingleOrDefaultAsync<ORIPolicyModel>(
					"ORI.spGetORIPolicyDetails",
					parameters,
					commandType: CommandType.StoredProcedure
				);

				if (policyDetails != null)
				{
					// Fetch all inclusions and exclusions in one query
					policyDetails.Filters = (await connection.QueryAsync<ORIFilterItem>(
						"ORI.spGetORIFiltersMaster",
						parameters,
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
			string userNameFinal = context?.User?.Identity?.Name ?? "UnknownUser";

			if (db.State == ConnectionState.Closed)
			{
				await db.OpenAsync();
			}

			using var transaction = db.BeginTransaction();
			try
			{
				Console.WriteLine($"[INFO] Saving ORI Policy Metadata for {model.ORIPolicyReference}");

				// Step 1: Process Removed Filters
				foreach (var filter in model.RemovedFilters)
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
					parameters.Add("@InclusionExclusion", filter.InclusionExclusion);
					parameters.Add("@IncludedOrExcludedItem", filter.IncludedOrExcludedItem);
					parameters.Add("@IncludedOrExcludedValue", filter.IncludedOrExcludedValue);
					parameters.Add("@LastUpdatedBy", userNameFinal);

					await db.ExecuteAsync("ORI.spRemoveORIFiltersMaster", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
				}

				// Step 2: Process Added Filters
				foreach (var filter in model.Filters)
				{
					var parameters = new DynamicParameters();
					parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
					parameters.Add("@InclusionExclusion", filter.InclusionExclusion);
					parameters.Add("@IncludedOrExcludedItem", filter.IncludedOrExcludedItem);
					parameters.Add("@IncludedOrExcludedValue", filter.IncludedOrExcludedValue);
					parameters.Add("@Note", filter.Note);
					parameters.Add("@LastUpdatedBy", userNameFinal);

					await db.ExecuteAsync("ORI.spAddORIFiltersMaster", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
				}

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
		public async Task<List<ORIFilterItemDefinition>> GetIncludedOrExcludedItems()
		{
			using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			await connection.OpenAsync();

			var results = await connection.QueryAsync<ORIFilterItemDefinition>(
				"ORI.spGetIncludedOrExcludedItems",
				commandType: CommandType.StoredProcedure
			);

			return results.ToList();
		}
	}
}