
namespace ToastData
{
    public class ToastElements {
        public string? ToastColor { get; set; }
        public string? ToastMessage { get; set; }
    };
    
    public class ToastService {

        public List<ToastElements> GetToast()
        {
            return new List<ToastElements>
            {
                new ToastElements { ToastColor="text-bg-primary ",ToastMessage=" Hello, world! This is the Primary toast."},
                new ToastElements { ToastColor="text-bg-secondary",ToastMessage="Hello, world! This is the Secondary toast."},
                new ToastElements { ToastColor="text-bg-warning",ToastMessage="Hello, world! This is the Warning toast."},
                new ToastElements { ToastColor="text-bg-info",ToastMessage="Hello, world! This is the info toast."},
            };
        }
    }
}