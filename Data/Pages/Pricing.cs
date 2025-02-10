using CardModel;
namespace PricingData
{
    public class PricingCard
    {   
        public decimal Id { get; set; }
        public bool Offer { get; set; } 
        public string? OfferValue { get; set; }
        public string? PricingBg { get; set; }
        public string? Title { get; set; }
        public bool Plan { get; set; }
        public string? Amount { get; set; }
        public string? Desc { get; set; }
        public string? PricingClass { get; set; }
        public List<Features>? Features { get; set; }
    }    
    public class Features
    {
        public decimal Id { get; set; }
        public string? FeatureDesc { get; set; }
        public string? Badge { get; set; }
        public string? InfoDesc { get; set; }
        public string? Validity { get; set; }
    }

    public class PricingService {
        
        private List<PricingCard> PricingData = new List<PricingCard>()
        {
            new PricingCard {Id=1,Offer=true, OfferValue="Popular",PricingBg="bg-primary",Title="Premium",Plan=true,Amount="$22.89",Desc="Unlock powerful tools tailored for seasoned users, designed to take your skills to the next level.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Unlimited users",Badge ="Unlimited"},
                    new Features { Id =2,FeatureDesc ="Advanced analytics"},
                    new Features { Id =3,FeatureDesc ="Customizable dashboards",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Phone support"},
                    new Features { Id =5,FeatureDesc ="Dedicated account manager"},
                    new Features { Id =6,FeatureDesc ="SLA guarantees",Validity ="30 Days"},
                    new Features { Id =7,FeatureDesc ="On-site training for teams",Validity ="120 Days"},
                }
            },
            new PricingCard {Id=2,Offer=false, Title="Basic",Plan=true,Amount="$8.5",Desc="Discover the vital features that create an enchanting foundation for a magical beginning.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Up to 10 users",Badge ="New"},
                    new Features { Id =2,FeatureDesc ="Community access"},
                    new Features { Id =3,FeatureDesc ="Basic reporting",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Email support"},
                    new Features { Id =5,FeatureDesc ="Community access"},
                    new Features { Id =6,FeatureDesc ="Access to essential features",Validity ="12 Days"},
                    new Features { Id =7,FeatureDesc ="Mobile app access",Validity ="45 Days"},
                }
            },
            new PricingCard {Id=3,Offer=false, Title="Standard",Plan=true,Amount="$29.99",Desc="Elevate to the highest standards with unparalleled excellence and exclusive top-tier support.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Up to 50 users",Badge ="New"},
                    new Features { Id =2,FeatureDesc ="Access to webinars"},
                    new Features { Id =3,FeatureDesc ="Advanced reporting",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Priority email support"},
                    new Features { Id =5,FeatureDesc ="24/7 chat support"},
                    new Features { Id =6,FeatureDesc ="All Standard features",Validity ="52 Days"},
                    new Features { Id =7,FeatureDesc ="Team collaboration tools",Validity ="60 Days"},
                }
            },
            new PricingCard {Id=4,Offer=true, OfferValue="Popular",PricingBg="bg-primary",Title="Premium",Plan=false,Amount="$1,999.89",Desc="Unlock powerful tools tailored for seasoned users, designed to take your skills to the next level.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Unlimited users",Badge ="Unlimited"},
                    new Features { Id =2,FeatureDesc ="Advanced analytics"},
                    new Features { Id =3,FeatureDesc ="Customizable dashboards",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Phone support"},
                    new Features { Id =5,FeatureDesc ="Dedicated account manager"},
                    new Features { Id =6,FeatureDesc ="SLA guarantees",Validity ="90 Days"},
                    new Features { Id =7,FeatureDesc ="On-site training for teams",Validity ="300 Days"},
                }
            },
            new PricingCard {Id=5,Offer=false, Title="Basic",Plan=false,Amount="$899.96",Desc="Discover the vital features that create an enchanting foundation for a magical beginning.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Up to 10 users",Badge ="New"},
                    new Features { Id =2,FeatureDesc ="Community access"},
                    new Features { Id =3,FeatureDesc ="Basic reporting",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Email support"},
                    new Features { Id =5,FeatureDesc ="Community access"},
                    new Features { Id =6,FeatureDesc ="Access to essential features",Validity ="40 Days"},
                    new Features { Id =7,FeatureDesc ="Mobile app access",Validity ="180 Days"},
                }
            },
            new PricingCard {Id=6,Offer=false, Title="Standard",Plan=false,Amount="$589.99",Desc="Elevate to the highest standards with unparalleled excellence and exclusive top-tier support.",PricingClass="p-3",
                Features = new List<Features>{
                    new Features { Id =1,FeatureDesc ="Up to 50 users",Badge ="New"},
                    new Features { Id =2,FeatureDesc ="Access to webinars"},
                    new Features { Id =3,FeatureDesc ="Advanced reporting",InfoDesc ="Provide essential insights and data analysis to help you track the performance."},
                    new Features { Id =4,FeatureDesc ="Priority email support"},
                    new Features { Id =5,FeatureDesc ="24/7 chat support"},
                    new Features { Id =6,FeatureDesc ="All Standard features",Validity ="250 Days"},
                    new Features { Id =7,FeatureDesc ="Team collaboration tools",Validity ="320 Days"},
                }
            },
            
        };
        public List<PricingCard> GetPricingData() => PricingData;

    }
}