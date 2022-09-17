using MedicationApp.Modals;
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
    /// Interaction logic for ClientInfoPage.xaml
    /// </summary>
    public partial class ClientInfoPage : Page
    {
        private List<Patient> masterList;
        private List<Patient> resultList;
        private String username;
        public ClientInfoPage(String username)
        {
            InitializeComponent();
            GetPatients();

            this.resultList = new List<Patient>();
            this.username = username;
            LoggedUser.Text = username;
        }

        private void GetPatients()
        {
            try
            {
                using (PatientDataContext context = new PatientDataContext())
                {
                    List<Patient> rawList = context.Patients.ToList();
                    this.masterList = rawList;
                    PatientChart.ItemsSource = rawList;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
           
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new LandingPage(this.username);
        }

        private void Mar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Mar(this.username);
        }

        private void Client_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new ClientInfoPage(this.username);
        }

        private void Caregiver_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new CareGiverPage(this.username);
        }

        private void Remove_Click(object s, RoutedEventArgs e)
        {
            using (PatientDataContext context = new PatientDataContext())
            {
                var deadUser = (s as FrameworkElement).DataContext as Patient;
                context.Patients.Remove(deadUser);
                context.SaveChanges();
                GetPatients();
            }

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Patient? chosenPatient = PatientChart.SelectedItem as Patient;
                EditPatientModal modal = new EditPatientModal(chosenPatient);
                modal.ShowDialog();
                GetPatients();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message.ToString());
            }
          
        }

        private void Search_Click(object s, RoutedEventArgs e)
        {
            PatientChart.ItemsSource = masterList;
            this.resultList.Clear();
            var name = Name.Text.ToString().ToLower();
            var dob = DOB.Text.ToString().ToLower();

            if (name.Length == 0 && dob.Length > 0)
            {
                for (int i = 0; i < this.masterList.Count; i++)
                {
                    if (masterList[i].birth.ToLower().Contains(dob))
                    {
                        resultList.Add(masterList[i]);
                    }
                }

                PatientChart.ItemsSource = resultList;
            }
            else if (dob.Length == 0 && name.Length > 0)
            {
                for (int i = 0; i < this.masterList.Count; i++)
                {
                    if (masterList[i].name.ToLower().Contains(name))
                    {
                        resultList.Add(masterList[i]);
                    }
                }

                PatientChart.ItemsSource = resultList;
            }
            else
            {
                for (int i = 0; i < this.masterList.Count; i++)
                {
                    if (masterList[i].name.ToLower().Contains(name) &&
                        masterList[i].birth.ToLower().Contains(dob))
                    {
                        resultList.Add(masterList[i]);
                    }
                }

                PatientChart.ItemsSource = resultList;
            }
            

        }

        private void Patient_Click(object s, RoutedEventArgs e)
        {
            AddPatientModal modal = new AddPatientModal();
            modal.ShowDialog();
            GetPatients();
        }

        private void View_Click(object s, RoutedEventArgs e)
        {
            AddPatientModal modal = new AddPatientModal();
            modal.ShowDialog();
            GetPatients();
        }

        private void To_login(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Content = new Login();
        }
    }
}
