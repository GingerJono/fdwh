using CardModel;

namespace Projects
{
    public class ProjectsChart : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
      public class ProjectStatistics {
        public string? Statistics { get; set; }
        public decimal Projects { get; set; }
        public decimal Revenue { get; set; }
    } ;
     public class MonthlyTargets  {
        public string? Targets { get; set; }
        public decimal TargetsValue { get; set; }
    } 
    public class Summary {
        public string? Week { get; set; }
        public decimal ThisWeekValue { get; set; }
        public decimal LastWeekValue { get; set; }
    } ;

    public class TeamList {
        public string? MemberImg { get; set;}
        public string? Member { get; set;}
        public string? Design { get; set;}
        public string? Works { get; set;}
        public bool ISOnline { get; set;}
        public string? TasksTotal { get; set;}
        public string? TasksCompleted { get; set;}
        
    }
    public class ProjectsList {
        public decimal Id { get; set;}       
        public string? Title { get; set;}
        public string? TasksTotal { get; set;}
        public string? TasksCompleted { get; set;}
        public string? Progress { get; set;}
        public List<AssignedToItem>? AssignedTo { get; set; }
        public string? Status { get; set;}
        public string? Statusclass { get; set;}
        public string? Duedate { get; set;}
    }
    public class TasksList { 
        public string? Duedate { get; set;}
        public string? Title { get; set;}        
        public string? Add { get; set;}
        public List<TagItem>? Tags { get; set; }
        public List<AssignedToItem>? AssignedTo { get; set; }
    }
    public class TagItem
    {
        public string? Tag { get; set; }
        public string? TagColor { get; set; }    
    }
    public class AssignedToItem
    {
        public string? Img { get; set; }
    }
}

