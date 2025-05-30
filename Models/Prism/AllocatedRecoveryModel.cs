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
        public decimal ActualRecoveriesInContractCcy { get; set; }
        public decimal PaidBasisRecoveriesInContractCcy { get; set; }
        public decimal IncurredBasisRecoveriesInContractCcy { get; set; }
        public decimal UltimateBasisRecoveriesInContractCcy { get; set; }
        public decimal ActualRIPsInContractCcy { get; set; }
        public decimal PaidBasisRIPsInContractCcy { get; set; }
        public decimal IncurredBasisRIPsInContractCcy { get; set; }
        public decimal UltimateBasisRIPsInContractCcy { get; set; }
        public decimal Paid_SCCInContractCcy { get; set; }
        public decimal Incurred_SCCInContractCcy { get; set; }
        public decimal UltimateClaimsInContractCcy { get; set; }
    }
}
