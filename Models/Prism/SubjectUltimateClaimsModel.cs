namespace Sandbox.Models.Prism
{
    public class SubjectUltimateClaimsModel
    {
        public long? RunID { get; set; }
        public string? ORIPolicyReference { get; set; }
        public string? ContractCcy { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public string? PolicyType { get; set; }
        public string? WholeOrOrder { get; set; }
        public string? Class { get; set; }
        public string? ReservingClass { get; set; }
        public long? YOA { get; set; }
        public string? DistributionChannel { get; set; }
        public string? EventCode { get; set; }
        public DateTime? EventDate { get; set; }
        public string? Ccy { get; set; }
        public double? UltimateClaims { get; set; }
        public string? Peril { get; set; }
        public string? PerilRegion { get; set; }
        public double? FXRate { get; set; }
        public double? UltimateClaimsInContractCcy { get; set; }
        public bool? is_proportional { get; set; }
        public string? Currency { get; set; }
    }
}
