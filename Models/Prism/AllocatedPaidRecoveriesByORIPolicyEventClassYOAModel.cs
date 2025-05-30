namespace Sandbox.Models.Prism
{
    public class AllocatedPaidRecoveriesByORIPolicyEventClassYOAModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }        
        public string Class { get; set; }
        public int? YOA { get; set; }
        public decimal Paid_SCCInContractCcy { get; set; }
        public decimal PaidBasisRecoveriesInContractCcy { get; set; }        
        public decimal Paid_SCCInContractCcy_alloc { get; set; }
        public decimal PaidBasisRecoveriesInContractCcy_alloc { get; set; }
    }
}
