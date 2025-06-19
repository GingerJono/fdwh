namespace Sandbox.Models.Prism
{
    public class ORIPolicyUltimateClaimsMappingModel
    {
        public long? RunID { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public string? ContractCcy { get; set; }
        public string? ORIPolicyReference { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public long? YOA { get; set; }
        public string? EventCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string? Ccy { get; set; }
        public decimal? UltimateClaims { get; set; }
        public string? Peril { get; set; }
        public string? PerilRegion { get; set; }
        public decimal? FXRateFromCcyToContractCcy { get; set; }
        public decimal? UltimateClaimsInContractCcy { get; set; }
    }
}
