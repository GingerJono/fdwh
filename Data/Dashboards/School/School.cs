using CardModel;

namespace School
{
    public class Attendance {
        public string? Month { get; set; }
        public decimal Staff { get; set; }
        public decimal Students { get; set; }
        public decimal Teachers { get; set; }
    } ;
    public class Students {
        public string? Week { get; set; }
        public decimal Projects { get; set; }
        public decimal Tasks { get; set; }
    } ;
    public class TeachersList
    {
        public int id { get; set; }
        public string? TeacherImg { get; set; }
        public string? Teacher { get; set; }
        public string? Qualification { get; set; }
        public string? Subject { get; set; }
        public string? SubjectClass { get; set; }
    } ;
    public class NoticeList
    {
        public int id { get; set; }
        public string? NoticeIcon { get; set; }
        public string? NoticeColor { get; set; }
        public string? Notice { get; set; }
        public string? NoticeDesc { get; set; }
        public string? NoticeDate { get; set; }
    } ;
    public class StudentsList
    {
        public int id { get; set; }
        public string? Studentsid { get; set; }
        public string? StudentImg { get; set; }
        public string? Student { get; set; }
        public string? Class { get; set; }
        public string? Section { get; set; }
        public string? Marks { get; set; }
        public string? GPA { get; set; }
        public bool Status { get; set; }
    } ;
    public class ResultsList
    {
        public int id { get; set; }
        public string? StudentImg { get; set; }
        public string? Student { get; set; }
        public string? Subject { get; set; }
        public string? ScoreClass { get; set; }
        public string? Score { get; set; }
    } ;


}

