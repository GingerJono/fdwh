namespace Sandbox.Models.SUA
{
	public class SUAVersion
	{
		public int VersionID { get; set; }
		public string Version { get; set; }
		public int? Syndicate { get; set; }
		public int? ProcessingMonth { get; set; }
		public string UploadedBy { get; set; }
		public DateTime? UploadedDate { get; set; }
		public bool? IsActive { get; set; }
		public string Comments { get; set; }
	}

	public class SUA
	{
		public string Version { get; set; }
		public int? YOA { get; set; }
		public string ClassCode { get; set; }
		public string ClassName { get; set; }
		public string ReservingClass { get; set; }
		public string DistributionChannel { get; set; }
		public string SettCCY { get; set; }
		public string Item { get; set; }
		public string ClaimsDetail { get; set; }
		public string RIType { get; set; }
		public decimal? ValueSCC { get; set; }
		public string Comment { get; set; }
	}

	public class SUAVersionSummary
	{
		public int VersionID { get; set; }
		public string Version { get; set; }
		public int? ProcessingMonth { get; set; }
		public int? Syndicate { get; set; }
		public string Comments { get; set; }
		public DateTime? UploadedDate { get; set; }
		public string UploadedBy { get; set; }
		public int RowCount { get; set; }
		public bool? IsActive { get; set; }
		public decimal TotalValueSCC { get; set; }
	}
}
