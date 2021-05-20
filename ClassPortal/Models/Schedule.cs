using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassPortal.Models
{
    public class Schedule
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Student Number Link is Required")]
        public long StudentId { get; set; } //Foreign Key

        public Student Student { get; set; }

        [Required(ErrorMessage = "Section ID Link is Required")]
        public long SectionId { get; set; } //Foreign Key

        public Section Section { get; set; }

    }
}
