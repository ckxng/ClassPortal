using Microsoft.EntityFrameworkCore;

namespace ClassPortal.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<College> Colleges { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseRecord> CourseRecords { get; set; }

        public DbSet<DegreeRecord> DegreeRecords { get; set; }

        public DbSet<Semester> Semesters { get; set; }

        public DbSet<Student> Students { get; set; }
    }
}
