namespace Sandbox.Models.ORI
{
    public class ORIPolicyReinstatementModel
    {
        public required string ORIPolicyReference { get; set; }
        public string? ProgrammeReference { get; set; }
        public required int ReinstatementOrder { get; set; }
        public required decimal ReinstatementPercent { get; set; }
        public required int NumberOfReinstatements { get; set; }
        public required string ProRateByTime { get; set; }
        public string? ReinstatementTerms { get; set; }
    }
}
