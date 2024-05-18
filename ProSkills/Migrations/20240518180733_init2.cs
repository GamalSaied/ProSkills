using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
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
                    Phone = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "Trainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: true),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "18/05/2024 9:07:33 pm", "", false, "Revit" },
                    { 2, "18/05/2024 9:07:33 pm", "", false, "Sap" },
                    { 3, "18/05/2024 9:07:33 pm", "", false, "Etabs" },
                    { 4, "18/05/2024 9:07:33 pm", "", false, "Forge" },
                    { 5, "18/05/2024 9:07:33 pm", "", false, "primavera" },
                    { 6, "18/05/2024 9:07:33 pm", "", false, "wpf" },
                    { 7, "18/05/2024 9:07:33 pm", "", false, "Windows Form" },
                    { 8, "18/05/2024 9:07:33 pm", "", false, "NavisWorks" },
                    { 9, "18/05/2024 9:07:33 pm", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "18/05/2024 9:07:33 pm", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "18/05/2024 9:07:33 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "18/05/2024 9:07:33 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "18/05/2024 9:07:33 pm", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "18/05/2024 9:07:33 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "18/05/2024 9:07:33 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "18/05/2024 9:07:33 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "18/05/2024 9:07:33 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "18/05/2024 9:07:33 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "18/05/2024 9:07:33 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "18/05/2024 9:07:33 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "18/05/2024 9:07:33 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "18/05/2024 9:07:33 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "18/05/2024 9:07:33 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "18/05/2024 9:07:33 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "18/05/2024 9:07:33 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "18/05/2024 9:07:33 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "18/05/2024 9:07:33 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "18/05/2024 9:07:33 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "18/05/2024 9:07:33 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "18/05/2024 9:07:33 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "18/05/2024 9:07:33 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "18/05/2024 9:07:33 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "18/05/2024 9:07:33 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "18/05/2024 9:07:33 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "18/05/2024 9:07:33 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "18/05/2024 9:07:33 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "18/05/2024 9:07:33 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "18/05/2024 9:07:33 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "18/05/2024 9:07:33 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "18/05/2024 9:07:33 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "18/05/2024 9:07:33 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "18/05/2024 9:07:33 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "18/05/2024 9:07:33 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfStudents", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8307), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8301), 10.5, 5 },
                    { 2, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8358), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8356), 15.199999999999999, 13 },
                    { 3, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8369), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8368), 11.699999999999999, 10 },
                    { 4, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8391), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8389), 13.5, 9 },
                    { 5, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the design and management of relational databases.", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8401), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8399), 14.1, 2 },
                    { 6, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8411), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8409), 12.300000000000001, 15 },
                    { 7, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8421), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8420), 12.800000000000001, 9 },
                    { 8, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8434), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8433), 13.199999999999999, 15 },
                    { 9, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of Python programming language.", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8445), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8443), 10.800000000000001, 8 },
                    { 10, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8455), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 5, 29, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8453), 12.199999999999999, 1 },
                    { 11, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8465), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 5, 31, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8463), 13.5, 13 },
                    { 12, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers essential concepts in computer networks.", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8478), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8476), 13.1, 8 },
                    { 13, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8488), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8487), 10.6, 15 },
                    { 14, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8498), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8497), 11.199999999999999, 3 },
                    { 15, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8509), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8507), 15.800000000000001, 8 },
                    { 16, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8521), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8519), 12.5, 6 },
                    { 17, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8531), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8530), 13.800000000000001, 3 },
                    { 18, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8541), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8540), 12.300000000000001, 5 },
                    { 19, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8552), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8550), 13.1, 3 },
                    { 20, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8564), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 5, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8563), 11.800000000000001, 15 },
                    { 21, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8574), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 5, 29, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8573), 12.5, 4 },
                    { 22, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8585), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 5, 31, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8583), 13.199999999999999, 9 },
                    { 23, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8594), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8593), 13.6, 1 },
                    { 24, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8606), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8605), 10.9, 7 },
                    { 25, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8617), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8615), 11.4, 8 },
                    { 26, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8653), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8651), 15.199999999999999, 3 },
                    { 27, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8665), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8663), 13.699999999999999, 11 },
                    { 28, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8678), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8675), 14.300000000000001, 4 },
                    { 29, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8688), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8686), 12.6, 4 },
                    { 30, "path/to/trainee/image.jpg", "18/05/2024 9:07:33 pm", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8698), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8696), 13.9, 2 }
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
                name: "Package");

            migrationBuilder.DropTable(
                name: "RedeemCode");

            migrationBuilder.DropTable(
                name: "Steps");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
