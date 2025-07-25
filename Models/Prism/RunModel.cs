namespace Sandbox.Models.Prism
{
    public class RunModel
    {
        public required int RunID { get; set; }
        public required DateTime AsAtDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public required DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? DurationMinutes { get; set; }
        public required string Status { get; set; }
        public string RunUser { get; set; } = string.Empty;
        public string? PrismVersion { get; set; } = string.Empty;
        public string? ProcessingMonth { get; set; } = string.Empty;
        public string? ErrorMessage { get; set; }  = string.Empty;
        public List<RunLogModel> Logs { get; set; } = new();

        public List<AllocatedPremiumModel> AllocatedPremium { get; set; } = new();
        public List<AllocatedRecoveriesAndRIPsModel> AllocatedRecoveriesAndRIPs { get; set; } = new(); 
        public List<ORIPolicyIncurredClaimsByEventModel> ORIPolicyIncurredClaimsByEvent { get; set; } = new();
        public List<ORIActualRecoveriesModel> ORIActualRecoveries { get; set; } = new();
        public List<ORIActualRIPsModel> ORIActualRIPs { get; set; } = new();
        public List<ORIPoliciesModel> ORIPolicies { get; set; } = new();
        public List<ORIPolicyToIncurredClaimsMappingModel> ORIPolicyToIncurredClaimsMapping { get; set; } = new();
        public List<ORIPolicyToInwardPolicyMappingModel> ORIPolicyToInwardPolicyMapping { get; set; } = new();
        public List<ORIPolicyToUltimateClaimsMappingModel> ORIPolicyToUltimateClaimsMapping { get; set; } = new();
        public bool HasOutput
        {
            get
            {
                return this.AllocatedPremium.Count != 0
                    || this.AllocatedRecoveriesAndRIPs.Count != 0
                    || this.ORIPolicyIncurredClaimsByEvent.Count != 0
                    || this.ORIActualRecoveries.Count != 0
                    || this.ORIActualRIPs.Count != 0
                    || this.ORIPolicies.Count != 0
                    || this.ORIPolicyToIncurredClaimsMapping.Count != 0
                    || this.ORIPolicyToInwardPolicyMapping.Count != 0
                    || this.ORIPolicyToUltimateClaimsMapping.Count != 0;
            }
        }

    }
}
