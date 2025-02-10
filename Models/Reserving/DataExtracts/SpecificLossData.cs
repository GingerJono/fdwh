namespace Sandbox.Models.Reserving.DataExtracts
{
    // output from spGetSpecificLossesForEdit
    public class SpecificLossData
    {
        public required int ReservingHeaderID { get; set; }
        public required string Class { get; set; }
        public required string ReservingClass { get; set; }
        public int YOA { get; set; }
        public required string Event { get; set; }
		public required string EventType { get; set; }
		public required string UltimateClaimsSelection { get; set; }
		public required string UltimateRIPsSelection { get; set; }
		public required double UltimateRIPsSetPercentageOfClaims { get; set; }
		public required double PaidLF { get; set; }
        public required double PaidExLF { get; set; }
        public required double OS { get; set; }
        public required double Incurred { get; set; }
		public required double IBNR { get; set; }
		public required double UltimateClaims { get; set; }
		public required double UltimateRIPs { get; set; }
	}

	public class SpecificLossCurrencyData
	{
		public required int ReservingHeaderID { get; set; }
		public required string Class { get; set; }
		public required string ReservingClass { get; set; }
		public int YOA { get; set; }
		public required string Event { get; set; }
		public required string SettCcy { get; set; }
		public required double PaidLF { get; set; }
		public required double PaidExLF { get; set; }
		public required double OS { get; set; }
		public required double Incurred { get; set; }
		public required double UltimateClaimsSetValue { get; set; }
		public required double UltimateRIPsSetValue { get; set; }
		public required double IBNR { get; set; }
		public required double UltimateClaims { get; set; }
		public required double UltimateRIPs { get; set; }
	}
}
