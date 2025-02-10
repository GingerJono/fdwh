
namespace RadialChartData
{
    public class Radialbarbasic
    {
        public string? RadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class Radialbarmultiple
    {
        public string? Fruits { get; set; }
        public decimal Value { get; set; }
    }
    public class Radialbarcustom
    {
        public string? SocialApps { get; set; }
        public decimal Value { get; set; }
    }    
    public class RadialbarGradient
    {
        public string? GradientRadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class RadialbarCircular
    {
        public string? CircularRadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class RadialbarImage
    {
        public string? ImageRadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class RadialbarSemiCircular
    {
        public string? SemiCircularRadialLabel { get; set; }
        public decimal Value { get; set; }
    }
    public class RadialChartService {
        public static List<Radialbarbasic> Radialbarbasic()
        {
            return new List<Radialbarbasic>
            {
                new Radialbarbasic { RadialLabel = "Cricket", Value = 70},
            };
        }
        public static List<Radialbarmultiple> Radialbarmultiple()
        {
            return new List<Radialbarmultiple>
            {
                new Radialbarmultiple { Fruits = "Apples", Value = 44},
                new Radialbarmultiple { Fruits = "Oranges", Value = 55},
                new Radialbarmultiple { Fruits = "Bananas", Value = 67},
                new Radialbarmultiple { Fruits = "Berries", Value = 83},
            };
        }
        public static List<Radialbarcustom> Radialbarcustom()
        {
            return new List<Radialbarcustom>
            {
                new Radialbarcustom { SocialApps = "Vimeo", Value = 76},
                new Radialbarcustom { SocialApps = "Messenger", Value = 67},
                new Radialbarcustom { SocialApps = "Facebook", Value = 61},
                new Radialbarcustom { SocialApps = "LinkedIn", Value = 90},
            };
        }
        public static List<RadialbarGradient> RadialbarGradient()
        {
            return new List<RadialbarGradient>
            {
                new RadialbarGradient { GradientRadialLabel = "Percent", Value = 75},
            };
        }
        public static List<RadialbarCircular> RadialbarCircular()
        {
            return new List<RadialbarCircular>
            {
                new RadialbarCircular { CircularRadialLabel = "Median Ratio", Value = 67},
            };
        }
        public static List<RadialbarImage> RadialbarImage()
        {
            return new List<RadialbarImage>
            {
                new RadialbarImage { ImageRadialLabel = "Volatility", Value = 67},
            };
        }
        public static List<RadialbarSemiCircular> RadialbarSemiCircular()
        {
            return new List<RadialbarSemiCircular>
            {
                new RadialbarSemiCircular { SemiCircularRadialLabel = "Average Results", Value = 76},
            };
        }
    }
}