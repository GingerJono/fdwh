using CardModel;

namespace PodCast
{
    public class Categories {
        public decimal id { get; set; }
        public string? icon { get; set; }
        public string? color { get; set; }
        public string? data { get; set; }
        public string? data1 { get; set; }
        
    }
    public class PopularPodcastList {
        public decimal id { get; set; }
        public string? title { get; set; }
        public string? author { get; set; }
        public string? image { get; set; }
        public string? listeners { get; set; }
    }    
    public class PlayedList {
        public decimal id { get; set; }
        public string? podcastImg { get; set; }
        public string? podcast { get; set; }
        public string? Player { get; set; }
        public string? duration { get; set; }
        public string? category { get; set; }
        public string? color { get; set; }
        public string? latest { get; set; }
        public string? avg { get; set; }
        public bool favourite { get; set; }
    }
}

