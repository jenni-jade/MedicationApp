using MedicationApp.Models;
using MedicationApp.Pages;
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
using System.Windows.Shapes;

namespace MedicationApp.Modals
{
    /// <summary>
    /// Interaction logic for EditUserModal.xaml
    /// </summary>
    public partial class EditUserModal : Window
    {
        public EditUserModal(User? chosenUser)
        {
            InitializeComponent();
            this.Content = new EditUser(chosenUser);
        }
    }
}
