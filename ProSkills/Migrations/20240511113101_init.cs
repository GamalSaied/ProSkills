using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
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
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    NumberOfTrainees = table.Column<int>(type: "int", nullable: false),
                    NumberOfAssesments = table.Column<int>(type: "int", nullable: false),
                    NumberOfLessons = table.Column<int>(type: "int", nullable: false),
                    TotlaFileSize = table.Column<double>(type: "float", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.Id);
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
                    Hours = table.Column<int>(type: "int", nullable: false),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    TotalFilesSize = table.Column<double>(type: "float", nullable: false),
                    NumberOfAssessment = table.Column<int>(type: "int", nullable: false),
                    NumberOfLessons = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "11/05/2024 14:31:01", "", false, "Revit" },
                    { 2, "11/05/2024 14:31:01", "", false, "Sap" },
                    { 3, "11/05/2024 14:31:01", "", false, "Etabs" },
                    { 4, "11/05/2024 14:31:01", "", false, "Forge" },
                    { 5, "11/05/2024 14:31:01", "", false, "primavera" },
                    { 6, "11/05/2024 14:31:01", "", false, "wpf" },
                    { 7, "11/05/2024 14:31:01", "", false, "Windows Form" },
                    { 8, "11/05/2024 14:31:01", "", false, "NavisWorks" },
                    { 9, "11/05/2024 14:31:01", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "11/05/2024 14:31:01", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "11/05/2024 14:31:01", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "11/05/2024 14:31:01", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "11/05/2024 14:31:01", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "11/05/2024 14:31:01", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "11/05/2024 14:31:01", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "11/05/2024 14:31:01", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "11/05/2024 14:31:01", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "11/05/2024 14:31:01", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "11/05/2024 14:31:01", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "11/05/2024 14:31:01", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "11/05/2024 14:31:01", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "11/05/2024 14:31:01", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "11/05/2024 14:31:01", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "11/05/2024 14:31:01", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "11/05/2024 14:31:01", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "11/05/2024 14:31:01", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "11/05/2024 14:31:01", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "11/05/2024 14:31:01", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "11/05/2024 14:31:01", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "11/05/2024 14:31:01", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "11/05/2024 14:31:01", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "11/05/2024 14:31:01", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "11/05/2024 14:31:01", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "11/05/2024 14:31:01", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "11/05/2024 14:31:01", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "11/05/2024 14:31:01", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "11/05/2024 14:31:01", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "11/05/2024 14:31:01", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "11/05/2024 14:31:01", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfStudents", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 10, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6403), 40, false, "Online", "Introduction to Programming", 5, 20, 25, new DateTime(2024, 5, 18, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6395), 10.5, 11 },
                    { 2, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 6, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6461), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, new DateTime(2024, 5, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6459), 15.199999999999999, 1 },
                    { 3, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6488), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, new DateTime(2024, 5, 16, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6486), 11.699999999999999, 7 },
                    { 4, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 10, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6500), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, new DateTime(2024, 5, 21, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6498), 13.5, 9 },
                    { 5, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the design and management of relational databases.", new DateTime(2024, 6, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6512), 50, false, "Online", "Database Design and Management", 7, 25, 30, new DateTime(2024, 5, 18, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6510), 14.1, 11 },
                    { 6, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 6, 30, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6523), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, new DateTime(2024, 5, 23, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6521), 12.300000000000001, 10 },
                    { 7, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 5, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6539), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, new DateTime(2024, 5, 19, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6537), 12.800000000000001, 13 },
                    { 8, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6551), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, new DateTime(2024, 5, 17, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6549), 13.199999999999999, 7 },
                    { 9, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of Python programming language.", new DateTime(2024, 6, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6562), 40, false, "Online", "Python Programming Basics", 5, 20, 25, new DateTime(2024, 5, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6560), 10.800000000000001, 11 },
                    { 10, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 6, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6574), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, new DateTime(2024, 5, 22, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6572), 12.199999999999999, 10 },
                    { 11, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 6, 30, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6588), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, new DateTime(2024, 5, 24, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6586), 13.5, 13 },
                    { 12, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers essential concepts in computer networks.", new DateTime(2024, 6, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6600), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, new DateTime(2024, 5, 21, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6598), 13.1, 12 },
                    { 13, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6611), 40, false, "Online", "Introduction to Linux", 5, 20, 25, new DateTime(2024, 5, 19, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6609), 10.6, 14 },
                    { 14, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 10, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6623), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, new DateTime(2024, 5, 18, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6621), 11.199999999999999, 8 },
                    { 15, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 6, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6638), 60, false, "Online", "Frontend Web Development", 7, 25, 30, new DateTime(2024, 5, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6636), 15.800000000000001, 5 },
                    { 16, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6649), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, new DateTime(2024, 5, 16, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6648), 12.5, 6 },
                    { 17, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 6, 30, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6661), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, new DateTime(2024, 5, 23, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6659), 13.800000000000001, 3 },
                    { 18, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 5, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6673), 50, false, "Online", "Node.js Development", 6, 23, 20, new DateTime(2024, 5, 19, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6671), 12.300000000000001, 6 },
                    { 19, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6687), 45, false, "Online", "Databases for Developers", 6, 22, 25, new DateTime(2024, 5, 17, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6685), 13.1, 2 },
                    { 20, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 6, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6699), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, new DateTime(2024, 5, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6697), 11.800000000000001, 8 },
                    { 21, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 6, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6710), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, new DateTime(2024, 5, 22, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6709), 12.5, 13 },
                    { 22, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of Ruby programming language.", new DateTime(2024, 6, 30, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6722), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, new DateTime(2024, 5, 24, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6720), 13.199999999999999, 11 },
                    { 23, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 6, 20, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6740), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, new DateTime(2024, 5, 21, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6738), 13.6, 11 },
                    { 24, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6755), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, new DateTime(2024, 5, 19, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6753), 10.9, 12 },
                    { 25, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 10, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6767), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, new DateTime(2024, 5, 18, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6765), 11.4, 5 },
                    { 26, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 6, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6780), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, new DateTime(2024, 5, 25, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6778), 15.199999999999999, 11 },
                    { 27, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6794), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, new DateTime(2024, 5, 16, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6792), 13.699999999999999, 2 },
                    { 28, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 6, 30, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6807), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, new DateTime(2024, 5, 23, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6805), 14.300000000000001, 12 },
                    { 29, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 5, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6819), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, new DateTime(2024, 5, 19, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6817), 12.6, 12 },
                    { 30, "path/to/trainee/image.jpg", "11/05/2024 14:31:01", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 15, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6831), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, new DateTime(2024, 5, 17, 14, 31, 1, 632, DateTimeKind.Local).AddTicks(6829), 13.9, 3 }
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
                name: "Course");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
