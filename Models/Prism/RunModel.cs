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

        public List<RunLogModel> Logs { get; set; } = new();

        public List<ORIPolIncurredClaimsMappingModel> ORIPolIncurredClaimsMapping { get; set; } = new();
        public List<ORIPolUltimateClaimsMappingModel> ORIPolUltimateClaimsMapping { get; set; } = new();
        public List<IncurredClaimsByORIPolicyByEventModel> IncurredClaimsByEvent { get; set; } = new();
        public List<UltimateClaimsByORIPolicyByEventModel> UltimateClaimsByEvent { get; set; } = new();
        public List<AllocatedPaidRecoveriesByORIPolicyEventClassYOAModel> AllocatedPaidRecoveries { get; set; } = new();
        public List<AllocatedIncurredRecoveriesByORIPolicyEventClassYOAModel> AllocatedIncurredRecoveries { get; set; } = new();
        public List<AllocatedUltimateRecoveriesByORIPolicyEventClassYOAModel> AllocatedUltimateRecoveries { get; set; } = new();
        public List<AllocatedRecoveryModel> AllocatedRecoveriesMerged { get; set; } = new();
    }
}
