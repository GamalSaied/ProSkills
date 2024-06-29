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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assessments_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
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
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<int>(type: "int", nullable: false),
                    CompletionRatio = table.Column<double>(type: "float", nullable: false)
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
                name: "JoinRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TraineeId = table.Column<int>(type: "int", nullable: false),
                    PaymentProofPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JoinRequests_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_JoinRequests_Trainee_TraineeId",
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
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActivityType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CourseTraineeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityLogs_CourseTrainee_CourseTraineeId",
                        column: x => x.CourseTraineeId,
                        principalTable: "CourseTrainee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ActivityLogs_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
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
                    { "1", 0, null, "f1a81f27-82e2-4668-a81e-099fd25580a3", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEH5UQ2cT6f2S8VaF8xSZIidHqc9Ezu9R2qSBjg3P5QIEOTe//fUnt0FZ2UQImo9Zvg==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "5f033c83-a459-4f42-8870-2d940ec492e4", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAEFiogE6gxtTPo5d24qz5ai4Yui+J4ytEhA3bm0PIjunsBSSyWcnKnZkAq2sDpHV+Lg==", "01050403037", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "e1b95eea-f094-4fbb-bed3-407bd6054c2e", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEFfEfULaeD2HxEvpUZCWL8aFxxyee+mnbl+Zm2X8ArbBczexV08hwdyEJTttHLNsdQ==", "01033901616", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "25/06/2024 10:09:06 am", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "25/06/2024 10:09:06 am", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "25/06/2024 10:09:06 am", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "25/06/2024 10:09:06 am", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "25/06/2024 10:09:06 am", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "25/06/2024 10:09:06 am", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "25/06/2024 10:09:06 am", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "25/06/2024 10:09:06 am", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "25/06/2024 10:09:06 am", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "25/06/2024 10:09:06 am", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "25/06/2024 10:09:06 am", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "25/06/2024 10:09:06 am", "Trainee1@example.com", false, "Trainee 1 Name", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "25/06/2024 10:09:06 am", "Trainee2@example.com", false, "Trainee 2 Name", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "25/06/2024 10:09:06 am", "Trainee3@example.com", false, "Trainee 3 Name", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "25/06/2024 10:09:06 am", "Trainee4@example.com", false, "Trainee 4 Name", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "25/06/2024 10:09:06 am", "Trainee5@example.com", false, "Trainee 5 Name", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "25/06/2024 10:09:06 am", "Trainee6@example.com", false, "Trainee 6 Name", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "25/06/2024 10:09:06 am", "Trainee7@example.com", false, "Trainee 7 Name", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "25/06/2024 10:09:06 am", "Trainee8@example.com", false, "Trainee 8 Name", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "25/06/2024 10:09:06 am", "Trainee9@example.com", false, "Trainee 9 Name", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "25/06/2024 10:09:06 am", "Trainee10@example.com", false, "Trainee 10 Name", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "25/06/2024 10:09:06 am", "Trainee11@example.com", false, "Trainee 11 Name", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "25/06/2024 10:09:06 am", "Trainee12@example.com", false, "Trainee 12 Name", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "25/06/2024 10:09:06 am", "Trainee13@example.com", false, "Trainee 13 Name", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "25/06/2024 10:09:06 am", "Trainee14@example.com", false, "Trainee 14 Name", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "25/06/2024 10:09:06 am", "Trainee15@example.com", false, "Trainee 15 Name", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "25/06/2024 10:09:06 am", "Trainee16@example.com", false, "Trainee 16 Name", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "25/06/2024 10:09:06 am", "Trainee17@example.com", false, "Trainee 17 Name", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "25/06/2024 10:09:06 am", "Trainee18@example.com", false, "Trainee 18 Name", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "25/06/2024 10:09:06 am", "Trainee19@example.com", false, "Trainee 19 Name", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "25/06/2024 10:09:06 am", "Trainee20@example.com", false, "Trainee 20 Name", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "25/06/2024 10:09:06 am", "Trainee21@example.com", false, "Trainee 21 Name", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "25/06/2024 10:09:06 am", "Trainee22@example.com", false, "Trainee 22 Name", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "25/06/2024 10:09:06 am", "Trainee23@example.com", false, "Trainee 23 Name", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "25/06/2024 10:09:06 am", "Trainee24@example.com", false, "Trainee 24 Name", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "25/06/2024 10:09:06 am", "Trainee25@example.com", false, "Trainee 25 Name", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "25/06/2024 10:09:06 am", "Trainee26@example.com", false, "Trainee 26 Name", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "25/06/2024 10:09:06 am", "Trainee27@example.com", false, "Trainee 27 Name", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "25/06/2024 10:09:06 am", "Trainee28@example.com", false, "Trainee 28 Name", null, "/themefront/img/user.jpg" },
                    { 29, "Bio for Trainee 29", null, "25/06/2024 10:09:06 am", "Trainee29@example.com", false, "Trainee 29 Name", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "25/06/2024 10:09:06 am", "Trainee30@example.com", false, "Trainee 30 Name", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "25/06/2024 10:09:06 am", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "25/06/2024 10:09:06 am", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "25/06/2024 10:09:06 am", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "ImagePath", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "25/06/2024 10:09:06 am", "instructor1@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 1 Name", "password1", null },
                    { 2, "Bio for Instructor 2", "25/06/2024 10:09:06 am", "instructor2@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 2 Name", "password2", null },
                    { 3, "Bio for Instructor 3", "25/06/2024 10:09:06 am", "instructor3@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 3 Name", "password3", null },
                    { 4, "Bio for Instructor 4", "25/06/2024 10:09:06 am", "instructor4@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 4 Name", "password4", null },
                    { 5, "Bio for Instructor 5", "25/06/2024 10:09:06 am", "instructor5@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 5 Name", "password5", null },
                    { 6, "Bio for Instructor 6", "25/06/2024 10:09:06 am", "instructor6@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 6 Name", "password6", null },
                    { 7, "Bio for Instructor 7", "25/06/2024 10:09:06 am", "instructor7@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 7 Name", "password7", null },
                    { 8, "Bio for Instructor 8", "25/06/2024 10:09:06 am", "instructor8@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 8 Name", "password8", null },
                    { 9, "Bio for Instructor 9", "25/06/2024 10:09:06 am", "instructor9@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 9 Name", "password9", null },
                    { 10, "Bio for Instructor 10", "25/06/2024 10:09:06 am", "instructor10@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 10 Name", "password10", null },
                    { 11, "Bio for Instructor 11", "25/06/2024 10:09:06 am", "instructor11@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 11 Name", "password11", null },
                    { 12, "Bio for Instructor 12", "25/06/2024 10:09:06 am", "instructor12@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 12 Name", "password12", null },
                    { 13, "Bio for Instructor 13", "25/06/2024 10:09:06 am", "instructor13@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 13 Name", "password13", null },
                    { 14, "Bio for Instructor 14", "25/06/2024 10:09:06 am", "instructor14@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 14 Name", "password14", null },
                    { 15, "Bio for Instructor 15", "25/06/2024 10:09:06 am", "instructor15@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 15 Name", "password15", null },
                    { 16, "Bio for Instructor 16", "25/06/2024 10:09:06 am", "instructor16@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 16 Name", "password16", null },
                    { 17, "Bio for Instructor 17", "25/06/2024 10:09:06 am", "instructor17@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 17 Name", "password17", null },
                    { 18, "Bio for Instructor 18", "25/06/2024 10:09:06 am", "instructor18@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 18 Name", "password18", null },
                    { 19, "Bio for Instructor 19", "25/06/2024 10:09:06 am", "instructor19@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 19 Name", "password19", null },
                    { 20, "Bio for Instructor 20", "25/06/2024 10:09:06 am", "instructor20@example.com", "\\ThemeFront\\img\\User.jpg", false, "Instructor 20 Name", "password20", null }
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
                    { 1, 1, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Structural Revit", new DateTime(2024, 7, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2218), 40, false, "Online", "Structural Revit", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 7, 2, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2179), 10.5, 1 },
                    { 2, 1, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Arch Revit", new DateTime(2024, 8, 9, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2319), 60, false, "Online", "Arch Revit", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 7, 9, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2314), 15.199999999999999, 8 },
                    { 3, 1, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn MEP Revit", new DateTime(2024, 7, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2384), 45, false, "Online", "MEP Revit", 6, 22, 20, 0, 0, null, 0, new DateTime(2024, 6, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2378), 11.699999999999999, 1 },
                    { 4, 2, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Structural AutoCAD", new DateTime(2024, 8, 24, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2415), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, 0, 0, null, 0, new DateTime(2024, 7, 5, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2411), 13.5, 7 },
                    { 5, 2, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Arch AutoCAD", new DateTime(2024, 8, 4, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2445), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 7, 2, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2440), 14.1, 14 },
                    { 6, 2, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn MEP AutoCAD", new DateTime(2024, 8, 14, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2478), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, 0, 0, null, 0, new DateTime(2024, 7, 7, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2475), 12.300000000000001, 15 },
                    { 7, 2, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn 3D AutoCAD", new DateTime(2024, 8, 19, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2528), 50, false, "Online", "3D AutoCAD", 6, 23, 20, 0, 0, null, 0, new DateTime(2024, 7, 3, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2508), 12.800000000000001, 14 },
                    { 8, 3, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Tekla", new DateTime(2024, 7, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2596), 45, false, "Online", "Tekla", 6, 22, 30, 0, 0, null, 0, new DateTime(2024, 7, 1, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2592), 13.199999999999999, 5 },
                    { 9, 3, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn SketchUP", new DateTime(2024, 8, 4, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2701), 40, false, "Online", "SketchUP", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 7, 4, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2697), 10.800000000000001, 9 },
                    { 10, 4, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn SAP 2000", new DateTime(2024, 8, 9, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2724), 50, false, "Online", "SAP 2000", 6, 22, 20, 0, 0, null, 0, new DateTime(2024, 7, 6, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2721), 12.199999999999999, 13 },
                    { 11, 4, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn STAAD Pro", new DateTime(2024, 8, 14, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2750), 55, false, "Online", "STAAD Pro", 6, 24, 25, 0, 0, null, 0, new DateTime(2024, 7, 8, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2746), 13.5, 4 },
                    { 12, 5, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn CIVIL 3D", new DateTime(2024, 8, 4, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2772), 45, false, "Online", "CIVIL 3D", 6, 22, 30, 0, 0, null, 0, new DateTime(2024, 7, 5, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2768), 13.1, 14 },
                    { 13, 4, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn ETABS", new DateTime(2024, 7, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2790), 40, false, "Online", "ETABS", 5, 20, 25, 0, 0, null, 0, new DateTime(2024, 7, 3, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2787), 10.6, 1 },
                    { 14, 4, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn SAFE", new DateTime(2024, 7, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2816), 35, false, "Online", "SAFE", 5, 18, 20, 0, 0, null, 0, new DateTime(2024, 7, 2, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2812), 11.199999999999999, 15 },
                    { 15, 6, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Primavera P6", new DateTime(2024, 8, 9, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2843), 60, false, "Online", "Primavera P6", 7, 25, 30, 0, 0, null, 0, new DateTime(2024, 7, 9, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2839), 15.800000000000001, 12 },
                    { 16, 6, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Microsoft Project", new DateTime(2024, 7, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2868), 45, false, "Online", "Microsoft Project", 6, 22, 25, 0, 0, null, 0, new DateTime(2024, 6, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2865), 12.5, 4 },
                    { 17, 3, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Navisworks", new DateTime(2024, 8, 14, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2894), 55, false, "Online", "Navisworks", 6, 24, 30, 0, 0, null, 0, new DateTime(2024, 7, 7, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2890), 13.800000000000001, 5 },
                    { 18, 7, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Advanced Revit Structure", new DateTime(2024, 8, 19, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2916), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, 0, 0, null, 0, new DateTime(2024, 7, 3, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2913), 12.300000000000001, 2 },
                    { 19, 7, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 30, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2941), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, 0, 0, null, 0, new DateTime(2024, 7, 1, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2937), 13.699999999999999, 15 },
                    { 20, 7, "/Images/DefaultCourseImg.png", "25/06/2024 10:09:06 am", "Learn Advanced Revit MEP", new DateTime(2024, 7, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2963), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, 0, 0, null, 0, new DateTime(2024, 7, 2, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(2959), 11.4, 11 }
                });

            migrationBuilder.InsertData(
                table: "Assessments",
                columns: new[] { "Id", "CourseId", "CreatedAt", "Description", "IsDeleted", "Points", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3424), "1- Draw grids on the attached dwg.\n2- Change the size of the Bubble.\n3- Change the text size of inside the bubble.", false, 20, "Grids Task", new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3437) },
                    { 2, 1, new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3444), "1- Create the type of column with dimension 25*50 cm2 and .6*.6.\n2- Draw the columns on the attached dwg.", false, 25, "Columns Task", new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3447) },
                    { 3, 1, new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3451), "1- Create the type of Footings with dimension 1.5*1.5 and 1*.6.\n2- Draw the Footings on the attached dwg.", false, 25, "Footings Task", new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3454) },
                    { 4, 1, new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3457), "1- Create the type of Beams with dimension 25*50.\n2- Draw the Beams on the attached dwg.", false, 25, "Beams Task", new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3459) },
                    { 5, 1, new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3464), "1- Create the type of floors generic 300mm.\n2- Draw the floors on the attached dwg.", false, 30, "Floors Task", new DateTime(2024, 6, 25, 10, 9, 6, 279, DateTimeKind.Local).AddTicks(3466) }
                });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Basics of Structural Revit", false, "Introduction to Structural Revit", "https://sadat.vip/" },
                    { 2, 1, "Detailed look into advanced elements", false, "Advanced Structural Elements", "https://sadat.vip/" },
                    { 3, 1, "Best practices for using Structural Revit", false, "Structural Revit Best Practices", "https://sadat.vip/" },
                    { 4, 1, "Conducting structural analysis", false, "Structural Analysis in Revit", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CompletionRatio", "CourseId", "Level", "Points", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 0.0, 1, 0, 20, 21.9116511245221m, 1 },
                    { 2, 0.0, 1, 0, 870, 82.3630586213506m, 2 },
                    { 3, 0.0, 1, 0, 990, 18.9660293131714m, 3 },
                    { 4, 0.0, 1, 0, 540, 47.1948820753936m, 4 },
                    { 5, 0.0, 1, 0, 730, 65.6454517996896m, 5 },
                    { 6, 0.0, 1, 0, 720, 1.16213007204599m, 6 },
                    { 7, 0.0, 1, 0, 180, 35.6163235411804m, 7 },
                    { 8, 0.0, 1, 0, 220, 94.7677329725497m, 8 },
                    { 9, 0.0, 1, 0, 10, 40.7634609785328m, 9 },
                    { 10, 0.0, 1, 0, 380, 14.4969253400149m, 10 },
                    { 11, 0.0, 1, 0, 780, 30.2297721477793m, 11 },
                    { 12, 0.0, 1, 0, 790, 32.3523759536236m, 12 },
                    { 13, 0.0, 1, 0, 570, 3.29760241972212m, 13 },
                    { 14, 0.0, 1, 0, 620, 61.2234397492669m, 14 },
                    { 15, 0.0, 1, 0, 770, 1.36413445292765m, 15 },
                    { 16, 0.0, 1, 0, 250, 96.0430359073104m, 16 },
                    { 17, 0.0, 1, 0, 260, 99.0365367419388m, 17 },
                    { 18, 0.0, 1, 0, 710, 6.60361663480616m, 18 },
                    { 19, 0.0, 1, 0, 670, 19.2935099605968m, 19 },
                    { 20, 0.0, 1, 0, 410, 70.4344016078499m, 20 },
                    { 21, 0.0, 1, 0, 260, 87.4746791181789m, 21 },
                    { 22, 0.0, 1, 0, 280, 68.7898595243542m, 22 },
                    { 23, 0.0, 1, 0, 470, 57.5158734680257m, 23 },
                    { 24, 0.0, 1, 0, 190, 86.918182957674m, 24 },
                    { 25, 0.0, 1, 0, 330, 62.3102721929976m, 25 },
                    { 26, 0.0, 1, 0, 20, 22.1806725235156m, 26 },
                    { 27, 0.0, 1, 0, 0, 91.8383963493703m, 27 },
                    { 28, 0.0, 1, 0, 210, 86.6022019535439m, 28 },
                    { 29, 0.0, 1, 0, 150, 79.2851638996594m, 29 },
                    { 30, 0.0, 1, 0, 720, 21.954969050748m, 30 },
                    { 31, 0.0, 2, 0, 690, 13.6095121277668m, 1 },
                    { 32, 0.0, 2, 0, 200, 8.36497361142433m, 2 },
                    { 33, 0.0, 2, 0, 710, 25.7083375948901m, 3 },
                    { 34, 0.0, 2, 0, 630, 62.5666118505127m, 4 },
                    { 35, 0.0, 2, 0, 160, 34.3756240142652m, 5 },
                    { 36, 0.0, 2, 0, 810, 52.898864835601m, 6 },
                    { 37, 0.0, 2, 0, 240, 2.5674892554842m, 7 },
                    { 38, 0.0, 2, 0, 760, 69.1683493370055m, 8 },
                    { 39, 0.0, 2, 0, 740, 19.8587483415415m, 9 },
                    { 40, 0.0, 2, 0, 920, 7.71569627592578m, 10 },
                    { 41, 0.0, 2, 0, 920, 39.5005602349547m, 11 },
                    { 42, 0.0, 2, 0, 130, 68.8981358268259m, 12 },
                    { 43, 0.0, 2, 0, 760, 54.8133186288355m, 13 },
                    { 44, 0.0, 2, 0, 820, 25.5346672894066m, 14 },
                    { 45, 0.0, 2, 0, 210, 91.3422863861807m, 15 },
                    { 46, 0.0, 2, 0, 360, 11.0564267207244m, 16 },
                    { 47, 0.0, 2, 0, 600, 16.2203687842128m, 17 },
                    { 48, 0.0, 2, 0, 110, 69.6137094262557m, 18 },
                    { 49, 0.0, 2, 0, 930, 14.2557541759735m, 19 },
                    { 50, 0.0, 2, 0, 330, 45.2516220957203m, 20 },
                    { 51, 0.0, 2, 0, 430, 76.6489199435918m, 21 },
                    { 52, 0.0, 2, 0, 140, 39.9514831218444m, 22 },
                    { 53, 0.0, 2, 0, 230, 65.3582868231482m, 23 },
                    { 54, 0.0, 2, 0, 760, 67.8543337044465m, 24 },
                    { 55, 0.0, 2, 0, 430, 78.4388878197958m, 25 },
                    { 56, 0.0, 2, 0, 750, 39.1172168142542m, 26 },
                    { 57, 0.0, 2, 0, 600, 2.35532897024489m, 27 },
                    { 58, 0.0, 2, 0, 220, 62.9089897077738m, 28 },
                    { 59, 0.0, 2, 0, 640, 80.8836874966782m, 29 },
                    { 60, 0.0, 2, 0, 560, 60.9835547897257m, 30 },
                    { 61, 0.0, 3, 0, 190, 20.1472352648534m, 1 },
                    { 62, 0.0, 3, 0, 220, 33.3543903981548m, 2 },
                    { 63, 0.0, 3, 0, 60, 14.3465802882638m, 3 },
                    { 64, 0.0, 3, 0, 740, 0.536083606640569m, 4 },
                    { 65, 0.0, 3, 0, 970, 59.1523204817984m, 5 },
                    { 66, 0.0, 3, 0, 550, 21.258024829754m, 6 },
                    { 67, 0.0, 3, 0, 910, 92.3771175674847m, 7 },
                    { 68, 0.0, 3, 0, 260, 28.8717430029784m, 8 },
                    { 69, 0.0, 3, 0, 670, 88.9459096963426m, 9 },
                    { 70, 0.0, 3, 0, 640, 50.6018246409627m, 10 },
                    { 71, 0.0, 3, 0, 10, 43.3230221596939m, 11 },
                    { 72, 0.0, 3, 0, 700, 52.5667586596675m, 12 },
                    { 73, 0.0, 3, 0, 60, 0.496448360393065m, 13 },
                    { 74, 0.0, 3, 0, 150, 92.6060816214592m, 14 },
                    { 75, 0.0, 3, 0, 360, 57.3061599740995m, 15 },
                    { 76, 0.0, 3, 0, 620, 61.9421726959415m, 16 },
                    { 77, 0.0, 3, 0, 360, 70.2284467440058m, 17 },
                    { 78, 0.0, 3, 0, 970, 63.1484214215422m, 18 },
                    { 79, 0.0, 3, 0, 630, 29.0390520251172m, 19 },
                    { 80, 0.0, 3, 0, 270, 66.0564566661241m, 20 },
                    { 81, 0.0, 3, 0, 940, 16.8140455057726m, 21 },
                    { 82, 0.0, 3, 0, 460, 82.3641616076155m, 22 },
                    { 83, 0.0, 3, 0, 70, 99.2901487878093m, 23 },
                    { 84, 0.0, 3, 0, 400, 65.7124802415522m, 24 },
                    { 85, 0.0, 3, 0, 570, 17.8273748344194m, 25 },
                    { 86, 0.0, 3, 0, 930, 60.5982509718012m, 26 },
                    { 87, 0.0, 3, 0, 320, 76.21004113688m, 27 },
                    { 88, 0.0, 3, 0, 420, 71.2772358095331m, 28 },
                    { 89, 0.0, 3, 0, 240, 50.6239986377161m, 29 },
                    { 91, 0.0, 3, 0, 810, 38.9274962765532m, 31 },
                    { 92, 0.0, 3, 0, 50, 53.0082793240882m, 32 },
                    { 93, 0.0, 3, 0, 150, 36.7666406822574m, 33 },
                    { 94, 0.0, 4, 0, 40, 45.0688747601147m, 1 },
                    { 95, 0.0, 4, 0, 500, 20.1589634745413m, 2 },
                    { 96, 0.0, 4, 0, 740, 14.6297540731767m, 3 },
                    { 97, 0.0, 4, 0, 770, 96.034734247974m, 4 },
                    { 98, 0.0, 4, 0, 380, 19.5022165374355m, 5 },
                    { 99, 0.0, 4, 0, 410, 71.3886397719405m, 6 },
                    { 100, 0.0, 4, 0, 790, 97.3078494384773m, 7 },
                    { 101, 0.0, 1, 0, 660, 51.7332301446941m, 31 },
                    { 102, 0.0, 1, 0, 920, 72.3347042255008m, 32 },
                    { 103, 0.0, 1, 0, 250, 79.4573984963835m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Installing Revit and initial setup", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 30, 0, 0), "Revit Installation and Setup", "https://sadat.vip/" },
                    { 2, 1, "Understanding basic structural elements", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 45, 0, 0), "Basic Structural Elements", "https://sadat.vip/" },
                    { 3, 2, "Advanced design techniques", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 1, 0, 0, 0), "Advanced Structural Design", "https://sadat.vip/" },
                    { 4, 2, "Designing complex structures", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 50, 0, 0), "Complex Structures", "https://sadat.vip/" },
                    { 5, 3, "Overview of best practices", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 40, 0, 0), "Best Practices Overview", "https://sadat.vip/" },
                    { 6, 3, "Tips for effective modeling", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 35, 0, 0), "Modeling Tips", "https://sadat.vip/" },
                    { 7, 4, "Basics of structural analysis", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 45, 0, 0), "Introduction to Structural Analysis", "https://sadat.vip/" },
                    { 8, 4, "Advanced techniques in structural analysis", false, "https://www.youtube.com/watch?v=Nd6U2KgHI6k", new TimeSpan(0, 0, 55, 0, 0), "Advanced Analysis Techniques", "https://sadat.vip/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_CourseTraineeId",
                table: "ActivityLogs",
                column: "CourseTraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLogs_LessonId",
                table: "ActivityLogs",
                column: "LessonId");

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
                name: "IX_JoinRequests_CourseId",
                table: "JoinRequests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_JoinRequests_TraineeId",
                table: "JoinRequests",
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
                name: "ActivityLogs");

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
                name: "JoinRequests");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "RedeemCode");

            migrationBuilder.DropTable(
                name: "Service");

            migrationBuilder.DropTable(
                name: "CourseTrainee");

            migrationBuilder.DropTable(
                name: "Lessons");

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
                name: "Category");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
