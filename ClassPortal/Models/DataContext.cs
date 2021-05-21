using Microsoft.EntityFrameworkCore;
using System;

namespace ClassPortal.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<College> Colleges { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Degree> Degrees { get; set; }

        public DbSet<CourseRecord> CourseRecords { get; set; }

        public DbSet<DegreeRecord> DegreeRecords { get; set; }

        public DbSet<Semester> Semesters { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Section> Sections { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>().HasData(
                new College { Id = 1L, Name = "University of Scouting" },
                new College { Id = 2L, Name = "Comissioner's College" });

            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1L, Code = "CLASS-101", Name = "Class 101", Credits = 3 },
                new Course { Id = 2L, Code = "CLASS-102", Name = "Class 102", Credits = 3 },
                new Course { Id = 3L, Code = "CLASS-201", Name = "Class 201", Credits = 3 },
                new Course { Id = 4L, Code = "CLASS-202", Name = "Class 202", Credits = 3 },
                new Course { Id = 5L, Code = "CLASS-301", Name = "Class 301", Credits = 3 },
                new Course { Id = 6L, Code = "CLASS-302", Name = "Class 302", Credits = 3 },
                new Course { Id = 7L, Code = "CLASS-401", Name = "Class 401", Credits = 3 },
                new Course { Id = 8L, Code = "CLASS-402", Name = "Class 402", Credits = 3 });

            modelBuilder.Entity<Degree>().HasData(
                new Degree { Id = 1L, Name = "Associate of Scouting" },
                new Degree { Id = 2L, Name = "Bachelor of Scouting" },
                new Degree { Id = 3L, Name = "Master of Scouting" },
                new Degree { Id = 4L, Name = "Doctor of Scouting" },
                new Degree { Id = 5L, Name = "Associate of Commisioner Science" },
                new Degree { Id = 6L, Name = "Bachelor of Commisioner Science" },
                new Degree { Id = 7L, Name = "Master of Commisioner Science" },
                new Degree { Id = 8L, Name = "Doctor of Commisioner Science" });

            modelBuilder.Entity<Semester>().HasData(
                new Semester { Id = 1L, CollegeId = 1L, Date = new DateTime(2018, 8, 1), Name = "UofS 2018" },
                new Semester { Id = 2L, CollegeId = 1L, Date = new DateTime(2019, 8, 1), Name = "UofS 2019" },
                new Semester { Id = 3L, CollegeId = 1L, Date = new DateTime(2020, 8, 1), Name = "UofS 2020" },
                new Semester { Id = 4L, CollegeId = 2L, Date = new DateTime(2018, 8, 1), Name = "CC 2018" },
                new Semester { Id = 5L, CollegeId = 2L, Date = new DateTime(2019, 8, 1), Name = "CC 2019" },
                new Semester { Id = 6L, CollegeId = 2L, Date = new DateTime(2020, 8, 1), Name = "CC 2020" });

            modelBuilder.Entity<Student>().HasData(
                new Student { Id = 1L, StudentNumber = "1234", FirstName = "John", LastName = "Doe" },
                new Student { Id = 2L, StudentNumber = "5678", FirstName = "Jane", LastName = "Smith" });

            modelBuilder.Entity<CourseRecord>().HasData(
                new CourseRecord { Id = 1L, StudentId = 1L, CourseId = 1L, SemesterId = 1L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 2L, StudentId = 1L, CourseId = 2L, SemesterId = 1L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 3L, StudentId = 1L, CourseId = 3L, SemesterId = 2L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 4L, StudentId = 1L, CourseId = 4L, SemesterId = 2L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 5L, StudentId = 1L, CourseId = 5L, SemesterId = 3L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 6L, StudentId = 1L, CourseId = 6L, SemesterId = 3L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 7L, StudentId = 2L, CourseId = 1L, SemesterId = 2L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 8L, StudentId = 2L, CourseId = 2L, SemesterId = 2L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 9L, StudentId = 2L, CourseId = 3L, SemesterId = 3L, Status = RecordStatus.Completed },
                new CourseRecord { Id = 10L, StudentId = 2L, CourseId = 4L, SemesterId = 3L, Status = RecordStatus.Completed });

            modelBuilder.Entity<DegreeRecord>().HasData(
                new DegreeRecord { Id = 1L, StudentId = 1L, DegreeId = 1L, SemesterId = 1L },
                new DegreeRecord { Id = 2L, StudentId = 1L, DegreeId = 2L, SemesterId = 2L },
                new DegreeRecord { Id = 3L, StudentId = 1L, DegreeId = 3L, SemesterId = 3L },
                new DegreeRecord { Id = 4L, StudentId = 2L, DegreeId = 1L, SemesterId = 2L },
                new DegreeRecord { Id = 5L, StudentId = 2L, DegreeId = 2L, SemesterId = 3L });

            modelBuilder.Entity<Section>().HasData(
                new Section { Id = 1L, CourseID = 1L, StartTime = new DateTime(2020, 8, 1, 9, 0, 0), EndTime = new DateTime(2020, 8, 1, 10, 0, 0), Name = "Period 1", Professor = "Professor X.", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 2L, CourseID = 2L, StartTime = new DateTime(2020, 8, 1, 10, 0, 0), EndTime = new DateTime(2020, 8, 1, 11, 0, 0), Name = "Period 2", Professor = "Joe Expert", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 3L, CourseID = 3L, StartTime = new DateTime(2020, 8, 1, 11, 0, 0), EndTime = new DateTime(2020, 8, 1, 12, 0, 0), Name = "Period 3", Professor = "Professor X.", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 4L, CourseID = 4L, StartTime = new DateTime(2020, 8, 1, 13, 0, 0), EndTime = new DateTime(2020, 8, 1, 14, 0, 0), Name = "Period 4", Professor = "Joe Expert", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 5L, CourseID = 5L, StartTime = new DateTime(2020, 8, 1, 14, 0, 0), EndTime = new DateTime(2020, 8, 1, 15, 0, 0), Name = "Period 5", Professor = "Professor X.", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 6L, CourseID = 6L, StartTime = new DateTime(2020, 8, 1, 15, 0, 0), EndTime = new DateTime(2020, 8, 1, 16, 0, 0), Name = "Period 6", Professor = "Joe Expert", Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>" },
                new Section { Id = 7L, CourseID = 7L, StartTime = new DateTime(2020, 8, 1, 09, 0, 0), EndTime = new DateTime(2020, 8, 1, 12, 0, 0), Name = "Period 1-3", Professor = "Sir Talks-a-Lot", Details = "Room 2, in-person only" },
                new Section { Id = 8L, CourseID = 8L, StartTime = new DateTime(2020, 8, 1, 13, 0, 0), EndTime = new DateTime(2020, 8, 1, 16, 0, 0), Name = "Period 1-6", Professor = "Sir Talks-a-Lot", Details = "Room 2, in-person only" });

            modelBuilder.Entity<Schedule>().HasData(
                new Schedule { Id = 1L, StudentId = 1L, SectionId = 7L },
                new Schedule { Id = 2L, StudentId = 1L, SectionId = 8L },
                new Schedule { Id = 3L, StudentId = 2L, SectionId = 5L },
                new Schedule { Id = 4L, StudentId = 2L, SectionId = 6L });
        }
    }
}
