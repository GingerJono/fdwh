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
        public string? ErrorMessage { get; set; } = string.Empty;

        public bool Submitted { get; set; }
        public List<RunLogModel> Logs { get; set; } = new();

        public List<AllocatedPremiumSignedModel> AllocatedPremiumSigned { get; set; } = new();
        public List<AllocatedPremiumWrittenModel> AllocatedPremiumWritten { get; set; } = new();
        public List<AllocatedOverridersAndProfitCommissionModel> AllocatedOverridersAndProfitCommission { get; set; } = new();
        public List<AllocatedRecoveriesAndRIPsModel> AllocatedRecoveriesAndRIPs { get; set; } = new();
        public List<AllocatedActualRecoveriesModel> AllocatedActualRecoveries { get; set; } = new();
        public List<AllocatedActualRIPsModel> AllocatedActualRIPs { get; set; } = new();
        public List<ORIActualRecoveriesModel> ORIActualRecoveries { get; set; } = new();
        public List<ORIActualRIPsModel> ORIActualRIPs { get; set; } = new();
        public List<ORIPoliciesModel> ORIPolicies { get; set; } = new();
        public List<SubjectClaimsModel> SubjectClaims { get; set; } = new();
        public List<SubjectPoliciesModel> SubjectPolicies { get; set; } = new();
        public bool HasOutput
        {
            get
            {
                return this.AllocatedPremiumSigned.Count != 0
                    || this.AllocatedPremiumWritten.Count != 0
                    || this.AllocatedRecoveriesAndRIPs.Count != 0
                    || this.AllocatedActualRecoveries.Count != 0
                    || this.AllocatedActualRIPs.Count != 0
                    || this.AllocatedOverridersAndProfitCommission.Count != 0
                    || this.ORIActualRecoveries.Count != 0
                    || this.ORIActualRIPs.Count != 0
                    || this.ORIPolicies.Count != 0
                    || this.SubjectClaims.Count != 0
                    || this.SubjectPolicies.Count != 0;
            }
        }

    }
}
