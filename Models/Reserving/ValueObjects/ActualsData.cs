namespace Sandbox.Models.Reserving.ValueObjects
{
    // output from spGetSpecificLossesForEdit
    public class ActualsData
    {
        public required int ReservingHeaderID { get; set; }
        public required string Class { get; set; }
        public required string ReservingClass { get; set; }
        public int YOA { get; set; }
        public required string SettCcy { get; set; }
		public required double GGWP { get; set; }
		public required double GNWP { get; set; }
		public required double GGSP { get; set; }
		public required double GNSP { get; set; }
		public required double PaidLossFunds { get; set; }
		public required double PaidNonLossFunds { get; set; }
		public required double OS { get; set; }
		public required double Incurred { get; set; }
	}
}
