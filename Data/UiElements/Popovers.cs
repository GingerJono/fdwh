
namespace PopoversData
{
    public class PopoversElements {
        public string? PopoverClass { get; set; }
        public string? PopoverTitle { get; set; }
        public string? PopoverText { get; set; }
        public string? PopoverPlacement { get; set; }
        public string? PopoverContent { get; set; }
        public string? PopoverCustomClass { get; set; }
    };
    
    public class PopoversService {
        public List<PopoversElements> GetPopovers1()
        {
            return new List<PopoversElements>
            {
                new PopoversElements { PopoverClass = "btn-primary",PopoverPlacement="top",PopoverTitle="Color",PopoverCustomClass="primary",PopoverContent="Popover with primary",PopoverText="Primary"},
                new PopoversElements { PopoverClass = "btn-primary1",PopoverPlacement="bottom",PopoverTitle="Color",PopoverCustomClass="primary1",PopoverContent="Popover with primary1",PopoverText="Primary1"},
                new PopoversElements { PopoverClass = "btn-primary2",PopoverPlacement="right",PopoverTitle="Color",PopoverCustomClass="primary2",PopoverContent="Popover with primary2",PopoverText="Primary2"},
                new PopoversElements { PopoverClass = "btn-primary3",PopoverPlacement="top",PopoverTitle="Color",PopoverCustomClass="primary3",PopoverContent="Popover with primary3",PopoverText="Primary3"},
                new PopoversElements { PopoverClass = "btn-secondary",PopoverPlacement="right",PopoverTitle="Color",PopoverCustomClass="secondary",PopoverContent="Popover with secondary",PopoverText="Secondary"},
                new PopoversElements { PopoverClass = "btn-info",PopoverPlacement="bottom",PopoverTitle="Color",PopoverCustomClass="info",PopoverContent="Popover with info",PopoverText="Info"},
                new PopoversElements { PopoverClass = "btn-warning",PopoverPlacement="left",PopoverTitle="Color",PopoverCustomClass="warning",PopoverContent="Popover with warning",PopoverText="Warning"},
                new PopoversElements { PopoverClass = "btn-success",PopoverPlacement="top",PopoverTitle="Color",PopoverCustomClass="success",PopoverContent="Popover with success",PopoverText="Success"},
                new PopoversElements { PopoverClass = "btn-danger",PopoverPlacement="top",PopoverTitle="Color",PopoverCustomClass="danger",PopoverContent="Popover with danger",PopoverText="Danger"},
                new PopoversElements { PopoverClass = "btn-teal",PopoverPlacement="bottom",PopoverTitle="Color",PopoverCustomClass="teal",PopoverContent="Popover with teal",PopoverText="Teal"},
                new PopoversElements { PopoverClass = "btn-purple",PopoverPlacement="top",PopoverTitle="Color",PopoverCustomClass="purple",PopoverContent="Popover with purple",PopoverText="Purple"},
            };
        }

    }
}