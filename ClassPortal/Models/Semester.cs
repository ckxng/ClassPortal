﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPortal.Models
{
    public class Semester
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        
        [Required(ErrorMessage = "College ID Link is Required")]
        public long CollegeId { get; set; } //Foreign Key

        [Required(ErrorMessage = "Enter Starting Date")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Enter Semester Name")]
        public string Name { get; set; }

        public ICollection<Record> Records { get; set; }
    }
}
