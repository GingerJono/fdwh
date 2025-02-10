using CardModel;

namespace Courses
{
    public class CourseTable {
        public decimal CourseId { get; set; }
        public string? CourseImg { get; set; }
        public string? CourseTitle { get; set; }
        public string? Category { get; set; }
        public string? Classes { get; set; }
        public string? Updated { get; set; }
        public string? Instructor { get; set; }
        public string? Students { get; set; }
    }
    public class UpcomingTasks {
        public decimal CourseId { get; set; }
        public string? CourseTitle { get; set; }
        public string? Date { get; set; }
        public string? Durationstart { get; set; }
        public string? Durationend { get; set; }
    }
    public class Earning {
        public string? Year { get; set; }
        public decimal ThisYearValue { get; set; }
        public decimal LastYearValue { get; set; }
    } ;
    public class CategoriesList {
        public string? CategorieIcon { get; set; }
        public string? CategorieColor { get; set; }
        public string? CategorieTitle { get; set; }
        public string? Courses { get; set; }
        public string? Price { get; set; }
    }
    public class CourseList {
        public string? CourseImg { get; set; }
        public string? CourseTitle { get; set; }
        public string? Price { get; set; }
    }
    
}

