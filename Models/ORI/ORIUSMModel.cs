using System;

namespace Sandbox.Models.ORI
{
	public class ORIUSMModel
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

		// Collection of narrative lines
		public IEnumerable<USMNarrative> Narratives { get; set; }
		public List<YOAAllocation> YOAAllocations { get; set; }
		public List<COBAllocation> COBAllocations { get; set; }
		public List<SecurityAllocation> SecurityAllocations { get; set; }
		public List<EventAllocation> EventAllocations { get; set; }
		public List<YOAAllocation> RemovedYOAAllocations { get; set; } = new();
		public List<COBAllocation> RemovedCOBAllocations { get; set; } = new();
		public List<SecurityAllocation> RemovedSecurityAllocations { get; set; } = new();
		public List<EventAllocation> RemovedEventAllocations { get; set; } = new();

	}

	public class USMNarrative
	{
		public string LineNo { get; set; }
		public int LineNoOccurrence { get; set; }
		public string NarrativeLine { get; set; }
	}

	public class YOAAllocation
	{
		public int YOA { get; set; }
		public decimal Allocation { get; set; }
	}

	public class COBAllocation
	{
		public string COB { get; set; }
		public decimal Allocation { get; set; }
	}

	public class SecurityAllocation
	{
		public string Security { get; set; }
		public decimal Allocation { get; set; }
	}

	public class EventAllocation
	{
		public string Event { get; set; }
		public decimal Allocation { get; set; }
	}
}