﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProSkills.Models;

#nullable disable

namespace ProSkills.Migrations
{
    [DbContext(typeof(ITIContext))]
    partial class ITIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ProSkills.Models.AdminPanel.InstructorManger.instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speciallization")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("instructor");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Bio for Instructor 1",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor1@example.com",
                            IsDeleted = false,
                            Name = "Instructor 1",
                            Password = "password1"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "Bio for Instructor 2",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor2@example.com",
                            IsDeleted = false,
                            Name = "Instructor 2",
                            Password = "password2"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Bio for Instructor 3",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor3@example.com",
                            IsDeleted = false,
                            Name = "Instructor 3",
                            Password = "password3"
                        },
                        new
                        {
                            Id = 4,
                            Bio = "Bio for Instructor 4",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor4@example.com",
                            IsDeleted = false,
                            Name = "Instructor 4",
                            Password = "password4"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Bio for Instructor 5",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor5@example.com",
                            IsDeleted = false,
                            Name = "Instructor 5",
                            Password = "password5"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "Bio for Instructor 6",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor6@example.com",
                            IsDeleted = false,
                            Name = "Instructor 6",
                            Password = "password6"
                        },
                        new
                        {
                            Id = 7,
                            Bio = "Bio for Instructor 7",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor7@example.com",
                            IsDeleted = false,
                            Name = "Instructor 7",
                            Password = "password7"
                        },
                        new
                        {
                            Id = 8,
                            Bio = "Bio for Instructor 8",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor8@example.com",
                            IsDeleted = false,
                            Name = "Instructor 8",
                            Password = "password8"
                        },
                        new
                        {
                            Id = 9,
                            Bio = "Bio for Instructor 9",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor9@example.com",
                            IsDeleted = false,
                            Name = "Instructor 9",
                            Password = "password9"
                        },
                        new
                        {
                            Id = 10,
                            Bio = "Bio for Instructor 10",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor10@example.com",
                            IsDeleted = false,
                            Name = "Instructor 10",
                            Password = "password10"
                        },
                        new
                        {
                            Id = 11,
                            Bio = "Bio for Instructor 11",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor11@example.com",
                            IsDeleted = false,
                            Name = "Instructor 11",
                            Password = "password11"
                        },
                        new
                        {
                            Id = 12,
                            Bio = "Bio for Instructor 12",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor12@example.com",
                            IsDeleted = false,
                            Name = "Instructor 12",
                            Password = "password12"
                        },
                        new
                        {
                            Id = 13,
                            Bio = "Bio for Instructor 13",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor13@example.com",
                            IsDeleted = false,
                            Name = "Instructor 13",
                            Password = "password13"
                        },
                        new
                        {
                            Id = 14,
                            Bio = "Bio for Instructor 14",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor14@example.com",
                            IsDeleted = false,
                            Name = "Instructor 14",
                            Password = "password14"
                        },
                        new
                        {
                            Id = 15,
                            Bio = "Bio for Instructor 15",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor15@example.com",
                            IsDeleted = false,
                            Name = "Instructor 15",
                            Password = "password15"
                        },
                        new
                        {
                            Id = 16,
                            Bio = "Bio for Instructor 16",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor16@example.com",
                            IsDeleted = false,
                            Name = "Instructor 16",
                            Password = "password16"
                        },
                        new
                        {
                            Id = 17,
                            Bio = "Bio for Instructor 17",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor17@example.com",
                            IsDeleted = false,
                            Name = "Instructor 17",
                            Password = "password17"
                        },
                        new
                        {
                            Id = 18,
                            Bio = "Bio for Instructor 18",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor18@example.com",
                            IsDeleted = false,
                            Name = "Instructor 18",
                            Password = "password18"
                        },
                        new
                        {
                            Id = 19,
                            Bio = "Bio for Instructor 19",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor19@example.com",
                            IsDeleted = false,
                            Name = "Instructor 19",
                            Password = "password19"
                        },
                        new
                        {
                            Id = 20,
                            Bio = "Bio for Instructor 20",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor20@example.com",
                            IsDeleted = false,
                            Name = "Instructor 20",
                            Password = "password20"
                        },
                        new
                        {
                            Id = 21,
                            Bio = "Bio for Instructor 21",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor21@example.com",
                            IsDeleted = false,
                            Name = "Instructor 21",
                            Password = "password21"
                        },
                        new
                        {
                            Id = 22,
                            Bio = "Bio for Instructor 22",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor22@example.com",
                            IsDeleted = false,
                            Name = "Instructor 22",
                            Password = "password22"
                        },
                        new
                        {
                            Id = 23,
                            Bio = "Bio for Instructor 23",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor23@example.com",
                            IsDeleted = false,
                            Name = "Instructor 23",
                            Password = "password23"
                        },
                        new
                        {
                            Id = 24,
                            Bio = "Bio for Instructor 24",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor24@example.com",
                            IsDeleted = false,
                            Name = "Instructor 24",
                            Password = "password24"
                        },
                        new
                        {
                            Id = 25,
                            Bio = "Bio for Instructor 25",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor25@example.com",
                            IsDeleted = false,
                            Name = "Instructor 25",
                            Password = "password25"
                        },
                        new
                        {
                            Id = 26,
                            Bio = "Bio for Instructor 26",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor26@example.com",
                            IsDeleted = false,
                            Name = "Instructor 26",
                            Password = "password26"
                        },
                        new
                        {
                            Id = 27,
                            Bio = "Bio for Instructor 27",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor27@example.com",
                            IsDeleted = false,
                            Name = "Instructor 27",
                            Password = "password27"
                        },
                        new
                        {
                            Id = 28,
                            Bio = "Bio for Instructor 28",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor28@example.com",
                            IsDeleted = false,
                            Name = "Instructor 28",
                            Password = "password28"
                        },
                        new
                        {
                            Id = 29,
                            Bio = "Bio for Instructor 29",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor29@example.com",
                            IsDeleted = false,
                            Name = "Instructor 29",
                            Password = "password29"
                        },
                        new
                        {
                            Id = 30,
                            Bio = "Bio for Instructor 30",
                            CreatedAt = "08/05/2024 05:51:53 م",
                            Email = "instructor30@example.com",
                            IsDeleted = false,
                            Name = "Instructor 30",
                            Password = "password30"
                        });
                });

            modelBuilder.Entity("ProSkills.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Assessment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaxScore")
                        .HasColumnType("int");

                    b.Property<int>("ModuleId")
                        .HasColumnType("int");

                    b.Property<string>("Weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("assessmentType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ModuleId");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CourseCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedAt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("Hours")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfAssessment")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfLessons")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfStudents")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalFilesSize")
                        .HasColumnType("float");

                    b.Property<string>("TraineeImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("maxDegree")
                        .HasColumnType("int");

                    b.Property<int>("minDegree")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Enrollment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EnrollDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FinalGrade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TraineeId");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.InstructorCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("instructorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("instructorId");

                    b.ToTable("InstructorCourse");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Module", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Submission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssessmentId")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<DateTime>("SubmittedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssessmentId");

                    b.HasIndex("TraineeId");

                    b.ToTable("Submission");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Trainee");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ProSkills.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ProSkills.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProSkills.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ProSkills.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Assessment", b =>
                {
                    b.HasOne("ProSkills.Models.ClientSide.Module", "module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("module");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Enrollment", b =>
                {
                    b.HasOne("ProSkills.Models.ClientSide.Course", "Course")
                        .WithMany("enrollments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProSkills.Models.ClientSide.Trainee", "Trainee")
                        .WithMany("enrollments")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.InstructorCourse", b =>
                {
                    b.HasOne("ProSkills.Models.ClientSide.Course", "Course")
                        .WithMany("instructorCourse")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProSkills.Models.AdminPanel.InstructorManger.instructor", "Instructor")
                        .WithMany("instructorCourses")
                        .HasForeignKey("instructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Module", b =>
                {
                    b.HasOne("ProSkills.Models.ClientSide.Course", "CourseData")
                        .WithMany("modules")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProSkills.Models.AdminPanel.InstructorManger.instructor", "instructorData")
                        .WithMany("modules")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseData");

                    b.Navigation("instructorData");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Submission", b =>
                {
                    b.HasOne("ProSkills.Models.ClientSide.Assessment", "assessment")
                        .WithMany("submissions")
                        .HasForeignKey("AssessmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProSkills.Models.ClientSide.Trainee", "trainee")
                        .WithMany("submissions")
                        .HasForeignKey("TraineeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("assessment");

                    b.Navigation("trainee");
                });

            modelBuilder.Entity("ProSkills.Models.AdminPanel.InstructorManger.instructor", b =>
                {
                    b.Navigation("instructorCourses");

                    b.Navigation("modules");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Assessment", b =>
                {
                    b.Navigation("submissions");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Course", b =>
                {
                    b.Navigation("enrollments");

                    b.Navigation("instructorCourse");

                    b.Navigation("modules");
                });

            modelBuilder.Entity("ProSkills.Models.ClientSide.Trainee", b =>
                {
                    b.Navigation("enrollments");

                    b.Navigation("submissions");
                });
#pragma warning restore 612, 618
        }
    }
}
