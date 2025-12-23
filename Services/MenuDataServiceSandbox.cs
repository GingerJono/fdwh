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

			selected: true,
			active: true,
			dirChange: false,
			children: new MainMenuItems[]
			{
				new MainMenuItems (
					path: "ORIPolicies",
					type: "link",
					title: "Policies",

					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (

					path: "EventMetadata",
					type: "link",
					title: "Events",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "ORIUSMs",
					type: "link",
					title: "USMs",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "LORSList",
					type: "link",
					title: "LORS",
					selected: false,
					active: false,
					dirChange: false
				),
				//new MainMenuItems (
    //                path: "ORIUSMs",
				//	type: "link",
				//	title: "NavHist",
				//	selected: false,
				//	active: false,
				//	dirChange: false
				//),
			}

		),
		new MainMenuItems(
			type: "sub",
			title: "Prism",
			icon: "",
			svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='currentColor' viewBox='0 0 16 16'><path d='M7.938 2.016A.13.13 0 0 1 8.002 2a.13.13 0 0 1 .063.016.15.15 0 0 1 .054.057l6.857 11.667c.036.06.035.124.002.183a.2.2 0 0 1-.054.06.1.1 0 0 1-.066.017H1.146a.1.1 0 0 1-.066-.017.2.2 0 0 1-.054-.06.18.18 0 0 1 .002-.183L7.884 2.073a.15.15 0 0 1 .054-.057m1.044-.45a1.13 1.13 0 0 0-1.96 0L.165 13.233c-.457.778.091 1.767.98 1.767h13.713c.889 0 1.438-.99.98-1.767z'/></svg>",
			badgeValue: "",
			badgeClass: "",

			selected: false,
			active: false,
			dirChange: false,
			children: new MainMenuItems[]
			{
				new MainMenuItems (
					path: "PrismRuns",
					type: "link",
					title: "Run Manager",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "PrismAdjustments",
					type: "link",
					title: "Adjustments",
					selected: false,
					active: false,
					dirChange: false
				),
				}
			),
		new MainMenuItems(
			type: "sub",
			title: "Windowpane",
			icon: "",
			svg: "<svg xmlns=\"http://www.w3.org/2000/svg\" class=\"w-6 h-6 side-menu__icon\" fill=\"none\" stroke=\"currentColor\" stroke-width=\"1.2\" viewBox=\"0 0 24 24\">\r\n  <rect x=\"3\" y=\"3\" width=\"7\" height=\"7\" />\r\n  <rect x=\"14\" y=\"3\" width=\"7\" height=\"7\" />\r\n  <rect x=\"3\" y=\"14\" width=\"7\" height=\"7\" />\r\n  <rect x=\"14\" y=\"14\" width=\"7\" height=\"7\" />\r\n</svg>",
			badgeValue: "",
			badgeClass: "",

			selected: false,
			active: false,
			dirChange: false,
			children: new MainMenuItems[]
			{
				new MainMenuItems (
					path: "WindowpaneSearch",
					type: "link",
					title: "Search",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "MyAccounts",
					type: "link",
					title: "My Accounts",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "CytoraChecking",
					type: "link",
					title: "Cytora Checking",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "NOCs",
					type: "link",
					title: "NOCs",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
					path: "HighLevelWorkflow",
					type: "link",
					title: "High-Level Workflow",
					selected: false,
					active: false,
					dirChange: false
				),
			}
		),
		new MainMenuItems(
			type: "sub",
			title: "FDWH Reporting",
			icon: "",
			svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3 3h18v18H3V3zm3 3v12m6-12v12m6-12v12' /></svg>",
			badgeValue: "",
			badgeClass: "",
			selected: false,
			active: false,
			dirChange: false,
			children: new MainMenuItems[]
			{
				new MainMenuItems(
					path: "FDWH/Reports",
					type: "link",
					title: "Reports",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems(
					path: "FDWH/ReportRuns",
					type: "link",
					title: "Report Runs",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems(
					path: "FDWH/SUA",
					type: "link",
					title: "SUA",
					selected: false,
					active: false,
					dirChange: false
				)
			}
		),
		new MainMenuItems(
	type: "sub",
	title: "Exceptions",
	icon: "",
	svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M12 9v3.75m0 3.75h.007v.008H12v-.008zM21 12a9 9 0 1 1-18 0 9 9 0 0 1 18 0z' /></svg>",
	badgeValue: "",
	badgeClass: "",
	selected: false,
	active: false,
	dirChange: false,
	children: new MainMenuItems[]
	{
		new MainMenuItems (
			path: "MyExceptions",
			type: "link",
			title: "My Exceptions",
			selected: false,
			active: false,
			dirChange: false
		),
		new MainMenuItems (
			path: "AllExceptions",
			type: "link",
			title: "All Exceptions",
			selected: false,
			active: false,
			dirChange: false
		)
	}
),

		new MainMenuItems(
			type: "sub",
			title: "Ultimates",
			icon: "",
			svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3.75 3v11.25A2.25 2.25 0 0 0 6 16.5h2.25M3.75 3h-1.5m1.5 0h16.5m0 0h1.5m-1.5 0v11.25A2.25 2.25 0 0 1 18 16.5h-2.25m-7.5 0h7.5m-7.5 0-1 3m8.5-3 1 3m0 0 .5 1.5m-.5-1.5h-9.5m0 0-.5 1.5M9 11.25v1.5M12 9v3.75m3-6v6' /></svg>",
			badgeValue: "",
			badgeClass: "",
			selected: false,
			active: false,
			dirChange: false,
			children: new MainMenuItems[]
			{
				new MainMenuItems(
					path: "Ultimates/Premium",
					type: "link",
					title: "Premium",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems(
					path: "Ultimates/Claims",
					type: "link",
					title: "Claims",
					selected: false,
					active: false,
					dirChange: false
				)
			}
		),
	};

	public List<MainMenuItems> GetMenuData()
	{
		return MenuData;
	}
}
