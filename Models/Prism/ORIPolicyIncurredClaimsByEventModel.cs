namespace Sandbox.Models.Prism
{
    public class ORIPolicyIncurredClaimsByEventModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string EventCode { get; set; } = string.Empty;

        public string? ContractCcy { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public long? IsCommuted { get; set; }
        public long? AdjustmentID { get; set; }

        public double? Paid { get; set; }
        public double? Incurred { get; set; }

        public double? PaidBasisRecoveries { get; set; }
        public double? IncurredBasisRecoveries { get; set; }

        public double? PaidBasisRIPs { get; set; }
        public double? IncurredBasisRIPs { get; set; }

        public double? PaidAllocatedAmountPure { get; set; }
        public double? PaidAllocatedAmountPreExhaustion { get; set; }

        public double? IncurredAllocatedAmountPure { get; set; }
        public double? IncurredAllocatedAmountPreExhaustion { get; set; }

        public double? ResidualPaid { get; set; }
        public double? ResidualIncurred { get; set; }

        public double? DeductibleRetention { get; set; }
        public long? RunID { get; set; }
    }
}
