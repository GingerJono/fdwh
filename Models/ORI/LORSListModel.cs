using System;

namespace Sandbox.Models.ORI
{
	public class LORSListModel
	{
		public required string FileName { get; set; }
		public int PolicySequence { get; set; }
		public required string ORIPolicyReference { get; set; }
		public DateTime? ProcessedDate { get; set; }
		public required string ProcessedTime { get; set; }
		public decimal Amount { get; set; }
	}
}
