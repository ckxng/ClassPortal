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

        public string Error = null;

        public RecordsModel(ClassPortal.Models.DataContext context)
        {
            _context = context;
        }

        public IList<Record> Record { get; set; }
        public Student Student { get; set; }

        public async Task OnGetAsync(string StudentNumber, string LastName)
        {
            Student = await _context.Students
                .Where(s => s.StudentNumber == StudentNumber && s.LastName == LastName)
                .FirstOrDefaultAsync();

            if(Student == null)
            {
                Error = "no student found";
                return;
            }

            Record = await _context.Records
                .Include("Student")
                .Where(r => r.StudentId == Student.Id)
                .Include("Semester")
                .Include("Course")
                .OrderBy(s => s.Semester.Date)
                .ThenBy(s => s.Course.Code)
                .ToListAsync();

            if (Record == null)
            {
                Error = "no records found";
                return;
            }
        }
    }
}
