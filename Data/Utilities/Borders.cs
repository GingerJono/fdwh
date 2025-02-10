
namespace BorderData
{
    public class BorderModel
    {
        public decimal BorderId { get; set; }
        public string? BorderClass { get; set; } 
    }
    public class BorderService {
        private List<BorderModel> BorderData = new List<BorderModel>()
        {
            new BorderModel { BorderId= 1, BorderClass= "border" },
            new BorderModel { BorderId= 2,  BorderClass= "border-top" },
            new BorderModel { BorderId= 3, BorderClass= "border-end" },
            new BorderModel { BorderId= 3, BorderClass= "border-bottom" },
            new BorderModel { BorderId= 3, BorderClass= "border-start" },
        };
        public List<BorderModel> GetBorderData() => BorderData;
        private List<BorderModel> BorderData2 = new List<BorderModel>()
        {
            new BorderModel { BorderId= 1, BorderClass= "primary"},
            new BorderModel { BorderId= 2, BorderClass= "primary1"},
            new BorderModel { BorderId= 3, BorderClass= "primary2"},
            new BorderModel { BorderId= 4, BorderClass= "primary3"},
            new BorderModel { BorderId= 5, BorderClass= "secondary"},
            new BorderModel { BorderId= 6, BorderClass= "success"},
            new BorderModel { BorderId= 7, BorderClass= "danger"},
            new BorderModel { BorderId= 8, BorderClass= "warning"},
            new BorderModel { BorderId= 9, BorderClass= "info"},
            new BorderModel { BorderId= 10, BorderClass= "light"},
            new BorderModel { BorderId= 11, BorderClass= "dark"},
            new BorderModel { BorderId= 12, BorderClass= "white"},
        };
        public List<BorderModel> GetBorderData2() => BorderData2;
        private List<BorderModel> BorderData3 = new List<BorderModel>()
        {
            new BorderModel { BorderId= 0, BorderClass= "0"},
            new BorderModel { BorderId= 1, BorderClass= "1"},
            new BorderModel { BorderId= 2, BorderClass= "2"},
            new BorderModel { BorderId= 3, BorderClass= "3"},
            new BorderModel { BorderId= 4, BorderClass= "4"},
            new BorderModel { BorderId= 5, BorderClass= "5"},
        };
        public List<BorderModel> GetBorderData3() => BorderData3;
        private List<BorderModel> BorderData4 = new List<BorderModel>()
        {
            new BorderModel { BorderId= 1, BorderClass= "rounded"},
            new BorderModel { BorderId= 1, BorderClass= "rounded-top"},
            new BorderModel { BorderId= 1, BorderClass= "rounded-end"},
            new BorderModel { BorderId= 1, BorderClass= "rounded-bottom"},
            new BorderModel { BorderId= 1, BorderClass= "rounded-start"},
            new BorderModel { BorderId= 1, BorderClass= "rounded-circle"},
            new BorderModel { BorderId= 1, BorderClass= " rounded-pill"},
        };
        public List<BorderModel> GetBorderData4() => BorderData4;
    }
}