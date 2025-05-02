public class MenuDataServiceSandbox
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "Main"
        ),
        new MainMenuItems(
            type: "sub",
            title: "ORI",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='m2.25 12 8.954-8.955c.44-.439 1.152-.439 1.591 0L21.75 12M4.5 9.75v10.125c0 .621.504 1.125 1.125 1.125H9.75v-4.875c0-.621.504-1.125 1.125-1.125h2.25c.621 0 1.125.504 1.125 1.125V21h4.125c.621 0 1.125-.504 1.125-1.125V9.75M8.25 21h8.25' /></svg>",
            badgeValue: "",
            badgeClass: "",
            
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
			{
				new MainMenuItems (
					path: "ORIPolicies",
					type: "link",
					title: "ORI Policies",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "ORIUSMs",
					type: "link",
					title: "ORI USMs",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "EventMetadata",
					type: "link",
					title: "Event Metadata",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "NavHist",
					type: "link",
					title: "NavHist",
					selected: false,
					active: false,
					dirChange: false
				),
			}
        ),

        
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
