namespace Sandbox.Models.Prism
{
    public class ORIPolUltimateClaimsMappingModel
    {
        public int RunID { get; set; }
        public string ContractCcy { get; set; }
        public string ORIPolicyReference { get; set; }
        public string Class { get; set; }
        public string ReservingClass { get; set; }
        public int YOA { get; set; }
        public string EventCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string Ccy { get; set; }
        public decimal UltimateClaims { get; set; }
        public string Peril { get; set; }
        public string PerilRegion { get; set; }
        public decimal FXRateFromCcyToContractCcy { get; set; }
        public decimal UltimateClaimsInContractCcy { get; set; }
    }
}
