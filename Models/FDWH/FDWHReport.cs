namespace Sandbox.Models.FDWH
{
	public class FDWHReport
	{
		public int ReportID { get; set; }
		public string ReportName { get; set; }
		public string StoredProcName { get; set; }
		public int VersionNumber { get; set; }
		public string Description { get; set; }
		public bool IsActive { get; set; }
	}

	public class SUAVersion
	{
		public int VersionID { get; set; }
		public string Version { get; set; }
		public string Syndicate { get; set; }
		public int ProcessingMonth { get; set; }
		public string UploadedBy { get; set; }
		public DateTime UploadedDate { get; set; }
		public bool IsActive { get; set; }
		public string Comments { get; set; }

		public string DisplayText => $"{Version} - {Comments}";
	}

	public class FDWHReportRun
	{
		public int RunID { get; set; }
		public int ReportID { get; set; }
		public string ParametersJSON { get; set; }
		public int ReportVersion { get; set; }
		public DateTime RunDate { get; set; }
		public string RunBy { get; set; }
		public string Status { get; set; }
		public string ResultSummary { get; set; }
		public string FilePath { get; set; }
		public int RowCount { get; set; }
	}
}
