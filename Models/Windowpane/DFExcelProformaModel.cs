namespace Sandbox.Models.Windowpane
{
	public class DFExcelProformaModel
	{
		// Main data points
		public string RiskReference { get; set; }
		public string AssuredName { get; set; }
		public DateTime InceptionDate { get; set; }
		public DateTime ExpiryDate { get; set; }
		public string BrokingHouse { get; set; }
		public string BrokerName { get; set; }
		public string RiskCode { get; set; }
		public decimal Limit { get; set; }
		public decimal XS { get; set; }
		public string LloydsLeader { get; set; }
		public string RiskLocation { get; set; }
		public string Occupancy { get; set; }
		public string Perils { get; set; }
		public string Currency { get; set; }
		public decimal TIV { get; set; }
		public bool IsConsortium { get; set; }
		public decimal ConsortiumWrittenLine { get; set; }
		public decimal ConsortiumSignedLine { get; set; }
		public decimal DaleWrittenLine { get; set; }
		public decimal DaleSignedLine { get; set; }
		public bool IsAviva { get; set; }
		public decimal AvivaWrittenLine { get; set; }
		public decimal AvivaSignedLine { get; set; }
		public string NoAvivaReason { get; set; }
		public decimal SlipIncome { get; set; }
		public decimal TP { get; set; }
		public decimal IELR { get; set; }
		public decimal Brokerage { get; set; }
		public decimal OtherDeductions { get; set; }
		public decimal AttritionSplit { get; set; }
		public decimal WindFloodSplit { get; set; }
		public decimal QuakeSplit { get; set; }
		public decimal TerrorismSplit { get; set; }

		// Account Performance - List of records
		public List<AccountPerformanceRecord> AccountPerformance { get; set; }

		public DFExcelProformaModel()
		{
			AccountPerformance = new List<AccountPerformanceRecord>();
		}
	}

	public class AccountPerformanceRecord
	{
		public int YOA { get; set; } // Year of Account
		public decimal Premium { get; set; }
		public decimal Claims { get; set; }
		public decimal ILR { get; set; } // Incurred Loss Ratio
		public decimal RARC { get; set; } // Reinsurance and Acquisition Costs
	}
}
