using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassPortal.Models
{
    public class DegreeRecord
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Student Number Link is Required")]
        public long StudentId { get; set; } //Foreign Key

        public Student Student { get; set; }

        [Required(ErrorMessage = "Semester ID Link is Required")]
        public long SemesterId { get; set; } //Foreign Key

        public Semester Semester { get; set; }

        [Required(ErrorMessage = "Degree ID Link is Required")]
        public long DegreeId { get; set; } //Foreign Key

        public Degree Degree { get; set; }
    }
}
