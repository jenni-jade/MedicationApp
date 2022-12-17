using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using MedicationApp.Models;

namespace MedicationApp.Pages
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void authenticate(String username)
        {
            Application.Current.MainWindow.Content = new LandingPage(username);
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            // Datbase code; comment out for now
            
            var username = userText.Text.ToString();
            var password = passwordText.Text.ToString();

            if (userText.Text.Equals("lance19") && passwordText.Text.Equals("Kamchatka2@"))
            {
                Application.Current.MainWindow.Content = new UserAdmin();
            }
            else {
                using (UserDataContext context = new UserDataContext())
                {
                    bool userFound = context.Users.Any(user => user.Username.Equals(username) && user.Password.Equals(password));
                    
                    if (userFound) authenticate(username);
                    else MessageBox.Show("Invalid Credentials");
                }
            }
           

            //Application.Current.MainWindow.Content = new LandingPage();

        }

       

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
