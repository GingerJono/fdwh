namespace Sandbox.Models.Windowpane
{
	public class NOCModel
	{
		public List<NOCItem> NOCItems { get; set; } = new List<NOCItem>();
	}

	public class NOCItem
	{
		public string Policy_Reference { get; set; }
		public string Assured_Name { get; set; }
		public string Line_Underwriter_Initials { get; set; }
		public string Policy_Status_Description { get; set; }
		public DateTime? Inception_Date { get; set; }
		public DateTime? Settlement_Due_Date { get; set; }
		public string EPI_Settlement_Currency { get; set; }
		public decimal? Actual_Estimated_Premium { get; set; }
		public string Broking_Company_Name { get; set; }
		public string Broker_Contact_Name { get; set; }
		public decimal USMPremPremCcy { get; set; }
		public decimal USMPremOtherCcy { get; set; }
	}
}
