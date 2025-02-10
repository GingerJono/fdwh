
namespace DropdownData
{
    public class DropdownElements {
        public string? DropdownClass { get; set; } 
        public string? DropdownText { get; set; }
    };
    
    
    public class DropdownsService {
        private List<DropdownElements> Dropdown1Data = new List<DropdownElements>()
        { 
            new DropdownElements { DropdownClass = "btn-primary",DropdownText="Primary"},
            new DropdownElements { DropdownClass = "btn-primary1",DropdownText="Primary"},
            new DropdownElements { DropdownClass = "btn-primary2",DropdownText="Primary"},
            new DropdownElements { DropdownClass = "btn-primary3",DropdownText="Primary"},
            new DropdownElements { DropdownClass = "btn-secondary",DropdownText="Secondary"},
            new DropdownElements { DropdownClass = "btn-success",DropdownText="Success"},
            new DropdownElements { DropdownClass = "btn-info",DropdownText="Info"},
            new DropdownElements { DropdownClass = "btn-warning",DropdownText="Warning"},
            new DropdownElements { DropdownClass = "btn-danger",DropdownText="Danger"},
        };
        public List<DropdownElements> GetDropdown1()
        {
            return Dropdown1Data;
        } 

    }
}