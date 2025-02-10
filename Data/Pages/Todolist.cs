using CardModel;
namespace TodoData
{
    public class TodoList
    {   
        public decimal Id { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public string? Priority { get; set; }
        public string? DueDate { get; set; }
        public string? AssignerImg { get; set; }
        public string? Assigner { get; set; }
        public string? Value { get; set; }
        public string? ProgressColor { get; set; }
        public bool Selected { get; set; }
    }
    public class TodoService {
        public TableText[] TodoHeaders = new TableText[]
        {
            new TableText { Title = "" },
            new TableText { Title = "Task Title" },
            new TableText { Title = "Status" },
            new TableText { Title = "Dead Line" },
            new TableText { Title = "Priority" },
            new TableText { Title = "Assigner" },
            new TableText { Title = "Progress" },
            new TableText { Title = "Action" },
        };        
        public TableText[] GetTodoHeadersData() => TodoHeaders;
        private List<TodoList> TodoLists = new List<TodoList>()
        {
            new TodoList { 
                Id=1,
                Title = "Software Development Tasks", 
                Status = "In Progress",  
                Priority = "Medium",
                DueDate = "15-Jan-2024", 
                AssignerImg = "../assets/images/faces/7.jpg", 
                Assigner = "Mehtha", 
                Value = "32", 
                ProgressColor = "primary", 
            },
            new TodoList { 
                Id=2,
                Title = "Bug Fixes and Issue Tracking", 
                Status = "Not Started",
                Priority = "High",
                DueDate = "16-Jan-2024",
                AssignerImg = "../assets/images/faces/12.jpg", 
                Assigner = "Ranjeeth", 
                Value = "80", 
                ProgressColor = "secondary", 
                Selected = true,
            },
            new TodoList {      
                Id=3,       
                Title = "IT Infrastructure Upgrades", 
                Status = "Not Started",   
                Priority = "Low",
                DueDate = "18-Feb-2024",
                AssignerImg = "../assets/images/faces/8.jpg", 
                Assigner = "Vency", 
                Value = "90", 
                ProgressColor = "orange", 
            },
            new TodoList {   
                Id=4,       
                Title = "Network Configuration", 
                Status = "Pending", 
                Priority = "Medium",    
                DueDate = "19-Feb-2024" ,
                AssignerImg = "../assets/images/faces/15.jpg", 
                Assigner = "Cimen Sobs", 
                Value = "69", 
                ProgressColor = "info", 
                Selected = true,
            },
            new TodoList {   
                Id=5,       
                Title = "Backup and Recovery Report", 
                Status = "Not Started",
                Priority = "High",
                DueDate = "21-Feb-2024" ,
                AssignerImg = "../assets/images/faces/14.jpg", 
                Assigner = "Dhruv Dany", 
                Value = "96", 
                ProgressColor = "warning", 
                Selected = true,
            },
            new TodoList {      
                Id=6,       
                Title = "User Account Management", 
                Status = "In Progress",  
                Priority = "Low",   
                DueDate = "24-Feb-2024",
                AssignerImg = "../assets/images/faces/11.jpg", 
                Assigner = "Rony Parker", 
                Value = "88", 
                ProgressColor = "danger", 
            },
            new TodoList {    
                Id=7,                       
                Title = "Deployment Schedule", 
                Status = "Not Started", 
                Priority = "High",    
                DueDate = "27-Feb-2024",
                AssignerImg = "../assets/images/faces/4.jpg", 
                Assigner = "Manjitha", 
                Value = "36", 
                ProgressColor = "teal", 
                Selected = true,
            },
            new TodoList {   
                Id=8,       
                Title = "Database Management", 
                Status = "Not Started",  
                Priority = "Medium",   
                DueDate = "03-Mar-2024",
                AssignerImg = "../assets/images/faces/3.jpg", 
                Assigner = "Killies", 
                Value = "57", 
                ProgressColor = "pink", 
            },
            new TodoList {       
                Id=9,              
                Title = "Monitoring And Alert", 
                Status = "Not Started", 
                Priority = "Low", 
                DueDate = "05-Mar-2024",
                AssignerImg = "../assets/images/faces/13.jpg", 
                Assigner = "Tom Cruz", 
                Value = "79", 
                ProgressColor = "dark", 
            },
            new TodoList {   
                Id=10,       
                Title = "Server Maintenance", 
                Status = "Completed",
                Priority = "Low",   
                DueDate = "17-Jan-2024",
                AssignerImg = "../assets/images/faces/13.jpg", 
                Assigner = "Palam Nath", 
                Value = "58", 
                ProgressColor = "success",
            },
        };
        public List<TodoList> GetTodoLists() => TodoLists;
    }
}