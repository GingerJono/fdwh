using CardModel;
namespace Hrm
{
    public class HrmChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public class Project {
        public string? Month { get; set; }
        public decimal New { get; set; }
        public decimal Inprogress { get; set; }
        public decimal Completed { get; set; }
        public decimal Onhold { get; set; }
    } ;
    public class Gender
    {
        public string? GenderSeries { get; set; }
        public int GenderValue { get; set; }
    }
    public class UpcomingEvents
    {
        public string? Date { get; set; }
        public string? DateColor { get; set; }
        public string? Day { get; set; }
        public string? Title { get; set; }
        public string? Desc { get; set; }
    }
    public class EmployeeList
    {
        public decimal Id { get; set;}
        public string? EmployeeId { get; set;}
        public string? EmployeeImg { get; set;}
        public string? Employee { get; set;}
        public string? Email { get; set;}
        public string? Desig { get; set;}
        public string? Type { get; set;}
        public string? Status { get; set;}
        public string? StatusColor { get; set;}
        public string? Contact { get; set;}
        public string? Salary { get; set;}
        public string? Days { get; set;}
        public string? Date { get; set;}
    }
    public class MeetingList
    {
        public decimal Id { get; set;}
        public string? EmployeeImg { get; set;}
        public string? ImgColor { get; set;}
        public string? Employee { get; set;}
        public string? Time { get; set;}
    }
}

