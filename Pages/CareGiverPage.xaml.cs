using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MedicationApp.Pages
{
    /// <summary>
    /// Interaction logic for CareGiverPage.xaml
    /// </summary>
    public partial class CareGiverPage : Page
    {
        private String username;
        public CareGiverPage(String username)
        {
            InitializeComponent();
            this.username = username;
            LoggedUser.Text = username;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new LandingPage(username);
        }

        private void Mar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Mar(this.username);
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new ClientInfoPage(this.username);
        }

        private void To_login(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Login();
        }

        private void Caregiver_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new CareGiverPage(this.username);
        }
    }
}
