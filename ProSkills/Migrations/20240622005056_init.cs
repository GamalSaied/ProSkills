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
                    { "1", 0, null, "d596eba5-f29b-4141-b670-dfccd591e231", 0, null, "ahmed9821hussein@gmail.com", true, "Ahmed Hussein", false, null, "AHMED9821HUSSEIN@GMAIL.COM", "AHMED9821HUSSEIN@GMAIL.COM", "AQAAAAIAAYagAAAAEHiboRm58CZckZchpQCS0N7pr4chPwwYKdA29PRMMgmaj6qXsDZReFqQC98OuoXapA==", "01015983533", null, true, "\\Images\\profiles\\profile-picture.jpg", "", false, "ahmed9821hussein@gmail.com" },
                    { "2", 0, null, "cbe10673-4c33-4cbd-85e8-9f77c2af256f", 0, null, "MuhammedSadat@outlook.com", true, "Muhammed Sadat", false, null, "MUHAMMEDSADAT@OUTLOOK.COM", "MUHAMMEDSADAT@OUTLOOK.COM", "AQAAAAIAAYagAAAAEJnCEB9C+WGJGq/nD36leqY12P/3NciwjxNkLUAUZxQig3yJQaT0AaMPc3/pgacTaQ==", "01050403037", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "MuhammedSadat@outlook.com" },
                    { "3", 0, null, "49dba61b-2ef9-4efc-9041-715fca642d60", 0, null, "gamalsaied.90@gmail.com", true, "Gamal Said", false, null, "GAMALSAIED.90@GMAIL.COM", "GAMALSAIED.90@GMAIL.COM", "AQAAAAIAAYagAAAAEHe8pyLIuw50Q6PBS0jTnQgCtC0wk2aSFKGZ28IeCN05FBIA6P21bGIAxjoAYcdJOQ==", "01033901616", null, false, "\\ThemeFront\\img\\User.jpg", "", false, "gamalsaied.90@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Description", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "22/06/2024 3:50:56 am", "Building Information Modeling software", "path/to/bim/image.jpg", false, "BIM Software" },
                    { 2, "22/06/2024 3:50:56 am", "Computer-Aided Design software", "path/to/cad/image.jpg", false, "CAD Software" },
                    { 3, "22/06/2024 3:50:56 am", "Software for construction planning and management", "path/to/construction/image.jpg", false, "Construction Software" },
                    { 4, "22/06/2024 3:50:56 am", "Software for structural engineering analysis and design", "path/to/structural/image.jpg", false, "Structural Engineering Software" },
                    { 5, "22/06/2024 3:50:56 am", "Software for civil engineering design and analysis", "path/to/civil/image.jpg", false, "Civil Engineering Software" },
                    { 6, "22/06/2024 3:50:56 am", "Software for project management", "path/to/project/image.jpg", false, "Project Management Software" },
                    { 7, "22/06/2024 3:50:56 am", "Advanced Building Information Modeling software", "path/to/advanced_bim/image.jpg", false, "Advanced BIM Software" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "22/06/2024 3:50:56 am", 10, "image1.jpg", false, "Free", 5, 15, 20, 1024.0 },
                    { 2, "22/06/2024 3:50:56 am", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "22/06/2024 3:50:56 am", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 1, "gamal", "22/06/2024 3:50:56 am", false, "Premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "22/06/2024 3:50:55 am", "Trainee1@example.com", false, "Trainee 1", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "22/06/2024 3:50:55 am", "Trainee2@example.com", false, "Trainee 2", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "22/06/2024 3:50:55 am", "Trainee3@example.com", false, "Trainee 3", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "22/06/2024 3:50:55 am", "Trainee4@example.com", false, "Trainee 4", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "22/06/2024 3:50:55 am", "Trainee5@example.com", false, "Trainee 5", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "22/06/2024 3:50:55 am", "Trainee6@example.com", false, "Trainee 6", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "22/06/2024 3:50:55 am", "Trainee7@example.com", false, "Trainee 7", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "22/06/2024 3:50:55 am", "Trainee8@example.com", false, "Trainee 8", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "22/06/2024 3:50:55 am", "Trainee9@example.com", false, "Trainee 9", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "22/06/2024 3:50:55 am", "Trainee10@example.com", false, "Trainee 10", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "22/06/2024 3:50:55 am", "Trainee11@example.com", false, "Trainee 11", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "22/06/2024 3:50:55 am", "Trainee12@example.com", false, "Trainee 12", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "22/06/2024 3:50:55 am", "Trainee13@example.com", false, "Trainee 13", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "22/06/2024 3:50:55 am", "Trainee14@example.com", false, "Trainee 14", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "22/06/2024 3:50:55 am", "Trainee15@example.com", false, "Trainee 15", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "22/06/2024 3:50:55 am", "Trainee16@example.com", false, "Trainee 16", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "22/06/2024 3:50:55 am", "Trainee17@example.com", false, "Trainee 17", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "22/06/2024 3:50:55 am", "Trainee18@example.com", false, "Trainee 18", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "22/06/2024 3:50:55 am", "Trainee19@example.com", false, "Trainee 19", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "22/06/2024 3:50:55 am", "Trainee20@example.com", false, "Trainee 20", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "22/06/2024 3:50:55 am", "Trainee21@example.com", false, "Trainee 21", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "22/06/2024 3:50:55 am", "Trainee22@example.com", false, "Trainee 22", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "22/06/2024 3:50:55 am", "Trainee23@example.com", false, "Trainee 23", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "22/06/2024 3:50:55 am", "Trainee24@example.com", false, "Trainee 24", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "22/06/2024 3:50:55 am", "Trainee25@example.com", false, "Trainee 25", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "22/06/2024 3:50:55 am", "Trainee26@example.com", false, "Trainee 26", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "22/06/2024 3:50:55 am", "Trainee27@example.com", false, "Trainee 27", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "22/06/2024 3:50:55 am", "Trainee28@example.com", false, "Trainee 28", null, "/themefront/img/user.jpg" },
                    { 29, "Bio for Trainee 29", null, "22/06/2024 3:50:55 am", "Trainee29@example.com", false, "Trainee 29", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "22/06/2024 3:50:55 am", "Trainee30@example.com", false, "Trainee 30", null, "/themefront/img/user.jpg" },
                    { 31, null, null, "22/06/2024 3:50:56 am", "ahmed9821hussein@gmail.com", false, "Ahmed Hussein", "01015983533", "\\Images\\profiles\\profile-picture.jpg" },
                    { 32, null, null, "22/06/2024 3:50:56 am", "MuhammedSadat@outlook.com", false, "Muhammed Sadat", "01050403037", "/themefront/img/user.jpg" },
                    { 33, null, null, "22/06/2024 3:50:56 am", "gamalsaied.90@gmail.com", false, "Gamal Said", "01033901616", "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "22/06/2024 3:50:55 am", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "22/06/2024 3:50:55 am", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "22/06/2024 3:50:55 am", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "22/06/2024 3:50:55 am", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "22/06/2024 3:50:55 am", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "22/06/2024 3:50:55 am", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "22/06/2024 3:50:55 am", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "22/06/2024 3:50:55 am", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "22/06/2024 3:50:55 am", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "22/06/2024 3:50:55 am", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "22/06/2024 3:50:55 am", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "22/06/2024 3:50:55 am", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "22/06/2024 3:50:55 am", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "22/06/2024 3:50:55 am", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "22/06/2024 3:50:55 am", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "22/06/2024 3:50:55 am", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "22/06/2024 3:50:55 am", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "22/06/2024 3:50:55 am", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "22/06/2024 3:50:55 am", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "22/06/2024 3:50:55 am", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "22/06/2024 3:50:55 am", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "22/06/2024 3:50:55 am", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "22/06/2024 3:50:55 am", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "22/06/2024 3:50:55 am", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "22/06/2024 3:50:55 am", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "22/06/2024 3:50:55 am", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "22/06/2024 3:50:55 am", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "22/06/2024 3:50:55 am", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "22/06/2024 3:50:55 am", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "22/06/2024 3:50:55 am", "instructor30@example.com", false, "Instructor 30", "password30", null }
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
                    { 1, 1, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Structural Revit", new DateTime(2024, 7, 22, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(383), 40, false, "Online", "Structural Revit", 5, 20, 25, null, new DateTime(2024, 6, 29, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(373), 10.5, 9 },
                    { 2, 1, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Arch Revit", new DateTime(2024, 8, 6, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(578), 60, false, "Online", "Arch Revit", 7, 25, 30, null, new DateTime(2024, 7, 6, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(574), 15.199999999999999, 13 },
                    { 3, 1, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn MEP Revit", new DateTime(2024, 7, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(605), 45, false, "Online", "MEP Revit", 6, 22, 20, null, new DateTime(2024, 6, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(601), 11.699999999999999, 7 },
                    { 4, 2, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Structural AutoCAD", new DateTime(2024, 8, 21, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(637), 55, false, "Online", "Structural AutoCAD", 6, 23, 25, null, new DateTime(2024, 7, 2, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(634), 13.5, 6 },
                    { 5, 2, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Arch AutoCAD", new DateTime(2024, 8, 1, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(657), 50, false, "Online", "Arch AutoCAD", 7, 25, 30, null, new DateTime(2024, 6, 29, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(655), 14.1, 8 },
                    { 6, 2, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn MEP AutoCAD", new DateTime(2024, 8, 11, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(678), 55, false, "Online", "MEP AutoCAD", 6, 24, 25, null, new DateTime(2024, 7, 4, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(676), 12.300000000000001, 10 },
                    { 7, 2, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn 3D AutoCAD", new DateTime(2024, 8, 16, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(708), 50, false, "Online", "3D AutoCAD", 6, 23, 20, null, new DateTime(2024, 6, 30, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(705), 12.800000000000001, 10 },
                    { 8, 3, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Tekla", new DateTime(2024, 7, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(749), 45, false, "Online", "Tekla", 6, 22, 30, null, new DateTime(2024, 6, 28, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(746), 13.199999999999999, 14 },
                    { 9, 3, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn SketchUP", new DateTime(2024, 8, 1, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(776), 40, false, "Online", "SketchUP", 5, 20, 25, null, new DateTime(2024, 7, 1, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(773), 10.800000000000001, 10 },
                    { 10, 4, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn SAP 2000", new DateTime(2024, 8, 6, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(796), 50, false, "Online", "SAP 2000", 6, 22, 20, null, new DateTime(2024, 7, 3, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(793), 12.199999999999999, 14 },
                    { 11, 4, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn STAAD Pro", new DateTime(2024, 8, 11, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(818), 55, false, "Online", "STAAD Pro", 6, 24, 25, null, new DateTime(2024, 7, 5, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(815), 13.5, 9 },
                    { 12, 5, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn CIVIL 3D", new DateTime(2024, 8, 1, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(842), 45, false, "Online", "CIVIL 3D", 6, 22, 30, null, new DateTime(2024, 7, 2, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(839), 13.1, 2 },
                    { 13, 4, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn ETABS", new DateTime(2024, 7, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(863), 40, false, "Online", "ETABS", 5, 20, 25, null, new DateTime(2024, 6, 30, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(860), 10.6, 2 },
                    { 14, 4, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn SAFE", new DateTime(2024, 7, 22, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(882), 35, false, "Online", "SAFE", 5, 18, 20, null, new DateTime(2024, 6, 29, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(879), 11.199999999999999, 6 },
                    { 15, 6, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Primavera P6", new DateTime(2024, 8, 6, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(900), 60, false, "Online", "Primavera P6", 7, 25, 30, null, new DateTime(2024, 7, 6, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(897), 15.800000000000001, 2 },
                    { 16, 6, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Microsoft Project", new DateTime(2024, 7, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(938), 45, false, "Online", "Microsoft Project", 6, 22, 25, null, new DateTime(2024, 6, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(935), 12.5, 5 },
                    { 17, 3, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Navisworks", new DateTime(2024, 8, 11, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(959), 55, false, "Online", "Navisworks", 6, 24, 30, null, new DateTime(2024, 7, 4, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(956), 13.800000000000001, 1 },
                    { 18, 7, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Advanced Revit Structure", new DateTime(2024, 8, 16, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(979), 50, false, "Online", "Revit Structure Advanced", 6, 23, 20, null, new DateTime(2024, 6, 30, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(976), 12.300000000000001, 12 },
                    { 19, 7, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Advanced Revit Architecture", new DateTime(2024, 7, 27, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(999), 45, false, "Online", "Revit Architecture Advanced", 6, 22, 25, null, new DateTime(2024, 6, 28, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(997), 13.699999999999999, 12 },
                    { 20, 7, "path/to/course/image.jpg", "22/06/2024 3:50:56 am", "Learn Advanced Revit MEP", new DateTime(2024, 7, 22, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(1023), 35, false, "Online", "Revit MEP Advanced", 5, 18, 20, null, new DateTime(2024, 6, 29, 3, 50, 56, 258, DateTimeKind.Local).AddTicks(1020), 11.4, 6 }
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
                    { 10, 4, "Description for Chapter 3 in Course 4", false, "Chapter 3 for Course 4", "https://sadat.vip/" },
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
                    { 22, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 23, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 24, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Level", "Points", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1, 0, 330, 48.8114191018263m, 1 },
                    { 2, 1, 0, 420, 91.9139004094869m, 2 },
                    { 3, 1, 0, 10, 4.51903674813775m, 3 },
                    { 4, 1, 0, 170, 46.8133595038046m, 4 },
                    { 5, 1, 0, 140, 27.6092065750767m, 5 },
                    { 6, 1, 0, 880, 75.7422290985536m, 6 },
                    { 7, 1, 0, 700, 70.0336667949302m, 7 },
                    { 8, 1, 0, 770, 73.4436121140124m, 8 },
                    { 9, 1, 0, 490, 97.1253119069968m, 9 },
                    { 10, 1, 0, 410, 51.502012407031m, 10 },
                    { 11, 1, 0, 560, 6.90030501746819m, 11 },
                    { 12, 1, 0, 820, 76.3617039706859m, 12 },
                    { 13, 1, 0, 630, 79.8173495854181m, 13 },
                    { 14, 1, 0, 680, 40.37795533036m, 14 },
                    { 15, 1, 0, 280, 96.1315666989076m, 15 },
                    { 16, 1, 0, 130, 86.3411334699823m, 16 },
                    { 17, 1, 0, 320, 94.6008012819348m, 17 },
                    { 18, 1, 0, 340, 94.8823903103697m, 18 },
                    { 19, 1, 0, 700, 53.7633275070634m, 19 },
                    { 20, 1, 0, 620, 87.4502462094135m, 20 },
                    { 21, 1, 0, 690, 74.8143238017148m, 21 },
                    { 22, 1, 0, 840, 46.2790901313081m, 22 },
                    { 23, 1, 0, 770, 71.0226169877551m, 23 },
                    { 24, 1, 0, 900, 4.05671455318061m, 24 },
                    { 25, 1, 0, 350, 85.9334806554191m, 25 },
                    { 26, 1, 0, 210, 36.6034179706371m, 26 },
                    { 27, 1, 0, 400, 91.103776508952m, 27 },
                    { 28, 1, 0, 650, 6.66687181349981m, 28 },
                    { 29, 1, 0, 70, 21.6318193985935m, 29 },
                    { 30, 1, 0, 740, 20.3395661964561m, 30 },
                    { 31, 2, 0, 750, 10.3573801391549m, 1 },
                    { 32, 2, 0, 160, 64.6387704864713m, 2 },
                    { 33, 2, 0, 300, 26.3924974139726m, 3 },
                    { 34, 2, 0, 330, 82.1493635454262m, 4 },
                    { 35, 2, 0, 190, 23.4494253299789m, 5 },
                    { 36, 2, 0, 930, 55.0926520504817m, 6 },
                    { 37, 2, 0, 360, 46.7465068789368m, 7 },
                    { 38, 2, 0, 910, 92.6889317539674m, 8 },
                    { 39, 2, 0, 0, 11.3539055747001m, 9 },
                    { 40, 2, 0, 500, 17.2838190881006m, 10 },
                    { 41, 2, 0, 500, 52.0179988408553m, 11 },
                    { 42, 2, 0, 150, 7.86135303918804m, 12 },
                    { 43, 2, 0, 810, 75.3203989739627m, 13 },
                    { 44, 2, 0, 210, 87.8305458256494m, 14 },
                    { 45, 2, 0, 450, 65.3472008224192m, 15 },
                    { 46, 2, 0, 840, 39.4604030876326m, 16 },
                    { 47, 2, 0, 680, 85.0104775972818m, 17 },
                    { 48, 2, 0, 860, 89.6276501765148m, 18 },
                    { 49, 2, 0, 150, 73.207785407705m, 19 },
                    { 50, 2, 0, 200, 83.1200106793024m, 20 },
                    { 51, 2, 0, 760, 15.9408564406842m, 21 },
                    { 52, 2, 0, 480, 4.45963040468205m, 22 },
                    { 53, 2, 0, 560, 34.2588671776671m, 23 },
                    { 54, 2, 0, 920, 84.0673139498663m, 24 },
                    { 55, 2, 0, 660, 25.7881025345224m, 25 },
                    { 56, 2, 0, 610, 75.2288141825356m, 26 },
                    { 57, 2, 0, 80, 84.9632813528241m, 27 },
                    { 58, 2, 0, 350, 64.3290017389791m, 28 },
                    { 59, 2, 0, 170, 26.4815868196772m, 29 },
                    { 60, 2, 0, 750, 99.6587134929553m, 30 },
                    { 61, 3, 0, 650, 95.1569144785706m, 1 },
                    { 62, 3, 0, 520, 64.8500763160391m, 2 },
                    { 63, 3, 0, 300, 9.91732181818612m, 3 },
                    { 64, 3, 0, 100, 53.7794421469491m, 4 },
                    { 65, 3, 0, 90, 76.2958384049613m, 5 },
                    { 66, 3, 0, 370, 53.9455397363506m, 6 },
                    { 67, 3, 0, 660, 59.8407777540681m, 7 },
                    { 68, 3, 0, 990, 17.9060327884263m, 8 },
                    { 69, 3, 0, 960, 19.190454173638m, 9 },
                    { 70, 3, 0, 590, 1.4234762077868m, 10 },
                    { 71, 3, 0, 590, 3.39007760005863m, 11 },
                    { 72, 3, 0, 180, 97.8043046375954m, 12 },
                    { 73, 3, 0, 440, 46.4848732079473m, 13 },
                    { 74, 3, 0, 500, 5.27668797325359m, 14 },
                    { 75, 3, 0, 670, 9.73862368617899m, 15 },
                    { 76, 3, 0, 600, 72.9583051277244m, 16 },
                    { 77, 3, 0, 330, 65.0546728832417m, 17 },
                    { 78, 3, 0, 30, 0.844995199775666m, 18 },
                    { 79, 3, 0, 80, 90.3874839080025m, 19 },
                    { 80, 3, 0, 460, 73.6986836785924m, 20 },
                    { 81, 3, 0, 380, 49.4326305659798m, 21 },
                    { 82, 3, 0, 600, 95.1029912729133m, 22 },
                    { 83, 3, 0, 660, 43.4530905186868m, 23 },
                    { 84, 3, 0, 890, 58.5479918786416m, 24 },
                    { 85, 3, 0, 650, 71.0972698814086m, 25 },
                    { 86, 3, 0, 850, 42.8953674085052m, 26 },
                    { 87, 3, 0, 110, 35.5192565957509m, 27 },
                    { 88, 3, 0, 200, 27.6503677444366m, 28 },
                    { 89, 3, 0, 240, 2.31121638563211m, 29 },
                    { 91, 3, 0, 910, 48.2681124642551m, 31 },
                    { 92, 3, 0, 730, 15.8605107768622m, 32 },
                    { 93, 3, 0, 330, 12.2254073830013m, 33 },
                    { 94, 4, 0, 170, 0.570264597643266m, 1 },
                    { 95, 4, 0, 320, 83.1814622791344m, 2 },
                    { 96, 4, 0, 0, 23.6319668241478m, 3 },
                    { 97, 4, 0, 250, 10.81936416721m, 4 },
                    { 98, 4, 0, 800, 71.9896195036536m, 5 },
                    { 99, 4, 0, 640, 33.8152176633508m, 6 },
                    { 100, 4, 0, 970, 42.2755075440892m, 7 },
                    { 101, 1, 0, 660, 4.11731764815978m, 31 },
                    { 102, 1, 0, 750, 25.8585261966528m, 32 },
                    { 103, 1, 0, 670, 70.2688957287865m, 33 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 3 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 3 for Chapter 4", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 18, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 20, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 21, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 22, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 23, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 24, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 25, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 27, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 28, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 3 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 3 for Chapter 12", "https://sadat.vip/" },
                    { 30, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 32, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 33, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 34, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 35, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 36, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 37, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 38, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 39, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 40, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 41, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 42, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 43, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 44, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 45, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 46, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 47, 20, "Content for Lesson 3 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 20", "https://sadat.vip/" },
                    { 48, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 49, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 50, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 51, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 52, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 53, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 54, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 55, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 56, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 57, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" }
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
