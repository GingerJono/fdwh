namespace Sandbox.Models.ORI
{
    public class ORIPolicyReinstatementModel
    {
        public string ORIPolicyReference { get; set; }
        public string ProgrammeReference { get; set; }
        public int ReinstatementOrder { get; set; }
        public decimal ReinstatementPercent { get; set; }
        public int NumberOfReinstatements { get; set; }
        public string ProRateByTime { get; set; }
        public string ReinstatementTerms { get; set; }
    }
}
