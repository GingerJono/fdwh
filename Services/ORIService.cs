using Dapper;
using Microsoft.Data.SqlClient;
using Sandbox.Helpers;
using Sandbox.Models;
using Sandbox.Models.ORI;
using Sandbox.Models.Prism;
using System.Data;
using System.Diagnostics;

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

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception("No ORI policies found.");
                }

            }
        }

        public async Task<IEnumerable<ORIPolicyReinstatementModel>> GetReinstatementsByPolicy(string ORIPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();
                var parameters = new DynamicParameters();
                parameters.Add("ORIPolicyReference", ORIPolicyReference, DbType.String);
                var result = await connection.QueryAsync<ORIPolicyReinstatementModel>(
                    "ORI.spGetReinstatementsByPolicy",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception($"No reinstatements found for policy reference: {ORIPolicyReference}.");
                }

            }
        }
        public async Task<List<FXTreatmentModel>> GetFXTreatments()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                //parameters.Add("UserName", userName, DbType.String);

                var result = await connection.QueryAsync<FXTreatmentModel>(
                    "ORI.spGetFxTreatments",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception("No FX treatments found.");
                }

            }
        }

        public async Task<LORSModel> GetLORSDetails(string fileName, int policySequence)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("FileName", fileName);
                parameters.Add("PolicySequence", policySequence);

                var result = await connection.QueryFirstOrDefaultAsync<LORSModel>(
                    "ORI.spGetLORSDetails", // Create this stored procedure as needed
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result;
                }
                else
                {
                    throw new Exception($"No LORS details found for FileName: {fileName} and PolicySequence: {policySequence}.");
                }
            }
        }

        public async Task<List<LORSReinsurerModel>> GetLORSReinsurers(string fileName, int policySequence)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("FileName", fileName);
                parameters.Add("PolicySequence", policySequence);

                var result = await connection.QueryAsync<LORSReinsurerModel>(
                    "ORI.spGetLORSReinsurers",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception($"No LORS reinsurers found for FileName: {fileName} and PolicySequence: {policySequence}.");
                }
            }
        }

        public async Task<IEnumerable<LORSListModel>> GetLORSList()
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                // No parameters needed for this stored procedure

                var result = await connection.QueryAsync<LORSListModel>(
                    "ORI.spGetLORSList",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception("No LORS records found.");
                }

            }
        }

        public async Task<IEnumerable<ORIUSMListModel>> GetORIUSMsByPolicy(string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@ORIPolicyReference", oriPolicyReference, DbType.String);

                var result = await connection.QueryAsync<ORIUSMListModel>(
                    "ORI.spGetORIUSMListByPolicy",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception($"No ORI USMs found for policy reference: {oriPolicyReference}.");
                }
            }
        }

        public async Task<IEnumerable<LORSListModel>> GetLORSByPolicy(string oriPolicyReference)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("@ORIPolicyReference", oriPolicyReference, DbType.String);

                var result = await connection.QueryAsync<LORSListModel>(
                    "ORI.spGetLORSListByPolicy",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception($"No LORS records found for policy reference: {oriPolicyReference}.");
                }
            }
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

                    policyDetails.Narratives = (await connection.QueryAsync<Narrative>(
                        "ORI.spGetORIPolicyNarratives", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    policyDetails.PolicySecurities = (await connection.QueryAsync<PolicySecurity>(
                        "ORI.spGetORIPolicySecurity", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    // Fetch Allocations Class and YOA
                    policyDetails.PolicyAllocations = (await GetPolicyAllocations(connection, policyDetails.ORIPolicyReference)).ToList();
                  

                    // Get Reinstatements
                    policyDetails.Reinstatements = (await GetPolicyReinstatements(connection, policyDetails.ORIPolicyReference)).ToList();

                    // Get Agg Deductibles
                    policyDetails.AggDeductibles = (await GetAggDeductibles(connection, policyDetails.ORIPolicyReference)).ToList();

                    // Get FX Rates
                    policyDetails.PolicyFXRates = (await GetPolicyFXRates(connection, policyDetails.ORIPolicyReference)).ToList();

                    return policyDetails;
                }
                else
                {
                    throw new Exception($"No ORI policy found with reference: {ORIPolicyReference}.");
                }
            }
        }

        private async Task<IEnumerable<ORIPolicyAllocation>> GetPolicyAllocations(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = await connection.QueryAsync<ORIPolicyAllocation>(
                "ORI.spGetORIPolicyAllocations",
                parameters,
                commandType: CommandType.StoredProcedure);
            
                return result.ToList();     
        }

        private async Task<IEnumerable<ORIPolicyFXRate>> GetPolicyFXRates(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = await connection.QueryAsync<ORIPolicyFXRate>(
                "ORI.spGetORIPolicyFXRates",
                parameters,
                commandType: CommandType.StoredProcedure);
            
                return result.ToList();                       
        }

        private async Task<IEnumerable<AggDeductible>> GetAggDeductibles(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = await connection.QueryAsync<AggDeductible>(
                "ORI.spGetAggDeductibles",
                parameters,
                commandType: CommandType.StoredProcedure);

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception($"No aggregate deductibles found for policy reference: {ORIPolicyReference}.");
            }
        }        

        private async Task<IEnumerable<ORIPolicyReinstatementModel>> GetPolicyReinstatements(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = await connection.QueryAsync<ORIPolicyReinstatementModel>(
                "ORI.spGetReinstatementsByPolicy",
                parameters,
                commandType: CommandType.StoredProcedure);

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception($"No reinstatements found for policy reference: {ORIPolicyReference}.");
            }
        }


        public async Task<IEnumerable<ORIUSMListModel>> GetORIUSMs(int? YoA = null, int? usmYear = null)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("PolicyYoA", YoA, DbType.Int32);
                parameters.Add("USMYear", usmYear, DbType.Int32);

                var result = await connection.QueryAsync<ORIUSMListModel>(
                    "ORI.spGetORIUSMList",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                if (result != null)
                {
                    return result.ToList();
                }
                else
                {
                    throw new Exception("No ORI USMs found.");
                }

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
                    usmDetails.YOAAllocations = (await connection.QueryAsync<YOAAllocation>(
                        "ORI.spGetORIUSMAllocationsYOA",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    )).ToList();

                    // Fetch Class allocations
                    usmDetails.ClassAllocations = (await connection.QueryAsync<ClassAllocation>(
                        "ORI.spGetORIUSMAllocationsClass",


                        parameters,
                        commandType: CommandType.StoredProcedure
                    )).ToList();

                    // Fetch Security allocations
                    usmDetails.SecurityAllocations = (await connection.QueryAsync<SecurityAllocation>(
                        "ORI.spGetORIUSMAllocationsSecurity",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    )).ToList();

                    // Fetch Event allocations
                    usmDetails.EventAllocations = (await connection.QueryAsync<EventAllocation>(
                        "ORI.spGetORIUSMAllocationsEvent",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    )).ToList();

                    return usmDetails;
                }
                else
                {
                    throw new Exception($"No ORI USM found with ID: {ORIUSMID}.");
                }
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

                // Process Removed Filters
                if (model.RemovedFilters != null && model.RemovedFilters.Any()) // Null and empty check
                {
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
                }

                // Process Added/Updated Filters
                if (model.Filters != null && model.Filters.Any())
                {
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
                }

                // Remove  Allocations
                if (model.RemovedPolicyAllocations != null && model.RemovedPolicyAllocations.Any())
                {
                    foreach (var allocation in model.RemovedPolicyAllocations)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", allocation.ORIPolicyReference);
                        parameters.Add("@YOA", allocation.YOA);
                        parameters.Add("@Class", allocation.Class);
                        parameters.Add("@Syndicate", allocation.Syndicate);
                        parameters.Add("@LastUpdatedBy", userNameFinal);

                        await db.ExecuteAsync("ORI.spDeletePolicyAllocations", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
                    }
                }                

                // Remove Agg Deductibles
                if (model.RemovedAggDeductibles != null && model.RemovedAggDeductibles.Any())
                {
                    foreach (var aggDeductible in model.RemovedAggDeductibles)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@ApplicationPriority", aggDeductible.ApplicationPriority);
                        parameters.Add("@Peril", aggDeductible.Peril);
                        parameters.Add("@PerilRegion", aggDeductible.PerilRegion);
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spDeleteAggDeductibles", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Remove FX Rates
                if (model.RemovedPolicyFXRates != null && model.RemovedPolicyFXRates.Any())
                {
                    foreach (var rate in model.RemovedPolicyFXRates)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@FromCurrency", rate.FromCurrency);
                        parameters.Add("@ToCurrency", rate.ToCurrency);                        
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spDeletePolicyFXRates", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Process Allocations
                if (model.PolicyAllocations != null && model.PolicyAllocations.Any())
                {
                    foreach (var allocation in model.PolicyAllocations)
                    {
                        await UpsertPolicyAllocations(db, allocation, userNameFinal, transaction, model.ORIPolicyReference);
                    }
                }               

                // Process Agg Deductibles
                if (model.AggDeductibles != null && model.AggDeductibles.Any())
                {
                    foreach (var aggDeductible in model.AggDeductibles)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@Deductible", aggDeductible.Deductible);
                        parameters.Add("@ApplicationPriority", aggDeductible.ApplicationPriority);
                        parameters.Add("@Peril", aggDeductible.Peril);
                        parameters.Add("@PerilRegion", aggDeductible.PerilRegion);
                        parameters.Add("@Note", aggDeductible.Note);
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spUpsertAggDeductibles", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Process FX Rates
                if (model.PolicyFXRates != null && model.PolicyFXRates.Any())
                {
                    foreach (var rate in model.PolicyFXRates)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@FromCurrency", rate.FromCurrency);
                        parameters.Add("@ToCurrency", rate.ToCurrency);
                        parameters.Add("@Rate", rate.Rate);                        
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spUpsertORIPolicyFXRates", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Step 9: Update Policy Metadata
                var metaDataParameters = new DynamicParameters();
                metaDataParameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                metaDataParameters.Add("@UseContractCurrency", model.UseContractCurrency);
                metaDataParameters.Add("@FXRateApplicationDate", model.FXRateApplicationDate);
                metaDataParameters.Add("@FXTreatment", model.FXTreatment);
                metaDataParameters.Add("@InuringPriority", model.InuringPriority);
                metaDataParameters.Add("@CededPremiumCalculation", model.CededPremiumCalculation);
                metaDataParameters.Add("@Overrider", model.Overrider);
                metaDataParameters.Add("@PC", model.PC);
                metaDataParameters.Add("@UWExpenses", model.UWExpenses);
                metaDataParameters.Add("@QSBasis", model.QSBasis);
                metaDataParameters.Add("@OverriderBasis", model.OverriderBasis);
                metaDataParameters.Add("@UWExpensesBasis", model.UWExpensesBasis);
                metaDataParameters.Add("@PCProfitBasis", model.PCProfitBasis);
                metaDataParameters.Add("@NilPCOverride", model.NilPCOverride); metaDataParameters.Add("@InceptionOverride", model.InceptionOverride);
                metaDataParameters.Add("@ExpiryOverride", model.ExpiryOverride);
                metaDataParameters.Add("@BasisOfCoverCodeOverride", model.BasisOfCoverCodeOverride);
                metaDataParameters.Add("@OrderOverride", model.OrderOverride);
                metaDataParameters.Add("@WholeOrOrderOverride", model.WholeOrOrderOverride);
                metaDataParameters.Add("@LimitOverride", model.LimitOverride);
                metaDataParameters.Add("@DeductibleRetentionOverride", model.DeductibleRetentionOverride);
                metaDataParameters.Add("@PolicyTypeOverride", model.PolicyTypeOverride);
                metaDataParameters.Add("@PolicySubTypeOverride", model.PolicySubTypeOverride);
                metaDataParameters.Add("@CessionOverride", model.CessionOverride);
                metaDataParameters.Add("@LastUpdatedBy", model.LastUpdatedBy);

                await db.ExecuteAsync("ORI.spUpsertPolicyDetails", metaDataParameters, commandType: CommandType.StoredProcedure, transaction: transaction);

                transaction.Commit();
                Console.WriteLine($"[SUCCESS] ORI Policy Metadata saved successfully for {model.ORIPolicyReference}");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"[ERROR] Transaction failed: {ex.Message}");
                throw;
            }
            finally
            {
                db.Close();
            }
        }
        private async Task UpsertPolicyAllocations(SqlConnection connection, ORIPolicyAllocation allocation, string userName, SqlTransaction transaction, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@YOA", allocation.YOA);
            parameters.Add("@Class", allocation.Class);
            parameters.Add("@Syndicate", allocation.Syndicate);
            parameters.Add("@YOAAllocation", allocation.YOAAllocation);
            parameters.Add("@ClassAllocation", allocation.ClassAllocation);
            parameters.Add("@SyndicateAllocation", allocation.SyndicateAllocation);
            parameters.Add("@Allocation", allocation.Allocation);
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spUpsertORIPolicyAllocations", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        private async Task UpsertPolicyFXRates(SqlConnection connection, ORIPolicyFXRate fxRate, string userName, SqlTransaction transaction, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@FromCurrency", fxRate.FromCurrency);
            parameters.Add("@Class", fxRate.ToCurrency);
            parameters.Add("@Rate", fxRate.Rate);            
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spUpsertORIPolicyAllocations", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        public async Task<List<ORIFilterItemDefinition>> GetIncludedOrExcludedItems()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = await connection.QueryAsync<ORIFilterItemDefinition>(
                "ORI.spGetIncludedOrExcludedItems",
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception("No included or excluded items found.");
            }
        }
        public async Task<List<DropdownItem>> GetDropdownValues(string filterType)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var storedProcedure = filterType switch
            {
                "Class" => "ORI.spGetListClass",
                "DomicileCountry" => "ORI.spGetListDomicileCountry",
                "Peril" => "ORI.spGetListPeril",
                "PerilRegion" => "ORI.spGetListPerilRegion",
                "PlacementUMR" => null,  // Remain as a textbox
                "RiskCode" => "ORI.spGetListRiskCode",
                "ReservingClass" => "ORI.spGetListReservingClass",
                "StatCode1" => "ORI.spGetListStatCode1",
                "StatCode2" => "ORI.spGetListStatCode2",
                _ => null
            };

            if (string.IsNullOrEmpty(storedProcedure))
                return new List<DropdownItem>(); // No dropdown values for this type

            var result = await connection.QueryAsync<DropdownItem>(
                storedProcedure,
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception($"No dropdown values found for filter type: {filterType}.");
            }
        }
        public async Task SaveORIUSM(ORIUSMModel model)
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
                Console.WriteLine($"[INFO] Saving ORI USM Data for {model.USMID}");

                // Step 1: Process Removed Allocations
                foreach (var allocation in model.RemovedYOAAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@YOA", allocation.YOA);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spDeleteUSMAllocationsYOA", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.RemovedClassAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Class", allocation.Class);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spDeleteUSMAllocationsClass", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.RemovedSecurityAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Security", allocation.Security);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spDeleteUSMAllocationsSecurity", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.RemovedEventAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Event", allocation.Event);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spDeleteUSMAllocationsEvent", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                // Step 2: Process Added or Updated Allocations
                foreach (var allocation in model.YOAAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@YOA", allocation.YOA);
                    parameters.Add("@Allocation", allocation.Allocation);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spUpsertUSMAllocationsYOA", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.ClassAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Class", allocation.Class);
                    parameters.Add("@Allocation", allocation.Allocation);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spUpsertUSMAllocationsClass", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.SecurityAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Security", allocation.Security);
                    parameters.Add("@Allocation", allocation.Allocation);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spUpsertUSMAllocationsSecurity", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                foreach (var allocation in model.EventAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@Event", allocation.Event);
                    parameters.Add("@Allocation", allocation.Allocation);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spUpsertUSMAllocationsEvent", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                }

                transaction.Commit();
                Console.WriteLine($"[SUCCESS] ORI USM Data saved successfully for {model.USMID}");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                Console.WriteLine($"[ERROR] Transaction failed: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<EventMetadataListModel>> GetEventMetadataList()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = await connection.QueryAsync<EventMetadataListModel>(
                "ORI.spGetEventMetadataList",
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception("No event metadata found.");
            }
        }

        public async Task<PagedResult<EventMetadataListModel>> GetEventMetadataPaged(int page, int pageSize, string? eventCode = null, string? peril = null, string? region = null, string? description = null)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = (await connection.QueryAsync<EventMetadataListModel>(
                "ORI.spGetEventMetadataPaged",
                new
                {
                    Page = page,
                    PageSize = pageSize,
                    EventCode = eventCode,
                    Peril = peril,
                    Region = region,
                    Description = description
                },
                commandType: CommandType.StoredProcedure
            )).ToList();

            int total = result.FirstOrDefault()?.TotalCount ?? 0;

            if (result != null)
            {
                return new PagedResult<EventMetadataListModel>
                {
                    Items = result,  // Cast to base model if needed
                    TotalCount = total
                };
            }
            else
            {
                throw new Exception("No event metadata found.");
            }
        }
        public async Task<EventMetadataModel> GetEventMetadata(string eventCode)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var parameters = new DynamicParameters();
            parameters.Add("@EventCode", eventCode, DbType.String);

            var result = await connection.QuerySingleOrDefaultAsync<EventMetadataModel>(
                "ORI.spGetEventMetadata",
                parameters,
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception($"No event metadata found for event code: {eventCode}.");
            }
        }

        public async Task UpsertEventMetadata(EventMetadataModel model)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var parameters = new DynamicParameters();
            parameters.Add("@EventCode", model.EventCode, DbType.String);
            parameters.Add("@Peril", model.Peril, DbType.String);
            parameters.Add("@PerilRegion", model.PerilRegion, DbType.String);
            parameters.Add("@Notes", model.Notes, DbType.String);
            parameters.Add("@LastUpdatedBy", model.LastUpdatedBy, DbType.String);
            parameters.Add("@EventStartDateOverride", model.EventStartDateOverride, DbType.DateTime);
            parameters.Add("@ClaimMadeDateOverride", model.ClaimMadeDateOverride, DbType.DateTime);

            await connection.ExecuteAsync(
                "ORI.spUpsertEventMetadata",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }

        public async Task DeleteEventMetadata(string eventCode, string lastUpdatedBy)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var parameters = new DynamicParameters();
            parameters.Add("@EventCode", eventCode, DbType.String);
            parameters.Add("@LastUpdatedBy", lastUpdatedBy, DbType.String);

            await connection.ExecuteAsync(
                "ORI.spDeleteEventMetadata",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }
        public async Task<List<string>> GetPerilList()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = await connection.QueryAsync<string>(
                "ORI.spGetListPeril",
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result.ToList();
            }
            {
                throw new Exception("No peril list found.");
            }

        }

        public async Task<List<string>> GetPerilRegionList()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = await connection.QueryAsync<string>(
                "ORI.spGetListPerilRegion",
                commandType: CommandType.StoredProcedure
            );

            if (result != null)
            {
                return result.ToList();
            }
            else
            {
                throw new Exception("No peril regions found.");
            }
        }

        public async Task<IEnumerable<Narrative>> GetORIPolicyNarratives(string ORIPolicyReference)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = (await connection.QueryAsync<Narrative>("ORI.spGetORIPolicyNarratives", parameters, commandType: CommandType.StoredProcedure)).ToList();

            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception($"No narratives found for policy reference: {ORIPolicyReference}.");
            }
        }

        public async Task<IEnumerable<PolicySecurity>> GetORIPolicySecurity(string ORIPolicyReference)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            var result = (await connection.QueryAsync<PolicySecurity>("ORI.spGetORIPolicySecurity", parameters, commandType: CommandType.StoredProcedure)).ToList();

            if (result != null)
            {
                return result;
            }
            else
            {
                throw new Exception($"No policy securities found for policy reference: {ORIPolicyReference}.");
            }
        }
                      

        // Difference Notes
        public async Task AddDifferenceNoteAsync(DifferenceNoteModel note)
        {
            const string sql = @"
            INSERT INTO ORI.DifferenceNotes
            (ORIPolicyReference, Metric, RunID, UnadjustedAmount, NoteDate, NotedBy, ExpectedSolve, PrismCorrect, Notes, IsDeleted)
            VALUES (@ORIPolicyReference, @Metric, @RunID, @UnadjustedAmount, GETDATE(), @NotedBy, @ExpectedSolve, @PrismCorrect, @Notes, 0);";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("ORIPolicyReference", note.ORIPolicyReference);
                parameters.Add("Metric", note.Metric);
                parameters.Add("RunID", note.RunID, DbType.Int64);
                parameters.Add("UnadjustedAmount", note.UnadjustedAmount, DbType.Double);
                parameters.Add("NotedBy", note.NotedBy);
                parameters.Add("ExpectedSolve", note.ExpectedSolve, DbType.Boolean);
                parameters.Add("PrismCorrect", note.PrismCorrect, DbType.Boolean);
                parameters.Add("Notes", note.Notes, DbType.String);

                try
                {
                    await connection.ExecuteAsync(sql, parameters, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in AddDifferenceNoteAsync: " + ex.Message);
                    throw;
                }
            }
        }

        // SELECT (newest first, hide soft-deleted)
        public async Task<List<DifferenceNoteModel>> GetDifferenceNotesAsync(string policyRef, int? runId = null)
        {
            var sql = @"
            SELECT ORIPolicyReference, Metric, RunID, UnadjustedAmount, NoteDate, NotedBy, ExpectedSolve, PrismCorrect, Notes, IsDeleted
            FROM ORI.DifferenceNotes
            WHERE ORIPolicyReference = @ORIPolicyReference
              AND ISNULL(IsDeleted, 0) = 0";

            if (runId.HasValue)
                sql += " AND RunID = @RunID";

            sql += " ORDER BY NoteDate DESC;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("ORIPolicyReference", policyRef);
                if (runId.HasValue) parameters.Add("RunID", runId.Value, DbType.Int64);

                try
                {
                    var results = await connection.QueryAsync<DifferenceNoteModel>(sql, parameters, commandType: CommandType.Text);
                    return results.ToList();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in GetDifferenceNotesAsync: " + ex.Message);
                    throw;
                }
            }
        }

        // UPDATE (only ExpectedSolve + Notes)
        public async Task UpdateDifferenceNoteAsync(string policyRef, string metric, long runId, DateTime noteDate, bool expectedSolve, bool prismCorrect, string? notes)
        {
            const string sql = @"
            UPDATE ORI.DifferenceNotes
            SET ExpectedSolve = @ExpectedSolve,
                PrismCorrect = @PrismCorrect,
                Notes = @Notes
            WHERE ORIPolicyReference = @ORIPolicyReference
              AND Metric = @Metric
              AND RunID = @RunID
              AND NoteDate = @NoteDate
              AND ISNULL(IsDeleted, 0) = 0;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("ExpectedSolve", expectedSolve, DbType.Boolean);
                parameters.Add("PrismCorrect", expectedSolve, DbType.Boolean);
                parameters.Add("Notes", notes, DbType.String);
                parameters.Add("ORIPolicyReference", policyRef);
                parameters.Add("Metric", metric);
                parameters.Add("RunID", runId, DbType.Int64);
                parameters.Add("NoteDate", noteDate, DbType.DateTime);

                try
                {
                    await connection.ExecuteAsync(sql, parameters, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in UpdateDifferenceNoteAsync: " + ex.Message);
                    throw;
                }
            }
        }

        // SOFT DELETE
        public async Task SoftDeleteDifferenceNoteAsync(string policyRef, string metric, long runId, DateTime noteDate)
        {
            const string sql = @"
            UPDATE ORI.DifferenceNotes
            SET IsDeleted = 1
            WHERE ORIPolicyReference = @ORIPolicyReference
              AND Metric = @Metric
              AND RunID = @RunID
              AND NoteDate = @NoteDate
              AND ISNULL(IsDeleted, 0) = 0;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("ORIPolicyReference", policyRef);
                parameters.Add("Metric", metric);
                parameters.Add("RunID", runId, DbType.Int64);
                parameters.Add("NoteDate", noteDate, DbType.DateTime);

                try
                {
                    await connection.ExecuteAsync(sql, parameters, commandType: CommandType.Text);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in SoftDeleteDifferenceNoteAsync: " + ex.Message);
                    throw;
                }
            }

        }

        public async Task<List<ORIPolicyPremiumModel>> GetORIPolicyPremiums(string oriPolicyReference, string? period = null, bool includeDeleted = false)
        {
            const string baseSql = @"
        SELECT ORIPolicyReference, Period, IsFinalAdjusted, GrossSubjectPremium, AdjustableRate, MinimumPremium,
               LastUpdatedBy, LastUpdatedDate, IsDeleted
        FROM ORI.ORIPolicyPremium
        WHERE ORIPolicyReference = @ORIPolicyReference
          /**period**/
          /**deleted**/
        ORDER BY LastUpdatedDate DESC;";

            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            // Build SQL with optional filters
            var sql = baseSql
                .Replace("/**period**/", period is null ? "" : "AND Period = @Period")
                .Replace("/**deleted**/", includeDeleted ? "" : "AND ISNULL(IsDeleted, 0) = 0");

            var p = new DynamicParameters();
            p.Add("ORIPolicyReference", oriPolicyReference);
            if (period is not null) p.Add("Period", period);

            var rows = await connection.QueryAsync<ORIPolicyPremiumModel>(sql, p, commandType: CommandType.Text);
            return rows.ToList();
        }

        // Returns the active (non-deleted) row for a given period if it exists
        public async Task<ORIPolicyPremiumModel?> GetCurrentORIPolicyPremiumAsync(string oriPolicyReference, string period)
        {
            var list = await GetORIPolicyPremiums(oriPolicyReference, period, includeDeleted: false);
            return list.FirstOrDefault();
        }

        // Upsert that soft-deletes previous iterations for the same Policy+Period
        public async Task UpsertORIPolicyPremiumAsync(string oriPolicyReference, string period, bool isFinalAdjusted, decimal? grossSubjectPremium, decimal? adjustableRate, 
            decimal? minimumPremium, bool isDeleted)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var context = _httpContextAccessor.HttpContext;
            string userNameFinal = context?.User?.Identity?.Name ?? "UnknownUser";

            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", oriPolicyReference, DbType.String);
            parameters.Add("@Period", period, DbType.String);
            parameters.Add("@IsFinalAdjusted", isFinalAdjusted, DbType.Boolean);
            parameters.Add("@GrossSubjectPremium", grossSubjectPremium, DbType.Decimal);
            parameters.Add("@AdjustableRate", adjustableRate, DbType.Decimal);
            parameters.Add("@MinimumPremium", minimumPremium, DbType.Decimal);
            parameters.Add("@LastUpdatedBy", userNameFinal, DbType.String);
            parameters.Add("@IsDeleted", isDeleted);

            await connection.ExecuteAsync(
                "ORI.spUpsertORIPolicyPremium",
                parameters,
                commandType: CommandType.StoredProcedure
            );
        }
    }
}

