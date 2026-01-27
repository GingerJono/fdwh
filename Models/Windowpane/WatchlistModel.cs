namespace Sandbox.Models.Windowpane
{
	public class WatchlistItem
	{
		public long WatchlistID { get; set; }
		public string TeamMember { get; set; }
		public string WatchlistType { get; set; }
		public string PolicyReference { get; set; }
		public string UCR { get; set; }
		public string COR { get; set; }
		public string DOL { get; set; }
		public string WLCode { get; set; }
		public string Claimant { get; set; }
		public string LossType { get; set; }
		public string WatchlistDescription { get; set; }
		public int InLitigation { get; set; }
		public string Jurisdiction { get; set; }
		public int IsActive { get; set; }
	}

	public class WatchlistUpdate
	{
		public long WatchlistID { get; set; }
		public long NthUpdate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdateDate { get; set; }
		public int IsChaser { get; set; }
		public int IsUpdate { get; set; }
		public decimal? CurrentReserveDaleShare { get; set; }
		public string ReservingConfidenceRating { get; set; }
		public bool? IBNRRecommended { get; set; }
		public decimal? IBNRAmountUSD { get; set; }
		public string RIApplicable { get; set; }
		public string UpdateNarrative { get; set; }
	}

	public class WatchlistWithLatestUpdate
	{
		public long WatchlistID { get; set; }
		public string TeamMember { get; set; }
		public string WatchlistType { get; set; }
		public string PolicyReference { get; set; }
		public string UCR { get; set; }
		public string COR { get; set; }
		public string DOL { get; set; }
		public string WLCode { get; set; }
		public string Claimant { get; set; }
		public string LossType { get; set; }
		public string WatchlistDescription { get; set; }
		public int InLitigation { get; set; }
		public string Jurisdiction { get; set; }
		public int IsActive { get; set; }
		public long? NthUpdate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime? UpdateDate { get; set; }
		public int? IsChaser { get; set; }
		public int? IsUpdate { get; set; }
		public decimal? CurrentReserveDaleShare { get; set; }
		public string ReservingConfidenceRating { get; set; }
		public bool? IBNRRecommended { get; set; }
		public decimal? IBNRAmountUSD { get; set; }
		public string RIApplicable { get; set; }
		public string UpdateNarrative { get; set; }
	}
}
