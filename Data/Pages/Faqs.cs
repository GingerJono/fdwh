
namespace FaqsData
{
    public class FaqsList
    {
        public decimal id { get; set; }
        public string? title { get; set; } 
        public string? desc { get; set; } 
    }
    public class FaqsService {
        
        private List<FaqsList>  FaqsListsData  = new List<FaqsList>()
        {
            new FaqsList{ id= 1,title= "1. Can I customize the admin template?", desc= " Yes, the admin template is fully customizable. You can modify the layout, color scheme, typography, and more to match your branding or design preferences."},
            new FaqsList{ id= 2,title= "2. How do I install the admin template?", desc= "Installing the admin template is straightforward. Simply download the template files and follow the included installation instructions provided in the documentation."},
            new FaqsList{ id= 3,title= "3. Is there a demo version available?", desc= "Yes, a demo version of the admin template is available for testing purposes. You can access the demo on our website and explore its features before making a purchase."},
            new FaqsList{ id= 4,title= "4. How do I integrate the admin template with my existing project?", desc= "Integrating the admin template with your existing project is simple. You can either copy the template files into your project directory or use package managers like npm or yarn for easy integration."},
            new FaqsList{ id= 5,title= "5. Does the admin template support responsive design?", desc= "Yes, the admin template is built with responsive design in mind. It is fully compatible with desktop, tablet, and mobile devices, ensuring a seamless user experience across all screen sizes."},

            new FaqsList{ id= 6,title= "1. How do I change the primary color of the theme?", desc= "Navigate to the 'Theme Settings' page, where you'll find options to choose a primary color and accent color. Select your desired colors and save the changes."},
            new FaqsList{ id= 7,title= " 2.  Can I customize the accent color of the theme?", desc= "Yes, you can customize the accent color of the theme to complement the primary color. Access the theme customization options and find the setting for 'Accent Color.''."},
            new FaqsList{ id= 8,title= " 3. Is it possible to set a background color for the theme?", desc= "Absolutely! You can set a background color for the theme by accessing the background settings in the customization panel. Select your desired color or upload a custom background image for a personalized touch."},
            new FaqsList{ id= 9,title= "4. How do I adjust the text color for different elements in the theme?", desc= "To adjust text color, navigate to the typography or text settings in the customization panel. You can set different text colors for headings, body text, links, and other text elements to ensure readability and visual consistency."},
            new FaqsList{ id= 10,title= "5. Are there options to customize hover and active states for links and buttons?", desc= "Yes, you can customize hover and active states for links and buttons to provide visual feedback to users.Look for settings related to link and button states in the customization"},

            new FaqsList{ id= 11,title= "1.  How do I add new users to the system?", desc= "Adding new users to the system is simple. As an admin, you can navigate to the user management section and select the option to add a new user."},
            new FaqsList{ id= 12,title= "2. Can I customize user roles and permissions?", desc= "Yes, you can customize user roles and permissions to control access to different parts of the system. As an admin, you can create custom roles with specific permissions and assign them to users as needed."},
            new FaqsList{ id= 13,title= "3.  How do I deactivate or delete a user account?", desc= "To deactivate or delete a user account, navigate to the user management section and select the option to edit the user account. From there, you can choose to deactivate or delete the account permanently."},
            new FaqsList{ id= 14,title= "4. Is there a way to import user data from an external source?", desc= "Yes, you can import user data from an external source such as a CSV file. There is usually an option available in the user management section to upload a CSV file"},
            new FaqsList{ id= 15,title= "5. Can users reset their own passwords?", desc= "Yes, users can typically reset their own passwords using a 'forgot password' feature. They will receive an email with instructions on how to reset their password securely."},

            new FaqsList{ id= 16,title= "1.  How do I set up secure authentication for my application?", desc= "Setting up secure authentication involves implementing encryption, strong password policies, and secure authentication methods like OAuth or JWT. Our documentation provides step-by-step instructions."},
            new FaqsList{ id= 17,title= "2. What are the best practices for securing user passwords?", desc= "Best practices for securing user passwords include using strong encryption algorithms (such as bcrypt), enforcing password complexity requirements, and regularly hashing and salting passwords."},
            new FaqsList{ id= 18,title= "3. Can I enable two-factor authentication (2FA) for added security?", desc= " Yes, our admin template supports two-factor authentication (2FA) as an additional layer of security. You can enable 2FA for user accounts to require users to provide a second form of verification, such as a code sent to their mobile device."},
            new FaqsList{ id= 19,title= "4.  session management handled securely in the admin template?", desc= "Yes, session management in the admin template is handled securely to prevent session hijacking and fixation attacks. We use secure cookies, session timeouts, and random session IDs to protect."},
            new FaqsList{ id= 20,title= "5. Can I restrict access to certain parts of the application based on user roles and permissions?", desc= "Yes, our admin template includes role-based access control (RBAC) functionality that allows you to define user roles and permissions and restrict access to certain features or data based on these roles."},

            new FaqsList{ id= 21,title= "1. Can I get help with customizing the admin template to fit my specific requirements?", desc= "Yes, our support team is available to assist with customizing the admin template to meet your specific needs. Contact us with details of your customization requirements, and we'll provide guidance and assistance as needed."},
            new FaqsList{ id= 22,title= "2. What should I do if I encounter an error while using the admin template?", desc= "If you encounter an error, first check the documentation for any troubleshooting tips or known issues. If the problem persists, please contact our support team for assistance."},
            new FaqsList{ id= 23,title= "3. How can I report a bug or issue with the admin template?", desc= "To report a bug or issue, please submit a detailed description of the problem along with any relevant screenshots or error messages to our support team. We'll investigate the issue and provide a resolution."},
            new FaqsList{ id= 24,title= "4.  I'm having trouble integrating the admin template with my project. What should I do?", desc= "If you're experiencing difficulties integrating the admin template with your project, refer to the documentation for step-by-step integration instructions. If you still need assistance, don't hesitate to reach out to our support team for help."},
            new FaqsList{ id= 25,title= "5. How do I troubleshoot performance issues with the admin template?", desc= "Performance issues may arise due to factors such as heavy resource usage, inefficient code, or server configuration issues. Check the documentation for optimization tips or contact our support team for assistance in diagnosing and resolving performance issues."},
            
        };       
        public List<FaqsList> GetFaqsListsData() => FaqsListsData;
    }
}