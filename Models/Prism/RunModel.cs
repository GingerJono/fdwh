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

        public List<ORIPolicyIncurredClaimsMappingModel> ORIPolicyIncurredClaimsMapping { get; set; } = new(); 
        public List<ORIPolicyUltimateClaimsMappingModel> ORIPolicyUltimateClaimsMapping { get; set; } = new();
        public List<IncurredClaimsByORIPolicyByEventModel> IncurredClaimsByEvent { get; set; } = new();
        public List<UltimateClaimsByORIPolicyByEventModel> UltimateClaimsByEvent { get; set; } = new();
        public List<CombinedCommutedRecoveriesAndRIPsModel> CombinedCommutedRecoveriesAndRIPs { get; set; } = new();

        public bool HasOutput
        {
            get
            {
                return this.ORIPolicyIncurredClaimsMapping.Count != 0 || this.ORIPolicyUltimateClaimsMapping.Count != 0
                     || this.IncurredClaimsByEvent.Count != 0 || this.UltimateClaimsByEvent.Count != 0
                     || this.CombinedCommutedRecoveriesAndRIPs.Count != 0;
            }
        }
    }
}
