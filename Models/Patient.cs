using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicationApp.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public String name { get; set; }
        public String birth { get; set; }
        public String height { get; set; }
        public String gender { get; set; }
        public String ssn { get; set; }
        public String address { get; set; }
        public String emergencyContact { get; set; }
        public String contactNumber { get; set; }
        public String referringPhysician { get; set; }
        public String Diagnosis { get; set; }
        public String Medication { get; set; }
        public String emailAddress {  get; set; }


    }
}
