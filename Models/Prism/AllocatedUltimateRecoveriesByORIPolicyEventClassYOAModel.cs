namespace Sandbox.Models.Prism
{
    public class AllocatedUltimateRecoveriesByORIPolicyEventClassYOAModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }
        public string Class { get; set; }
        public int? YOA { get; set; }
        public decimal UltimateRecoveriesInContractCcy { get; set; }
        public decimal UltimateClaimsInContractCcy { get; set; }
        public decimal UltimateClaimsInContractCcy_alloc { get; set; }
        public decimal UltimateBasisRecoveriesInContractCcy_alloc { get; set; }
    }
}
