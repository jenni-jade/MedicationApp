using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MedicationApp.Models;

namespace MedicationApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // facade pattern simiplifies complex implementations (which depend on subsystems)
            DatabaseFacade facade = new DatabaseFacade(new UserDataContext());
            DatabaseFacade patientFacade = new DatabaseFacade(new PatientDataContext());

            // Ensures database and schemas already exist
            facade.EnsureCreated();
            patientFacade.EnsureCreated();

        }
    }
}
