
namespace BadgeData
{
    public class BadgeElements {
        public string? ButtonClass { get; set; } 
        public string? BadgeClass { get; set; } 
        public string? BadgeText { get; set; }
        public bool IsRounded { get; set; }
    };
    
    public class BadgesService {
        private List<BadgeElements> Badge1Data = new List<BadgeElements>()
        { 
            new BadgeElements { BadgeClass = "bg-primary" , BadgeText = "Primary"},
            new BadgeElements { BadgeClass = "bg-primary1" , BadgeText = "Primary1"},
            new BadgeElements { BadgeClass = "bg-primary2" , BadgeText = "Primary2"},
            new BadgeElements { BadgeClass = "bg-primary3" , BadgeText = "Primary3"},
            new BadgeElements { BadgeClass = "bg-secondary" , BadgeText = "Secondary"},
            new BadgeElements { BadgeClass = "bg-success" , BadgeText = "Success"},
            new BadgeElements { BadgeClass = "bg-danger" , BadgeText = "Danger"},
            new BadgeElements { BadgeClass = "bg-warning" , BadgeText = "Warning"},
            new BadgeElements { BadgeClass = "bg-info" , BadgeText = "Info"},
            new BadgeElements { BadgeClass = "bg-light" , BadgeText = "Light"},
            new BadgeElements { BadgeClass = "bg-dark" , BadgeText = "Dark"},
            new BadgeElements { BadgeClass = "bg-orange" , BadgeText = "orange"},
            new BadgeElements { BadgeClass = "bg-purple" , BadgeText = "purple"},
        };
        public List<BadgeElements> GetBadge1()
        {
            return Badge1Data;
        } 
        private List<BadgeElements> Badge2Data = new List<BadgeElements>()
        { 
            new BadgeElements { BadgeClass = "bg-primary" , BadgeText = "Primary" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-primary1" , BadgeText = "Primary1" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-primary2" , BadgeText = "Primary2" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-primary3" , BadgeText = "Primary3" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-secondary" , BadgeText = "Secondary" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-success" , BadgeText = "Success" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-danger" , BadgeText = "Danger" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-warning" , BadgeText = "Warning" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-info" , BadgeText = "Info" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-light" , BadgeText = "Light" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-dark" , BadgeText = "Dark" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-orange" , BadgeText = "orange" ,IsRounded=true},
            new BadgeElements { BadgeClass = "bg-purple" , BadgeText = "purple" ,IsRounded=true},
        };
        public List<BadgeElements> GetBadge2()
        {
            return Badge2Data;
        }
        private List<BadgeElements> Badge3Data = new List<BadgeElements>()
        { 
            new BadgeElements { ButtonClass="btn-primary" ,BadgeClass = "bg-primary1" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-primary1" ,BadgeClass = "bg-primary" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-primary2" ,BadgeClass = "bg-warning" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-primary3" ,BadgeClass = "bg-primary1" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-secondary" ,BadgeClass = "bg-primary" , BadgeText = "7"},
            new BadgeElements { ButtonClass="btn-success" ,BadgeClass = "bg-danger" , BadgeText = "12"},
            new BadgeElements { ButtonClass="btn-info" ,BadgeClass = "bg-warning" , BadgeText = "32"},
        };
        public List<BadgeElements> GetBadge3()
        {
            return Badge3Data;
        }
        private List<BadgeElements> Badge4Data = new List<BadgeElements>()
        { 
            new BadgeElements { ButtonClass="btn-outline-primary" ,BadgeClass = "" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-outline-primary1" ,BadgeClass = "" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-outline-primary2" ,BadgeClass = "" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-outline-primary3" ,BadgeClass = "" , BadgeText = "4"},
            new BadgeElements { ButtonClass="btn-outline-secondary" ,BadgeClass = "" , BadgeText = "7"},
            new BadgeElements { ButtonClass="btn-outline-success" ,BadgeClass = "" , BadgeText = "12"},
            new BadgeElements { ButtonClass="btn-outline-info" ,BadgeClass = "" , BadgeText = "32"},
        };
        public List<BadgeElements> GetBadge4()
        {
            return Badge4Data;
        }
    }
}