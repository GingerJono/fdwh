using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Projects
{
    public class ProjectsService{
        public List<MainCard> ProjectsCardData = new List<MainCard>{
            new MainCard {icon="ri-pages-line" ,iconclass="primary",title="New Projects",price="432",IsIncreased=false,percentage="-5.20%"},
            new MainCard {icon="ri-check-double-line" ,iconclass="primary1",title="Completed",price="122",IsIncreased=true,percentage="+7.20%"},
            new MainCard {icon="ri-loop-left-fill" ,iconclass="primary2",title="Ongoing Projects",price="1,265",IsIncreased=false,percentage="-5.20%"},
            new MainCard {icon="ri-time-line" ,iconclass="primary3",title="Pending Projects",price="1,265",IsIncreased=true,percentage="+5.20%"},
        };        
        public List<MainCard> GetProjectsCardData() => ProjectsCardData;
        public static List<ProjectsChart> GetProjectsChart(MainCard MainCard)
        {
            var projectsChart = new List<ProjectsChart>();
            var sharedValues = new List<decimal> { 12, 14, 18, 47, 42, 15, 47, 75, 65, 19, 14, 50};
           var titles = new List<string>
            {
                "New Projects","Completed","Ongoing Projects","Pending Projects",
            };
            var title = MainCard?.title;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    projectsChart.Add(new ProjectsChart { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return projectsChart;
        }
        public static List<ProjectStatistics> GetProjectStatistics() {
            var projectstatistics = new List<ProjectStatistics>();
            projectstatistics.Add(new ProjectStatistics { Statistics = "1", Projects = 15, Revenue = 20, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "2", Projects = 28, Revenue = 29, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "3", Projects = 23, Revenue = 37, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "4", Projects = 23, Revenue = 35, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "5", Projects = 41, Revenue = 44, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "6", Projects = 58, Revenue = 43, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "7", Projects = 48, Revenue = 50, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "8", Projects = 50, Revenue = 20, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "9", Projects = 22, Revenue = 20, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "10", Projects = 31, Revenue = 45, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "11", Projects = 40, Revenue = 45, });
            projectstatistics.Add(new ProjectStatistics { Statistics = "12", Projects = 45, Revenue = 52, });
            return projectstatistics;
        }
        public static List<MonthlyTargets> MonthlyTargets() {
            return new List<MonthlyTargets>
            {
                new MonthlyTargets { Targets = "New Projects", TargetsValue = 86},
                new MonthlyTargets { Targets = "Completed", TargetsValue = 80},
                new MonthlyTargets { Targets = "Pending", TargetsValue = 60},
            };
        }
        public static List<Summary> GetSummary() {
            var report = new List<Summary>();
            report.Add(new Summary { Week = "Su", ThisWeekValue = 44, LastWeekValue = 34});
            report.Add(new Summary { Week = "Mo", ThisWeekValue = 42, LastWeekValue = 22});
            report.Add(new Summary { Week = "Tu", ThisWeekValue = 57, LastWeekValue = 42});
            report.Add(new Summary { Week = "We", ThisWeekValue = 86, LastWeekValue = 56});
            report.Add(new Summary { Week = "Th", ThisWeekValue = 58, LastWeekValue = 21});
            report.Add(new Summary { Week = "Fr", ThisWeekValue = 55, LastWeekValue = 86});
            report.Add(new Summary { Week = "Sa", ThisWeekValue = 70, LastWeekValue = 60});
            return report;
        }
        public List<TeamList> TeamListData = new List<TeamList>{
            new TeamList {MemberImg="../assets/images/faces/2.jpg",Member="Richard Dom",Design="Team Leader",Works="457",ISOnline=true,TasksTotal="1145",TasksCompleted="564"},
            new TeamList {MemberImg="../assets/images/faces/11.jpg",Member="Jennifer Tab",Design="Project Manager",Works="965",ISOnline=true,TasksTotal="2145",TasksCompleted="1,754"},
            new TeamList {MemberImg="../assets/images/faces/3.jpg",Member="Nikki Jey",Design="UI Developer",Works="647",ISOnline=false,TasksTotal="1145",TasksCompleted="631"},
            new TeamList {MemberImg="../assets/images/faces/21.jpg",Member="Arifa Zed",Design="Web Developer",Works="983",ISOnline=true,TasksTotal="1236",TasksCompleted="502"},
            new TeamList {MemberImg="../assets/images/faces/4.jpg",Member="Xiong Yu",Design="Team Member",Works="631",ISOnline=true,TasksTotal="457",TasksCompleted="360"},
            new TeamList {MemberImg="../assets/images/faces/11.jpg",Member="Emanuel Gen",Design="Project Manager",Works="478",ISOnline=false,TasksTotal="698",TasksCompleted="558"},
        };        
        public List<TeamList> GetTeamListData() => TeamListData;
        public TableText[] TeamHeadersData = new TableText[]
        {
            new TableText { Title = "Name"},
            new TableText { Title = "Works"},
            new TableText { Title = "Status"},
            new TableText { Title = "Tasks"},
            new TableText { Title = "Actions"},
        };        
        public TableText[] GetTeamHeadersData() => TeamHeadersData;
        public TableText[] ProjectsHeadersData = new TableText[]
        {
            new TableText { Title = "S.No"},
            new TableText { Title = "Project Title"},
            new TableText { Title = "Tasks"},
            new TableText { Title = "Progress"},
            new TableText { Title = "Assigned Team"},
            new TableText { Title = "Status"},
            new TableText { Title = "Due Date"},
            new TableText { Title = "Actions"},
        };        
        public TableText[] GetProjectsHeadersData() => ProjectsHeadersData;

        public List<ProjectsList> ProjectsListData = new List<ProjectsList>{
            new ProjectsList {
                Id =1,Title ="Home Page",TasksTotal ="234",TasksCompleted ="210",Progress ="35",Status ="In Progress",Statusclass ="bg-primary-transparent",Duedate ="14-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/6.jpg"},new AssignedToItem { Img = "../assets/images/faces/7.jpg"},
                },
            },
            new ProjectsList {
                Id =2,Title ="Landing Design",TasksTotal ="185",TasksCompleted ="162",Progress ="80",Status ="In Progress",Statusclass ="bg-primary-transparent",Duedate ="20-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/6.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/7.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                },
            },
            new ProjectsList {
                Id =3,Title ="New Template Design",TasksTotal ="100",TasksCompleted ="10",Progress ="10",Status ="Pending",Statusclass ="bg-warning-transparent",Duedate ="29-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                },
            },
            new ProjectsList {
                Id =4,Title ="HR Management Design",TasksTotal ="52",TasksCompleted ="48",Progress ="63",Status ="In Progress",Statusclass ="bg-primary-transparent",Duedate ="18-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/14.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                },
            },
            new ProjectsList {
                Id =5,Title ="Designing New Template",TasksTotal ="192",TasksCompleted ="185",Progress ="100",Status ="Completed",Statusclass ="bg-success-transparent",Duedate ="11-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/14.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                },
            },
            new ProjectsList {
                Id =6,Title ="Documentation Project",TasksTotal ="72",TasksCompleted ="25",Progress ="50",Status ="In Progress",Statusclass ="bg-primary-transparent",Duedate ="18-05-2024",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/14.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/21.jpg"},
                },
            },
        };        
        public List<ProjectsList> GetProjectsListData() => ProjectsListData;

        public List<TasksList> TasksListData = new List<TasksList>{
            new TasksList {
                Title ="Home Page Design",
                Duedate ="09:15 AM",  
                Add ="primary",
                Tags = new List<TagItem>
                {
                    new TagItem { Tag = "Framework",TagColor="bg-primary-transparent"},
                    new TagItem { Tag = "Angular",TagColor="bg-secondary-transparent"},
                    new TagItem { Tag = "Php",TagColor="bg-info-transparent"},
                },
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                },
            },
            new TasksList {
                Title ="Meeting Hour",
                Duedate ="10:15 AM",  
                Add ="primary1",
                Tags = new List<TagItem>
                {
                    new TagItem { Tag = "Framework",TagColor="bg-primary-transparent"},
                    new TagItem { Tag = "Angular",TagColor="bg-secondary-transparent"},
                    new TagItem { Tag = "Php",TagColor="bg-info-transparent"},
                    new TagItem { Tag = "Html",TagColor="bg-danger-transparent"},
                    new TagItem { Tag = "Laravel",TagColor="bg-success-transparent"},
                },
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                },
            },
            new TasksList {
                Title ="Projects Work Progress",
                Duedate ="04:30 AM",  
                Add ="primary2",
                Tags = new List<TagItem>
                {
                    new TagItem { Tag = "Php",TagColor="bg-info-transparent"},
                    new TagItem { Tag = "Html",TagColor="bg-danger-transparent"},
                    new TagItem { Tag = "Framework",TagColor="bg-primary-transparent"},
                },
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                },
            },
            new TasksList {
                Title ="Status Updation by Team Leads",
                Duedate ="05:45 PM",  
                Add ="primary3",
                Tags = new List<TagItem>
                {
                    new TagItem { Tag = "Framework",TagColor="bg-primary-transparent"},
                    new TagItem { Tag = "Angular",TagColor="bg-secondary-transparent"},
                    new TagItem { Tag = "Php",TagColor="bg-info-transparent"},
                },
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/8.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/2.jpg"},
                },
            },
        };        
        public List<TasksList> GetTasksListData() => TasksListData;
    }
}
