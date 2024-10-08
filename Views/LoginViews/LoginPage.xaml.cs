using System.Windows;
using System.Windows.Controls;

namespace MedicationApp.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            // 1. Get username and password
            string username = userText.Text;
            string password = passwordBox.Password;

            // 2. Authenticate user
            if (AuthenticateUser(username, password))
            {
                // If authentication successful:
                // Navigate to the main application window or landing page
                NavigationService.Navigate(new LandingPage());
            }

        private bool AuthenticateUser(string username, string password)
        {
            // Replace this with  actual authentication logic
            // This could involve checking against a database, an API, or any other authentication method.

            // Example: Simple hardcoded authentication (for demonstration only - NOT SECURE)
            if (username == "admin" && password == "password")
            {
                return true;
            }
            return false;
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the Create User page
            NavigationService.Navigate(new Views.UserViews.CreateUserPage());
        }
    }
}


