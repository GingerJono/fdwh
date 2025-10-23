namespace Sandbox.Models.Prism
{
    public class DifferenceNoteModel
    {
        public string ORIPolicyReference { get; set; } = "";
        public string Metric { get; set; } = "";            // e.g. "01 Written Premium"
        public long RunID { get; set; }
        public double UnadjustedAmount { get; set; }
        public DateTime NoteDate { get; set; }              // populated by GETDATE() in SQL on insert (returned on read)
        public string NotedBy { get; set; } = "";
        public bool ExpectedSolve { get; set; }
        public bool PrismCorrect { get; set; }
        public string? Notes { get; set; }
        public bool IsDeleted { get; set; }

    }
}
