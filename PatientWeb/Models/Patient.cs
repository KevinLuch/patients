using System.ComponentModel.DataAnnotations;

namespace PatientWeb.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string FirstName { get; set; }

        public int DateOfBirth { get; set; }

        [Required]
        public string AdmitTo { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
