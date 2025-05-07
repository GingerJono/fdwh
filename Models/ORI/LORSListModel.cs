using System;

namespace Sandbox.Models.ORI
{
	public class LORSListModel
	{
		public string FileName { get; set; }
		public int PolicySequence { get; set; }
		public string ORIPolicyReference { get; set; }
		public DateTime? ProcessedDate { get; set; }
		public TimeSpan? ProcessedTime { get; set; }
		public decimal Amount { get; set; }
	}
}
