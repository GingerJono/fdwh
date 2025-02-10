namespace Sandbox.Models.Reserving.DataExtracts
{
    // OUTPUT from spGetSelectionCurrencyForEdit
    public class OutputsCYCurrencyData
	{
		public required int ReservingHeaderID { get; set; }
		public required string Class { get; set; }
		public required int YOA { get; set; }
		public required string SettCcy { get; set; }
		public double UltimateGGWP { get; set; }
		public double UltimateDeductions { get; set; }
		public double UltimateGNWP { get; set; }
		public double UltimateInwardsRIPs { get; set; }
		public double UltimateNCBPCSwing { get; set; }
		public double UltimateLossRatio { get; set; }
		public double UnwrittenGGWP { get; set; }
		public double UnwrittenGNWP { get; set; }
		public double EarnedGGWP { get; set; }
		public double EarnedGNWP { get; set; }
		public double UnearnedGGWP { get; set; }
		public double UnearnedGNWP { get; set; }
		public double SpecificUltimateRIPs { get; set; }
		public double SpecificUltimateRIPsCat { get; set; }
		public double SpecificUltimateRIPsLarge { get; set; }
		public double FutureRIPs { get; set; }
		public double WrittenDeductions { get; set; }
		public double PlanDeductions { get; set; }
		public double SpecificUltimateClaims { get; set; }
		public double SpecificIncurredClaims { get; set; }
		public double SpecificUltimateClaimsCat { get; set; }
		public double SpecificIncurredClaimsCat { get; set; }
		public double SpecificUltimateClaimsLarge { get; set; }
		public double SpecificIncurredClaimsLarge { get; set; }
		public double TotalUltimateClaims { get; set; }
		public double TotalPaidExLF { get; set; }
		public double TotalLF { get; set; }
		public double TotalPaid { get; set; }
		public double TotalOS { get; set; }
		public double TotalIncurred { get; set; }
		public double TotalIBNR { get; set; }
		public double SpecificIBNR { get; set; }
		public double NonSpecificIBNR { get; set; }
		public double PaidCat { get; set; }
		public double IncurredCat { get; set; }
		public double SpecificIBNRCat { get; set; }
		public double NonSpecificIBNRCat { get; set; }
		public double IBNRCat { get; set; }
		public double UltimateCat { get; set; }
		public double EarnedCatClaims { get; set; }
		public double PaidLarge { get; set; }
		public double IncurredLarge { get; set; }
		public double SpecificIBNRLarge { get; set; }
		public double NonSpecificIBNRLarge { get; set; }
		public double IBNRLarge { get; set; }
		public double UltimateLarge { get; set; }
		public double EarnedLargeClaims { get; set; }
		public double PaidAttr { get; set; }
		public double IncurredAttr { get; set; }
		public double IBNRAttr { get; set; }
		public double UltimateAttr { get; set; }
		public double EarnedClaims { get; set; }
		public double IBNRandLF { get; set; }
	}
}
