using CardModel;
namespace SearchData
{
    public class SearchCard
    {   
        public decimal Id { get; set; }
        public string? SubTitle { get; set; }
        public string? Title { get; set; }
        public string? Url { get; set; }
        public string? Desc { get; set; }
        public List<Media>? Media { get; set; }
        public List<Tags>? Tags { get; set; }
    }    
    public class Media
    {
        public string? Img { get; set; }
        public string? Title { get; set; }
        public string? CompanyImg { get; set; }
        public string? Company { get; set; }
    }
    public class Tags
    {
        public string? Tag { get; set; }      
    }    
    public class Books
    {
        public decimal Id { get; set; }             
        public string? Date { get; set; }     
        public string? Img { get; set; }      
        public string? Title { get; set; }     
        public string? Desc { get; set; }    
        public string? Author { get; set; }    
        public List<Tags>? Tags { get; set; } 
    }    
    public class News
    {
        public decimal Id { get; set; }     
        public string? Title { get; set; }      
        public string? Date { get; set; }    
        public string? Location { get; set; }  
        public string? Desc { get; set; }     
    }    
    public class SearchService {
        private List<SearchCard> SearchCardData = new List<SearchCard>()
        {    
            new SearchCard { Id =1,SubTitle ="Beginner",Title ="Introduction to Web Development",Url ="http://www.beginnerpackage.com",Desc ="Learn the basics of web development, including HTML, CSS, and JavaScript.", Tags =new List<Tags>(){new Tags { Tag ="Shop Now"},new Tags { Tag ="Top 10 Picks"},},
            },
            new SearchCard { Id =2,SubTitle ="Responsive Design",Title ="Best Practices for Responsive Web Design",Url ="http://www.responsivedesigns.com",Desc ="Explore the latest techniques and tools for creating responsive websites..",Tags =new List<Tags>(){new Tags { Tag ="Browse Recipes"},new Tags { Tag ="Nutrition Tips"}},
            },
            new SearchCard { Id =3,SubTitle ="JavaScript, Frameworks",Title ="Advanced JavaScript Frameworks",Url ="http://www.javaScriptDevlops.com",Desc ="Dive deep into popular JavaScript frameworks like React, Angular, and Vue.js..", Tags =new List<Tags>(){new Tags { Tag ="Explore Destinations"},new Tags { Tag ="Travel Guides"}},
            },
            new SearchCard { Id =4,SubTitle ="JavaScript, Frameworks",Title ="CSS Flexbox Tutorial:<span class='text-muted fw-normal fs-13'> Master the CSS Flexbox layout model, get Videos from the link.</span>",Url ="http://www.layoutscss.com", Media =new List<Media>(){new Media { Img ="../assets/images/media/media-15.jpg"},new Media { Img ="../assets/images/media/media-16.jpg"}},Tags =new List<Tags>(){new Tags { Tag ="Explore Destinations"},new Tags { Tag ="Travel Guides"}},
            },
            new SearchCard { Id =5,SubTitle ="Frontend Development, Debugging",Title ="Debugging Tips for Frontend Developers",Url ="http://www.frontenddevelopment.com",Desc ="Discover effective strategies for debugging frontend code and troubleshooting common issues.", Tags =new List<Tags>(){new Tags { Tag ="Shop Now"},new Tags { Tag ="Trend Alerts"}},
            },
            new SearchCard { Id =6,SubTitle ="Backend Development",Title ="Introduction to Backend Development",Url ="http://www.backenddevlops.com",Desc ="Get started with backend development using Node.js, Python, and other server-side technologies.", Tags =new List<Tags>(){new Tags { Tag ="Explore Books"},new Tags { Tag ="Author Interviews"}},
            },
        };
        public List<SearchCard> GetSearchCardData() => SearchCardData;
        private List<Tags> TagsData = new List<Tags>()
        {    
            new Tags { Tag ="Designs"},
            new Tags { Tag ="Template"},
            new Tags { Tag ="Dashboard"},
            new Tags { Tag ="Admin Templates"},
            new Tags { Tag ="Templates"},
            new Tags { Tag ="Admin"},
            new Tags { Tag ="Hosting Templates"},
            new Tags { Tag ="Hosting"},
            new Tags { Tag ="Bootstrap"},
            new Tags { Tag ="Sales"},
        };
        public List<Tags> GetTagsData() => TagsData;
        private List<Media> MediaData = new List<Media>()
        {    
            new Media {  Img ="../assets/images/media/media-40.jpg", Title ="Beginner", CompanyImg ="../assets/images/company-logos/6.png", Company ="Beginner In.co"},
            new Media {  Img ="../assets/images/media/media-41.jpg", Title ="Responsive", CompanyImg ="../assets/images/company-logos/2.png", Company ="Responsive Design"},
            new Media {  Img ="../assets/images/media/media-42.jpg", Title ="JavaScript", CompanyImg ="../assets/images/company-logos/4.png", Company ="JavaScript Devlops"},
            new Media {  Img ="../assets/images/media/media-43.jpg", Title ="Layoutscss", CompanyImg ="../assets/images/company-logos/5.png", Company ="Layout SCSS"},
            new Media {  Img ="../assets/images/media/media-44.jpg", Title ="frontend", CompanyImg ="../assets/images/company-logos/6.png", Company ="Frontend Development.co"},
            new Media {  Img ="../assets/images/media/media-45.jpg", Title ="backenddevlops", CompanyImg ="../assets/images/company-logos/7.png", Company ="Backend Solutions"},
            new Media {  Img ="../assets/images/media/media-46.jpg", Title ="Frontend Dev", CompanyImg ="../assets/images/company-logos/8.png", Company ="Project innovations.in"},
            new Media {  Img ="../assets/images/media/media-60.jpg", Title ="Flawless", CompanyImg ="../assets/images/company-logos/9.png", Company ="Masters In.co"},
        };
        public List<Media> GetMediaData() => MediaData;
        private List<Books> BooksData = new List<Books>()
        {    
            new Books { Id =1,Date="May 10, 1902",Img="../assets/images/media/books/6.jpg",Title ="Whispers in the Wind",Desc ="Set in the Scottish Highlands, this tale follows the forbidden love between a Highland.",Author="Emma Harper", Tags =new List<Tags>(){new Tags { Tag ="Classic"},new Tags { Tag ="Historical"},new Tags { Tag ="Adventure"}},
            },
            new Books { Id =2,Date="Jun 08, 1994",Img="../assets/images/media/books/3.jpg",Title ="The Quantum Enigma",Desc ="A brilliant physicist stumbles upon a groundbreaking quantum discovery, but soon finds..",Author="Dr. James Holloway", Tags =new List<Tags>(){new Tags { Tag ="Science Fiction"},new Tags { Tag ="Mystery"},new Tags { Tag ="Thriller"}},
            },
            new Books { Id =3,Date="Apr 15, 2010",Img="../assets/images/media/books/1.jpg",Title ="Echoes of Eternity",Desc ="In a world where magic is fading, a young mage must embark on a perilous..",Author="Sophia Turner", Tags =new List<Tags>(){new Tags { Tag ="Epic"},new Tags { Tag ="Fantasy"},new Tags { Tag ="Adventure"}},
            },
            new Books { Id =4,Date="Oct 22, 1889",Img="../assets/images/media/books/2.jpg",Title ="Culinary Alchemy",Desc ="Discover the secrets of transforming simple ingredients into..",Author="Gordon Meyers", Tags =new List<Tags>(){new Tags { Tag ="Cooking"},new Tags { Tag ="Non-fiction"},new Tags { Tag ="Self-help"}},
            },
            new Books { Id =5,Date="Jan 06, 1999",Img="../assets/images/media/books/4.jpg",Title ="Shadows of the Mind",Desc ="A forensic psychologist with a dark past is drawn into a series..",Author="Dr. Lisa Bennett", Tags =new List<Tags>(){new Tags { Tag ="Psychological Thriller"},new Tags { Tag ="Crime"},new Tags { Tag ="Suspense"}},
            },
            new Books { Id =6,Date="Feb 16, 2003",Img="../assets/images/media/books/5.jpg",Title ="The Last Garden",Desc ="In a future where Earth’s ecosystems are collapsing, a group..",Author="Marcus Reed", Tags =new List<Tags>(){new Tags { Tag ="Dystopian"},new Tags { Tag ="Environmental"},new Tags { Tag ="Drama"}},
            },
        };
        public List<Books> GetBooksData() => BooksData;
        private List<News> NewsData = new List<News>()
        {    
            new News { Id =1,Title ="Quantum Physicists Break New Ground",Date ="10,Mar 2024 - 3:15PM",Location ="Quantum Research Facility, Geneva",Desc ="In a groundbreaking experiment, quantum physicists have detected a previously unknown subatomic particle, challenging."},
            new News { Id =2,Title ="Stunning Images from NASA's Perseverance Rover",Date ="8,Apr 2024 - 9:00AM",Location ="Jezero Crater, Mars",Desc =" NASA's Perseverance rover has captured breathtaking images of the Martian landscape, revealing tantalizing clues about the planet's geology."},
            new News { Id =3,Title ="Breakthrough in Cancer Research",Date ="5,May 2024 - 1:45PM",Location ="Genetech Laboratories",Desc ="Researchers have made a significant breakthrough in cancer treatment with the development of a novel therapy that targets"},
            new News { Id =4,Title ="Chef Julia Rodriguez Launches Global Initiative",Date ="5,Jun 2024 - 11:30AM",Location ="20 countries",Desc ="Renowned chef and humanitarian, Chef Julia Rodriguez, has launched a global initiative to combat"},
            new News { Id =5,Title ="Historic Peace Agreement Signed",Date ="22,Jul 2024 - 4:20PM",Location ="United Nations",Desc ="In a historic move, long-time rival nations have signed a landmark peace agreement."},
            new News { Id =6,Title ="Breakthrough in Renewable Energy",Date ="8,Aug 2024 - 10:00AM",Location ="SolarTech Innovations",Desc ="Scientists have achieved a major breakthrough in renewable energy with the development"},
        };
        public List<News> GetNewsData() => NewsData;
        
    }
}