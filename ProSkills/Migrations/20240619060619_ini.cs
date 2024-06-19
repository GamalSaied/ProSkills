using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class ini : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "instructor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speciallization = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instructor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    NumberOfTrainees = table.Column<int>(type: "int", nullable: false),
                    NumberOfAssesments = table.Column<int>(type: "int", nullable: false),
                    NumberOfLessons = table.Column<int>(type: "int", nullable: false),
                    TotlaFileSize = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RedeemCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    isAvalible = table.Column<bool>(type: "bit", nullable: true),
                    packageid = table.Column<int>(type: "int", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedeemCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<int>(type: "int", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: true),
                    NumberOfTrainees = table.Column<int>(type: "int", nullable: true),
                    TotalFilesSize = table.Column<double>(type: "float", nullable: true),
                    NumberOfAssessment = table.Column<int>(type: "int", nullable: true),
                    NumberOfLessons = table.Column<int>(type: "int", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedeemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_instructor_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    downloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapters_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseTrainee_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CourseTrainee_Trainee_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Steps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Steps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Steps_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    downloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "19/06/2024 9:06:19 am", "", false, "Revit" },
                    { 2, "19/06/2024 9:06:19 am", "", false, "Sap" },
                    { 3, "19/06/2024 9:06:19 am", "", false, "Etabs" },
                    { 4, "19/06/2024 9:06:19 am", "", false, "Forge" },
                    { 5, "19/06/2024 9:06:19 am", "", false, "primavera" },
                    { 6, "19/06/2024 9:06:19 am", "", false, "wpf" },
                    { 7, "19/06/2024 9:06:19 am", "", false, "Windows Form" },
                    { 8, "19/06/2024 9:06:19 am", "", false, "NavisWorks" },
                    { 9, "19/06/2024 9:06:19 am", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "19/06/2024 9:06:19 am", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "19/06/2024 9:06:19 am", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "19/06/2024 9:06:19 am", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "19/06/2024 9:06:19 am", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "19/06/2024 9:06:19 am", "Trainee1@example.com", false, "Trainee 1", null },
                    { 2, "Bio for Trainee 2", null, "19/06/2024 9:06:19 am", "Trainee2@example.com", false, "Trainee 2", null },
                    { 3, "Bio for Trainee 3", null, "19/06/2024 9:06:19 am", "Trainee3@example.com", false, "Trainee 3", null },
                    { 4, "Bio for Trainee 4", null, "19/06/2024 9:06:19 am", "Trainee4@example.com", false, "Trainee 4", null },
                    { 5, "Bio for Trainee 5", null, "19/06/2024 9:06:19 am", "Trainee5@example.com", false, "Trainee 5", null },
                    { 6, "Bio for Trainee 6", null, "19/06/2024 9:06:19 am", "Trainee6@example.com", false, "Trainee 6", null },
                    { 7, "Bio for Trainee 7", null, "19/06/2024 9:06:19 am", "Trainee7@example.com", false, "Trainee 7", null },
                    { 8, "Bio for Trainee 8", null, "19/06/2024 9:06:19 am", "Trainee8@example.com", false, "Trainee 8", null },
                    { 9, "Bio for Trainee 9", null, "19/06/2024 9:06:19 am", "Trainee9@example.com", false, "Trainee 9", null },
                    { 10, "Bio for Trainee 10", null, "19/06/2024 9:06:19 am", "Trainee10@example.com", false, "Trainee 10", null },
                    { 11, "Bio for Trainee 11", null, "19/06/2024 9:06:19 am", "Trainee11@example.com", false, "Trainee 11", null },
                    { 12, "Bio for Trainee 12", null, "19/06/2024 9:06:19 am", "Trainee12@example.com", false, "Trainee 12", null },
                    { 13, "Bio for Trainee 13", null, "19/06/2024 9:06:19 am", "Trainee13@example.com", false, "Trainee 13", null },
                    { 14, "Bio for Trainee 14", null, "19/06/2024 9:06:19 am", "Trainee14@example.com", false, "Trainee 14", null },
                    { 15, "Bio for Trainee 15", null, "19/06/2024 9:06:19 am", "Trainee15@example.com", false, "Trainee 15", null },
                    { 16, "Bio for Trainee 16", null, "19/06/2024 9:06:19 am", "Trainee16@example.com", false, "Trainee 16", null },
                    { 17, "Bio for Trainee 17", null, "19/06/2024 9:06:19 am", "Trainee17@example.com", false, "Trainee 17", null },
                    { 18, "Bio for Trainee 18", null, "19/06/2024 9:06:19 am", "Trainee18@example.com", false, "Trainee 18", null },
                    { 19, "Bio for Trainee 19", null, "19/06/2024 9:06:19 am", "Trainee19@example.com", false, "Trainee 19", null },
                    { 20, "Bio for Trainee 20", null, "19/06/2024 9:06:19 am", "Trainee20@example.com", false, "Trainee 20", null },
                    { 21, "Bio for Trainee 21", null, "19/06/2024 9:06:19 am", "Trainee21@example.com", false, "Trainee 21", null },
                    { 22, "Bio for Trainee 22", null, "19/06/2024 9:06:19 am", "Trainee22@example.com", false, "Trainee 22", null },
                    { 23, "Bio for Trainee 23", null, "19/06/2024 9:06:19 am", "Trainee23@example.com", false, "Trainee 23", null },
                    { 24, "Bio for Trainee 24", null, "19/06/2024 9:06:19 am", "Trainee24@example.com", false, "Trainee 24", null },
                    { 25, "Bio for Trainee 25", null, "19/06/2024 9:06:19 am", "Trainee25@example.com", false, "Trainee 25", null },
                    { 26, "Bio for Trainee 26", null, "19/06/2024 9:06:19 am", "Trainee26@example.com", false, "Trainee 26", null },
                    { 27, "Bio for Trainee 27", null, "19/06/2024 9:06:19 am", "Trainee27@example.com", false, "Trainee 27", null },
                    { 28, "Bio for Trainee 28", null, "19/06/2024 9:06:19 am", "Trainee28@example.com", false, "Trainee 28", null },
                    { 30, "Bio for Trainee 30", null, "19/06/2024 9:06:19 am", "Trainee30@example.com", false, "Trainee 30", null }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "19/06/2024 9:06:19 am", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "19/06/2024 9:06:19 am", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "19/06/2024 9:06:19 am", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "19/06/2024 9:06:19 am", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "19/06/2024 9:06:19 am", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "19/06/2024 9:06:19 am", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "19/06/2024 9:06:19 am", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "19/06/2024 9:06:19 am", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "19/06/2024 9:06:19 am", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "19/06/2024 9:06:19 am", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "19/06/2024 9:06:19 am", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "19/06/2024 9:06:19 am", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "19/06/2024 9:06:19 am", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "19/06/2024 9:06:19 am", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "19/06/2024 9:06:19 am", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "19/06/2024 9:06:19 am", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "19/06/2024 9:06:19 am", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "19/06/2024 9:06:19 am", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "19/06/2024 9:06:19 am", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "19/06/2024 9:06:19 am", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "19/06/2024 9:06:19 am", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "19/06/2024 9:06:19 am", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "19/06/2024 9:06:19 am", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "19/06/2024 9:06:19 am", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "19/06/2024 9:06:19 am", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "19/06/2024 9:06:19 am", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "19/06/2024 9:06:19 am", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "19/06/2024 9:06:19 am", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "19/06/2024 9:06:19 am", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "19/06/2024 9:06:19 am", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9602), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9598), 10.5, 2 },
                    { 2, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9651), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9649), 15.199999999999999, 10 },
                    { 3, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9690), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9689), 11.699999999999999, 6 },
                    { 4, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 8, 18, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9714), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9712), 13.5, 7 },
                    { 5, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9724), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9723), 14.1, 9 },
                    { 6, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9734), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 7, 1, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9733), 12.300000000000001, 12 },
                    { 7, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 8, 13, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9748), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9746), 12.800000000000001, 6 },
                    { 8, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers software engineering principles and best practices.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9762), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 6, 25, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9760), 13.199999999999999, 11 },
                    { 9, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9774), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 28, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9772), 10.800000000000001, 3 },
                    { 10, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9784), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 30, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9783), 12.199999999999999, 1 },
                    { 11, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9795), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 7, 2, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9793), 13.5, 1 },
                    { 12, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9807), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9806), 13.1, 13 },
                    { 13, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9849), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9847), 10.6, 14 },
                    { 14, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of mobile app development.", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9860), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9859), 11.199999999999999, 15 },
                    { 15, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9871), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9869), 15.800000000000001, 6 },
                    { 16, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9883), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9881), 12.5, 2 },
                    { 17, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9893), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 7, 1, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9892), 13.800000000000001, 3 },
                    { 18, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 8, 13, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9903), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9901), 12.300000000000001, 7 },
                    { 19, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers database concepts and technologies for developers.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9913), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 6, 25, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9911), 13.1, 10 },
                    { 20, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9925), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 28, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9924), 11.800000000000001, 2 },
                    { 21, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9935), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 30, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9934), 12.5, 1 },
                    { 22, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of Ruby programming language.", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9945), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 7, 2, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9944), 13.199999999999999, 3 },
                    { 23, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9955), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9954), 13.6, 1 },
                    { 24, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9967), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9965), 10.9, 3 },
                    { 25, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9977), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9975), 11.4, 7 },
                    { 26, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9986), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9985), 15.199999999999999, 9 },
                    { 27, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9996), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9995), 13.699999999999999, 10 },
                    { 28, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 8, 8, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(10), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 7, 1, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(8), 14.300000000000001, 11 },
                    { 29, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 8, 13, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(21), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 27, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(19), 12.6, 6 },
                    { 30, "path/to/trainee/image.jpg", "19/06/2024 9:06:19 am", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 7, 24, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(31), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 25, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(29), 13.9, 14 }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Description for Chapter 1 in Course 1", false, "Chapter 1 for Course 1", "https://sadat.vip/" },
                    { 2, 1, "Description for Chapter 2 in Course 1", false, "Chapter 2 for Course 1", "https://sadat.vip/" },
                    { 3, 1, "Description for Chapter 3 in Course 1", false, "Chapter 3 for Course 1", "https://sadat.vip/" },
                    { 4, 2, "Description for Chapter 1 in Course 2", false, "Chapter 1 for Course 2", "https://sadat.vip/" },
                    { 5, 2, "Description for Chapter 2 in Course 2", false, "Chapter 2 for Course 2", "https://sadat.vip/" },
                    { 6, 3, "Description for Chapter 1 in Course 3", false, "Chapter 1 for Course 3", "https://sadat.vip/" },
                    { 7, 3, "Description for Chapter 2 in Course 3", false, "Chapter 2 for Course 3", "https://sadat.vip/" },
                    { 8, 3, "Description for Chapter 3 in Course 3", false, "Chapter 3 for Course 3", "https://sadat.vip/" },
                    { 9, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 10, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 11, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 13, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 14, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 15, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 16, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 17, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 18, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 19, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 20, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 21, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 22, 9, "Description for Chapter 3 in Course 9", false, "Chapter 3 for Course 9", "https://sadat.vip/" },
                    { 23, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 24, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 25, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 55.1532688064529m, 22 },
                    { 2, 10, 26.6610250808211m, 5 },
                    { 3, 21, 55.2309441168533m, 3 },
                    { 4, 25, 76.3906458053626m, 2 },
                    { 5, 19, 54.2653055921142m, 3 },
                    { 6, 7, 24.6096032809317m, 23 },
                    { 7, 6, 94.9400959265591m, 26 },
                    { 8, 2, 81.328919545353m, 8 },
                    { 9, 2, 21.5919435888571m, 3 },
                    { 10, 27, 29.8280855957526m, 1 },
                    { 11, 11, 60.2929847514642m, 14 },
                    { 12, 4, 16.2511810568416m, 14 },
                    { 13, 9, 28.5484498635912m, 27 },
                    { 14, 24, 88.8947903777376m, 5 },
                    { 15, 13, 72.6421258798176m, 16 },
                    { 16, 16, 89.7921073990626m, 18 },
                    { 17, 8, 17.8567441054018m, 22 },
                    { 18, 17, 24.5836403415671m, 21 },
                    { 19, 16, 50.0108739367166m, 27 },
                    { 20, 20, 24.138872480522m, 17 },
                    { 21, 18, 46.333615138887m, 19 },
                    { 22, 27, 51.6665583868402m, 12 },
                    { 23, 14, 58.7586227879225m, 20 },
                    { 24, 6, 43.9401391966398m, 15 },
                    { 25, 7, 37.8212117531538m, 9 },
                    { 26, 2, 58.3166322095881m, 24 },
                    { 27, 4, 22.9104573608962m, 3 },
                    { 28, 11, 71.6804433380751m, 6 },
                    { 29, 28, 60.7073278514154m, 23 },
                    { 30, 21, 78.3481962172574m, 2 },
                    { 31, 16, 57.6067721572026m, 2 },
                    { 32, 8, 65.4258165165357m, 21 },
                    { 33, 28, 95.112873527267m, 21 },
                    { 34, 19, 19.5817810825069m, 4 },
                    { 35, 12, 49.4575742629888m, 2 },
                    { 36, 18, 48.0932090869347m, 23 },
                    { 37, 15, 11.7960777851343m, 17 },
                    { 38, 12, 25.5506926370451m, 12 },
                    { 39, 5, 84.0089451592751m, 13 },
                    { 40, 24, 24.9576368986876m, 7 },
                    { 41, 23, 4.10661639163715m, 2 },
                    { 42, 26, 75.4491807276114m, 27 },
                    { 43, 26, 74.3705789162154m, 1 },
                    { 44, 27, 36.1292903737349m, 11 },
                    { 45, 11, 91.1611258588051m, 21 },
                    { 46, 10, 9.81839813465214m, 3 },
                    { 47, 17, 81.5259567666507m, 19 },
                    { 48, 28, 93.724251208762m, 6 },
                    { 49, 13, 91.6670015316294m, 18 },
                    { 50, 4, 43.7862356227735m, 8 },
                    { 51, 14, 98.4331935350716m, 14 },
                    { 52, 9, 30.7574503874438m, 23 },
                    { 53, 10, 91.5143409734975m, 14 },
                    { 54, 15, 6.61362853022m, 22 },
                    { 55, 5, 22.6636382020795m, 25 },
                    { 56, 22, 67.6297372323654m, 10 },
                    { 57, 18, 11.6805279011937m, 21 },
                    { 58, 15, 35.027308845738m, 11 },
                    { 59, 27, 79.712720202916m, 25 },
                    { 60, 28, 12.671466641676m, 15 },
                    { 61, 14, 30.6858395488969m, 7 },
                    { 62, 19, 86.3792028360851m, 13 },
                    { 63, 4, 75.6882929301606m, 14 },
                    { 64, 19, 61.2634373021175m, 24 },
                    { 65, 17, 77.1633389989271m, 1 },
                    { 66, 17, 59.7652741425409m, 13 },
                    { 67, 16, 58.8639266620847m, 21 },
                    { 68, 23, 98.5416642045032m, 13 },
                    { 69, 13, 23.6250265922517m, 11 },
                    { 70, 5, 86.5072656466642m, 18 },
                    { 71, 25, 65.6117991760971m, 21 },
                    { 72, 26, 50.818340253944m, 14 },
                    { 73, 20, 83.7541443582992m, 7 },
                    { 74, 19, 3.37649580235295m, 12 },
                    { 75, 20, 70.0275267948643m, 26 },
                    { 76, 5, 17.5433119841682m, 24 },
                    { 77, 22, 9.92400495737402m, 6 },
                    { 78, 20, 32.7546254382929m, 18 },
                    { 79, 9, 54.4860696471173m, 17 },
                    { 80, 18, 11.2302950601846m, 10 },
                    { 81, 4, 67.0550951119106m, 25 },
                    { 82, 18, 54.5509371810474m, 13 },
                    { 83, 28, 27.2553865437216m, 26 },
                    { 84, 19, 48.4396651942827m, 14 },
                    { 85, 11, 63.8830616933402m, 13 },
                    { 86, 25, 85.6409176157924m, 15 },
                    { 87, 24, 54.6406840451999m, 10 },
                    { 88, 23, 85.8174456423418m, 5 },
                    { 89, 12, 22.0588160553099m, 28 },
                    { 90, 26, 73.7302435445948m, 24 },
                    { 91, 9, 0.537604292460281m, 3 },
                    { 92, 14, 12.4579804583952m, 26 },
                    { 93, 3, 14.7367670063852m, 25 },
                    { 94, 28, 60.5661803973297m, 19 },
                    { 95, 9, 33.2920780579398m, 8 },
                    { 96, 5, 64.8127815662574m, 18 },
                    { 97, 17, 87.804751764421m, 2 },
                    { 98, 14, 23.7190561113773m, 4 },
                    { 99, 24, 49.2717337975873m, 9 },
                    { 100, 23, 96.3220699893526m, 9 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 7, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 8, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 9, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 10, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 11, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 12, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 13, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 14, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 15, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 16, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 17, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 18, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 19, 9, "Content for Lesson 3 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" },
                    { 20, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 21, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 22, 10, "Content for Lesson 3 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" },
                    { 23, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 24, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 25, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 26, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 27, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 28, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 29, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 30, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 31, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 32, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 33, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 34, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 35, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 36, 16, "Content for Lesson 3 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 16", "https://sadat.vip/" },
                    { 37, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 38, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 39, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 40, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 41, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 42, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 43, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 44, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 45, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 46, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 47, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 48, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 49, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 50, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 51, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 52, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 53, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 54, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 55, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 56, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 57, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 58, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 59, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_instructorId",
                table: "Course",
                column: "instructorId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainee_CourseId",
                table: "CourseTrainee",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainee_TraineeId",
                table: "CourseTrainee",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ChapterId",
                table: "Lessons",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Steps_CourseId",
                table: "Steps",
                column: "CourseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "RedeemCode");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
