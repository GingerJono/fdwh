public class MenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems(
            menuTitle: "Main"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Dashboards",
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
                    path: "/index",
                    type: "link",
                    title: "Sales",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index2",
                    type: "link",
                    title: "Analytics",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index3",
                    type: "link",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
				new MainMenuItems (
					path: "/index17",
					type: "link",
					title: "JonoTest",
					selected: false,
					active: false,
					dirChange: false
				),
				new MainMenuItems (
                    path: "/index4",
                    type: "link",
                    title: "CRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index5",
                    type: "link",
                    title: "HRM",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index6",
                    type: "link",
                    title: "NFT",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index7",
                    type: "link",
                    title: "Crypto",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index8",
                    type: "link",
                    title: "Jobs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index9",
                    type: "link",
                    title: "Projects",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index10",
                    type: "link",
                    title: "Courses",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index11",
                    type: "link",
                    title: "Stocks",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index12",
                    type: "link",
                    title: "Medical",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index13",
                    type: "link",
                    title: "POS System",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index14",
                    type: "link",
                    title: "Podcast",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index15",
                    type: "link",
                    title: "School",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/index16",
                    type: "link",
                    title: "Social Media",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems(
            menuTitle: "Web Apps"
        ),
        new MainMenuItems(
            type: "sub",
            title: "Apps",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M13.5 16.875h3.375m0 0h3.375m-3.375 0V13.5m0 3.375v3.375M6 10.5h2.25a2.25 2.25 0 0 0 2.25-2.25V6a2.25 2.25 0 0 0-2.25-2.25H6A2.25 2.25 0 0 0 3.75 6v2.25A2.25 2.25 0 0 0 6 10.5Zm0 9.75h2.25A2.25 2.25 0 0 0 10.5 18v-2.25a2.25 2.25 0 0 0-2.25-2.25H6a2.25 2.25 0 0 0-2.25 2.25V18A2.25 2.25 0 0 0 6 20.25Zm9.75-9.75H18a2.25 2.25 0 0 0 2.25-2.25V6A2.25 2.25 0 0 0 18 3.75h-2.25A2.25 2.25 0 0 0 13.5 6v2.25a2.25 2.25 0 0 0 2.25 2.25Z' /></svg>",
            badgeValue: "",
            badgeClass: "",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Ecommerce",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/add-products",
                            type: "link",
                            title: "Add Products",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/cart",
                            type: "link",
                            title: "Cart",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/checkout",
                            type: "link",
                            title: "Checkout",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/edit-products",
                            type: "link",
                            title: "Edit Products",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/order-details",
                            type: "link",
                            title: "Order Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/orders",
                            type: "link",
                            title: "Orders",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/products",
                            type: "link",
                            title: "Products",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/product-details",
                            type: "link",
                            title: "Product Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/products-list",
                            type: "link",
                            title: "Products List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/wishlist",
                            type: "link",
                            title: "Wishlist",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Calendars",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/full-calendar",
                            type: "link",
                            title: "Full Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blazor-calendar",
                            type: "link",
                            title: "Blazor Calendar",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/gallery",
                    type: "link",
                    title: "Gallery",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/sweet-alerts",
                    type: "link",
                    title: "Sweet Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Projects",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/projects-list",
                            type: "link",
                            title: "Projects List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-overview",
                            type: "link",
                            title: "Project Overview",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/projects-create",
                            type: "link",
                            title: "Create Project",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Task",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/task-kanban-board",
                            type: "link",
                            title: "Kanban Board",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/task-list-view",
                            type: "link",
                            title: "List View",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/task-details",
                            type: "link",
                            title: "Task Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Jobs",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/job-details",
                            type: "link",
                            title: "Job Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-company-search",
                            type: "link",
                            title: "Search Company",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-search",
                            type: "link",
                            title: "Search Jobs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-post",
                            type: "link",
                            title: "Job Post",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-list",
                            type: "link",
                            title: "Job List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-search",
                            type: "link",
                            title: "Search Candidate",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/job-candidate-details",
                            type: "link",
                            title: "Candidate Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "NFT",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/nft-marketplace",
                            type: "link",
                            title: "Market Place",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-details",
                            type: "link",
                            title: "NFT Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-create",
                            type: "link",
                            title: "Create NFT",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-wallet-integration",
                            type: "link",
                            title: "Wallet Integration",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/nft-live-auction",
                            type: "link",
                            title: "Live Auction",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "CRM",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crm-contacts",
                            type: "link",
                            title: "Contacts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-companies",
                            type: "link",
                            title: "Companies",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-deals",
                            type: "link",
                            title: "Deals",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crm-leads",
                            type: "link",
                            title: "Leads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "",
                    type: "sub",
                    title: "Crypto",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/crypto-transactions",
                            type: "link",
                            title: "Transactions",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-currency-exchange",
                            type: "link",
                            title: "Currency Exchange",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-buy-sell",
                            type: "link",
                            title: "Buy & Sell",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-marketcap",
                            type: "link",
                            title: "Marketcap",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/crypto-wallet",
                            type: "link",
                            title: "Wallet",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Nested Menu",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M15.75 17.25v3.375c0 .621-.504 1.125-1.125 1.125h-9.75a1.125 1.125 0 0 1-1.125-1.125V7.875c0-.621.504-1.125 1.125-1.125H6.75a9.06 9.06 0 0 1 1.5.124m7.5 10.376h3.375c.621 0 1.125-.504 1.125-1.125V11.25c0-4.46-3.243-8.161-7.5-8.876a9.06 9.06 0 0 0-1.5-.124H9.375c-.621 0-1.125.504-1.125 1.125v3.5m7.5 10.375H9.375a1.125 1.125 0 0 1-1.125-1.125v-9.25m12 6.625v-1.875a3.375 3.375 0 0 0-3.375-3.375h-1.5a1.125 1.125 0 0 1-1.125-1.125v-1.5a3.375 3.375 0 0 0-3.375-3.375H9.75' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "",
                    type: "empty",
                    title: "Nested-1",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Nested-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Nested-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Nested-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Nested-2-2-2",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                )
                            }
                        )
                    }
                )
            }
        ),

        new MainMenuItems(
            menuTitle: "PAGES"
        ),

        new MainMenuItems (
            type: "sub",
            title: "Authentication",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M16.5 10.5V6.75a4.5 4.5 0 1 0-9 0v3.75m-.75 11.25h10.5a2.25 2.25 0 0 0 2.25-2.25v-6.75a2.25 2.25 0 0 0-2.25-2.25H6.75a2.25 2.25 0 0 0-2.25 2.25v6.75a2.25 2.25 0 0 0 2.25 2.25Z' /></svg>",
            badgeValue: "",
            badgeClass: "",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems ( 
                    path: "/comingsoon",
                    type: "link",
                    title: "Coming Soon",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Create Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/createpassword-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/createpassword-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Lock Screen",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/lockscreen-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/lockscreen-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Reset Password",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/resetpassword-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/resetpassword-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign Up",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/signup-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/signup-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Sign In",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/signin-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/signin-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    type: "sub",
                    title: "Two Step Verification",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems ( 
                            path: "/twostep-verification-basic",
                            type: "link",
                            title: "Basic",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems ( 
                            path: "/twostep-verification-cover",
                            type: "link",
                            title: "Cover",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems ( 
                    path: "/under-maintenance",
                    type: "link",
                    title: "Under Maintenance",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Error",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M12 9v3.75m-9.303 3.376c-.866 1.5.217 3.374 1.948 3.374h14.71c1.73 0 2.813-1.874 1.948-3.374L13.949 3.378c-.866-1.5-3.032-1.5-3.898 0L2.697 16.126ZM12 15.75h.007v.008H12v-.008Z' /></svg>",
            badgeValue: "",
            badgeClass: "",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/error401",
                    type: "link",
                    title: "401 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/error404",
                    type: "link",
                    title: "404 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/error500",
                    type: "link",
                    title: "500 - Error",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems(
            type: "sub",
            title: "Pages",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M11.35 3.836c-.065.21-.1.433-.1.664 0 .414.336.75.75.75h4.5a.75.75 0 0 0 .75-.75 2.25 2.25 0 0 0-.1-.664m-5.8 0A2.251 2.251 0 0 1 13.5 2.25H15c1.012 0 1.867.668 2.15 1.586m-5.8 0c-.376.023-.75.05-1.124.08C9.095 4.01 8.25 4.973 8.25 6.108V8.25m8.9-4.414c.376.023.75.05 1.124.08 1.131.094 1.976 1.057 1.976 2.192V16.5A2.25 2.25 0 0 1 18 18.75h-2.25m-7.5-10.5H4.875c-.621 0-1.125.504-1.125 1.125v11.25c0 .621.504 1.125 1.125 1.125h9.75c.621 0 1.125-.504 1.125-1.125V18.75m-7.5-10.5h6.375c.621 0 1.125.504 1.125 1.125v9.375m-8.25-3 1.5 1.5 3-3.75' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Blog",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/blog",
                            type: "link",
                            title: "Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog-details",
                            type: "link",
                            title: "Blog Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blog-create",
                            type: "link",
                            title: "Create Blog",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/chat",
                    type: "link",
                    title: "Chat",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/counter",
                    type: "link",
                    title: "Counter",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Email",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/mail",
                            type: "link",
                            title: "Mail App",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/mail-settings",
                            type: "link",
                            title: "Mail Settings",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/empty-page",
                    type: "link",
                    title: "Empty",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/faqs",
                    type: "link",
                    title: "FAQ's",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/filemanager",
                    type: "link",
                    title: "File Manager",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Invoice",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/invoice-create",
                            type: "link",
                            title: "Create Invoice",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-details",
                            type: "link",
                            title: "Invoice Details",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/invoice-list",
                            type: "link",
                            title: "Invoice List",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/landing",
                    type: "external",
                    title: "Landing Page",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/pricing",
                    type: "link",
                    title: "Pricing",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile",
                    type: "link",
                    title: "Profile",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/profile-settings",
                    type: "link",
                    title: "Profile Settings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/reviews",
                    type: "link",
                    title: "Reviews",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/search-results",
                    type: "link",
                    title: "Search",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/team",
                    type: "link",
                    title: "Team",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/terms-conditions",
                    type: "link",
                    title: "Terms & Conditions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/timeline",
                    type: "link",
                    title: "Timeline",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/todo-list",
                    type: "link",
                    title: "To Do List",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            menuTitle: "GENERAL"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Forms",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'> <path stroke-linecap='round' stroke-linejoin='round' d='M15.666 3.888A2.25 2.25 0 0 0 13.5 2.25h-3c-1.03 0-1.9.693-2.166 1.638m7.332 0c.055.194.084.4.084.612v0a.75.75 0 0 1-.75.75H9a.75.75 0 0 1-.75-.75v0c0-.212.03-.418.084-.612m7.332 0c.646.049 1.288.11 1.927.184 1.1.128 1.907 1.077 1.907 2.185V19.5a2.25 2.25 0 0 1-2.25 2.25H6.75A2.25 2.25 0 0 1 4.5 19.5V6.257c0-1.108.806-2.057 1.907-2.185a48.208 48.208 0 0 1 1.927-.184' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/form-advanced",
                    type: "link",
                    title: "Form Advanced",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Form Elements",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form-inputs",
                            type: "link",
                            title: "Inputs",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-check-radios",
                            type: "link",
                            title: "Checks & Radios",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-input-groups",
                            type: "link",
                            title: "Input Groups",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-select",
                            type: "link",
                            title: "Form Select",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-range",
                            type: "link",
                            title: "Range Slider",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-input-masks",
                            type: "link",
                            title: "Input Masks",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-file-uploads",
                            type: "link",
                            title: "File Uploads",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-datetime-pickers",
                            type: "link",
                            title: "Date,Time Picker",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/form-color-pickers",
                            type: "link",
                            title: "Color Pickers",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),new MainMenuItems (
                    type: "sub",
                    title: "Form Wizards",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/form-wizards",
                            type: "link",
                            title: "JS",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/blazor-form-wizards",
                            type: "link",
                            title: "Blazor",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/floating-labels",
                    type: "link",
                    title: "Floating Labels",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-layouts",
                    type: "link",
                    title: "Form Layouts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/quill-editor",
                    type: "link",
                    title: "Quill Editor",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-validations",
                    type: "link",
                    title: "Validations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/form-select2",
                    type: "link",
                    title: "Select2",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Ui Elements",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='m20.25 7.5-.625 10.632a2.25 2.25 0 0 1-2.247 2.118H6.622a2.25 2.25 0 0 1-2.247-2.118L3.75 7.5M10 11.25h4M3.375 7.5h17.25c.621 0 1.125-.504 1.125-1.125v-1.5c0-.621-.504-1.125-1.125-1.125H3.375c-.621 0-1.125.504-1.125 1.125v1.5c0 .621.504 1.125 1.125 1.125Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/alerts",
                    type: "link",
                    title: "Alerts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/badges",
                    type: "link",
                    title: "Badges",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breadcrumbs",
                    type: "link",
                    title: "Breadcrumb",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttons",
                    type: "link",
                    title: "Buttons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/buttongroups",
                    type: "link",
                    title: "Button Groups",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/cards",
                    type: "link",
                    title: "Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/dropdowns",
                    type: "link",
                    title: "Dropdowns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/images-figures",
                    type: "link",
                    title: "Images & Figures",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/links-interactions",
                    type: "link",
                    title: "Links & Interactions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/listgroups",
                    type: "link",
                    title: "List Groups",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navs-tabs",
                    type: "link",
                    title: "Navs & Tabs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/object-fit",
                    type: "link",
                    title: "Object Fit",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/paginations",
                    type: "link",
                    title: "Paginations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/popovers",
                    type: "link",
                    title: "Popovers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/progress",
                    type: "link",
                    title: "Progress",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/spinners",
                    type: "link",
                    title: "Spinners",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/toasts",
                    type: "link",
                    title: "Toasts",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tooltips",
                    type: "link",
                    title: "Tooltips",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/typography",
                    type: "link",
                    title: "Typography",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Advanced Ui",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M4.098 19.902a3.75 3.75 0 0 0 5.304 0l6.401-6.402M6.75 21A3.75 3.75 0 0 1 3 17.25V4.125C3 3.504 3.504 3 4.125 3h5.25c.621 0 1.125.504 1.125 1.125v4.072M6.75 21a3.75 3.75 0 0 0 3.75-3.75V8.197M6.75 21h13.125c.621 0 1.125-.504 1.125-1.125v-5.25c0-.621-.504-1.125-1.125-1.125h-4.072M10.5 8.197l2.88-2.88c.438-.439 1.15-.439 1.59 0l3.712 3.713c.44.44.44 1.152 0 1.59l-2.879 2.88M6.75 17.25h.008v.008H6.75v-.008Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/accordions-collapse",
                    type: "link",
                    title: "Accordion & Collapse",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/carousel",
                    type: "link",
                    title: "Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/draggable-cards",
                    type: "link",
                    title: "Draggable Cards",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/media-player",
                    type: "link",
                    title: "Media Player",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/modals-closes",
                    type: "link",
                    title: "Modals & Closes",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/navbar",
                    type: "link",
                    title: "Navbar",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/offcanvas",
                    type: "link",
                    title: "Offcanvas",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/placeholders",
                    type: "link",
                    title: "Placeholders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ratings",
                    type: "link",
                    title: "Ratings",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/ribbons",
                    type: "link",
                    title: "Ribbons",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/sortable-list",
                    type: "link",
                    title: "Sortable JS",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/tour",
                    type: "link",
                    title: "Tour",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/slick-carousel",
                    type: "link",
                    title: "Slick Carousel",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/treeview",
                    type: "link",
                    title: "Treeview",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            type: "sub",
            title: "Utilities",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M2.25 13.5h3.86a2.25 2.25 0 0 1 2.012 1.244l.256.512a2.25 2.25 0 0 0 2.013 1.244h3.218a2.25 2.25 0 0 0 2.013-1.244l.256-.512a2.25 2.25 0 0 1 2.013-1.244h3.859m-19.5.338V18a2.25 2.25 0 0 0 2.25 2.25h15A2.25 2.25 0 0 0 21.75 18v-4.162c0-.224-.034-.447-.1-.661L19.24 5.338a2.25 2.25 0 0 0-2.15-1.588H6.911a2.25 2.25 0 0 0-2.15 1.588L2.35 13.177a2.25 2.25 0 0 0-.1.661Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/avatars",
                    type: "link",
                    title: "Avatars",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/borders",
                    type: "link",
                    title: "Borders",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/breakpoints",
                    type: "link",
                    title: "Breakpoints",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/colors",
                    type: "link",
                    title: "Colors",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/columns",
                    type: "link",
                    title: "Columns",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/css-grid",
                    type: "link",
                    title: "CSS Grid",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/flex",
                    type: "link",
                    title: "Flex",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/gutters",
                    type: "link",
                    title: "Gutters",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/helpers",
                    type: "link",
                    title: "Helpers",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/position",
                    type: "link",
                    title: "Positions",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/more",
                    type: "link",
                    title: "Additional Content",
                    selected: false,
                    active: false,
                    dirChange: false
                )
            }
        ),

        new MainMenuItems (
            path: "/widgets",
            type: "link",
            title: "Widgets",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M21 11.25v8.25a1.5 1.5 0 0 1-1.5 1.5H5.25a1.5 1.5 0 0 1-1.5-1.5v-8.25M12 4.875A2.625 2.625 0 1 0 9.375 7.5H12m0-2.625V7.5m0-2.625A2.625 2.625 0 1 1 14.625 7.5H12m0 0V21m-8.625-9.75h18c.621 0 1.125-.504 1.125-1.125v-1.5c0-.621-.504-1.125-1.125-1.125h-18c-.621 0-1.125.504-1.125 1.125v1.5c0 .621.504 1.125 1.125 1.125Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false
        ),
        
        new MainMenuItems (
            menuTitle: "MAPS & ICONS"
        ),
        new MainMenuItems (
            type: "sub",
            title: "Maps",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M9 6.75V15m6-6v8.25m.503 3.498 4.875-2.437c.381-.19.622-.58.622-1.006V4.82c0-.836-.88-1.38-1.628-1.006l-3.869 1.934c-.317.159-.69.159-1.006 0L9.503 3.252a1.125 1.125 0 0 0-1.006 0L3.622 5.689C3.24 5.88 3 6.27 3 6.695V19.18c0 .836.88 1.38 1.628 1.006l3.869-1.934c.317-.159.69-.159 1.006 0l4.994 2.497c.317.158.69.158 1.006 0Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/vector-maps",
                    type: "link",
                    title: "Vector Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/leaflet-maps",
                    type: "link",
                    title: "Leaflet Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/google-maps",
                    type: "link",
                    title: "Google Maps",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),

        new MainMenuItems (
            path: "/icons",
            type: "link",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M13.5 21v-7.5a.75.75 0 0 1 .75-.75h3a.75.75 0 0 1 .75.75V21m-4.5 0H2.36m11.14 0H18m0 0h3.64m-1.39 0V9.349M3.75 21V9.349m0 0a3.001 3.001 0 0 0 3.75-.615A2.993 2.993 0 0 0 9.75 9.75c.896 0 1.7-.393 2.25-1.016a2.993 2.993 0 0 0 2.25 1.016c.896 0 1.7-.393 2.25-1.015a3.001 3.001 0 0 0 3.75.614m-16.5 0a3.004 3.004 0 0 1-.621-4.72l1.189-1.19A1.5 1.5 0 0 1 5.378 3h13.243a1.5 1.5 0 0 1 1.06.44l1.19 1.189a3 3 0 0 1-.621 4.72M6.75 18h3.75a.75.75 0 0 0 .75-.75V13.5a.75.75 0 0 0-.75-.75H6.75a.75.75 0 0 0-.75.75v3.75c0 .414.336.75.75.75Z' /></svg>",
            title: "Icons",
            selected: false,
            active: false,
            dirChange: false
        ),

        new MainMenuItems (
            menuTitle: "TABLES & CHARTS"
        ),

        new MainMenuItems (
            type: "sub",
            title: "Charts",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3 13.125C3 12.504 3.504 12 4.125 12h2.25c.621 0 1.125.504 1.125 1.125v6.75C7.5 20.496 6.996 21 6.375 21h-2.25A1.125 1.125 0 0 1 3 19.875v-6.75ZM9.75 8.625c0-.621.504-1.125 1.125-1.125h2.25c.621 0 1.125.504 1.125 1.125v11.25c0 .621-.504 1.125-1.125 1.125h-2.25a1.125 1.125 0 0 1-1.125-1.125V8.625ZM16.5 4.125c0-.621.504-1.125 1.125-1.125h2.25C20.496 3 21 3.504 21 4.125v15.75c0 .621-.504 1.125-1.125 1.125h-2.25a1.125 1.125 0 0 1-1.125-1.125V4.125Z' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    type: "sub",
                    title: "Apex Charts",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "/apex-line-charts",
                            type: "link",
                            title: "Line Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-area-charts",
                            type: "link",
                            title: "Area Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-column-charts",
                            type: "link",
                            title: "Column Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bar-charts",
                            type: "link",
                            title: "Bar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-mixed-charts",
                            type: "link",
                            title: "Mixed Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-rangearea-charts",
                            type: "link",
                            title: "Range Area Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-timeline-charts",
                            type: "link",
                            title: "Timeline Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-funnel-charts",
                            type: "link",
                            title: "Funnel Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-candlestick-charts",
                            type: "link",
                            title: "Candle Stick Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-boxplot-charts",
                            type: "link",
                            title: "Boxplot Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-bubble-charts",
                            type: "link",
                            title: "Bubble Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-scatter-charts",
                            type: "link",
                            title: "Scatter Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/Apex-heatmap-charts",
                            type: "link",
                            title: "Heatmap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-treemap-charts",
                            type: "link",
                            title: "Treemap Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-pie-charts",
                            type: "link",
                            title: "Pie Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radialbar-charts",
                            type: "link",
                            title: "Radialbar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-radar-charts",
                            type: "link",
                            title: "Radar Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-polararea-charts",
                            type: "link",
                            title: "Polararea Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            path: "/apex-slope-charts",
                            type: "link",
                            title: "Slope Charts",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                    }
                ),
                new MainMenuItems (
                    path: "/chartjs-charts",
                    type: "link",
                    title: "Chartjs",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
            }
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "Tables",
            icon: "",
            svg: "<svg xmlns='http://www.w3.org/2000/svg' class='w-6 h-6 side-menu__icon' fill='none' viewBox='0 0 24 24' stroke-width='1.5' stroke='currentColor'><path stroke-linecap='round' stroke-linejoin='round' d='M3.375 19.5h17.25m-17.25 0a1.125 1.125 0 0 1-1.125-1.125M3.375 19.5h7.5c.621 0 1.125-.504 1.125-1.125m-9.75 0V5.625m0 12.75v-1.5c0-.621.504-1.125 1.125-1.125m18.375 2.625V5.625m0 12.75c0 .621-.504 1.125-1.125 1.125m1.125-1.125v-1.5c0-.621-.504-1.125-1.125-1.125m0 3.75h-7.5A1.125 1.125 0 0 1 12 18.375m9.75-12.75c0-.621-.504-1.125-1.125-1.125H3.375c-.621 0-1.125.504-1.125 1.125m19.5 0v1.5c0 .621-.504 1.125-1.125 1.125M2.25 5.625v1.5c0 .621.504 1.125 1.125 1.125m0 0h17.25m-17.25 0h7.5c.621 0 1.125.504 1.125 1.125M3.375 8.25c-.621 0-1.125.504-1.125 1.125v1.5c0 .621.504 1.125 1.125 1.125m17.25-3.75h-7.5c-.621 0-1.125.504-1.125 1.125m8.625-1.125c.621 0 1.125.504 1.125 1.125v1.5c0 .621-.504 1.125-1.125 1.125m-17.25 0h7.5m-7.5 0c-.621 0-1.125.504-1.125 1.125v1.5c0 .621.504 1.125 1.125 1.125M12 10.875v-1.5m0 1.5c0 .621-.504 1.125-1.125 1.125M12 10.875c0 .621.504 1.125 1.125 1.125m-2.25 0c.621 0 1.125.504 1.125 1.125M13.125 12h7.5m-7.5 0c-.621 0-1.125.504-1.125 1.125M20.625 12c.621 0 1.125.504 1.125 1.125v1.5c0 .621-.504 1.125-1.125 1.125m-17.25 0h7.5M12 14.625v-1.5m0 1.5c0 .621-.504 1.125-1.125 1.125M12 14.625c0 .621.504 1.125 1.125 1.125m-2.25 0c.621 0 1.125.504 1.125 1.125m0 1.5v-1.5m0 0c0-.621.504-1.125 1.125-1.125m0 0h7.5' /></svg>",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "/tables",
                    type: "link",
                    title: "Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/grid-tables",
                    type: "link",
                    title: "Grid JS Tables",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "/data-tables",
                    type: "link",
                    title: "Data Tables",
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
