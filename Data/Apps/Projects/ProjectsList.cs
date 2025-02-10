
using CardModel;
namespace ProjectData
{
    public class ProjectList
    {
        public decimal ProjectId { get; set; }
        public string? Project { get; set; }
        public string? ProjectTitle { get; set; }
        public string? TotalTasks { get; set; }
        public string? CompletedTasks { get; set; }
        public string? Description { get; set; }
        public List<AssignedToItem>? AssignedTo { get; set; }
        public string? Assigned { get; set; }
        public string? Due { get; set; }
        public string? Status { get; set; }
       public string? Priority { get; set; }
        public bool Selected { get; set; }
    }
    public class AssignedToItem
    {
        public string? Img { get; set; }
        public string? Title { get; set; }
    }
    public class Tags
    {
        public string? Tag { get; set; }
    }
    public class ProjectService {
        private List<ProjectList> ProjectListData = new List<ProjectList>()
        {
            new ProjectList {  ProjectId =1,Project ="../assets/images/company-logos/1.png",ProjectTitle ="Development of Enhanced Analytics Platform",TotalTasks ="22",CompletedTasks ="18",Description ="Build an advanced analytics dashboard integrating real-time data from multiple sources.",Assigned="15,Jun 2024",Due ="30,Aug 2024",Status ="65",Priority ="Medium",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/7.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                },
            },
            new ProjectList {  ProjectId =2,Project ="../assets/images/company-logos/3.png",ProjectTitle ="E-commerce Platform Optimization",TotalTasks ="20",CompletedTasks ="10",Description ="Enhance performance and user experience for a high-traffic e-commerce platform.",Assigned="02, Jul 2024",Due ="15, Sep 2024",Status ="45",Priority ="High",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/4.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/6.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/9.jpg"},
                },
            },
            new ProjectList {  ProjectId =3,Project ="../assets/images/company-logos/7.png",ProjectTitle ="Data Migration to Cloud",TotalTasks ="8",CompletedTasks ="5",Description ="Transfer legacy data systems to cloud infrastructure for scalability and accessibility.",Assigned="15, Oct 2024",Due ="30, Dec 2024",Status ="62",Priority ="Low",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/1.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/21.jpg"},
                },
            },
            new ProjectList {  ProjectId =4,Project ="../assets/images/company-logos/8.png",ProjectTitle ="Cybersecurity Audit and Enhancements",TotalTasks ="6",CompletedTasks ="2",Description ="Conduct a comprehensive audit and implement security measures to protect data and systems.",Assigned="01, Nov 2024",Due ="15, Jan 2025",Status ="40",Priority ="High",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                },
            },
            new ProjectList {  ProjectId =5,Project ="../assets/images/company-logos/6.png",ProjectTitle ="AI-Powered Customer Support System",TotalTasks ="10",CompletedTasks ="3",Description ="Implement a machine learning-driven system to automate customer support inquiries.",Assigned="05,Sep 2024",Due ="25,Nov 2024",Status ="30",Priority ="Medium",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/5.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/12.jpg"},
                },
            },
            new ProjectList {  ProjectId =6,Project ="../assets/images/company-logos/4.png",ProjectTitle ="Mobile App Launch",TotalTasks ="15",CompletedTasks ="5",Description ="Develop and release a new mobile application for iOS and Android platforms.",Assigned="10,Aug 2024",Due ="30,Oct 2024",Status ="35",Priority ="Medium",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/13.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/14.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/15.jpg"},
                },
            },
            new ProjectList {  ProjectId =7,Project ="../assets/images/company-logos/5.png",ProjectTitle ="IT Infrastructure Upgrade",TotalTasks ="12",CompletedTasks ="2",Description ="Modernize network and server infrastructure to improve reliability and security.",Assigned="20,Jul 2024",Due ="30,Oct 2024",Status ="15",Priority ="Low",
                AssignedTo = new List<AssignedToItem>
                {
                    new AssignedToItem { Img = "../assets/images/faces/16.jpg"},
                    new AssignedToItem { Img = "../assets/images/faces/11.jpg"},
                },
            },
        };
        public List<ProjectList> GetProjectList() => ProjectListData;
        public TableText[] ProjectTableHeaders = new TableText[]
        {
            new TableText { Title = "Project Name" },
            new TableText { Title = "Description" },
            new TableText { Title = "Team" },
            new TableText { Title = "Assigned Date" },
            new TableText { Title = "Due Date" },
            new TableText { Title = "Status" },
            new TableText { Title = "Priority" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetProjectHeadersData() => ProjectTableHeaders;
        private List<AssignedToItem> TeamData = new List<AssignedToItem>()
        {
            new AssignedToItem { Img="../assets/images/faces/1.jpg"},
            new AssignedToItem {Img= "../assets/images/faces/2.jpg"},
            new AssignedToItem { Img="../assets/images/faces/8.jpg"},
            new AssignedToItem { Img="../assets/images/faces/12.jpg"},
            new AssignedToItem { Img="../assets/images/faces/10.jpg"},
            new AssignedToItem { Img="../assets/images/faces/4.jpg"},
            new AssignedToItem { Img="../assets/images/faces/5.jpg"},
            new AssignedToItem { Img="../assets/images/faces/13.jpg"},
        };
        public List<AssignedToItem> GetTeam() => TeamData;
        private List<Tags> TagsData = new List<Tags>()
        {
            new Tags {Tag="UI/UX Design"},
            new Tags {Tag="Data Integration"},
            new Tags {Tag="Data Visualization"},
            new Tags {Tag="Front-End Development"},
            new Tags {Tag="Authentication Systems"},
            new Tags {Tag="Usability Testing"},
            new Tags {Tag="Agile Methodology"},
            new Tags {Tag="API Development"},
        };
        public List<Tags> GetTagsData() => TagsData;
        private List<AssignedToItem> AssignedData = new List<AssignedToItem>()
        {
            new AssignedToItem {Img="../assets/images/faces/2.jpg",Title="John"},
            new AssignedToItem {Img= "../assets/images/faces/8.jpg",Title="Emily"},
            new AssignedToItem {Img="../assets/images/faces/5.jpg",Title="Liam"},
            new AssignedToItem {Img="../assets/images/faces/10.jpg",Title="Sophia"},
            new AssignedToItem {Img="../assets/images/faces/15.jpg",Title="Charlotte"},
        };
        public List<AssignedToItem> GetAssigned() => AssignedData;
        public TableText[] TodoTableHeaders = new TableText[]
        {
            new TableText { Title = "" },
            new TableText { Title = "Task Title" },
            new TableText { Title = "Status" },
            new TableText { Title = "End Date" },
            new TableText { Title = "Action" },
        };
        public TableText[] GetTodoHeadersData() => TodoTableHeaders;
        private List<ProjectList> TodoData = new List<ProjectList>()
        {
            new ProjectList {ProjectId =1,ProjectTitle ="Implement responsive design",Due ="17-Jan-2024",Status ="Not Started",Selected = true,},
            new ProjectList {ProjectId =2,ProjectTitle ="Fix login authentication issue",Due ="17-Jan-2024",Status ="Completed",Selected = false,},
            new ProjectList {ProjectId =3,ProjectTitle ="Optimize database queries",Due ="18-Feb-2024",Status ="Not Started",Selected = false,},
            new ProjectList {ProjectId =4,ProjectTitle ="Integrate third-party API",Due ="19-Feb-2024",Status ="Pending",Selected = true,},
            new ProjectList {ProjectId =5,ProjectTitle ="Create user documentation",Due ="21-Feb-2024",Status ="Not Started",Selected = true,},
            new ProjectList {ProjectId =6,ProjectTitle ="Deploy to staging environment",Due ="24-Feb-2024",Status ="In Progress",Selected = false,},
            new ProjectList {ProjectId =7,ProjectTitle ="Conduct security audit",Due ="27-Feb-2024",Status ="Not Started",Selected = true,},
        };
        public List<ProjectList> GetTodoData() => TodoData;
        private List<Activity> ActivityData = new List<Activity>()
        {
            new Activity {Id=1,Avatarcolor="bg-primary",Value="A",Title="<span class='fw-medium'>Project Kick-off Meeting</span>",Duration="15,Jun 2024 - 06:20", Desc="Discuss project scope, objectives, and timelines."},
            new Activity {Id=2,Avatarcolor="bg-primary2",Value="B",Title="<span class='fw-medium'>Project Details Page Planning</span>",Duration="20, Jun 2024 - 09:00", Desc="Define feature requirements and layout for the project details page."},
            new Activity {Id=3,Img="../assets/images/faces/12.jpg",Title="<span class='text-default'><b>Brenda Adams</b> shared a document with <b>you</b></span>",Duration="18,Jun 2024 - 09:15",Media = new List<Media>{new Media { Img = "../assets/images/media/file-manager/3.png",Desc="728.62KB"},},},
            new Activity {Id=4,Avatarcolor="bg-primary3",Value="J",Title="<span class='text-default'><b>You</b> shared a post with 4 people <b>John,Emma,Liam,Sophie</b></span>.",Duration="30,Jun 2024 - 13:20",Media = new List<Media>{new Media { Img = "../assets/images/media/media-21.jpg",},},
                AssignedTo = new List<Team>{
                    new Team { Img = "../assets/images/faces/3.jpg",},
                    new Team { Img = "../assets/images/faces/9.jpg",},
                    new Team { Img = "../assets/images/faces/6.jpg",},
                    new Team { Img = "../assets/images/faces/14.jpg",},
                }
            },
            new Activity {Id=5,Img="../assets/images/faces/7.jpg",Title="<span class='fw-medium'>Security and Compliance Audit</span>",Duration="27, Jun 2024 - 09:00", Desc="Define feature requirements and layout for the project details page."},
            new Activity {Id=6,Img="../assets/images/media/media-45.jpg",Title="<b>Lucas</b> Commented on Project <a class='text-secondary' href='javascript:void(0);'><u>#System Integration</u></a>.",Duration="25,Jun 2024 - 10:52", Desc="Integration progress looks good, keep it up! 👍",
                Media = new List<Media>{
                    new Media { Img = "../assets/images/media/media-28.jpg"},
                    new Media { Img = "../assets/images/media/media-30.jpg"},
                },
            },
        };
        public List<Activity> GetActivityData() => ActivityData;
        private List<ProjectList> DocumentsData = new List<ProjectList>()
        {
            new ProjectList {ProjectId =1,Project="../assets/images/media/file-manager/1.png",ProjectTitle ="Project Proposal.pdf",Status ="1.2MB"},
            new ProjectList {ProjectId =2,Project="../assets/images/media/file-manager/3.png",ProjectTitle ="Contracts.docx",Status ="1.5MB"},
            new ProjectList {ProjectId =3,Project="../assets/images/media/file-manager/1.png",ProjectTitle ="Meeting Notes.txt",Status ="256KB"},
            new ProjectList {ProjectId =4,Project="../assets/images/media/file-manager/3.png",ProjectTitle ="User Manual.pdf",Status ="1.8MB"},
        };
        public List<ProjectList> GetDocumentsData() => DocumentsData;

    }
}