namespace Sandbox.Models.Prism
{
    public class IncurredClaimsByORIPolicyByEventModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }

        public decimal? Paid_SCCInContractCcy { get; set; }
        public decimal? Incurred_SCCInContractCcy { get; set; }
        public decimal? PaidRecoveriesInContractCcy { get; set; }
        public decimal? IncurredRecoveriesInContractCcy { get; set; }
        public decimal? PaidBasisRIPsInContractCcy { get; set; }
        public decimal? IncurredBasisRIPsInContractCcy { get; set; }
        public decimal? ResidualPaid_SCCInContractCcy { get; set; }
        public decimal? ResidualIncurred_SCCInContractCcy { get; set; }
    }
}
