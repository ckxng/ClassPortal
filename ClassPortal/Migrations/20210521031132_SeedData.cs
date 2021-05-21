using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClassPortal.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "BannerURL", "Name" },
                values: new object[,]
                {
                    { 1L, null, "University of Scouting" },
                    { 2L, null, "Comissioner's College" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Code", "Credits", "Name" },
                values: new object[,]
                {
                    { 7L, "CLASS-401", 3, "Class 401" },
                    { 6L, "CLASS-302", 3, "Class 302" },
                    { 5L, "CLASS-301", 3, "Class 301" },
                    { 8L, "CLASS-402", 3, "Class 402" },
                    { 3L, "CLASS-201", 3, "Class 201" },
                    { 2L, "CLASS-102", 3, "Class 102" },
                    { 1L, "CLASS-101", 3, "Class 101" },
                    { 4L, "CLASS-202", 3, "Class 202" }
                });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Associate of Scouting" },
                    { 2L, "Bachelor of Scouting" },
                    { 3L, "Master of Scouting" },
                    { 4L, "Doctor of Scouting" },
                    { 5L, "Associate of Commisioner Science" },
                    { 6L, "Bachelor of Commisioner Science" },
                    { 7L, "Master of Commisioner Science" },
                    { 8L, "Doctor of Commisioner Science" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "FirstName", "LastName", "StudentNumber" },
                values: new object[,]
                {
                    { 1L, "John", "Doe", "1234" },
                    { 2L, "Jane", "Smith", "5678" }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "CourseID", "Details", "EndTime", "Name", "Professor", "StartTime" },
                values: new object[,]
                {
                    { 1L, 1L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Period 1", "Professor X.", new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 2L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified), "Period 2", "Joe Expert", new DateTime(2020, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, 3L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Period 3", "Professor X.", new DateTime(2020, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4L, 4L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified), "Period 4", "Joe Expert", new DateTime(2020, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5L, 5L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), "Period 5", "Professor X.", new DateTime(2020, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6L, 6L, "Room 1, <a href=\"#\">Zoom 123-456-7890</a>", new DateTime(2020, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "Period 6", "Joe Expert", new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7L, 7L, "Room 2, in-person only", new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), "Period 1-3", "Sir Talks-a-Lot", new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8L, 8L, "Room 2, in-person only", new DateTime(2020, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), "Period 1-6", "Sir Talks-a-Lot", new DateTime(2020, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CollegeId", "Date", "Name" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UofS 2018" },
                    { 2L, 1L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UofS 2019" },
                    { 3L, 1L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "UofS 2020" },
                    { 4L, 2L, new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC 2018" },
                    { 5L, 2L, new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC 2019" },
                    { 6L, 2L, new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "CC 2020" }
                });

            migrationBuilder.InsertData(
                table: "CourseRecords",
                columns: new[] { "Id", "CourseId", "SemesterId", "Status", "StudentId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 3, 1L },
                    { 10L, 4L, 3L, 3, 2L },
                    { 9L, 3L, 3L, 3, 2L },
                    { 6L, 6L, 3L, 3, 1L },
                    { 8L, 2L, 2L, 3, 2L },
                    { 5L, 5L, 3L, 3, 1L },
                    { 4L, 4L, 2L, 3, 1L },
                    { 3L, 3L, 2L, 3, 1L },
                    { 2L, 2L, 1L, 3, 1L },
                    { 7L, 1L, 2L, 3, 2L }
                });

            migrationBuilder.InsertData(
                table: "DegreeRecords",
                columns: new[] { "Id", "DegreeId", "SemesterId", "StudentId" },
                values: new object[,]
                {
                    { 2L, 2L, 2L, 1L },
                    { 4L, 1L, 2L, 2L },
                    { 1L, 1L, 1L, 1L },
                    { 3L, 3L, 3L, 1L },
                    { 5L, 2L, 3L, 2L }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "SectionId", "StudentId" },
                values: new object[,]
                {
                    { 1L, 7L, 1L },
                    { 3L, 5L, 2L },
                    { 4L, 6L, 2L },
                    { 2L, 8L, 1L }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "CourseRecords",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "DegreeRecords",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "DegreeRecords",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "DegreeRecords",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "DegreeRecords",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "DegreeRecords",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Degrees",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 8L);
        }
    }
}
