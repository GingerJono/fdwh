namespace Sandbox.Models.Windowpane
{
	public class CytoraCheckingModel
	{
		public List<CytoraCheck> CytoraChecks { get; set; } = new List<CytoraCheck>();
	}

	public class CytoraCheck
	{
		public int JobID { get; set; }
		public DateTime? ProcessingStart { get; set; }
		public DateTime? ProcessingEnd { get; set; }
		public string ProcessingStatus { get; set; }
		public string ProcessingNotes { get; set; }
		public string FileName { get; set; }
		public string EmailSubject { get; set; }
		public string EmailFrom { get; set; }
		public string EmailTo { get; set; }
		public DateTime? EmailDateSent { get; set; }
		public decimal? EmailFileSizeInMB { get; set; }
		public DateTime? CytoraDigitiser1Start { get; set; }
		public string CytoraUploadID { get; set; }
		public string CytoraFileID { get; set; }
		public string CytoraJobID { get; set; }

		// Cytora outputs
		public string OutputInsuredName { get; set; }
		public string OutputInsuredDomicile { get; set; }
		public string OutputInsuredState { get; set; }
		public string OutputReinsuredName { get; set; }
		public string OutputReinsuredDomicile { get; set; }
		public string OutputReinsuredState { get; set; }
		public string OutputBrokerCompany { get; set; }
		public string OutputBrokerContact { get; set; }
		public string OutputLineOfBusiness { get; set; }
		public string OutputPolicyType { get; set; }
		public string OutputUnderwriter { get; set; }
		public DateTime? OutputInceptionDate { get; set; }
		public DateTime? OutputExpiryDate { get; set; }
		public string OutputRiskLocation { get; set; }
		public string OutputAdditionalParties { get; set; }
		public string OutputSubmissionSummary { get; set; }
		public string OutputNewRenewal { get; set; }
		public string OutputRenewedFrom { get; set; }
		public string OutputRenewalTermsComparison { get; set; }

		// NDEX join
		public string NDEXInsuredName { get; set; }
		public string NDEXDomicileCountry { get; set; }
		public string NDEXInsuredState { get; set; }
		public string NDEXReinsuredName { get; set; }
		public string NDEXReinsuredDomicile { get; set; }
		public string NDEXReinsuredState { get; set; }
		public string NDEXBrokerCompany { get; set; }
		public string NDEXBrokerContact { get; set; }
		public string NDEXLineOfBusiness { get; set; }
		public string NDEXPolicyType { get; set; }
		public string NDEXUnderwriter { get; set; }
		public DateTime? NDEXInceptionDate { get; set; }
		public DateTime? NDEXExpiryDate { get; set; }
		public string NDEXRiskLocation { get; set; }
		public string NDEXNewRenewal { get; set; }
		public string NDEXRenewedFrom { get; set; }
	}
}
