using CardModel;
namespace TimelineData
{
    public class Activity
    {
        public string? Date { get; set; }  
        public string? Mainclass { get; set; }  
        public List<ActivityDetails>? Activitylist { get; set; }
    } 
    
    public class ActivityDetails
    {
        public decimal Id { get; set; }
        public string? Mainclass { get; set; }  
        public string? ImgPosition  { get; set; }
        public string? Day { get; set; }
        public string? Time { get; set; }
        public string? Date { get; set; }
        public string? User { get; set; }
        public bool IsOnline { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Media>? MediaList { get; set; }
    }   
    public class Media
    {
        public string? Img { get; set; }
    }
    public class TimelineService {
        private List<Activity> TimelineData1 = new List<Activity>()
        {    
           new Activity {
                Date = "22 January 2024",
                Mainclass="primary2",
                Activitylist = new List<ActivityDetails>
                {
                    new ActivityDetails
                    {
                        Id = 1,
                        Time ="15:36, Monday",
                        Title ="<b>You </b> Tagged <b> Emma Thompson</b>  in a Photo.",
                        Description ="'Including Emma in cherished memories captured on camera, tagging her in a photo to share a moment of joy or significance and inviting her to reminisce together.'",
                        MediaList = new List<Media>
                        {
                            new Media {Img = "../assets/images/media/media-17.jpg"},
                            new Media {Img = "../assets/images/media/media-18.jpg"},
                        },
                    },
                    new ActivityDetails
                    {
                        Id = 2,
                        Time ="22:45, Monday",
                        Title ="<span class='text-default'><b>Michel</b> Retweeted Emily <a href='javascript:void(0);' class='text-primary1 fw-medium text-decoration-underline'>Davis</a>'s Tweet </span>.",
                        Description ="Amplifying Emily's message and sharing it with your own Twitter followers, acknowledging the importance or relevance of her tweet and extending its reach across the platform.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium",
                    },
                },
            },
           new Activity {
                Date = "25 January 2024",
                Mainclass="primary3",
                Activitylist = new List<ActivityDetails>
                {
                    new ActivityDetails
                    {
                        Id = 3,
                        Time ="09:14, Thursday",
                        Title ="<span class='text-default'><b>You</b> Shared <b>a Recipe </b></span>on Sarah Johnson's Timeline.",
                        Description ="Spreading culinary inspiration by sharing a mouth-watering recipe on Sarah's timeline, encouraging others to indulge in delicious homemade dishes and fostering a sense of community around food.",
                        MediaList = new List<Media>
                        {
                            new Media {Img = "../assets/images/media/media-59.jpg"},
                            new Media {Img = "../assets/images/media/media-60.jpg"},
                            new Media {Img = "../assets/images/media/media-61.jpg"},
                        },
                    },
                    new ActivityDetails
                    {
                        Id = 4,
                        Time ="17:56, Thursday",
                        Title ="<b>You</b> Participated in a Poll Created by <b> Ethan Clark</b>  <a class='text-primary2' href='javascript:void(0);'><u>#analysis-decision-making</u></a>.",
                        Description ="Sharing your perspective and contributing to Ethan's data collection through participation in his poll, providing valuable feedback and insights to inform further analysis and decision-making.", 
                        MediaList = new List<Media>
                        {
                            new Media {Img = "../assets/images/media/media-26.jpg"},
                            new Media {Img = "../assets/images/media/media-29.jpg"},
                        },
                    },
                },
            },
        };
        public List<Activity> GetTimelineData1() => TimelineData1;
        private List<ActivityDetails> TimelineData2 = new List<ActivityDetails>()
        {    
            new ActivityDetails {
                Id =1,
                Mainclass ="primary",  
                ImgPosition  ="left",
                Day ="Saturday",
                Time ="06:15",
                Date ="May 21, 2024 - Ongoing",
                User ="../assets/images/faces/1.jpg",
                IsOnline =true,
                Title ="Event Conceptualization",
                Description ="Brainstormed event ideas and themes.Conducted initial research on venue options and potential sponsors",
            },
            new ActivityDetails {
                Id =2,
                Mainclass ="primary1",  
                ImgPosition  ="right",
                Day ="Tuesday",
                Time ="22:55",
                Date =" May 21 - 26, 2024",
                User ="../assets/images/faces/15.jpg",
                IsOnline =true,
                Title ="Preparation and Organization",
                Description ="Secured venue and finalized contracts with vendors.Created event marketing materials and promotional strategies.Established event logistics.",
            },
            new ActivityDetails {
                Id =3,
                Mainclass ="primary2",  
                ImgPosition  ="left",
                Day ="Monday",
                Time ="13:05",
                Date =" May 20, 2024",
                User ="../assets/images/faces/2.jpg",
                IsOnline =true,
                Title ="Event Execution",
                Description ="Set up event space and coordinated with vendors for equipment and services.Facilitated event activities, speakers, and entertainment.",
            },
            new ActivityDetails {
                Id =4,
                Mainclass ="primary3",  
                ImgPosition  ="right",
                Day ="Yesterday",
                Time ="08:45",
                Date ="May 1 - May 15, 2024",
                User ="../assets/images/faces/8.jpg",
                IsOnline =true,
                Title ="Product Development",
                Description ="Conducted market research and identified customer needs.Defined product specifications and features.",
            },
            new ActivityDetails {
                Id =5,
                Mainclass ="secondary",  
                ImgPosition  ="left",
                Day ="Today",
                Time ="12:24",
                Date ="February 15 - April 30, 2024",
                User ="../assets/images/faces/13.jpg",
                IsOnline =true,
                Title ="Team Building Retreat",
                Description ="Our team took a break to recharge and bond. We came back stronger!",
            },
            new ActivityDetails {
                Id =6,
                Mainclass ="warning",  
                ImgPosition  ="right",
                Day ="Today",
                Time ="04:11",
                Date ="January 20 - February 10, 2024",
                User ="../assets/images/faces/6.jpg",
                IsOnline =true,
                Title ="Design and Development",
                Description ="Designed user interface (UI) and user experience (UX) elements.Developed product functionalities.",
            },
            new ActivityDetails {
                Id =7,
                Mainclass ="info",  
                ImgPosition  ="left",
                Day ="Today",
                Time ="02:52",
                Date ="January 15, 2024",
                User ="../assets/images/faces/11.jpg",
                IsOnline =true,
                Title ="Testing and Launch",
                Description ="Conducted comprehensive testing to ensure product quality and stability.Prepared marketing materials.",
            },
                   
        };
        public List<ActivityDetails> GetTimelineData2() => TimelineData2;
        private List<ActivityDetails> TimelineData3 = new List<ActivityDetails>()
        {    
            new ActivityDetails {
                Id =1,
                Mainclass ="primary1",  
                ImgPosition  ="bottom",
                Date ="October 6, 2024",
                User ="../assets/images/faces/11.jpg",
                Title ="Planning",
                Description ="Research and competitor analysis.",
            },
            new ActivityDetails {
                Id =2,
                Mainclass ="primary2",  
                ImgPosition  ="top",
                Date ="September 12, 2024",
                User ="../assets/images/faces/1.jpg",
                Title ="Design",
                Description ="Frontend and backend components.",
            },
            new ActivityDetails {
                Id =3,
                Mainclass ="primary3",  
                ImgPosition  ="bottom",
                Date ="July 20, 2024",
                User ="../assets/images/faces/12.jpg",
                Title ="Testing",
                Description ="Conducted comprehensive testing.",
            },
            new ActivityDetails {
                Id =4,
                Mainclass ="secondary",  
                ImgPosition  ="top",
                Date ="May 18, 2024",
                User ="../assets/images/faces/3.jpg",
                Title ="Deployment",
                Description ="Conducted final checks.",
            },
            new ActivityDetails {
                Id =5,
                Mainclass ="warning",  
                ImgPosition  ="bottom",
                Date ="April 5, 2024",
                User ="../assets/images/faces/14.jpg",
                Title ="Post-Launch",
                Description ="Provided ongoing support.",
            },
                   
        };
        public List<ActivityDetails> GetTimelineData3() => TimelineData3;
        
    }
}