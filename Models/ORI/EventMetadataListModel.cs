using System;

namespace Sandbox.Models.ORI
{
	public class EventMetadataListModel
	{
		public string EventCode { get; set; }
		public string EventStartDate { get; set; }
		public string Peril { get; set; }
		public string PerilRegion { get; set; }
		public string EventDescription { get; set; }
		public int NumClaims { get; set; }
		public double IncurredUSDQtr { get; set; }
		public int TotalCount { get; set; }
	}
}
