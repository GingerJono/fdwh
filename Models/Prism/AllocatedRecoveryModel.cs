namespace Sandbox.Models.Prism
{
    public class AllocatedRecoveryModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }
        public string Class { get; set; }
        public int YOA { get; set; }
        public decimal Paid_SCCInContractCcy { get; set; }
        public decimal PaidRecoveriesInContractCcy_alloc { get; set; }
        public decimal Incurred_SCCInContractCcy { get; set; }
        public decimal IncurredRecoveriesInContractCcy_alloc { get; set; }
        public decimal UltimateClaimsInContractCcy { get; set; }
        public decimal UltimateRecoveriesInContractCcy_alloc { get; set; }
        public decimal PaidBasisRIPsInContractCcy { get; set; }
        public decimal IncurredBasisRIPsInContractCcy { get; set; }
        public decimal UltimateBasisRIPsInContractCcy { get; set; }
    }
}
