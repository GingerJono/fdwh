using CardModel;

namespace Ecommerce
{
    public class EcommerceService
    {
        private List<MainCard> EcommerceCardData = new List<MainCard>()
        {
            new MainCard {
                id = 1,
                title = "Total Sales",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M136,120v56a8,8,0,0,1-16,0V120a8,8,0,0,1,16,0ZM239.86,98.11,226,202.12A16,16,0,0,1,210.13,216H45.87A16,16,0,0,1,30,202.12l-13.87-104A16,16,0,0,1,32,80H68.37L122,18.73a8,8,0,0,1,12,0L187.63,80H224a16,16,0,0,1,15.85,18.11ZM89.63,80h76.74L128,36.15ZM224,96H32L45.87,200H210.13Zm-51.16,23.2-5.6,56A8,8,0,0,0,174.4,184a7.44,7.44,0,0,0,.81,0,8,8,0,0,0,7.95-7.2l5.6-56a8,8,0,0,0-15.92-1.6Zm-89.68,0a8,8,0,0,0-15.92,1.6l5.6,56a8,8,0,0,0,8,7.2,7.44,7.44,0,0,0,.81,0,8,8,0,0,0,7.16-8.76Z'></path></svg>",
                iconclass ="bg-primary svg-white",
                price = "15,432" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="5.1%",
                statusicon ="ti ti-trending-up",
                IsRounded=false,
                MainBgImg=true,
            },
            new MainCard {
                id = 2,
                title = "Revenue",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M168,56a8,8,0,0,1,8-8h16V32a8,8,0,0,1,16,0V48h16a8,8,0,0,1,0,16H208V80a8,8,0,0,1-16,0V64H176A8,8,0,0,1,168,56Zm62.56,54.68a103.92,103.92,0,1,1-85.24-85.24,8,8,0,0,1-2.64,15.78A88.07,88.07,0,0,0,40,128a87.62,87.62,0,0,0,22.24,58.41A79.66,79.66,0,0,1,98.3,157.66a48,48,0,1,1,59.4,0,79.66,79.66,0,0,1,36.06,28.75A87.62,87.62,0,0,0,216,128a88.85,88.85,0,0,0-1.22-14.68,8,8,0,1,1,15.78-2.64ZM128,152a32,32,0,1,0-32-32A32,32,0,0,0,128,152Zm0,64a87.57,87.57,0,0,0,53.92-18.5,64,64,0,0,0-107.84,0A87.57,87.57,0,0,0,128,216Z'></path></svg>",
                iconclass ="bg-primary1 svg-white",
                price = "$245,147" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="0.6%",
                statusicon ="ti ti-trending-up",
                IsRounded=false,
                MainBgImg=true,
            },
            new MainCard {
                id = 3,
                title = "Average Order Value",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",
                iconclass ="bg-primary2 svg-white",
                price = "$120" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="1.08%",
                statusicon ="ti ti-trending-down",
                IsRounded=false,
                MainBgImg=true,
            },
            new MainCard {
                id = 4,
                title = "Total Orders",
                svg = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M223.68,66.15,135.68,18a15.88,15.88,0,0,0-15.36,0l-88,48.17a16,16,0,0,0-8.32,14v95.64a16,16,0,0,0,8.32,14l88,48.17a15.88,15.88,0,0,0,15.36,0l88-48.17a16,16,0,0,0,8.32-14V80.18A16,16,0,0,0,223.68,66.15ZM128,32l80.34,44-29.77,16.3-80.35-44ZM128,120,47.66,76l33.9-18.56,80.34,44ZM40,90l80,43.78v85.79L40,175.82Zm176,85.78h0l-80,43.79V133.82l32-17.51V152a8,8,0,0,0,16,0V107.55L216,90v85.77Z'></path></svg>",
                iconclass ="bg-primary3 svg-white",
                price = "1,25,032" ,
                status ="Increased",
                statusclass ="text-success",
                statusdata ="2.3%",
                statusicon ="ti ti-trending-up",
                IsRounded=false,
                MainBgImg=true,
            },

        };
        public static List<SalesReport> GetSalesReportData() {
            var salesreport = new List<SalesReport>();
            salesreport.Add(new SalesReport { Month = "Jan", Sales = 20, Profit = 10, Expenses = 38});
            salesreport.Add(new SalesReport { Month = "Feb", Sales = 42, Profit = 39, Expenses = 53});
            salesreport.Add(new SalesReport { Month = "Mar", Sales = 28, Profit = 25, Expenses = 34});
            salesreport.Add(new SalesReport { Month = "Apr", Sales = 79, Profit = 74, Expenses = 33});
            salesreport.Add(new SalesReport { Month = "May", Sales = 68, Profit = 58, Expenses = 30});
            salesreport.Add(new SalesReport { Month = "Jun", Sales = 84, Profit = 80, Expenses = 28});
            salesreport.Add(new SalesReport { Month = "Jul", Sales = 48, Profit = 42, Expenses = 39});
            salesreport.Add(new SalesReport { Month = "Aug", Sales = 65, Profit = 58, Expenses = 36});
            salesreport.Add(new SalesReport { Month = "Sep", Sales = 45, Profit = 31, Expenses = 32});
            salesreport.Add(new SalesReport { Month = "Oct", Sales = 80, Profit = 71, Expenses = 40});
            salesreport.Add(new SalesReport { Month = "Nov", Sales = 25, Profit = 10, Expenses = 22});
            salesreport.Add(new SalesReport { Month = "Dec", Sales = 75, Profit = 82, Expenses = 74});
            return salesreport;
        }
        public static List<TotalOrders> TotalOrders()
        {
            var totalorders = new List<TotalOrders>();
            totalorders.Add( new TotalOrders { CircularRadialLabel = "Orders", Value = 92});
            return  totalorders;
        }
        public static List<WebsiteDesign> GetWebsiteDesign() {
           var websitedesign = new List<WebsiteDesign> ();
           websitedesign.Add( new WebsiteDesign { Series = "1", Projects = 120, });
           websitedesign.Add( new WebsiteDesign { Series = "2", Projects = 200, });
           websitedesign.Add( new WebsiteDesign { Series = "3", Projects = 150, });
           websitedesign.Add( new WebsiteDesign { Series = "4", Projects = 300, });
           websitedesign.Add( new WebsiteDesign { Series = "5", Projects = 250, });
           websitedesign.Add( new WebsiteDesign { Series = "6", Projects = 350, });
           websitedesign.Add( new WebsiteDesign { Series = "7", Projects = 400, });
           websitedesign.Add( new WebsiteDesign { Series = "8", Projects = 450, });
           websitedesign.Add( new WebsiteDesign { Series = "9", Projects = 500, });
           websitedesign.Add( new WebsiteDesign { Series = "10", Projects = 550, });
           websitedesign.Add( new WebsiteDesign { Series = "11", Projects = 600, });
           websitedesign.Add( new WebsiteDesign { Series = "12", Projects = 650, });
           websitedesign.Add( new WebsiteDesign { Series = "13", Projects = 700, });
           websitedesign.Add( new WebsiteDesign { Series = "14", Projects = 750, });
           websitedesign.Add( new WebsiteDesign { Series = "15", Projects = 800, });
           websitedesign.Add( new WebsiteDesign { Series = "16", Projects = 850, });
           websitedesign.Add( new WebsiteDesign { Series = "17", Projects = 900, });
           websitedesign.Add( new WebsiteDesign { Series = "18", Projects = 950, });
           websitedesign.Add( new WebsiteDesign { Series = "19", Projects = 1000, });
           websitedesign.Add( new WebsiteDesign { Series = "20", Projects = 1050, });
           websitedesign.Add( new WebsiteDesign { Series = "21", Projects = 1100, });
           websitedesign.Add( new WebsiteDesign { Series = "22", Projects = 1150, });
           websitedesign.Add( new WebsiteDesign { Series = "23", Projects = 1200, });
           websitedesign.Add( new WebsiteDesign { Series = "24", Projects = 1250, });
           websitedesign.Add( new WebsiteDesign { Series = "25", Projects = 1300, });
           websitedesign.Add( new WebsiteDesign { Series = "26", Projects = 1350, });
           websitedesign.Add( new WebsiteDesign { Series = "27", Projects = 1400, });
           websitedesign.Add( new WebsiteDesign { Series = "28", Projects = 1450, });
           websitedesign.Add( new WebsiteDesign { Series = "29", Projects = 1500, });
           websitedesign.Add( new WebsiteDesign { Series = "30", Projects = 1542, });
            return websitedesign;
        }
        private List<EcommerceTable> EcommerceOrdersData = new List<EcommerceTable>()
        {
            new EcommerceTable {
                Id=1,
                OrderId="#SPK781",
                Customer="../assets/images/faces/15.jpg",
                CustomerName="Priceton Gray",
                Date="Mar 18,2024",
                Amount="$2,145.90",
                statusclass="bg-success-transparent",
                Status="Paid",
            },
            new EcommerceTable {
                Id=2,
                OrderId="#SPK782",
                Customer="../assets/images/faces/4.jpg",
                CustomerName="Elsa Urena",
                Date="Mar 20,2024",
                Amount="$2,145.90",
                statusclass="bg-danger-transparent",
                Status="UnPaid",
            },
            new EcommerceTable {
                Id=3,
                OrderId="#SPK783",
                Customer="../assets/images/faces/5.jpg",
                CustomerName="Gloria",
                Date="Mar 24,2024",
                Amount="$2,145.90",
                statusclass="bg-success-transparent",
                Status="Paid",
            },
            new EcommerceTable {
                Id=4,
                OrderId="#SPK784",
                Customer="../assets/images/faces/6.jpg",
                CustomerName="Priya",
                Date="Mar 25,2024",
                Amount="$2,145.90",
                statusclass="bg-warning-transparent",
                Status="Pending",
            },
            new EcommerceTable {
                Id=5,
                OrderId="#SPK785",
                Customer="../assets/images/faces/11.jpg",
                CustomerName="Adam Smith",
                Date="Mar 18,2024",
                Amount="$2,145.90",
                statusclass="bg-danger-transparent",
                Status="UnPaid",
            },
        };
        private List<EcommerceTable> EcommerceProductsData = new List<EcommerceTable>()
        {
            new EcommerceTable {
                Id=1,
                OrderId="#1547988",
                Product="../assets/images/ecommerce/png/12.png",
                ProductName="Sweater Coat",
                Category="Women's wear",
                Discount="40%",
                Amount="$241.08",
                statusclass="bg-success-transparent",
                Status="Published",
                Date="15-05-2024",
            },
            new EcommerceTable {
                Id=2,
                OrderId="#1415023",
                Product="../assets/images/ecommerce/png/6.png",
                ProductName="Cushion Chair",
                Category="Furniture",
                Discount="30%",
                Amount="$1,489.00",
                statusclass="bg-warning-transparent",
                Status="Pending",
                Date="20-05-2024",
            },
            new EcommerceTable {
                Id=3,
                OrderId="#4578162",
                Product="../assets/images/ecommerce/png/23.png",
                ProductName="Smart Watch",
                Category="Gadgets",
                Discount="10%",
                Amount="$2,457.08",
                statusclass="bg-info-transparent",
                Status="Saved as Draft",
                Date="06-02-2024",
            },
            new EcommerceTable {
                Id=4,
                OrderId="#4578954",
                Product="../assets/images/ecommerce/png/32.png",
                ProductName="Alarm Clock",
                Category="Home Decor",
                Discount="20%",
                Amount="$359.99",
                statusclass="bg-success-transparent",
                Status="Published",
                Date="26-01-2024",
            },
            new EcommerceTable {
                Id=5,
                OrderId="#8745814",
                Product="../assets/images/ecommerce/png/28.png",
                ProductName="Running Shoes",
                Category="Athletic Footwear",
                Discount="0%",
                Amount="$568.87",
                statusclass="bg-success-transparent",
                Status="Published",
                Date="24-03-2024",
            },
        };
        private List<ProductList> EcommerceProductListData = new List<ProductList>()
        {
            new ProductList {Id=1, Product="../assets/images/ecommerce/png/6.png", Productsize="avatar-lg me-3 ",ProductTitle="Chair with Cushion", Category="Furniture",Amount="$124",Sales="260 Sales"},
            new ProductList {Id=2, Product="../assets/images/ecommerce/png/7.png", Productsize="avatar-lg me-3 ",ProductTitle="Hand Bag", Category="Accessories",Amount="$564",Sales="181 Sales"},
            new ProductList {Id=3, Product="../assets/images/ecommerce/png/28.png", Productsize="avatar-lg me-3 ",ProductTitle="Sneakers", Category="Sports",Amount="$964",Sales="134 Sales"},
            new ProductList {Id=4, Product="../assets/images/ecommerce/png/11.png", Productsize="avatar-lg me-3 ",ProductTitle="Ron Hoodie", Category="Fashion",Amount="$769",Sales="127 Sales"},
            new ProductList {Id=5, Product="../assets/images/ecommerce/png/23.png", Productsize="avatar-lg me-3 ",ProductTitle="Smart Watch", Category="Electronics",Amount="$999",Sales="108 Sales"},
        }; 
        private List<ProductActivity> EcommerceProductActivityData = new List<ProductActivity>()
        {
            new ProductActivity {Id=1,IconSize="avatar-sm me-3 ",Iconclass="bg-primary",Icon="ri-shopping-cart-line",Title="New Order - #12345",Desc="2 items purchased by John Doe",Duration="3 hrs ago",},
            new ProductActivity {Id=2,IconSize="avatar-sm me-3 ",Iconclass="bg-success",Icon="ri-checkbox-circle-line fs-14",Title="Order Shipped - #12345",Desc="Shipped via FedEx",Duration="1 day ago",},
            new ProductActivity {Id=3,IconSize="avatar-sm me-3 ",Iconclass="bg-primary1",Icon="ri-add-circle-line fs-14",Title=" Added New Products",Desc="New items added in Fashions",Duration="12 days ago",ChildContent="<a href='javascript:void(0);' class='avatar avatar-sm bg-gray-200 me-1'><img src='../assets/images/ecommerce/png/7.png' alt=''></a><a href='javascript:void(0);' class='avatar avatar-sm bg-gray-200'><img src='../assets/images/ecommerce/png/12.png' alt=''></a>"},
            new ProductActivity {Id=4,IconSize="avatar-sm me-3 ",Iconclass="bg-danger",Icon="ri-heart-3-line fs-14",Title="Product Favorited - iPhone 12 Pro",Desc="Added to favorites by Jane Smith",Duration="2 days ago",},
            new ProductActivity {Id=5,IconSize="avatar-sm me-3 ",Iconclass="bg-warning",Icon="ri-star-line fs-14",Title="Product Rated - Samsung Galaxy S21",Desc="Rated 4.5 stars by John Doe",Duration="3 days ago",},
            new ProductActivity {Id=6,IconSize="avatar-sm me-3 ",Iconclass="bg-info",Icon="ri-price-tag-3-line fs-14",Title="Product Discount - Nike Air Max",Desc="Discounted price applied",Duration="4 days ago",},
            new ProductActivity {Id=6,IconSize="avatar-sm me-3 ",Iconclass="bg-secondary",Icon="ri-chat-1-line fs-14",Title="Customer Inquiry - Order ID: #12346",Desc="Inquiry received from customer",Duration="5 days ago",},
        };     
        private List<Payments> EcommerceProductPaymentsData = new List<Payments>()
        {
            new Payments {Id=1,Icon="ri-bank-card-line",Iconclass="bg-primary3-transparent",Title="Credit Card",Percentage="25%"},
            new Payments {Id=2,Icon="ri-paypal-line",Iconclass="bg-primary2-transparent",Title="PayPal",Percentage="20%"},
            new Payments {Id=3,Icon="ri-visa-line",Iconclass="bg-primary1-transparent",Title="VISA",Percentage="15%"},
            new Payments {Id=4,Icon="ri-apple-line",Iconclass="bg-info-transparent",Title="Apple Pay",Percentage="10%"},
            new Payments {Id=5,Icon="ri-google-line",Iconclass="bg-secondary-transparent",Title="Google Pay",Percentage="10%"},
        }; 
        private List<TrafficSources> EcommerceProductSourcesData = new List<TrafficSources>()
        {
            new TrafficSources {Id=1,Icon="ri-chrome-line",Iconclass="bg-primary3-transparent",Title="Chrome",Progressbg="bg-primary3",Percentage="78",Value="15,248",IsIncreased=true},
            new TrafficSources {Id=1,Icon="ri-safari-line",Iconclass="bg-primary2-transparent",Title="Safari",Progressbg="bg-primary2",Percentage="50",Value="22,945",IsIncreased=true},
            new TrafficSources {Id=1,Icon="ri-opera-line",Iconclass="bg-primary1-transparent",Title="Opera",Progressbg="bg-primary1",Percentage="62",Value="32,453",IsIncreased=false},
            new TrafficSources {Id=1,Icon="ri-edge-line",Iconclass="bg-primary-transparent",Title="Edge",Progressbg="bg-primary",Percentage="45",Value="9,886",IsIncreased=true},
        };

        public List<MainCard> GetEcommerceMainCard() => EcommerceCardData;
        public List<EcommerceTable> GetEcommerceOrders() => EcommerceOrdersData;
        public List<EcommerceTable> GetEcommerceProducts() => EcommerceProductsData;
        public List<ProductList> GetEcommerceProductsList() => EcommerceProductListData;
        public List<ProductActivity> GetEcommerceProductsActivity() => EcommerceProductActivityData;
        public List<Payments> GetEcommerceProductsPayments() => EcommerceProductPaymentsData;
        public List<TrafficSources> GetEcommerceProductsSources() => EcommerceProductSourcesData;

        
        public TableText[] OrdersHeaders = new TableText[]
        {
            new TableText { Title = "Order ID" },
            new TableText { Title = "Customer" },
            new TableText { Title = "Date" },
            new TableText { Title = "Amount" },
            new TableText { Title = "Status" },
        };
        public TableText[] GetOrdersHeadersData() => OrdersHeaders;
        public TableText[] ProductsHeaders = new TableText[]
        {
            new TableText { Title = "Product ID" },
            new TableText { Title = "Product Name" },
            new TableText { Title = "Category" },
            new TableText { Title = "% Discount" },
            new TableText { Title = "Price" },
            new TableText { Title = "Status" },
            new TableText { Title = "Added Date" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetProductsHeadersData() => ProductsHeaders;
        public TableText[] SourcesHeaders = new TableText[]
        {
            new TableText { Title = "Browser" },
            new TableText { Title = "Traffic" },
            new TableText { Title = "Sessions" },
        };
        public TableText[] GetSourcesHeadersData() => SourcesHeaders;
    }
}