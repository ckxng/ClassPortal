using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassPortal.Models
{
    public class Student
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [DisplayName("Student Number")]
        [Required(ErrorMessage = "Enter Student Number")]
        public string StudentNumber { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "Enter First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string LastName { get; set; }

        public ICollection<CourseRecord> CourseRecords { get; set; }
        public ICollection<DegreeRecord> DegreeRecords { get; set; }
    }
}
