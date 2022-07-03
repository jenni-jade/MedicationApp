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
    /// Interaction logic for AddPatient.xaml
    /// </summary>
    public partial class AddPatient : Page
    {
        public AddPatient()
        {
            InitializeComponent();
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



                if (name != null && dob != null)
                {
                    context.Patients.Add(new Patient() {
                        name = name, birth = dob, gender = gender, ssn = ssn, address = address,
                        emailAddress = email, height = height, referringPhysician = reffering, Diagnosis = diagnosis,
                        Medication = medication, emergencyContact = emergency, contactNumber = contact
                    });
                    context.SaveChanges();
                    MessageBox.Show("Patient saved successfully");
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
