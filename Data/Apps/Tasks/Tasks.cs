
using CardModel;
namespace TasksData
{
    public class TaskCategory
    {
        public string? TaskTitle { get; set; }
        public string? TaskTitleClass { get; set; }
        public string? TaskTitlebg { get; set; }
        public string?  Badge { get; set; }
        public List<TaskItem>? TaskCard { get; set; }
    }

    public class TaskItem
    {
        public string? Id { get; set; }
        public List<TaskBadges>? TaskBadges { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Priority { get; set; }
        public string? Status { get; set; }
        public List<TeamList>? TeamList { get; set; }
        public string? Likes { get; set; }
        public string? Comments { get; set; }
    }

    public class TaskBadges
    {
        public string? Badge { get; set; }
        public string? BadgeClass { get; set; }
    }
    public class TeamList
    {
        public string? Img { get; set; }
    }
    public class TaskList
    {
        public string? TaskName { get; set; }
        public string? TaskListId { get; set; }
        public string? AssignedDate { get; set; }
        public string? Status { get; set; }
        public string? Statusupdate { get; set; }
        public string? Priority { get; set; }
        public string? DueDate { get; set; }
        public List<TeamList>? TeamList { get; set; }
        public bool Selected { get; set; }
    }
    
    public class AttachmentsList
    {
        public decimal ProjectId { get; set; }
        public string? Project { get; set; }
        public string? ProjectTitle { get; set; }
        public string? Status { get; set; }
    }
    public class TasksService {
        private List<TaskCategory> TasksList = new List<TaskCategory>
        {
            new TaskCategory {
                TaskTitle = "New",
                TaskTitleClass = "new",
                TaskTitlebg ="bg-primary",
                Badge = "18",
                TaskCard = new List<TaskItem>
                {
                    new TaskItem
                    {
                        Id = "#SHG - 01",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 01", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-info-transparent" }
                        },
                        Title = "Update Website Content",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "High",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/1.jpg"},
                            new TeamList {Img = "../assets/images/faces/2.jpg"},
                            new TeamList {Img = "../assets/images/faces/3.jpg"},
                            new TeamList {Img = "../assets/images/faces/4.jpg"},
                        },
                        Likes = "11",
                        Comments = "02"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 02",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 02", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-info-transparent" }
                        },
                        Title = "Implement new feature for Karban app",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Low",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/1.jpg"},
                            new TeamList {Img = "../assets/images/faces/2.jpg"},
                            new TeamList {Img = "../assets/images/faces/3.jpg"},
                            new TeamList {Img = "../assets/images/faces/4.jpg"},
                        },
                        Likes = "15",
                        Comments = "03"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 03",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 03", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-primary3-transparent" },
                            new TaskBadges { Badge = "UI/UX", BadgeClass = "bg-primary2-transparent" }
                        },
                        Title = "Develop new feature for Karban app",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Low",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/5.jpg"},
                            new TeamList {Img = "../assets/images/faces/9.jpg"},
                        },
                        Likes = "25",
                        Comments = "05"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 04",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 04", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-info-transparent" },
                            new TaskBadges { Badge = "Designing", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "Design multi-usage landing page.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Low",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/5.jpg"},
                            new TeamList {Img = "../assets/images/faces/9.jpg"},
                        },
                        Likes = "25",
                        Comments = "05"
                    }
                }
            },
            new TaskCategory {
                TaskTitle = "TODO",
                TaskTitleClass = "todo",
                TaskTitlebg ="bg-primary1",
                Badge = "12",
                TaskCard = new List<TaskItem>
                {
                    new TaskItem
                    {
                        Id = "#SHG - 05",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 05", BadgeClass = "bg-info-transparent" },
                            new TaskBadges { Badge = "Authentication", BadgeClass = "bg-primary2-transparent" }
                        },
                        Title = "Adding Authentication Pages.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Low",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/4.jpg"},
                            new TeamList {Img = "../assets/images/faces/13.jpg"},
                            new TeamList {Img = "../assets/images/faces/5.jpg"},
                        },
                        Likes = "08",
                        Comments = "04"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 06",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 06", BadgeClass = "bg-info-transparent" },
                            new TaskBadges { Badge = "Marketing", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "New Marketing Campaign Strategy",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "High",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/4.jpg"},
                            new TeamList {Img = "../assets/images/faces/13.jpg"},
                            new TeamList {Img = "../assets/images/faces/5.jpg"},
                        },
                        Likes = "23",
                        Comments = "12"
                    },
                }
            },
            new TaskCategory {
                TaskTitle = "ON GOING",
                TaskTitleClass = "in-progress",
                TaskTitlebg ="bg-primary2",
                Badge = "26",
                TaskCard = new List<TaskItem>
                {
                    new TaskItem
                    {
                        Id = "#SHG - 07",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 07", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "UI Design", BadgeClass = "bg-primary-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "Developing Calendar & Mail pages.",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Medium",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/7.jpg"},
                            new TeamList {Img = "../assets/images/faces/10.jpg"},
                            new TeamList {Img = "../assets/images/faces/11.jpg"},
                        },
                        Likes = "10",
                        Comments = "18"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 08",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 08", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Design", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "Project Design in Figma and Sketch",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Medium",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/13.jpg"},
                            new TeamList {Img = "../assets/images/faces/6.jpg"},
                        },
                        Likes = "05",
                        Comments = "02"
                    },
                }
            },
            new TaskCategory {
                TaskTitle = "IN REVIEW",
                TaskTitleClass = "inreview",
                TaskTitlebg ="bg-primary3",
                Badge = "30",
                TaskCard = new List<TaskItem>
                {
                    new TaskItem
                    {
                        Id = "#SHG - 10",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 10", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Review", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "Design Architecture Strategy",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "Medium",
                        Status = "In Progress",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/3.jpg"},
                            new TeamList {Img = "../assets/images/faces/5.jpg"},
                            new TeamList {Img = "../assets/images/faces/7.jpg"},
                        },
                        Likes = "09",
                        Comments = "35"
                    },
                }
            },            
            new TaskCategory {
                TaskTitle = "COMPLETED",
                TaskTitleClass = "completed",
                TaskTitlebg ="bg-secondary",
                Badge = "36",
                TaskCard = new List<TaskItem>
                {
                    new TaskItem
                    {
                        Id = "#SHG - 11",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 11", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Review", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "New Project Update",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "High",
                        Status = "Completed",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/6.jpg"},
                            new TeamList {Img = "../assets/images/faces/13.jpg"},
                        },
                        Likes = "09",
                        Comments = "35"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 12",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 12", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Development", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "React JS New Version Update",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "High",
                        Status = "Completed",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/10.jpg"},
                            new TeamList {Img = "../assets/images/faces/11.jpg"},
                            new TeamList {Img = "../assets/images/faces/1.jpg"},
                        },
                        Likes = "22",
                        Comments = "12"
                    },
                    new TaskItem
                    {
                        Id = "#SHG - 13",
                        TaskBadges = new List<TaskBadges>
                        {
                            new TaskBadges { Badge = "#SHG - 13", BadgeClass = "bg-primary1-transparent" },
                            new TaskBadges { Badge = "Discussion", BadgeClass = "bg-primary3-transparent" }
                        },
                        Title = "Project Discussion with Client",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                        Priority = "High",
                        Status = "Completed",
                        TeamList = new List<TeamList>
                        {
                            new TeamList {Img = "../assets/images/faces/4.jpg"},
                        },
                        Likes = "11",
                        Comments = "12"
                    },
                }
            }
        };
        public List<TaskCategory> GetTasksList() => TasksList;
        
        private List<MainCard> TaskCardData = new List<MainCard>()
        {
            new MainCard {
                id = 1,
                title = "New Tasks",
                icon = "ri-task-line",
                iconclass ="bg-primary",
                price = "45,478" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="2.56%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 2,
                title = "Completed Tasks",
                icon = "ri-check-line",
                iconclass ="bg-primary1",
                price = "2,345" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="3.05%",
                statusicon ="ti ti-arrow-narrow-down",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 3,
                title = "Pending Tasks",
                icon = "ri-time-line",
                iconclass ="bg-primary2",
                price = "1245" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="2.16%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 4,
                title = "Inprogress Tasks",
                icon = "ri-loader-line",
                iconclass ="bg-primary3",
                price = "658" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="2.1%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
        };

        public List<MainCard> GetTaskCardData() => TaskCardData;

        public TableText[] TasksTableHeaders = new TableText[]
        {
            new TableText { Title = "Task" },
            new TableText { Title = "Task ID" },
            new TableText { Title = "Assigned Date" },
            new TableText { Title = "Status" },
            new TableText { Title = "Due Date" },
            new TableText { Title = "Priority" },
            new TableText { Title = "Assigned To" },
            new TableText { Title = "Action" },
            new TableText { Title = "Status Update" },
        };
        public TableText[] GetTasksHeadersData() => TasksTableHeaders;
        private List<TaskList> TaskLists = new List<TaskList>()
        {
            new TaskList { 
                TaskName = "Design New Landing Page", 
                TaskListId = "SPK - 01", 
                AssignedDate = "02-06-2024", 
                Status = "New",       
                Priority = "Medium",
                DueDate = "10-06-2024", 
                Statusupdate = "In Review", 
                TeamList = new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                    new TeamList { Img = "../assets/images/faces/3.jpg"},
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                }
            },
            new TaskList { 
                TaskName = "New Project Blueprint",
                TaskListId = "SPK - 04", 
                AssignedDate = "05-06-2024", 
                Status = "Inprogress",
                Priority = "High",
                DueDate = "15-06-2024",
                Statusupdate = "On Hold", 
                Selected=true,
                TeamList = new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/11.jpg"},
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                    new TeamList { Img = "../assets/images/faces/9.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/7.jpg"},
                }
            },
            new TaskList { 
                TaskName = "Server Side Validation",             
                TaskListId = "SPK - 11", 
                AssignedDate = "12-06-2024", 
                Status = "Pending",   
                Priority = "Low",    
                DueDate = "16-06-2024",
                Statusupdate = "In Review", 
                TeamList = new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/5.jpg"},
                    new TeamList { Img = "../assets/images/faces/9.jpg"},
                    new TeamList { Img = "../assets/images/faces/13.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/11.jpg"},
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                    new TeamList { Img = "../assets/images/faces/9.jpg"},
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                }
            },
            new TaskList { 
                TaskName = "New Project Blueprint",
                TaskListId = "SPK - 04", 
                AssignedDate = "05-06-2024", 
                Status = "Inprogress", 
                Priority = "High",    
                DueDate = "15-06-2024" ,
                Statusupdate = "In Review", 
                Selected=true,
                TeamList = new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/11.jpg"},
                    new TeamList { Img = "../assets/images/faces/5.jpg"},
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                    new TeamList { Img = "../assets/images/faces/1.jpg"},
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                }
            },
            new TaskList { 
                TaskName = "Server Side Validation",  
                TaskListId = "SPK - 11", 
                AssignedDate = "12-06-2024", 
                Status = "Pending",
                Priority = "Low",
                DueDate = "16-06-2024" ,
                Statusupdate = "In Review", 
                TeamList = new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/5.jpg"},
                    new TeamList { Img = "../assets/images/faces/9.jpg"},
                    new TeamList { Img = "../assets/images/faces/13.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                }
            },
            new TaskList { 
                TaskName = "New Plugin Development",     
                TaskListId = "SPK - 24", 
                AssignedDate = "08-06-2024", 
                Status = "Completed",  
                Priority = "Low",   
                DueDate = "17-06-2024",
                Statusupdate = "On Hold",  
                Selected=true,
                TeamList =new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                } 
            },
            new TaskList { 
                TaskName = "Designing New Authentication Page",                    
                TaskListId = "SPK - 16", 
                AssignedDate = "03-06-2024", 
                Status = "Inprogress", 
                Priority = "Medium",    
                DueDate = "08-06-2024",
                Statusupdate = "In Review", 
                TeamList =new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                    new TeamList { Img = "../assets/images/faces/15.jpg"},
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                } 
            },
            new TaskList { 
                TaskName = "New Plugin Development",   
                TaskListId = "SPK - 24", 
                AssignedDate = "08-06-2024", 
                Status = "Completed",   
                Priority = "Low",   
                DueDate = "17-06-2024",
                Statusupdate = "In Review", 
                TeamList =new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                    new TeamList { Img = "../assets/images/faces/8.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                } 
            },
            new TaskList { 
                TaskName = "Designing New Authentication Page",             
                TaskListId = "SPK - 16", 
                AssignedDate = "03-06-2024", 
                Status = "Inprogress", 
                Priority = "Medium", 
                DueDate = "08-06-2024",
                Statusupdate = "In Review", 
                TeamList =new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/10.jpg"},
                    new TeamList { Img = "../assets/images/faces/15.jpg"},
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                    new TeamList { Img = "../assets/images/faces/3.jpg"},
                    new TeamList { Img = "../assets/images/faces/2.jpg"},
                }
            },
            new TaskList { 
                TaskName = "Documentation For New Template", 
                TaskListId = "SPK - 07", 
                AssignedDate = "12-06-2024", 
                Status = "New",
                Priority = "High",   
                DueDate = "25-06-2024",
                Statusupdate = "On Hold", 
                TeamList =new List<TeamList>
                {
                    new TeamList { Img = "../assets/images/faces/12.jpg"},
                } 
            },
        };

        public List<TaskList> GetTaskLists() => TaskLists;
        
        private List<AttachmentsList> AttachmentsListData = new List<AttachmentsList>()
        {
            new AttachmentsList {ProjectId =1,Project="../assets/images/media/file-manager/1.png",ProjectTitle ="Full Project",Status ="0.45MB"},
            new AttachmentsList {ProjectId =2,Project="../assets/images/media/file-manager/3.png",ProjectTitle ="assets.zip",Status ="0.99MB"},
            new AttachmentsList {ProjectId =3,Project="../assets/images/media/file-manager/1.png",ProjectTitle ="image-1.png",Status ="245KB"},
            new AttachmentsList {ProjectId =4,Project="../assets/images/media/file-manager/3.png",ProjectTitle ="documentation.zip",Status ="2MB"},
            new AttachmentsList {ProjectId =5,Project="../assets/images/media/file-manager/3.png",ProjectTitle ="landing.zip",Status ="3.46MB"},
        };
        public List<AttachmentsList> GetAttachmentsListData() => AttachmentsListData;
        private List<Activity> ActivityData = new List<Activity>()
        {
            new Activity {Id=1,Img="../assets/images/faces/7.jpg",Title="<span class='text-default'><span class='fw-medium'>Oliver</span> shared a document with<span class='fw-medium'>you</span>.</span>",Desc="'We've finalized the project specifications and the client has approved the initial designs. Moving forward with the development phase.",Duration="14, June 2024 - 10:45",Media = new List<Media>{new Media { Img = "../assets/images/media/file-manager/3.png",Desc="512.34KB"},},},
            new Activity {Id=2,Avatarcolor="bg-primary2",Value="S",Title="<span class='text-default'><span class='fw-medium'>You</span> shared a post with 6 people, including<span class='fw-medium'>Ava, Sophia, Mia, Lucas</span>.</span>",Duration="10, June 2024 - 14:23",Media = new List<Media>{new Media { Img = "../assets/images/media/media-19.jpg",},},
                AssignedTo = new List<Team>{
                    new Team { Img = "../assets/images/faces/3.jpg",},
                    new Team { Img = "../assets/images/faces/9.jpg",},
                    new Team { Img = "../assets/images/faces/12.jpg",},
                    new Team { Img = "../assets/images/faces/14.jpg",},
                }
            },
            new Activity {Id=3,Img="../assets/images/faces/7.jpg",Title="<span class='text-default'><span class='fw-medium'>Liam</span> commented on your post.</span>",Duration="12, June 2024 - 09:15", Desc="'The updates to the project plan look great. I'll review the milestones and get back to you by end of day.'"},
        };
        public List<Activity> GetActivityData() => ActivityData;

    }
}