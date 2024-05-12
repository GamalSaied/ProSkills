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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "12/05/2024 16:44:10", "", false, "Revit" },
                    { 2, "12/05/2024 16:44:10", "", false, "Sap" },
                    { 3, "12/05/2024 16:44:10", "", false, "Etabs" },
                    { 4, "12/05/2024 16:44:10", "", false, "Forge" },
                    { 5, "12/05/2024 16:44:10", "", false, "primavera" },
                    { 6, "12/05/2024 16:44:10", "", false, "wpf" },
                    { 7, "12/05/2024 16:44:10", "", false, "Windows Form" },
                    { 8, "12/05/2024 16:44:10", "", false, "NavisWorks" },
                    { 9, "12/05/2024 16:44:10", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "12/05/2024 16:44:10", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "12/05/2024 16:44:10", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "12/05/2024 16:44:10", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "12/05/2024 16:44:10", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "12/05/2024 16:44:10", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "12/05/2024 16:44:10", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "12/05/2024 16:44:10", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "12/05/2024 16:44:10", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "12/05/2024 16:44:10", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "12/05/2024 16:44:10", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "12/05/2024 16:44:10", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "12/05/2024 16:44:10", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "12/05/2024 16:44:10", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "12/05/2024 16:44:10", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "12/05/2024 16:44:10", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "12/05/2024 16:44:10", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "12/05/2024 16:44:10", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "12/05/2024 16:44:10", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "12/05/2024 16:44:10", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "12/05/2024 16:44:10", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "12/05/2024 16:44:10", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "12/05/2024 16:44:10", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "12/05/2024 16:44:10", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "12/05/2024 16:44:10", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "12/05/2024 16:44:10", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "12/05/2024 16:44:10", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "12/05/2024 16:44:10", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "12/05/2024 16:44:10", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "12/05/2024 16:44:10", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "12/05/2024 16:44:10", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "12/05/2024 16:44:10", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "12/05/2024 16:44:10", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "12/05/2024 16:44:10", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "12/05/2024 16:44:10", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfStudents", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 11, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8017), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 5, 19, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8010), 10.5, 10 },
                    { 2, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 6, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8119), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 5, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8117), 15.199999999999999, 10 },
                    { 3, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8136), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 17, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8134), 11.699999999999999, 3 },
                    { 4, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 11, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8149), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 5, 22, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8147), 13.5, 10 },
                    { 5, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the design and management of relational databases.", new DateTime(2024, 6, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8161), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 5, 19, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8160), 14.1, 13 },
                    { 6, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 1, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8177), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 5, 24, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8175), 12.300000000000001, 6 },
                    { 7, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 6, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8189), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 5, 20, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8187), 12.800000000000001, 5 },
                    { 8, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8202), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 18, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8201), 13.199999999999999, 13 },
                    { 9, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of Python programming language.", new DateTime(2024, 6, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8215), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8213), 10.800000000000001, 3 },
                    { 10, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 6, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8230), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 5, 23, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8228), 12.199999999999999, 1 },
                    { 11, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 1, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8243), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 5, 25, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8241), 13.5, 3 },
                    { 12, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers essential concepts in computer networks.", new DateTime(2024, 6, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8255), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 5, 22, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8253), 13.1, 3 },
                    { 13, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8318), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 5, 20, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8315), 10.6, 12 },
                    { 14, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 11, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8334), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 5, 19, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8333), 11.199999999999999, 5 },
                    { 15, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 6, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8347), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 5, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8345), 15.800000000000001, 1 },
                    { 16, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8360), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 17, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8358), 12.5, 5 },
                    { 17, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 1, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8372), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 5, 24, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8370), 13.800000000000001, 11 },
                    { 18, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 6, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8388), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 5, 20, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8386), 12.300000000000001, 15 },
                    { 19, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8401), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 18, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8399), 13.1, 7 },
                    { 20, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 6, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8414), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 5, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8412), 11.800000000000001, 9 },
                    { 21, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 6, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8426), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 5, 23, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8424), 12.5, 11 },
                    { 22, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 1, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8441), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 5, 25, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8439), 13.199999999999999, 4 },
                    { 23, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 6, 21, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8453), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 5, 22, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8451), 13.6, 10 },
                    { 24, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8467), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 20, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8465), 10.9, 2 },
                    { 25, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 11, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8678), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 5, 19, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8675), 11.4, 3 },
                    { 26, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 6, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8693), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 5, 26, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8691), 15.199999999999999, 5 },
                    { 27, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8705), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 17, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8704), 13.699999999999999, 6 },
                    { 28, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 1, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8718), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 5, 24, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8716), 14.300000000000001, 3 },
                    { 29, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 6, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8731), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 5, 20, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8728), 12.6, 11 },
                    { 30, "path/to/trainee/image.jpg", "12/05/2024 16:44:10", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 16, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8746), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 18, 16, 44, 10, 876, DateTimeKind.Local).AddTicks(8744), 13.9, 13 }
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
                name: "RedeemCode");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
