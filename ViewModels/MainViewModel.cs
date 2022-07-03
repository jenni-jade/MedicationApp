using MedicationApp.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MedicationApp.ViewModels
{
    public class MainViewModel: BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public BaseViewModel SelectedViewModel {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value;
                onPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand SignInCommand { get; set; }
        public MainViewModel()
        {
            this._selectedViewModel = new LoginViewModel();
        }
    }
}
