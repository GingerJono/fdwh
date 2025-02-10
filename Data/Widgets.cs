using CardModel;
namespace WidgetData
{
    public class WidgetElements {
        public decimal Id { get; set; }
        public string? MainClass { get; set; }
        public string? Icon { get; set; }
        public string? IconClass { get; set; }
        public string? Title { get; set; }
        public string? Value { get; set; }
        public bool IsIncreased { get; set; }
        public string? Percentage { get; set; }
    };
    public class WidgetsChart1 : ILineGraph {
        public decimal Series { get; set; }
        public decimal Value { get; set; }
    } ;
    public interface ILineGraph2
    {        
        public int Series { get; set; }
        public decimal ThisWeek { get; set; }
        public decimal LastWeek { get; set; }
    }
    public class WidgetsChart2 : ILineGraph2 {
        public int Series { get; set; }
        public decimal ThisWeek { get; set; }
        public decimal LastWeek { get; set; }
    } ;
    public class SalesStatistics {
        public string? Month { get; set; }
        public decimal ApplicationsValue { get; set; }
        public decimal ShortlistedValue { get; set; }
        public decimal RejectedValue { get; set; }
        public decimal OnHoldValue { get; set; }
    } ;
    public class CircleChart
    {
        public string? Source { get; set; }
        public int SourceValue { get; set; }
    }
    public class Learning {
        public string? Activity { get; set; }
        public decimal LastWeek { get; set; }
        public decimal Average { get; set; }
    } ; 
    public class Radialbarmultiple
    {
        public string? Fruits { get; set; }
        public decimal Value { get; set; }
    }
    public class SaleRevenue2 {
        public string? Month { get; set; }
        public decimal Sale2Value { get; set; }
        public decimal Refunds2Value { get; set; }
        public decimal Cancelled2Value { get; set; }
    } 
    public class MixedAll {
        public string? TEAMMixedValue { get; set; }
        public decimal TEAMAMixedValue { get; set; }
        public decimal TEAMBMixedValue { get; set; }
    } ;
    public class Ordersoverview
    {
        public string? Fruits { get; set; }
        public decimal Value { get; set; }
    }
    public class WidgetService {
        public static List<WidgetsChart1> GetWidgetsChart1(WidgetElements MainCard)
        {
            var WidgetsChart1 = new List<WidgetsChart1>();
            var sharedValues = new List<decimal> { 14, 48, 26, 36, 26, 75, 45, 20, 55 };
           var titles = new List<string>
            {
                "Total Sales","Total profit","Total Revenue","Total Income",
            };
            var title = MainCard?.Title;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    WidgetsChart1.Add(new WidgetsChart1 { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return WidgetsChart1;
        }
        private List<WidgetElements> WidgetsCard1Data = new List<WidgetElements>( )
        {
            new WidgetElements {Id=1,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass="primary",Title="Total Sales",Value="87,985",IsIncreased=true,Percentage="0.5"},
            new WidgetElements {Id=2,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M152,120H136V56h8a32,32,0,0,1,32,32,8,8,0,0,0,16,0,48.05,48.05,0,0,0-48-48h-8V24a8,8,0,0,0-16,0V40h-8a48,48,0,0,0,0,96h8v64H104a32,32,0,0,1-32-32,8,8,0,0,0-16,0,48.05,48.05,0,0,0,48,48h16v16a8,8,0,0,0,16,0V216h16a48,48,0,0,0,0-96Zm-40,0a32,32,0,0,1,0-64h8v64Zm40,80H136V136h16a32,32,0,0,1,0,64Z'></path></svg>",IconClass="primary1",Title="Total profit",Value="$46,789",IsIncreased=false,Percentage="0.5"},
            new WidgetElements {Id=3,Icon=" <svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M244.24,60a8,8,0,0,0-7.75-.4c-42.93,21-73.59,11.16-106,.78-34-10.89-69.25-22.14-117.95,1.64A8,8,0,0,0,8,69.24V189.17a8,8,0,0,0,11.51,7.19c42.93-21,73.59-11.16,106.05-.78,19.24,6.15,38.84,12.42,61,12.42,17.09,0,35.73-3.72,56.91-14.06a8,8,0,0,0,4.49-7.18V66.83A8,8,0,0,0,244.24,60ZM232,181.67c-40.6,18.17-70.25,8.69-101.56-1.32-19.24-6.15-38.84-12.42-61-12.42a122,122,0,0,0-45.4,9V74.33c40.6-18.17,70.25-8.69,101.56,1.32S189.14,96,232,79.09ZM128,96a32,32,0,1,0,32,32A32,32,0,0,0,128,96Zm0,48a16,16,0,1,1,16-16A16,16,0,0,1,128,144ZM56,96v48a8,8,0,0,1-16,0V96a8,8,0,1,1,16,0Zm144,64V112a8,8,0,1,1,16,0v48a8,8,0,1,1-16,0Z'></path></svg>",IconClass="primary2",Title="Total Revenue",Value="$57,874",IsIncreased=true,Percentage="0.5"},
            new WidgetElements {Id=4,Icon=" <svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M192,116a12,12,0,1,1-12-12A12,12,0,0,1,192,116ZM152,64H112a8,8,0,0,0,0,16h40a8,8,0,0,0,0-16Zm96,48v32a24,24,0,0,1-24,24h-2.36l-16.21,45.38A16,16,0,0,1,190.36,224H177.64a16,16,0,0,1-15.07-10.62L160.65,208h-57.3l-1.92,5.38A16,16,0,0,1,86.36,224H73.64a16,16,0,0,1-15.07-10.62L46,178.22a87.69,87.69,0,0,1-21.44-48.38A16,16,0,0,0,16,144a8,8,0,0,1-16,0,32,32,0,0,1,24.28-31A88.12,88.12,0,0,1,112,32H216a8,8,0,0,1,0,16H194.61a87.93,87.93,0,0,1,30.17,37c.43,1,.85,2,1.25,3A24,24,0,0,1,248,112Zm-16,0a8,8,0,0,0-8-8h-3.66a8,8,0,0,1-7.64-5.6A71.9,71.9,0,0,0,144,48H112A72,72,0,0,0,58.91,168.64a8,8,0,0,1,1.64,2.71L73.64,208H86.36l3.82-10.69A8,8,0,0,1,97.71,192h68.58a8,8,0,0,1,7.53,5.31L177.64,208h12.72l18.11-50.69A8,8,0,0,1,216,152h8a8,8,0,0,0,8-8Z'></path></svg>",IconClass="primary3",Title="Total Income",Value="$98,122",IsIncreased=false,Percentage="0.5"},
        };
        public List<WidgetElements> GetWidgetsCard1() => WidgetsCard1Data;
        private List<WidgetElements> WidgetsCard2Data = new List<WidgetElements>( )
        {
            new WidgetElements {Id=1,MainClass="primary",Icon="<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><circle cx='84' cy='108' r='52' opacity='0.2'/><path d='M10.23,200a88,88,0,0,1,147.54,0' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M172,160a87.93,87.93,0,0,1,73.77,40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><circle cx='84' cy='108' r='52' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M152.69,59.7A52,52,0,1,1,172,160' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>",IconClass="primary",Title="TOTAL EMPLOYEES",Value="15,877",Percentage="+0.5%"},
            new WidgetElements {Id=2,MainClass="primary1",Icon="<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M40,192a16,16,0,0,0,16,16H216a8,8,0,0,0,8-8V88a8,8,0,0,0-8-8H56A16,16,0,0,1,40,64Z' opacity='0.2'/><path d='M40,64V192a16,16,0,0,0,16,16H216a8,8,0,0,0,8-8V88a8,8,0,0,0-8-8H56A16,16,0,0,1,40,64h0A16,16,0,0,1,56,48H192' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><circle cx='180' cy='140' r='12'/></svg>",IconClass="primary1",Title="TOTAL PROFIT",Value="$88,784",Percentage="+0.5%"},
            new WidgetElements {Id=3,MainClass="primary2",Icon="<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M88,216a24,24,0,0,0,24-24c0-10-8-16-8-16H216s8,6,8,16a24,24,0,0,1-24,24Z' opacity='0.2'/><path d='M200,176V64a24,24,0,0,0-24-24H40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><line x1='104' y1='104' x2='168' y2='104' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><line x1='104' y1='136' x2='168' y2='136' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M24,80s-8-6-8-16a24,24,0,0,1,48,0V192a24,24,0,0,0,48,0c0-10-8-16-8-16H216s8,6,8,16a24,24,0,0,1-24,24H88' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>",IconClass="primary2",Title="TOTAL REVENUE",Value="$1,25,833",Percentage="+0.5%"},
            new WidgetElements {Id=4,MainClass="primary3",Icon="<svg xmlns='http://www.w3.org/2000/svg' viewBox='0 0 256 256'><rect width='256' height='256' fill='none'/><path d='M128,128h24a40,40,0,0,1,0,80H128Z' opacity='0.2'/><path d='M128,48H112a40,40,0,0,0,0,80h16Z' opacity='0.2'/><line x1='128' y1='24' x2='128' y2='48' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><line x1='128' y1='208' x2='128' y2='232' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/><path d='M184,88a40,40,0,0,0-40-40H112a40,40,0,0,0,0,80h40a40,40,0,0,1,0,80H104a40,40,0,0,1-40-40' fill='none' stroke='currentColor' stroke-linecap='round' stroke-linejoin='round' stroke-width='16'/></svg>",IconClass="primary3",Title="TOTAL SALES",Value="15,123",Percentage="+0.5%"},
        };
        public List<WidgetElements> GetWidgetsCard2() => WidgetsCard2Data;
        public static List<SalesStatistics> GetSalesStatisticss() {
            var jobsstatistics = new List<SalesStatistics>();
            jobsstatistics.Add(new SalesStatistics { Month = "Jan", ApplicationsValue = 144, ShortlistedValue = 133, RejectedValue = 30, OnHoldValue = 30});
            jobsstatistics.Add(new SalesStatistics { Month = "Feb", ApplicationsValue = 155, ShortlistedValue = 21, RejectedValue = 125, OnHoldValue = 125});
            jobsstatistics.Add(new SalesStatistics { Month = "Mar", ApplicationsValue = 141, ShortlistedValue = 32, RejectedValue = 36, OnHoldValue = 36});
            jobsstatistics.Add(new SalesStatistics { Month = "Apr", ApplicationsValue = 142, ShortlistedValue = 37, RejectedValue = 30, OnHoldValue = 30});
            jobsstatistics.Add(new SalesStatistics { Month = "May", ApplicationsValue = 122, ShortlistedValue = 123, RejectedValue = 45, OnHoldValue = 45});
            jobsstatistics.Add(new SalesStatistics { Month = "Jun", ApplicationsValue = 143, ShortlistedValue = 32, RejectedValue = 135, OnHoldValue = 135});
            jobsstatistics.Add(new SalesStatistics { Month = "Jul", ApplicationsValue = 121, ShortlistedValue = 47, RejectedValue = 64, OnHoldValue = 64});
            jobsstatistics.Add(new SalesStatistics { Month = "Aug", ApplicationsValue = 135, ShortlistedValue = 131, RejectedValue = 51, OnHoldValue = 51});
            jobsstatistics.Add(new SalesStatistics { Month = "Sep", ApplicationsValue = 156, ShortlistedValue = 54, RejectedValue = 59, OnHoldValue = 59});
            jobsstatistics.Add(new SalesStatistics { Month = "Oct", ApplicationsValue = 127, ShortlistedValue = 132, RejectedValue = 136, OnHoldValue = 136});
            jobsstatistics.Add(new SalesStatistics { Month = "Nov", ApplicationsValue = 143, ShortlistedValue = 20, RejectedValue = 39, OnHoldValue = 39});
            jobsstatistics.Add(new SalesStatistics { Month = "Dec", ApplicationsValue = 127, ShortlistedValue = 138, RejectedValue = 51, OnHoldValue = 51});
            return jobsstatistics;
        }
        public static List<CircleChart> GetCircleCharts()
        {
            var circlechart = new List<CircleChart>();
            circlechart.Add(new CircleChart { Source = "Total Sales", SourceValue = 85 });
            return circlechart;
        }
       public static List<WidgetsChart2> GetWidgetsChart2(WidgetElements MainCard) 
        {
            var WidgetsChart2 = new List<WidgetsChart2>();
            var valuesMap = new Dictionary<string, List<decimal>>
            {
                { 
                    "Total Sales", new List<decimal> { 88, 42, 65, 44, 57, 35, 33, -24, -38, -31, -57, -37, -22, -14 } 
                },
                { 
                    "Total Revenue", new List<decimal> { 68, 44, 87, 35, 22, 10, 88, -45, -57, -88, -22, -45, -45, -12 }
                },
                { 
                    "Total Customers", new List<decimal> { 87, 45, 12, 23, 56, 89, 45, -11, -56, -44, -89, -33, -44, -88 }
                },
                { 
                    "Total Profit", new List<decimal> { 77, 42, 88, 14, 89, 44, 45, -65, -45, -11, -12, -25, -36, -14 }
                },
            };

            var title = MainCard?.Title;
            if (!string.IsNullOrEmpty(title) && valuesMap.ContainsKey(title))
            {
                var values = valuesMap[title];
                for (int i = 0; i < values.Count / 2; i++)  // Adjusting loop to handle two sets of values (ThisWeek and LastWeek)
                {
                    WidgetsChart2.Add(new WidgetsChart2
                    {
                        Series = i + 1,
                        ThisWeek = values[i],  // First half for ThisWeek
                        LastWeek = values[i + values.Count / 2]  // Second half for LastWeek
                    });
                }
            }
            return WidgetsChart2;
        }
        private List<WidgetElements> WidgetsCard3Data = new List<WidgetElements>( )
        {
            new WidgetElements {Id=1,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M224,200h-8V40a8,8,0,0,0-8-8H152a8,8,0,0,0-8,8V80H96a8,8,0,0,0-8,8v40H48a8,8,0,0,0-8,8v64H32a8,8,0,0,0,0,16H224a8,8,0,0,0,0-16ZM160,48h40V200H160ZM104,96h40V200H104ZM56,144H88v56H56Z'></path></svg>",IconClass="primary-gradient",Title="Total Sales",Value="87,472",IsIncreased=true,Percentage="0.5"},
            new WidgetElements {Id=2,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M216,56H176V48a24,24,0,0,0-24-24H104A24,24,0,0,0,80,48v8H40A16,16,0,0,0,24,72V200a16,16,0,0,0,16,16H216a16,16,0,0,0,16-16V72A16,16,0,0,0,216,56ZM96,48a8,8,0,0,1,8-8h48a8,8,0,0,1,8,8v8H96ZM216,72v41.61A184,184,0,0,1,128,136a184.07,184.07,0,0,1-88-22.38V72Zm0,128H40V131.64A200.19,200.19,0,0,0,128,152a200.25,200.25,0,0,0,88-20.37V200ZM104,112a8,8,0,0,1,8-8h32a8,8,0,0,1,0,16H112A8,8,0,0,1,104,112Z'></path></svg>",IconClass="primary1-gradient",Title="Total Revenue",Value="$9,432",IsIncreased=false,Percentage="1.0%"},
            new WidgetElements {Id=3,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M117.25,157.92a60,60,0,1,0-66.5,0A95.83,95.83,0,0,0,3.53,195.63a8,8,0,1,0,13.4,8.74,80,80,0,0,1,134.14,0,8,8,0,0,0,13.4-8.74A95.83,95.83,0,0,0,117.25,157.92ZM40,108a44,44,0,1,1,44,44A44.05,44.05,0,0,1,40,108Zm210.14,98.7a8,8,0,0,1-11.07-2.33A79.83,79.83,0,0,0,172,168a8,8,0,0,1,0-16,44,44,0,1,0-16.34-84.87,8,8,0,1,1-5.94-14.85,60,60,0,0,1,55.53,105.64,95.83,95.83,0,0,1,47.22,37.71A8,8,0,0,1,250.14,206.7Z'></path></svg>",IconClass="primary2-gradient",Title="Total Customers",Value="3,132",IsIncreased=true,Percentage="1.5%"},
            new WidgetElements {Id=4,Icon="<svg xmlns='http://www.w3.org/2000/svg' width='32' height='32' fill='#000000' viewBox='0 0 256 256'><path d='M128,24A104,104,0,1,0,232,128,104.11,104.11,0,0,0,128,24Zm0,192a88,88,0,1,1,88-88A88.1,88.1,0,0,1,128,216Zm40-68a28,28,0,0,1-28,28h-4v8a8,8,0,0,1-16,0v-8H104a8,8,0,0,1,0-16h36a12,12,0,0,0,0-24H116a28,28,0,0,1,0-56h4V72a8,8,0,0,1,16,0v8h16a8,8,0,0,1,0,16H116a12,12,0,0,0,0,24h24A28,28,0,0,1,168,148Z'></path></svg>",IconClass="primary3-gradient",Title="Total Profit",Value="$5,325",IsIncreased=true,Percentage="1.3%"},
        };
        public List<WidgetElements> GetWidgetsCard3() => WidgetsCard3Data;
        public static List<Learning> GetLearnings() {
            var learning = new List<Learning>();
            learning.Add(new Learning { Activity = "0.1", LastWeek = 34, Average = 14});
            learning.Add(new Learning { Activity = "0.2", LastWeek = 84, Average = 65});
            learning.Add(new Learning { Activity = "0.3", LastWeek = 15, Average = 24});
            learning.Add(new Learning { Activity = "0.4", LastWeek = 36, Average = 88});
            learning.Add(new Learning { Activity = "0.5", LastWeek = 18, Average = 12});
            learning.Add(new Learning { Activity = "0.6", LastWeek = 19, Average = 65});
            learning.Add(new Learning { Activity = "0.7", LastWeek = 38, Average = 89});
            learning.Add(new Learning { Activity = "0.8", LastWeek = 65, Average = 65});
            learning.Add(new Learning { Activity = "0.9", LastWeek = 21, Average = 48});
            return learning;
        }
        public static List<Radialbarmultiple> Radialbarmultiple()
        {
            return new List<Radialbarmultiple>
            {
                new Radialbarmultiple { Fruits = "Apples", Value = 90},
                new Radialbarmultiple { Fruits = "Oranges", Value = 80},
                new Radialbarmultiple { Fruits = "Bananas", Value = 75},
            };
        }
        public static List<SaleRevenue2> GetSaleRevenue2() {
            var salerevenue2 = new List<SaleRevenue2>();
            salerevenue2.Add(new SaleRevenue2 { Month = "Jan", Sale2Value = 24, Refunds2Value = -8,  Cancelled2Value = 18, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Feb", Sale2Value = 57, Refunds2Value = -40, Cancelled2Value = 40, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Mar", Sale2Value = 55, Refunds2Value = -15, Cancelled2Value = 32, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Apr", Sale2Value = 18, Refunds2Value = -32, Cancelled2Value = 65, });
            salerevenue2.Add(new SaleRevenue2 { Month = "May", Sale2Value = 44, Refunds2Value = -45, Cancelled2Value = 45, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Jun", Sale2Value = 88, Refunds2Value = -30, Cancelled2Value = 30, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Jul", Sale2Value = 65, Refunds2Value = -20, Cancelled2Value = -20, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Aug", Sale2Value = 88, Refunds2Value = -35, Cancelled2Value = 35, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Sep", Sale2Value = 66, Refunds2Value = -28, Cancelled2Value = 28, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Oct", Sale2Value = 55, Refunds2Value = -43, Cancelled2Value = 43, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Nov", Sale2Value = 25, Refunds2Value = -65, Cancelled2Value = -30, });
            salerevenue2.Add(new SaleRevenue2 { Month = "Dec", Sale2Value = 88, Refunds2Value = -35, Cancelled2Value = -40, });
            return salerevenue2;
        }
        public static List<MixedAll> GetMixedAlls()
        {
            var MixedAlls = new List<MixedAll>();
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "01/01/2003" , TEAMAMixedValue = 47, TEAMBMixedValue = 14});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "02/01/2003" , TEAMAMixedValue = 55 , TEAMBMixedValue = 35});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "03/01/2003" , TEAMAMixedValue = 56 , TEAMBMixedValue = 85});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "04/01/2003" , TEAMAMixedValue = 33 , TEAMBMixedValue = 88});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "05/01/2003" , TEAMAMixedValue = 33 , TEAMBMixedValue = 45});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "06/01/2003" , TEAMAMixedValue = 48 , TEAMBMixedValue = 56});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "07/01/2003" , TEAMAMixedValue = 48 , TEAMBMixedValue = 25});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "08/01/2003" , TEAMAMixedValue = 22 , TEAMBMixedValue = 36});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "09/01/2003" , TEAMAMixedValue = 22 , TEAMBMixedValue = 14});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "10/01/2003" , TEAMAMixedValue = 86 , TEAMBMixedValue = 85});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "11/01/2003" , TEAMAMixedValue = 88 , TEAMBMixedValue = 96});
            MixedAlls.Add(new MixedAll { TEAMMixedValue = "11/01/2003" , TEAMAMixedValue = 89 , TEAMBMixedValue = 74});
            return MixedAlls;
        }
        public static List<Ordersoverview> Ordersoverview()
        {
            return new List<Ordersoverview>
            {
                new Ordersoverview { Fruits = "Apples", Value = 88},
                new Ordersoverview { Fruits = "Oranges", Value = 85},
                new Ordersoverview { Fruits = "Bananas", Value = 75},
                new Ordersoverview { Fruits = "Berries", Value = 60},
            };
        } 
        private List<Activity> ActivityData = new List<Activity>()
        {
            new Activity {Id=1,Title="Template Review",Desc="Reviewing the new template <a href='javascript:void(0)' class='text-primary'>HTML template</a>",Duration="15 May 2024" ,Avatarcolor="primary"},
            new Activity {Id=2,Title="Update Documentation",Desc="Documentation is updated <a href='javascript:void(0)' class='text-primary'> Available here</a>",Duration="18 Jun 2024" ,Avatarcolor="primary"},
            new Activity {Id=3,Title="Meeting for Managers",Desc="Meeting is going to be held on <a href='javascript:void(0)' class='text-secondary'> Today Evening 5:30PM</a>",Duration="05 Jul 2024" ,Avatarcolor="primary"},
            new Activity {Id=4,Title="Monitoring progress",Desc="Work Progess of each and every template is <a href='javascript:void(0)' class='text-success'>taken as consider</a>",Duration="13 July 2024" ,Avatarcolor="primary"},
            new Activity {Id=5,Title="Quality Testing",Desc="<a href='javascript:void(0)' class='text-warning'> Pending </a> Quality Assurance",Duration="15 Aug 2024" ,Avatarcolor="primary"},
            new Activity {Id=6,Title="Remainder for submission",Desc="The deadline for template submission is <a href='javascript:void(0)' class='text-dark'>10-09-2024</a>",Duration="21 Aug 2024" ,Avatarcolor="primary"},
        };
        public List<Activity> GetActivityData() => ActivityData;
        public static List<WidgetsChart1> GetWidgetsChart4(WidgetElements MainCard)
        {
            var WidgetsChart4 = new List<WidgetsChart1>();
            var sharedValues = new List<decimal> { 14, 20, 15, 25, 33, 58 };
            var titles = new List<string>
            {
                "Total Sales","Total Revenue","Total Users","Total Profit",
            };
            var title = MainCard?.Title;
            if (!string.IsNullOrEmpty(title) && titles.Contains(title))
            {
                for (int i = 0; i < sharedValues.Count; i++)
                {
                    WidgetsChart4.Add(new WidgetsChart1 { Series = i + 1, Value = sharedValues[i] });
                }
            }
            return WidgetsChart4;
        }
        private List<WidgetElements> WidgetsCard4Data = new List<WidgetElements>( )
        {
            new WidgetElements {Id=1,Icon="ri-bar-chart-box-line",IconClass="primary",Title="Total Sales",Value="42,312",IsIncreased=true,Percentage="+1.64%"},
            new WidgetElements {Id=2,Icon="ri-wallet-3-line",IconClass="primary1",Title="Total Revenue",Value="$78.7K",IsIncreased=false,Percentage="-1.32%"},
            new WidgetElements {Id=3,Icon="ri-group-line",IconClass="primary2",Title="Total Users",Value="86,475",IsIncreased=false,Percentage="-1.15%"},
            new WidgetElements {Id=4,Icon="ri-money-dollar-circle-line",IconClass="primary3",Title="Total Profit",Value="$18.4K",IsIncreased=true,Percentage="+2.05%"},
        };
        public List<WidgetElements> GetWidgetsCard4() => WidgetsCard4Data;
    }
}