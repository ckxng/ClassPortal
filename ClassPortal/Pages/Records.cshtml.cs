using ClassPortal.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassPortal.Pages
{
    public class RecordsModel : PageModel
    {
        private readonly DataContext _context;

        public string Error = null;

        public RecordsModel(DataContext context)
        {
            _context = context;
        }

        public IList<CourseRecord> CourseRecords { get; set; }
        public IList<DegreeRecord> DegreeRecords { get; set; }
        public IList<Schedule> Schedules { get; set; }
        public Student Student { get; set; }
        public College College { get; set; }

        public async Task OnGetAsync(long CollegeId, string StudentNumber, string LastName)
        {
            College = await _context.Colleges
                .Where(c => c.Id == CollegeId)
                .FirstOrDefaultAsync();

            if (College == null)
            {
                Error = "unable to lookup college";
                return;
            }

            Student = await _context.Students
                .Where(s => s.StudentNumber == StudentNumber && s.LastName == LastName)
                .FirstOrDefaultAsync();

            if (Student == null)
            {
                Error = "unable to lookup student";
                return;
            }

            Schedules = await _context.Schedules
                .Where(s => s.StudentId == Student.Id)
                .Include(s => s.Section)
                .ThenInclude(section => section.Course)
                .OrderBy(s => s.Section.StartTime)
                .ToListAsync();

            CourseRecords = await _context.CourseRecords
                .Include(cr => cr.Student)
                .Include(cr => cr.Semester)
                .Where(r => r.StudentId == Student.Id)
                .Where(r => r.Semester.CollegeId == CollegeId)
                .Include(cr => cr.Course)
                .OrderBy(s => s.Semester.Date)
                .ThenBy(s => s.Course.Code)
                .ToListAsync();

            if (CourseRecords == null)
            {
                Error = "unable to lookup course records";
                return;
            }

            DegreeRecords = await _context.DegreeRecords
                .Include(dr => dr.Student)
                .Include(dr => dr.Semester)
                .Where(r => r.StudentId == Student.Id)
                .Where(r => r.Semester.CollegeId == CollegeId)
                .Include(dr => dr.Degree)
                .OrderBy(s => s.Semester.Date)
                .ToListAsync();

            if (DegreeRecords == null)
            {
                Error = "unable to lookup degree completions";
                return;
            }

            if (CourseRecords.Count == 0 && DegreeRecords.Count == 0)
            {
                Error = "this user has no records in this college";
                return;
            }
        }
    }
}
