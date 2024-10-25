using MedicationApp.Models;
using MedicationApp.Views.PatientViews;
using MedicationApp.Views.UserViews; // Assuming this contains your LandingPage and CreateUserPage
using System.Windows;

namespace MedicationApp.Pages
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        // Sign In button click event handler
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            // Get the entered username and password (if needed)
            string loggedInUsername = userText.Text;
            string password = passwordBox.Password; // Retrieve password from the PasswordBox

            // Here, you could add logic to authenticate the user with a backend service or database
            // For now, let's assume any username/password combination is accepted for the sake of simplicity.

            if (string.IsNullOrWhiteSpace(loggedInUsername))
            {
                MessageBox.Show("Please enter a valid username.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Navigate to Landing Page (pass username to the LandingPage)
            LandingPage landingPage = new LandingPage(loggedInUsername);
            landingPage.Show();
            this.Close(); // Close the login page
        }

        // Create User button click event handler
        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Create User Page
            CreateUserPage createUserPage = new CreateUserPage();
            createUserPage.Show();
            this.Close(); // Optionally close the login page
        }
    }
}
