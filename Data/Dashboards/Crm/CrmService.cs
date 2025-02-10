using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Crm
{
    public class CrmService
    {
        private List<MainCard> CrmcardData = new List<MainCard>()
        {
            new MainCard{ id = 1,color = "primary",title = "Total Leads",svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",price = "1,1125",percentage = "2.5" ,IsIncreased=true},
            new MainCard{ id = 1,color = "primary1",title = "Conversion Rate",svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M205.66,61.64l-144,144a8,8,0,0,1-11.32-11.32l144-144a8,8,0,0,1,11.32,11.31ZM50.54,101.44a36,36,0,0,1,50.92-50.91h0a36,36,0,0,1-50.92,50.91ZM56,76A20,20,0,1,0,90.14,61.84h0A20,20,0,0,0,56,76ZM216,180a36,36,0,1,1-10.54-25.46h0A35.76,35.76,0,0,1,216,180Zm-16,0a20,20,0,1,0-5.86,14.14A19.87,19.87,0,0,0,200,180Z'></path></svg>",price = "15.8%",percentage = "2.5" ,IsIncreased=false},
            new MainCard{ id = 1,color = "primary2",title = "Tasks Pending",svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M173.66,98.34a8,8,0,0,1,0,11.32l-56,56a8,8,0,0,1-11.32,0l-24-24a8,8,0,0,1,11.32-11.32L112,148.69l50.34-50.35A8,8,0,0,1,173.66,98.34ZM232,128A104,104,0,1,1,128,24,104.11,104.11,0,0,1,232,128Zm-16,0a88,88,0,1,0-88,88A88.1,88.1,0,0,0,216,128Z'></path></svg>",price = "$3,132",percentage = "2.5" ,IsIncreased=true},
            new MainCard{ id = 1,color = "primary3",title = "Sales Pipeline",svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M232,208a8,8,0,0,1-8,8H32a8,8,0,0,1-8-8V48a8,8,0,0,1,16,0V156.69l50.34-50.35a8,8,0,0,1,11.32,0L128,132.69,180.69,80H160a8,8,0,0,1,0-16h40a8,8,0,0,1,8,8v40a8,8,0,0,1-16,0V91.31l-58.34,58.35a8,8,0,0,1-11.32,0L96,123.31l-56,56V200H224A8,8,0,0,1,232,208Z'></path></svg>",price = "$3,132",percentage = "2.5" ,IsIncreased=true},
            new MainCard{ id = 1,color = "secondary",title = "New Contacts",svg="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M256,136a8,8,0,0,1-8,8H232v16a8,8,0,0,1-16,0V144H200a8,8,0,0,1,0-16h16V112a8,8,0,0,1,16,0v16h16A8,8,0,0,1,256,136Zm-57.87,58.85a8,8,0,0,1-12.26,10.3C165.75,181.19,138.09,168,108,168s-57.75,13.19-77.87,37.15a8,8,0,0,1-12.25-10.3c14.94-17.78,33.52-30.41,54.17-37.17a68,68,0,1,1,71.9,0C164.6,164.44,183.18,177.07,198.13,194.85ZM108,152a52,52,0,1,0-52-52A52.06,52.06,0,0,0,108,152Z'></path></svg>",price = "968",percentage = "2.5" ,IsIncreased=false},
        };
        public List<MainCard> GetCrmcardData() => CrmcardData;
        public static List<Profit> GetProfitData() {
            var profit = new List<Profit>();
            profit.Add(new Profit { Series = 1, Profitvalue = 35, });
            profit.Add(new Profit { Series = 2, Profitvalue = 36, });
            profit.Add(new Profit { Series = 3, Profitvalue = 22, });
            profit.Add(new Profit { Series = 4, Profitvalue = 44, });
            profit.Add(new Profit { Series = 5, Profitvalue = 48, });
            profit.Add(new Profit { Series = 6, Profitvalue = 37, });
            profit.Add(new Profit { Series = 7, Profitvalue = 36, });
            profit.Add(new Profit { Series = 8, Profitvalue = 26, });
            profit.Add(new Profit { Series = 9, Profitvalue = 27, });
            profit.Add(new Profit { Series = 10, Profitvalue = 33, });
            profit.Add(new Profit { Series = 11, Profitvalue = 32, });
            profit.Add(new Profit { Series = 12, Profitvalue = 36, });
            profit.Add(new Profit { Series = 13, Profitvalue = 55, });
            profit.Add(new Profit { Series = 14, Profitvalue = 53, });
            profit.Add(new Profit { Series = 15, Profitvalue = 46, });
            profit.Add(new Profit { Series = 16, Profitvalue = 40, });
            profit.Add(new Profit { Series = 17, Profitvalue = 45, });
            profit.Add(new Profit { Series = 18, Profitvalue = 38, });
            profit.Add(new Profit { Series = 19, Profitvalue = 46, });
            profit.Add(new Profit { Series = 20, Profitvalue = 37, });
            profit.Add(new Profit { Series = 21, Profitvalue = 22, });
            profit.Add(new Profit { Series = 22, Profitvalue = 34, });
            profit.Add(new Profit { Series = 23, Profitvalue = 40, });
            profit.Add(new Profit { Series = 24, Profitvalue = 44, });
            profit.Add(new Profit { Series = 25, Profitvalue = 28, });
            profit.Add(new Profit { Series = 26, Profitvalue = 33, });
            profit.Add(new Profit { Series = 27, Profitvalue = 34, });
            profit.Add(new Profit { Series = 28, Profitvalue = 36, });
            profit.Add(new Profit { Series = 29, Profitvalue = 58, });
            profit.Add(new Profit { Series = 30, Profitvalue = 56, });
            profit.Add(new Profit { Series = 31, Profitvalue = 45, });
            profit.Add(new Profit { Series = 32, Profitvalue = 34, });
            profit.Add(new Profit { Series = 33, Profitvalue = 33, });
            profit.Add(new Profit { Series = 34, Profitvalue = 22, });
            profit.Add(new Profit { Series = 35, Profitvalue = 45, });
            profit.Add(new Profit { Series = 36, Profitvalue = 50, });
            return profit;
        }
        public static List<Revenue> GetRevenueData() {
            var revenue = new List<Revenue>();
            revenue.Add(new Revenue { Series = 1, revenuevalue = 14, });
            revenue.Add(new Revenue { Series = 2, revenuevalue = 12, });
            revenue.Add(new Revenue { Series = 3, revenuevalue = 17, });
            revenue.Add(new Revenue { Series = 4, revenuevalue = 16, });
            revenue.Add(new Revenue { Series = 5, revenuevalue = 18, });
            revenue.Add(new Revenue { Series = 6, revenuevalue = 15, });
            revenue.Add(new Revenue { Series = 7, revenuevalue = 18, });
            revenue.Add(new Revenue { Series = 8, revenuevalue = 23, });
            revenue.Add(new Revenue { Series = 9, revenuevalue = 28, });
            revenue.Add(new Revenue { Series = 10, revenuevalue = 44, });
            revenue.Add(new Revenue { Series = 11, revenuevalue = 40, });
            revenue.Add(new Revenue { Series = 12, revenuevalue = 34, });
            revenue.Add(new Revenue { Series = 13, revenuevalue = 34, });
            revenue.Add(new Revenue { Series = 14, revenuevalue = 22, });
            revenue.Add(new Revenue { Series = 15, revenuevalue = 37, });
            revenue.Add(new Revenue { Series = 16, revenuevalue = 46, });
            revenue.Add(new Revenue { Series = 17, revenuevalue = 21, });
            revenue.Add(new Revenue { Series = 18, revenuevalue = 35, });
            revenue.Add(new Revenue { Series = 19, revenuevalue = 40, });
            revenue.Add(new Revenue { Series = 20, revenuevalue = 34, });
            revenue.Add(new Revenue { Series = 21, revenuevalue = 46, });
            revenue.Add(new Revenue { Series = 22, revenuevalue = 55, });
            revenue.Add(new Revenue { Series = 23, revenuevalue = 62, });
            revenue.Add(new Revenue { Series = 24, revenuevalue = 55, });
            revenue.Add(new Revenue { Series = 25, revenuevalue = 23, });
            revenue.Add(new Revenue { Series = 26, revenuevalue = 20, });
            revenue.Add(new Revenue { Series = 27, revenuevalue = 22, });
            revenue.Add(new Revenue { Series = 28, revenuevalue = 33, });
            revenue.Add(new Revenue { Series = 29, revenuevalue = 35, });
            revenue.Add(new Revenue { Series = 30, revenuevalue = 23, });
            revenue.Add(new Revenue { Series = 31, revenuevalue = 15, });
            revenue.Add(new Revenue { Series = 32, revenuevalue = 16, });
            revenue.Add(new Revenue { Series = 33, revenuevalue = 17, });
            revenue.Add(new Revenue { Series = 34, revenuevalue = 12, });
            revenue.Add(new Revenue { Series = 35, revenuevalue = 14, });
            revenue.Add(new Revenue { Series = 36, revenuevalue = 23, });
            return revenue;
        }
        public static List<CRMOverview> GetCRMOverviewData() {
            var crmoverview = new List<CRMOverview>();
            crmoverview.Add(new CRMOverview { Month = "Jan", Income = 100, Revenue = 200, Profit = 740});
            crmoverview.Add(new CRMOverview { Month = "Feb", Income = 210, Revenue = 530, Profit = 590});
            crmoverview.Add(new CRMOverview { Month = "Mar", Income = 180, Revenue = 110, Profit = 320});
            crmoverview.Add(new CRMOverview { Month = "Apr", Income = 454, Revenue = 130, Profit = 730});
            crmoverview.Add(new CRMOverview { Month = "May", Income = 454, Revenue = 480, Profit = 340});
            crmoverview.Add(new CRMOverview { Month = "Jun", Income = 230, Revenue = 520, Profit = 580});
            crmoverview.Add(new CRMOverview { Month = "Jul", Income = 230, Revenue = 780, Profit = 890});
            crmoverview.Add(new CRMOverview { Month = "Aug", Income = 656, Revenue = 435, Profit = 654});
            crmoverview.Add(new CRMOverview { Month = "Sep", Income = 656, Revenue = 475, Profit = 410});
            crmoverview.Add(new CRMOverview { Month = "Oct", Income = 350, Revenue = 738, Profit = 638});
            crmoverview.Add(new CRMOverview { Month = "Nov", Income = 350, Revenue = 454, Profit = 230});
            crmoverview.Add(new CRMOverview { Month = "Dec", Income = 210, Revenue = 480, Profit = 675});
            return crmoverview;
        }
        public static List<Leads> GetLeadsData()
        {
            var leads = new List<Leads>();
            leads.Add(new Leads { Year = "2018", Value1 = 80,  Value2 = 20,  Value3 = 60, Value4 = 5  });
            leads.Add(new Leads { Year = "2019", Value1 = 50,  Value2 = 100, Value3 = 30, Value4 = 76 });
            leads.Add(new Leads { Year = "2020", Value1 = 100, Value2 = 20,  Value3 = 60, Value4 = 78 });
            leads.Add(new Leads { Year = "2021", Value1 = 40,  Value2 = 80,  Value3 = 30, Value4 = 13 });
            leads.Add(new Leads { Year = "2022", Value1 = 100, Value2 = 20,  Value3 = 60, Value4 = 43 });
            leads.Add(new Leads { Year = "2023", Value1 = 20,  Value2 = 80,  Value3 = 30, Value4 = 10 });
            return  leads;
        }
        private List<SalesProfits> CrmProfitData = new List<SalesProfits>()
        {
            new SalesProfits{ Id = 1, Icon="bx bx-wallet-alt", Color = "primary", Title = "Total Sales", Desc="10% Increases", Value = "12,345", Percentage = "80" },
            new SalesProfits{ Id = 2, Icon="bx bx-money-withdraw", Color = "secondary", Title = "Total Profit", Desc="12% Increases", Value = "9,345", Percentage = "75" },
            new SalesProfits{ Id = 3, Icon="bx bx-money-withdraw", Color = "primary1", Title = "Total Revenue", Desc="11% Decrease", Value = "9,345", Percentage = "78" },
            new SalesProfits{ Id = 4, Icon="bx bx-money-withdraw", Color = "primary2", Title = "Total loss", Desc="11% Decrease", Value = "11,345", Percentage = "68" },
        };
        public List<SalesProfits> GetCrmProfitData() => CrmProfitData;
        private List<TasksList> CrmTasksData= new List<TasksList>()
        {
            new TasksList{ Id = 1, Title = "Review Marketing Campaign Strategy",Status="Progress",Desc="Nemo enim ipsam voluptatem", Selected=false },
            new TasksList{ Id = 2, Title = "Update Client Database",Status="Completed",Desc="Eos dolor ea", Selected=true },
            new TasksList{ Id = 3, Title = "Prepare Monthly Sales Report",Status="Pending",Desc="Nonumy erat ipsum ut ipsum", Selected=false },
            new TasksList{ Id = 4, Title = "Schedule Team Meeting",Status="Completed",Desc="Nemo enim ipsam voluptatem", Selected=true },
            new TasksList{ Id = 5, Title = "Update User Database",Status="Progress",Desc="Eos dolor ea", Selected=false },
            new TasksList{ Id = 6, Title = "Respond to Customer Inquiries",Status="Completed",Desc="Sed labore ut sed", Selected=true },

            new TasksList{ Id = 7, Title = "Conduct Product Demo Sessions",Desc="Nonumy erat ipsum ut ipsum", Selected=false },
            new TasksList{ Id = 8, Title = "Organize Training Session",Desc="Consetetur et amet dolor", Selected=false },
            new TasksList{ Id = 9, Title = "Analyze Market Trends",Desc="Nonumy erat ipsum ut ipsum", Selected=false },
            new TasksList{ Id = 10, Title = "Coordinate with Logistics Department",Desc="Nonumy erat ipsum ut ipsum", Selected=false },
            new TasksList{ Id = 11, Title = "Meeting On Updation",Desc="Nonumy erat ipsum ut ipsum", Selected=false },
            new TasksList{ Id = 12, Title = "Plan Social Media Content Calendar",Desc="Accusam aliquyam ea sea", Selected=false },
        };
        public List<TasksList> GetCrmTasksData() => CrmTasksData;
        
        public Crmprofit crmprofit = new Crmprofit
        {
            Icon = "<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M230.33,141.06a24.43,24.43,0,0,0-21.24-4.23l-41.84,9.62A28,28,0,0,0,140,112H89.94a31.82,31.82,0,0,0-22.63,9.37L44.69,144H16A16,16,0,0,0,0,160v40a16,16,0,0,0,16,16H120a7.93,7.93,0,0,0,1.94-.24l64-16a6.94,6.94,0,0,0,1.19-.4L226,182.82l.44-.2a24.6,24.6,0,0,0,3.93-41.56ZM16,160H40v40H16Zm203.43,8.21-38,16.18L119,200H56V155.31l22.63-22.62A15.86,15.86,0,0,1,89.94,128H140a12,12,0,0,1,0,24H112a8,8,0,0,0,0,16h32a8.32,8.32,0,0,0,1.79-.2l67-15.41.31-.08a8.6,8.6,0,0,1,6.3,15.9ZM164,96a36,36,0,0,0,5.9-.48,36,36,0,1,0,28.22-47A36,36,0,1,0,164,96Zm60-12a20,20,0,1,1-20-20A20,20,0,0,1,224,84ZM164,40a20,20,0,0,1,19.25,14.61,36,36,0,0,0-15,24.93A20.42,20.42,0,0,1,164,80a20,20,0,0,1,0-40Z'></path></svg>",
            Cardclass = "primary2",
            Title = "Total Profit",
            Value = "37,566",
            Badge = "primary3 ",
            BadgeValue = "5.66%",
            IsIncreased = true
        };
        public Crmprofit GetcrmprofitData() => crmprofit;
        
        public TableText[] SalesTable = new TableText[]
        {
            new TableText { Title = "S.No." },
            new TableText { Title = "Representative" },
            new TableText { Title = "Deals Closed" },
            new TableText { Title = "Leads" },
            new TableText { Title = "Rate (%)" }
        };
        public TableText[] GetSalesTableData() => SalesTable;
        public List<SalesTable> SalesTables = new List<SalesTable>
        {

            new SalesTable { Id = 1,Representative="John Joe",RepresentativeImg="../assets/images/faces/11.jpg",Deals="15",Leads="100",Rate="15.0",IsIncreased=true },
            new SalesTable { Id = 2,Representative="Jane Smith",RepresentativeImg="../assets/images/faces/12.jpg",Deals="20",Leads="120",Rate="16.7",IsIncreased=false },
            new SalesTable { Id = 3,Representative="Michael Johnson",RepresentativeImg="../assets/images/faces/15.jpg",Deals="18",Leads="110",Rate="16.4",IsIncreased=true },
            new SalesTable { Id = 4,Representative="Emily Davis",RepresentativeImg="../assets/images/faces/13.jpg",Deals="22",Leads="130",Rate="16.9",IsIncreased=true },
            new SalesTable { Id = 5,Representative="Anna Garcia",RepresentativeImg="../assets/images/faces/1.jpg",Deals="17",Leads="105",Rate="16.2",IsIncreased=false },
            new SalesTable { Id = 6,Representative="Kiara Nousin",RepresentativeImg="../assets/images/faces/4.jpg",Deals="20",Leads="35",Rate="57%",IsIncreased=true },
        };
        public List<SalesTable> GetSalesTablesData() => SalesTables;
        public TableText[] LeadTable = new TableText[]
        {
            new TableText { Title = "S.No" },
            new TableText { Title = "Lead" },
            new TableText { Title = "Phone Number" },
            new TableText { Title = "Company Name" },
            new TableText { Title = "Status" },
            new TableText { Title = "Location" },
            new TableText { Title = "Date" },
            new TableText { Title = "Amount" },
            new TableText { Title = "Action" }
        };
        public TableText[] GetLeadHeaderData() => LeadTable;
        public List<LeadTable> LeadTables = new List<LeadTable>
        {

            new LeadTable { Id = 01, LeadImg="../assets/images/faces/2.jpg",LeadName="Sophia Sara",LeadEmail="sophiasara@gmail.com",Phone="+1(222) 547 6897",Company="Nova Solutions",Status="Won Lead",Statusclass="success",Location="Italy",Date="10-05-2024",Amount="2457"},
            new LeadTable { Id = 02, LeadImg="../assets/images/faces/12.jpg",LeadName="Simon Leo",LeadEmail="simonleo@gmail.com",Phone="+1(222) 987 9874",Company="Global Innovations Ltd.",Status="New Lead",Statusclass="primary",Location="Paris",Date="12-05-2024",Amount="14009"},
            new LeadTable { Id = 03, LeadImg="../assets/images/faces/14.jpg",LeadName="Hadley Kylin",LeadEmail="hadleykylin@gmail.com",Phone="+1(222) 654 6541",Company="Blue Enterprises",Status="New Lead",Statusclass="primary",Location="Japan",Date="14-05-2024",Amount="20000"},
            new LeadTable { Id = 04, LeadImg="../assets/images/faces/4.jpg",LeadName="Isha Bella",LeadEmail="ishabella@gmail.com",Phone="+1(222) 321 1232",Company="Silver Techns.",Status="Lost Lead",Statusclass="danger",Location="Califonia",Date="20-06-2024",Amount="24000"},
            new LeadTable { Id = 05, LeadImg="../assets/images/faces/3.jpg",LeadName="Red Siddique",LeadEmail="redsiddique@gmail.com",Phone="+1(222) 658 3256",Company="Omega Systems Ltd.",Status="New Lead",Statusclass="primary",Location="Brazil",Date="03-06-2024",Amount="35789"},
        };
        public List<LeadTable> GetLeadsTableData() => LeadTables;
    }
}