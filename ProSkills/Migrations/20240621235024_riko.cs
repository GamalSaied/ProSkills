using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class riko : Migration
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
                    { "1", 0, null, "d1398b08-df89-444d-b6a1-b1dd208bb3ff", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEE+8JjGOfHN50VvEMT4qrTaY+jOgP1v44oJk+LzEDmny/IC0egibbs14rsmlVP3YKA==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "dea0e99a-7d72-4550-964a-a0ccdb7290e3", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAEOZ8R4yaz51H7xnFPsC9K7GJyqLETKP5wKNbj2nohDvE9An/UHjQHWaVyCf+KnCpig==", "01050403037", null, false, null, "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "6eeb8440-7a33-4907-93d9-1cac96faf71b", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEL6vPyLI5AC5v1e4fmKAl7Sf26zVKwMp3/l9cv5kknWC8NhK7J+t61I8wdoZkqe7Tw==", "01033901616", null, false, null, "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "22/06/2024 02:50:23 ص", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "22/06/2024 02:50:23 ص", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "22/06/2024 02:50:23 ص", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "22/06/2024 02:50:23 ص", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "22/06/2024 02:50:23 ص", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "22/06/2024 02:50:23 ص", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "22/06/2024 02:50:23 ص", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "22/06/2024 02:50:23 ص", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "22/06/2024 02:50:23 ص", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "22/06/2024 02:50:23 ص", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "22/06/2024 02:50:23 ص", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "22/06/2024 02:50:23 ص", "Trainee1@example.com", false, "Trainee 1", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "22/06/2024 02:50:23 ص", "Trainee2@example.com", false, "Trainee 2", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "22/06/2024 02:50:23 ص", "Trainee3@example.com", false, "Trainee 3", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "22/06/2024 02:50:23 ص", "Trainee4@example.com", false, "Trainee 4", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "22/06/2024 02:50:23 ص", "Trainee5@example.com", false, "Trainee 5", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "22/06/2024 02:50:23 ص", "Trainee6@example.com", false, "Trainee 6", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "22/06/2024 02:50:23 ص", "Trainee7@example.com", false, "Trainee 7", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "22/06/2024 02:50:23 ص", "Trainee8@example.com", false, "Trainee 8", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "22/06/2024 02:50:23 ص", "Trainee9@example.com", false, "Trainee 9", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "22/06/2024 02:50:23 ص", "Trainee10@example.com", false, "Trainee 10", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "22/06/2024 02:50:23 ص", "Trainee11@example.com", false, "Trainee 11", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "22/06/2024 02:50:23 ص", "Trainee12@example.com", false, "Trainee 12", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "22/06/2024 02:50:23 ص", "Trainee13@example.com", false, "Trainee 13", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "22/06/2024 02:50:23 ص", "Trainee14@example.com", false, "Trainee 14", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "22/06/2024 02:50:23 ص", "Trainee15@example.com", false, "Trainee 15", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "22/06/2024 02:50:23 ص", "Trainee16@example.com", false, "Trainee 16", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "22/06/2024 02:50:23 ص", "Trainee17@example.com", false, "Trainee 17", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "22/06/2024 02:50:23 ص", "Trainee18@example.com", false, "Trainee 18", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "22/06/2024 02:50:23 ص", "Trainee19@example.com", false, "Trainee 19", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "22/06/2024 02:50:23 ص", "Trainee20@example.com", false, "Trainee 20", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "22/06/2024 02:50:23 ص", "Trainee21@example.com", false, "Trainee 21", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "22/06/2024 02:50:23 ص", "Trainee22@example.com", false, "Trainee 22", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "22/06/2024 02:50:23 ص", "Trainee23@example.com", false, "Trainee 23", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "22/06/2024 02:50:23 ص", "Trainee24@example.com", false, "Trainee 24", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "22/06/2024 02:50:23 ص", "Trainee25@example.com", false, "Trainee 25", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "22/06/2024 02:50:23 ص", "Trainee26@example.com", false, "Trainee 26", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "22/06/2024 02:50:23 ص", "Trainee27@example.com", false, "Trainee 27", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "22/06/2024 02:50:23 ص", "Trainee28@example.com", false, "Trainee 28", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "22/06/2024 02:50:23 ص", "Trainee30@example.com", false, "Trainee 30", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "22/06/2024 02:50:23 ص", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "22/06/2024 02:50:23 ص", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "22/06/2024 02:50:23 ص", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "22/06/2024 02:50:23 ص", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "22/06/2024 02:50:23 ص", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "22/06/2024 02:50:23 ص", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "22/06/2024 02:50:23 ص", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "22/06/2024 02:50:23 ص", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "22/06/2024 02:50:23 ص", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "22/06/2024 02:50:23 ص", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "22/06/2024 02:50:23 ص", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "22/06/2024 02:50:23 ص", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "22/06/2024 02:50:23 ص", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "22/06/2024 02:50:23 ص", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "22/06/2024 02:50:23 ص", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "22/06/2024 02:50:23 ص", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "22/06/2024 02:50:23 ص", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "22/06/2024 02:50:23 ص", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "22/06/2024 02:50:23 ص", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "22/06/2024 02:50:23 ص", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "22/06/2024 02:50:23 ص", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "22/06/2024 02:50:23 ص", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "22/06/2024 02:50:23 ص", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "22/06/2024 02:50:23 ص", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "22/06/2024 02:50:23 ص", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "22/06/2024 02:50:23 ص", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "22/06/2024 02:50:23 ص", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "22/06/2024 02:50:23 ص", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "22/06/2024 02:50:23 ص", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "22/06/2024 02:50:23 ص", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "22/06/2024 02:50:23 ص", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "22/06/2024 02:50:23 ص", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "22/06/2024 02:50:23 ص", "instructor30@example.com", false, "Instructor 30", "password30", null }
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
                    { 1, 1, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Structural Revit", new DateTime(2024, 7, 22, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9547), 40, false, "Online", "Structural Revit", 5, 20, 25, null, new DateTime(2024, 6, 29, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9538), 10.5, 2 },
                    { 2, 1, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Arch Revit", new DateTime(2024, 8, 6, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9673), 60, false, "Online", "Arch Revit", 7, 25, 30, null, new DateTime(2024, 7, 6, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9669), 15.199999999999999, 2 },
                    { 3, 1, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn MEP Revit", new DateTime(2024, 7, 27, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9714), 45, false, "Online", "MEP Revit", 6, 22, 20, null, new DateTime(2024, 6, 27, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9711), 11.699999999999999, 8 },
                    { 4, 2, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Structural AutoCAD", new DateTime(2024, 8, 21, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9732), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, null, new DateTime(2024, 7, 2, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9729), 13.5, 14 },
                    { 5, 2, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Arch AutoCAD", new DateTime(2024, 8, 1, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9768), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, null, new DateTime(2024, 6, 29, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9765), 14.1, 12 },
                    { 6, 2, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn MEP AutoCAD", new DateTime(2024, 8, 11, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9795), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, null, new DateTime(2024, 7, 4, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9792), 12.300000000000001, 9 },
                    { 7, 2, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn 3D AutoCAD", new DateTime(2024, 8, 16, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9822), 50, false, "Online", "3D AutoCAD", 6, 23, 20, null, new DateTime(2024, 6, 30, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9812), 12.800000000000001, 14 },
                    { 8, 3, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Tekla", new DateTime(2024, 7, 27, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9885), 45, false, "Online", "Tekla", 6, 22, 30, null, new DateTime(2024, 6, 28, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9882), 13.199999999999999, 13 },
                    { 9, 3, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn SketchUP", new DateTime(2024, 8, 1, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(41), 40, false, "Online", "SketchUP", 5, 20, 25, null, new DateTime(2024, 7, 1, 2, 50, 23, 594, DateTimeKind.Local).AddTicks(9904), 10.800000000000001, 13 },
                    { 10, 4, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn SAP 2000", new DateTime(2024, 8, 6, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(60), 50, false, "Online", "SAP 2000", 6, 22, 20, null, new DateTime(2024, 7, 3, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(57), 12.199999999999999, 13 },
                    { 11, 4, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn STAAD Pro", new DateTime(2024, 8, 11, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(221), 55, false, "Online", "STAAD Pro", 6, 24, 25, null, new DateTime(2024, 7, 5, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(216), 13.5, 13 },
                    { 12, 5, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn CIVIL 3D", new DateTime(2024, 8, 1, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(245), 45, false, "Online", "CIVIL 3D", 6, 22, 30, null, new DateTime(2024, 7, 2, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(242), 13.1, 1 },
                    { 13, 4, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn ETABS", new DateTime(2024, 7, 27, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(264), 40, false, "Online", "ETABS", 5, 20, 25, null, new DateTime(2024, 6, 30, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(262), 10.6, 9 },
                    { 14, 4, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn SAFE", new DateTime(2024, 7, 22, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(287), 35, false, "Online", "SAFE", 5, 18, 20, null, new DateTime(2024, 6, 29, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(284), 11.199999999999999, 4 },
                    { 15, 6, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Primavera P6", new DateTime(2024, 8, 6, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(303), 60, false, "Online", "Primavera P6", 7, 25, 30, null, new DateTime(2024, 7, 6, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(301), 15.800000000000001, 5 },
                    { 16, 6, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Microsoft Project", new DateTime(2024, 7, 27, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(323), 45, false, "Online", "Microsoft Project", 6, 22, 25, null, new DateTime(2024, 6, 27, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(320), 12.5, 2 },
                    { 17, 3, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Navisworks", new DateTime(2024, 8, 11, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(348), 55, false, "Online", "Navisworks", 6, 24, 30, null, new DateTime(2024, 7, 4, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(345), 13.800000000000001, 9 },
                    { 18, 7, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Advanced Revit Structure", new DateTime(2024, 8, 16, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(365), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, null, new DateTime(2024, 6, 30, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(363), 12.300000000000001, 15 },
                    { 19, 7, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 27, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(382), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, null, new DateTime(2024, 6, 28, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(379), 13.699999999999999, 4 },
                    { 20, 7, "path/to/course/image.jpg", "22/06/2024 02:50:23 ص", "Learn Advanced Revit MEP", new DateTime(2024, 7, 22, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(399), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, null, new DateTime(2024, 6, 29, 2, 50, 23, 595, DateTimeKind.Local).AddTicks(397), 11.4, 1 }
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
                    { 6, 2, "Description for Chapter 3 in Course 2", false, "Chapter 3 for Course 2", "https://sadat.vip/" },
                    { 7, 3, "Description for Chapter 1 in Course 3", false, "Chapter 1 for Course 3", "https://sadat.vip/" },
                    { 8, 3, "Description for Chapter 2 in Course 3", false, "Chapter 2 for Course 3", "https://sadat.vip/" },
                    { 9, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 10, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 11, 4, "Description for Chapter 3 in Course 4", false, "Chapter 3 for Course 4", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 13, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 14, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 15, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 16, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 17, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 18, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 19, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 20, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 21, 8, "Description for Chapter 3 in Course 8", false, "Chapter 3 for Course 8", "https://sadat.vip/" },
                    { 22, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 23, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 24, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 25, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 26, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Level", "Points", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 0, 830, 72.2894605977043m, 1 },
                    { 2, 1, 0, 560, 86.4895031602914m, 2 },
                    { 3, 1, 0, 340, 27.5533553611222m, 3 },
                    { 4, 1, 0, 30, 73.0109007595093m, 4 },
                    { 5, 1, 0, 0, 10.7545456665873m, 5 },
                    { 6, 1, 0, 800, 29.180293103618m, 6 },
                    { 7, 1, 0, 750, 24.9962157985478m, 7 },
                    { 8, 1, 0, 140, 30.1448208987283m, 8 },
                    { 9, 1, 0, 880, 68.2288896669716m, 9 },
                    { 10, 1, 0, 540, 79.8843709542481m, 10 },
                    { 11, 1, 0, 980, 26.3474571767987m, 11 },
                    { 12, 1, 0, 690, 70.4677331302497m, 12 },
                    { 13, 1, 0, 140, 56.4814189436019m, 13 },
                    { 14, 1, 0, 230, 90.5404291012845m, 14 },
                    { 15, 15, 0, 390, 94.3505920077469m, 15 },
                    { 16, 16, 0, 350, 3.85785004595445m, 16 },
                    { 17, 17, 0, 250, 20.5301229657516m, 17 },
                    { 18, 18, 0, 530, 7.67040234431208m, 18 },
                    { 19, 19, 0, 50, 98.4240101656114m, 19 },
                    { 20, 20, 0, 120, 82.1927933935085m, 20 },
                    { 21, 1, 0, 740, 62.3285710057507m, 21 },
                    { 22, 2, 0, 1000, 52.3965863895644m, 22 },
                    { 23, 3, 0, 590, 77.9742786151803m, 23 },
                    { 24, 4, 0, 280, 7.62591304764633m, 24 },
                    { 25, 5, 0, 930, 37.2152900869168m, 25 },
                    { 26, 6, 0, 90, 21.5653955418783m, 26 },
                    { 27, 7, 0, 920, 15.5826841437641m, 27 },
                    { 28, 8, 0, 50, 96.4329084860723m, 28 },
                    { 29, 9, 0, 600, 59.3473766212075m, 29 },
                    { 30, 10, 0, 10, 8.90524518347064m, 30 },
                    { 31, 11, 0, 850, 21.2331754808358m, 1 },
                    { 32, 12, 0, 180, 95.4302206975507m, 2 },
                    { 33, 13, 0, 440, 48.2842879536957m, 3 },
                    { 34, 14, 0, 900, 65.5862785074438m, 4 },
                    { 35, 15, 0, 650, 24.1390696829555m, 5 },
                    { 36, 16, 0, 900, 69.6144442008445m, 6 },
                    { 37, 17, 0, 360, 89.4796966140338m, 7 },
                    { 38, 18, 0, 430, 56.3336625340148m, 8 },
                    { 39, 19, 0, 190, 1.07068613321567m, 9 },
                    { 40, 20, 0, 850, 66.7613194293813m, 10 },
                    { 41, 1, 0, 710, 13.971868657498m, 11 },
                    { 42, 2, 0, 620, 25.2941296550369m, 12 },
                    { 43, 3, 0, 50, 41.3786472548868m, 13 },
                    { 44, 4, 0, 790, 60.0435795182418m, 14 },
                    { 45, 5, 0, 100, 22.4464729850116m, 15 },
                    { 46, 6, 0, 880, 47.2561765471934m, 16 },
                    { 47, 7, 0, 430, 60.6382074532971m, 17 },
                    { 48, 8, 0, 10, 48.6655982640382m, 18 },
                    { 49, 9, 0, 300, 0.538000701963393m, 19 },
                    { 50, 10, 0, 320, 82.4137866513644m, 20 },
                    { 51, 11, 0, 730, 42.1023762547551m, 21 },
                    { 52, 12, 0, 630, 9.13525880716405m, 22 },
                    { 53, 13, 0, 920, 29.2419031545567m, 23 },
                    { 54, 14, 0, 210, 95.0733457568657m, 24 },
                    { 55, 15, 0, 900, 39.5243226580075m, 25 },
                    { 56, 16, 0, 420, 22.2925947199814m, 26 },
                    { 57, 17, 0, 760, 36.6059789438552m, 27 },
                    { 58, 18, 0, 810, 32.7502818535049m, 28 },
                    { 59, 19, 0, 660, 96.2488538910405m, 29 },
                    { 60, 20, 0, 260, 72.8857262541168m, 30 },
                    { 61, 1, 0, 370, 22.8791279313962m, 1 },
                    { 62, 2, 0, 820, 31.0014698397402m, 2 },
                    { 63, 3, 0, 480, 59.5917481254281m, 3 },
                    { 64, 4, 0, 290, 70.0281173597533m, 4 },
                    { 65, 5, 0, 80, 94.2694769237838m, 5 },
                    { 66, 6, 0, 230, 53.4575810989172m, 6 },
                    { 67, 7, 0, 200, 95.5300936534028m, 7 },
                    { 68, 8, 0, 870, 52.9610670954929m, 8 },
                    { 69, 9, 0, 110, 45.0083754380026m, 9 },
                    { 70, 10, 0, 280, 14.2291778657598m, 10 },
                    { 71, 11, 0, 550, 59.3759566667639m, 11 },
                    { 72, 12, 0, 930, 93.8527502267744m, 12 },
                    { 73, 13, 0, 680, 33.9995704938823m, 13 },
                    { 74, 14, 0, 640, 76.0663815492241m, 14 },
                    { 75, 15, 0, 740, 43.5881591931345m, 15 },
                    { 76, 16, 0, 860, 25.6428625490396m, 16 },
                    { 77, 17, 0, 370, 58.3241656700828m, 17 },
                    { 78, 18, 0, 150, 71.7962760429707m, 18 },
                    { 79, 19, 0, 730, 28.5010145755361m, 19 },
                    { 80, 20, 0, 680, 87.8044040471396m, 20 },
                    { 81, 1, 0, 10, 99.434080401825m, 21 },
                    { 82, 2, 0, 200, 90.1091666122812m, 22 },
                    { 83, 3, 0, 970, 19.0830996124111m, 23 },
                    { 84, 4, 0, 620, 80.1884196606271m, 24 },
                    { 85, 5, 0, 890, 43.5563853087766m, 25 },
                    { 86, 6, 0, 40, 30.1265758508179m, 26 },
                    { 87, 7, 0, 830, 44.9399433627696m, 27 },
                    { 88, 8, 0, 720, 5.91263366628802m, 28 },
                    { 89, 9, 0, 190, 46.904511602711m, 29 },
                    { 90, 10, 0, 820, 57.9964566661103m, 30 },
                    { 91, 11, 0, 810, 10.6664104929983m, 31 },
                    { 92, 12, 0, 900, 54.9643228332019m, 32 },
                    { 93, 13, 0, 320, 19.8307242178148m, 33 },
                    { 94, 14, 0, 430, 97.8293179295797m, 34 },
                    { 95, 15, 0, 780, 64.5866977173513m, 35 },
                    { 96, 16, 0, 550, 25.8362409195012m, 36 },
                    { 97, 17, 0, 40, 9.40468655694651m, 37 },
                    { 98, 18, 0, 180, 89.5784124548006m, 38 },
                    { 99, 19, 0, 500, 27.8391165957731m, 39 },
                    { 100, 20, 0, 750, 34.1182490968273m, 40 },
                    { 101, 1, 0, 140, 58.5838593742467m, 31 },
                    { 102, 1, 0, 270, 16.8915690098298m, 32 },
                    { 103, 1, 0, 380, 55.3800897127084m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 10, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 12, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 13, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 3 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 6", "https://sadat.vip/" },
                    { 15, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 17, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 18, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 20, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 21, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 22, 9, "Content for Lesson 3 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" },
                    { 23, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 24, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 3 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 28, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 32, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 34, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 35, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 36, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 37, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 38, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 39, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 40, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 41, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 42, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 43, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 44, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 45, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 46, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 47, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 49, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 50, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 51, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 52, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 53, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 54, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 55, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 56, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 57, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 58, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 59, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 60, 24, "Content for Lesson 3 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 3 for Chapter 24", "https://sadat.vip/" },
                    { 61, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 62, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" },
                    { 64, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 65, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" },
                    { 66, 26, "Content for Lesson 3 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 26", "https://sadat.vip/" }
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
