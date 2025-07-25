namespace Sandbox.Models.Prism
{
    public class ORIPolicyToUltimateClaimsMappingModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public DateTime? FXRateApplicationDate { get; set; }
        public string? ContractCcy { get; set; }
        public int? IsCommuted { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public string? YOA { get; set; }
        public string? EventCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string? Ccy { get; set; }
        public string? Peril { get; set; }
        public string? PerilRegion { get; set; }
        public double? FXRateFromCcyToContractCcy { get; set; }
        public double? UltimateClaims { get; set; }
        public double? UltimateClaimsInContractCcy { get; set; }
        public long RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}
