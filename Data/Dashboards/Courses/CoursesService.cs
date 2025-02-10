using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Courses
{
    public class CoursesService{
        public List<MainCard> CoursesCardData = new List<MainCard>(){
            new MainCard{svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M152,120H136V56h8a32,32,0,0,1,32,32,8,8,0,0,0,16,0,48.05,48.05,0,0,0-48-48h-8V24a8,8,0,0,0-16,0V40h-8a48,48,0,0,0,0,96h8v64H104a32,32,0,0,1-32-32,8,8,0,0,0-16,0,48.05,48.05,0,0,0,48,48h16v16a8,8,0,0,0,16,0V216h16a48,48,0,0,0,0-96Zm-40,0a32,32,0,0,1,0-64h8v64Zm40,80H136V136h16a32,32,0,0,1,0,64Z'></path></svg>",iconclass="bg-primary" ,title="Total Revenue",price="$25,378",IsIncreased=true,percentage="+5.35% "},
            new MainCard{svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M226.53,56.41l-96-32a8,8,0,0,0-5.06,0l-96,32A8,8,0,0,0,24,64v80a8,8,0,0,0,16,0V75.1L73.59,86.29a64,64,0,0,0,20.65,88.05c-18,7.06-33.56,19.83-44.94,37.29a8,8,0,1,0,13.4,8.74C77.77,197.25,101.57,184,128,184s50.23,13.25,65.3,36.37a8,8,0,0,0,13.4-8.74c-11.38-17.46-27-30.23-44.94-37.29a64,64,0,0,0,20.65-88l44.12-14.7a8,8,0,0,0,0-15.18ZM176,120A48,48,0,1,1,89.35,91.55l36.12,12a8,8,0,0,0,5.06,0l36.12-12A47.89,47.89,0,0,1,176,120ZM128,87.57,57.3,64,128,40.43,198.7,64Z'></path></svg>",iconclass="bg-primary1" ,title="Total Students",price="78,565",IsIncreased=true,percentage="+12.1%"},
            new MainCard{svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M128,24A104,104,0,1,0,232,128,104.11,104.11,0,0,0,128,24ZM74.08,197.5a64,64,0,0,1,107.84,0,87.83,87.83,0,0,1-107.84,0ZM96,120a32,32,0,1,1,32,32A32,32,0,0,1,96,120Zm97.76,66.41a79.66,79.66,0,0,0-36.06-28.75,48,48,0,1,0-59.4,0,79.66,79.66,0,0,0-36.06,28.75,88,88,0,1,1,131.52,0Z'></path></svg>",iconclass="bg-primary2" ,title="Total Instructors",price="6,247",IsIncreased=false,percentage="-10.21%"},
            new MainCard{svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M223.68,66.15,135.68,18a15.88,15.88,0,0,0-15.36,0l-88,48.17a16,16,0,0,0-8.32,14v95.64a16,16,0,0,0,8.32,14l88,48.17a15.88,15.88,0,0,0,15.36,0l88-48.17a16,16,0,0,0,8.32-14V80.18A16,16,0,0,0,223.68,66.15ZM128,32l80.34,44-29.77,16.3-80.35-44ZM128,120,47.66,76l33.9-18.56,80.34,44ZM40,90l80,43.78v85.79L40,175.82Zm176,85.78h0l-80,43.79V133.82l32-17.51V152a8,8,0,0,0,16,0V107.55L216,90v85.77Z'></path></svg>",iconclass="bg-primary3" ,title="Total Courses",price="2,467",IsIncreased=true,percentage="+16.1%"},
        };
        public List<MainCard> GetCoursesMainCards() => CoursesCardData;
        private List<ProductList> ProfessorsListData = new List<ProductList>()
        {
            new ProductList {Id=1, Product="../assets/images/faces/2.jpg", Productsize="avatar-sm me-2",ProductTitle="John Henry", Category="M.Tech",Amount="321 Classes",Sales="Digital Marketing",IsRounded=true},
            new ProductList {Id=2, Product="../assets/images/faces/12.jpg", Productsize="avatar-sm me-2",ProductTitle="Mortal Yun", Category="P.H.D",Amount="25 Classes",Sales="Stocks & Trading",IsRounded=true},
            new ProductList {Id=3, Product="../assets/images/faces/13.jpg", Productsize="avatar-sm me-2",ProductTitle="Trex Con", Category="MBBS",Amount="39 Classes",Sales="Science",IsRounded=true},
            new ProductList {Id=4, Product="../assets/images/faces/3.jpg", Productsize="avatar-sm me-2",ProductTitle="Saiu Sarah", Category="P.H.D",Amount="11 Classes",Sales="Science",IsRounded=true},
            new ProductList {Id=5, Product="../assets/images/faces/4.jpg", Productsize="avatar-sm me-2",ProductTitle="Ion Hau", Category="M.Tech",Amount="124 Classes",Sales="Web Development",IsRounded=true},
            new ProductList {Id=6, Product="../assets/images/faces/14.jpg", Productsize="avatar-sm me-2",ProductTitle="Roman Killon", Category="M.Tech",Amount="1263 Classes",Sales="Ui / Ux Designing",IsRounded=true},
            new ProductList {Id=7, Product="../assets/images/faces/5.jpg", Productsize="avatar-sm me-2",ProductTitle="Suzika Stallone", Category="P.H.D",Amount="110 Classes",Sales="Machine Leadning",IsRounded=true},
            new ProductList {Id=8, Product="../assets/images/faces/15.jpg", Productsize="avatar-sm me-2",ProductTitle="Robert Lewis", Category="P.H.D",Amount="150 Classes",Sales="Java Development",IsRounded=true},
        }; 
        public List<ProductList> GetProfessorssList() => ProfessorsListData;
        private TableText[] CourseListHeaderData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Course"},
            new TableText { Title = "Classes"},
            new TableText { Title = "Last Updated"},
            new TableText { Title = "Instructor"},
            new TableText { Title = "Students"},
            new TableText { Title = "Actions"},
        }; 
        public TableText[] GetCourseListHeaderData() => CourseListHeaderData;
        public List<CourseTable> CoursesListData = new List<CourseTable>(){
            new CourseTable{CourseId=1,CourseImg="../assets/images/media/media-1.jpg",CourseTitle="CSS Zero to Hero Master Class",Category="UI/UX Designing",Classes="51",Updated="22-06-2023",Instructor="Burak Oin",Students="252"},
            new CourseTable{CourseId=2,CourseImg="../assets/images/media/media-4.jpg",CourseTitle="Digital Marketing Course From Scratch",Category="Marketing",Classes="115",Updated="21-06-2023",Instructor="Stuart Little",Students="1,189"},
            new CourseTable{CourseId=3,CourseImg="../assets/images/media/media-10.jpg",CourseTitle="Digital Marketing Course From Scratch",Category="Programming",Classes="30",Updated="15-06-2023",Instructor="Boran Ray",Students="3,365"},
            new CourseTable{CourseId=4,CourseImg="../assets/images/media/media-15.jpg",CourseTitle="Master Linear Algebra Medium Level",Category="Mathematics",Classes="90",Updated="11-06-2023",Instructor="Arya Neo",Students="773"},
            new CourseTable{CourseId=5,CourseImg="../assets/images/media/media-23.jpg",CourseTitle="Learn How to Trade & Invest",Category="Stocks & Trading",Classes="161",Updated="10-06-2023",Instructor="Sia Niu",Students="51"},
        };
        public List<CourseTable> GetCoursesListData() => CoursesListData;
        public List<UpcomingTasks> UpcomingTasksData = new List<UpcomingTasks>(){
            new UpcomingTasks{CourseId=1,CourseTitle="Web Design",Date="10-06-2023",Durationstart="09:00am",Durationend="12:00pm"},
            new UpcomingTasks{CourseId=2,CourseTitle="Java Programming",Date="15-06-2023",Durationstart="12:00pm",Durationend="13:20pm"},
            new UpcomingTasks{CourseId=3,CourseTitle="Meeting Yuhan Sev",Date="15-06-2023",Durationstart="16:00pm",Durationend="17:20pm"},
            new UpcomingTasks{CourseId=4,CourseTitle="UX/UI",Date="20-06-2023",Durationstart="18:15pm",Durationend="19:00pm"},
            new UpcomingTasks{CourseId=5,CourseTitle="React js",Date="20-06-2023",Durationstart="18:15pm",Durationend="19:00pm"},
            new UpcomingTasks{CourseId=6,CourseTitle="Java Programming",Date="15-06-2023",Durationstart="12:00pm",Durationend="13:20pm"},
        };
        public List<UpcomingTasks> GetUpcomingTasksData() => UpcomingTasksData;
        
        public static List<Earning> GetEarning() {
            var earning = new List<Earning>();
            earning.Add(new Earning { Year = "Jan", ThisYearValue = 44, LastYearValue = 23});
            earning.Add(new Earning { Year = "Feb", ThisYearValue = 55, LastYearValue = 11});
            earning.Add(new Earning { Year = "Mar", ThisYearValue = 41, LastYearValue = 22});
            earning.Add(new Earning { Year = "Apr", ThisYearValue = 67, LastYearValue = 35});
            earning.Add(new Earning { Year = "May", ThisYearValue = 42, LastYearValue = 17});
            earning.Add(new Earning { Year = "Jun", ThisYearValue = 22, LastYearValue = 28});
            earning.Add(new Earning { Year = "Jul", ThisYearValue = 43, LastYearValue = 22});
            earning.Add(new Earning { Year = "Aug", ThisYearValue = 21, LastYearValue = 37});
            earning.Add(new Earning { Year = "Sep", ThisYearValue = 41, LastYearValue = 21});
            earning.Add(new Earning { Year = "Oct", ThisYearValue = 56, LastYearValue = 44});
            earning.Add(new Earning { Year = "Nov", ThisYearValue = 27, LastYearValue = 22});
            earning.Add(new Earning { Year = "Dec", ThisYearValue = 43, LastYearValue = 30});
            return earning;
        }

        public List<CategoriesList> CategoriesListData = new List<CategoriesList>(){
            new CategoriesList{CategorieIcon="ri-dashboard-line",CategorieColor="bg-primary-transparent",CategorieTitle="UI / UX Design",Courses="10,000",Price="$199.99"},
            new CategoriesList{CategorieIcon="ri-advertisement-line",CategorieColor="bg-primary1-transparent",CategorieTitle="Digital Marketing",Courses="90",Price="$599.99"},
            new CategoriesList{CategorieIcon="ri-code-box-line",CategorieColor="bg-primary2-transparent",CategorieTitle="Web Development",Courses="250",Price="$299.99"},
            new CategoriesList{CategorieIcon="ri-bar-chart-2-line",CategorieColor="bg-primary3-transparent",CategorieTitle="Stocks & Trading",Courses="100",Price="$999.99"},
            new CategoriesList{CategorieIcon="ri-angularjs-line",CategorieColor="bg-secondary-transparent",CategorieTitle="Angular Course",Courses="300",Price="$399.99"},
            new CategoriesList{CategorieIcon="ri-database-2-line",CategorieColor="bg-info-transparent",CategorieTitle="Full Stack Course",Courses="500",Price="$199.99"},
        };
        public List<CategoriesList> GetCategoriesListData() => CategoriesListData;
        
        public List<CourseList> CourseListData = new List<CourseList>(){
            new CourseList{CourseImg="../assets/images/media/media-78.png",CourseTitle="Coding Classes",Price="$644"},
            new CourseList{CourseImg="../assets/images/media/media-76.png",CourseTitle="Data Science",Price="$657"},
            new CourseList{CourseImg="../assets/images/media/media-79.png",CourseTitle="Marketing",Price="$457"},
            new CourseList{CourseImg="../assets/images/media/media-78.png",CourseTitle="Java",Price="$778"},
            new CourseList{CourseImg="../assets/images/media/media-78.png",CourseTitle="Coding Classes",Price="$644"},
            new CourseList{CourseImg="../assets/images/media/media-76.png",CourseTitle="Data Science",Price="$657"},
            new CourseList{CourseImg="../assets/images/media/media-79.png",CourseTitle="Marketing",Price="$457"},
        };
        public List<CourseList> GetCourseListData() => CourseListData;
    }
}
