
namespace ProgressData
{
    public class ProgressElements {
        public string? ProgressClass { get; set; }
        public string? ProgressValue { get; set; }
        public string? ProgressColor { get; set; }
        public string? ProgressSize { get; set; }
    };
    
    public class ProgressService {

        public List<ProgressElements> GetProgress()
        {
            return new List<ProgressElements>
            {
                new ProgressElements { ProgressValue="10",ProgressColor=""},
                new ProgressElements { ProgressValue="25",ProgressColor="secondary"},
                new ProgressElements { ProgressValue="50",ProgressColor="success"},
                new ProgressElements { ProgressValue="75",ProgressColor="info"},
                new ProgressElements { ProgressValue="100",ProgressColor="warning"},
            };
        }
        public List<ProgressElements> GetProgress1()
        {
            return new List<ProgressElements>
            {
                new ProgressElements { ProgressValue="10",ProgressColor=""},
                new ProgressElements { ProgressValue="20",ProgressColor="secondary"},
                new ProgressElements { ProgressValue="40",ProgressColor="success"},
                new ProgressElements { ProgressValue="60",ProgressColor="info"},
                new ProgressElements { ProgressValue="80",ProgressColor="warning"},
            };
        }
        public List<ProgressElements> GetProgress2()
        {
            return new List<ProgressElements>
            {
                new ProgressElements {ProgressValue="10",ProgressSize="progress-xs"},
                new ProgressElements {ProgressValue="25",ProgressSize="progress-sm"},
                new ProgressElements {ProgressValue="50",ProgressSize=""},
                new ProgressElements {ProgressValue="75",ProgressSize="progress-lg"},
                new ProgressElements {ProgressValue="100",ProgressSize="progress-xl"},
            };
        }
        public List<ProgressElements> GetProgress3()
        {
            return new List<ProgressElements>
            {
                new ProgressElements {ProgressColor="secondary",ProgressValue="20"},
                new ProgressElements {ProgressColor="warning",ProgressValue="40"},
                new ProgressElements {ProgressColor="info",ProgressValue="60"},
                new ProgressElements {ProgressColor="success",ProgressValue="80"},
                new ProgressElements {ProgressColor="danger",ProgressValue="100"},
            };
        }
    }
}