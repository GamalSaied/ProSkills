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
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Information = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DownloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DemoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProfilePictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    CourseImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Price = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Course_instructor_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessments_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
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
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ActivityLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseTraineeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityLog_CourseTrainee_CourseTraineeId",
                        column: x => x.CourseTraineeId,
                        principalTable: "CourseTrainee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Admin", "ADMIN" },
                    { "2", null, "Instructor", "INSTRUCTOR" },
                    { "3", null, "Trainee", "TRAINEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "CountryCode", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Phone", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, null, "bab2168e-cd6e-49a5-a9b4-4c462ac2bb59", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEFjRwVlbWrieEJHAWjyYbQUGyoc6ZdkfWRj0Ym4BTD5zALZ4Use/Bo+WvNREP1fG2A==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "484b9dd1-516f-4b39-9480-b80299fa3c50", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAELLFUs0tDLvwb4Hb59Q/R7ewvLafa2C58voQql9wS/IqzZ9Hz3EMsgqB0KSjfWaMOA==", "01050403037", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "e08cc13d-fa3d-45da-a787-47c8945d05b6", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEPa/UZ9AD5YyvA0mp3xsxKQKmHnUa682bu4UuS9HSqfMRGwkva9al3OP5rn9hG/onw==", "01033901616", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "22/06/2024 9:55:46 am", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "22/06/2024 9:55:46 am", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "22/06/2024 9:55:46 am", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "22/06/2024 9:55:46 am", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "22/06/2024 9:55:46 am", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "22/06/2024 9:55:46 am", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "22/06/2024 9:55:46 am", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "22/06/2024 9:55:46 am", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "22/06/2024 9:55:46 am", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "22/06/2024 9:55:46 am", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "22/06/2024 9:55:46 am", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "22/06/2024 9:55:46 am", "Trainee1@example.com", false, "Trainee 1 Name", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "22/06/2024 9:55:46 am", "Trainee2@example.com", false, "Trainee 2 Name", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "22/06/2024 9:55:46 am", "Trainee3@example.com", false, "Trainee 3 Name", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "22/06/2024 9:55:46 am", "Trainee4@example.com", false, "Trainee 4 Name", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "22/06/2024 9:55:46 am", "Trainee5@example.com", false, "Trainee 5 Name", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "22/06/2024 9:55:46 am", "Trainee6@example.com", false, "Trainee 6 Name", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "22/06/2024 9:55:46 am", "Trainee7@example.com", false, "Trainee 7 Name", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "22/06/2024 9:55:46 am", "Trainee8@example.com", false, "Trainee 8 Name", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "22/06/2024 9:55:46 am", "Trainee9@example.com", false, "Trainee 9 Name", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "22/06/2024 9:55:46 am", "Trainee10@example.com", false, "Trainee 10 Name", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "22/06/2024 9:55:46 am", "Trainee11@example.com", false, "Trainee 11 Name", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "22/06/2024 9:55:46 am", "Trainee12@example.com", false, "Trainee 12 Name", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "22/06/2024 9:55:46 am", "Trainee13@example.com", false, "Trainee 13 Name", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "22/06/2024 9:55:46 am", "Trainee14@example.com", false, "Trainee 14 Name", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "22/06/2024 9:55:46 am", "Trainee15@example.com", false, "Trainee 15 Name", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "22/06/2024 9:55:46 am", "Trainee16@example.com", false, "Trainee 16 Name", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "22/06/2024 9:55:46 am", "Trainee17@example.com", false, "Trainee 17 Name", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "22/06/2024 9:55:46 am", "Trainee18@example.com", false, "Trainee 18 Name", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "22/06/2024 9:55:46 am", "Trainee19@example.com", false, "Trainee 19 Name", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "22/06/2024 9:55:46 am", "Trainee20@example.com", false, "Trainee 20 Name", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "22/06/2024 9:55:46 am", "Trainee21@example.com", false, "Trainee 21 Name", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "22/06/2024 9:55:46 am", "Trainee22@example.com", false, "Trainee 22 Name", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "22/06/2024 9:55:46 am", "Trainee23@example.com", false, "Trainee 23 Name", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "22/06/2024 9:55:46 am", "Trainee24@example.com", false, "Trainee 24 Name", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "22/06/2024 9:55:46 am", "Trainee25@example.com", false, "Trainee 25 Name", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "22/06/2024 9:55:46 am", "Trainee26@example.com", false, "Trainee 26 Name", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "22/06/2024 9:55:46 am", "Trainee27@example.com", false, "Trainee 27 Name", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "22/06/2024 9:55:46 am", "Trainee28@example.com", false, "Trainee 28 Name", null, "/themefront/img/user.jpg" },
                    { 29, "Bio for Trainee 29", null, "22/06/2024 9:55:46 am", "Trainee29@example.com", false, "Trainee 29 Name", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "22/06/2024 9:55:46 am", "Trainee30@example.com", false, "Trainee 30 Name", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "22/06/2024 9:55:46 am", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "22/06/2024 9:55:46 am", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "22/06/2024 9:55:46 am", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "22/06/2024 9:55:46 am", "instructor1@example.com", false, "Instructor 1 Name", "password1", null },
                    { 2, "Bio for Instructor 2", "22/06/2024 9:55:46 am", "instructor2@example.com", false, "Instructor 2 Name", "password2", null },
                    { 3, "Bio for Instructor 3", "22/06/2024 9:55:46 am", "instructor3@example.com", false, "Instructor 3 Name", "password3", null },
                    { 4, "Bio for Instructor 4", "22/06/2024 9:55:46 am", "instructor4@example.com", false, "Instructor 4 Name", "password4", null },
                    { 5, "Bio for Instructor 5", "22/06/2024 9:55:46 am", "instructor5@example.com", false, "Instructor 5 Name", "password5", null },
                    { 6, "Bio for Instructor 6", "22/06/2024 9:55:46 am", "instructor6@example.com", false, "Instructor 6 Name", "password6", null },
                    { 7, "Bio for Instructor 7", "22/06/2024 9:55:46 am", "instructor7@example.com", false, "Instructor 7 Name", "password7", null },
                    { 8, "Bio for Instructor 8", "22/06/2024 9:55:46 am", "instructor8@example.com", false, "Instructor 8 Name", "password8", null },
                    { 9, "Bio for Instructor 9", "22/06/2024 9:55:46 am", "instructor9@example.com", false, "Instructor 9 Name", "password9", null },
                    { 10, "Bio for Instructor 10", "22/06/2024 9:55:46 am", "instructor10@example.com", false, "Instructor 10 Name", "password10", null },
                    { 11, "Bio for Instructor 11", "22/06/2024 9:55:46 am", "instructor11@example.com", false, "Instructor 11 Name", "password11", null },
                    { 12, "Bio for Instructor 12", "22/06/2024 9:55:46 am", "instructor12@example.com", false, "Instructor 12 Name", "password12", null },
                    { 13, "Bio for Instructor 13", "22/06/2024 9:55:46 am", "instructor13@example.com", false, "Instructor 13 Name", "password13", null },
                    { 14, "Bio for Instructor 14", "22/06/2024 9:55:46 am", "instructor14@example.com", false, "Instructor 14 Name", "password14", null },
                    { 15, "Bio for Instructor 15", "22/06/2024 9:55:46 am", "instructor15@example.com", false, "Instructor 15 Name", "password15", null },
                    { 16, "Bio for Instructor 16", "22/06/2024 9:55:46 am", "instructor16@example.com", false, "Instructor 16 Name", "password16", null },
                    { 17, "Bio for Instructor 17", "22/06/2024 9:55:46 am", "instructor17@example.com", false, "Instructor 17 Name", "password17", null },
                    { 18, "Bio for Instructor 18", "22/06/2024 9:55:46 am", "instructor18@example.com", false, "Instructor 18 Name", "password18", null },
                    { 19, "Bio for Instructor 19", "22/06/2024 9:55:46 am", "instructor19@example.com", false, "Instructor 19 Name", "password19", null },
                    { 20, "Bio for Instructor 20", "22/06/2024 9:55:46 am", "instructor20@example.com", false, "Instructor 20 Name", "password20", null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "1", "2" },
                    { "1", "3" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "Price", "Rating", "RedeemCode", "ReviewCount", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, 1, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Structural Revit", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4216), 40, false, "Online", "Structural Revit", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4206), 10.5, 5 },
                    { 2, 1, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Arch Revit", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4335), 60, false, "Online", "Arch Revit", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 7, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4329), 15.199999999999999, 1 },
                    { 3, 1, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn MEP Revit", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4401), 45, false, "Online", "MEP Revit", 6, 22, 20, 0, 0, null, 0, new DateTime(2024, 6, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4397), 11.699999999999999, 11 },
                    { 4, 2, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Structural AutoCAD", new DateTime(2024, 8, 21, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4433), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, 0, 0, null, 0, new DateTime(2024, 7, 2, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4428), 13.5, 14 },
                    { 5, 2, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Arch AutoCAD", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4483), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4478), 14.1, 2 },
                    { 6, 2, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn MEP AutoCAD", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4518), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, 0, 0, null, 0, new DateTime(2024, 7, 4, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4514), 12.300000000000001, 15 },
                    { 7, 2, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn 3D AutoCAD", new DateTime(2024, 8, 16, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4559), 50, false, "Online", "3D AutoCAD", 6, 23, 20, 0, 0, null, 0, new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4542), 12.800000000000001, 15 },
                    { 8, 3, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Tekla", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4624), 45, false, "Online", "Tekla", 6, 22, 30, 0, 0, null, 0, new DateTime(2024, 6, 28, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4620), 13.199999999999999, 4 },
                    { 9, 3, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn SketchUP", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4670), 40, false, "Online", "SketchUP", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 7, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4647), 10.800000000000001, 8 },
                    { 10, 4, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn SAP 2000", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4823), 50, false, "Online", "SAP 2000", 6, 22, 20, 0, 0, null, 0, new DateTime(2024, 7, 3, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4819), 12.199999999999999, 4 },
                    { 11, 4, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn STAAD Pro", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4850), 55, false, "Online", "STAAD Pro", 6, 24, 25, 0, 0, null, 0, new DateTime(2024, 7, 5, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4846), 13.5, 15 },
                    { 12, 5, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn CIVIL 3D", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4872), 45, false, "Online", "CIVIL 3D", 6, 22, 30, 0, 0, null, 0, new DateTime(2024, 7, 2, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4868), 13.1, 5 },
                    { 13, 4, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn ETABS", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5069), 40, false, "Online", "ETABS", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5066), 10.6, 1 },
                    { 14, 4, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn SAFE", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5099), 35, false, "Online", "SAFE", 5, 18, 20, 0, 0, null, 0, new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5095), 11.199999999999999, 7 },
                    { 15, 6, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Primavera P6", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5162), 60, false, "Online", "Primavera P6", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 7, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5157), 15.800000000000001, 3 },
                    { 16, 6, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Microsoft Project", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5195), 45, false, "Online", "Microsoft Project", 6, 22, 25, 0, 0, null, 0, new DateTime(2024, 6, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5190), 12.5, 1 },
                    { 17, 3, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Navisworks", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5223), 55, false, "Online", "Navisworks", 6, 24, 30, 0, 0, null, 0, new DateTime(2024, 7, 4, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5219), 13.800000000000001, 5 },
                    { 18, 7, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Advanced Revit Structure", new DateTime(2024, 8, 16, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5247), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, 0, 0, null, 0, new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5243), 12.300000000000001, 8 },
                    { 19, 7, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5269), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, 0, 0, null, 0, new DateTime(2024, 6, 28, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5265), 13.699999999999999, 13 },
                    { 20, 7, "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", "Learn Advanced Revit MEP", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5290), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, 0, 0, null, 0, new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5287), 11.4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Description for Chapter 1 in Course 1", false, "Chapter 1 for Course 1", "https://sadat.vip/" },
                    { 2, 1, "Description for Chapter 2 in Course 1", false, "Chapter 2 for Course 1", "https://sadat.vip/" },
                    { 3, 2, "Description for Chapter 1 in Course 2", false, "Chapter 1 for Course 2", "https://sadat.vip/" },
                    { 4, 2, "Description for Chapter 2 in Course 2", false, "Chapter 2 for Course 2", "https://sadat.vip/" },
                    { 5, 3, "Description for Chapter 1 in Course 3", false, "Chapter 1 for Course 3", "https://sadat.vip/" },
                    { 6, 3, "Description for Chapter 2 in Course 3", false, "Chapter 2 for Course 3", "https://sadat.vip/" },
                    { 7, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 8, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 9, 4, "Description for Chapter 3 in Course 4", false, "Chapter 3 for Course 4", "https://sadat.vip/" },
                    { 10, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 11, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 12, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 13, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 14, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 15, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 16, 7, "Description for Chapter 3 in Course 7", false, "Chapter 3 for Course 7", "https://sadat.vip/" },
                    { 17, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 18, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 19, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 20, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 21, 9, "Description for Chapter 3 in Course 9", false, "Chapter 3 for Course 9", "https://sadat.vip/" },
                    { 22, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 23, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Level", "Points", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 0, 960, 2.10767442887495m, 1 },
                    { 2, 1, 0, 180, 38.7329446470883m, 2 },
                    { 3, 1, 0, 400, 0.696204449674564m, 3 },
                    { 4, 1, 0, 930, 45.9126005095335m, 4 },
                    { 5, 1, 0, 480, 15.1268537559829m, 5 },
                    { 6, 1, 0, 700, 16.6523499369984m, 6 },
                    { 7, 1, 0, 400, 60.6645946962313m, 7 },
                    { 8, 1, 0, 950, 49.7195680976626m, 8 },
                    { 9, 1, 0, 400, 34.5634215893546m, 9 },
                    { 10, 1, 0, 350, 44.3158464455209m, 10 },
                    { 11, 1, 0, 750, 20.7224183024248m, 11 },
                    { 12, 1, 0, 830, 53.5935528406216m, 12 },
                    { 13, 1, 0, 500, 31.6188586927732m, 13 },
                    { 14, 1, 0, 860, 31.1394892177886m, 14 },
                    { 15, 1, 0, 920, 11.96711642206m, 15 },
                    { 16, 1, 0, 200, 73.5755608770866m, 16 },
                    { 17, 1, 0, 60, 82.3104399755859m, 17 },
                    { 18, 1, 0, 230, 54.9405232039624m, 18 },
                    { 19, 1, 0, 940, 22.0312417499487m, 19 },
                    { 20, 1, 0, 300, 41.5845810565632m, 20 },
                    { 21, 1, 0, 1000, 29.9279971579442m, 21 },
                    { 22, 1, 0, 340, 22.6677801495418m, 22 },
                    { 23, 1, 0, 410, 49.3635774093281m, 23 },
                    { 24, 1, 0, 90, 78.1701464048519m, 24 },
                    { 25, 1, 0, 410, 0.210631876150413m, 25 },
                    { 26, 1, 0, 30, 32.9820616380855m, 26 },
                    { 27, 1, 0, 730, 85.3270972118296m, 27 },
                    { 28, 1, 0, 80, 1.49338316930054m, 28 },
                    { 29, 1, 0, 720, 22.040935051195m, 29 },
                    { 30, 1, 0, 890, 72.9948320628469m, 30 },
                    { 31, 2, 0, 770, 48.3717202833934m, 1 },
                    { 32, 2, 0, 240, 61.7935738949366m, 2 },
                    { 33, 2, 0, 620, 27.8276691048599m, 3 },
                    { 34, 2, 0, 810, 43.9833510931792m, 4 },
                    { 35, 2, 0, 480, 8.32219579396049m, 5 },
                    { 36, 2, 0, 740, 56.7865862253799m, 6 },
                    { 37, 2, 0, 340, 79.8429369272167m, 7 },
                    { 38, 2, 0, 340, 91.4365672098637m, 8 },
                    { 39, 2, 0, 830, 97.0154712337536m, 9 },
                    { 40, 2, 0, 870, 28.3477540029361m, 10 },
                    { 41, 2, 0, 330, 74.2880907532118m, 11 },
                    { 42, 2, 0, 410, 2.68901434878218m, 12 },
                    { 43, 2, 0, 710, 17.0782747657317m, 13 },
                    { 44, 2, 0, 210, 25.0941931764319m, 14 },
                    { 45, 2, 0, 250, 7.43303325764869m, 15 },
                    { 46, 2, 0, 750, 73.1282510409144m, 16 },
                    { 47, 2, 0, 180, 64.4146719003981m, 17 },
                    { 48, 2, 0, 930, 5.69810535060713m, 18 },
                    { 49, 2, 0, 60, 4.92767451426871m, 19 },
                    { 50, 2, 0, 750, 9.0390170513892m, 20 },
                    { 51, 2, 0, 0, 50.8740157973935m, 21 },
                    { 52, 2, 0, 540, 71.3285969564476m, 22 },
                    { 53, 2, 0, 980, 4.33585749099484m, 23 },
                    { 54, 2, 0, 780, 32.7722806211955m, 24 },
                    { 55, 2, 0, 190, 84.241556054282m, 25 },
                    { 56, 2, 0, 580, 78.2145952280529m, 26 },
                    { 57, 2, 0, 660, 42.5207171240993m, 27 },
                    { 58, 2, 0, 630, 71.4110963894256m, 28 },
                    { 59, 2, 0, 760, 96.0504466535224m, 29 },
                    { 60, 2, 0, 410, 22.8764974976167m, 30 },
                    { 61, 3, 0, 610, 95.8982840390278m, 1 },
                    { 62, 3, 0, 740, 74.27230775527m, 2 },
                    { 63, 3, 0, 340, 76.2486090974163m, 3 },
                    { 64, 3, 0, 190, 70.9582350313459m, 4 },
                    { 65, 3, 0, 510, 27.5634921022718m, 5 },
                    { 66, 3, 0, 620, 87.3364692155988m, 6 },
                    { 67, 3, 0, 880, 14.0460704106794m, 7 },
                    { 68, 3, 0, 990, 30.9550799618138m, 8 },
                    { 69, 3, 0, 70, 73.6952456040039m, 9 },
                    { 70, 3, 0, 540, 88.2020742377125m, 10 },
                    { 71, 3, 0, 250, 71.5349406342558m, 11 },
                    { 72, 3, 0, 400, 59.0917785955575m, 12 },
                    { 73, 3, 0, 880, 31.016264203867m, 13 },
                    { 74, 3, 0, 520, 5.8850945012945m, 14 },
                    { 75, 3, 0, 940, 63.7968931150628m, 15 },
                    { 76, 3, 0, 520, 85.2074916754957m, 16 },
                    { 77, 3, 0, 150, 53.1663797419998m, 17 },
                    { 78, 3, 0, 130, 90.7606355353867m, 18 },
                    { 79, 3, 0, 850, 62.2617673927969m, 19 },
                    { 80, 3, 0, 180, 33.9407980982993m, 20 },
                    { 81, 3, 0, 760, 43.221585581831m, 21 },
                    { 82, 3, 0, 870, 66.8165590011004m, 22 },
                    { 83, 3, 0, 180, 54.1158188150042m, 23 },
                    { 84, 3, 0, 860, 58.1061345714383m, 24 },
                    { 85, 3, 0, 280, 5.67676234003762m, 25 },
                    { 86, 3, 0, 650, 37.5275805307411m, 26 },
                    { 87, 3, 0, 1000, 94.3124934567654m, 27 },
                    { 88, 3, 0, 370, 11.2038440942784m, 28 },
                    { 89, 3, 0, 50, 23.3480101522682m, 29 },
                    { 91, 3, 0, 150, 24.7478355130667m, 31 },
                    { 92, 3, 0, 340, 39.1928895785629m, 32 },
                    { 93, 3, 0, 760, 19.273337079728m, 33 },
                    { 94, 4, 0, 460, 35.7493888332068m, 1 },
                    { 95, 4, 0, 360, 61.3789854097933m, 2 },
                    { 96, 4, 0, 920, 24.9395689997209m, 3 },
                    { 97, 4, 0, 470, 46.447376838547m, 4 },
                    { 98, 4, 0, 680, 60.6714758406906m, 5 },
                    { 99, 4, 0, 520, 11.4182633192076m, 6 },
                    { 100, 4, 0, 670, 85.8939103673344m, 7 },
                    { 101, 1, 0, 900, 29.7187039645832m, 31 },
                    { 102, 1, 0, 430, 43.1638197263043m, 32 },
                    { 103, 1, 0, 840, 83.2063701577527m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 10, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 13, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 3 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 6", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 20, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 21, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 22, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 23, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 24, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 3 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 28, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 32, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 33, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 34, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 35, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 36, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 37, 15, "Content for Lesson 3 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 15", "https://sadat.vip/" },
                    { 38, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 39, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 40, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 41, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 42, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 43, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 44, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 45, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 46, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 47, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 49, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 50, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 51, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 52, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 53, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 54, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 55, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 56, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLog_CourseTraineeId",
                table: "ActivityLog",
                column: "CourseTraineeId");

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
                name: "IX_Assessments_CourseId",
                table: "Assessments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLog");

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
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "RedeemCode");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
