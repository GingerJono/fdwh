
namespace TooltipData
{
    public class TooltipElements {
        public string? TooltipClass { get; set; }
        public string? TooltipTitle { get; set; }
        public string? TooltipText { get; set; }
        public string? TooltipPlacement { get; set; }
        public string? TooltipCustomClass { get; set; }
    };
    
    public class TooltipService {
        public List<TooltipElements> GetTooltip1()
        {
            return new List<TooltipElements>
            {
                new TooltipElements { TooltipClass = "btn-primary",TooltipPlacement="top",TooltipTitle="Primary Tooltip",TooltipCustomClass="tooltip-primary" ,TooltipText="Primary Tooltip"},
                new TooltipElements { TooltipClass = "btn-primary1",TooltipPlacement="bottom",TooltipTitle="Primary 1 Tooltip",TooltipCustomClass="tooltip-primary1" ,TooltipText="Primary1 Tooltip"},
                new TooltipElements { TooltipClass = "btn-primary2",TooltipPlacement="right",TooltipTitle="Primary 2 Tooltip",TooltipCustomClass="tooltip-primary2" ,TooltipText="Primary2 Tooltip"},
                new TooltipElements { TooltipClass = "btn-primary3",TooltipPlacement="top",TooltipTitle="Primary 3 Tooltip",TooltipCustomClass="tooltip-primary3" ,TooltipText="Primary3 Tooltip"},
                new TooltipElements { TooltipClass = "btn-secondary",TooltipPlacement="right",TooltipTitle="Secondary Tooltip",TooltipCustomClass="tooltip-secondary" ,TooltipText="Secondary Tooltip"},
                new TooltipElements { TooltipClass = "btn-warning",TooltipPlacement="bottom",TooltipTitle="Warning Tooltip",TooltipCustomClass="tooltip-warning" ,TooltipText="Warning Tooltip"},
                new TooltipElements { TooltipClass = "btn-info",TooltipPlacement="left",TooltipTitle="Info Tooltip",TooltipCustomClass="tooltip-info" ,TooltipText="Info Tooltip"},
                new TooltipElements { TooltipClass = "btn-success",TooltipPlacement="top",TooltipTitle="Success Tooltip",TooltipCustomClass="tooltip-success" ,TooltipText="Success Tooltip"},
                new TooltipElements { TooltipClass = "btn-danger",TooltipPlacement="bottom",TooltipTitle="Danger Tooltip",TooltipCustomClass="tooltip-danger" ,TooltipText="Danger Tooltip"},
                new TooltipElements { TooltipClass = "btn-light",TooltipPlacement="bottom",TooltipTitle="Light Tooltip",TooltipCustomClass="tooltip-light" ,TooltipText="Light Tooltip"},
                new TooltipElements { TooltipClass = "btn-dark",TooltipPlacement="bottom",TooltipTitle="Dark Tooltip",TooltipCustomClass="tooltip-dark" ,TooltipText="Dark Tooltip"},
            };
        }

    }
}