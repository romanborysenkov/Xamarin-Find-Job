// <auto-generated />
using System;
using FindWork.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FindWork.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221128180529_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("FindWork.API.Models.InterviewCall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Called")
                        .HasColumnType("TEXT");

                    b.Property<string>("HRId")
                        .HasColumnType("TEXT");

                    b.Property<string>("WorkerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("interviewCalls");
                });

            modelBuilder.Entity("FindWork.API.Models.Responses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("OwnerId")
                        .HasColumnType("TEXT");

                    b.Property<int?>("VacancyId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WorkerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("responses");
                });

            modelBuilder.Entity("FindWork.API.Models.Resume", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("desireSalary")
                        .HasColumnType("TEXT");

                    b.Property<string>("desireWork")
                        .HasColumnType("TEXT");

                    b.Property<string>("education")
                        .HasColumnType("TEXT");

                    b.Property<string>("educationDegree")
                        .HasColumnType("TEXT");

                    b.Property<string>("employmentDegree")
                        .HasColumnType("TEXT");

                    b.Property<int>("expirience")
                        .HasColumnType("INTEGER");

                    b.Property<int>("graduationYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("languages")
                        .HasColumnType("TEXT");

                    b.Property<string>("photoName")
                        .HasColumnType("TEXT");

                    b.Property<string>("photoSrc")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("publishTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("skills")
                        .HasColumnType("TEXT");

                    b.Property<string>("userId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("resumes");
                });

            modelBuilder.Entity("FindWork.API.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("isEmployer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("salt")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("saltedhashedpassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("secondname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("FindWork.API.Models.Vacancy", b =>
                {
                    b.Property<int>("vacancyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .HasColumnType("TEXT");

                    b.Property<string>("company")
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("location")
                        .HasColumnType("TEXT");

                    b.Property<string>("offer")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("publishtime")
                        .HasColumnType("TEXT");

                    b.Property<string>("requires")
                        .HasColumnType("TEXT");

                    b.Property<int>("salary")
                        .HasColumnType("INTEGER");

                    b.Property<string>("userId")
                        .HasColumnType("TEXT");

                    b.Property<string>("vacancyname")
                        .HasColumnType("TEXT");

                    b.HasKey("vacancyId");

                    b.ToTable("vacancies");
                });
#pragma warning restore 612, 618
        }
    }
}
