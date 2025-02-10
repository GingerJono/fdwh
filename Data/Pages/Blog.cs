
namespace BlogData
{
    public class BlogCategories
    {
        public decimal id { get; set; }
        public string? icon { get; set; }
        public string? title { get; set; } 
        public string? Count { get; set; } 
        public string? color { get; set; }
    }
    public class RelatedBlog
    {
        public decimal id { get; set; }
        public string? img { get; set; }
        public string? title { get; set; } 
        public string? titleColor { get; set; } 
        public string? desc { get; set; } 
        public string? posted { get; set; }
    }    
    public class BlogService {
        private List<BlogCategories> BlogCategoriesData = new List<BlogCategories>()
        {
            new BlogCategories{ id= 1, icon= "ri-leaf-fill", title= "Nature Life", Count= "12", color= "primary" },
            new BlogCategories{ id= 2, icon= "ri-flight-takeoff-fill", title= "Tourism & Trips", Count= "36", color= "primary1" },
            new BlogCategories{ id= 3, icon= "ri-global-fill", title= "Technology", Count= "45", color= "primary2" },
            new BlogCategories{ id= 4, icon= "ri-cloud-fill", title= "Data Networking", Count= "124", color= "primary3" },
            new BlogCategories{ id= 5, icon= "ri-home-wifi-fill", title= "Modern Living", Count= "16", color= "info" }
        };       
        public List<BlogCategories> GetBlogCategoriesData() => BlogCategoriesData;
        private List<RelatedBlog> RelatedBlogData = new List<RelatedBlog>()
        {
            new RelatedBlog{ id= 1, img= "../assets/images/media/blog/5.jpg",title="Jack Diamond",desc="To generate....",posted="25,Mar 2024 - 22=30"},
            new RelatedBlog{ id= 2, img= "../assets/images/media/blog/6.jpg",title="Jack Diamond",desc="To generate....",posted="25,Mar 2024 - 22=30"},
            new RelatedBlog{ id= 3, img= "../assets/images/media/blog/8.jpg",title="Jack Diamond",desc="To generate....",posted="25,Mar 2024 - 22=30"},
            new RelatedBlog{ id= 4, img= "../assets/images/media/blog/9.jpg",title="Jack Diamond",desc="To generate....",posted="25,Mar 2024 - 22=30"},
        };       
        public List<RelatedBlog> GetRelatedBlogData() => RelatedBlogData;
        private List<RelatedBlog> FeaturedBlogData = new List<RelatedBlog>()
        {
            new RelatedBlog{ id= 1, img= "../assets/images/media/blog/14.jpg", title= "Jack Diamond", desc= " To generate Lorem Ipsum which looks reasonable",},
            new RelatedBlog{ id= 2, img= "../assets/images/media/blog/15.jpg", title= "Dhruva Gen", desc= "All the Lorem Ipsum generators on the Internet",},
            new RelatedBlog{ id= 3, img= "../assets/images/media/blog/16.jpg", title= "Henry Milo", desc= "Lorem Ipsum is therefore always free from repetition, injected humour",},
            new RelatedBlog{ id= 4, img= "../assets/images/media/blog/17.jpg", title= "Peter Paul", desc= "orem Ipsum is not simply random text. It has roots in a piece of classical",},
            new RelatedBlog{ id= 5, img= "../assets/images/media/blog/7.jpg", title= "Fahad Rafi", desc= "Electronic typesetting, remaining essentially unchanged.", }
        };       
        public List<RelatedBlog> GetFeaturedBlogData() => FeaturedBlogData;
        private List<RelatedBlog> TagsBlogData = new List<RelatedBlog>()
        {
            new RelatedBlog{ title= "#artist"},
            new RelatedBlog{ title= "#musician"},
            new RelatedBlog{ title= "#monology"},
            new RelatedBlog{ title= "#promting"},
            new RelatedBlog{ title= "#critisium"},
            new RelatedBlog{ title= "#mentor"},
            new RelatedBlog{ title= "#adventure"},
            new RelatedBlog{ title= "#capturing"},
            new RelatedBlog{ title= "#navigator"},
            new RelatedBlog{ title= "#mountain"},
            new RelatedBlog{ title= "#popsinger"},
            new RelatedBlog{ title= "#lyrists"},
            new RelatedBlog{ title= "#musicnotes"},
            new RelatedBlog{ title= "#multiplecovers"},
            new RelatedBlog{ title= "#facesact"},
            new RelatedBlog{ title= "#language"},
            new RelatedBlog{ title= "#fluency"},
        };       
        public List<RelatedBlog> GetTagsBlogData() => TagsBlogData;
        private List<RelatedBlog>  RecentPostsData  = new List<RelatedBlog>()
        {
            new RelatedBlog{ id= 1, img= "../assets/images/media/blog/14.jpg",titleColor="text-primary", title= "Nature", desc= " The Wonders of Nature",posted="18 Jan 2024, 15:46"},
            new RelatedBlog{ id= 2, img= "../assets/images/media/blog/15.jpg",titleColor="text-primary1", title= "Tourism", desc= "Embarking on a Tourism Journey",posted="20 Feb 2024, 03:03"},
            new RelatedBlog{ id= 3, img= "../assets/images/media/blog/16.jpg",titleColor="text-primary2", title= "Technology", desc= "Navigating the Digital Frontier",posted="05 Feb 2024, 16:23"},
            new RelatedBlog{ id= 4, img= "../assets/images/media/blog/17.jpg",titleColor="text-primary3", title= "Networking", desc= "More Designing on websites",posted="13 Mar 2024, 20:14"},
        };       
        public List<RelatedBlog> GetRecentPostsData() => RecentPostsData;
        private List<RelatedBlog>  BlogCommentsData  = new List<RelatedBlog>()
        {
            new RelatedBlog{ id= 1, img= "../assets/images/faces/3.jpg",title= "Mary Cateline", desc= "This blog captures the essence of why music is such a powerful force in our lives. It's not just about the sounds. Thank you for reminding us of the beauty and magic of music"},
            new RelatedBlog{ id= 2, img= "../assets/images/faces/13.jpg",title= "Monte vin", desc= "Reading your blog is like taking a journey into the heart of music itself. Your passion for the subject shines through in every word!"},
            new RelatedBlog{ id= 3, img= "../assets/images/faces/6.jpg",title= "Master Sets", desc= "The importance of carving out moments of stillness in our busy lives to simply listen and be present with the music. It's a powerful reminder that sometimes ."},
        };       
        public List<RelatedBlog> GetBlogCommentsData() => BlogCommentsData;
        private List<BlogCategories>  RelatedTopicsData  = new List<BlogCategories>()
        {
            new BlogCategories{ id= 1, icon= "ri-brush-fill",title= "Desiging", Count= "13",color="primary"},
            new BlogCategories{ id= 2, icon= "ri-pencil-fill",title= "Modern", Count= "36",color="primary1"},
            new BlogCategories{ id= 3, icon= "ri-microscope-fill",title= "Science", Count= "15",color="primary2"},
            new BlogCategories{ id= 4, icon= "ri-flight-takeoff-fill",title= "Trips", Count= "17",color="primary3"},
            new BlogCategories{ id= 5, icon= "ri-magic-fill",title= "Beauty", Count= "66",color="secondary"},
            new BlogCategories{ id= 6, icon= "ri-shirt-fill",title= "Styling", Count= "33",color="success"},
        };       
        public List<BlogCategories> GetRelatedTopicsData() => RelatedTopicsData;
    }
}