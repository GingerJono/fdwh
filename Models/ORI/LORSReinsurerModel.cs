namespace Sandbox.Models.ORI
{
    public class LORSReinsurerModel
    {
        public required string FileName { get; set; }
        public int PolicySequence { get; set; }

        public required string PartyQualifier { get; set; }
        public required string PartyCode { get; set; }
        public required string Reinsurer { get; set; }
        public required string CNRReference { get; set; }
        public required string AmountQualifier { get; set; }
        public required decimal Amount { get; set; }
    }
}
