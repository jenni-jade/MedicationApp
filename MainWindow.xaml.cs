using MedicationApp.Pages;
using MedicationApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace MedicationApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public String loggedInUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();

            Main.Content = new Login();
            this.loggedInUser = "";
           
        }

       

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new LandingPage(loggedInUser);
        }

      
    }
}
