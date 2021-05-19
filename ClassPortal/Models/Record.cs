using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPortal.Models
{
    public class Record
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Student Number Link is Required")]
        public long StudentId { get; set; } //Foreign Key

        public Student Student { get; set; }
        
        [Required(ErrorMessage = "Semester ID Link is Required")]
        public long SemesterId { get; set; } //Foreign Key

        public Semester Semester { get; set; }

        [Required(ErrorMessage = "Course ID Link is Required")]
        public long CourseId { get; set; } //Foreign Key

        public Course Course { get; set; }

        [Required(ErrorMessage = "Record Status ID is Required (0=Hidden,1=Registered,2=Attended,3=Completed)")]
        public RecordStatus Status { get; set; }

    }
}
