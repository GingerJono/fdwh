using CardModel;
namespace LandingData
{
    public class MainCard
    {   
        public decimal Id { get; set; }
        public string? Icon { get; set; }
        public string? IconClass { get; set; }
        public string? Title { get; set; }
        public string? Desc { get; set; }
    }
    public class FaqsList
    {
        public decimal id { get; set; }
        public string? title { get; set; } 
        public string? desc { get; set; } 
    }

    public class LandingService {
        private List<MainCard>  CardData1  = new List<MainCard>()
        {
            new MainCard{Id=1,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M208,40H48A24,24,0,0,0,24,64V176a24,24,0,0,0,24,24H208a24,24,0,0,0,24-24V64A24,24,0,0,0,208,40Zm8,136a8,8,0,0,1-8,8H48a8,8,0,0,1-8-8V64a8,8,0,0,1,8-8H208a8,8,0,0,1,8,8Zm-48,48a8,8,0,0,1-8,8H96a8,8,0,0,1,0-16h64A8,8,0,0,1,168,224Z'></path></svg>",IconClass= "primary",Title ="Responsive and Accessible",Desc ="Lorem ipsum dolor sit, amet consectetur adipisicing elitipsum dolor sit, amet consectetur",},
            new MainCard{Id=2,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,48V96a8,8,0,0,1-8,8H168a8,8,0,0,1,0-16h28.69L182.06,73.37a79.56,79.56,0,0,0-56.13-23.43h-.45A79.52,79.52,0,0,0,69.59,72.71,8,8,0,0,1,58.41,61.27a96,96,0,0,1,135,.79L208,76.69V48a8,8,0,0,1,16,0ZM186.41,183.29a80,80,0,0,1-112.47-.66L59.31,168H88a8,8,0,0,0,0-16H40a8,8,0,0,0-8,8v48a8,8,0,0,0,16,0V179.31l14.63,14.63A95.43,95.43,0,0,0,130,222.06h.53a95.36,95.36,0,0,0,67.07-27.33,8,8,0,0,0-11.18-11.44Z'></path></svg>",IconClass= "primary1",Title ="Continuous Updates and Support",Desc ="Lorem ipsum dolor sit, amet consectetur adipisicing elitipsum dolor sit, amet consectetur",},
            new MainCard{Id=3,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M64,105V40a8,8,0,0,0-16,0v65a32,32,0,0,0,0,62v49a8,8,0,0,0,16,0V167a32,32,0,0,0,0-62Zm-8,47a16,16,0,1,1,16-16A16,16,0,0,1,56,152Zm80-95V40a8,8,0,0,0-16,0V57a32,32,0,0,0,0,62v97a8,8,0,0,0,16,0V119a32,32,0,0,0,0-62Zm-8,47a16,16,0,1,1,16-16A16,16,0,0,1,128,104Zm104,64a32.06,32.06,0,0,0-24-31V40a8,8,0,0,0-16,0v97a32,32,0,0,0,0,62v17a8,8,0,0,0,16,0V199A32.06,32.06,0,0,0,232,168Zm-32,16a16,16,0,1,1,16-16A16,16,0,0,1,200,184Z'></path></svg>",IconClass= "primary2",Title ="Design and Customization",Desc ="Lorem ipsum dolor sit, amet consectetur adipisicing elitipsum dolor sit, amet consectetur",},
        };       
        public List<MainCard> GetCardData1() => CardData1;
        private List<MainCard>  CardData2  = new List<MainCard>()
        {
            new MainCard{Id=1,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "primary",Title ="Responsive Design",Desc ="Ensures the template is optimized for various screen sizes and devices, enhancing usability."},
            new MainCard{Id=2,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "primary1",Title ="Pre-built Components",Desc ="Ready-made UI components such as buttons, forms, tables, charts, and modals."},
            new MainCard{Id=3,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "primary2",Title ="Customization Options",Desc ="Ability to customize colors, fonts, layouts, and other visual elements to match your brand."},
            new MainCard{Id=4,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "primary3",Title ="Documentation",Desc ="Comprehensive documentation that guides you through installation, customization."},
            new MainCard{Id=5,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "secondary",Title ="Support",Desc ="Access to support forums, ticket systems, or direct support from the template provider."},
            new MainCard{Id=6,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "info",Title ="Updates and Maintenance",Desc ="Regular updates to ensure compatibility with the latest web technologies and bug fixes."},
            new MainCard{Id=7,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "warning",Title ="Multiple Layout",Desc ="Different layout styles (sidebar navigation, top navigation) to suit different types of applications."},
            new MainCard{Id=8,Icon ="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass= "success",Title ="Performance Optimization",Desc ="Code optimized for performance, including lazy loading of assets, CSS and JS files."},
        };       
        public List<MainCard> GetCardData2() => CardData2;
        
        private List<FaqsList>  FaqsListsData  = new List<FaqsList>()
        {
            new FaqsList{ id= 1,title= "Where can I subscribe to your newsletter?"},
            new FaqsList{ id= 2,title= "Where can in edit my address?"},
            new FaqsList{ id= 3,title= "What are your opening hours?"},
            new FaqsList{ id= 4,title= "Do I have the right to return an item?"},
            new FaqsList{ id= 5,title= "General Terms & Conditions (GTC)"},
            new FaqsList{ id= 6,title= "Do I need to create an account to make an order?"},

            new FaqsList{ id= 7,title= "General Terms & Conditions (GTC)"},
            new FaqsList{ id= 8,title= "Do I need to create an account to make an order?"},
            new FaqsList{ id= 9,title= "Where can I subscribe to your newsletter?"},
            new FaqsList{ id= 10,title= "Where can in edit my address?"},
            new FaqsList{ id= 11,title= "What are your opening hours?"},
            new FaqsList{ id= 12,title= "Do I have the right to return an item?"},
        };
         public List<FaqsList> GetFaqsListsData() => FaqsListsData;
    }
}