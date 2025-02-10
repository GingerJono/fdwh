
namespace FunnelData
{    
    public class Funnelbasic
    {
        public string? Country { get; set; }
        public int GrossValue { get; set; }
    }    
    public class FunnelGradient
    {
        public string? Country { get; set; }
        public int GrossValue { get; set; }
    }    
    public class FunnelService {
        public static List<Funnelbasic> GetFunnelbasics()
        {
            return new List<Funnelbasic>
            {
                new Funnelbasic { Country = "Sourced", GrossValue = 1380 },
                new Funnelbasic { Country = "Screened", GrossValue = 1100 },
                new Funnelbasic { Country = "Assessed", GrossValue = 990 },
                new Funnelbasic { Country = "HR Interview", GrossValue = 880 },
                new Funnelbasic { Country = "Technical", GrossValue = 740 },
                new Funnelbasic { Country = "Verify", GrossValue = 548 },
                new Funnelbasic { Country = "Offered", GrossValue = 330 },
                new Funnelbasic { Country = "Hired", GrossValue = 200 },
            };
        }
        public static List<FunnelGradient> GetFunnelGradients()
        {
            return new List<FunnelGradient>
            {
                new FunnelGradient { Country = "Sweets", GrossValue = 200 },
                new FunnelGradient { Country = "Processed Foods", GrossValue = 330 },
                new FunnelGradient { Country = "Healthy Fats", GrossValue = 548 },
                new FunnelGradient { Country = "Meat", GrossValue = 740 },
                new FunnelGradient { Country = "Beans & Legumes", GrossValue = 880 },
                new FunnelGradient { Country = "Dairy", GrossValue = 990 },
                new FunnelGradient { Country = "Fruits & Vegetables", GrossValue = 1100 },
                new FunnelGradient { Country = "Grains", GrossValue = 1380 },
            };
        }
    }
}