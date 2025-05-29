using System;

namespace Sandbox.Models.ORI
{
	public class EventMetadataModel
	{
		public string EventCode { get; set; }
        public string? EventDescription { get; set; }
        public string Peril { get; set; }
		public string PerilRegion { get; set; }
		public string EventStartDate { get; set; }
        public string EventStartDateOverride { get; set; }
        public int NumberOfClaims { get; set; }
        public double IncurredUSDQtr { get; set; }
        public string Notes { get; set; }
		public DateTime LastUpdated { get; set; }
		public string LastUpdatedBy { get; set; }
		public bool IsDeleted { get; set; }		
		public bool IsDerived { get; set; }
	}
}
