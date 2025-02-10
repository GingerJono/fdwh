using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Hrm
{
    public class HrmService
    {
        public static List<HrmChart> GetHrmChart(HrmMainCard HrmMainChart)
        {
            var HrmChart = new List<HrmChart>();
            var valuesMap = new Dictionary<string, List<decimal>>
            {
                { "Total Employees", new List<decimal> { 47, 45, 54, 38, 56, 24, 65, 31, 37 , 39, 62,51,35,41,35,27,53,53,61,27,54,43,19,46} },
                { "Total Job Applied", new List<decimal> { 47, 45, 54, 38, 56, 24, 65, 31, 37 , 39, 62,51,35,41,35,27,53,53,61,27,54,43,19,46 } },
                { "Total Compensation", new List<decimal> { 47, 45, 54, 38, 56, 24, 65, 31, 37 , 39, 62,51,35,41,35,27,53,53,61,27,54,43,19,46 } },
                { "Annual Compensation", new List<decimal> { 47, 45, 54, 38, 56, 24, 65, 31, 37 , 39, 62,51,35,41,35,27,53,53,61,27,54,43,19,46 } }
            };
            var title = HrmMainChart?.Title;
            if (!string.IsNullOrEmpty(title) && valuesMap.ContainsKey(title))
            {
                var values = valuesMap[title];
                for (int i = 0; i < values.Count; i++)
                {
                    HrmChart.Add(new HrmChart { Series = i + 1, Value = values[i] });
                }
            }
            return HrmChart;
        }
        private List<HrmMainCard> HrmMainChartData = new List<HrmMainCard>( )
        {
            new HrmMainCard { Title = "Total Employees", TotalValue = "12,116", Percentage = " 2.5%", IsIncreased = true },
            new HrmMainCard { Title = "Total Job Applied", TotalValue = "15,784", Percentage = " 1.5%", IsIncreased = false },
            new HrmMainCard { Title = "Total Compensation", TotalValue = "$56,784", Percentage = " 6.0%", IsIncreased = true },
            new HrmMainCard { Title = "Annual Compensation", TotalValue = "$6.8k", Percentage = " 6.0%", IsIncreased = true },
        };
        public List<HrmMainCard> GetHrmMainCard() => HrmMainChartData;
        public static List<Project> GetProjectData() {
            var project = new List<Project>();
            project.Add(new Project { Month = "Jan", New = 45, Inprogress = 30, Completed = 15, Onhold = 15});
            project.Add(new Project { Month = "Feb", New = 30, Inprogress = 35, Completed = 30, Onhold = 20});
            project.Add(new Project { Month = "Mar", New = 49, Inprogress = 25, Completed = 19, Onhold = 20});
            project.Add(new Project { Month = "Apr", New = 45, Inprogress = 20, Completed = 30, Onhold = 15});
            project.Add(new Project { Month = "May", New = 36, Inprogress = 35, Completed = 34, Onhold = 25});
            project.Add(new Project { Month = "Jun", New = 42, Inprogress = 25, Completed = 25, Onhold = 25});
            project.Add(new Project { Month = "Jul", New = 30, Inprogress = 36, Completed = 36, Onhold = 15});
            project.Add(new Project { Month = "Aug", New = 35, Inprogress = 54, Completed = 45, Onhold = 15});
            project.Add(new Project { Month = "Sep", New = 35, Inprogress = 36, Completed = 36, Onhold = 45});
            project.Add(new Project { Month = "Oct", New = 54, Inprogress = 29, Completed = 29, Onhold = 30});
            project.Add(new Project { Month = "Nov", New = 29, Inprogress = 49, Completed = 49, Onhold = 45});
            project.Add(new Project { Month = "Dec", New = 36, Inprogress = 42, Completed = 42, Onhold = 20});
            return project;
        }
        public static List<Gender> GetGenderData()
        {
            var gender = new List<Gender>();
            gender.Add( new Gender { GenderSeries = "Total", GenderValue = 500, });
            gender.Add( new Gender { GenderSeries = "Male", GenderValue = 350, });
            gender.Add( new Gender { GenderSeries = "Female", GenderValue = 150, });
            return gender;
        }
        private List<UpcomingEvents> UpcomingEventsData = new List<UpcomingEvents>( )
        {
            new UpcomingEvents {DateColor="bg-primary-transparent",Date="02",Day="Mon",Title="You have an announcement - Ipsum Est Diam Eirmod",Desc="10:00AM<span class='badge bg-primary-transparent ms-2'>Announcement</span>"},
            new UpcomingEvents {DateColor="bg-primary1-transparent",Date="08",Day="Tue",Title="National holiday - Vero Jayanti",Desc="<span class='badge bg-warning-transparent'>Holiday</span>"},
            new UpcomingEvents {DateColor="bg-primary2-transparent",Date="12",Day="Wed",Title="John pup birthday - Team Member",Desc="09:00AM<span class='badge bg-success-transparent ms-2'>Birthday</span>"},
            new UpcomingEvents {DateColor="bg-primary3-transparent",Date="20",Day="Thu",Title="National Holiday - Dolore Ipsum",Desc="<span class='badge bg-warning-transparent'>Holiday</span>"},
            new UpcomingEvents {DateColor="bg-warning-transparent",Date="12",Day="Wed",Title="Amet sed no dolor kasd - Et Dolores Tempor Erat",Desc="04:00PM<span class='badge bg-primary-transparent ms-2'>Announcement</span>"},
            new UpcomingEvents {DateColor="bg-secondary-transparent",Date="21",Day="Fri",Title="John pup birthday - Team Member",Desc="09:00AM<span class='badge bg-success-transparent ms-2'>Birthday</span>"},
        };
        public List<UpcomingEvents> GetUpcomingEvents() => UpcomingEventsData;
        
        public TableText[] EmployeesHeadersData = new TableText[]
        {
            new TableText { Title = "Employee" },
            new TableText { Title = "Type" },
            new TableText { Title = "Days" },
            new TableText { Title = "Status" },
            new TableText { Title = "Start Date" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetEmployeesHeadersData() => EmployeesHeadersData;
        private List<EmployeeList> EmployeeListData = new List<EmployeeList>( )
        {
            new EmployeeList {Id=1,EmployeeImg="../assets/images/faces/2.jpg",Employee="Socrates Itumay",Desig="Team Lead",Type="Sick",Days="2 Days",StatusColor="bg-success-transparent",Status="Approved",Date="30-05-2024"},
            new EmployeeList {Id=2,EmployeeImg="../assets/images/faces/4.jpg",Employee="Samantha Paul",Desig="Sr.UI Developer",Type="Casual",Days="1 Day",StatusColor="bg-warning-transparent",Status="Pending",Date="29-05-2024"},
            new EmployeeList {Id=3,EmployeeImg="../assets/images/faces/14.jpg",Employee="Gray Noal",Desig="Java Developer",Type="Paternity",Days="5 Days",StatusColor="bg-success-transparent",Status="Approved",Date="28-05-2024"},
            new EmployeeList {Id=4,EmployeeImg="../assets/images/faces/15.jpg",Employee="Gray Noal",Desig="React Developer",Type="Personal",Days="2 Days",StatusColor="bg-danger-transparent",Status="Rejected",Date="27-05-2024"},
            new EmployeeList {Id=5,EmployeeImg="../assets/images/faces/8.jpg",Employee="Emiley Jackson",Desig="Full Stack Developer",Type="Maternity",Days="2 Days",StatusColor="bg-success-transparent",Status="Approved",Date="26-05-2024"},
            new EmployeeList {Id=6,EmployeeImg="../assets/images/faces/16.jpg",Employee="Pope Johnson",Desig="Jr.Java Developer",Type="Gifted",Days="2 Days",StatusColor="bg-warning-transparent",Status="Pending",Date="25-05-2024"},
        };
        public List<EmployeeList> GetEmployeeList() => EmployeeListData;
        private List<MeetingList> MeetingListData = new List<MeetingList>( )
        {
            new MeetingList {Id=1,EmployeeImg="../assets/images/faces/15.jpg",ImgColor="bg-danger-transparent",Employee="Anurag Batiya",Time="03 May(9.00am-10.00am)"},
            new MeetingList {Id=2,EmployeeImg="../assets/images/faces/3.jpg",ImgColor="bg-primary1-transparent",Employee="Project Meeting",Time="04 May(9.00am-10.00am)"},
            new MeetingList {Id=3,EmployeeImg="../assets/images/faces/6.jpg",ImgColor="bg-primary2-transparent",Employee="Team Meeting",Time="05 May(9.00am-10.00am)"},
            new MeetingList {Id=4,EmployeeImg="../assets/images/faces/13.jpg",ImgColor="bg-primary3-transparent",Employee="Client Meeting",Time="06 May(9.00am-10.00am)"},
            new MeetingList {Id=5,EmployeeImg="../assets/images/faces/3.jpg",ImgColor="bg-secondary-transparent",Employee="Client Meeting",Time="06 May(9.00am-10.00am)"},
            new MeetingList {Id=6,EmployeeImg="../assets/images/faces/11.jpg",ImgColor="bg-success-transparent",Employee="Team Meeting",Time="05 May(9.00am-10.00am)"},
            new MeetingList {Id=7,EmployeeImg="../assets/images/faces/1.jpg",ImgColor="bg-info-transparent",Employee="Project Meeting",Time="04 May(9.00am-10.00am)"},
        };
        public List<MeetingList> GetMeetingList() => MeetingListData;
        
        private List<EmployeeList> EmployeeDirectoryData = new List<EmployeeList>( )
        {
            new EmployeeList {Id=01,EmployeeId="#emp23520",EmployeeImg="../assets/images/faces/1.jpg",Employee="Socrates Itumay",Desig="Team Leader",Type="Backend",Email="richard116@demo.com",StatusColor="bg-success-transparent",Status="Active",Contact="+0987654321",Salary="$15,000"},
            new EmployeeList {Id=02,EmployeeId="#emp23521",EmployeeImg="../assets/images/faces/2.jpg",Employee="Kakashra Sri",Desig="Web Developer",Type="Front End",Email="Kakashra987@demo.com",StatusColor="bg-success-transparent",Status="Active",Contact="+0986548761",Salary="$20,000"},
            new EmployeeList {Id=03,EmployeeId="#emp23522",EmployeeImg="../assets/images/faces/3.jpg",Employee="Nikki Jey",Desig="Project Manager",Type="HR",Email="Nikki654@demo.com",StatusColor="bg-info-transparent",Status="On Leave",Contact="+0986548787",Salary="$25,000"},
            new EmployeeList {Id=04,EmployeeId="#emp23523",EmployeeImg="../assets/images/faces/4.jpg",Employee="Sasukey Ahuhi",Desig="Project Manager",Type="HR",Email="Sasukey986@demo.com	",StatusColor="bg-success-transparent",Status="Active",Contact="+0986548788",Salary="$30,000"},
            new EmployeeList {Id=05,EmployeeId="#emp23524",EmployeeImg="../assets/images/faces/5.jpg",Employee="Xiong Yu",Desig="UI Developer",Type="Engineering",Email="Xiongu987@demo.com",StatusColor="bg-success-transparent",Status="Active",Contact="+0986548988",Salary="$35,000"},
            new EmployeeList {Id=06,EmployeeId="#emp23525",EmployeeImg="../assets/images/faces/6.jpg",Employee="Arifa Zed",Desig="Team Member",Type="IT",Email="Arifa432@demo.com",StatusColor="bg-danger-transparent",Status="Resigned",Contact="+0986548985",Salary="$40,000"},
            new EmployeeList {Id=07,EmployeeId="#emp23526",EmployeeImg="../assets/images/faces/7.jpg",Employee="Jennifer Tab",Desig="Project Manager",Type="Front End",Email="Jennifer543@demo.com	",StatusColor="bg-success-transparent",Status="Active",Contact="+09865489987",Salary="$45,000"},
        };
        public List<EmployeeList> GetEmployeeDirectory() => EmployeeDirectoryData;
        
        public TableText[] DirectoryHeadersData = new TableText[]
        {
            new TableText { Title = "S.No" },
            new TableText { Title = "Employee Id" },
            new TableText { Title = "Employee Name" },
            new TableText { Title = "Position" },
            new TableText { Title = "Department" },
            new TableText { Title = "Email" },
            new TableText { Title = "Status" },
            new TableText { Title = "Contact" },
            new TableText { Title = "Salary" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetDirectoryHeadersData() => DirectoryHeadersData;
    }
}