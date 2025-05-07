using System;

namespace Sandbox.Models.ORI
{
	public class ORIPolicyListModel
	{
		public string ORIPolicyReference { get; set; }
		public DateTime? InceptionDate { get; set; }
		public DateTime? ExpiryDate { get; set; }
		public double? Limit { get; set; }
		public double? Retention { get; set; }
		public string PolicyDescription { get; set; }
		public string PolicyType { get; set; }
		public string Broker { get; set; }
		public string Status { get; set; }
		public string FiltersStatus { get; set; }
		public double YOAAllocations { get; set; }
		public double ClassAllocations { get; set; }

	}
}
