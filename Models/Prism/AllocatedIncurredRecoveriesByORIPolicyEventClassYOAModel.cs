namespace Sandbox.Models.Prism
{
    public class AllocatedIncurredRecoveriesByORIPolicyEventClassYOAModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }

        public decimal? IncurredRecoveriesInContractCcy { get; set; }
        public string Class { get; set; }
        public int? PolicyYOA { get; set; }

        public decimal? Incurred_SCCInContractCcy { get; set; }
        public decimal? Incurred_SCCInContractCcy_alloc { get; set; }
        public decimal? IncurredRecoveriesInContractCcy_alloc { get; set; }
    }
}
