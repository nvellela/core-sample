﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Models.DB;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(EFCoreDBFirstDemoContext))]
    [Migration("20190805103318_CreateSchoolDB")]
    partial class CreateSchoolDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.DB.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApplication1.Models.DB.Student", b =>
                {
                    b.Property<long>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Address2")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("City")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateOfRegistration")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("State")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Zip")
                        .HasMaxLength(10);

                    b.HasKey("StudentId");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}