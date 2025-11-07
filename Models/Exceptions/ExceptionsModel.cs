namespace Sandbox.Models.Exceptions
{
	public class ExceptionRecord
	{
		public int ExceptionID { get; set; }
		public int RuleID { get; set; }
		public string BusinessID { get; set; }
		public string Status { get; set; }
		public string PriorStatus { get; set; }
		public string CurrentValue { get; set; }
		public string Reason { get; set; }
		public string Comment { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? LastUpdated { get; set; }
		public string User { get; set; }
	}
	public class ExceptionsList
	{
		public List<ExceptionRecord> Exceptions { get; set; } = new List<ExceptionRecord>();
	}

	public class RuleRecord
	{
		public int RuleID { get; set; }
		public string FieldName { get; set; }
		public string ValueType { get; set; }
		public string Threshold { get; set; }
		public string GreaterThanLessThan { get; set; }
		public string ResponsibleTeam { get; set; }
		public string ReappearanceThreshold { get; set; }
		public string StoredProcedure { get; set; }
		public string Comment { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? LastUpdated { get; set; }
	}
}
