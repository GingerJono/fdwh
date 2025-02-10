
namespace ColorsData
{
    public class ColorsModel
    {
        public decimal ColorsId { get; set; }
        public string? ColorsClass { get; set; } 
    }
    public class ColorsService {
        private List<ColorsModel> ColorsData = new List<ColorsModel>()
        {
            new ColorsModel { ColorsId= 1, ColorsClass= "primary" },
            new ColorsModel { ColorsId= 2,  ColorsClass= "primary1" },
            new ColorsModel { ColorsId= 3, ColorsClass= "primary2" },
            new ColorsModel { ColorsId= 4, ColorsClass= "primary3" },
            new ColorsModel { ColorsId= 5, ColorsClass= "secondary" },
            new ColorsModel { ColorsId= 6, ColorsClass= "warning" },
            new ColorsModel { ColorsId= 7, ColorsClass= "info" },
            new ColorsModel { ColorsId= 8, ColorsClass= "success" },
            new ColorsModel { ColorsId= 9, ColorsClass= "danger" },
            new ColorsModel { ColorsId= 10, ColorsClass= "light" },
            new ColorsModel { ColorsId= 11, ColorsClass= "dark" },
            new ColorsModel { ColorsId= 12, ColorsClass= "muted" },
        };
        public List<ColorsModel> GetColorsData() => ColorsData;
        private List<ColorsModel> ColorsData2 = new List<ColorsModel>()
        {
            new ColorsModel { ColorsId= 1, ColorsClass= "-100" },
            new ColorsModel { ColorsId= 2,  ColorsClass= "-200" },
            new ColorsModel { ColorsId= 3, ColorsClass= "-300" },
            new ColorsModel { ColorsId= 4, ColorsClass= "-400" },
            new ColorsModel { ColorsId= 5, ColorsClass= "-500" },
            new ColorsModel { ColorsId= 6, ColorsClass= "-600" },
            new ColorsModel { ColorsId= 7, ColorsClass= "-700" },
            new ColorsModel { ColorsId= 8, ColorsClass= "-800" },
            new ColorsModel { ColorsId= 9, ColorsClass= "-900" },
            new ColorsModel { ColorsId= 10, ColorsClass= "" },
        };
        public List<ColorsModel> GetColorsData2() => ColorsData2;
    }
}