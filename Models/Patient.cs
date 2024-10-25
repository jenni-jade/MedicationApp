using System;

namespace MedicationApp.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float Height { get; set; }

        // Add the missing boolean properties:
        public bool IsDNR { get; set; }
        public bool IsDNRArrest { get; set; }
        public bool IsFullCode { get; set; }
        public bool IsComfortMeasOnly { get; set; }
        public bool IsLivingWill { get; set; }
        public bool IsPowerOfAttorney { get; set; }
        public bool IsCopyOnFile { get; set; }
        public bool IsNCFEligible { get; set; }
        public bool IsFallRisk { get; set; }
        public bool IsHOH { get; set; }
        public bool IsDisoriented { get; set; }
        public bool IsDialysis { get; set; }
        public bool IsVulnerable { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsEscortRequired { get; set; }
        public bool IsFrail { get; set; }
        public bool IsAlert { get; set; }
    }
}
