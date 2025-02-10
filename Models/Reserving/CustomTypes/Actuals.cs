using Sandbox.Services;

namespace Sandbox.Models.Reserving.Types
{
	public class Actuals
	{

		// Constructor that accepts IReservingService to retrieve FX rates
		public Actuals(Dictionary<SettCcyEnum, double> fxRates)
		{
			PaidExLFCat = new SettCcySet(fxRates, "Actuals PaidExLFCat");
			LFCat = new SettCcySet(fxRates, "Actuals LFCat");
			OSCat = new SettCcySet(fxRates, "Actuals OSCat");

			PaidExLFLarge = new SettCcySet(fxRates, "Actuals PaidExLFLarge");
			LFLarge = new SettCcySet(fxRates, "Actuals LFLarge");
			OSLarge = new SettCcySet(fxRates, "Actuals OSLarge");
			PaidExLFAttr = new SettCcySet(fxRates, "Actuals PaidExLFAttr");
			LFAttr = new SettCcySet(fxRates, "Actuals LFAttr");
			OSAttr = new SettCcySet(fxRates, "Actuals OSAttr");
			IncurredTotal = new SettCcySet(fxRates, "Actuals IncurredTotal");
			IncurredCat = new SettCcySet(fxRates, "Actuals IncurredCat");
			IncurredLarge = new SettCcySet(fxRates, "Actuals IncurredLarge");
			IncurredAttr = new SettCcySet(fxRates, "Actuals IncurredAttr");
			PaidCat = new SettCcySet(fxRates, "Actuals PaidCat");
			PaidAttr = new SettCcySet(fxRates, "Actuals PaidAttr");
			PaidLarge = new SettCcySet(fxRates, "Actuals PaidLarge");
			PaidTotal = new SettCcySet(fxRates, "Actuals PaidTotal");
			PaidExLFTotal = new SettCcySet(fxRates, "Actuals PaidExLFTotal");
			LFTotal = new SettCcySet(fxRates, "Actuals LFTotal");
			OSTotal = new SettCcySet(fxRates, "Actuals OSTotal");
			GGWP = new SettCcySet(fxRates, "Actuals GGWP");
			WrittenDeductionsCurrency = new SettCcySet(fxRates, "Actuals WrittenDeductionsCurrency");

			WrittenDeductions = new double();
			GNWP = new SettCcySet(fxRates, "Actuals GNWP");
			GGSP = new SettCcySet(fxRates, "Actuals GGSP");
			SignedDeductionsCurrency = new SettCcySet(fxRates, "Actuals SignedDeductionsCurrency");
			SignedDeductions = new double();

			GNSP = new SettCcySet(fxRates, "Actuals GNSP");
			GGEP = new SettCcySet(fxRates, "Actuals GGEP");
			EarnedDeductionsCurrency = new SettCcySet(fxRates, "Actuals EarnedDeductionsCurrency");

			EarnedDeductions = new double();
			GNEP = new SettCcySet(fxRates, "Actuals GNEP");
			SignedInwardsRIPs = new SettCcySet(fxRates, "Actuals SignedInwardsRIPs");
			SignedNCBPCSwing = new SettCcySet(fxRates, "Actuals SignedNCBPCSwing");

			IncurredLossRatio = new double();

		}

		public Actuals()
		{
			// Initialization empty
		}

		public SettCcySet PaidExLFCat { get; set; } = new SettCcySet("Actuals PaidExLFCat");
		public SettCcySet LFCat { get; set; } = new SettCcySet("Actuals LFCat");
		public SettCcySet OSCat { get; set; } = new SettCcySet("Actuals OSCat");

		public SettCcySet PaidExLFLarge { get; set; } = new SettCcySet("Actuals PaidExLFLarge");
		public SettCcySet LFLarge { get; set; } = new SettCcySet("Actuals LFLarge");
		public SettCcySet OSLarge { get; set; } = new SettCcySet("Actuals OSLarge");
		public SettCcySet PaidExLFAttr { get; set; } = new SettCcySet("Actuals PaidExLFAttr");
		public SettCcySet LFAttr { get; set; } = new SettCcySet("Actuals LFAttr");
		public SettCcySet OSAttr { get; set; } = new SettCcySet("Actuals OSAttr");
		public SettCcySet IncurredTotal { get; set; } = new SettCcySet("Actuals IncurredTotal");
		public SettCcySet IncurredCat { get; set; } = new SettCcySet("Actuals IncurredCat");
		public SettCcySet IncurredLarge { get; set; } = new SettCcySet("Actuals IncurredLarge");
		public SettCcySet IncurredAttr { get; set; } = new SettCcySet("Actuals IncurredAttr");
		public SettCcySet PaidCat { get; set; } = new SettCcySet("Actuals PaidCat");
		public SettCcySet PaidAttr { get; set; } = new SettCcySet("Actuals PaidAttr");
		public SettCcySet PaidLarge { get; set; } = new SettCcySet("Actuals PaidLarge");
		public SettCcySet PaidTotal { get; set; } = new SettCcySet("Actuals PaidTotal");
		public SettCcySet PaidExLFTotal { get; set; } = new SettCcySet("Actuals PaidExLFTotal");
		public SettCcySet LFTotal { get; set; } = new SettCcySet("Actuals LFTotal");
		public SettCcySet OSTotal { get; set; } = new SettCcySet("Actuals OSTotal");
		public SettCcySet GGWP { get; set; } = new SettCcySet("Actuals GGWP");
		public SettCcySet WrittenDeductionsCurrency { get; set; } = new SettCcySet("Actuals WrittenDeductionsCurrency");



		public double WrittenDeductions { get; set; }
		public SettCcySet GNWP { get; set; } = new SettCcySet("Actuals GNWP");
		public SettCcySet GGSP { get; set; } = new SettCcySet("Actuals GGSP");
		public SettCcySet SignedDeductionsCurrency { get; set; } = new SettCcySet("Actuals SignedDeductionsCurrency");
		public double SignedDeductions { get; set; }

		public SettCcySet GNSP { get; set; } = new SettCcySet("Actuals GNSP");
		public SettCcySet GGEP { get; set; } = new SettCcySet("Actuals GGEP");
		public SettCcySet EarnedDeductionsCurrency { get; set; } = new SettCcySet("Actuals EarnedDeductionsCurrency");

		public double EarnedDeductions { get; set; }
		public SettCcySet GNEP { get; set; } = new SettCcySet("Actuals GNEP");
		public SettCcySet SignedInwardsRIPs { get; set; } = new SettCcySet("Actuals SignedInwardsRIPs");
		public SettCcySet SignedNCBPCSwing { get; set; } = new SettCcySet("Actuals SignedNCBPCSwing");

		public double IncurredLossRatio { get; set; }
	}
}