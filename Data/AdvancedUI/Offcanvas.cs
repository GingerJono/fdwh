
namespace OffcanvasData
{
    public class OffcanvasModel
    {
        public decimal OffcanvasId { get; set; }
        public string? OffcanvasClass { get; set; } 
        public string? Img { get; set; } 
        public string? Value { get; set; } 
        public string? ValueClass { get; set; } 
        public string? Title { get; set; } 
        public string? Time { get; set; } 
        public string? Date { get; set; } 
    }
    public class OffcanvasService {
        private List<OffcanvasModel> OffcanvasData = new List<OffcanvasModel>()
        {
            new OffcanvasModel { OffcanvasId= 1, Value= "NW" ,ValueClass="bg-primary",Title="New Website Created",Time="30 mins ago",Date="20 Mar 2024"},
            new OffcanvasModel { OffcanvasId= 2, Value= "CH" ,ValueClass="bg-danger",Title="Prepare for the new project",Time="2 hrs ago",Date="3 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 3, Value= "S" ,ValueClass="bg-info",Title="Decide the live discussion",Time="3 hrs ago",Date="17 Feb 2024"},
            new OffcanvasModel { OffcanvasId= 4, Img= "../assets/images/faces/12.jpg" ,Title="Meeting at 3:00 pm",Time="4 hrs ago",Date="29 May 2024"},
            new OffcanvasModel { OffcanvasId= 5, Value= "RC" ,ValueClass="bg-success",Title="Prepare for presentation",Time="4 hrs ago",Date="31 May 2024"},
            new OffcanvasModel { OffcanvasId= 6, Img= "../assets/images/faces/1.jpg" ,Title="Brenda New product launching",Time="7 hrs ago",Date="1 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 7, Value= "M" ,ValueClass="bg-secondary",Title="Medeleine Hey! there i'm available",Time="3 hrs ago",Date="5 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 8, Value= "OL" ,ValueClass="bg-info",Title="Olivia New schedule release",Time="45 mins ago",Date="6 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 9, Value= "A" ,ValueClass="bg-warning",Title="Kamala Preparing for new admin launch",Time="28 mins ago",Date="7 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 10, Img= "../assets/images/faces/6.jpg",Title="Oisha Meeting with clinet for dinner",Time="14 hrs ago",Date="10 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 11, Value= "CH" ,ValueClass="bg-danger",Title="Prepare for the new project",Time="2 hrs ago",Date="3 Jan 2024"},
            new OffcanvasModel { OffcanvasId= 12, Value= "S" ,ValueClass="bg-info",Title="Decide the live discussion",Time="3 hrs ago",Date="17 Feb 2024"},
            new OffcanvasModel { OffcanvasId= 13, Img= "../assets/images/faces/14.jpg" ,Title="Meeting at 3:00 pm",Time="4 hrs ago",Date="29 May 2024"},
            new OffcanvasModel { OffcanvasId= 14, Value= "RC" ,ValueClass="bg-primary",Title="Prepare for presentation",Time="4 hrs ago",Date="31 May 2024"},
        };
        public List<OffcanvasModel> GetOffcanvasData() => OffcanvasData;
    }
}