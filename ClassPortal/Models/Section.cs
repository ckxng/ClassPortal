using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassPortal.Models
{
    public class Section
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Course ID Link is required")]
        public long CourseID { get; set; } // Foreign key
        public Course Course { get; set; }

        [Required(ErrorMessage = "Enter Starting Date & Time")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "Enter Ending Date & Time")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Enter Period Name")]
        public string Name { get; set; }

        public string Professor { get; set; }

        public string Details { get; set; }
    }
}
