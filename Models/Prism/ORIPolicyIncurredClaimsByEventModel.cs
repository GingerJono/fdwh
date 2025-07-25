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

        public double? Paid_SCCInContractCcy { get; set; }
        public double? Incurred_SCCInContractCcy { get; set; }

        public double? PaidBasisRecoveriesInContractCcy { get; set; }
        public double? IncurredBasisRecoveriesInContractCcy { get; set; }

        public double? PaidBasisRIPsInContractCcy { get; set; }
        public double? IncurredBasisRIPsInContractCcy { get; set; }

        public double? PaidAllocatedAmountPure { get; set; }
        public double? PaidAllocatedAmountPreExhaustion { get; set; }

        public double? IncurredAllocatedAmountPure { get; set; }
        public double? IncurredAllocatedAmountPreExhaustion { get; set; }

        public double? ResidualPaid_SCCInContractCcy { get; set; }
        public double? ResidualIncurred_SCCInContractCcy { get; set; }

        public double? DeductibleRetention { get; set; }
        public long? RunID { get; set; }
    }
}
