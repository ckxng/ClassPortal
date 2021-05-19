using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPortal.Models
{
    public class Course
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter Course Code (ABC-101)")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Enter Course Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Number of Credits (1,2,3...)")]
        public int Credits { get; set; }

        public ICollection<Record> Records { get; set; }

    }
}
