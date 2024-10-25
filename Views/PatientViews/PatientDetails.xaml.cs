using MedicationApp.Models;
using MedicationApp.Pages;
using System.Windows;
using System.Windows.Controls;

namespace MedicationApp.Views.PatientViews
{
    public partial class PatientDetails : Window
    {
      
        private Patient _patient; // Store the patient object


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
            PrioritiesGroupBox.BringIntoView();

        }


        public string Username { get; set; }
        public Patient CurrentPatient { get; set; }



        // Constructor that accepts both a Patient object and username to display patient details
        public PatientDetails(Patient patient, string username)
        {
            InitializeComponent();
            CurrentPatient = patient;
            Username = username;
            LoggedUser.Text = $"{username}";
            _patient = patient;

            // Assign the patient details to the UI elements
            txtPatientId.Text = patient.PatientId.ToString();
            txtName.Text = patient.Name;
            txtAge.Text = patient.Age.ToString();
            dpBirthdate.SelectedDate = patient.DateOfBirth;
            txtHeight.Text = patient.Height.ToString();

            // Set the checkbox states based on the patient's properties
            SetCheckBoxStates();

            // Add event handlers for checkboxes to track changes
            RegisterCheckBoxEvents();
        }

        // Function to set the checkboxes' initial states based on patient data
        private void SetCheckBoxStates()
        {
            chkIsDNR.IsChecked = _patient.IsDNR;
            chkIsDNRArrest.IsChecked = _patient.IsDNRArrest;
            chkIsFullCode.IsChecked = _patient.IsFullCode;
            chkIsComfortMeasOnly.IsChecked = _patient.IsComfortMeasOnly;
            chkIsLivingWill.IsChecked = _patient.IsLivingWill;
            chkIsPowerOfAttorney.IsChecked = _patient.IsPowerOfAttorney;
            chkIsCopyOnFile.IsChecked = _patient.IsCopyOnFile;
            chkIsNCFEligible.IsChecked = _patient.IsNCFEligible;
            chkIsFallRisk.IsChecked = _patient.IsFallRisk;
            chkIsHOH.IsChecked = _patient.IsHOH;
            chkIsDisoriented.IsChecked = _patient.IsDisoriented;
            chkIsDialysis.IsChecked = _patient.IsDialysis;
            chkIsVulnerable.IsChecked = _patient.IsVulnerable;
            chkIsDisabled.IsChecked = _patient.IsDisabled;
            chkIsEscortRequired.IsChecked = _patient.IsEscortRequired;
            chkIsFrail.IsChecked = _patient.IsFrail;
            chkIsAlert.IsChecked = _patient.IsAlert;
        }

        // Function to register event handlers for checkboxes
        private void RegisterCheckBoxEvents()
        {
            chkIsDNR.Checked += CheckBox_CheckedChanged;
            chkIsDNR.Unchecked += CheckBox_CheckedChanged;

            chkIsDNRArrest.Checked += CheckBox_CheckedChanged;
            chkIsDNRArrest.Unchecked += CheckBox_CheckedChanged;

            chkIsFullCode.Checked += CheckBox_CheckedChanged;
            chkIsFullCode.Unchecked += CheckBox_CheckedChanged;

            chkIsComfortMeasOnly.Checked += CheckBox_CheckedChanged;
            chkIsComfortMeasOnly.Unchecked += CheckBox_CheckedChanged;

            chkIsLivingWill.Checked += CheckBox_CheckedChanged;
            chkIsLivingWill.Unchecked += CheckBox_CheckedChanged;

            chkIsPowerOfAttorney.Checked += CheckBox_CheckedChanged;
            chkIsPowerOfAttorney.Unchecked += CheckBox_CheckedChanged;

            chkIsCopyOnFile.Checked += CheckBox_CheckedChanged;
            chkIsCopyOnFile.Unchecked += CheckBox_CheckedChanged;

            chkIsNCFEligible.Checked += CheckBox_CheckedChanged;
            chkIsNCFEligible.Unchecked += CheckBox_CheckedChanged;

            chkIsFallRisk.Checked += CheckBox_CheckedChanged;
            chkIsFallRisk.Unchecked += CheckBox_CheckedChanged;

            chkIsHOH.Checked += CheckBox_CheckedChanged;
            chkIsHOH.Unchecked += CheckBox_CheckedChanged;

            chkIsDisoriented.Checked += CheckBox_CheckedChanged;
            chkIsDisoriented.Unchecked += CheckBox_CheckedChanged;

            chkIsDialysis.Checked += CheckBox_CheckedChanged;
            chkIsDialysis.Unchecked += CheckBox_CheckedChanged;

            chkIsVulnerable.Checked += CheckBox_CheckedChanged;
            chkIsVulnerable.Unchecked += CheckBox_CheckedChanged;

            chkIsDisabled.Checked += CheckBox_CheckedChanged;
            chkIsDisabled.Unchecked += CheckBox_CheckedChanged;

            chkIsEscortRequired.Checked += CheckBox_CheckedChanged;
            chkIsEscortRequired.Unchecked += CheckBox_CheckedChanged;

            chkIsFrail.Checked += CheckBox_CheckedChanged;
            chkIsFrail.Unchecked += CheckBox_CheckedChanged;

            chkIsAlert.Checked += CheckBox_CheckedChanged;
            chkIsAlert.Unchecked += CheckBox_CheckedChanged;
        }

        // Event handler for the checkbox changes
        private void CheckBox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            var checkbox = sender as CheckBox;
            if (checkbox == null || _patient == null) return;

            // Update the corresponding patient properties based on which checkbox was checked/unchecked
            switch (checkbox.Name)
            {
                case "chkIsDNR":
                    _patient.IsDNR = checkbox.IsChecked == true;
                    break;
                case "chkIsDNRArrest":
                    _patient.IsDNRArrest = checkbox.IsChecked == true;
                    break;
                case "chkIsFullCode":
                    _patient.IsFullCode = checkbox.IsChecked == true;
                    break;
                case "chkIsComfortMeasOnly":
                    _patient.IsComfortMeasOnly = checkbox.IsChecked == true;
                    break;
                case "chkIsLivingWill":
                    _patient.IsLivingWill = checkbox.IsChecked == true;
                    break;
                case "chkIsPowerOfAttorney":
                    _patient.IsPowerOfAttorney = checkbox.IsChecked == true;
                    break;
                case "chkIsCopyOnFile":
                    _patient.IsCopyOnFile = checkbox.IsChecked == true;
                    break;
                case "chkIsNCFEligible":
                    _patient.IsNCFEligible = checkbox.IsChecked == true;
                    break;
                case "chkIsFallRisk":
                    _patient.IsFallRisk = checkbox.IsChecked == true;
                    break;
                case "chkIsHOH":
                    _patient.IsHOH = checkbox.IsChecked == true;
                    break;
                case "chkIsDisoriented":
                    _patient.IsDisoriented = checkbox.IsChecked == true;
                    break;
                case "chkIsDialysis":
                    _patient.IsDialysis = checkbox.IsChecked == true;
                    break;
                case "chkIsVulnerable":
                    _patient.IsVulnerable = checkbox.IsChecked == true;
                    break;
                case "chkIsDisabled":
                    _patient.IsDisabled = checkbox.IsChecked == true;
                    break;
                case "chkIsEscortRequired":
                    _patient.IsEscortRequired = checkbox.IsChecked == true;
                    break;
                case "chkIsFrail":
                    _patient.IsFrail = checkbox.IsChecked == true;
                    break;
                case "chkIsAlert":
                    _patient.IsAlert = checkbox.IsChecked == true;
                    break;
                default:
                    break;
            }
        }

        // Logout button click event handler to close the current window
        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // Show the login window and close the current window
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Close();
        }
    }
}
