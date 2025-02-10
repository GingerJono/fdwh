using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Index1
{
    public class Index1Service
    {
        private List<MainCard> MainCardData = new List<MainCard>()
        {
            new MainCard {
                id = 1,
                title = "Total Products",
                icon = "ti ti-shopping-cart",
                iconclass ="bg-primary",
                price = "854" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="2.56%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 2,
                title = "Total Users",
                icon = "ti ti-users",
                iconclass ="bg-primary1",
                price = "31,876" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="0.34%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 3,
                title = "Total Revenue",
                icon = "ti ti-currency-dollar",
                iconclass ="bg-primary2",
                price = "$34,241" ,
                status ="Increased ",
                statusclass ="text-success",
                statusdata ="7.66%",
                statusicon ="ti ti-arrow-narrow-up",
                IsRounded=true,
                MainBgImg=true,
            },
            new MainCard {
                id = 4,
                title = "Total Sales",
                icon = "ti ti-chart-bar",
                iconclass ="bg-primary3",
                price = "1,76,586" ,
                status ="Decreased",
                statusclass ="text-danger",
                statusdata ="0.74%",
                statusicon ="ti ti-arrow-narrow-down",
                IsRounded=true,
                MainBgImg=true,
            },

        };

        public List<MainCard> GetMainCard()
        {
            return MainCardData;
        }

        // Sales Overview Start //
        public static List<SalesOverview> GetSalesOverview()
        {
            var salesoverview = new List<SalesOverview>();
            salesoverview.Add(new SalesOverview { Month = "Jan", growth = 140, profit = 180, sales = 200 });
            salesoverview.Add(new SalesOverview { Month = "Feb", growth = 120, profit = 620, sales = 330 });
            salesoverview.Add(new SalesOverview { Month = "Mar", growth = 190, profit = 476, sales = 110 });
            salesoverview.Add(new SalesOverview { Month = "Apr", growth = 364, profit = 220, sales = 130 });
            salesoverview.Add(new SalesOverview { Month = "May", growth = 140, profit = 520, sales = 380 });
            salesoverview.Add(new SalesOverview { Month = "Jun", growth = 230, profit = 680, sales = 420 });
            salesoverview.Add(new SalesOverview { Month = "Jul", growth = 166, profit = 435, sales = 580 });
            salesoverview.Add(new SalesOverview { Month = "Aug", growth = 340, profit = 515, sales = 335 });
            salesoverview.Add(new SalesOverview { Month = "Sep", growth = 260, profit = 638, sales = 375 });
            salesoverview.Add(new SalesOverview { Month = "Oct", growth = 260, profit = 454, sales = 638 });
            salesoverview.Add(new SalesOverview { Month = "Nov", growth = 120, profit = 525, sales = 454 });
            salesoverview.Add(new SalesOverview { Month = "Dec", growth = 320, profit = 230, sales = 480 });
            return salesoverview;
        }
        // Sales Overview End //

        //  Total Orders Start //
        public static List<TotalOrders> GetTotalOrders()
        {
            var TotalOrderss = new List<TotalOrders>();
            TotalOrderss.Add(new TotalOrders { Source = "Delivered", SourceValue = 1754 });
            TotalOrderss.Add(new TotalOrders { Source = "Cancelled", SourceValue = 634 });
            TotalOrderss.Add(new TotalOrders { Source = "Pending", SourceValue = 878 });
            TotalOrderss.Add(new TotalOrders { Source = "Returned", SourceValue = 470 });

            return TotalOrderss;
        }
        //  Total Orders END //

        // Sales Statistics Start //
        public static List<SalesStatistics> GetSalesStatistics()
        {
            var Statistics = new List<SalesStatistics>();
            Statistics.Add(new SalesStatistics { Week = "Mon", Total = 80, ThisYear = 55, LastYear = 71 });
            Statistics.Add(new SalesStatistics { Week = "Tue", Total = 90, ThisYear = 25, LastYear = 97 });
            Statistics.Add(new SalesStatistics { Week = "Wed", Total = 59, ThisYear = 25, LastYear = 72 });
            Statistics.Add(new SalesStatistics { Week = "Thu", Total = 86, ThisYear = 165, LastYear = 52 });
            Statistics.Add(new SalesStatistics { Week = "Fri", Total = 120, ThisYear = 75, LastYear = 73 });
            Statistics.Add(new SalesStatistics { Week = "Sat", Total = 165, ThisYear = 64, LastYear = 51 });
            Statistics.Add(new SalesStatistics { Week = "Sun", Total = 115, ThisYear = 70, LastYear = 71 });
            return Statistics;
        }

        // Sales Statistics End //

        private List<Index1Table> CategoryData = new List<Index1Table>()
        {
            new Index1Table {
                id = 1,
                categoryclass = "one",
                title = "Clothing",
                price ="31,245",
                Percentage = "25" ,
                badge ="0.45 ",
                badgeclass ="bg-success",
            },
            new Index1Table {
                id = 2,
                categoryclass = "two",
                title = "Electronics",
                price ="29,553",
                Percentage = "16" ,
                badge ="0.27",
                badgeclass ="bg-warning",
            },
            new Index1Table {
                id = 3,
                categoryclass = "three",
                title = "Grocery",
                price ="24,577",
                Percentage = "22" ,
                badge ="0.63",
                badgeclass ="bg-secondary",
            },
            new Index1Table {
                id = 4,
                categoryclass = "four",
                title = "Automobiles",
                price ="19,278",
                Percentage = "18" ,
                badge ="1.14",
                badgeclass ="bg-primary1",
            },
            new Index1Table {
                id = 5,
                categoryclass = "five",
                title = "others",
                price ="15,934",
                Percentage = "15" ,
                badge ="3.87",
                badgeclass ="bg-primary",
            },
        };

        public List<Index1Table> GetCategory()
        {
            return CategoryData;
        }
        private List<Index1Table> TransactionsData = new List<Index1Table>()
        {
            new Index1Table {id = 1,img = "../assets/images/ecommerce/jpg/4.jpg",title = "SwiftBuds",price ="39.99",badge ="Success",badgeclass ="primary",},
            new Index1Table {id = 2,img = "../assets/images/ecommerce/jpg/6.jpg",title = "CozyCloud Pillow",price ="19.95",badge ="Pending",badgeclass ="primary1",},
            new Index1Table {id = 3,img = "../assets/images/ecommerce/jpg/3.jpg",title = "AquaGrip Bottle",price ="9.99",badge ="Failed",badgeclass ="primary2",},
            new Index1Table {id = 4,img = "../assets/images/ecommerce/jpg/1.jpg",title = "GlowLite Lamp",price ="24.99",badge ="Success",badgeclass ="primary3",},
            new Index1Table {id = 5,img = "../assets/images/ecommerce/jpg/2.jpg",title = "Bitvitamin",price ="26.45",badge ="Success",badgeclass ="secondary",},
            new Index1Table {id = 5,img = "../assets/images/ecommerce/jpg/5.jpg",title = "FitTrack",price ="49.95",badge ="Success",badgeclass ="warning",},
        };

        public List<Index1Table> GetTransactions()
        {
            return TransactionsData;
        }
        
        private List<ActivityCard> ActivityData = new List<ActivityCard>()
        {
            new ActivityCard {ActivityUser = "John Doe",ActivityTime="12 Hrs",ActivityDesc="Updated the product description for <span class='text-primary fw-medium'>Widget X</span>."},
            new ActivityCard {ActivityUser = "Jane Smith",ActivityTime="4:32pm",ActivityDesc=" added a <span class='fw-medium text-dark'>new user</span> with username <span class='fw-medium text-primary1'>janesmith89.</span>"},
            new ActivityCard {ActivityUser = "Michael Brown",ActivityTime="11:45am",ActivityDesc="Changed the status of order <a href='javascript:void(0);' class='fw-medium text-dark text-decoration-underline'>#12345</a> to <span class='fw-medium text-primary2'>Shipped.</span>"},
            new ActivityCard {ActivityUser = "David Wilson",ActivityTime="9:27am",ActivityDesc="added <span class='fw-medium text-primary3'>John Smith</span> to academy group this day."},
            new ActivityCard {ActivityUser = "Robert Jackson",ActivityTime="8:56pm",ActivityDesc="added a comment to the task <span class='fw-medium text-secondary'>Update website layout.</span>"},
        };

        public List<ActivityCard> GetActivity()
        {
            return ActivityData;
        }
      
        private List<Index1Table> OrdersData = new List<Index1Table>()
        {
            new Index1Table 
            {
                id = 1,
                Selected = true,
                img = "../assets/images/faces/1.jpg",
                customer = "Elena Smith",
                email = "elenasmith387@gmail.com",
                Product = "All-Purpose Cleaner",
                Quantity = "3",
                price = "$9.99",
                badge = "In Progress",
                badgeclass = "bg-primary-transparent",
                date = "03, Sep 2024",
            },
            new Index1Table 
            {
                id = 2,
                Selected = false,
                img = "../assets/images/faces/12.jpg",
                customer = "Nelson Gold",
                email = "noahrussell556@gmail.com",
                Product = "Kitchen Knife Set",
                Quantity = "4",
                price = "$49.99",
                badge = "Pending",
                badgeclass = "bg-primary1-transparent",
                date = "26,Jul 2024",
            },
            new Index1Table 
            {
                id = 3,
                Selected = true,
                img = "../assets/images/faces/6.jpg",
                customer = "Grace Mitchell",
                email = "gracemitchell79@gmail.com",
                Product = "Velvet Throw Blanket",
                Quantity = "2",
                price = "$29.99",
                badge = "Success",
                badgeclass = "bg-primary2-transparent",
                date = "12,May 2024",
            },
            new Index1Table 
            {
                id = 4,
                Selected = true,
                img = "../assets/images/faces/14.jpg",
                customer = "Spencer Robin",
                email = "leophillips124@gmail.com",
                Product = "Aromatherapy Diffuser",
                Quantity = "4",
                price = "$19.99",
                badge = "Success",
                badgeclass = "bg-primary2-transparent",
                date = "15,Aug 2024",
            },
            new Index1Table 
            {
                id = 5,
                Selected = false,
                img = "../assets/images/faces/3.jpg",
                customer = "Chloe Lewis",
                email = "chloelewis67@gmail.com",
                Product = "Insulated Water Bottle",
                Quantity = "2",
                price = "$14.99",
                badge = "Pending",
                badgeclass = "bg-primary3-transparent",
                date = "11,Oct 2024",
            },
        };

        public List<Index1Table> GetOrders()
        {
            return OrdersData;
        }
      
        private List<CountryCardModel> CountryData = new List<CountryCardModel>()
        {
            new CountryCardModel{ id = 1,img = "../assets/images/flags/us_flag.jpg",title = "United States",value = "31,672",color = "bg-primary",percent = "90",},
            new CountryCardModel{ id = 2,img = "../assets/images/flags/italy_flag.jpg",title = "Italy",value = "29,557",color = "bg-primary1",percent = "85",},
            new CountryCardModel{ id = 3,img = "../assets/images/flags/spain_flag.jpg",title = "Spain",value = "24,562",color = "bg-primary2",percent = "80",},
            new CountryCardModel{ id = 4,img = "../assets/images/flags/uae_flag.jpg",title = "Uae",value = "21,532",color = "bg-primary3",percent = "75",},
            new CountryCardModel{ id = 5,img = "../assets/images/flags/argentina_flag.jpg",title = "Argentina",value = "18,753",color = "bg-secondary",percent = "70",},
            new CountryCardModel{ id = 6,img = "../assets/images/flags/china_flag.jpg",title = "China",value = "12,342",color = "bg-info",percent = "65",},
            new CountryCardModel{ id = 7,img = "../assets/images/flags/french_flag.jpg",title = "French",value = "15,533",color = "bg-warning",percent = "60",},
           
        };

        public List<CountryCardModel> GetCountryData()
        {
            return CountryData;
        }
        
        
        //  Line Chart  Start //
        public static List<LineGraphChart> GetLineGraphChart(OverallStats overallStats)
        {
            var linegraphchart = new List<LineGraphChart>();
            var valuesMap = new Dictionary<string, List<decimal>>
            {
                { "Total Expenses", new List<decimal> { 0, 30, 10, 35, 26, 31, 14, 22, 40, 12 } },
                { "General Leads", new List<decimal> { 0, 20, 15, 25, 15, 25, 6, 25, 32, 15 } },
                { "Churn Rate", new List<decimal> { 0, 10, 30, 12, 16, 25, 4, 35, 26, 15 } },
                { "New Users", new List<decimal> { 0, 12, 19, 26, 10, 18, 8, 17, 35, 14 } },
                { "Returning Users", new List<decimal> { 0, 12, 19, 17, 35, 14, 26, 10, 18, 8 } }
            };
            var title = overallStats?.Title;
            if (!string.IsNullOrEmpty(title) && valuesMap.ContainsKey(title))
            {
                var values = valuesMap[title];
                for (int i = 0; i < values.Count; i++)
                {
                    linegraphchart.Add(new LineGraphChart { Series = i + 1, Value = values[i] });
                }
            }
            return linegraphchart;
        }

        //  Expenses Line Chart End //

        private List<OverallStats> OverallStatsData = new List<OverallStats>()
        {
            new OverallStats{ Id = 1, Title="Total Expenses",TotalValue="$134,032",Percentage="0.45%",IsIncreased=true},
            new OverallStats{ Id = 1, Title="General Leads",TotalValue="74,354",Percentage="3.84%",IsIncreased=false},
            new OverallStats{ Id = 1, Title="Churn Rate",TotalValue="6.02%",Percentage="0.72%",IsIncreased=true},
            new OverallStats{ Id = 1, Title="New Users",TotalValue="7,893",Percentage="11.05%",IsIncreased=true},
            new OverallStats{ Id = 1, Title="Returning Users",TotalValue="3,258",Percentage="1.69%",IsIncreased=true},
           
        };

        public List<OverallStats> GetOverallStatistics()
        {
            return OverallStatsData;
        }
        public TableText[] TransactionsHeaderData = new TableText[]
        {
            new TableText { Title = "Product" },
            new TableText { Title = "Price" },
            new TableText { Title = "Status" },
        };
        public TableText[] GetTransactionsHeaderData() => TransactionsHeaderData;
        public TableText[] OrdersHeaders = new TableText[]
        {
            new TableText { Title = "Customer" },
            new TableText { Title = "Product" },
            new TableText { Title = "Quantity" },
            new TableText { Title = "Amount" },
            new TableText { Title = "Status" },
            new TableText { Title = "Date Ordered" },
            new TableText { Title = "Actions" },
        };
        public TableText[] GetOrdersHeadersData() => OrdersHeaders;

    }
}