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
    /// Interaction logic for EditUser.xaml
    /// </summary>
    public partial class EditUser : Page
    {

        private User _user;
        public EditUser(User? chosenUser)
        {
            InitializeComponent();
            this._user = chosenUser;
            userText.Text = chosenUser.Username;
            passwordText.Text = chosenUser.Password;
            signatureText.Text = chosenUser.Signature;
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var username = userText.Text.ToString();
            var password = passwordText.Text.ToString();
            var signature = signatureText.Text.ToString();

            using (UserDataContext context = new UserDataContext())
            {
                if (username != null && password != null)
                {
                    if (username.Length > 15)
                        MessageBox.Show("Username is too long. Please choose a different name");
                    else
                    {
                        this._user.Username = username;
                        this._user.Password = password;
                        this._user.Signature = signature;

                        context.Users.Update(this._user);
                        context.SaveChanges();
                        MessageBox.Show("User successfully updated");
                        Window.GetWindow(this).Close();
                    }

                }
                else
                {
                    MessageBox.Show("Please try different credentials");
                }
            }
        }

        private void Discard_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).Close();
        }
    }
}
