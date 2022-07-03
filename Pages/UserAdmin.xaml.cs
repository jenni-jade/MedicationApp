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
    /// Interaction logic for UserAdmin.xaml
    /// </summary>
    public partial class UserAdmin : Page
    {
        public UserAdmin()
        {
            InitializeComponent();
            GetUsers();
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e) => Create();
        

        private void Cancel_Click(object sender, RoutedEventArgs e) => 
            Application.Current.MainWindow.Content = new Login();
        



        private void Create()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var username = userText.Text.ToString();
                var password = passwordText.Text.ToString();
                var signature = signatureText.Text.ToString();

                if (username.Length > 0 && password.Length > 0) {
                    if (username.Length > 15) 
                        MessageBox.Show("Username is too long. Please choose a different name");
                    else
                    {
                        context.Users.Add(new User() { Username = username, Password = password, Signature = signature });
                        context.SaveChanges();
                        GetUsers();
                        MessageBox.Show("User successfully created");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Please try different credentials");
                }
               
            }
        }

        private void GetUsers()
        {
            using (UserDataContext context = new UserDataContext())
            {
                UserChart.ItemsSource = context.Users.ToList();
            }
        }

        private void Edit_Click(object s, RoutedEventArgs e)
        {
            User? chosenUser = UserChart.SelectedItem as User;  
            EditUserModal eum = new EditUserModal(chosenUser);
            eum.ShowDialog();
            GetUsers();
        }

        private void Remove_Click(object s, RoutedEventArgs e)
        {
            using (UserDataContext context = new UserDataContext())
            {
                var deadUser = (s as FrameworkElement).DataContext as User;
                context.Users.Remove(deadUser);
                context.SaveChanges();
                GetUsers();
            }


        }
    }
}
