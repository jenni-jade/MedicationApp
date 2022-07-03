using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class PatientView
    {
        public int Id { get; set; }
        public String name { get; set; }
        public String dateOfBirth { get; set; }
        public String height { get; set; }

        public PatientView(int id, string name, string dateOfBirth, string height)
        {
            Id = id;
            this.name = name;
            this.dateOfBirth = dateOfBirth;
            this.height = height;
        }
    }
}
