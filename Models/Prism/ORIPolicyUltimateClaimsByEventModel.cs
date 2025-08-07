namespace Sandbox.Models.Prism
{
    public class ORIPolicyUltimateClaimsByEventModel
    {
        public long RunID { get; set; }
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string? EventCode { get; set; }
        public string? ContractCcy { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public int? IsCommuted { get; set; }
        public long? AdjustmentID { get; set; }

        public double? UltimateClaims { get; set; }
        public double? UltimateBasisRecoveries { get; set; }
        public double? UltimateBasisRIPs { get; set; }
        public double? UltimateAllocatedAmountPure { get; set; }
        public double? UltimateAllocatedAmountPreExhaustion { get; set; }
        public double? ResidualUltimateClaims { get; set; }
        public double? DeductibleRetention { get; set; }
    }
}
