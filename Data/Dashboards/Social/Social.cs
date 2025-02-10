using CardModel;

namespace Social
{
    public class FollowOnDevice
    {
        public string? Device { get; set; }
        public int DeviceValue { get; set; }
    };
    public class Audience {
        public string? Month { get; set; }
        public decimal Followers { get; set; }
        public decimal Views { get; set; }
        
    } ;
    public class SocialTable  {
        public string? Date { get; set; }
        public string? PlatformImg { get; set; }
        public string? PlatformClass { get; set; }
        public string? Platform { get; set; }
        public string? Likes { get; set; }
        public string? Comments { get; set; }
        public string? Shares { get; set; }
        public string? Impressions { get; set; }
        public string? ImpressionsClass { get; set; }
        public string? Engaged  { get; set; }
        public string? Followers { get; set; }
        public string? Following { get; set; }
        
    } ;
    
    public class SocialList  {
        public string? UserImg { get; set; }
        public string? User { get; set; }
    } ;


}

