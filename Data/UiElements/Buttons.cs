
namespace ButtonData
{
    public class ButtonElements {
        public int ButtonId { get; set; } 
        public string? ButtonClass { get; set; } 
        public string? ButtonText { get; set; }
        public string? ButtonType { get; set; } 
        public string? ButtonIcon { get; set; } 
        public string? ButtonSize { get; set; }
        public bool IsRounded { get; set; }
    };
    
    public class ButtonsService {
        private List<ButtonElements> Button1Data = new List<ButtonElements>()
        { 
            new ButtonElements { ButtonClass = "btn-primary" , ButtonText = "Primary"},
            new ButtonElements { ButtonClass = "btn-primary1" , ButtonText = "Primary1"},
            new ButtonElements { ButtonClass = "btn-primary2" , ButtonText = "Primary2"},
            new ButtonElements { ButtonClass = "btn-primary3" , ButtonText = "Primary3"},
            new ButtonElements { ButtonClass = "btn-secondary" , ButtonText = "Secondary"},
            new ButtonElements { ButtonClass = "btn-success" , ButtonText = "Success"},
            new ButtonElements { ButtonClass = "btn-danger" , ButtonText = "Danger"},
            new ButtonElements { ButtonClass = "btn-warning" , ButtonText = "Warning"},
            new ButtonElements { ButtonClass = "btn-info" , ButtonText = "Info"},
            new ButtonElements { ButtonClass = "btn-purple" , ButtonText = "Purple"},
            new ButtonElements { ButtonClass = "btn-teal" , ButtonText = "Teal"},
            new ButtonElements { ButtonClass = "btn-orange" , ButtonText = "orange"},
        };
        public List<ButtonElements> GetButton1()
        {
            return Button1Data;
        }
        private List<ButtonElements> Button2Data = new List<ButtonElements>()
        { 
            new ButtonElements { ButtonClass = "btn-primary" , ButtonText = "Primary"},
            new ButtonElements { ButtonClass = "btn-primary1" , ButtonText = "Primary1"},
            new ButtonElements { ButtonClass = "btn-primary2" , ButtonText = "Primary2"},
            new ButtonElements { ButtonClass = "btn-primary3" , ButtonText = "Primary3"},
            new ButtonElements { ButtonClass = "btn-secondary" , ButtonText = "Secondary"},
            new ButtonElements { ButtonClass = "btn-success" , ButtonText = "Success"},
            new ButtonElements { ButtonClass = "btn-danger" , ButtonText = "Danger"},
            new ButtonElements { ButtonClass = "btn-warning" , ButtonText = "Warning"},
            new ButtonElements { ButtonClass = "btn-info" , ButtonText = "Info"},
            new ButtonElements { ButtonClass = "btn-light" , ButtonText = "Light"},
            new ButtonElements { ButtonClass = "btn-dark" , ButtonText = "Dark"},
            new ButtonElements { ButtonClass = "btn-link" , ButtonText = "Link"},
        };
        public List<ButtonElements> GetButton2()
        {
            return Button2Data;
        }
        private List<ButtonElements> Button3Data = new List<ButtonElements>()
        { 
            new ButtonElements { ButtonClass = "btn-outline-primary" , ButtonText = "Primary"},
            new ButtonElements { ButtonClass = "btn-outline-primary1" , ButtonText = "Primary1"},
            new ButtonElements { ButtonClass = "btn-outline-primary2" , ButtonText = "Primary2"},
            new ButtonElements { ButtonClass = "btn-outline-primary3" , ButtonText = "Primary3"},
            new ButtonElements { ButtonClass = "btn-outline-secondary" , ButtonText = "Secondary"},
            new ButtonElements { ButtonClass = "btn-outline-success" , ButtonText = "Success"},
            new ButtonElements { ButtonClass = "btn-outline-danger" , ButtonText = "Danger"},
            new ButtonElements { ButtonClass = "btn-outline-warning" , ButtonText = "Warning"},
            new ButtonElements { ButtonClass = "btn-outline-info" , ButtonText = "Info"},
            new ButtonElements { ButtonClass = "btn-outline-light" , ButtonText = "Light"},
            new ButtonElements { ButtonClass = "btn-outline-dark" , ButtonText = "Dark"},
        };
        public List<ButtonElements> GetButton3()
        {
            return Button3Data;
        }
        private List<ButtonElements> Button4Data = new List<ButtonElements>()
        { 
            new ButtonElements { ButtonClass = "btn-icon btn-primary" , ButtonIcon = "ri-bank-fill",ButtonSize="btn-sm"},
            new ButtonElements { ButtonClass = "btn-icon btn-info" , ButtonIcon = "ri-medal-line",ButtonSize=""},
            new ButtonElements { ButtonClass = "btn-icon btn-danger" , ButtonIcon = "ri-archive-line",ButtonSize="btn-lg"},
            new ButtonElements { ButtonClass = "btn-icon btn-warning" , ButtonIcon = "ri-calendar-2-line",ButtonSize=""},
            new ButtonElements { ButtonClass = "btn-icon btn-primary-light" , ButtonIcon = "ri-home-smile-line",ButtonSize="btn-sm"},
            new ButtonElements { ButtonClass = "btn-icon btn-secondary-light" , ButtonIcon = "ri-delete-bin-line",ButtonSize=""},
            new ButtonElements { ButtonClass = "btn-icon btn-success-light" , ButtonIcon = "ri-notification-3-line",ButtonSize="btn-lg"},
            new ButtonElements { ButtonClass = "btn-icon btn-danger-light" , ButtonIcon = "ri-chat-settings-line",ButtonSize=""},
            new ButtonElements { ButtonClass = "btn-icon btn-outline-primary" , ButtonIcon = "ri-phone-line",ButtonSize="btn-sm"},
            new ButtonElements { ButtonClass = "btn-icon btn-outline-teal" , ButtonIcon = "ri-customer-service-2-line",ButtonSize=""},
            new ButtonElements { ButtonClass = "btn-icon btn-outline-success" , ButtonIcon = "ri-live-line",ButtonSize="btn-lg"},
            new ButtonElements { ButtonClass = "btn-icon btn-outline-secondary" , ButtonIcon = "ri-save-line",ButtonSize=""},

            new ButtonElements { ButtonClass = "btn-icon btn-facebook" , ButtonIcon = "ri-facebook-line"},
            new ButtonElements { ButtonClass = "btn-icon btn-twitter" , ButtonIcon = "ri-twitter-x-line"},
            new ButtonElements { ButtonClass = "btn-icon btn-instagram" , ButtonIcon = "ri-instagram-line"},
            new ButtonElements { ButtonClass = "btn-icon btn-github" , ButtonIcon = "ri-github-line"},
            new ButtonElements { ButtonClass = "btn-icon btn-youtube" , ButtonIcon = "ri-youtube-line"},
            new ButtonElements { ButtonClass = "btn-icon btn-google" , ButtonIcon = "ri-google-line"},
        };
        public List<ButtonElements> GetButton4()
        {
            return Button4Data;
        }
        private List<ButtonElements> Button5Data = new List<ButtonElements>()
        { 
            new ButtonElements { ButtonClass = "btn-info custom-button" , ButtonText = "Twitter",ButtonIcon = "ri-twitter-x-line text-info",IsRounded =true},
            new ButtonElements { ButtonClass = "btn-teal-light btn-border-down" , ButtonText = "Border"},
            new ButtonElements { ButtonClass = "btn-secondary-light btn-border-start" , ButtonText = "Border"},
            new ButtonElements { ButtonClass = "btn-purple-light btn-border-end" , ButtonText = "Border"},
            new ButtonElements { ButtonClass = "btn-warning-light btn-border-top" , ButtonText = "Border"},
            new ButtonElements { ButtonClass = "btn-secondary btn-glare" , ButtonText = "Glare Button"},
            new ButtonElements { ButtonClass = "btn-danger btn-hover btn-hover-animate" , ButtonText = "Like"},
            new ButtonElements { ButtonClass = "btn-success btn-darken-hover" , ButtonText = "Hover"},
            new ButtonElements { ButtonClass = "btn-orange btn-custom-border" , ButtonText = "Hover"},
        };
        public List<ButtonElements> GetButton5()
        {
            return Button5Data;
        }
    }
}