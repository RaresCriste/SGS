﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApp.Data;

#nullable disable

namespace WebApp.Migrations
{
    [DbContext(typeof(WebAppContext))]
    [Migration("20240105133737_optstud")]
    partial class optstud
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebApp.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoClasses")
                        .HasColumnType("int");

                    b.Property<int?>("ProfessorID")
                        .HasColumnType("int");

                    b.HasKey("CourseID");

                    b.HasIndex("ProfessorID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("WebApp.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"), 1L, 1);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("WebApp.Models.Grade", b =>
                {
                    b.Property<int>("GradeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradeID"), 1L, 1);

                    b.Property<DateTime>("DateOfGrading")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EnrollmentID")
                        .HasColumnType("int");

                    b.Property<int>("GradeValue")
                        .HasColumnType("int");

                    b.HasKey("GradeID");

                    b.HasIndex("EnrollmentID");

                    b.ToTable("Grade");
                });

            modelBuilder.Entity("WebApp.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessorID"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessorID");

                    b.ToTable("Professor");
                });

            modelBuilder.Entity("WebApp.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("WebApp.Models.Course", b =>
                {
                    b.HasOne("WebApp.Models.Professor", "Professor")
                        .WithMany("Courses")
                        .HasForeignKey("ProfessorID");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("WebApp.Models.Enrollment", b =>
                {
                    b.HasOne("WebApp.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID");

                    b.HasOne("WebApp.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID");

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("WebApp.Models.Grade", b =>
                {
                    b.HasOne("WebApp.Models.Enrollment", "Enrollment")
                        .WithMany("Grades")
                        .HasForeignKey("EnrollmentID");

                    b.Navigation("Enrollment");
                });

            modelBuilder.Entity("WebApp.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("WebApp.Models.Enrollment", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("WebApp.Models.Professor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("WebApp.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
