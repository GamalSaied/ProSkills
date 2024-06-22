using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class rio : Migration
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
                    { "1", 0, null, "eff51bda-1527-4440-b504-84c2ff533c4e", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEFfzqTzFpF9epdxO0EYSpIWYENaPksdOnNjfgOmfC/qeZ6pBvPijLxWBqxofgDIC9A==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "7daae6a4-8ab1-4704-8f9d-93768d2fbbe8", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAEDnsvClrkTDKl76maaKnFHkaNiQZvvCeiHvX6AWq5dXh/AwYO2CwNo6pDaVjagb31A==", "01050403037", null, false, null, "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "a28d341e-5566-4cb7-9d21-9aa67a5add07", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEKOkYm5AxkL5R95jAiglF+HCE1y1nRbf9QnADhfXogjd/blN6i/ZnGT/gtX92wrkLw==", "01033901616", null, false, null, "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "22/06/2024 03:01:54 ص", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "22/06/2024 03:01:54 ص", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "22/06/2024 03:01:54 ص", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "22/06/2024 03:01:54 ص", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "22/06/2024 03:01:54 ص", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "22/06/2024 03:01:54 ص", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "22/06/2024 03:01:54 ص", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "22/06/2024 03:01:54 ص", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "22/06/2024 03:01:54 ص", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "22/06/2024 03:01:54 ص", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "22/06/2024 03:01:54 ص", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "22/06/2024 03:01:53 ص", "Trainee1@example.com", false, "Trainee 1", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "22/06/2024 03:01:53 ص", "Trainee2@example.com", false, "Trainee 2", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "22/06/2024 03:01:53 ص", "Trainee3@example.com", false, "Trainee 3", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "22/06/2024 03:01:53 ص", "Trainee4@example.com", false, "Trainee 4", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "22/06/2024 03:01:53 ص", "Trainee5@example.com", false, "Trainee 5", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "22/06/2024 03:01:53 ص", "Trainee6@example.com", false, "Trainee 6", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "22/06/2024 03:01:53 ص", "Trainee7@example.com", false, "Trainee 7", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "22/06/2024 03:01:53 ص", "Trainee8@example.com", false, "Trainee 8", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "22/06/2024 03:01:53 ص", "Trainee9@example.com", false, "Trainee 9", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "22/06/2024 03:01:53 ص", "Trainee10@example.com", false, "Trainee 10", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "22/06/2024 03:01:53 ص", "Trainee11@example.com", false, "Trainee 11", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "22/06/2024 03:01:53 ص", "Trainee12@example.com", false, "Trainee 12", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "22/06/2024 03:01:53 ص", "Trainee13@example.com", false, "Trainee 13", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "22/06/2024 03:01:53 ص", "Trainee14@example.com", false, "Trainee 14", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "22/06/2024 03:01:53 ص", "Trainee15@example.com", false, "Trainee 15", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "22/06/2024 03:01:53 ص", "Trainee16@example.com", false, "Trainee 16", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "22/06/2024 03:01:53 ص", "Trainee17@example.com", false, "Trainee 17", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "22/06/2024 03:01:53 ص", "Trainee18@example.com", false, "Trainee 18", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "22/06/2024 03:01:53 ص", "Trainee19@example.com", false, "Trainee 19", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "22/06/2024 03:01:53 ص", "Trainee20@example.com", false, "Trainee 20", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "22/06/2024 03:01:53 ص", "Trainee21@example.com", false, "Trainee 21", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "22/06/2024 03:01:53 ص", "Trainee22@example.com", false, "Trainee 22", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "22/06/2024 03:01:53 ص", "Trainee23@example.com", false, "Trainee 23", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "22/06/2024 03:01:53 ص", "Trainee24@example.com", false, "Trainee 24", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "22/06/2024 03:01:53 ص", "Trainee25@example.com", false, "Trainee 25", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "22/06/2024 03:01:53 ص", "Trainee26@example.com", false, "Trainee 26", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "22/06/2024 03:01:53 ص", "Trainee27@example.com", false, "Trainee 27", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "22/06/2024 03:01:53 ص", "Trainee28@example.com", false, "Trainee 28", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "22/06/2024 03:01:53 ص", "Trainee30@example.com", false, "Trainee 30", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "22/06/2024 03:01:54 ص", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "22/06/2024 03:01:54 ص", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "22/06/2024 03:01:54 ص", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "22/06/2024 03:01:53 ص", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "22/06/2024 03:01:53 ص", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "22/06/2024 03:01:53 ص", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "22/06/2024 03:01:53 ص", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "22/06/2024 03:01:53 ص", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "22/06/2024 03:01:53 ص", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "22/06/2024 03:01:53 ص", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "22/06/2024 03:01:53 ص", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "22/06/2024 03:01:53 ص", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "22/06/2024 03:01:53 ص", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "22/06/2024 03:01:53 ص", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "22/06/2024 03:01:53 ص", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "22/06/2024 03:01:53 ص", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "22/06/2024 03:01:53 ص", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "22/06/2024 03:01:53 ص", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "22/06/2024 03:01:53 ص", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "22/06/2024 03:01:53 ص", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "22/06/2024 03:01:53 ص", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "22/06/2024 03:01:53 ص", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "22/06/2024 03:01:53 ص", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "22/06/2024 03:01:53 ص", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "22/06/2024 03:01:53 ص", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "22/06/2024 03:01:53 ص", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "22/06/2024 03:01:53 ص", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "22/06/2024 03:01:53 ص", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "22/06/2024 03:01:53 ص", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "22/06/2024 03:01:53 ص", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "22/06/2024 03:01:53 ص", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "22/06/2024 03:01:53 ص", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "22/06/2024 03:01:53 ص", "instructor30@example.com", false, "Instructor 30", "password30", null }
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
                    { 1, 1, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Structural Revit", new DateTime(2024, 7, 22, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4285), 40, false, "Online", "Structural Revit", 5, 20, 25, null, new DateTime(2024, 6, 29, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4273), 10.5, 10 },
                    { 2, 1, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Arch Revit", new DateTime(2024, 8, 6, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4411), 60, false, "Online", "Arch Revit", 7, 25, 30, null, new DateTime(2024, 7, 6, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4407), 15.199999999999999, 5 },
                    { 3, 1, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn MEP Revit", new DateTime(2024, 7, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4470), 45, false, "Online", "MEP Revit", 6, 22, 20, null, new DateTime(2024, 6, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4468), 11.699999999999999, 14 },
                    { 4, 2, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Structural AutoCAD", new DateTime(2024, 8, 21, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4488), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, null, new DateTime(2024, 7, 2, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4486), 13.5, 14 },
                    { 5, 2, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Arch AutoCAD", new DateTime(2024, 8, 1, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4512), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, null, new DateTime(2024, 6, 29, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4509), 14.1, 1 },
                    { 6, 2, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn MEP AutoCAD", new DateTime(2024, 8, 11, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4541), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, null, new DateTime(2024, 7, 4, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4539), 12.300000000000001, 4 },
                    { 7, 2, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn 3D AutoCAD", new DateTime(2024, 8, 16, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4580), 50, false, "Online", "3D AutoCAD", 6, 23, 20, null, new DateTime(2024, 6, 30, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4564), 12.800000000000001, 9 },
                    { 8, 3, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Tekla", new DateTime(2024, 7, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4700), 45, false, "Online", "Tekla", 6, 22, 30, null, new DateTime(2024, 6, 28, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4697), 13.199999999999999, 1 },
                    { 9, 3, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn SketchUP", new DateTime(2024, 8, 1, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4716), 40, false, "Online", "SketchUP", 5, 20, 25, null, new DateTime(2024, 7, 1, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4713), 10.800000000000001, 10 },
                    { 10, 4, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn SAP 2000", new DateTime(2024, 8, 6, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4733), 50, false, "Online", "SAP 2000", 6, 22, 20, null, new DateTime(2024, 7, 3, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4730), 12.199999999999999, 6 },
                    { 11, 4, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn STAAD Pro", new DateTime(2024, 8, 11, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4754), 55, false, "Online", "STAAD Pro", 6, 24, 25, null, new DateTime(2024, 7, 5, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4750), 13.5, 4 },
                    { 12, 5, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn CIVIL 3D", new DateTime(2024, 8, 1, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4772), 45, false, "Online", "CIVIL 3D", 6, 22, 30, null, new DateTime(2024, 7, 2, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4769), 13.1, 1 },
                    { 13, 4, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn ETABS", new DateTime(2024, 7, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4791), 40, false, "Online", "ETABS", 5, 20, 25, null, new DateTime(2024, 6, 30, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4788), 10.6, 8 },
                    { 14, 4, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn SAFE", new DateTime(2024, 7, 22, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4819), 35, false, "Online", "SAFE", 5, 18, 20, null, new DateTime(2024, 6, 29, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4816), 11.199999999999999, 14 },
                    { 15, 6, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Primavera P6", new DateTime(2024, 8, 6, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4846), 60, false, "Online", "Primavera P6", 7, 25, 30, null, new DateTime(2024, 7, 6, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4843), 15.800000000000001, 1 },
                    { 16, 6, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Microsoft Project", new DateTime(2024, 7, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4870), 45, false, "Online", "Microsoft Project", 6, 22, 25, null, new DateTime(2024, 6, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4867), 12.5, 15 },
                    { 17, 3, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Navisworks", new DateTime(2024, 8, 11, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4885), 55, false, "Online", "Navisworks", 6, 24, 30, null, new DateTime(2024, 7, 4, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4883), 13.800000000000001, 8 },
                    { 18, 7, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Advanced Revit Structure", new DateTime(2024, 8, 16, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4902), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, null, new DateTime(2024, 6, 30, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4899), 12.300000000000001, 8 },
                    { 19, 7, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 27, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4922), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, null, new DateTime(2024, 6, 28, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4920), 13.699999999999999, 7 },
                    { 20, 7, "path/to/course/image.jpg", "22/06/2024 03:01:54 ص", "Learn Advanced Revit MEP", new DateTime(2024, 7, 22, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4939), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, null, new DateTime(2024, 6, 29, 3, 1, 54, 69, DateTimeKind.Local).AddTicks(4936), 11.4, 14 }
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
                    { 7, 3, "Description for Chapter 3 in Course 3", false, "Chapter 3 for Course 3", "https://sadat.vip/" },
                    { 8, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 9, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 10, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 11, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 13, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 14, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 15, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 16, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
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
                    { 1, 1, 0, 270, 9.30865817808668m, 1 },
                    { 2, 1, 0, 130, 17.739730785144m, 2 },
                    { 3, 1, 0, 770, 85.102802416939m, 3 },
                    { 4, 1, 0, 940, 3.06165927533456m, 4 },
                    { 5, 1, 0, 220, 99.5339919636359m, 5 },
                    { 6, 1, 0, 540, 76.7476066782086m, 6 },
                    { 7, 1, 0, 850, 6.03443290707989m, 7 },
                    { 8, 1, 0, 100, 6.59941413952639m, 8 },
                    { 9, 1, 0, 290, 11.9150061004565m, 9 },
                    { 10, 1, 0, 570, 26.1446903904745m, 10 },
                    { 11, 1, 0, 240, 97.7364110063341m, 11 },
                    { 12, 1, 0, 310, 60.5431719815848m, 12 },
                    { 13, 1, 0, 220, 39.1560592178947m, 13 },
                    { 14, 1, 0, 20, 73.1807602490343m, 14 },
                    { 15, 15, 0, 870, 14.2348197794775m, 15 },
                    { 16, 16, 0, 720, 76.185503359607m, 16 },
                    { 17, 17, 0, 300, 17.1621914336307m, 17 },
                    { 18, 18, 0, 900, 91.2107106408202m, 18 },
                    { 19, 19, 0, 470, 57.1550086735166m, 19 },
                    { 20, 20, 0, 870, 24.7310161896566m, 20 },
                    { 21, 1, 0, 580, 17.6209789782645m, 21 },
                    { 22, 2, 0, 940, 84.801667661105m, 22 },
                    { 23, 3, 0, 620, 85.0538286057158m, 23 },
                    { 24, 4, 0, 440, 29.3299538996148m, 24 },
                    { 25, 5, 0, 650, 86.1035436081959m, 25 },
                    { 26, 6, 0, 870, 91.5362773484366m, 26 },
                    { 27, 7, 0, 540, 22.3788363155125m, 27 },
                    { 28, 8, 0, 770, 0.0805992845884229m, 28 },
                    { 29, 9, 0, 70, 40.7481164560266m, 29 },
                    { 30, 10, 0, 890, 96.9059361211294m, 30 },
                    { 31, 11, 0, 260, 33.372855160111m, 1 },
                    { 32, 12, 0, 530, 78.1806567965784m, 2 },
                    { 33, 13, 0, 590, 5.91906147982253m, 3 },
                    { 34, 14, 0, 480, 48.2759136282374m, 4 },
                    { 35, 15, 0, 930, 92.8836319015397m, 5 },
                    { 36, 16, 0, 620, 83.5890429420427m, 6 },
                    { 37, 17, 0, 680, 97.0321074222096m, 7 },
                    { 38, 18, 0, 390, 83.2392562779231m, 8 },
                    { 39, 19, 0, 480, 3.92695114870412m, 9 },
                    { 40, 20, 0, 190, 4.6862148644857m, 10 },
                    { 41, 1, 0, 320, 71.6774210113957m, 11 },
                    { 42, 2, 0, 410, 1.34574679641515m, 12 },
                    { 43, 3, 0, 700, 46.058847650044m, 13 },
                    { 44, 4, 0, 860, 11.3646903645473m, 14 },
                    { 45, 5, 0, 0, 80.8507209206009m, 15 },
                    { 46, 6, 0, 330, 83.4842452199881m, 16 },
                    { 47, 7, 0, 340, 85.3718572627904m, 17 },
                    { 48, 8, 0, 1000, 25.0075030433436m, 18 },
                    { 49, 9, 0, 650, 13.7764399747591m, 19 },
                    { 50, 10, 0, 870, 59.744253789164m, 20 },
                    { 51, 11, 0, 810, 10.9299331735802m, 21 },
                    { 52, 12, 0, 200, 24.1249227892029m, 22 },
                    { 53, 13, 0, 10, 86.6242473147494m, 23 },
                    { 54, 14, 0, 490, 66.1836879984223m, 24 },
                    { 55, 15, 0, 880, 28.8030284222052m, 25 },
                    { 56, 16, 0, 740, 87.3437567033556m, 26 },
                    { 57, 17, 0, 160, 73.4850927238316m, 27 },
                    { 58, 18, 0, 950, 10.537106907004m, 28 },
                    { 59, 19, 0, 820, 75.0268533111862m, 29 },
                    { 60, 20, 0, 30, 43.4397866107795m, 30 },
                    { 61, 1, 0, 190, 2.35966109972522m, 1 },
                    { 62, 2, 0, 10, 77.5959612850443m, 2 },
                    { 63, 3, 0, 970, 74.4560927775987m, 3 },
                    { 64, 4, 0, 680, 12.6069428286471m, 4 },
                    { 65, 5, 0, 380, 35.8889747011323m, 5 },
                    { 66, 6, 0, 490, 16.4637892169333m, 6 },
                    { 67, 7, 0, 30, 70.3421071138868m, 7 },
                    { 68, 8, 0, 960, 93.2026736574059m, 8 },
                    { 69, 9, 0, 720, 90.3280672890374m, 9 },
                    { 70, 10, 0, 870, 19.4205032654763m, 10 },
                    { 71, 11, 0, 520, 31.3396152686348m, 11 },
                    { 72, 12, 0, 780, 92.7894744996627m, 12 },
                    { 73, 13, 0, 730, 87.2252195596801m, 13 },
                    { 74, 14, 0, 960, 11.3872186311704m, 14 },
                    { 75, 15, 0, 680, 94.6244398250413m, 15 },
                    { 76, 16, 0, 330, 26.5170690290742m, 16 },
                    { 77, 17, 0, 350, 70.7220232299265m, 17 },
                    { 78, 18, 0, 740, 92.715958837168m, 18 },
                    { 79, 19, 0, 750, 37.0674935449258m, 19 },
                    { 80, 20, 0, 880, 88.2174528705444m, 20 },
                    { 81, 1, 0, 920, 27.1442936363534m, 21 },
                    { 82, 2, 0, 560, 76.6247367793928m, 22 },
                    { 83, 3, 0, 380, 98.1474775812784m, 23 },
                    { 84, 4, 0, 240, 22.9083437044633m, 24 },
                    { 85, 5, 0, 770, 59.2349349139755m, 25 },
                    { 86, 6, 0, 830, 29.2925643190788m, 26 },
                    { 87, 7, 0, 460, 6.95075675018552m, 27 },
                    { 88, 8, 0, 640, 71.3173804016625m, 28 },
                    { 89, 9, 0, 310, 49.324217755315m, 29 },
                    { 90, 10, 0, 100, 21.0493652973935m, 30 },
                    { 91, 11, 0, 580, 0.315188012827505m, 31 },
                    { 92, 12, 0, 550, 12.5285707587931m, 32 },
                    { 93, 13, 0, 720, 15.5873082167199m, 33 },
                    { 94, 14, 0, 820, 15.2452363436467m, 1 },
                    { 95, 15, 0, 700, 19.9320892900603m, 2 },
                    { 96, 16, 0, 920, 16.1922790968771m, 3 },
                    { 97, 17, 0, 10, 12.3468276031005m, 4 },
                    { 98, 18, 0, 440, 35.4687516945992m, 5 },
                    { 99, 19, 0, 400, 36.1545014743861m, 6 },
                    { 100, 20, 0, 530, 7.74278748731545m, 7 },
                    { 101, 1, 0, 800, 17.8758565853093m, 31 },
                    { 102, 1, 0, 640, 93.0111785147826m, 32 },
                    { 103, 1, 0, 290, 48.2313547694795m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 3 for Chapter 1", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 3 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 3", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 11, 4, "Content for Lesson 3 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 3 for Chapter 4", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 18, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 20, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 21, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 22, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 23, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 24, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 25, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 27, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 28, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 29, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 30, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 32, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 33, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 34, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 35, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 36, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 37, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 38, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 39, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 40, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 41, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 42, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 43, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 44, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 45, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 46, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 47, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 48, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 49, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 50, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 51, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 52, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 53, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 54, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" }
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
