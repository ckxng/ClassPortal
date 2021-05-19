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
        
        [Required]
        public long StudentId { get; set; } //Foreign Key
        
        [Required]
        public long SemesterId { get; set; } //Foreign Key

        [Required]
        public long CourseId { get; set; } //Foreign Key

        [Required]
        public RecordStatus Status { get; set; }

    }
}
