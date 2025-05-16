using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using Sandbox.Helpers;
using Sandbox.Models.ORI;

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
                return result.ToList();
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

                return result.ToList();
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

                return result;
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

                return result.ToList();
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

                return result.ToList();
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

                    policyDetails.Narratives = (await connection.QueryAsync<Narrative>(
                        "ORI.spGetORIPolicyNarratives", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    policyDetails.PolicySecurities = (await connection.QueryAsync<PolicySecurity>(
                        "ORI.spGetORIPolicySecurity", parameters, commandType: CommandType.StoredProcedure)).ToList();

                    // Fetch Allocations Class and YOA
                    policyDetails.PolicyAllocationsClass = (await GetPolicyAllocationsClass(connection, policyDetails.ORIPolicyReference)).ToList();
                    policyDetails.PolicyAllocationsYOA = (await GetPolicyAllocationsYOA(connection, policyDetails.ORIPolicyReference)).ToList();
                }

                return policyDetails;
            }
        }
        private async Task<IEnumerable<ORIPolicyAllocationClass>> GetPolicyAllocationsClass(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            return await connection.QueryAsync<ORIPolicyAllocationClass>(
                "ORI.spGetPolicyAllocationsClass",
                parameters,
                commandType: CommandType.StoredProcedure);
        }

        private async Task<IEnumerable<ORIPolicyAllocationYOA>> GetPolicyAllocationsYOA(SqlConnection connection, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            return await connection.QueryAsync<ORIPolicyAllocationYOA>(
                "ORI.spGetPolicyAllocationsYOA",
                parameters,
                commandType: CommandType.StoredProcedure);
        }
        public async Task<IEnumerable<ORIUSMListModel>> GetORIUSMs(int? policyYOA = null, int? usmYear = null)
        {
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection")))
            {
                await connection.OpenAsync();

                var parameters = new DynamicParameters();
                parameters.Add("PolicyYOA", policyYOA, DbType.Int32);
                parameters.Add("USMYear", usmYear, DbType.Int32);

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
                    usmDetails.YOAAllocations = (await connection.QueryAsync<YOAAllocation>(
                        "ORI.spGetORIUSMAllocationsYOA",
                        parameters,
                        commandType: CommandType.StoredProcedure
                    )).ToList();

                    // Fetch COB allocations
                    usmDetails.COBAllocations = (await connection.QueryAsync<COBAllocation>(
                        "ORI.spGetORIUSMAllocationsCOB",
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

                // Step 2: Process Added/Updated Filters
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

                // Step 3: Process Class Allocations
                if (model.PolicyAllocationsClass != null && model.PolicyAllocationsClass.Any())
                {
                    foreach (var allocation in model.PolicyAllocationsClass)
                    {
                        await UpsertPolicyAllocationsClass(db, allocation, userNameFinal, transaction, model.ORIPolicyReference);
                    }
                }

                // Step 4: Process YOA Allocations
                if (model.PolicyAllocationsYOA != null && model.PolicyAllocationsYOA.Any())
                {
                    foreach (var allocation in model.PolicyAllocationsYOA)
                    {
                        await UpsertPolicyAllocationsYOA(db, allocation, userNameFinal, transaction, model.ORIPolicyReference);
                    }
                }

                // Step 5: Remove Class Allocations
                if (model.RemovedPolicyAllocationsClass != null && model.RemovedPolicyAllocationsClass.Any())
                {
                    foreach (var allocation in model.RemovedPolicyAllocationsClass)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@Class", allocation.Class); // Add the key fields for deletion
                                                                    //  You might need YearOfAccount too, depending on your table structure
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spDeletePolicyAllocationsClass", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Step 6: Remove YOA Allocations
                if (model.RemovedPolicyAllocationsYOA != null && model.RemovedPolicyAllocationsYOA.Any())
                {
                    foreach (var allocation in model.RemovedPolicyAllocationsYOA)
                    {
                        var parameters = new DynamicParameters();
                        parameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                        parameters.Add("@YearOfAccount", allocation.YearOfAccount); // Add the key fields for deletion
                        parameters.Add("@LastUpdatedBy", userNameFinal);
                        await db.ExecuteAsync("ORI.spDeletePolicyAllocationsYOA", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
                    }
                }

                // Step 7: Update Policy Metadata
                var metaDataParameters = new DynamicParameters();
                metaDataParameters.Add("@ORIPolicyReference", model.ORIPolicyReference);
                metaDataParameters.Add("@FXRateApplicationDate", model.FXRateApplicationDate);
                metaDataParameters.Add("@FXTreatment", model.FXTreatment);
                metaDataParameters.Add("@InuringPriority", model.InuringPriority);
                metaDataParameters.Add("@CededPremiumCalculation", model.CededPremiumCalculation);
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
        private async Task UpsertPolicyAllocationsClass(SqlConnection connection, ORIPolicyAllocationClass allocation, string userName, SqlTransaction transaction, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@Class", allocation.Class);
            parameters.Add("@Allocation", allocation.Allocation);
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spUpsertPolicyAllocationsClass", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        private async Task UpsertPolicyAllocationsYOA(SqlConnection connection, ORIPolicyAllocationYOA allocation, string userName, SqlTransaction transaction, string ORIPolicyReference)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@YearOfAccount", allocation.YearOfAccount);
            parameters.Add("@Allocation", allocation.Allocation);
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spUpsertPolicyAllocationsYOA", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        private async Task DeletePolicyAllocationsClass(SqlConnection connection, string ORIPolicyReference, string className, string userName, SqlTransaction transaction)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@Class", className);
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spDeletePolicyAllocationsClass", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
        }

        private async Task DeletePolicyAllocationsYOA(SqlConnection connection, string ORIPolicyReference, int yearOfAccount, string userName, SqlTransaction transaction)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference);
            parameters.Add("@YearOfAccount", yearOfAccount);
            parameters.Add("@LastUpdatedBy", userName);

            await connection.ExecuteAsync("ORI.spDeletePolicyAllocationsYOA", parameters, transaction: transaction, commandType: CommandType.StoredProcedure);
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
        public async Task<List<DropdownItem>> GetDropdownValues(string filterType)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var storedProcedure = filterType switch
            {
                "Class" => "ORI.spGetListClass",
                "DomicileCountry" => "ORI.spGetListDomicileCountry",
                "Peril" => "ORI.spGetListPeril",
                "PlacementUMR" => null,  // Remain as a textbox
                "RiskCode" => "ORI.spGetListRiskCode",
                "ReservingClass" => "ORI.spGetListReservingClass",
                "StatCode1" => "ORI.spGetListStatCode1",
                "StatCode2" => "ORI.spGetListStatCode2",
                _ => null
            };

            if (string.IsNullOrEmpty(storedProcedure))
                return new List<DropdownItem>(); // No dropdown values for this type

            var results = await connection.QueryAsync<DropdownItem>(
                storedProcedure,
                commandType: CommandType.StoredProcedure
            );

            return results.ToList();
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

                foreach (var allocation in model.RemovedCOBAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@COB", allocation.COB);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spDeleteUSMAllocationsCOB", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
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

                foreach (var allocation in model.COBAllocations)
                {
                    var parameters = new DynamicParameters();
                    parameters.Add("@ORIUSMID", model.USMID);
                    parameters.Add("@COB", allocation.COB);
                    parameters.Add("@Allocation", allocation.Allocation);
                    parameters.Add("@LastUpdatedBy", userNameFinal);

                    await db.ExecuteAsync("ORI.spUpsertUSMAllocationsCOB", parameters, commandType: CommandType.StoredProcedure, transaction: transaction);
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

            return result.ToList();
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

            return result;
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

            return result.ToList();
        }

        public async Task<List<string>> GetPerilRegionList()
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();

            var result = await connection.QueryAsync<string>(
                "ORI.spGetListPerilRegion",
                commandType: CommandType.StoredProcedure
            );

            return result.ToList();
        }

        public async Task<IEnumerable<Narrative>> GetORIPolicyNarratives(string ORIPolicyReference)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            return (await connection.QueryAsync<Narrative>(
                "ORI.spGetORIPolicyNarratives", parameters, commandType: CommandType.StoredProcedure)).ToList();
        }

        public async Task<IEnumerable<PolicySecurity>> GetORIPolicySecurity(string ORIPolicyReference)
        {
            using var connection = new SqlConnection(_configuration.GetConnectionString("DaleSandboxConnection"));
            await connection.OpenAsync();
            var parameters = new DynamicParameters();
            parameters.Add("@ORIPolicyReference", ORIPolicyReference, DbType.String);

            return (await connection.QueryAsync<PolicySecurity>(
                "ORI.spGetORIPolicySecurity", parameters, commandType: CommandType.StoredProcedure)).ToList();
        }


    }
}

