
namespace AlertData
{
    public class AlertModel
    {
        public string? AlertText { get; set; }
        public string? AlertClass { get; set; } 
        public string? AlertImage { get; set; } 
        public string? Alertsvg { get; set; }
        public string? AlertSizes { get; set; }
    }
    public class AlertService {

        private List<AlertModel> Alert1Data = new List<AlertModel>()
        {
            new AlertModel { AlertClass = "alert-primary" , AlertText = "A simple primary alert—check it out!"},
            new AlertModel { AlertClass = "alert-primary1" , AlertText = " A simple primary1 alert—check it out!"},
            new AlertModel { AlertClass = "alert-primary2" , AlertText = " A simple primary2 alert—check it out!"},
            new AlertModel { AlertClass = "alert-primary3" , AlertText = "A simple primary3 alert—check it out!"},
            new AlertModel { AlertClass = "alert-secondary" , AlertText = "A simple secondary alert—check it out!"},
            new AlertModel { AlertClass = "alert-success" , AlertText = "A simple success alert—check it out!"},
            new AlertModel { AlertClass = "alert-danger" , AlertText = "A simple danger alert—check it out!"},
            new AlertModel { AlertClass = "alert-warning" , AlertText = "A simple warning alert—check it out!"},
            new AlertModel { AlertClass = "alert-info" , AlertText = "A simple info alert—check it out!"},
            new AlertModel { AlertClass = "alert-light" , AlertText = "A simple light alert—check it out!"},
            new AlertModel { AlertClass = "alert-dark" , AlertText = "A simple dark alert—check it out!"},
        };
        public List<AlertModel> GetAlert1()
        {
            return Alert1Data;
        }
        private List<AlertModel> Alert2Data = new List<AlertModel>()
        {
            new AlertModel { AlertClass = "alert-primary" , AlertText = "A simple primary alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-primary1" , AlertText = " A simple primary1 alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-primary2" , AlertText = " A simple primary2 alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-primary3" , AlertText = "A simple primary3 alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-secondary" , AlertText = "A simple secondary alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-success" , AlertText = "A simple success alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-danger" , AlertText = "A simple danger alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-warning" , AlertText = "A simple warning alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-info" , AlertText = "A simple info alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-light" , AlertText = "A simple light alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
            new AlertModel { AlertClass = "alert-dark" , AlertText = "A simple dark alert with <a href='javascript:void(0);' class='alert-link'>an example link</a>.Give it a click if you like."},
        };
        public List<AlertModel> GetAlert2()
        {
            return Alert2Data;
        }
        private List<AlertModel>? Alert3 { get; set; } = new List<AlertModel>();
        public List<AlertModel> GetAlert3()
        {
            return Alert3 ?? new List<AlertModel>();
        }
        public void AddNewAlert()
        {
            Alert3?.Add(new AlertModel
            {
                AlertClass = "alert-success mb-2",
                AlertText = "Nice, you triggered this alert message!"
            });
        }
        private List<AlertModel> Alert4Data = new List<AlertModel>()
        {
            new AlertModel { AlertClass = "svg-primary alert-primary custom-alert-icon shadow-sm" , Alertsvg = "<svg class='me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0z' fill='none'></path><path d='M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm1 15h-2v-6h2v6zm0-8h-2V7h2v2z'></path></svg>" , AlertText="A customized primary alert with an icon"},
            new AlertModel { AlertClass = "svg-secondary alert-secondary custom-alert-icon shadow-sm" , Alertsvg = "<svg class='me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0z' fill='none'></path><path d='M12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm-2 15l-5-5 1.41-1.41L10 14.17l7.59-7.59L19 8l-9 9z'></path></svg>" , AlertText="A customized secondary alert with an icon"},
            new AlertModel { AlertClass = "svg-warning alert-warning custom-alert-icon shadow-sm" , Alertsvg = "<svg class='me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0z' fill='none'></path><path d='M1 21h22L12 2 1 21zm12-3h-2v-2h2v2zm0-4h-2v-4h2v4z'></path></svg>" , AlertText="A customized warning alert with an icon"},
            new AlertModel { AlertClass = "svg-danger alert-danger custom-alert-icon shadow-sm" , Alertsvg = "<svg class='me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0z' fill='none'></path><path d='M15.73 3H8.27L3 8.27v7.46L8.27 21h7.46L21 15.73V8.27L15.73 3zM12 17.3c-.72 0-1.3-.58-1.3-1.3 0-.72.58-1.3 1.3-1.3.72 0 1.3.58 1.3 1.3 0 .72-.58 1.3-1.3 1.3zm1-4.3h-2V7h2v6z'></path></svg>" , AlertText="A customized danger alert with an icon"},

            new AlertModel { AlertClass = "alert-primary svg-primary d-flex align-items-center" , Alertsvg = "<svg class='flex-shrink-0 me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0V0z' fill='none'></path><path d='M11 7h2v2h-2zm0 4h2v6h-2zm1-9C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm0 18c-4.41 0-8-3.59-8-8s3.59-8 8-8 8 3.59 8 8-3.59 8-8 8z'></path></svg>" , AlertText="An example alert with an icon"},
            new AlertModel { AlertClass = "alert-success svg-success d-flex align-items-center" , Alertsvg = "<svg class='flex-shrink-0 me-2' xmlns='http://www.w3.org/2000/svg' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><path d='M0 0h24v24H0V0zm0 0h24v24H0V0z' fill='none'></path><path d='M16.59 7.58L10 14.17l-3.59-3.58L5 12l5 5 8-8zM12 2C6.48 2 2 6.48 2 12s4.48 10 10 10 10-4.48 10-10S17.52 2 12 2zm0 18c-4.42 0-8-3.58-8-8s3.58-8 8-8 8 3.58 8 8-3.58 8-8 8z'></path></svg>" , AlertText="An example success alert with an icon"},
            new AlertModel { AlertClass = "alert-warning svg-warning d-flex align-items-center" , Alertsvg = "<svg class='flex-shrink-0 me-2' xmlns='http://www.w3.org/2000/svg' enable-background='new 0 0 24 24' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><g><rect fill='none' height='24' width='24'></rect></g><g><g><g><path d='M12,5.99L19.53,19H4.47L12,5.99 M12,2L1,21h22L12,2L12,2z'></path><polygon points='13,16 11,16 11,18 13,18'></polygon><polygon points='13,10 11,10 11,15 13,15'></polygon></g></g></g></svg>" , AlertText="An example warning alert with an icon"},
            new AlertModel { AlertClass = "alert-danger svg-danger d-flex align-items-center" , Alertsvg = "<svg class='flex-shrink-0 me-2' xmlns='http://www.w3.org/2000/svg' enable-background='new 0 0 24 24' height='1.5rem' viewBox='0 0 24 24' width='1.5rem' fill='#000000'><g><rect fill='none' height='24' width='24'></rect></g><g><g><g><path d='M15.73,3H8.27L3,8.27v7.46L8.27,21h7.46L21,15.73V8.27L15.73,3z M19,14.9L14.9,19H9.1L5,14.9V9.1L9.1,5h5.8L19,9.1V14.9z'></path><rect height='6' width='2' x='11' y='7'></rect><rect height='2' width='2' x='11' y='15'></rect></g></g></g></svg>" , AlertText="An example danger alert with an icon"},

        };
        public List<AlertModel> GetAlert4()
        {
            return Alert4Data;
        }
        private List<AlertModel> Alert5Data = new List<AlertModel>()
        {
             new AlertModel { AlertClass = "alert-img alert-primary flex-wrap" , AlertText = "A simple primary alert with image—check it out!",AlertImage = "../assets/images/faces/3.jpg",AlertSizes="avatar-xs"},
            new AlertModel { AlertClass = "alert-img alert-primary1 flex-wrap" , AlertText = " A simple primary1 alert with image—check it out!",AlertImage = "../assets/images/faces/9.jpg",AlertSizes="avatar-xs"},
            new AlertModel { AlertClass = "alert-img alert-primary2 flex-wrap" , AlertText = " A simple primary2 alert with image—check it out!",AlertImage = "../assets/images/faces/12.jpg",AlertSizes="avatar-xs"},
            new AlertModel { AlertClass = "alert-img alert-primary3 flex-wrap" , AlertText = "A simple primary3 alert with image—check it out!",AlertImage = "../assets/images/faces/15.jpg",AlertSizes="avatar-xs"},
            new AlertModel { AlertClass = "alert-img alert-secondary flex-wrap" , AlertText = "A simple secondary alert with image—check it out!",AlertImage = "../assets/images/faces/5.jpg",AlertSizes="avatar-sm"},
            new AlertModel { AlertClass = "alert-img alert-warning flex-wrap" , AlertText = "A simple warning alert with image—check it out!",AlertImage = "../assets/images/faces/8.jpg",AlertSizes=""},
            new AlertModel { AlertClass = "alert-img alert-danger flex-wrap" , AlertText = "A simple danger alert with image—check it out!",AlertImage = "../assets/images/faces/13.jpg",AlertSizes="avatar-md"},
            new AlertModel { AlertClass = "alert-img alert-info flex-wrap" , AlertText = "A simple info alert with image—check it out!",AlertImage = "../assets/images/faces/11.jpg",AlertSizes="avatar-lg"},
            new AlertModel { AlertClass = "alert-img alert-dark flex-wrap" , AlertText = "A simple dark alert with image—check it out!",AlertImage = "../assets/images/faces/15.jpg",AlertSizes="avatar-xl"},
            new AlertModel { AlertClass = "alert-img alert-light flex-wrap" , AlertText = "A simple light alert with image—check it out!",AlertImage = "../assets/images/faces/10.jpg",AlertSizes=""},
        };
        public List<AlertModel> GetAlert5()
        {
            return Alert5Data;
        }
    }
}