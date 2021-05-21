﻿// <auto-generated />
using System;
using ClassPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClassPortal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210521031132_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ClassPortal.Models.College", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BannerURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Colleges");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "University of Scouting"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Comissioner's College"
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "CLASS-101",
                            Credits = 3,
                            Name = "Class 101"
                        },
                        new
                        {
                            Id = 2L,
                            Code = "CLASS-102",
                            Credits = 3,
                            Name = "Class 102"
                        },
                        new
                        {
                            Id = 3L,
                            Code = "CLASS-201",
                            Credits = 3,
                            Name = "Class 201"
                        },
                        new
                        {
                            Id = 4L,
                            Code = "CLASS-202",
                            Credits = 3,
                            Name = "Class 202"
                        },
                        new
                        {
                            Id = 5L,
                            Code = "CLASS-301",
                            Credits = 3,
                            Name = "Class 301"
                        },
                        new
                        {
                            Id = 6L,
                            Code = "CLASS-302",
                            Credits = 3,
                            Name = "Class 302"
                        },
                        new
                        {
                            Id = 7L,
                            Code = "CLASS-401",
                            Credits = 3,
                            Name = "Class 401"
                        },
                        new
                        {
                            Id = 8L,
                            Code = "CLASS-402",
                            Credits = 3,
                            Name = "Class 402"
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.CourseRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<long>("SemesterId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseRecords");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseId = 1L,
                            SemesterId = 1L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            CourseId = 2L,
                            SemesterId = 1L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            CourseId = 3L,
                            SemesterId = 2L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            CourseId = 4L,
                            SemesterId = 2L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            CourseId = 5L,
                            SemesterId = 3L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 6L,
                            CourseId = 6L,
                            SemesterId = 3L,
                            Status = 3,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 7L,
                            CourseId = 1L,
                            SemesterId = 2L,
                            Status = 3,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 8L,
                            CourseId = 2L,
                            SemesterId = 2L,
                            Status = 3,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 9L,
                            CourseId = 3L,
                            SemesterId = 3L,
                            Status = 3,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 10L,
                            CourseId = 4L,
                            SemesterId = 3L,
                            Status = 3,
                            StudentId = 2L
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Degree", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Degrees");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Associate of Scouting"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Bachelor of Scouting"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Master of Scouting"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Doctor of Scouting"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Associate of Commisioner Science"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Bachelor of Commisioner Science"
                        },
                        new
                        {
                            Id = 7L,
                            Name = "Master of Commisioner Science"
                        },
                        new
                        {
                            Id = 8L,
                            Name = "Doctor of Commisioner Science"
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.DegreeRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DegreeId")
                        .HasColumnType("bigint");

                    b.Property<long>("SemesterId")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.HasIndex("SemesterId");

                    b.HasIndex("StudentId");

                    b.ToTable("DegreeRecords");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            DegreeId = 1L,
                            SemesterId = 1L,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            DegreeId = 2L,
                            SemesterId = 2L,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            DegreeId = 3L,
                            SemesterId = 3L,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            DegreeId = 1L,
                            SemesterId = 2L,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 5L,
                            DegreeId = 2L,
                            SemesterId = 3L,
                            StudentId = 2L
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Schedule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("SectionId")
                        .HasColumnType("bigint");

                    b.Property<long>("StudentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("StudentId");

                    b.ToTable("Schedules");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            SectionId = 7L,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            SectionId = 8L,
                            StudentId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            SectionId = 5L,
                            StudentId = 2L
                        },
                        new
                        {
                            Id = 4L,
                            SectionId = 6L,
                            StudentId = 2L
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Section", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CourseID")
                        .HasColumnType("bigint");

                    b.Property<string>("Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Professor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CourseID = 1L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 1",
                            Professor = "Professor X.",
                            StartTime = new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            CourseID = 2L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 2",
                            Professor = "Joe Expert",
                            StartTime = new DateTime(2020, 8, 1, 10, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3L,
                            CourseID = 3L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 3",
                            Professor = "Professor X.",
                            StartTime = new DateTime(2020, 8, 1, 11, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4L,
                            CourseID = 4L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 4",
                            Professor = "Joe Expert",
                            StartTime = new DateTime(2020, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5L,
                            CourseID = 5L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 5",
                            Professor = "Professor X.",
                            StartTime = new DateTime(2020, 8, 1, 14, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6L,
                            CourseID = 6L,
                            Details = "Room 1, <a href=\"#\">Zoom 123-456-7890</a>",
                            EndTime = new DateTime(2020, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 6",
                            Professor = "Joe Expert",
                            StartTime = new DateTime(2020, 8, 1, 15, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7L,
                            CourseID = 7L,
                            Details = "Room 2, in-person only",
                            EndTime = new DateTime(2020, 8, 1, 12, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 1-3",
                            Professor = "Sir Talks-a-Lot",
                            StartTime = new DateTime(2020, 8, 1, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8L,
                            CourseID = 8L,
                            Details = "Room 2, in-person only",
                            EndTime = new DateTime(2020, 8, 1, 16, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Period 1-6",
                            Professor = "Sir Talks-a-Lot",
                            StartTime = new DateTime(2020, 8, 1, 13, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Semester", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CollegeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollegeId");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CollegeId = 1L,
                            Date = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "UofS 2018"
                        },
                        new
                        {
                            Id = 2L,
                            CollegeId = 1L,
                            Date = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "UofS 2019"
                        },
                        new
                        {
                            Id = 3L,
                            CollegeId = 1L,
                            Date = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "UofS 2020"
                        },
                        new
                        {
                            Id = 4L,
                            CollegeId = 2L,
                            Date = new DateTime(2018, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CC 2018"
                        },
                        new
                        {
                            Id = 5L,
                            CollegeId = 2L,
                            Date = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CC 2019"
                        },
                        new
                        {
                            Id = 6L,
                            CollegeId = 2L,
                            Date = new DateTime(2020, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "CC 2020"
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            FirstName = "John",
                            LastName = "Doe",
                            StudentNumber = "1234"
                        },
                        new
                        {
                            Id = 2L,
                            FirstName = "Jane",
                            LastName = "Smith",
                            StudentNumber = "5678"
                        });
                });

            modelBuilder.Entity("ClassPortal.Models.CourseRecord", b =>
                {
                    b.HasOne("ClassPortal.Models.Course", "Course")
                        .WithMany("CourseRecords")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassPortal.Models.Semester", "Semester")
                        .WithMany("CourseRecords")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassPortal.Models.Student", "Student")
                        .WithMany("CourseRecords")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassPortal.Models.DegreeRecord", b =>
                {
                    b.HasOne("ClassPortal.Models.Degree", "Degree")
                        .WithMany("DegreeRecords")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassPortal.Models.Semester", "Semester")
                        .WithMany("DegreeRecords")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassPortal.Models.Student", "Student")
                        .WithMany("DegreeRecords")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Degree");

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassPortal.Models.Schedule", b =>
                {
                    b.HasOne("ClassPortal.Models.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassPortal.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Section");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ClassPortal.Models.Section", b =>
                {
                    b.HasOne("ClassPortal.Models.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("ClassPortal.Models.Semester", b =>
                {
                    b.HasOne("ClassPortal.Models.College", null)
                        .WithMany("Semesters")
                        .HasForeignKey("CollegeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassPortal.Models.College", b =>
                {
                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("ClassPortal.Models.Course", b =>
                {
                    b.Navigation("CourseRecords");

                    b.Navigation("Sections");
                });

            modelBuilder.Entity("ClassPortal.Models.Degree", b =>
                {
                    b.Navigation("DegreeRecords");
                });

            modelBuilder.Entity("ClassPortal.Models.Semester", b =>
                {
                    b.Navigation("CourseRecords");

                    b.Navigation("DegreeRecords");
                });

            modelBuilder.Entity("ClassPortal.Models.Student", b =>
                {
                    b.Navigation("CourseRecords");

                    b.Navigation("DegreeRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
