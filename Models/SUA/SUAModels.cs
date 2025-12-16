namespace Sandbox.Models.SUA
{
	public class SUAVersion
	{
		public int ID { get; set; }
		public string Version { get; set; }
		public int ProcessingMonth { get; set; }
		public string Syndicate { get; set; }
		public string Comments { get; set; }
		public DateTime UploadDate { get; set; }
		public string UploadedBy { get; set; }
		public int RowCount { get; set; }
		public string Status { get; set; } // "Success" or "Failed"
		public string ErrorMessage { get; set; }
	}

	public class SUA
	{
		public int ID { get; set; }
		public int SUAVersionID { get; set; }
		public string Version { get; set; }
		public int YOA { get; set; }
		public string ClassCode { get; set; }
		public string ClassName { get; set; }
		public string ReservingClass { get; set; }
		public string DistributionChannel { get; set; }
		public string SettCcy { get; set; }
		public string Item { get; set; }
		public string ClaimsDetail { get; set; }
		public string RIType { get; set; }
		public decimal? ValueSettCcy { get; set; }
		public string Comment { get; set; }
	}

	public class SUAVersionSummary
	{
		public int ID { get; set; }
		public string Version { get; set; }
		public int ProcessingMonth { get; set; }
		public string Syndicate { get; set; }
		public string Comments { get; set; }
		public DateTime UploadDate { get; set; }
		public string UploadedBy { get; set; }
		public int RowCount { get; set; }
		public string Status { get; set; }
		public decimal TotalValueSettCcy { get; set; }
	}
}
