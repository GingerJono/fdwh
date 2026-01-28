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
using DataCardMultiColumnTableDataReturnType = System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>>;
using DataCardSingleColumnTableDataReturnType = System.Collections.Generic.Dictionary<string, string>;
using DataCardPivotableTableDataReturnType = System.Collections.Generic.List<System.Tuple<string, string, string>>;
using DataCardTabbedTableDataReturnType = System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Collections.Generic.Dictionary<string, object>>>;
using ScatterCardDataReturnType = System.Collections.Generic.List<Sandbox.Models.Windowpane.ScatterCardData>;
using Microsoft.Extensions.Logging;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Sandbox.Services
{
	public class WindowpaneService
	{
		private readonly IConfiguration _configuration;
		private readonly ILogger<WindowpaneService> _logger;
		private readonly IHttpContextAccessor _httpContextAccessor;

		public WindowpaneService(IConfiguration configuration, ILogger<WindowpaneService> logger, IHttpContextAccessor httpContextAccessor)
		{
			_configuration = configuration;
			_logger = logger;
			_httpContextAccessor = httpContextAccessor;
		}

		public async Task<IEnumerable<SearchPolicyModel>> SearchPolicies(string searchTerm)
		{
			searchTerm = InputSanitizer.SanitizeHtml(searchTerm);
			using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await connection.QueryAsync<SearchPolicyModel>(
				"Windowpane.spSearchPolicy",
				new { searchTerm },
				commandType: CommandType.StoredProcedure);
		}

		public async Task<IEnumerable<SearchClaimModel>> SearchClaims(string searchTerm)
		{
			searchTerm = InputSanitizer.SanitizeHtml(searchTerm);
			using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await connection.QueryAsync<SearchClaimModel>(
				"Windowpane.spSearchClaim",
				new { searchTerm },
				commandType: CommandType.StoredProcedure);
		}

		public async Task<IEnumerable<SearchProgramModel>> SearchPrograms(string searchTerm)
		{
			searchTerm = InputSanitizer.SanitizeHtml(searchTerm);
			using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await connection.QueryAsync<SearchProgramModel>(
				"Windowpane.spSearchProgram",
				new { searchTerm },
				commandType: CommandType.StoredProcedure);
		}

		// method for Headers - put everything into viewbag
		public Dictionary<string, string> GetProgramHeaderKeyValuePairs(string id)
		{
			return SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spProgramHeader",
				new { ID = id }
			);
		}
		public Dictionary<string, string> GetPolicyHeaderKeyValuePairs(string id)
		{
			return SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spPolicyHeader",
				new { ID = id }
			);
		}
		public Dictionary<string, string> GetClaimHeaderKeyValuePairs(string id)
		{
			return SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spClaimHeader",
				new { ID = id }
			);
		}

		// method for Home Dashboard - put everything into viewbag
		public Dictionary<string, string> GetDashboardHeaderKeyValuePairs(string username)
		{
			return SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spDashboardHeader",
				new { UserName = username }
			);
		}

		// method for Renewal Lists

		public async Task<RenewalListModel> GetRenewalListAsync()
		{
			try
			{
				using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
				var renewalListModel = new RenewalListModel();

				// Fetch Renewals
				var renewals = await db.QueryAsync<Renewal>("[Windowpane].[spRenewalListRenewals]", commandType: CommandType.StoredProcedure);
				renewalListModel.Renewals = renewals.ToList();

				// Fetch New Businesses
				var newBusinesses = await db.QueryAsync<NewBusiness>("[Windowpane].[spRenewalListNewBusiness]", commandType: CommandType.StoredProcedure);
				renewalListModel.NewBusinesses = newBusinesses.ToList();

				return renewalListModel;
			}
			catch (Exception ex)
			{
				_logger.LogError(ex, "An error occurred while fetching renewal and new business lists.");
				throw; // Rethrow the exception after logging
			}
		}

		public async Task<IEnumerable<MyProgram>> GetAllProgramsAsync()
		{
			var context = _httpContextAccessor.HttpContext;
			var username = context?.User?.Identity?.Name;
			// e.g., "DUW\\jononeill"

			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<MyProgram>(
				"[Windowpane].[spDashboardGetAllPrograms]",
				new { ID = username },
				commandType: CommandType.StoredProcedure);
		}

		public async Task<long> GetNextWatchlistIdAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QuerySingleAsync<long>(
				"[Ultimates].[spWatchlist_GetNextID]",
				commandType: CommandType.StoredProcedure);
		}

		// method for generating Excel proforma

		public byte[] GenerateDFProformaExcelFile(string id)
		{
			// Set the License Context
			ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

			// Fetch data from database or other sources
			var data = GetDFProformaDataForExcel(id);

			using (var package = new ExcelPackage(new FileInfo("wwwroot/templates/D&F Underwriting Notes Template 20240816.xlsx")))
			{
				var worksheet = package.Workbook.Worksheets["ProForma"];

				// TO-DO
				// Handle no Aviva
				// Calculate Consortium Line Properly
				// Summarise Account ILR
				// Number Formats

				// Populate Excel cells with data from DFExcelProformaModel
				worksheet.Cells[3, 2].Value = data.AssuredName;
				worksheet.Cells[4, 2].Value = data.RiskReference;
				worksheet.Cells[5, 2].Value = data.InceptionDate.ToShortDateString() + " to " + data.ExpiryDate.ToShortDateString();
				worksheet.Cells[6, 2].Value = data.BrokingHouse;
				worksheet.Cells[7, 2].Value = data.BrokerName;
				worksheet.Cells[8, 2].Value = string.Format("{0:N0} xs {1:N0}", data.Limit, data.XS);
				worksheet.Cells[9, 2].Value = data.RiskCode;
				worksheet.Cells[10, 2].Value = data.LloydsLeader;
				worksheet.Cells[11, 2].Value = data.RiskLocation;
				worksheet.Cells[12, 2].Value = data.Occupancy;
				worksheet.Cells[13, 2].Value = data.Perils;
				worksheet.Cells[17, 2].Value = data.Currency;
				worksheet.Cells[18, 2].Value = data.TIV;
				worksheet.Cells[21, 2].Value = data.ConsortiumWrittenLine;
				worksheet.Cells[22, 2].Value = data.ConsortiumSignedLine;
				worksheet.Cells[21, 4].Value = data.DaleWrittenLine;
				worksheet.Cells[22, 4].Value = data.DaleSignedLine;
				worksheet.Cells[21, 6].Value = data.AvivaWrittenLine;
				worksheet.Cells[22, 6].Value = data.AvivaSignedLine;
				worksheet.Cells[20, 2].Value = data.IsConsortium ? "Yes" : "No";  // Converting bool to "Yes"/"No"
				worksheet.Cells[20, 6].Value = data.IsAviva ? "Yes" : "No";
				worksheet.Cells[23, 6].Value = data.NoAvivaReason;
				worksheet.Cells[25, 2].Value = data.SlipIncome;
				worksheet.Cells[26, 2].Value = data.TP;
				worksheet.Cells[27, 2].Value = data.IELR;
				worksheet.Cells[25, 4].Value = data.Brokerage;
				worksheet.Cells[26, 4].Value = data.OtherDeductions;
				worksheet.Cells[30, 2].Value = data.AttritionSplit;
				worksheet.Cells[31, 2].Value = data.WindFloodSplit;
				worksheet.Cells[32, 2].Value = data.QuakeSplit;
				worksheet.Cells[33, 2].Value = data.TerrorismSplit;

				// Assuming Account Performance starts from row 33
				int startRow = 39;
				foreach (var record in data.AccountPerformance)
				{
					worksheet.Cells[startRow, 1].Value = record.YOA;
					worksheet.Cells[startRow, 2].Value = record.Premium;
					worksheet.Cells[startRow, 3].Value = record.Claims;
					worksheet.Cells[startRow, 4].Value = record.ILR;
					worksheet.Cells[startRow, 5].Value = record.RARC;
					startRow++;
				}

				// Convert the package to a byte array
				return package.GetAsByteArray();
			}
		}
		private DFExcelProformaModel GetDFProformaDataForExcel(string id)
		{
			// Fetch main proforma data
			var proformaData = SqlExtractor.GetColumnarData(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spPolicyDFProFormaSnapshot",
				new { ID = id }
			);

			// Map the data to DFExcelProformaModel
			var model = new DFExcelProformaModel
			{
				RiskReference = proformaData.ContainsKey("RiskReference") ? proformaData["RiskReference"] : string.Empty,
				AssuredName = proformaData.ContainsKey("AssuredName") ? proformaData["AssuredName"] : string.Empty,
				InceptionDate = proformaData.ContainsKey("InceptionDate") ? DateTime.Parse(proformaData["InceptionDate"]) : DateTime.MinValue,
				ExpiryDate = proformaData.ContainsKey("ExpiryDate") ? DateTime.Parse(proformaData["ExpiryDate"]) : DateTime.MinValue,
				BrokingHouse = proformaData.ContainsKey("BrokingHouse") ? proformaData["BrokingHouse"] : string.Empty,
				BrokerName = proformaData.ContainsKey("BrokerName") ? proformaData["BrokerName"] : string.Empty,
				RiskCode = proformaData.ContainsKey("RiskCode") ? proformaData["RiskCode"] : string.Empty,
				Limit = proformaData.ContainsKey("Limit") ? decimal.Parse(proformaData["Limit"]) : 0,
				XS = proformaData.ContainsKey("XS") ? decimal.Parse(proformaData["XS"]) : 0,
				LloydsLeader = proformaData.ContainsKey("LloydsLeader") ? proformaData["LloydsLeader"] : string.Empty,
				RiskLocation = proformaData.ContainsKey("RiskLocation") ? proformaData["RiskLocation"] : string.Empty,
				Occupancy = proformaData.ContainsKey("Occupancy") ? proformaData["Occupancy"] : string.Empty,
				Perils = proformaData.ContainsKey("Perils") ? proformaData["Perils"] : string.Empty,
				Currency = proformaData.ContainsKey("Currency") ? proformaData["Currency"] : string.Empty,
				TIV = proformaData.ContainsKey("TIV") ? decimal.Parse(proformaData["TIV"]) : 0,
				ConsortiumWrittenLine = proformaData.ContainsKey("ConsortiumWrittenLine") ? decimal.Parse(proformaData["ConsortiumWrittenLine"]) : 0,
				ConsortiumSignedLine = proformaData.ContainsKey("ConsortiumSignedLine") ? decimal.Parse(proformaData["ConsortiumSignedLine"]) : 0,
				AvivaWrittenLine = proformaData.ContainsKey("AvivaWrittenLine") ? decimal.Parse(proformaData["AvivaWrittenLine"]) : 0,
				AvivaSignedLine = proformaData.ContainsKey("AvivaSignedLine") ? decimal.Parse(proformaData["AvivaSignedLine"]) : 0,
				DaleWrittenLine = proformaData.ContainsKey("DaleWrittenLine") ? decimal.Parse(proformaData["DaleWrittenLine"]) : 0,
				DaleSignedLine = proformaData.ContainsKey("DaleSignedLine") ? decimal.Parse(proformaData["DaleSignedLine"]) : 0,
				IsConsortium = proformaData.ContainsKey("IsConsortium") ? bool.Parse(proformaData["IsConsortium"]) : false,
				IsAviva = proformaData.ContainsKey("IsAviva") ? bool.Parse(proformaData["IsAviva"]) : false,
				NoAvivaReason = proformaData.ContainsKey("NoAvivaReason") ? proformaData["NoAvivaReason"] : string.Empty,
				SlipIncome = proformaData.ContainsKey("SlipIncome") ? decimal.Parse(proformaData["SlipIncome"]) : 0,
				TP = proformaData.ContainsKey("TP") ? decimal.Parse(proformaData["TP"]) : 0,
				IELR = proformaData.ContainsKey("IELR") ? decimal.Parse(proformaData["IELR"]) : 0,
				Brokerage = proformaData.ContainsKey("Brokerage") ? decimal.Parse(proformaData["Brokerage"]) : 0,
				OtherDeductions = proformaData.ContainsKey("OtherDeductions") ? decimal.Parse(proformaData["OtherDeductions"]) : 0,
				AttritionSplit = proformaData.ContainsKey("AttritionSplit") ? decimal.Parse(proformaData["AttritionSplit"]) : 0,
				WindFloodSplit = proformaData.ContainsKey("WindFloodSplit") ? decimal.Parse(proformaData["WindFloodSplit"]) : 0,
				QuakeSplit = proformaData.ContainsKey("QuakeSplit") ? decimal.Parse(proformaData["QuakeSplit"]) : 0,
				TerrorismSplit = proformaData.ContainsKey("TerrorismSplit") ? decimal.Parse(proformaData["TerrorismSplit"]) : 0,
			};

			// Fetch account performance data
			var accountPerformanceData = SqlExtractor.GetTabularDataAsync(
				_configuration,
				"DaleSandboxConnection",
				"Windowpane.spPolicyDFProFormaAccountPerformance",
				new { ID = id }
			).Result;

			// Map the account performance data
			foreach (var row in accountPerformanceData)
			{
				var accountPerformanceRecord = new AccountPerformanceRecord
				{
					YOA = row.ContainsKey("YOA") ? int.Parse(row["YOA"].ToString()) : 0,
					Premium = row.ContainsKey("Premium") ? decimal.Parse(row["Premium"].ToString()) : 0,
					Claims = row.ContainsKey("Claims") ? decimal.Parse(row["Claims"].ToString()) : 0,
					ILR = row.ContainsKey("ILR") ? decimal.Parse(row["ILR"].ToString()) : 0,
					RARC = row.ContainsKey("RARC") ? decimal.Parse(row["RARC"].ToString()) : 0,
				};
				model.AccountPerformance.Add(accountPerformanceRecord);
			}

			return model;
		}

		// configure Methods for Windowpane extracts

		#region METHOD CONFIG
		public class MethodConfig
		{
			public string MethodName { get; set; }
			public Type ReturnType { get; set; }
			public string SqlProcedureName { get; set; }
			public string? GroupByColumnName { get; set; }
		}

		List<MethodConfig> methodConfigs = new List<MethodConfig>
		{
			new MethodConfig { MethodName = "GetClaimsMovementsSummary", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsMovementsSummary" },
		new MethodConfig { MethodName = "GetClaimsReinsuranceCatXL", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsReinsuranceCatXL" },
		new MethodConfig { MethodName = "GetClaimsReinsuranceFac", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsReinsuranceFac" },
		new MethodConfig { MethodName = "GetClaimsReinsuranceQuotaShare", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsReinsuranceQuotaShare" },
		new MethodConfig { MethodName = "GetClaimsReinsuranceRiskXL", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsReinsuranceRiskXL" },
		new MethodConfig { MethodName = "GetClaimsSnapshotDates", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsSnapshotDates" },
		new MethodConfig { MethodName = "GetClaimsSnapshotEvents", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsSnapshotEvents" },
		new MethodConfig { MethodName = "GetClaimsSnapshotNarratives", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsSnapshotNarratives" },
		new MethodConfig { MethodName = "GetClaimsSnapshotSummary", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spClaimsSnapshotSummary" },
		new MethodConfig { MethodName = "GetPolicyAggregatesCountry", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAggregatesCountry" },
		new MethodConfig { MethodName = "GetPolicyAggregatesCounty", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAggregatesCounty" },
		new MethodConfig { MethodName = "GetPolicyAggregatesHistorical", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAggregatesHistorical" },
		new MethodConfig { MethodName = "GetPolicyAggregatesState", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAggregatesState" },
		new MethodConfig { MethodName = "GetPolicyAuditAuditLog", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAuditAuditLog" },
		new MethodConfig { MethodName = "GetPolicyAuditLifeCycle", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyAuditLifeCycle" },
		new MethodConfig { MethodName = "GetPolicyClaimsDevelopment", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyClaimsDevelopment" },
		new MethodConfig { MethodName = "GetPolicyClaimsEvents", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyClaimsEvents" },
		new MethodConfig { MethodName = "GetPolicyClaimsList", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyClaimsList" },
		new MethodConfig { MethodName = "GetPolicyExceptionsChecked", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyExceptionsChecked" },
		new MethodConfig { MethodName = "GetPolicyExceptionsUnchecked", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyExceptionsUnchecked" },
		new MethodConfig { MethodName = "GetPolicyNotesNDEXNotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyNotesNDEXNotes" },
		new MethodConfig { MethodName = "GetPolicyNotesWorkbenchNotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyNotesWorkbenchNotes" },
		new MethodConfig { MethodName = "GetPolicyPremiumCurrencies", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPremiumCurrencies" },
		new MethodConfig { MethodName = "GetPolicyPremiumHistory", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPremiumHistory" },
		new MethodConfig { MethodName = "GetPolicyPremiumPatterns", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPremiumPatterns" },
		new MethodConfig { MethodName = "GetPolicyPremiumSignings", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPremiumSignings" },
		new MethodConfig { MethodName = "GetPolicyPricingELRs", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPricingELRs" },
		new MethodConfig { MethodName = "GetPolicyPricingOptalitixQuotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPricingOptalitixQuotes" },
		new MethodConfig { MethodName = "GetPolicyPricingPremiumSplits", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPricingPremiumSplits" },
		new MethodConfig { MethodName = "GetPolicyPricingRateChange", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyPricingRateChange" },
		new MethodConfig { MethodName = "GetPolicySnapshotCompanies", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotCompanies" },
		new MethodConfig { MethodName = "GetPolicySnapshotDates", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotDates" },
		new MethodConfig { MethodName = "GetPolicySnapshotDeductions", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotDeductions" },
		new MethodConfig { MethodName = "GetPolicySnapshotDocuments", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotDocuments" },
		new MethodConfig { MethodName = "GetPolicySnapshotGeographical", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotGeographical" },
		new MethodConfig { MethodName = "GetPolicySnapshotHistory", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotHistory" },
		new MethodConfig { MethodName = "GetPolicySnapshotKeyStats", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotKeyStats" },
		new MethodConfig { MethodName = "GetPolicySnapshotLinesLimits", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotLinesLimits" },
		new MethodConfig { MethodName = "GetPolicySnapshotPeriod", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotPeriod" },
		new MethodConfig { MethodName = "GetPolicySnapshotRelatedPolicies", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotRelatedPolicies" },
		new MethodConfig { MethodName = "GetPolicySnapshotReview", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotReview" },
		new MethodConfig { MethodName = "GetPolicySnapshotRiskCodes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotRiskCodes" },
		new MethodConfig { MethodName = "GetPolicySnapshotSegmentation", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotSegmentation" },
		new MethodConfig { MethodName = "GetPolicySnapshotStatuses", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotStatuses" },
		new MethodConfig { MethodName = "GetPolicySnapshotSummary", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spPolicySnapshotSummary" },
		new MethodConfig { MethodName = "GetDFProFormaSummary", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spPolicyDFProFormaSnapshot" },
		new MethodConfig { MethodName = "GetDFProFormaPerformance", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spPolicyDFProFormaAccountPerformance" },
		new MethodConfig { MethodName = "GetProgramClaimsDevelopment", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramClaimsDevelopment" },
		new MethodConfig { MethodName = "GetProgramClaimsEvents", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramClaimsEvents" },
		new MethodConfig { MethodName = "GetProgramClaimsList", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramClaimsList" },
		new MethodConfig { MethodName = "GetProgramSnapshotNDEXNotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotNDEXNotes" },
		new MethodConfig { MethodName = "GetProgramNotesWorkbenchNotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramNotesWorkbenchNotes" },
		new MethodConfig { MethodName = "GetProgramPremiumCurrencies", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPremiumCurrencies" },
		new MethodConfig { MethodName = "GetProgramPremiumHistory", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPremiumHistory" },
		new MethodConfig { MethodName = "GetProgramPremiumPatterns", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPremiumPatterns" },
		new MethodConfig { MethodName = "GetProgramPremiumSignings", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPremiumSignings" },
		new MethodConfig { MethodName = "GetProgramPricingELRs", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPricingELRs" },
		new MethodConfig { MethodName = "GetProgramPricingOptalitixQuotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPricingOptalitixQuotes" },
		new MethodConfig { MethodName = "GetProgramPricingPremiumSplits", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPricingPremiumSplits" },
		new MethodConfig { MethodName = "GetProgramPricingRateChange", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramPricingRateChange" },
		new MethodConfig { MethodName = "GetProgramSnapshotCompanies", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotCompanies" },
		new MethodConfig { MethodName = "GetProgramSnapshotDates", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotDates" },
		new MethodConfig { MethodName = "GetProgramSnapshotDeductions", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotDeductions" },
		new MethodConfig { MethodName = "GetProgramSnapshotDocuments", ReturnType = typeof(DataCardTabbedTableDataReturnType), SqlProcedureName = "spProgramSnapshotDocuments", GroupByColumnName = "Type" },
		new MethodConfig { MethodName = "GetProgramSnapshotGeographical", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotGeographical" },
		new MethodConfig { MethodName = "GetProgramSnapshotHistory", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotHistory" },
		new MethodConfig { MethodName = "GetProgramSnapshotHistorySettCcy", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotHistorySettCcy" },
		new MethodConfig { MethodName = "GetProgramSnapshotKeyStats", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotKeyStats" },
		new MethodConfig { MethodName = "GetProgramSnapshotLines", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotLines" },
		new MethodConfig { MethodName = "GetProgramSnapshotRiskCodes", ReturnType = typeof(DataCardPivotableTableDataReturnType), SqlProcedureName = "spProgramSnapshotRiskCodes" },
		new MethodConfig { MethodName = "GetProgramSnapshotSegmentation", ReturnType = typeof(DataCardSingleColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotSegmentation" },
		new MethodConfig { MethodName = "GetProgramELRvsPremium", ReturnType = typeof(ScatterCardDataReturnType), SqlProcedureName = "spProgramSnapshotELRvsPremium" },
		new MethodConfig { MethodName = "GetProgramSnapshotTechnicalPremium", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramSnapshotTechnicalPremium" },
		new MethodConfig { MethodName = "GetProgramAccuracyCheckDetails", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spProgramAccuracyCheckDetails" },

		// Dashboard methods
		new MethodConfig { MethodName = "GetDashboardGetRecentlyBound", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetRecentlyBound" },
		new MethodConfig { MethodName = "GetDashboardGetRecentlyRiskReviewed", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetRecentlyRiskReviewed" },
		new MethodConfig { MethodName = "GetDashboardGetUpcomingRenewals", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetUpcomingRenewals" },
		new MethodConfig { MethodName = "GetDashboardOpenQuotes", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetOpenQuotes" },
		new MethodConfig { MethodName = "GetDashboardToBeUWReviewed", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetToBeUWReviewed" },
		new MethodConfig { MethodName = "GetDashboardGetRecentClaimsMovements", ReturnType = typeof(DataCardMultiColumnTableDataReturnType), SqlProcedureName = "spDashboardGetRecentClaimsMovements" },

		};

		// reflection method for executing the extraction
		public async Task<object> ExecuteMethodByName(string methodName, string id)
		{
			var config = methodConfigs.FirstOrDefault(m => m.MethodName == methodName);
			if (config == null)
				throw new InvalidOperationException($"No method configuration found for {methodName}");

			if (config.ReturnType == typeof(Dictionary<string, string>))
			{
				return await SqlExtractor.GetColumnarDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"Windowpane." + config.SqlProcedureName,
					new { ID = id }
				);
			}
			else if (config.ReturnType == typeof(List<Dictionary<string, object>>))
			{
				return await SqlExtractor.GetTabularDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"Windowpane." + config.SqlProcedureName,
					new { ID = id }
				);
			}
			else if (config.ReturnType == typeof(List<Tuple<string, string, string>>))
			{
				return await SqlExtractor.GetPivotableDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"Windowpane." + config.SqlProcedureName,
					new { ID = id }
				);
			}
			else if (config.ReturnType == typeof(IEnumerable<IGrouping<string, Dictionary<string, object>>>))
			{
				return await SqlExtractor.GetTabTableDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"Windowpane." + config.SqlProcedureName,
					config.GroupByColumnName, // Use the property here
					new { ID = id }
				);
			}
			else if (config.ReturnType == typeof(List<Sandbox.Models.Windowpane.ScatterCardData>))
			{
				return await SqlExtractor.GetScatterCardDataAsync(
					_configuration,
					"DaleSandboxConnection",
					"Windowpane." + config.SqlProcedureName,
					new { ID = id }
				);
			}


			else
			{
				throw new InvalidOperationException($"Unsupported return type {config.ReturnType} for method {methodName}");
			}
		}

		public async Task<IEnumerable<CytoraCheck>> GetCytoraChecksAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<CytoraCheck>(
				"SELECT * FROM vwCytoraChecking"
			);
		}

		public async Task<CytoraCheck> GetCytoraCheckByJobIdAsync(int jobId)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryFirstOrDefaultAsync<CytoraCheck>(
				"SELECT * FROM vwCytoraChecking WHERE JobID = @JobID",
				new { JobID = jobId }
			);
		}

		public async Task<IEnumerable<NOCItem>> GetNOCsAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<NOCItem>(
				"Windowpane.spNOCList",
				commandType: CommandType.StoredProcedure
			);
		}

		public async Task<IEnumerable<HighLevelWorkflowItem>> GetHighLevelWorkflowAsync(DateTime inceptionMonth, string classParam)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<HighLevelWorkflowItem>(
				"Windowpane.spHighLevelWorkflow",
				new { InceptionMonth = inceptionMonth, Class = classParam },
				commandType: CommandType.StoredProcedure
			);
		}

		public async Task<IEnumerable<BindersMetadataItem>> GetBindersMetadataAsync()
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			return await db.QueryAsync<BindersMetadataItem>(
				"Windowpane.spGetBindersMetadata",
				commandType: CommandType.StoredProcedure
			);
		}

		public async Task UpdateBindersMetadataAsync(UpdateBindersMetadataRequest request)
		{
			using var db = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
			await db.ExecuteAsync(
				"Windowpane.spUpdateBindersMetadata",
				new
				{
					PolicyRef = request.PolicyRef,
					RequiresClaimsBdx = request.RequiresClaimsBdx,
					UpdatedBy = request.UpdatedBy,
					Comments = request.Comments
				},
				commandType: CommandType.StoredProcedure
			);
		}
		#endregion
	}
	public class CytoraCheckingFilterState
	{
		public int? MinJobID { get; set; }
		public int? MaxJobID { get; set; }
	}
}
