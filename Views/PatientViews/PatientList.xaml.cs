using MedicationApp.Pages;
using MedicationApp.Models;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using MedicationApp.Views;
using MedicationApp.Views.PatientViews;
using System.Windows.Controls.Primitives;
using System.Windows.Input;

namespace MedicationApp.Views.PatientViews
{
    public partial class PatientList : Window
    {
        public ObservableCollection<Patient> Patients { get; set; }
        public string Username { get; set; }

        public PatientList()
        {
            InitializeComponent();

            // Initialize the Patients collection with some sample data
            Patients = new ObservableCollection<Patient>
    {
        new Patient { PatientId = 111, Name = "Jennifer", Age = 40 },
        new Patient { PatientId = 222, Name = "Aiko", Age = 30 },
        new Patient { PatientId = 333, Name = "Jade", Age = 45 }
    };

            // Bind the Patients collection to the DataGrid
            PatientDataGrid.ItemsSource = Patients;
        }


        // View Patient button click event handler
        private void ViewPatient_Click(object sender, RoutedEventArgs e)
        {
            // Logic to view a selected patient's details
            if (PatientDataGrid.SelectedItem is Patient selectedPatient)
            {
                // Open the PatientDetails window and pass the selected patient and username
                PatientDetails patientDetailsPage = new PatientDetails(selectedPatient, Username);
                patientDetailsPage.Show();

                // Close the current PatientList window
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a patient to view.", "View Patient", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Logout button click event handler
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Show the login window and close the current window
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }

        // Add Patient button click event handler
        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            // Logic to add a new patient
            var newPatient = new Patient
            {
                PatientId = Patients.Count + 1,
                Name = "New Patient",
                Age = 0
            };
            Patients.Add(newPatient);
        }

        // Edit Patient button click event handler
        private void EditPatient_Click(object sender, RoutedEventArgs e)
        {
            // Logic to edit a selected patient
            if (PatientDataGrid.SelectedItem is Patient selectedPatient)
            {
                selectedPatient.Name = "Edited Name"; // Example modification
                PatientDataGrid.Items.Refresh(); // Refresh DataGrid to show updated information
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.", "Edit Patient", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Delete Patient button click event handler
        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {
            // Logic to delete a selected patient
            if (PatientDataGrid.SelectedItem is Patient selectedPatient)
            {
                Patients.Remove(selectedPatient);
            }
            else
            {
                MessageBox.Show("Please select a patient to delete.", "Delete Patient", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void PatientDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Handle selection change if needed
        }



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
            // Navigate to Home page (for example)
            MessageBox.Show("Navigating to Home Page.");
        }



        private void btnPatientList_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Patient List button clicked!");
        }

        private void btnCaregiverInfo_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to Caregiver Info page
            MessageBox.Show("Navigating to Caregiver Info Page.");
        }

        private void btnMar_Click(object sender, RoutedEventArgs e)
        {
            // Navigate to MAR page
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

        private void btnLogout_Click_Second(object sender, RoutedEventArgs e)  // Changed to avoid conflicting names
        {
            // Perform logout action and navigate back to login page
            MessageBox.Show("Logging out...");
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close(); // Close the current window
        }
    }
}