namespace Sandbox.Models.Prism
{
    public class ORIPoliciesModel
    {
        public string ORIPolicyReference { get; set; } = string.Empty;
        public string? ORIPillar { get; set; }
        public bool UseContractCurrency { get; set; }
        public DateTime? FXRateApplicationDate { get; set; }
        public string? FXTreatment { get; set; }
        public string? PolicyType { get; set; }
        public string? PolicyDescription { get; set; }
        public string? ContractCurrency { get; set; }
        public DateTime? Inception { get; set; }
        public DateTime? Expiry { get; set; }
        public string? BasisOfCoverCode { get; set; }
        public string? BasisOfCover { get; set; }
        public double? OrderPercent { get; set; }
        public string? WholeOrOder { get; set; }
        public long? TotalReinstatements { get; set; }
        public double? Limit { get; set; }
        public double? DeductibleRetention { get; set; }
        public double? Aggregate { get; set; }
        public int? InuringPriority { get; set; }
        public int? Commuted { get; set; }
        public double? Cession { get; set; }
        public double? EstimatedPremium { get; set; }
        public double? ResidualLimitPaidBasis { get; set; }
        public double? ResidualLimitIncurredBasis { get; set; }
        public double? ResidualLimitUltimateBasis { get; set; }
        public long RunID { get; set; }
        public long? AdjustmentID { get; set; }
    }
}
