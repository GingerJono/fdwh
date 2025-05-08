using System;

namespace Sandbox.Models.ORI
{
	public class ORIUSMListModel
	{
		public string USMID { get; set; }
		public string ORIPolicyReference { get; set; }
		public string LPSONo { get; set; }
		public DateTime? LPSODate { get; set; }
		public string LPSOVersionNo { get; set; }
		public string UserSequenceNo { get; set; }
		public string SyndicateNo { get; set; }
		public string InstalmentNo { get; set; }
		public string TreatySection { get; set; }
		public string SyndicateLineNo { get; set; }
		public string USMCaCategoryDesc { get; set; }
		public string ClosingCcy { get; set; }
		public string SettCcy { get; set; }
		public double? LineAmountSCC { get; set; }
		// Total Allocations
		public decimal TotalYOAAllocation { get; set; }
		public decimal TotalCOBAllocation { get; set; }
		public decimal TotalSecurityAllocation { get; set; }
		public decimal TotalEventAllocation { get; set; }
		public bool IsRIP { get; set; }
		public bool IsPC { get; set; }

	}
}
