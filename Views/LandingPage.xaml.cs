using MedicationApp.Views;
using MedicationApp.Views.PatientViews;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace MedicationApp.Pages
{
    public partial class LandingPage : Window
    {
        public string Username { get; set; }

        public LandingPage(string username)
        {
            InitializeComponent();
            Username = username;
            LoggedUser.Text = $"Hello, {username}!";
        }

        // Handle Popup for Hover Effects
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is Button button)
            {
                Popup.PlacementTarget = button;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                PopupText.Text = button.Content.ToString();
            }
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.IsOpen = false;
        }

        // Navigation Event Handlers for Button Clicks
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Home page
            MessageBox.Show("Navigating to Home Page.");
        }



      




        private void btnPatientList_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the PatientList window using the default constructor
            PatientList patientListPage = new PatientList();

            // Show the PatientList window
            patientListPage.Show();

            // Optionally close the current window
            this.Close();
        }








        private void btnCaregiverInfo_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Caregiver Info page
            MessageBox.Show("Navigating to Caregiver Info Page.");
        }

        private void btnMar_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Mar page
            MessageBox.Show("Navigating to MAR Page.");
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Schedule page
            MessageBox.Show("Navigating to Schedule Page.");
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Report page
            MessageBox.Show("Navigating to Report Page.");
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Perform logout action
            MessageBox.Show("Logging out...");
            this.Close(); // Close the Landing Page
        }
    }
}
