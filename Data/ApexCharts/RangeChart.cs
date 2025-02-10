
namespace RangeChartData
{
    public class Rangeareabasic
    {
        public string? Month { get; set; }
        public int?  HighestTemperature { get; set; }
        public int?  LowestTemperature { get; set; }

    }    
    public class Rangeareamixed
    {
        public string? Month { get; set; }
        public int? HighestTemperature { get; set; }
        public int? LowestTemperature { get; set; }
        public int? CurrentTemperature { get; set; }
        public int? HighestTemperature2 { get; set; }
        public int? LowestTemperature2 { get; set; }
        public int? CurrentTemperature2 { get; set; }
    }
    
    public class RangeChartService {
        public static List<Rangeareabasic> GetRangeareabasic(){
            return new List<Rangeareabasic>
            {
                new Rangeareabasic { Month = "Jan", HighestTemperature = -2, LowestTemperature = 4},
                new Rangeareabasic { Month = "Feb", HighestTemperature = -1, LowestTemperature = 6},
                new Rangeareabasic { Month = "Mar", HighestTemperature = 3, LowestTemperature = 10},
                new Rangeareabasic { Month = "Apr", HighestTemperature = 8, LowestTemperature = 16},
                new Rangeareabasic { Month = "May", HighestTemperature = 13, LowestTemperature = 22},
                new Rangeareabasic { Month = "Jun", HighestTemperature = 18, LowestTemperature = 26},
                new Rangeareabasic { Month = "Jul", HighestTemperature = 21, LowestTemperature = 29},
                new Rangeareabasic { Month = "Aug", HighestTemperature = 21, LowestTemperature = 28},
                new Rangeareabasic { Month = "Sep", HighestTemperature = 17, LowestTemperature = 24},
                new Rangeareabasic { Month = "Oct", HighestTemperature = 11, LowestTemperature = 18},
                new Rangeareabasic { Month = "Nov", HighestTemperature = 6, LowestTemperature = 12},
                new Rangeareabasic { Month = "Dec", HighestTemperature = 1, LowestTemperature = 7},
            };
        }
        public static List<Rangeareamixed> GetRangeareamixed()
        {
            return new List<Rangeareamixed>
            {
                new Rangeareamixed { Month = "Jan" , HighestTemperature = 3100 , LowestTemperature = 3400 , CurrentTemperature = 3300 , HighestTemperature2 = 1100 , LowestTemperature2 = 1900 , CurrentTemperature2 = 1500 },
                new Rangeareamixed { Month = "Feb" , HighestTemperature = 4200 , LowestTemperature = 5200 , CurrentTemperature = 4900 , HighestTemperature2 = 1200 , LowestTemperature2 = 1800 , CurrentTemperature2 = 1700 },
                new Rangeareamixed { Month = "Mar" , HighestTemperature = 3900 , LowestTemperature = 4900 , CurrentTemperature = 4300 , HighestTemperature2 = 900  , LowestTemperature2 = 2900 , CurrentTemperature2 = 1900 },
                new Rangeareamixed { Month = "Apr" , HighestTemperature = 3400 , LowestTemperature = 3900 , CurrentTemperature = 3700 , HighestTemperature2 = 1400 , LowestTemperature2 = 2700 , CurrentTemperature2 = 2200 },
                new Rangeareamixed { Month = "May" , HighestTemperature = 5100 , LowestTemperature = 5900 , CurrentTemperature = 5500 , HighestTemperature2 = 2600 , LowestTemperature2 = 3900 , CurrentTemperature2 = 3000 },
                new Rangeareamixed { Month = "Jun" , HighestTemperature = 5400 , LowestTemperature = 6700 , CurrentTemperature = 5900 , HighestTemperature2 = 500  , LowestTemperature2 = 1700 , CurrentTemperature2 = 1000 },
                new Rangeareamixed { Month = "Jul" , HighestTemperature = 4300 , LowestTemperature = 4600 , CurrentTemperature = 4500 , HighestTemperature2 = 1900 , LowestTemperature2 = 2300 , CurrentTemperature2 = 2100 },
                new Rangeareamixed { Month = "Aug" , HighestTemperature = 2100 , LowestTemperature = 2900 , CurrentTemperature = 2400 , HighestTemperature2 = 1000 , LowestTemperature2 = 1500 , CurrentTemperature2 = 1200 },
                new Rangeareamixed { Month = "Sep" , CurrentTemperature = 2100 , CurrentTemperature2 = 1800 },
                new Rangeareamixed { Month = "Oct" , CurrentTemperature = 1500 , CurrentTemperature2 = 2000 },
            };
        }
    }
}