public class LandingMenuDataService
{
    private List<MainMenuItems> MenuData = new List<MainMenuItems>()
    {
        new MainMenuItems (
            path: "#home",
            type: "link",
            title: "Home",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "#about",
            type: "link",
            title: "About",
            selected: false,
            active: false,
            dirChange: false
        ),
        
        new MainMenuItems (
            type: "sub",
            title: "More",
            selected: false,
            active: false,
            dirChange: false,
            children: new MainMenuItems[]
            {
                new MainMenuItems (
                    path: "#services",
                    type: "link",
                    title: "Services",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "#expectations",
                    type: "link",
                    title: "Expectations",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    path: "#features",
                    type: "link",
                    title: "Features",
                    selected: false,
                    active: false,
                    dirChange: false
                ),
                new MainMenuItems (
                    type: "sub",
                    title: "Level-2",
                    selected: false,
                    active: false,
                    dirChange: false,
                    children: new MainMenuItems[]
                    {
                        new MainMenuItems (
                            path: "",
                            type: "empty",
                            title: "Level-2-1",
                            selected: false,
                            active: false,
                            dirChange: false
                        ),
                        new MainMenuItems (
                            type: "sub",
                            title: "Level-2-2",
                            selected: false,
                            active: false,
                            dirChange: false,
                            children: new MainMenuItems[]
                            {
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-1",
                                    selected: false,
                                    active: false,
                                    dirChange: false
                                ),
                                new MainMenuItems (
                                    path: "",
                                    type: "empty",
                                    title: "Level-2-2-2",
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
        
        new MainMenuItems (
            path: "#team",
            type: "link",
            title: "Team",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "#pricing",
            type: "link",
            title: "Pricing",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "#faqs",
            type: "link",
            title: "Faq's",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "#testimonials",
            type: "link",
            title: "Testimonials",
            selected: false,
            active: false,
            dirChange: false
        ),
        new MainMenuItems (
            path: "#contact",
            type: "link",
            title: "Contact Us",
            selected: false,
            active: false,
            dirChange: false
        ),
    };

    public List<MainMenuItems> GetMenuData()
   {
        return MenuData;
    }
}
