using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Medical
{
    public class MedicalService{
        
        public List<MedicalCard> MedicalData = new List<MedicalCard>{
            new MedicalCard { Medicalprice ="12,457",Medicaltitle ="Total Patients",Medicalpercent ="- 0.02% ",MedicalsvgIcon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' class='svg-icon-med position-absolute end-0 bottom-0 opacity-1 text-primary' fill='currentColor' viewBox='0 0 256 256'><path d='M136,108A52,52,0,1,1,84,56,52,52,0,0,1,136,108Z' opacity='0.2'></path><path d='M117.25,157.92a60,60,0,1,0-66.5,0A95.83,95.83,0,0,0,3.53,195.63a8,8,0,1,0,13.4,8.74,80,80,0,0,1,134.14,0,8,8,0,0,0,13.4-8.74A95.83,95.83,0,0,0,117.25,157.92ZM40,108a44,44,0,1,1,44,44A44.05,44.05,0,0,1,40,108Zm210.14,98.7a8,8,0,0,1-11.07-2.33A79.83,79.83,0,0,0,172,168a8,8,0,0,1,0-16,44,44,0,1,0-16.34-84.87,8,8,0,1,1-5.94-14.85,60,60,0,0,1,55.53,105.64,95.83,95.83,0,0,1,47.22,37.71A8,8,0,0,1,250.14,206.7Z'></path></svg>",IsIncreased =false,},
            new MedicalCard { Medicalprice ="2,987",Medicaltitle ="Total Doctors ",Medicalpercent ="- 0.02% ",MedicalsvgIcon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' class='svg-icon-med position-absolute end-0 bottom-0 text-primary1 opacity-1' fill='currentColor' viewBox='0 0 256 256'><path d='M240,160a32,32,0,1,1-32-32A32,32,0,0,1,240,160Z' opacity='0.2'></path><path d='M220,160a12,12,0,1,1-12-12A12,12,0,0,1,220,160Zm-4.55,39.29A48.08,48.08,0,0,1,168,240H144a48.05,48.05,0,0,1-48-48V151.49A64,64,0,0,1,40,88V40a8,8,0,0,1,8-8H72a8,8,0,0,1,0,16H56V88a48,48,0,0,0,48.64,48c26.11-.34,47.36-22.25,47.36-48.83V48H136a8,8,0,0,1,0-16h24a8,8,0,0,1,8,8V87.17c0,32.84-24.53,60.29-56,64.31V192a32,32,0,0,0,32,32h24a32.06,32.06,0,0,0,31.22-25,40,40,0,1,1,16.23.27ZM232,160a24,24,0,1,0-24,24A24,24,0,0,0,232,160Z'></path></svg>",IsIncreased =false,},
            new MedicalCard { Medicalprice ="35,324",Medicaltitle ="Total Appointments",Medicalpercent ="+2.15% ",MedicalsvgIcon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' class='svg-icon-med position-absolute end-0 bottom-0 opacity-1 text-primary2' fill='currentColor' viewBox='0 0 256 256'><path d='M216,48V88H40V48a8,8,0,0,1,8-8H208A8,8,0,0,1,216,48Z' opacity='0.2'></path><path d='M208,32H184V24a8,8,0,0,0-16,0v8H88V24a8,8,0,0,0-16,0v8H48A16,16,0,0,0,32,48V208a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V48A16,16,0,0,0,208,32ZM72,48v8a8,8,0,0,0,16,0V48h80v8a8,8,0,0,0,16,0V48h24V80H48V48ZM208,208H48V96H208V208Zm-48-56a8,8,0,0,1-8,8H136v16a8,8,0,0,1-16,0V160H104a8,8,0,0,1,0-16h16V128a8,8,0,0,1,16,0v16h16A8,8,0,0,1,160,152Z'></path></svg>",IsIncreased =true,},
            new MedicalCard { Medicalprice ="5,478",Medicaltitle ="Total Staff",Medicalpercent ="+ 1.05% ",MedicalsvgIcon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' class='svg-icon-med position-absolute end-0 bottom-0 text-primary3 opacity-1' fill='currentColor' viewBox='0 0 256 256'><path d='M168,144a40,40,0,1,1-40-40A40,40,0,0,1,168,144ZM64,56A32,32,0,1,0,96,88,32,32,0,0,0,64,56Zm128,0a32,32,0,1,0,32,32A32,32,0,0,0,192,56Z' opacity='0.2'></path><path d='M244.8,150.4a8,8,0,0,1-11.2-1.6A51.6,51.6,0,0,0,192,128a8,8,0,0,1,0-16,24,24,0,1,0-23.24-30,8,8,0,1,1-15.5-4A40,40,0,1,1,219,117.51a67.94,67.94,0,0,1,27.43,21.68A8,8,0,0,1,244.8,150.4ZM190.92,212a8,8,0,1,1-13.85,8,57,57,0,0,0-98.15,0,8,8,0,1,1-13.84-8,72.06,72.06,0,0,1,33.74-29.92,48,48,0,1,1,58.36,0A72.06,72.06,0,0,1,190.92,212ZM128,176a32,32,0,1,0-32-32A32,32,0,0,0,128,176ZM72,120a8,8,0,0,0-8-8A24,24,0,1,1,87.24,82a8,8,0,1,0,15.5-4A40,40,0,1,0,37,117.51,67.94,67.94,0,0,0,9.6,139.19a8,8,0,1,0,12.8,9.61A51.6,51.6,0,0,1,64,128,8,8,0,0,0,72,120Z'></path></svg>",IsIncreased =true,}
        };        
        public List<MedicalCard> GetMedicalData() => MedicalData;
        
        public static List<Patients> GetPatientss() {
           var Survey = new List<Patients> ();
            Survey.Add(new Patients { Month = "Jan", OldPatients = 30, NewPatients = 45, });
            Survey.Add(new Patients { Month = "Feb", OldPatients = 35, NewPatients = 30, });
            Survey.Add(new Patients { Month = "Mar", OldPatients = 35, NewPatients = 49, });
            Survey.Add(new Patients { Month = "Apr", OldPatients = 30, NewPatients = 30, });
            Survey.Add(new Patients { Month = "May", OldPatients = 45, NewPatients = 45, });
            Survey.Add(new Patients { Month = "Jun", OldPatients = 25, NewPatients = 25, });
            Survey.Add(new Patients { Month = "Jul", OldPatients = 36, NewPatients = 36, });
            Survey.Add(new Patients { Month = "Aug", OldPatients = 54, NewPatients = 54, });
            Survey.Add(new Patients { Month = "Sep", OldPatients = 36, NewPatients = 36, });
            Survey.Add(new Patients { Month = "Oct", OldPatients = 29, NewPatients = 29, });
            Survey.Add(new Patients { Month = "Nov", OldPatients = 49, NewPatients = 49, });
            Survey.Add(new Patients { Month = "Dec", OldPatients = 42, NewPatients = 42, });
            return Survey;
        }        
        public static List<RevenueStatistics> RevenueStatisticsItems()
        {
            var RevenueStatisticsItems = new List<RevenueStatistics>();
                RevenueStatisticsItems.Add(new RevenueStatistics { SeriesValue = 230, Source = "Revenue" });
                RevenueStatisticsItems.Add(new RevenueStatistics { SeriesValue = 200, Source = "Income" });
                RevenueStatisticsItems.Add(new RevenueStatistics { SeriesValue = 178, Source = "Profit" });
                RevenueStatisticsItems.Add(new RevenueStatistics { SeriesValue = 153, Source = "Patients" });

            return RevenueStatisticsItems;
        }
        public static List<PatientsOverview> GetPatientsOverviews()
        {
           var patientsoverview = new List<PatientsOverview>();
            patientsoverview.Add(new PatientsOverview { Source = "Male", SourceValue = 1754 });
            patientsoverview.Add(new PatientsOverview { Source = "Female", SourceValue = 1234 });
            return patientsoverview;
        }
        public static List<Staff> GetStaff() {
            var Attendance = new List<Staff>();
            Attendance.Add(new Staff { Month = "Jan", DayShift = 15, NightShift = 8, });
            Attendance.Add(new Staff { Month = "Feb", DayShift = 30, NightShift = 40, });
            Attendance.Add(new Staff { Month = "Mar", DayShift = 22, NightShift = 15, });
            Attendance.Add(new Staff { Month = "Apr", DayShift = 49, NightShift = 32, });
            Attendance.Add(new Staff { Month = "May", DayShift = 32, NightShift = 45, });
            Attendance.Add(new Staff { Month = "Jun", DayShift = 45, NightShift = 30, });
            Attendance.Add(new Staff { Month = "Jul", DayShift = 30, NightShift = 20, });
            Attendance.Add(new Staff { Month = "Aug", DayShift = 45, NightShift = 35, });
            Attendance.Add(new Staff { Month = "Sep", DayShift = 65, NightShift = 28, });
            Attendance.Add(new Staff { Month = "Oct", DayShift = 45, NightShift = 43, });
            Attendance.Add(new Staff { Month = "Nov", DayShift = 25, NightShift = 30, });
            Attendance.Add(new Staff { Month = "Dec", DayShift = 45, NightShift = 40, });
            return Attendance;
        }
        public TableText[] DoctorslistHeadersData = new TableText[]
        {
            new TableText { Title = "Doctor"},
            new TableText { Title = "Qualification"},
            new TableText { Title = "Experience"},
            new TableText { Title = "Action"},
        };        
        public TableText[] GetDoctorslistHeadersData() => DoctorslistHeadersData;    
        private List<DoctorsList> DoctorsListData = new List<DoctorsList>( )
        {
            new DoctorsList {Id=1,DoctorImg="../assets/images/faces/doctors/1.jpg",Doctor="Dr. Smith",Specialist="Cardiology",Qualification="MBBS, Ph.D",Experience="4 yrs Exp",},
            new DoctorsList {Id=2,DoctorImg="../assets/images/faces/doctors/2.jpg",Doctor="Dr. Johnson",Specialist="Orthopedics",Qualification="MBBS, MD, DM",Experience="6 yrs Exp",},
            new DoctorsList {Id=3,DoctorImg="../assets/images/faces/doctors/3.jpg",Doctor="Dr.L.Rickie Smtih",Specialist="Orthopedics",Qualification="MBBS, MD, DM",Experience="6 yrs Exp",},
            new DoctorsList {Id=4,DoctorImg="../assets/images/faces/doctors/4.jpg",Doctor="Dr.M.Angle",Specialist="Gynecologist",Qualification="MBBS, MD, Ph.D",Experience="10 yrs Exp",},
            new DoctorsList {Id=5,DoctorImg="../assets/images/faces/doctors/5.jpg",Doctor="Dr.S.Mary",Specialist="Neurosurgeon",Qualification="MBBS, MD, Ph.D",Experience="3 yrs Exp",},
            new DoctorsList {Id=6,DoctorImg="../assets/images/faces/doctors/6.jpg",Doctor="Dr.T.Laytoya Thoma",Specialist="Dermatologists",Qualification="MBBS, MD, Ph.D",Experience="5 yrs Exp",},
        };
        public List<DoctorsList> GetDoctorsList() => DoctorsListData;   
         
        
        private List<ScheduleList> ScheduleData  = new List<ScheduleList>( )
        {
            new ScheduleList  {
                id= 1,
                title= "Meeting with Doctors",
                subtitle= "video conference",
                startTime= "09:00",
                endTime= "12:00",
            },
            new ScheduleList  {
                id= 2,
                title= "Lunch with team members",
                subtitle= "Dolores Ait Labore Sit",
                startTime= "12:00",
                endTime= "13:20",
            },
            new ScheduleList  {
                id= 3,
                title= "Meeting With Doctors <a href='javascript:void(0);' class='text-primary'>Yuhan Sev</a>",
                subtitle= "Golden Park",
                startTime= "16:00",
                endTime= "17:20",
            },
            new ScheduleList  {
                id= 4,
                title= "Appointment with Dr. Smith",
                subtitle= "Follow-up for annual physical examination",
                startTime= "18:15",
                endTime= "19:00",
            },
            new ScheduleList{
                id= 5,
                title= "Assigning Medicines distribution To Patients",
                subtitle= "Task Basic",
                startTime= "09:35",
                endTime= "10:00",
            },
            new ScheduleList    {
                id= 6,
                title= "Lunch With <a href='javscript:void(0);' class='tx-primary'>John Abu</a>",
                subtitle= "Silver Valley",
                startTime= "12:20",
                endTime= "13:20",
            },
            new ScheduleList    {
                id= 7,
                title= "Checking Upcoming Projects & Schedules",
                subtitle= "Vlarhar Dhi Ionk Si",
                startTime= "15:40",
                endTime= "16:00",
            },
            new ScheduleList   {
                id= 8,
                title= "Uploading New Projects In Terminal",
                subtitle= "WPN Project",
                startTime= "16:45",
                endTime= "17:00",
            },
            new ScheduleList  {
                id= 9,
                title= "Meeting With <a href='javascript:void(0);' class='tx-primary'>Abu Siddik</a>",
                subtitle= "Zoom Meeting",
                startTime= "10:00",
                endTime= "11:30",
            },
            new ScheduleList  {
                id= 10,
                title= "Lunch with team members",
                subtitle= "Amet Dolor Clita",
                startTime= "13:45",
                endTime= "14:45",
            },
            new ScheduleList  {
                id= 11,
                title= "Uploading New Dashboard",
                subtitle= "Iox Ui",
                startTime= "16:10",
                endTime= "16:30",
            },
            new ScheduleList  {
                id= 12,
                title= "Meeting With Doctors <a href='javascript:void(0);' class='tx-primary'>Ion Habbu</a>",
                subtitle= "Backend",
                startTime= "16:55",
                endTime= "18:55",
            },
            new ScheduleList  {
                id= 13,
                title= "Developing Backend For Login Page",
                subtitle= "Backend",
                startTime= "10:00",
                endTime= "12:00",
            },
            new ScheduleList  {
                id= 14,
                title= "Catch Lunch At <a href='javascript:void(0);'' class='tx-primary'>Sed Lorem</a>",
                subtitle= "Lorem Ipsum",
                startTime= "13:15",
                endTime= "14:10",
            },
            new ScheduleList  {
                id= 15,
                title= "Join Doctors Meeting",
                subtitle= "SpaceY",
                startTime= "15:30",
                endTime= "16:20",
            },
            new ScheduleList  {
                id= 16,
                title= "Planning New Technology With Members",
                subtitle= "Rio",
                startTime= "17:30",
                endTime= "18:00",
            },
            new ScheduleList  {
                id= 17,
                title ="Meeting with <a href='javascript:void(0);' class='tx-primary'>Xion Shan</a>",
                subtitle ="G - Meets",
                startTime ="09:00",
                endTime ="11:00",
            },
            new ScheduleList  {
                id= 18,
                title ="Updating UI Of Dashboard",
                subtitle ="Dashboard Xin",
                startTime ="12:50",
                endTime ="13:20",
            },
            new ScheduleList  {
                id= 19,
                title ="Assigning Tasks To Members",
                subtitle ="Task MWU",
                startTime ="15:45",
                endTime ="16:00",
            },
            new ScheduleList  {
                id= 20,
                title ="Dinner with team members",
                subtitle ="Amet Dolor Clita",
                startTime ="19:55",
                endTime ="20:30",
            },
            new ScheduleList  {
                id= 21,
                title ="Meeting with Doctors",
                subtitle ="video conference",
                startTime ="09:00",
                endTime ="12:00",
            },
            new ScheduleList  {
                id= 22,
                title ="Lunch with team members",
                subtitle ="Dolores Ait Labore Sit",
                startTime ="12:00",
                endTime ="13:20",
            },
            new ScheduleList  {
                id= 23,
                title ="Meeting With Doctors <a href='javascript:void(0);' class='text-primary'>Yuhan Sev</a>",
                subtitle ="Golden Park",
                startTime ="16:00",
                endTime ="17:20",
            },
            new ScheduleList  {
                id= 24,
                title ="Appointment with Dr. Smith",
                subtitle ="Follow-up for annual physical examination",
                startTime ="18:15",
                endTime ="19:00",
            },
            new ScheduleList  {
                id= 25,
                title ="Assigning Tasks To Employees",
                subtitle ="Task Basic",
                startTime ="09:35",
                endTime ="10:00",
            },
            new ScheduleList  {
                id= 26,
                title ="Lunch With <a href='javscript:void(0);' class='tx-primary'>John Abu</a>",
                subtitle ="Silver Valley",
                startTime ="12:20",
                endTime ="13:20",
            },
            new ScheduleList  {
                id= 27,
                title ="Checking Upcoming Projects & Schedules",
                subtitle ="Vlarhar Dhi Ionk Si",
                startTime ="15:40",
                endTime ="16:00",
            },
            new ScheduleList  {
                id= 28,
                title ="Uploading New Projects In Terminal",
                subtitle ="WPN Project",
                startTime ="16:45",
                endTime ="17:00",
            },
        };
        public List<ScheduleList> GetScheduleData () => ScheduleData ;   
        public TableText[] PatientsListHeadersData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Patient ID"},
            new TableText { Title = "Name"},
            new TableText { Title = "Gender"},
            new TableText { Title = "Age"},
            new TableText { Title = "Assgined Doctor"},
            new TableText { Title = "Disease"},
            new TableText { Title = "Contact Number"},
            new TableText { Title = "Appointmented Date"},
            new TableText { Title = "Room No"},
            new TableText { Title = "Action"},
        };        
        public TableText[] GetPatientsListHeadersData() => PatientsListHeadersData;   
        
        public List<PatientsList> PatientsListData = new List<PatientsList>{
            new PatientsList {Id=01,PatientID="PAC-9ABC",PatientName="Jhon Doe",PatientImg="../assets/images/faces/11.jpg",Gender="Male",Age="25",Doctor="Dr.M.Smith",Disease="Hypertension",Diseaseclass="bg-primary-transparent",Contact ="123-456-7890",Appointment="2023-10-20",RoomNo ="101",},

            new PatientsList {Id=02,PatientID="PAC-3SFW",PatientName="Jane smith",PatientImg="../assets/images/faces/2.jpg",Gender="Female",Age="35",Doctor="Dr. Johnson",Disease="Diabetes",Diseaseclass="bg-secondary-transparent",Contact ="987-654-3210",Appointment="2023-09-15",RoomNo ="102",},

            new PatientsList {Id=03,PatientID="PAC-6SKF",PatientName="Robert Jhonson",PatientImg="../assets/images/faces/12.jpg",Gender="Male",Age="45",Doctor="Dr.M.Angle",Disease="Asthma",Diseaseclass="bg-success-transparent",Contact ="456-789-0123",Appointment="2023-11-05",RoomNo ="103",},

            new PatientsList {Id=04,PatientID="PAC-3ESD",PatientName="Emiley Davis",PatientImg="../assets/images/faces/5.jpg",Gender="Female",Age="28",Doctor="Dr.S.Mary",Disease="Allergies",Diseaseclass="bg-orange-transparent",Contact ="789-012-3456",Appointment="2023-08-12",RoomNo ="104",},

            new PatientsList {Id=05,PatientID="PAC-3KSE",PatientName="William Martinez",PatientImg="../assets/images/faces/11.jpg",Gender="Male",Age="38",Doctor="Dr.S.Mary",Disease="General",Diseaseclass="bg-info-transparent",Contact ="234-567-8901",Appointment="2023-12-08",RoomNo ="105",},

            new PatientsList {Id=06,PatientID="PAC-4DFS",PatientName="Sarah Wilson",PatientImg="../assets/images/faces/4.jpg",Gender="Female",Age="28",Doctor="Dr.T.Laytoya Thoma",Disease="High Cholesterol",Diseaseclass="bg-warning-transparent",Contact ="567-890-1234",Appointment="2023-07-25",RoomNo ="106",},
        };        
        public List<PatientsList> GetPatientsListData() => PatientsListData;
    }
}
