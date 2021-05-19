using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ClassPortal.Models;

namespace ClassPortal.Pages
{
    public class RecordsModel : PageModel
    {
        private readonly ClassPortal.Models.DataContext _context;

        public RecordsModel(ClassPortal.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Record> Record { get; set; }

        public async Task OnGetAsync()
        {
            Record = await _context.Records
                .Include("Student")
                .Include("Semester")
                .Include("Course")
                .ToListAsync();
        }
    }
}
