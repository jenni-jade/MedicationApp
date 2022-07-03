using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MedicationApp.ViewModels;

namespace MedicationApp.Commands
{
    public class SignInCommand : ICommand
    {
        private MainViewModel viewModel;

        public SignInCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object? parameter)
        {
            if (parameter.ToString().Equals("HomePage")) viewModel.SelectedViewModel = new HomePageViewModel();
            else if (parameter.ToString().Equals("LoginPage")) viewModel.SelectedViewModel = new LoginViewModel();
        }
    }
}
