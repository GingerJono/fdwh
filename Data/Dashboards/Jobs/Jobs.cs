using CardModel;

namespace Jobs
{
    public class JobStatistics {
        public string? Week { get; set; }
        public decimal ApplicationsValue { get; set; }
        public decimal ShortlistedValue { get; set; }
        public decimal RejectedValue { get; set; }
        public decimal OnHoldValue { get; set; }
    } ;
    public class Candidate
    {
        public string? CandidateSeries { get; set; }
        public int CandidateValue { get; set; }
    }
    public class RecentJobs  {
        public decimal Id { get; set; }
        public string? JobIcon { get; set; }
        public string? JobColor { get; set; }
        public string? JobTile { get; set; }
        public string? Posted { get; set; }
        public string? Applicants { get; set; }
        public string? Openings { get; set; }
        public string? Location { get; set; }
    }
    public class HireList  {
        public string? HireIcon { get; set; }
        public string? HireIMG { get; set; }
        public string? HireColor { get; set; }
        public string? HireTile { get; set; }
        public string? Status { get; set; }
        public string? StatusColor { get; set; }
        public string? Candidates { get; set; }
    }
    public class Applicants  {
        public decimal Id { get; set; }
        public string? CandidateIMG { get; set; }
        public string? Candidate { get; set; }
        public string? Category { get; set; }
        public string? Design { get; set; }
        public string? DesigColor { get; set; }
        public string? Mail { get; set; }
        public string? Location { get; set; }
        public string? Date { get; set; }
        public string? Status { get; set; }
        public string? StatusColor { get; set; }
    }
}

