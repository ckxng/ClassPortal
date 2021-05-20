using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassPortal.Models
{
    public class Degree
    {
        [Required, Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Required(ErrorMessage = "Enter Degree Name")]
        public string Name { get; set; }

        public ICollection<DegreeRecord> DegreeRecords { get; set; }

    }
}
