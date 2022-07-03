using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class UserDataContext: DbContext
    {

        // Executed everytime a UserDataContext object is initialized 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Old Database: UserDatabase.db
            optionsBuilder.UseSqlite("Data Source = UsersDatabase.db");
        }

        public DbSet<User> Users { get; set; }
    }
}
