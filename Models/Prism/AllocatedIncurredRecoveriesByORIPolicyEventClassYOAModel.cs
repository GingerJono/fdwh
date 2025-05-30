namespace Sandbox.Models.Prism
{
    public class AllocatedIncurredRecoveriesByORIPolicyEventClassYOAModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }        
        public string Class { get; set; }
        public int? YOA { get; set; }
        public decimal? Incurred_SCCInContractCcy { get; set; }
        public decimal? IncurredBasisRecoveriesInContractCcy { get; set; }        
        public decimal? Incurred_SCCInContractCcy_alloc { get; set; }
        public decimal? IncurredBasisRecoveriesInContractCcy_alloc { get; set; }
    }
}
