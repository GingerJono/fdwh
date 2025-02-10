using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Jobs
{
    public class JobsService{
        public static List<JobStatistics> GetJobStatisticss() {
            var jobsstatistics = new List<JobStatistics>();
            jobsstatistics.Add(new JobStatistics { Week = "Sun", ApplicationsValue = 30, ShortlistedValue = 33, RejectedValue = 30, OnHoldValue = 44});
            jobsstatistics.Add(new JobStatistics { Week = "Mon", ApplicationsValue = 25, ShortlistedValue = 21, RejectedValue = 25, OnHoldValue = 55});
            jobsstatistics.Add(new JobStatistics { Week = "Tue", ApplicationsValue = 36, ShortlistedValue = 32, RejectedValue = 36, OnHoldValue = 41});
            jobsstatistics.Add(new JobStatistics { Week = "Wed", ApplicationsValue = 30, ShortlistedValue = 37, RejectedValue = 30, OnHoldValue = 42});
            jobsstatistics.Add(new JobStatistics { Week = "Thu", ApplicationsValue = 45, ShortlistedValue = 23, RejectedValue = 45, OnHoldValue = 22});
            jobsstatistics.Add(new JobStatistics { Week = "Fri", ApplicationsValue = 35, ShortlistedValue = 32, RejectedValue = 35, OnHoldValue = 43});
            jobsstatistics.Add(new JobStatistics { Week = "Sat", ApplicationsValue = 64, ShortlistedValue = 47, RejectedValue = 64, OnHoldValue = 21});
            return jobsstatistics;
        }
        public static List<Candidate> GetCandidates()
        {
            var Candidates = new List<Candidate>();
            Candidates.Add(new Candidate { CandidateSeries = "Male", CandidateValue = 1754 });
            Candidates.Add(new Candidate { CandidateSeries = "Female", CandidateValue = 634});
            return Candidates;
        }
        public TableText[] JobsHeadersData = new TableText[]{
            new TableText { Title = "Job Title"},
            new TableText { Title = "Applicants"},
            new TableText { Title = "Openings End"},
            new TableText { Title = "Location"},
            new TableText { Title = "Action"},
        };        
        public  TableText[] GetJobsHeadersData() => JobsHeadersData;
        public List<RecentJobs> JobsData = new List<RecentJobs>{
            new RecentJobs {Id = 1,JobIcon = "ri-android-line",JobColor = "primary",JobTile = "Sr. Mobile App Developer",Posted = "1 day ago",Applicants = "56",Openings = "27 May 2024",Location = "Georgia, XY"},
            new RecentJobs {Id = 2,JobIcon = "ri-database-2-line",JobColor = "secondary",JobTile = "Data Scientist Trainee",Posted = "1 day ago",Applicants = "784",Openings = "03 Jun 2024",Location = "Siberia, PQ"},
            new RecentJobs {Id = 3,JobIcon = "ri-reactjs-line",JobColor = "info",JobTile = "React Developer",Posted = "1 day ago",Applicants = "421",Openings = "18 Jun 2024",Location = "Italy, Rs"},
            new RecentJobs {Id = 4,JobIcon = "ri-amazon-line",JobColor = "success",JobTile = "AWS Engineer",Posted = "1 day ago",Applicants = "257",Openings = "15 Jun 2024",Location = "Georgia, XY"},
            new RecentJobs {Id = 5,JobIcon = "ri-layout-masonry-line",JobColor = "warning",JobTile = "Ui Developer",Posted = "1 day ago",Applicants = "87",Openings = "20 Jun 2024",Location = "Canada, UK"},
            new RecentJobs {Id = 6,JobIcon = "ri-angularjs-line",JobColor = "danger",JobTile = "Angular Developer",Posted = "3 days ago",Applicants = "86",Openings = "23 Jun 2024",Location = "Germany, US"},
        };        
        public List<RecentJobs> GetJobsData() => JobsData;

        private List<MainCard> MainCardData = new List<MainCard>()
        {
            new MainCard {
                id = 1,
                title = "JOB APPLICATIONS",
                svg = " <svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,80l-96,56L32,80l96-56Z' opacity='0.2'></path><path d='M230.91,172A8,8,0,0,1,228,182.91l-96,56a8,8,0,0,1-8.06,0l-96-56A8,8,0,0,1,36,169.09l92,53.65,92-53.65A8,8,0,0,1,230.91,172ZM220,121.09l-92,53.65L36,121.09A8,8,0,0,0,28,134.91l96,56a8,8,0,0,0,8.06,0l96-56A8,8,0,1,0,220,121.09ZM24,80a8,8,0,0,1,4-6.91l96-56a8,8,0,0,1,8.06,0l96,56a8,8,0,0,1,0,13.82l-96,56a8,8,0,0,1-8.06,0l-96-56A8,8,0,0,1,24,80Zm23.88,0L128,126.74,208.12,80,128,33.26Z'></path></svg>",
                iconclass ="avatar-lg bg-primary-transparent svg-primary border-3 border border-opacity-50 flex-shrink-0 border-primary",
                price = "47,784" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="1.6%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
            },
            new MainCard {
                id = 2,
                title = "INTERVIEW SCHEDULE",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M216,48V88H40V48a8,8,0,0,1,8-8H208A8,8,0,0,1,216,48Z' opacity='0.2'></path><path d='M208,32H184V24a8,8,0,0,0-16,0v8H88V24a8,8,0,0,0-16,0v8H48A16,16,0,0,0,32,48V208a16,16,0,0,0,16,16H208a16,16,0,0,0,16-16V48A16,16,0,0,0,208,32ZM72,48v8a8,8,0,0,0,16,0V48h80v8a8,8,0,0,0,16,0V48h24V80H48V48ZM208,208H48V96H208V208Zm-68-76a12,12,0,1,1-12-12A12,12,0,0,1,140,132Zm44,0a12,12,0,1,1-12-12A12,12,0,0,1,184,132ZM96,172a12,12,0,1,1-12-12A12,12,0,0,1,96,172Zm44,0a12,12,0,1,1-12-12A12,12,0,0,1,140,172Zm44,0a12,12,0,1,1-12-12A12,12,0,0,1,184,172Z'></path></svg>",
                iconclass ="avatar-lg bg-primary1-transparent svg-primary1  border-3 border border-opacity-50 flex-shrink-0 border-primary1 ",
                price = "5,358" ,
                status ="Decreased ",
                statusclass ="text-danger",
                statusdata ="3.1%",
                statusicon ="ti ti-arrow-narrow-down ",
                IsRounded=true,
            },
            new MainCard {
                id = 3,
                title = "SHORTLISTED",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M120,104A40,40,0,1,1,80,64,40,40,0,0,1,120,104Z' opacity='0.2'></path><path d='M152,80a8,8,0,0,1,8-8h88a8,8,0,0,1,0,16H160A8,8,0,0,1,152,80Zm96,40H160a8,8,0,0,0,0,16h88a8,8,0,0,0,0-16Zm0,48H184a8,8,0,0,0,0,16h64a8,8,0,0,0,0-16Zm-96.25,22a8,8,0,0,1-5.76,9.74,7.55,7.55,0,0,1-2,.26,8,8,0,0,1-7.75-6c-6.16-23.94-30.34-42-56.25-42s-50.09,18.05-56.25,42a8,8,0,0,1-15.5-4c5.59-21.71,21.84-39.29,42.46-48a48,48,0,1,1,58.58,0C129.91,150.71,146.16,168.29,151.75,190ZM80,136a32,32,0,1,0-32-32A32,32,0,0,0,80,136Z'></path></svg>",
                iconclass ="avatar-lg bg-primary2-transparent svg-primary2  border-3 border border-opacity-50 flex-shrink-0 border-primary2 ",
                price = "784" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="1.3%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
            },
            new MainCard {
                id = 4,
                title = "REJECTED APPLICATIONS",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,128a96,96,0,1,1-96-96A96,96,0,0,1,224,128Z' opacity='0.2'></path><path d='M165.66,101.66,139.31,128l26.35,26.34a8,8,0,0,1-11.32,11.32L128,139.31l-26.34,26.35a8,8,0,0,1-11.32-11.32L116.69,128,90.34,101.66a8,8,0,0,1,11.32-11.32L128,116.69l26.34-26.35a8,8,0,0,1,11.32,11.32ZM232,128A104,104,0,1,1,128,24,104.11,104.11,0,0,1,232,128Zm-16,0a88,88,0,1,0-88,88A88.1,88.1,0,0,0,216,128Z'></path></svg>",
                iconclass ="avatar-lg bg-primary3-transparent svg-primary3  border-3 border border-opacity-50 flex-shrink-0 border-primary3",
                price = "47,784" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="0.3%",
                statusicon ="ti ti-arrow-narrow-down ",
                IsRounded=true,
            },
            new MainCard {
                id = 5,
                title = "ON-HOLD APPLICATIONS",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M159.46,53l-17.78,83H114.32L96.54,53A24,24,0,0,1,120,24h16A24,24,0,0,1,159.46,53Z' opacity='0.2'></path><path d='M224,224a8,8,0,0,1-8,8H40a8,8,0,0,1,0-16H216A8,8,0,0,1,224,224Zm0-80v40a16,16,0,0,1-16,16H48a16,16,0,0,1-16-16V144a16,16,0,0,1,16-16h56.43L88.72,54.71A32,32,0,0,1,120,16h16a32,32,0,0,1,31.29,38.71L151.57,128H208A16,16,0,0,1,224,144ZM120.79,128h14.42l16.43-76.65A16,16,0,0,0,136,32H120a16,16,0,0,0-15.65,19.35ZM208,184V144H48v40H208Z'></path></svg>",
                iconclass ="avatar-lg bg-secondary-transparent svg-secondary  border-3 border border-opacity-50 flex-shrink-0 border-secondary",
                price = "11,574" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="0.1%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
            },
        };

        public List<MainCard> GetMainCard() => MainCardData;
        
        private List<ProductActivity> JobsActivityData = new List<ProductActivity>()
        {
            new ProductActivity {Id=1,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-primary-transparent flex-shrink-0 border border-primary border-opacity-10",Icon="ri-user-fill",Title="New Job Posted",Desc="Frontend Developer",Duration="2 mins ago"},
            new ProductActivity {Id=2,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-primary1-transparent flex-shrink-0 border border-primary1 border-opacity-10",Icon="ri-file-list-3-fill",Title="New Application",Desc="<a href='javascript:void(0);' class='fw-medium text-primary'>John Doe</a> applied for Frontend Developer position",Duration="5 mins ago"},
            new ProductActivity {Id=3,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-primary2-transparent flex-shrink-0 border border-primary2 border-opacity-10",Icon="ri-user-fill",Title="New Job Posted",Desc="<span class='fw-medium text-primary1'>#245</span> Backend Developer ",Duration="10 mins ago"},
            new ProductActivity {Id=4,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-primary3-transparent flex-shrink-0 border border-primary3 border-opacity-10",Icon="ri-user-fill",Title="New Job Posted",Desc="Backend Developer",Duration="10 mins ago"},
            new ProductActivity {Id=5,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-secondary-transparent flex-shrink-0 border border-secondary border-opacity-10",Icon="ri-calendar-check-fill",Title="Updated Interview Dates",Desc="Updated new interview scheduled and added in the <a href='javascript:void(0);' class='fw-medium text-primary2 text-decoration-underline'>notification list</a>",Duration="15 mins ago"},
            new ProductActivity {Id=5,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-danger-transparent flex-shrink-0 border border-danger border-opacity-10",Icon="ri-calendar-check-fill",Title="Rescheduled Interview Dates",Desc="Rescheduled interview dates <a href='javascript:void(0);'' class='fw-medium text-primary2 text-decoration-underline'>notification list</a>",Duration="15 mins ago"},
            new ProductActivity {Id=6,IconSize="avatar-sm",Activityclass="gap-2",Iconclass="bg-warning-transparent flex-shrink-0 border border-warning border-opacity-10",Icon="ri-time-fill",Title="Closed Job Post",Desc="closed React Job ID: <span class='fw-medium text-primary'>#454</span>",Duration="15 mins ago"},
        };
        public List<ProductActivity> GetJobsActivity() => JobsActivityData;
        
        private List<HireList> HireData = new List<HireList>()
        {
            new HireList {HireIcon="UD",HireColor="primary",HireTile="UI/UX Designers",Status="75% completed",StatusColor="success",Candidates="03"},
            new HireList {HireIcon="SD",HireColor="primary1",HireTile="Senior Developer",Status="15% completed",StatusColor="danger",Candidates="12"},
            new HireList {HireIcon="MM",HireColor="primary2",HireTile="Marketing Manager",Status="pending",StatusColor="warning",Candidates="08"},
            new HireList {HireIcon="CW",HireColor="primary3",HireTile="Content Writers",Status="55% completed",StatusColor="success",Candidates="01"},
            new HireList {HireIcon="RD",HireColor="warning",HireTile="React Developer",Status="15% completed",StatusColor="danger",Candidates="03"},
        };
        public List<HireList> GetHireData() => HireData;
        private List<HireList> ApplicantsData = new List<HireList>()
        {
            new HireList {HireIMG="../assets/images/faces/1.jpg",HireTile="Mona Cruzis",Status="React Developer"},
            new HireList {HireIMG="../assets/images/faces/11.jpg",HireTile="Soyab Khan",Status="Java Developer"},
            new HireList {HireIcon="KM",HireColor="primary2",HireTile="Katherine Myn",Status="UI Developer"},
            new HireList {HireIMG="../assets/images/faces/13.jpg",HireTile="James Roy",Status="React Developer"},
            new HireList {HireIMG="../assets/images/faces/5.jpg",HireTile="Cayathe Dore",Status="Vue.js Developer"},
            new HireList {HireIcon="SP",HireColor="primary3",HireTile="Surjith Pandey",Status="UX Developer"},
        };
        public List<HireList> GetApplicantsData() => ApplicantsData;
        public TableText[] JobsApplicantsHeadersData = new TableText[]{
            new TableText { Title = "S.No"},
            new TableText { Title = "Candidate"},
            new TableText { Title = "Category"},
            new TableText { Title = "Designation"},
            new TableText { Title = "Mail"},
            new TableText { Title = "Location"},
            new TableText { Title = "Date"},
            new TableText { Title = "Type"},
            new TableText { Title = "Action"},
        };        
        public  TableText[] GetJobsApplicantsHeadersData() => JobsApplicantsHeadersData;
        
        
        private List<Applicants> JobsApplicantsData = new List<Applicants>()
        {
            new Applicants {Id=01, CandidateIMG="../assets/images/faces/4.jpg", Candidate="Mayor Kelly",Category="Manufacture",Design="Team Lead",DesigColor="text-secondary",Mail="mayorkelly@gmail.com",Location="Germany",Date="Sep 15 - Oct 12, 2023",Status="Full Time",StatusColor="bg-primary-transparent"},
            new Applicants {Id=02, CandidateIMG="../assets/images/faces/15.jpg", Candidate="Andrew Garfield",Category="Development",Design="Sr.UI Developer",DesigColor="text-secondary",Mail="andrewgarfield@gmail.com",Location="Canada",Date="Apr 10 - Dec 12, 2023",Status="Full Time",StatusColor="bg-primary-transparent"},
            new Applicants {Id=03, CandidateIMG="../assets/images/faces/11.jpg", Candidate="Simon Cowel",Category="Service",Design="Sr.UI Developer",DesigColor="text-secondary",Mail="simoncowel234@gmail.com",Location="Europe",Date="Sep 15 - Oct 12, 2023",Status="Part Time",StatusColor="bg-secondary-transparent",},
            new Applicants {Id=04, CandidateIMG="../assets/images/faces/8.jpg", Candidate="Mirinda Hers",Category="Marketing",Design="Sales Executive",DesigColor="text-danger",Mail="mirindahers@gmail.com",Location="USA",Date="Apr 10 - Dec 12, 2023",Status="Hybride",StatusColor="bg-danger-transparent",},
            new Applicants {Id=05, CandidateIMG="../assets/images/faces/16.jpg", Candidate="Andrew Garfield",Category="Development",Design="Sr.UI Developer",DesigColor="text-secondary",Mail="andrewgarfield@gmail.com",Location="London",Date="Jun 10 - Dec 12, 2022",Status="Freelancer",StatusColor="bg-success-transparent",},
        };
        public List<Applicants> GetJobsApplicantsData() => JobsApplicantsData;
    }
}
