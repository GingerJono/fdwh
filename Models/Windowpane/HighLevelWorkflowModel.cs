namespace Sandbox.Models.Windowpane
{
	public class HighLevelWorkflowModel
	{
		public List<HighLevelWorkflowItem> WorkflowItems { get; set; } = new List<HighLevelWorkflowItem>();
	}

	public class HighLevelWorkflowItem
	{
		public string Policy_Reference { get; set; }
		public string Assured_Name { get; set; }
		public string Line_Underwriter_Initials { get; set; }
		public DateTime? Inception_Date { get; set; }
		public DateTime? Expiry_Date { get; set; }
		public string EPI_Settlement_Currency { get; set; }
		public decimal? Actual_Estimated_Premium { get; set; }
		public string Broker_Pseudonym { get; set; }
		public string Broker_Number { get; set; }
		public string Broking_Company_Name { get; set; }
		public string Broker_Contact_Name { get; set; }
		public string Renewed_From_Line_Id { get; set; }
		public decimal? Reporting_Line_Percent { get; set; }
		public string Limit_Currency { get; set; }
		public decimal? Limit { get; set; }
		public decimal? Excess { get; set; }
		public string Line_Status_Code { get; set; }
		public decimal? Technical_Premium_Percent { get; set; }
		public decimal? Rate_Pct_Gross { get; set; }
		public string Consortium_Code { get; set; }
		public decimal? Consortium_Line_Percent { get; set; }
		public string Companion_Name { get; set; }
		public decimal? Written_Line_Pct { get; set; }
		public decimal? Signed_Line_Pct { get; set; }
		public DateTime? Settlement_Due_Date { get; set; }
		public decimal USMPrem { get; set; }
		public int? RiskID { get; set; }
		public string Class { get; set; }
		public int? Year_Of_Account { get; set; }
		public decimal? Exposure { get; set; }
	}
}
