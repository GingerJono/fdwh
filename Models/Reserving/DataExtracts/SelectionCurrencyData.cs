namespace Sandbox.Models.Reserving.DataExtracts
{
    // OUTPUT from spGetSelectionCurrencyForEdit
    public class SelectionCurrencyData
    {
        public required int ReservingHeaderID { get; set; }
        public required string Class { get; set; }
        public required string ReservingClass { get; set; }
        public required int YOA { get; set; }
        public required string SettCcy { get; set; }
        public double UltimateGGWPSetValue { get; set; }
        public double NCBPCSwingSetValue { get; set; }
        public double InwardsRIPsSetValue { get; set; }

        public double ActualPaidExLFCat { get; set; }
        public double ActualLFCat { get; set; }
        public double ActualOSCat { get; set; }
        public double ActualPaidExLFLarge { get; set; }
        public double ActualLFLarge { get; set; }
        public double ActualOSLarge { get; set; }
        public double ActualPaidExLFAttr { get; set; }
        public double ActualLFAttr { get; set; }
        public double ActualOSAttr { get; set; }
        public double ActualGGWP { get; set; }
        public double ActualGNWP { get; set; }
        public double ActualGGSP { get; set; }
        public double ActualGNSP { get; set; }
		public double ActualGGEP { get; set; }
		public double ActualGNEP { get; set; }
		public double ActualSignedInwardsRIPs { get; set; }
        public double ActualSignedNCBPCSwing { get; set; }

		public double PlanGGWP { get; set; }
		public double PlanGNWP { get; set; }
		public double PlanUltimateClaimsCat { get; set; }
		public double PlanUltimateClaimsLarge { get; set; }
		public double PlanUltimateClaimsAttr { get; set; }
		public double PlanSignedInwardsRIPs { get; set; }
		public double PlanSignedNCBPCSwing { get; set; }

	}
}
