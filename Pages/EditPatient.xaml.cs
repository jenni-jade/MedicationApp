using MedicationApp.Models;
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

namespace MedicationApp.Pages
{
    /// <summary>
    /// Interaction logic for EditPatient.xaml
    /// </summary>
    public partial class EditPatient : Page
    {
        private Patient _patient;
        public EditPatient(Patient? chosenPatient)
        {
            InitializeComponent();
            this._patient = chosenPatient;
            Name.Text = this._patient.name;
            DOB.Text = this._patient.birth;
            Gender.Text = this._patient.gender;
            SSN.Text = this._patient.ssn;
            Address.Text = this._patient.address;
            Height.Text = this._patient.height;
            Physician.Text = this._patient.referringPhysician;
            Diagnosis.Text = this._patient.Diagnosis; 
            Medication.Text = this._patient.Medication;
            EmailAddress.Text = this._patient.emailAddress;
            EmergencyContact.Text = this._patient.emergencyContact;
            ContactNumber.Text = this._patient.contactNumber;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (PatientDataContext context = new PatientDataContext())
            {
             
                var name = Name.Text.ToString();
                var dob = DOB.Text.ToString();
                var gender = Gender.Text.ToString();
                var ssn = SSN.Text.ToString();
                var address = Address.Text.ToString();
                var height = Height.Text.ToString();

                var reffering = Physician.Text.ToString();
                var diagnosis = Diagnosis.Text.ToString();
                var medication = Medication.Text.ToString();
                var email = EmailAddress.Text.ToString();
                var emergency = EmergencyContact.Text.ToString();
                var contact = ContactNumber.Text.ToString();

                //Patient chosenPatient = sender as Patient;

                if (name != null && dob != null)
                {
                    this._patient.name = name;
                    this._patient.birth = dob;
                    this._patient.gender = gender;
                    this._patient.ssn = ssn;
                    this._patient.address = address;
                    this._patient.height = height;
                    this._patient.referringPhysician = reffering;
                    this._patient.Diagnosis = diagnosis;
                    this._patient.Medication = medication;
                    this._patient.emailAddress = email;
                    this._patient.emergencyContact = emergency;
                    this._patient.contactNumber = contact;

                    context.Patients.Update(_patient);
                    context.SaveChanges();
                    MessageBox.Show("Changes saved successfully");
                    Window.GetWindow(this).Close();
                }
                else
                {
                    MessageBox.Show("Please enter in a name and date of birth");
                }

            }
        }

        private void Discard_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
