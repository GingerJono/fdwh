using System;

namespace Sandbox.Models.ORI
{
	public class LORSModel
	{
		public required string FileName { get; set; }
		public int PolicySequence { get; set; }
		public required string ORIPolicyReference { get; set; }
		public DateTime? ProcessedDate { get; set; }
		public required string ProcessedTime { get; set; }
		public decimal Amount { get; set; }
		public List<LORSReinsurerModel> LORSReinsurers { get; set; } = new List<LORSReinsurerModel>();
	}
}
