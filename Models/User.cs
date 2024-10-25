using System.ComponentModel.DataAnnotations;

namespace MedicationApp.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be at least 8 characters long.")]
        public string Password { get; set; }

        [StringLength(200)]
        public string Signature { get; set; }
    }
}
