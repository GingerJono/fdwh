using System;

namespace Sandbox.Models.ORI
{
	public class ORIUSMListModel
	{
		public string USMID { get; set; }
		public string ORIPolicyReference { get; set; }
		public int? LPSONo { get; set; }
		public DateTime? LPSODate { get; set; }
		public int? LPSOVersionNo { get; set; }
		public int? UserSequenceNo { get; set; }
		public int? SyndicateNo { get; set; }
		public int? InstalmentNo { get; set; }
		public string TreatySection { get; set; }
		public int? SyndicateLineNo { get; set; }
		public string USMCaCategoryDesc { get; set; }
		public string ClosingCcy { get; set; }
		public string SettCcy { get; set; }
		public double? LineAmountSCC { get; set; }
		// Total Allocations
		public decimal TotalYOAAllocation { get; set; }
		public decimal TotalCOBAllocation { get; set; }
		public decimal TotalSecurityAllocation { get; set; }
		public decimal TotalEventAllocation { get; set; }
	}
}
