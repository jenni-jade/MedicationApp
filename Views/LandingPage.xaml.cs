using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Navigation;
using MedicationApp.Pages;


namespace MedicationApp.Pages
{
  
    // Interaction logic for LandingPage.xaml
    // </summary>
    public partial class LandingPage : Page
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        // Handle Sidebar Popups for Mouse Hover Events
        private void btnHome_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnHome;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Home"; // Use PopupText directly
        }

        private void btnHome_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        private void btnPatientInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnPatientInfo;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Patient Info";
        }

        private void btnPatientInfo_Click(object sender, MouseEventArgs e)
        {
            NavigationService.Navigate(new Uri("Views/PatientViews/PatientList.xaml", UriKind.Relative));
        }

     
        private void btnPatientInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }




        private void btnCaregiverInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnCaregiverInfo;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Caregiver Info";
        }

        private void btnCaregiverInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        private void btnMar_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnMar;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Mar";
        }

        private void btnMar_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        private void btnSchedule_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnSchedule;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Schedule";
        }

        private void btnSchedule_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        private void btnReport_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnReport;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Report";
        }

        private void btnReport_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        private void btnLogout_MouseEnter(object sender, MouseEventArgs e)
        {
            Popup.PlacementTarget = btnLogout;
            Popup.Placement = PlacementMode.Right;
            Popup.IsOpen = true;
            PopupText.Text = "Logout";
        }

        private void btnLogout_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        // Navigation Event Handlers for Button Clicks



        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Home page
            NavigationService.Navigate(new Uri("Pages/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnPatientInfo_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to the PatientInfoPage
            NavigationService.Navigate(new Uri("Pages/PatientInfoPage.xaml", UriKind.Relative));

        }


        private void btnCaregiverInfo_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Caregiver Info page
            NavigationService.Navigate(new Uri("Pages/CaregiverInfo.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnMar_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Mar page
            NavigationService.Navigate(new Uri("Pages/Mar.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Schedule page
            NavigationService.Navigate(new Uri("Pages/Schedule.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Report page
            NavigationService.Navigate(new Uri("Pages/Report.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Logout or perform logout action
            NavigationService.Navigate(new Uri("Pages/Login.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Landing_Navigated(object sender, NavigationEventArgs e)
        {
            // Handle page navigation events if necessary
        }
    }
}