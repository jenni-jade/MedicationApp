using MedicationApp.Models;
using MedicationApp.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Threading;

namespace MedicationApp.Views.PatientViews
{
    public partial class PatientDetails : Window
    {
        public Patient SelectedPatient { get; }
        public string Username { get; }

     
        public PatientDetails(Patient patient, string username)
        {
            InitializeComponent();
            this.SelectedPatient = patient;
        }
            private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Show the popup for submission confirmation
            SubmitPopup.IsOpen = true;

            // Close the popup after 2 seconds
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(2);
            timer.Tick += (s, args) =>
            {
                SubmitPopup.IsOpen = false;
                timer.Stop();
            };
            timer.Start();

            // Clear all text fields
            txtPatientId.Clear();
            txtName.Clear();
            txtAge.Clear();
            dpBirthdate.SelectedDate = null;
            txtHeight.Clear();
            txtPrimaryInsurance.Clear();
            txtIDNumber.Clear();
            txtGroupNumber.Clear();
            txtPolicyHolder.Clear();
            txtInsurancePhoneNumber.Clear();

            // Uncheck all checkboxes
            UncheckAllCheckBoxes();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset the form fields just like the Submit button
            txtPatientId.Clear();
            txtName.Clear();
            txtAge.Clear();
            dpBirthdate.SelectedDate = null;
            txtHeight.Clear();
            txtPrimaryInsurance.Clear();
            txtIDNumber.Clear();
            txtGroupNumber.Clear();
            txtPolicyHolder.Clear();
            txtInsurancePhoneNumber.Clear();

            // Uncheck all checkboxes
            UncheckAllCheckBoxes();
        }

        private void UncheckAllCheckBoxes()
        {
            chkIsDNR.IsChecked = false;
            chkIsDNRArrest.IsChecked = false;
            chkIsFullCode.IsChecked = false;
            chkIsComfortMeasOnly.IsChecked = false;
            chkIsLivingWill.IsChecked = false;
            chkIsPowerOfAttorney.IsChecked = false;
            chkIsCopyOnFile.IsChecked = false;
            chkIsNCFEligible.IsChecked = false;
            chkIsFallRisk.IsChecked = false;
            chkIsHOH.IsChecked = false;
            chkIsDisoriented.IsChecked = false;
            chkIsDialysis.IsChecked = false;
            chkIsVulnerable.IsChecked = false;
            chkIsDisabled.IsChecked = false;
            chkIsEscortRequired.IsChecked = false;
            chkIsFrail.IsChecked = false;
            chkIsAlert.IsChecked = false;

            // Additional checkboxes for Services and Home Management sections
            chkIsSN.IsChecked = false;
            chkIsPT.IsChecked = false;
            chkIsOT.IsChecked = false;
            chkIsST.IsChecked = false;
            chkIsMSW.IsChecked = false;
            chkIsHHA.IsChecked = false;
            chkIsHMKR.IsChecked = false;
            chkIsCompanion.IsChecked = false;
            chkIshousekeeper.IsChecked = false;
            chkIsTeleReasurance.IsChecked = false;
            chkIsHomefriend.IsChecked = false;
            chkIsNutrition.IsChecked = false;
            chkIsIV.IsChecked = false;
            chkIsRespite.IsChecked = false;
            chkIsChaplin.IsChecked = false;
            chkIsMusic.IsChecked = false;

            chkIsAmbulation.IsChecked = false;
            chkIsHearing.IsChecked = false;
            chkIsVision.IsChecked = false;
            chkIsSpeech.IsChecked = false;
            chkIsOriented.IsChecked = false;
            chkIsPleasant.IsChecked = false;
            chkIsPassive.IsChecked = false;
            chkIsDepressed.IsChecked = false;
            chkIsAgitated.IsChecked = false;
            chkIsHostile.IsChecked = false;
            chkIsParalysis.IsChecked = false;
            chkIsCat.IsChecked = false;
            chkIsDog.IsChecked = false;
            chkIsSmokes.IsChecked = false;
            chkIsOther.IsChecked = false;
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Show a confirmation message
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                // Navigate to LoginPage
                LoginPage loginPage = new LoginPage();
                loginPage.Show();

                // Close the current window
                this.Close();
            }
        }

        // Navigation button handlers (for completeness, adjust these as needed)
        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Home Page.");
        }

        private void btnPatientList_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Patient List button clicked!");
        }

        private void btnCaregiverInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Caregiver Info Page.");
        }

        private void btnMar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to MAR Page.");
        }

        private void btnSchedule_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Schedule Page.");
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Navigating to Report Page.");
        }

        private void chkIsPowerOfAttorney_Checked(object sender, RoutedEventArgs e)
        {
            // Handle the Power of Attorney checkbox check event if needed
        }

        // Scroll to specific sections
        private void ScrollToPersonalInfo(object sender, RoutedEventArgs e)
        {
            PersonalInfoGroupBox.BringIntoView();
        }

        private void ScrollToInsuranceInfo(object sender, RoutedEventArgs e)
        {
            InsuranceInfoGroupBox.BringIntoView();
        }

        private void ScrollToPriorities(object sender, RoutedEventArgs e)
        {
            PrioritiesGroupBox.BringIntoView();
        }

        private void ScrollToServices(object sender, RoutedEventArgs e)
        {
            ServicesGroupBox.BringIntoView();
        }

        private void ScrollToHomeManagement(object sender, RoutedEventArgs e)
        {
            HomeManagementGroupBox.BringIntoView();
        }
    }
}
