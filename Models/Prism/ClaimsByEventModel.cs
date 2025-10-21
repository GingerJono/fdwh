namespace Sandbox.Models.Prism
{
    public class ClaimsByEventModel
    {      
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;
        public string? ContractCcy { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public string? PolicyType { get; set; }
        public string? WholeOrOrder { get; set; }
        public double? Paid { get; set; }
        public double? Incurred { get; set; }
        public double? PaidInContractCcy { get; set; }
        public double? IncurredInContractCcy { get; set; }
        public double? PaidBasisRecoveries { get; set; }
        public double? IncurredBasisRecoveries { get; set; }
        public double? PaidBasisRIPs { get; set; }
        public double? IncurredBasisRIPs { get; set; }
        public double? PaidAllocatedAmountPure { get; set; }
        public double? PaidAllocatedAmountPreExhaustion { get; set; }
        public double? IncurredAllocatedAmountPure { get; set; }
        public double? IncurredAllocatedAmountPreExhaustion { get; set; }
        public double? ResidualPaidInContractCcy { get; set; }
        public double? ResidualIncurredInContractCcy { get; set; }
        public double? DeductibleRetention { get; set; }
        public double? UltimateClaims { get; set; }
        public double? UltimateClaimsInContractCcy { get; set; }
        public double? UltimateBasisRecoveries { get; set; }
        public double? UltimateBasisRIPs { get; set; }
        public double? UltimateAllocatedAmountPure { get; set; }
        public double? UltimateAllocatedAmountPreExhaustion { get; set; }
        public double? ResidualUltimateClaimsInContractCcy { get; set; }
        public long RunID { get; set; }
    }
}
