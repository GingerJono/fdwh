namespace Sandbox.Models.Reserving.Types
{
	public class Plan
	{
		public SettCcySet GGWP { get; set; } = new SettCcySet("Plan GGWP");
		public SettCcySet GNWP { get; set; } = new SettCcySet("Plan GNWP");
		public SettCcySet DeductionsCurrency { get; set; } = new SettCcySet("Plan DeductionsCurrency");
		public double Deductions { get; set; }
		public SettCcySet UltimateClaimsCat { get; set; } = new SettCcySet("Plan UltimateClaimsCat");
		public SettCcySet UltimateClaimsLarge { get; set; } = new SettCcySet("Plan UltimateClaimsLarge");
		public SettCcySet UltimateClaimsAttr { get; set; } = new SettCcySet("Plan UltimateClaimsAttr");
		public SettCcySet UltimateClaimsTotal { get; set; } = new SettCcySet("Plan UltimateClaimsTotal");
		public double UltimateLossRatio { get; set; }
		public SettCcySet InwardsRIPs { get; set; } = new SettCcySet("Plan InwardsRIPs");
		public SettCcySet NCBPCSwing { get; set; } = new SettCcySet("Plan NCBPCSwing");
	}
}