using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace School
{
    public class SchoolService
    {
        public List<Schoolcard> SchoolcardData = new List<Schoolcard>{
            new Schoolcard { Svg="<svg xmlns='http://www.w3.org/2000/svg' height='24px' viewBox='0 0 24 24' width='24px' fill='currentColor'><path d='M0 0h24v24H0V0z' fill='none'></path><path d='M7 12.27v3.72l5 2.73 5-2.73v-3.72L12 15zM5.18 9 12 12.72 18.82 9 12 5.28z' opacity='.2'></path><path d='M12 3 1 9l4 2.18v6L12 21l7-3.82v-6l2-1.09V17h2V9L12 3zm5 12.99-5 2.73-5-2.73v-3.72L12 15l5-2.73v3.72zm-5-3.27L5.18 9 12 5.28 18.82 9 12 12.72z'></path></svg>",SvgClass="text-primary",title="Students",Value ="62,784"},
            new Schoolcard { Svg="<svg xmlns='http://www.w3.org/2000/svg' enable-background='new 0 0 24 24' height='24px' viewBox='0 0 24 24' width='24px' fill='currentColor'><g><rect fill='none' height='24' width='24'></rect><rect fill='none' height='24' width='24'></rect></g><g><g><path d='M8,15c-2.7,0-5.8,1.29-6,2.01V18h12v-1C13.8,16.29,10.7,15,8,15z' opacity='.2'></path><circle cx='8' cy='8' opacity='.2' r='2'></circle><polygon points='22,9 22,7 20,7 20,9 18,9 18,11 20,11 20,13 22,13 22,11 24,11 24,9'></polygon><path d='M8,12c2.21,0,4-1.79,4-4s-1.79-4-4-4S4,5.79,4,8S5.79,12,8,12z M8,6c1.1,0,2,0.9,2,2s-0.9,2-2,2S6,9.1,6,8S6.9,6,8,6z'></path><path d='M8,13c-2.67,0-8,1.34-8,4v3h16v-3C16,14.34,10.67,13,8,13z M14,18H2v-0.99C2.2,16.29,5.3,15,8,15s5.8,1.29,6,2V18z'></path><path d='M12.51,4.05C13.43,5.11,14,6.49,14,8s-0.57,2.89-1.49,3.95C14.47,11.7,16,10.04,16,8S14.47,4.3,12.51,4.05z'></path><path d='M16.53,13.83C17.42,14.66,18,15.7,18,17v3h2v-3C20,15.55,18.41,14.49,16.53,13.83z'></path></g></g></svg>",SvgClass="text-primary1",title="Teachers",Value ="3,765"},
            new Schoolcard { Svg="<svg xmlns='http://www.w3.org/2000/svg' enable-background='new 0 0 24 24' height='24px' viewBox='0 0 24 24' width='24px' fill='currentColor'><g><rect fill='none' height='24' width='24' y='0'></rect></g><g><g><path d='M14,13.5h4V12h-4V13.5z M14,16.5h4V15h-4V16.5z M20,7h-5V4c0-1.1-0.9-2-2-2h-2C9.9,2,9,2.9,9,4v3H4C2.9,7,2,7.9,2,9v11 c0,1.1,0.9,2,2,2h16c1.1,0,2-0.9,2-2V9C22,7.9,21.1,7,20,7z M11,4h2v5h-2V4z M20,20H4V9h5c0,1.1,0.9,2,2,2h2c1.1,0,2-0.9,2-2h5V20 z M9,15c0.83,0,1.5-0.67,1.5-1.5c0-0.83-0.67-1.5-1.5-1.5s-1.5,0.67-1.5,1.5C7.5,14.33,8.17,15,9,15z M11.08,16.18 C10.44,15.9,9.74,15.75,9,15.75s-1.44,0.15-2.08,0.43C6.36,16.42,6,16.96,6,17.57V18h6v-0.43C12,16.96,11.64,16.42,11.08,16.18z'></path><path d='M13,11h-2c-1.1,0-2-0.9-2-2H4v11h16V9h-5C15,10.1,14.1,11,13,11z M9,12c0.83,0,1.5,0.67,1.5,1.5 c0,0.83-0.67,1.5-1.5,1.5s-1.5-0.67-1.5-1.5C7.5,12.67,8.17,12,9,12z M12,18H6v-0.43c0-0.6,0.36-1.15,0.92-1.39 C7.56,15.9,8.26,15.75,9,15.75s1.44,0.15,2.08,0.43c0.55,0.24,0.92,0.78,0.92,1.39V18z M18,16.5h-4V15h4V16.5z M18,13.5h-4V12h4 V13.5z' opacity='.3'></path></g></g></svg>",SvgClass="text-primary2",title="Total Staff",Value ="8,475"},
            new Schoolcard { Svg="<svg xmlns='http://www.w3.org/2000/svg' height='24px' viewBox='0 0 24 24' width='24px' fill='currentColor'><path d='M0 0h24v24H0V0z' fill='none'></path><path d='M13 17c-1.1 0-2-.9-2-2V9c0-1.1.9-2 2-2h6V5H5v14h14v-2h-6z' opacity='.2'></path><path d='M21 7.28V5c0-1.1-.9-2-2-2H5c-1.11 0-2 .9-2 2v14c0 1.1.89 2 2 2h14c1.1 0 2-.9 2-2v-2.28c.59-.35 1-.98 1-1.72V9c0-.74-.41-1.38-1-1.72zM20 9v6h-7V9h7zM5 19V5h14v2h-6c-1.1 0-2 .9-2 2v6c0 1.1.9 2 2 2h6v2H5z'></path><circle cx='16' cy='12' r='1.5'></circle></svg>",SvgClass="text-primary3",title="Revenue",Value ="$22,987"},
            new Schoolcard { Svg="<svg xmlns='http://www.w3.org/2000/svg' enable-background='new 0 0 24 24' height='24px' viewBox='0 0 24 24' width='24px' fill='currentColor'><rect fill='none' height='24' width='24'></rect><path d='M12,14c-1.65,0-3-1.35-3-3V5h6v6C15,12.65,13.65,14,12,14z' opacity='.2'></path><path d='M19,5h-2V3H7v2H5C3.9,5,3,5.9,3,7v1c0,2.55,1.92,4.63,4.39,4.94c0.63,1.5,1.98,2.63,3.61,2.96V19H7v2h10v-2h-4v-3.1 c1.63-0.33,2.98-1.46,3.61-2.96C19.08,12.63,21,10.55,21,8V7C21,5.9,20.1,5,19,5z M5,8V7h2v3.82C5.84,10.4,5,9.3,5,8z M12,14 c-1.65,0-3-1.35-3-3V5h6v6C15,12.65,13.65,14,12,14z M19,8c0,1.3-0.84,2.4-2,2.82V7h2V8z'></path></svg>",SvgClass="text-warning",title="Awards",Value ="865"},
        };        
        public List<Schoolcard> GetSchoolcardData() => SchoolcardData;
        public static List<Attendance> GetAttendance() {
            var attendance = new List<Attendance>();
            attendance.Add(new Attendance { Month = "Jan", Staff = 100, Students = 180, Teachers = 210});
            attendance.Add(new Attendance { Month = "Feb", Staff = 210, Students = 620, Teachers = 380});
            attendance.Add(new Attendance { Month = "Mar", Staff = 180, Students = 476, Teachers = 400});
            attendance.Add(new Attendance { Month = "Apr", Staff = 454, Students = 220, Teachers = 250});
            attendance.Add(new Attendance { Month = "May", Staff = 230, Students = 520, Teachers = 300});
            attendance.Add(new Attendance { Month = "Jun", Staff = 320, Students = 780, Teachers = 420});
            attendance.Add(new Attendance { Month = "Jul", Staff = 656, Students = 435, Teachers = 380});
            attendance.Add(new Attendance { Month = "Aug", Staff = 830, Students = 515, Teachers = 280});
            attendance.Add(new Attendance { Month = "Sep", Staff = 350, Students = 738, Teachers = 380});
            attendance.Add(new Attendance { Month = "Oct", Staff = 350, Students = 454, Teachers = 350});
            attendance.Add(new Attendance { Month = "Nov", Staff = 210, Students = 525, Teachers = 230});
            attendance.Add(new Attendance { Month = "Dec", Staff = 410, Students = 230, Teachers = 250});
            return attendance;
        }
        public static List<Students> GetStudents() {
           var students = new List<Students>();
            students.Add(new Students { Week = "Sun", Projects = 26, Tasks = 56});
            students.Add(new Students { Week = "Mon", Projects = 58, Tasks = 41});
            students.Add(new Students { Week = "Tue", Projects = 44, Tasks = 55});
            students.Add(new Students { Week = "Wed", Projects = 42, Tasks = 34});
            students.Add(new Students { Week = "Thu", Projects = 57, Tasks = 54});
            students.Add(new Students { Week = "Fri", Projects = 55, Tasks = 42});
            students.Add(new Students { Week = "Sat", Projects = 45, Tasks = 57});
            return students;
        }
        public TableText[] TeachersHeadersData = new TableText[]
        {
            new TableText { Title = "Teacher"},
            new TableText { Title = "Qualification"},
            new TableText { Title = "Subject"},
            new TableText { Title = "Action"},
        };        
        public TableText[] GetTeachersHeadersData() => TeachersHeadersData;
        
        public List<TeachersList> TeachersData = new List<TeachersList>{
            new TeachersList { id= 1, TeacherImg= "../../assets/images/faces/11.jpg", Teacher= "John Smith", Qualification= "M.Ed", Subject= "Mathematics", SubjectClass= "primary" },
            new TeachersList { id= 2, TeacherImg= "../../assets/images/faces/3.jpg", Teacher= "Mary Johnson", Qualification= "B.A. in English", Subject= "English", SubjectClass= "secondary" },
            new TeachersList { id= 3, TeacherImg= "../../assets/images/faces/4.jpg", Teacher= "Robert Davis", Qualification= "Ph.D. in Science", Subject= "Physics", SubjectClass= "danger" },
            new TeachersList { id= 4, TeacherImg= "../../assets/images/faces/1.jpg", Teacher= "Sarah Thompson", Qualification= "M.A. in History", Subject= "History", SubjectClass= "info" },
            new TeachersList { id= 5, TeacherImg= "../../assets/images/faces/15.jpg", Teacher= "Michael Brown", Qualification= "B.Ed", Subject= "Chemistry", SubjectClass= "secondary" },
            new TeachersList { id= 6, TeacherImg= "../../assets/images/faces/2.jpg", Teacher= "Emily Wilson", Qualification= "M.A. in Geography", Subject= "Geography", SubjectClass= "pink" },
            new TeachersList { id= 7, TeacherImg= "../../assets/images/faces/5.jpg", Teacher= "Sarah Smith", Qualification= "M.A.", Subject= "Hindi", SubjectClass= "warning" },
        };      
        public List<TeachersList> GetTeachersData() => TeachersData;
        
        public List<NoticeList> NoticeListData = new List<NoticeList>{
            new NoticeList {id =1,NoticeIcon ="<svg class='avatar-md avatar bg-primary-transparent svg-primary  p-2' xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M232,112a24,24,0,0,0-24-24H136V79a32.06,32.06,0,0,0,24-31c0-28-26.44-45.91-27.56-46.66a8,8,0,0,0-8.88,0C122.44,2.09,96,20,96,48a32.06,32.06,0,0,0,24,31v9H48a24,24,0,0,0-24,24v23.33a40.84,40.84,0,0,0,8,24.24V200a24,24,0,0,0,24,24H200a24,24,0,0,0,24-24V159.57a40.84,40.84,0,0,0,8-24.24ZM112,48c0-13.57,10-24.46,16-29.79,6,5.33,16,16.22,16,29.79a16,16,0,0,1-32,0ZM40,112a8,8,0,0,1,8-8H208a8,8,0,0,1,8,8v23.33c0,13.25-10.46,24.31-23.32,24.66A24,24,0,0,1,168,136a8,8,0,0,0-16,0,24,24,0,0,1-48,0,8,8,0,0,0-16,0,24,24,0,0,1-24.68,24C50.46,159.64,40,148.58,40,135.33Zm160,96H56a8,8,0,0,1-8-8V172.56A38.77,38.77,0,0,0,62.88,176a39.69,39.69,0,0,0,29-11.31A40.36,40.36,0,0,0,96,160a40,40,0,0,0,64,0,40.36,40.36,0,0,0,4.13,4.67A39.67,39.67,0,0,0,192,176c.38,0,.76,0,1.14,0A38.77,38.77,0,0,0,208,172.56V200A8,8,0,0,1,200,208Z'></path></svg>",NoticeColor ="primary",Notice ="Inter-School Sports Day",NoticeDesc ="Students are gearing up for the annual inter-school.",NoticeDate ="20 Mar 2024"},

            new NoticeList {id =2,NoticeIcon ="<svg class='avatar-md avatar bg-primary1-transparent svg-primary1  p-2' xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M208,32H184V24a8,8,0,0,0-16,0v8H88V24a8,8,0,0,0-16,0v8H48A16,16,0,0,0,32,48V208a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V48A16,16,0,0,0,208,32ZM72,48v8a8,8,0,0,0,16,0V48h80v8a8,8,0,0,0,16,0V48h24V80H48V48ZM208,208H48V96H208V208Zm-96-88v64a8,8,0,0,1-16,0V132.94l-4.42,2.22a8,8,0,0,1-7.16-14.32l16-8A8,8,0,0,1,112,120Zm59.16,30.45L152,176h16a8,8,0,0,1,0,16H136a8,8,0,0,1-6.4-12.8l28.78-38.37A8,8,0,1,0,145.07,132a8,8,0,1,1-13.85-8A24,24,0,0,1,176,136,23.76,23.76,0,0,1,171.16,150.45Z'></path></svg>",NoticeColor ="primary1",Notice ="Science Exhibition <span class='text-primary2'>'Science Fare'</span>",NoticeDesc ="Explore innovative projects and experiments by our students.",NoticeDate ="24 Mar 2024"},

            new NoticeList {id =3,NoticeIcon ="<svg class='avatar-md avatar bg-primary2-transparent svg-primary2  p-2' xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M216,40H40A16,16,0,0,0,24,56V216a8,8,0,0,0,11.58,7.16L64,208.94l28.42,14.22a8,8,0,0,0,7.16,0L128,208.94l28.42,14.22a8,8,0,0,0,7.16,0L192,208.94l28.42,14.22A8,8,0,0,0,232,216V56A16,16,0,0,0,216,40Zm0,163.06-20.42-10.22a8,8,0,0,0-7.16,0L160,207.06l-28.42-14.22a8,8,0,0,0-7.16,0L96,207.06,67.58,192.84a8,8,0,0,0-7.16,0L40,203.06V56H216ZM60.42,167.16a8,8,0,0,0,10.74-3.58L76.94,152h38.12l5.78,11.58a8,8,0,1,0,14.32-7.16l-32-64a8,8,0,0,0-14.32,0l-32,64A8,8,0,0,0,60.42,167.16ZM96,113.89,107.06,136H84.94ZM136,128a8,8,0,0,1,8-8h16V104a8,8,0,0,1,16,0v16h16a8,8,0,0,1,0,16H176v16a8,8,0,0,1-16,0V136H144A8,8,0,0,1,136,128Z'></path></svg>",NoticeColor ="primary2",Notice ="Cultural Fest 2024",NoticeDesc ="Join us for a vibrant celebration of cultural diversity",NoticeDate ="09 Apr 2024"},

            new NoticeList {id =4,NoticeIcon ="<svg class='avatar-md avatar bg-primary3-transparent svg-primary3  p-2' xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M208,32H184V24a8,8,0,0,0-16,0v8H88V24a8,8,0,0,0-16,0v8H48A16,16,0,0,0,32,48V208a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V48A16,16,0,0,0,208,32ZM72,48v8a8,8,0,0,0,16,0V48h80v8a8,8,0,0,0,16,0V48h24V80H48V48ZM208,208H48V96H208V208Zm-96-88v64a8,8,0,0,1-16,0V132.94l-4.42,2.22a8,8,0,0,1-7.16-14.32l16-8A8,8,0,0,1,112,120Zm59.16,30.45L152,176h16a8,8,0,0,1,0,16H136a8,8,0,0,1-6.4-12.8l28.78-38.37A8,8,0,1,0,145.07,132a8,8,0,1,1-13.85-8A24,24,0,0,1,176,136,23.76,23.76,0,0,1,171.16,150.45Z'></path></svg>",NoticeColor ="primary3",Notice ="Founders' Day Celebration",NoticeDesc ="Commemorating the vision and values of our school's founders.",NoticeDate ="09 Apr 2024"},

            new NoticeList {id =5,NoticeIcon ="<svg class='avatar-md avatar bg-secondary-transparent svg-secondary  p-2' xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M128,24A104,104,0,1,0,232,128,104.11,104.11,0,0,0,128,24Zm0,192a88,88,0,1,1,88-88A88.1,88.1,0,0,1,128,216ZM80,108a12,12,0,1,1,12,12A12,12,0,0,1,80,108Zm96,0a12,12,0,1,1-12-12A12,12,0,0,1,176,108Zm-1.07,48c-10.29,17.79-27.4,28-46.93,28s-36.63-10.2-46.92-28a8,8,0,1,1,13.84-8c7.47,12.91,19.21,20,33.08,20s25.61-7.1,33.07-20a8,8,0,0,1,13.86,8Z'></path></svg>",NoticeColor ="secondary",Notice ="Literary Week",NoticeDesc ="Engage in a week full of literary activities.",NoticeDate ="09 Apr 2024"},
        };      
        public List<NoticeList> GetNoticeListData() => NoticeListData;
        private List<ProductActivity> SchoolActivityData = new List<ProductActivity>()
        {
            new ProductActivity {Id=1,Title="Mr. Thomas Brown", TitleClass="h6 mb-1 fs-13",Desc="Liked a post from <span class='badge bg-secondary-transparent'>Ms. Sarah Parker</span> about the upcoming school event",DescClass="fs-13 fw-normal",Duration="02:30PM"},
            new ProductActivity {Id=2,Title="Mr. John Doe",TitleClass="h6 mb-1 fs-13",Desc="Updated class schedule",DescClass="fs-13 fw-normal",Duration="12:47PM"},
            new ProductActivity {Id=3,Title="Ms. Jane Smith",TitleClass="h6 mb-1 fs-13",Desc="Posted a <span class='text-primary3 fs-14 fw-medium'>new announcement</span>",DescClass="fs-13 fw-normal",Duration="10:22AM", ChildContent="<div class='p-2 rounded-1 bg-light fs-13'>Reminder: Parent-Teacher meeting on Friday at 3 PM 📅</div>"},
            new ProductActivity {Id=4,Title="Mrs. Emily Davis",TitleClass="h6 mb-1 fs-13",Desc="Commented on a student's project - <span class='fw-medium text-success'>'Excellent Work'</span>",DescClass="fs-13 fw-normal",Duration="11:30AM"},
            new ProductActivity {Id=5,Title="Alice Johnson",TitleClass="h6 mb-1 fs-13",Desc="Submitted a report - <span class='fw-medium text-success fs-14'>'Science Project'</span>",DescClass="fs-13 fw-normal",Duration="11:45AM"},
            new ProductActivity {Id=6,Title="Mr. Bob Anderson",TitleClass="h6 mb-1 fs-13",Desc="Reviewed a submission from <span class='badge bg-secondary-transparent'>Jane Smith</span>",DescClass="fs-13 fw-normal",Duration="10:54AM"},
        };
        public List<ProductActivity> GetSchoolActivity() => SchoolActivityData;
        public TableText[] StudentsHeadersData = new TableText[] {
            new TableText { Title = "S.No"},
            new TableText { Title = "ID"},
            new TableText { Title = "Student"},
            new TableText { Title = "Class"},
            new TableText { Title = "Section"},
            new TableText { Title = "Marks In %"},
            new TableText { Title = "Marks In GPA"},
            new TableText { Title = "Status"},
            new TableText { Title = "Actions"},
        };        
        public TableText[] GetStudentsHeadersData() => StudentsHeadersData;
        
        private List<StudentsList> StudentsData = new List<StudentsList>()
        {
            new StudentsList {id=1,Studentsid="#1116",StudentImg="../assets/images/faces/2.jpg",Student="Studar Little",Class="IX",Section="B",Marks="75%",GPA="7.5",Status=true,},
            new StudentsList {id=2,Studentsid="#8547",StudentImg="../assets/images/faces/4.jpg",Student="Ion Somer",Class="X",Section="A",Marks="65%",GPA="6.5",Status=true,},
            new StudentsList {id=3,Studentsid="#7564",StudentImg="../assets/images/faces/6.jpg",Student="Shakira",Class="X",Section="B",Marks="25%",GPA="2.5",Status=false,},
            new StudentsList {id=4,Studentsid="#1254",StudentImg="../assets/images/faces/8.jpg",Student="Thomas Shelby",Class="IX",Section="A",Marks="95%",GPA="9.5",Status=true,},
            new StudentsList {id=5,Studentsid="#7458",StudentImg="../assets/images/faces/10.jpg",Student="Stefan U",Class="IX",Section="B",Marks="62%",GPA="6.2",Status=true,},
            new StudentsList {id=6,Studentsid="#6325",StudentImg="../assets/images/faces/12.jpg",Student="Michael Shreff",Class="X",Section="A",Marks="15%",GPA="1.5",Status=false,},
        };
        public List<StudentsList> GetStudentsData() => StudentsData;
        public TableText[] ResultsHeadersData = new TableText[] {
            new TableText { Title = "ID"},
            new TableText { Title = "Student"},
            new TableText { Title = "Subject"},
            new TableText { Title = "Score"},
        };        
        public TableText[] GetResultsHeadersData() => ResultsHeadersData;
        private List<ResultsList> ResultsData = new List<ResultsList>()
        {
            new ResultsList {id=8547,StudentImg="../assets/images/faces/4.jpg",Student="Ion Somer",Subject="Science",ScoreClass="text-success",Score="92%",},
            new ResultsList {id=7564,StudentImg="../assets/images/faces/6.jpg",Student="Shakira",Subject="English",ScoreClass="text-success",Score="78%",},
            new ResultsList {id=1254,StudentImg="../assets/images/faces/8.jpg",Student="Thomas Shelby",Subject="History",ScoreClass="text-success",Score="88%",},
            new ResultsList {id=7458,StudentImg="../assets/images/faces/10.jpg",Student="Stefan U",Subject="Geography",ScoreClass="text-secondary",Score="65%",},
            new ResultsList {id=6325,StudentImg="../assets/images/faces/12.jpg",Student="Michael Shreff",Subject="Physics",ScoreClass="text-success",Score="80%",},
            new ResultsList {id=2321,StudentImg="../assets/images/faces/4.jpg",Student="Leo Phllip",Subject="Chemistry",ScoreClass="text-success",Score="83%",},
        };
        public List<ResultsList> GetResultsData() => ResultsData;

    }
}