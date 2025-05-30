using System;

namespace Sandbox.Models.ORI
{
	public class EventMetadataListModel
	{
		public required string EventCode { get; set; }
		public required string EventStartDate { get; set; }
		public string? Peril { get; set; }
		public string? PerilRegion { get; set; }
		public string? Description { get; set; }
		public int NumberOfClaims { get; set; }
		public double IncurredUSDQtr { get; set; }
		public int TotalCount { get; set; }
		public int IsDerived { get; set; }
	}
}
