namespace Sandbox.Models.Prism
{
    public class AllocatedRecoveriesAndRIPsModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;
        public string Currency { get; set; } = string.Empty;
        public string? Class { get; set; }
        public string? YOA { get; set; }
        public string? Security { get; set; }

        public double? ActualRecoveries { get; set; }
        public double? ActualRIPs { get; set; }

        public double? PaidBasisRecoveries { get; set; }
        public double? IncurredBasisRecoveries { get; set; }
        public double? UltimateBasisRecoveries { get; set; }

        public double? PaidBasisRIPs { get; set; }
        public double? IncurredBasisRIPs { get; set; }
        public double? UltimateBasisRIPs { get; set; }

        public long RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}
