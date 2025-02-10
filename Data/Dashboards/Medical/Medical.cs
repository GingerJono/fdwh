using CardModel;

namespace Medical
{
    public class Patients {
        public string? Month { get; set; }
        public decimal OldPatients { get; set; }
        public decimal NewPatients { get; set; }
    } ;
    public class RevenueStatistics
    {
        public string? Source { get; set; }
        public int SeriesValue { get; set; }
    }
    public class PatientsOverview
    {
        public string? Source { get; set; }
        public int SourceValue { get; set; }
    }
    public class Staff {
        public string? Month { get; set; }
        public decimal DayShift { get; set; }
        public decimal NightShift { get; set; }
    } ;
    public class DoctorsList {
        public decimal Id { get; set; }
        public string? DoctorImg { get; set; }
        public string? Doctor { get; set; }
        public string? Specialist { get; set; }
        public string? Qualification { get; set; }
        public string? Experience { get; set; }
    } ;
    public class ScheduleList {
        public decimal id { get; set; }
        public string? title { get; set; }
        public string? subtitle { get; set; }
        public string? startTime { get; set; }
        public string? endTime { get; set; }
    } ;
    public class PatientsList {
        public int Id { get; set; }
        public string? PatientID { get; set; }
        public string? PatientName { get; set; }
        public string? PatientImg { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public string? Doctor { get; set; }
        public string? Disease { get; set; }
        public string? Diseaseclass { get; set; }
        public string? Contact  { get; set; }
        public string? Appointment { get; set; }
        public string? RoomNo  { get; set; }
    } ;
}

