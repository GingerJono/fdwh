namespace Sandbox.Models.Prism
{
    public class AllocatedPaidRecoveriesByORIPolicyEventClassYOAModel
    {
        public int RunID { get; set; }
        public string ORIPolicyReference { get; set; }
        public string EventCode { get; set; }
        public string ContractCcy { get; set; }

        public decimal? PaidRecoveriesInContractCcy { get; set; }
        public string Class { get; set; }
        public int? PolicyYOA { get; set; }

        public decimal? Paid_SCCInContractCcy { get; set; }
        public decimal? Paid_SCCInContractCcy_alloc { get; set; }
        public decimal? PaidRecoveriesInContractCcy_alloc { get; set; }
    }
}
