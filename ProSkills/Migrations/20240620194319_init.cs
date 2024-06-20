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
                    { "1", 0, null, "76c260cf-7c0f-47b4-b832-fdfad9bf785b", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAECPW5C0nmzeNulmGyR9HW2SfQjtJZmb7GNeBusmRrjA4AUICNYP/fBKpGi721iOuog==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "06bc232d-4ef8-46f3-8931-3e87972489d3", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAEKB/8+R4y0MJch7//QOL69fPnIIAIXmRASeLGlPMyMblKuTXhMoZ8Q7E4hiOFtSnyQ==", "01050403037", null, false, null, "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "2698f28f-71a0-4c20-b3a6-d1c1ef9e0838", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEMmduxDoXzADMKHkAvVPuYabP6Dcu2/pOlXVUWGQHlFqKj5c5SqKE+rec+rvXxQ/Lg==", "01033901616", null, false, null, "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "20/06/2024 10:43:19 pm", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "20/06/2024 10:43:19 pm", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "20/06/2024 10:43:19 pm", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "20/06/2024 10:43:19 pm", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "20/06/2024 10:43:19 pm", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "20/06/2024 10:43:19 pm", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "20/06/2024 10:43:19 pm", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "20/06/2024 10:43:19 pm", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "20/06/2024 10:43:19 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "20/06/2024 10:43:19 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "20/06/2024 10:43:19 pm", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "20/06/2024 10:43:19 pm", "Trainee1@example.com", false, "Trainee 1", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "20/06/2024 10:43:19 pm", "Trainee2@example.com", false, "Trainee 2", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "20/06/2024 10:43:19 pm", "Trainee3@example.com", false, "Trainee 3", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "20/06/2024 10:43:19 pm", "Trainee4@example.com", false, "Trainee 4", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "20/06/2024 10:43:19 pm", "Trainee5@example.com", false, "Trainee 5", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "20/06/2024 10:43:19 pm", "Trainee6@example.com", false, "Trainee 6", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "20/06/2024 10:43:19 pm", "Trainee7@example.com", false, "Trainee 7", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "20/06/2024 10:43:19 pm", "Trainee8@example.com", false, "Trainee 8", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "20/06/2024 10:43:19 pm", "Trainee9@example.com", false, "Trainee 9", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "20/06/2024 10:43:19 pm", "Trainee10@example.com", false, "Trainee 10", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "20/06/2024 10:43:19 pm", "Trainee11@example.com", false, "Trainee 11", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "20/06/2024 10:43:19 pm", "Trainee12@example.com", false, "Trainee 12", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "20/06/2024 10:43:19 pm", "Trainee13@example.com", false, "Trainee 13", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "20/06/2024 10:43:19 pm", "Trainee14@example.com", false, "Trainee 14", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "20/06/2024 10:43:19 pm", "Trainee15@example.com", false, "Trainee 15", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "20/06/2024 10:43:19 pm", "Trainee16@example.com", false, "Trainee 16", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "20/06/2024 10:43:19 pm", "Trainee17@example.com", false, "Trainee 17", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "20/06/2024 10:43:19 pm", "Trainee18@example.com", false, "Trainee 18", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "20/06/2024 10:43:19 pm", "Trainee19@example.com", false, "Trainee 19", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "20/06/2024 10:43:19 pm", "Trainee20@example.com", false, "Trainee 20", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "20/06/2024 10:43:19 pm", "Trainee21@example.com", false, "Trainee 21", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "20/06/2024 10:43:19 pm", "Trainee22@example.com", false, "Trainee 22", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "20/06/2024 10:43:19 pm", "Trainee23@example.com", false, "Trainee 23", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "20/06/2024 10:43:19 pm", "Trainee24@example.com", false, "Trainee 24", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "20/06/2024 10:43:19 pm", "Trainee25@example.com", false, "Trainee 25", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "20/06/2024 10:43:19 pm", "Trainee26@example.com", false, "Trainee 26", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "20/06/2024 10:43:19 pm", "Trainee27@example.com", false, "Trainee 27", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "20/06/2024 10:43:19 pm", "Trainee28@example.com", false, "Trainee 28", null, "/themefront/img/user.jpg" },
                    { 29, "Bio for Trainee 29", null, "20/06/2024 10:43:19 pm", "Trainee29@example.com", false, "Trainee 29", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "20/06/2024 10:43:19 pm", "Trainee30@example.com", false, "Trainee 30", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "20/06/2024 10:43:19 pm", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "20/06/2024 10:43:19 pm", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "20/06/2024 10:43:19 pm", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "20/06/2024 10:43:19 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "20/06/2024 10:43:19 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "20/06/2024 10:43:19 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "20/06/2024 10:43:19 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "20/06/2024 10:43:19 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "20/06/2024 10:43:19 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "20/06/2024 10:43:19 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "20/06/2024 10:43:19 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "20/06/2024 10:43:19 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "20/06/2024 10:43:19 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "20/06/2024 10:43:19 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "20/06/2024 10:43:19 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "20/06/2024 10:43:19 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "20/06/2024 10:43:19 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "20/06/2024 10:43:19 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "20/06/2024 10:43:19 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "20/06/2024 10:43:19 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "20/06/2024 10:43:19 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "20/06/2024 10:43:19 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "20/06/2024 10:43:19 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "20/06/2024 10:43:19 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "20/06/2024 10:43:19 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "20/06/2024 10:43:19 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "20/06/2024 10:43:19 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "20/06/2024 10:43:19 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "20/06/2024 10:43:19 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "20/06/2024 10:43:19 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "20/06/2024 10:43:19 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "20/06/2024 10:43:19 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "20/06/2024 10:43:19 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
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
                columns: new[] { "Id", "CategoryId", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, 1, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Structural Revit", new DateTime(2024, 7, 20, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5750), 40, false, "Online", "Structural Revit", 5, 20, 25, null, new DateTime(2024, 6, 27, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5746), 10.5, 5 },
                    { 2, 1, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Arch Revit", new DateTime(2024, 8, 4, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5890), 60, false, "Online", "Arch Revit", 7, 25, 30, null, new DateTime(2024, 7, 4, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5887), 15.199999999999999, 14 },
                    { 3, 1, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn MEP Revit", new DateTime(2024, 7, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5904), 45, false, "Online", "MEP Revit", 6, 22, 20, null, new DateTime(2024, 6, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5902), 11.699999999999999, 3 },
                    { 4, 2, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Structural AutoCAD", new DateTime(2024, 8, 19, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5916), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, null, new DateTime(2024, 6, 30, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5914), 13.5, 14 },
                    { 5, 2, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Arch AutoCAD", new DateTime(2024, 7, 30, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5926), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, null, new DateTime(2024, 6, 27, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5925), 14.1, 8 },
                    { 6, 2, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn MEP AutoCAD", new DateTime(2024, 8, 9, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5941), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, null, new DateTime(2024, 7, 2, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5940), 12.300000000000001, 14 },
                    { 7, 2, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn 3D AutoCAD", new DateTime(2024, 8, 14, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5953), 50, false, "Online", "3D AutoCAD", 6, 23, 20, null, new DateTime(2024, 6, 28, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5951), 12.800000000000001, 13 },
                    { 8, 3, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Tekla", new DateTime(2024, 7, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5963), 45, false, "Online", "Tekla", 6, 22, 30, null, new DateTime(2024, 6, 26, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5962), 13.199999999999999, 9 },
                    { 9, 3, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn SketchUP", new DateTime(2024, 7, 30, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5973), 40, false, "Online", "SketchUP", 5, 20, 25, null, new DateTime(2024, 6, 29, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(5972), 10.800000000000001, 14 },
                    { 10, 4, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn SAP 2000", new DateTime(2024, 8, 4, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6015), 50, false, "Online", "SAP 2000", 6, 22, 20, null, new DateTime(2024, 7, 1, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6014), 12.199999999999999, 1 },
                    { 11, 4, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn STAAD Pro", new DateTime(2024, 8, 9, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6028), 55, false, "Online", "STAAD Pro", 6, 24, 25, null, new DateTime(2024, 7, 3, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6026), 13.5, 12 },
                    { 12, 5, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn CIVIL 3D", new DateTime(2024, 7, 30, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6039), 45, false, "Online", "CIVIL 3D", 6, 22, 30, null, new DateTime(2024, 6, 30, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6037), 13.1, 6 },
                    { 13, 4, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn ETABS", new DateTime(2024, 7, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6052), 40, false, "Online", "ETABS", 5, 20, 25, null, new DateTime(2024, 6, 28, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6050), 10.6, 10 },
                    { 14, 4, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn SAFE", new DateTime(2024, 7, 20, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6065), 35, false, "Online", "SAFE", 5, 18, 20, null, new DateTime(2024, 6, 27, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6063), 11.199999999999999, 2 },
                    { 15, 6, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Primavera P6", new DateTime(2024, 8, 4, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6076), 60, false, "Online", "Primavera P6", 7, 25, 30, null, new DateTime(2024, 7, 4, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6074), 15.800000000000001, 1 },
                    { 16, 6, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Microsoft Project", new DateTime(2024, 7, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6088), 45, false, "Online", "Microsoft Project", 6, 22, 25, null, new DateTime(2024, 6, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6086), 12.5, 13 },
                    { 17, 3, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Navisworks", new DateTime(2024, 8, 9, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6098), 55, false, "Online", "Navisworks", 6, 24, 30, null, new DateTime(2024, 7, 2, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6097), 13.800000000000001, 13 },
                    { 18, 7, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Advanced Revit Structure", new DateTime(2024, 8, 14, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6111), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, null, new DateTime(2024, 6, 28, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6109), 12.300000000000001, 13 },
                    { 19, 7, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 25, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6121), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, null, new DateTime(2024, 6, 26, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6119), 13.699999999999999, 4 },
                    { 20, 7, "path/to/course/image.jpg", "20/06/2024 10:43:19 pm", "Learn Advanced Revit MEP", new DateTime(2024, 7, 20, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6131), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, null, new DateTime(2024, 6, 27, 22, 43, 19, 313, DateTimeKind.Local).AddTicks(6129), 11.4, 5 }
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
                    { 9, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 10, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 11, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 12, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 13, 6, "Description for Chapter 3 in Course 6", false, "Chapter 3 for Course 6", "https://sadat.vip/" },
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
                    { 1, 1, 0, 970, 56.3619440534801m, 1 },
                    { 2, 1, 0, 730, 74.5838541316384m, 2 },
                    { 3, 1, 0, 780, 90.76107587728m, 3 },
                    { 4, 1, 0, 650, 69.9925753601289m, 4 },
                    { 5, 1, 0, 820, 14.7815402697657m, 5 },
                    { 6, 1, 0, 130, 72.4992506639215m, 6 },
                    { 7, 1, 0, 480, 29.5317408463615m, 7 },
                    { 8, 1, 0, 170, 85.6809748596824m, 8 },
                    { 9, 1, 0, 200, 92.4820229380203m, 9 },
                    { 10, 1, 0, 640, 42.6266263738974m, 10 },
                    { 11, 1, 0, 940, 81.8314381202725m, 11 },
                    { 12, 1, 0, 840, 35.4100245750026m, 12 },
                    { 13, 1, 0, 950, 63.7242524420217m, 13 },
                    { 14, 1, 0, 700, 66.6449777899537m, 14 },
                    { 15, 1, 0, 410, 92.1590459762045m, 15 },
                    { 16, 1, 0, 40, 30.9251020328395m, 16 },
                    { 17, 1, 0, 140, 36.7783516695366m, 17 },
                    { 18, 1, 0, 130, 85.9263657654823m, 18 },
                    { 19, 1, 0, 640, 83.1664872787329m, 19 },
                    { 20, 1, 0, 350, 95.4175779864105m, 20 },
                    { 21, 2, 0, 850, 15.3709161482988m, 21 },
                    { 22, 2, 0, 810, 46.8419096519638m, 22 },
                    { 23, 2, 0, 30, 33.0387387293947m, 23 },
                    { 24, 2, 0, 430, 69.2715534669016m, 24 },
                    { 25, 2, 0, 850, 89.7544174659458m, 25 },
                    { 26, 2, 0, 820, 59.1210803904001m, 26 },
                    { 27, 2, 0, 550, 3.5116770995271m, 27 },
                    { 28, 2, 0, 270, 90.5188342012968m, 28 },
                    { 29, 2, 0, 790, 93.8124487594261m, 29 },
                    { 30, 2, 0, 820, 41.8370743974868m, 30 },
                    { 31, 3, 0, 240, 59.2879654675054m, 1 },
                    { 32, 3, 0, 650, 63.1912846932743m, 2 },
                    { 33, 3, 0, 970, 46.0182379895642m, 3 },
                    { 34, 3, 0, 100, 62.9030170651748m, 4 },
                    { 35, 3, 0, 550, 62.0816595644745m, 5 },
                    { 36, 4, 0, 640, 24.2827291746695m, 6 },
                    { 37, 4, 0, 780, 99.8672308711326m, 7 },
                    { 38, 4, 0, 720, 19.8275047084155m, 8 },
                    { 39, 4, 0, 740, 87.6098451472191m, 9 },
                    { 40, 4, 0, 570, 48.623523075551m, 10 },
                    { 41, 5, 0, 890, 37.5478210677384m, 11 },
                    { 42, 5, 0, 170, 96.0525442514038m, 12 },
                    { 43, 5, 0, 770, 25.3073501384873m, 13 },
                    { 44, 5, 0, 560, 83.5025519033627m, 14 },
                    { 45, 5, 0, 220, 86.3472304535811m, 15 },
                    { 46, 6, 0, 720, 5.80443520944164m, 16 },
                    { 47, 6, 0, 310, 43.8331113078428m, 17 },
                    { 48, 6, 0, 500, 45.5149144792964m, 18 },
                    { 49, 6, 0, 460, 26.0358847042267m, 19 },
                    { 50, 7, 0, 60, 5.99805107944679m, 20 },
                    { 51, 7, 0, 930, 89.9195092263958m, 21 },
                    { 52, 7, 0, 70, 21.133981142674m, 22 },
                    { 53, 8, 0, 740, 61.8313386467766m, 23 },
                    { 54, 8, 0, 120, 89.1790307774918m, 24 },
                    { 55, 8, 0, 640, 47.8534990426394m, 25 },
                    { 56, 9, 0, 710, 35.5062367287858m, 26 },
                    { 57, 9, 0, 950, 45.3614170473409m, 27 },
                    { 58, 9, 0, 80, 15.3066701659896m, 28 },
                    { 59, 9, 0, 820, 69.9074836225852m, 29 },
                    { 60, 10, 0, 480, 43.7637246179524m, 30 },
                    { 61, 11, 0, 340, 16.6290610386038m, 1 },
                    { 62, 11, 0, 980, 21.0052313699667m, 2 },
                    { 63, 11, 0, 410, 18.7000685252455m, 3 },
                    { 64, 12, 0, 820, 39.31035120677m, 4 },
                    { 65, 12, 0, 390, 96.8251035054002m, 5 },
                    { 66, 12, 0, 770, 20.0090618661598m, 6 },
                    { 67, 13, 0, 130, 85.360360675921m, 7 },
                    { 68, 13, 0, 510, 96.7725282086994m, 8 },
                    { 69, 13, 0, 560, 96.3395353172447m, 9 },
                    { 70, 14, 0, 970, 4.81814395058602m, 10 },
                    { 71, 14, 0, 290, 38.139800618184m, 11 },
                    { 72, 14, 0, 630, 71.2187531528209m, 12 },
                    { 73, 15, 0, 50, 43.8938789648827m, 13 },
                    { 74, 15, 0, 990, 95.7675211700183m, 14 },
                    { 75, 15, 0, 420, 64.7630606674571m, 15 },
                    { 76, 15, 0, 540, 35.5130681609967m, 16 },
                    { 77, 16, 0, 360, 76.8792192197026m, 17 },
                    { 78, 16, 0, 510, 71.0894215493524m, 18 },
                    { 79, 16, 0, 90, 50.8551809301672m, 19 },
                    { 80, 16, 0, 870, 74.207655228555m, 20 },
                    { 81, 16, 0, 960, 91.8740231259811m, 21 },
                    { 82, 17, 0, 670, 31.2499320616918m, 22 },
                    { 83, 17, 0, 440, 99.2517257426004m, 23 },
                    { 84, 17, 0, 120, 22.141116354214m, 24 },
                    { 85, 17, 0, 130, 68.9414014759347m, 25 },
                    { 86, 17, 0, 560, 61.9333274633359m, 26 },
                    { 87, 17, 0, 40, 56.6998464708072m, 27 },
                    { 88, 17, 0, 370, 65.7236109547787m, 28 },
                    { 89, 17, 0, 60, 9.78977513674288m, 29 },
                    { 90, 18, 0, 410, 3.92559335670529m, 30 },
                    { 91, 18, 0, 980, 90.2927622184034m, 31 },
                    { 92, 18, 0, 260, 14.6713409720158m, 32 },
                    { 93, 19, 0, 560, 99.6515546848448m, 33 },
                    { 94, 19, 0, 270, 61.9785061446238m, 1 },
                    { 95, 19, 0, 400, 48.427513539802m, 2 },
                    { 96, 19, 0, 570, 75.3248637876814m, 3 },
                    { 97, 20, 0, 720, 38.1837429651533m, 4 },
                    { 98, 20, 0, 410, 2.91478177264624m, 5 },
                    { 99, 20, 0, 680, 28.6789322305566m, 6 },
                    { 100, 20, 0, 320, 16.960593857099m, 7 },
                    { 101, 1, 0, 40, 49.9105019586464m, 31 },
                    { 102, 1, 0, 400, 57.6086745639305m, 32 },
                    { 103, 1, 0, 670, 51.1046186096856m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 3 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 3 for Chapter 3", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 16, 6, "Content for Lesson 3 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 6", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 19, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 20, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 21, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 22, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 23, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 24, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 26, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 28, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 29, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 31, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 32, 12, "Content for Lesson 3 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 12", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 34, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 35, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 36, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 37, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 38, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 39, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 40, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 41, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 42, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 43, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 44, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 45, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 46, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 47, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 48, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 49, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 50, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 51, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 52, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 53, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 54, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 55, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 56, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 57, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 59, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" }
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
