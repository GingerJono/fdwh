using Sandbox.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardModel;

namespace Analytics
{
    public class AnalyticsService
    {
        public static List<AnalyticChart> GetAnalyticChart(AnalyticMainChart analyticMainChart)
        {
            var analyticChart = new List<AnalyticChart>();
            var valuesMap = new Dictionary<string, List<decimal>>
            {
                { "Total Followers", new List<decimal> { 1, 20, 15, 35, 30, 25, 55, 45, 65 } },
                { "Session Rate", new List<decimal> { 1, 20, 15, 35, 30, 25, 55, 45, 65 } },
                { "Conversion Rate", new List<decimal> { 1, 20, 15, 35, 30, 25, 55, 45, 65 } },
                { "Total Review", new List<decimal> { 1, 20, 15, 35, 30, 25, 55, 45, 65 } }
            };
            var title = analyticMainChart?.Title;
            if (!string.IsNullOrEmpty(title) && valuesMap.ContainsKey(title))
            {
                var values = valuesMap[title];
                for (int i = 0; i < values.Count; i++)
                {
                    analyticChart.Add(new AnalyticChart { Series = i + 1, Value = values[i] });
                }
            }
            return analyticChart;
        }
        
        private List<AnalyticMainChart> AnalyticMainChartData = new List<AnalyticMainChart>( )
        {
            new AnalyticMainChart { Title = "Total Followers", Icon = "bx bx-group", IconClass = "bg-primary", TotalValue = "13,124", Percentage = "<span class='text-success'>2.62%<i class='ti ti-arrow-narrow-up fs-16'></i></span>", IsIncreased = true },
            new AnalyticMainChart { Title = "Session Rate", Icon = "bx bx-trending-up", IconClass = "bg-primary1", TotalValue = "11,287", Percentage = "<span class='text-success'>0.56%<i class='ti ti-arrow-narrow-up fs-16'></i></span>", IsIncreased = true },
            new AnalyticMainChart { Title = "Conversion Rate", Icon = "bx bx-dollar", IconClass = "bg-primary2", TotalValue = "17,658", Percentage = "<span class='text-danger'>3.76%<i class='ti ti-arrow-narrow-down fs-16'></i></span>", IsIncreased = false },
            new AnalyticMainChart { Title = "Total Review", Icon = "bx bx-like", IconClass = "bg-primary3", TotalValue = "5,124", Percentage = "<span class='text-success'>2.57%<i class='ti ti-arrow-narrow-up fs-16'></i></span>", IsIncreased = true },
        };

        public List<AnalyticMainChart> GetAnalyticMainChart() => AnalyticMainChartData;
        public static List<AudienceMetric> GetAudienceMetric() {
            // Replace this with actual data retrieval logic
            var audienceMetric = new List<AudienceMetric>();
            audienceMetric.Add(new AudienceMetric { Month = "Jan", Viewers = 320, Followers = 680, Sessions = 180});
            audienceMetric.Add(new AudienceMetric { Month = "Feb", Viewers = 560, Followers = 800, Sessions = 250});
            audienceMetric.Add(new AudienceMetric { Month = "Mar", Viewers = 250, Followers = 680, Sessions = 300});
            audienceMetric.Add(new AudienceMetric { Month = "Apr", Viewers = 486, Followers = 840, Sessions = 350});
            audienceMetric.Add(new AudienceMetric { Month = "May", Viewers = 310, Followers = 980, Sessions = 350});
            audienceMetric.Add(new AudienceMetric { Month = "Jun", Viewers = 560, Followers = 720, Sessions = 250});
            audienceMetric.Add(new AudienceMetric { Month = "Jul", Viewers = 560, Followers = 900, Sessions = 150});
            audienceMetric.Add(new AudienceMetric { Month = "Aug", Viewers = 860, Followers = 1000, Sessions = 250});
            audienceMetric.Add(new AudienceMetric { Month = "Sep", Viewers = 400, Followers = 850, Sessions = 350});
            audienceMetric.Add(new AudienceMetric { Month = "Oct", Viewers = 500, Followers = 950, Sessions = 350});
            audienceMetric.Add(new AudienceMetric { Month = "Nov", Viewers = 350, Followers = 750, Sessions = 250});
            audienceMetric.Add(new AudienceMetric { Month = "Dec", Viewers = 700, Followers = 860, Sessions = 200});
            return audienceMetric;
        }
        public static List<Referrals> GetReferralsData()
        {
            var referrals = new List<Referrals>();
            referrals.Add(new Referrals { ReferralsName = "Search Engines", ReferralsValue = 300 });
            referrals.Add(new Referrals { ReferralsName = "Social Media", ReferralsValue = 450 });
            referrals.Add(new Referrals { ReferralsName = "Direct", ReferralsValue = 200 });
            referrals.Add(new Referrals { ReferralsName = "Referral Sites", ReferralsValue = 150 });
            referrals.Add(new Referrals { ReferralsName = "Email", ReferralsValue = 100 });
            return referrals;
        }
        public static List<SalesGrowthRate> GetSalesGrowthRateData() {
            var salesgrowthrate = new List<SalesGrowthRate>();
            salesgrowthrate.Add(new SalesGrowthRate { Month = "1", LastYear = 35, ThisYear = 55, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "2", LastYear = 36, ThisYear = 53, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "3", LastYear = 22, ThisYear = 46, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "4", LastYear = 44, ThisYear = 40, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "5", LastYear = 48, ThisYear = 45, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "6", LastYear = 37, ThisYear = 38, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "7", LastYear = 36, ThisYear = 46, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "8", LastYear = 26, ThisYear = 37, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "9", LastYear = 27, ThisYear = 22, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "10", LastYear = 33, ThisYear = 34, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "11", LastYear = 32, ThisYear = 40, });
            salesgrowthrate.Add(new SalesGrowthRate { Month = "12", LastYear = 36, ThisYear = 44, });
            return salesgrowthrate;
        }
        private List<AnalyticActivity> AnalyticActivityData = new List<AnalyticActivity>( )
        {
            new AnalyticActivity {        
                Id =1,
                Icon ="ri-timer-2-line",
                IconClass ="bg-primary-transparent",
                Title ="Avg. Session Duration",
                TotalValue ="2m 35s",
                Percentage ="5.2%",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =2,
                Icon ="ri-user-add-line fs-18",
                IconClass ="bg-primary1-transparent",
                Title ="New Users",
                TotalValue ="5,621",
                Percentage ="10.3%",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =3,
                Icon ="ri-eye-line fs-18",
                IconClass ="bg-primary2-transparent",
                Title ="Page Views",
                TotalValue ="45,890",
                Percentage ="2.15%",
                IsIncreased =false, 
            },
            new AnalyticActivity {        
                Id =4,
                Icon ="ri-line-chart-line fs-18",
                IconClass ="bg-primary3-transparent",
                Title ="Conversion Rate",
                TotalValue ="4.8%",
                Percentage ="1.5%",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =5,
                Icon ="ri-arrow-down-s-line fs-18",
                IconClass ="bg-primary3-transparent",
                Title ="Bounce Rate",
                TotalValue ="32.5%",
                Percentage ="3.8%",
                IsIncreased =false, 
            },
            new AnalyticActivity {        
                Id =6,
                Icon ="ri-user-line fs-18",
                IconClass ="bg-warning-transparent",
                Title ="Returning Visitors",
                TotalValue ="8,932",
                Percentage ="7.2%",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =7,
                Icon ="ri-money-dollar-circle-line fs-18",
                IconClass ="bg-info-transparent",
                Title ="Avg. Order Value",
                TotalValue ="$56.78",
                Percentage ="2.7%",
                IsIncreased =false, 
            },
        };

        public List<AnalyticActivity> GetAnalyticActivity() => AnalyticActivityData;
        
        private List<AnalyticActivity> AnalyticUserData = new List<AnalyticActivity>( )
        {
            new AnalyticActivity {        
                Id =1,
                Icon ="../assets/images/flags/us_flag.jpg",
                Title ="United States",
                TotalValue ="26,890",
                Percentage ="5.1",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =2,
                Icon ="../assets/images/flags/germany_flag.jpg",
                Title ="Germany",
                TotalValue ="12,345",
                Percentage ="1.3",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =3,
                Icon ="../assets/images/flags/spain_flag.jpg",
                Title ="Spain",
                TotalValue ="18,765",
                Percentage ="2.7",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =4,
                Icon ="../assets/images/flags/china_flag.jpg",
                Title ="China",
                TotalValue ="9,874",
                Percentage ="1.0",
                IsIncreased =false, 
            },
            new AnalyticActivity {        
                Id =5,
                Icon ="../assets/images/flags/mexico_flag.jpg",
                Title ="Mexico",
                TotalValue ="21,456",
                Percentage ="2.7",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =6,
                Icon ="../assets/images/flags/canada_flag.jpg",
                Title ="Canada",
                TotalValue ="28,976",
                Percentage ="2.1",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =7,
                Icon ="../assets/images/flags/argentina_flag.jpg",
                Title ="Argentina",
                TotalValue ="21,456",
                Percentage ="5.4",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =7,
                Icon ="../assets/images/flags/singapore_flag.jpg",
                Title ="Singapore",
                TotalValue ="16,789",
                Percentage ="0.7",
                IsIncreased =true, 
            },
            new AnalyticActivity {        
                Id =8,
                Icon ="../assets/images/flags/italy_flag.jpg",
                Title ="Italy",
                TotalValue ="21,456",
                Percentage ="0.3",
                IsIncreased =false, 
            },
        };

        public List<AnalyticActivity> GetAnalyticUsers() => AnalyticUserData;
        
        private List<SiteTable> SiteTableData = new List<SiteTable>()
        {
            new SiteTable {Id = 1,Title="Search Engines",Total="300",IsGrowth=true,Growth="+5.2%"},
            new SiteTable {Id = 2,Title="Social Media",Total="450",IsGrowth=true,Growth="+10.3%"},
            new SiteTable {Id = 3,Title="Direct",Total="200",IsGrowth=true,Growth="+2.5%"},
            new SiteTable {Id = 4,Title="Referral Sites",Total="150",IsGrowth=false,Growth="-1.2%"},
            new SiteTable {Id = 5,Title="Email",Total="100",IsGrowth=true,Growth="+5.2%"},
        };
        public List<SiteTable> GetSite() => SiteTableData;
        
      
        private List<CountryCardModel> LandingData = new List<CountryCardModel>()
        {
            new CountryCardModel{ id = 1,title = "main/landing-page/home",value = "2,345 Visits",color = "bg-primary",percent = "50",customclass="mb-3"},
            new CountryCardModel{ id = 2,title = "main/landing-page/products/popular-category",value = "1,987 Visits",color = "bg-primary1",percent = "30",customclass="mb-3"},
            new CountryCardModel{ id = 3,title = "main/landing-page/blog/latest-article",value = "1,532 Visits",color = "bg-primary2",percent = "20",customclass="mb-3"},
            new CountryCardModel{ id = 4,title = "main/landing-page/about-us/team-page",value = "1,254 Visits",color = "bg-primary3",percent = "40",customclass="mb-3"},
            new CountryCardModel{ id = 5,title = "main/landing-page/about-us/profile",value = "1,103 Visits",color = "bg-primary3",percent = "40",customclass="mb-3"},
            new CountryCardModel{ id = 6,title = "main/landing-page/contact/support",value = "985 Visits",color = "bg-info",percent = "60",customclass="mb-0"},
        };
        public List<CountryCardModel> GetLandingData() => LandingData;
        
        private List<VisitorsTable> VisitorsStatsData = new List<VisitorsTable>()
        {
            new VisitorsTable {
                Id = 1,
                Visitors="32,190",
                Duration="15m 30s",
                New="12,345",
                Returning="19,845",
                BounceRate="45%",
                ConversionRate="3.5%",
                Average="3m 45s",
                Referral="Google, Facebook",
                VisitorsClass="table-success",
                DurationClass="",
                NewClass="",
                ReturningClass="",
                BounceRateClass="table-danger",
                ConversionRateClass="",
                AverageClass="",
                ReferralClass="",
            },
            new VisitorsTable {
                Id = 2,
                Visitors="28,674",
                Duration="13m 25s",
                New="10,432",
                Returning="18,242",
                BounceRate="47%",
                ConversionRate="3.8%",
                Average="3m 10s",
                Referral="Twitter, LinkedIn",
                VisitorsClass="",
                DurationClass="",
                NewClass="",
                ReturningClass="",
                BounceRateClass="",
                ConversionRateClass="table-warning",
                AverageClass="",
                ReferralClass="",
            },
            new VisitorsTable {
                Id = 3,
                Visitors="35,789",
                Duration="16m 10s",
                New="13,567",
                Returning="22,222",
                BounceRate="43%",
                ConversionRate="3.2%",
                Average="4m 05s",
                Referral="Bing, YouTube",
                VisitorsClass="",
                DurationClass="table-warning",
                NewClass="",
                ReturningClass="table-success",
                BounceRateClass="",
                ConversionRateClass="",
                AverageClass="table-success",
                ReferralClass="",
            },
            new VisitorsTable {
                Id = 4,
                Visitors="30,234",
                Duration="14m 50s",
                New="11,678",
                Returning="18,556",
                BounceRate="46%",
                ConversionRate="3.6%",
                Average="3m 30s",
                Referral="Instagram, Reddit",
                VisitorsClass="",
                DurationClass="",
                NewClass="",
                ReturningClass="",
                BounceRateClass="",
                ConversionRateClass="",
                AverageClass="",
                ReferralClass="",
            },
            new VisitorsTable {
                Id = 5,
                Visitors="33,456",
                Duration="15m 45s",
                New="12,890",
                Returning="20,566",
                BounceRate="44%",
                ConversionRate="3.4%",
                Average="3m 55s",
                Referral="Yahoo, Pinterest",
                VisitorsClass="table-danger",
                DurationClass="",
                NewClass="",
                ReturningClass="",
                BounceRateClass="",
                ConversionRateClass="",
                AverageClass="",
                ReferralClass="table-success",
            },
        };
        public List<VisitorsTable> GetVisitorsStats() => VisitorsStatsData;
        
        public TableText[] VisitorsTableHeaders = new TableText[]
        {
            new TableText { Title = "Total Visitors" },
            new TableText { Title = "Sessions Duration" },
            new TableText { Title = "New Visitors" },
            new TableText { Title = "Returning Visitors" },
            new TableText { Title = "Bounce Rate" },
            new TableText { Title = "Conversion Rate" },
            new TableText { Title = "Average Session Duration" },
            new TableText { Title = "Top Referral Sources" },
        };
        public TableText[] GetVisitorsHeadersData() => VisitorsTableHeaders;
        
        public TableText[] SiteTableHeaders = new TableText[]
        {
            new TableText { Title = "Source" },
            new TableText { Title = "Total" },
            new TableText { Title = "Growth" },
        };
        public TableText[] GetSiteHeadersData() => SiteTableHeaders;
        
    }
}