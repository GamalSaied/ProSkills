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
                    Result = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "20/06/2024 3:36:46 pm", "", false, "Revit" },
                    { 2, "20/06/2024 3:36:46 pm", "", false, "Sap" },
                    { 3, "20/06/2024 3:36:46 pm", "", false, "Etabs" },
                    { 4, "20/06/2024 3:36:46 pm", "", false, "Forge" },
                    { 5, "20/06/2024 3:36:46 pm", "", false, "primavera" },
                    { 6, "20/06/2024 3:36:46 pm", "", false, "wpf" },
                    { 7, "20/06/2024 3:36:46 pm", "", false, "Windows Form" },
                    { 8, "20/06/2024 3:36:46 pm", "", false, "NavisWorks" },
                    { 9, "20/06/2024 3:36:46 pm", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "20/06/2024 3:36:46 pm", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "20/06/2024 3:36:46 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "20/06/2024 3:36:46 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "20/06/2024 3:36:46 pm", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone", "ProfilePictureUrl" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "20/06/2024 3:36:46 pm", "Trainee1@example.com", false, "Trainee 1", null, "/themefront/img/user.jpg" },
                    { 2, "Bio for Trainee 2", null, "20/06/2024 3:36:46 pm", "Trainee2@example.com", false, "Trainee 2", null, "/themefront/img/user.jpg" },
                    { 3, "Bio for Trainee 3", null, "20/06/2024 3:36:46 pm", "Trainee3@example.com", false, "Trainee 3", null, "/themefront/img/user.jpg" },
                    { 4, "Bio for Trainee 4", null, "20/06/2024 3:36:46 pm", "Trainee4@example.com", false, "Trainee 4", null, "/themefront/img/user.jpg" },
                    { 5, "Bio for Trainee 5", null, "20/06/2024 3:36:46 pm", "Trainee5@example.com", false, "Trainee 5", null, "/themefront/img/user.jpg" },
                    { 6, "Bio for Trainee 6", null, "20/06/2024 3:36:46 pm", "Trainee6@example.com", false, "Trainee 6", null, "/themefront/img/user.jpg" },
                    { 7, "Bio for Trainee 7", null, "20/06/2024 3:36:46 pm", "Trainee7@example.com", false, "Trainee 7", null, "/themefront/img/user.jpg" },
                    { 8, "Bio for Trainee 8", null, "20/06/2024 3:36:46 pm", "Trainee8@example.com", false, "Trainee 8", null, "/themefront/img/user.jpg" },
                    { 9, "Bio for Trainee 9", null, "20/06/2024 3:36:46 pm", "Trainee9@example.com", false, "Trainee 9", null, "/themefront/img/user.jpg" },
                    { 10, "Bio for Trainee 10", null, "20/06/2024 3:36:46 pm", "Trainee10@example.com", false, "Trainee 10", null, "/themefront/img/user.jpg" },
                    { 11, "Bio for Trainee 11", null, "20/06/2024 3:36:46 pm", "Trainee11@example.com", false, "Trainee 11", null, "/themefront/img/user.jpg" },
                    { 12, "Bio for Trainee 12", null, "20/06/2024 3:36:46 pm", "Trainee12@example.com", false, "Trainee 12", null, "/themefront/img/user.jpg" },
                    { 13, "Bio for Trainee 13", null, "20/06/2024 3:36:46 pm", "Trainee13@example.com", false, "Trainee 13", null, "/themefront/img/user.jpg" },
                    { 14, "Bio for Trainee 14", null, "20/06/2024 3:36:46 pm", "Trainee14@example.com", false, "Trainee 14", null, "/themefront/img/user.jpg" },
                    { 15, "Bio for Trainee 15", null, "20/06/2024 3:36:46 pm", "Trainee15@example.com", false, "Trainee 15", null, "/themefront/img/user.jpg" },
                    { 16, "Bio for Trainee 16", null, "20/06/2024 3:36:46 pm", "Trainee16@example.com", false, "Trainee 16", null, "/themefront/img/user.jpg" },
                    { 17, "Bio for Trainee 17", null, "20/06/2024 3:36:46 pm", "Trainee17@example.com", false, "Trainee 17", null, "/themefront/img/user.jpg" },
                    { 18, "Bio for Trainee 18", null, "20/06/2024 3:36:46 pm", "Trainee18@example.com", false, "Trainee 18", null, "/themefront/img/user.jpg" },
                    { 19, "Bio for Trainee 19", null, "20/06/2024 3:36:46 pm", "Trainee19@example.com", false, "Trainee 19", null, "/themefront/img/user.jpg" },
                    { 20, "Bio for Trainee 20", null, "20/06/2024 3:36:46 pm", "Trainee20@example.com", false, "Trainee 20", null, "/themefront/img/user.jpg" },
                    { 21, "Bio for Trainee 21", null, "20/06/2024 3:36:46 pm", "Trainee21@example.com", false, "Trainee 21", null, "/themefront/img/user.jpg" },
                    { 22, "Bio for Trainee 22", null, "20/06/2024 3:36:46 pm", "Trainee22@example.com", false, "Trainee 22", null, "/themefront/img/user.jpg" },
                    { 23, "Bio for Trainee 23", null, "20/06/2024 3:36:46 pm", "Trainee23@example.com", false, "Trainee 23", null, "/themefront/img/user.jpg" },
                    { 24, "Bio for Trainee 24", null, "20/06/2024 3:36:46 pm", "Trainee24@example.com", false, "Trainee 24", null, "/themefront/img/user.jpg" },
                    { 25, "Bio for Trainee 25", null, "20/06/2024 3:36:46 pm", "Trainee25@example.com", false, "Trainee 25", null, "/themefront/img/user.jpg" },
                    { 26, "Bio for Trainee 26", null, "20/06/2024 3:36:46 pm", "Trainee26@example.com", false, "Trainee 26", null, "/themefront/img/user.jpg" },
                    { 27, "Bio for Trainee 27", null, "20/06/2024 3:36:46 pm", "Trainee27@example.com", false, "Trainee 27", null, "/themefront/img/user.jpg" },
                    { 28, "Bio for Trainee 28", null, "20/06/2024 3:36:46 pm", "Trainee28@example.com", false, "Trainee 28", null, "/themefront/img/user.jpg" },
                    { 30, "Bio for Trainee 30", null, "20/06/2024 3:36:46 pm", "Trainee30@example.com", false, "Trainee 30", null, "/themefront/img/user.jpg" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "20/06/2024 3:36:46 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "20/06/2024 3:36:46 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "20/06/2024 3:36:46 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "20/06/2024 3:36:46 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "20/06/2024 3:36:46 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "20/06/2024 3:36:46 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "20/06/2024 3:36:46 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "20/06/2024 3:36:46 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "20/06/2024 3:36:46 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "20/06/2024 3:36:46 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "20/06/2024 3:36:46 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "20/06/2024 3:36:46 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "20/06/2024 3:36:46 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "20/06/2024 3:36:46 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "20/06/2024 3:36:46 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "20/06/2024 3:36:46 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "20/06/2024 3:36:46 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "20/06/2024 3:36:46 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "20/06/2024 3:36:46 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "20/06/2024 3:36:46 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "20/06/2024 3:36:46 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "20/06/2024 3:36:46 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "20/06/2024 3:36:46 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "20/06/2024 3:36:46 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "20/06/2024 3:36:46 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "20/06/2024 3:36:46 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "20/06/2024 3:36:46 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "20/06/2024 3:36:46 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "20/06/2024 3:36:46 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "20/06/2024 3:36:46 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 7, 20, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3581), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 6, 27, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3577), 10.5, 14 },
                    { 2, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 8, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3633), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3631), 15.199999999999999, 2 },
                    { 3, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3643), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 6, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3642), 11.699999999999999, 13 },
                    { 4, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 8, 19, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3654), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3652), 13.5, 14 },
                    { 5, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3670), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 6, 27, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3669), 14.1, 9 },
                    { 6, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 8, 9, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3680), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 7, 2, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3679), 12.300000000000001, 7 },
                    { 7, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 8, 14, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3919), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 28, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3917), 12.800000000000001, 6 },
                    { 8, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers software engineering principles and best practices.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3930), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 6, 26, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3928), 13.199999999999999, 1 },
                    { 9, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3943), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 29, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3941), 10.800000000000001, 8 },
                    { 10, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 8, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3954), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 7, 1, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3952), 12.199999999999999, 9 },
                    { 11, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 8, 9, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3964), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 7, 3, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3962), 13.5, 6 },
                    { 12, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3974), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3973), 13.1, 10 },
                    { 13, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3987), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 28, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3985), 10.6, 4 },
                    { 14, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of mobile app development.", new DateTime(2024, 7, 20, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3998), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 6, 27, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(3996), 11.199999999999999, 4 },
                    { 15, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 8, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4008), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 7, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4006), 15.800000000000001, 10 },
                    { 16, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4019), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4017), 12.5, 15 },
                    { 17, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 8, 9, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4034), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 7, 2, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4032), 13.800000000000001, 4 },
                    { 18, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 8, 14, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4045), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 28, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4044), 12.300000000000001, 6 },
                    { 19, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers database concepts and technologies for developers.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4056), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 6, 26, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4054), 13.1, 9 },
                    { 20, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4066), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 29, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4065), 11.800000000000001, 3 },
                    { 21, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 8, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4080), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 7, 1, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4078), 12.5, 4 },
                    { 22, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of Ruby programming language.", new DateTime(2024, 8, 9, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4090), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 7, 3, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4089), 13.199999999999999, 5 },
                    { 23, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4101), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 30, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4100), 13.6, 15 },
                    { 24, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4113), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 28, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4111), 10.9, 14 },
                    { 25, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 7, 20, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4154), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 6, 27, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4153), 11.4, 14 },
                    { 26, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 8, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4167), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 4, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4165), 15.199999999999999, 11 },
                    { 27, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4177), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 6, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4175), 13.699999999999999, 1 },
                    { 28, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 8, 9, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4187), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 7, 2, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4186), 14.300000000000001, 15 },
                    { 29, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 8, 14, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4200), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 28, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4198), 12.6, 2 },
                    { 30, "path/to/trainee/image.jpg", "20/06/2024 3:36:46 pm", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 7, 25, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4210), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 26, 15, 36, 46, 32, DateTimeKind.Local).AddTicks(4209), 13.9, 6 }
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
                    { 16, 6, "Description for Chapter 3 in Course 6", false, "Chapter 3 for Course 6", "https://sadat.vip/" },
                    { 17, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 18, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 19, 7, "Description for Chapter 3 in Course 7", false, "Chapter 3 for Course 7", "https://sadat.vip/" },
                    { 20, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 21, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 22, 8, "Description for Chapter 3 in Course 8", false, "Chapter 3 for Course 8", "https://sadat.vip/" },
                    { 23, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 24, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 25, 9, "Description for Chapter 3 in Course 9", false, "Chapter 3 for Course 9", "https://sadat.vip/" },
                    { 26, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 27, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Level", "Points", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 13, 0, 0, 84.3286821115832m, 12 },
                    { 2, 23, 0, 0, 5.94424207505563m, 23 },
                    { 3, 9, 0, 0, 31.2888043613402m, 11 },
                    { 4, 6, 0, 0, 27.8709998509003m, 21 },
                    { 5, 17, 0, 0, 40.4594289313816m, 5 },
                    { 6, 22, 0, 0, 61.1453216991031m, 20 },
                    { 7, 15, 0, 0, 69.0794843362383m, 8 },
                    { 8, 4, 0, 0, 78.5079142801526m, 15 },
                    { 9, 28, 0, 0, 60.290464313247m, 26 },
                    { 10, 2, 0, 0, 2.27991107955361m, 4 },
                    { 11, 12, 0, 0, 46.05922356446m, 8 },
                    { 12, 3, 0, 0, 82.1883514435699m, 19 },
                    { 13, 12, 0, 0, 56.3601552920554m, 28 },
                    { 14, 19, 0, 0, 57.7834708508178m, 19 },
                    { 15, 17, 0, 0, 9.30973255034999m, 8 },
                    { 16, 23, 0, 0, 85.7308607054231m, 18 },
                    { 17, 9, 0, 0, 18.9817168447707m, 22 },
                    { 18, 9, 0, 0, 77.9416371138758m, 25 },
                    { 19, 9, 0, 0, 8.966105078336m, 3 },
                    { 20, 26, 0, 0, 26.2909886424944m, 7 },
                    { 21, 1, 0, 0, 94.4972298551224m, 9 },
                    { 22, 27, 0, 0, 99.6361945196924m, 6 },
                    { 23, 20, 0, 0, 81.946543249123m, 22 },
                    { 24, 27, 0, 0, 20.1898477315785m, 20 },
                    { 25, 23, 0, 0, 26.1939535725036m, 24 },
                    { 26, 1, 0, 0, 54.62402518617m, 12 },
                    { 27, 5, 0, 0, 12.1403494304738m, 15 },
                    { 28, 9, 0, 0, 62.6317319826292m, 18 },
                    { 29, 15, 0, 0, 14.8465247349597m, 1 },
                    { 30, 7, 0, 0, 30.7080662165329m, 15 },
                    { 31, 7, 0, 0, 64.1991665321051m, 24 },
                    { 32, 4, 0, 0, 72.3719554129165m, 10 },
                    { 33, 12, 0, 0, 91.2958639513704m, 24 },
                    { 34, 8, 0, 0, 94.9674744815258m, 15 },
                    { 35, 12, 0, 0, 72.9950183416757m, 2 },
                    { 36, 12, 0, 0, 29.1972619200275m, 20 },
                    { 37, 19, 0, 0, 16.4591967148688m, 7 },
                    { 38, 21, 0, 0, 12.0422584662967m, 18 },
                    { 39, 1, 0, 0, 66.3039382908145m, 9 },
                    { 40, 3, 0, 0, 40.2281226441122m, 17 },
                    { 41, 5, 0, 0, 91.9200554541452m, 25 },
                    { 42, 23, 0, 0, 84.2074828882212m, 1 },
                    { 43, 5, 0, 0, 34.8380254541285m, 14 },
                    { 44, 18, 0, 0, 2.9635911885913m, 8 },
                    { 45, 24, 0, 0, 5.49497679746753m, 9 },
                    { 46, 18, 0, 0, 64.6451531072753m, 19 },
                    { 47, 28, 0, 0, 15.9262155466029m, 19 },
                    { 48, 5, 0, 0, 45.5588967234694m, 28 },
                    { 49, 27, 0, 0, 58.7654894514766m, 7 },
                    { 50, 9, 0, 0, 6.4200429829535m, 6 },
                    { 51, 21, 0, 0, 29.2262837536282m, 7 },
                    { 52, 12, 0, 0, 14.3307649821803m, 7 },
                    { 53, 16, 0, 0, 70.066389351461m, 17 },
                    { 54, 16, 0, 0, 64.2153595506199m, 6 },
                    { 55, 26, 0, 0, 8.07394875473786m, 6 },
                    { 56, 18, 0, 0, 53.5079784467746m, 26 },
                    { 57, 22, 0, 0, 57.5764030331183m, 12 },
                    { 58, 14, 0, 0, 60.2096646681101m, 11 },
                    { 59, 13, 0, 0, 25.9068017731451m, 4 },
                    { 60, 3, 0, 0, 45.4138508012366m, 26 },
                    { 61, 17, 0, 0, 33.5641344110935m, 24 },
                    { 62, 6, 0, 0, 75.6656272691341m, 22 },
                    { 63, 13, 0, 0, 88.4249272095991m, 28 },
                    { 64, 7, 0, 0, 31.3414603471722m, 28 },
                    { 65, 22, 0, 0, 28.6481104290056m, 17 },
                    { 66, 16, 0, 0, 50.8628718311868m, 11 },
                    { 67, 27, 0, 0, 8.15002196983526m, 19 },
                    { 68, 23, 0, 0, 10.1734460192451m, 14 },
                    { 69, 13, 0, 0, 64.3752719674112m, 3 },
                    { 70, 2, 0, 0, 58.8123698380898m, 12 },
                    { 71, 3, 0, 0, 2.78365429584779m, 15 },
                    { 72, 4, 0, 0, 21.4617468451268m, 11 },
                    { 73, 3, 0, 0, 98.7887546303257m, 20 },
                    { 74, 1, 0, 0, 21.5680515037604m, 6 },
                    { 75, 21, 0, 0, 74.1481330894996m, 28 },
                    { 76, 10, 0, 0, 84.2726644412262m, 19 },
                    { 77, 13, 0, 0, 58.2610108505606m, 18 },
                    { 78, 5, 0, 0, 48.534709111643m, 19 },
                    { 79, 11, 0, 0, 31.1590520028883m, 20 },
                    { 80, 16, 0, 0, 31.5920107743796m, 13 },
                    { 81, 1, 0, 0, 58.118385172438m, 24 },
                    { 82, 8, 0, 0, 98.4553557607196m, 19 },
                    { 83, 9, 0, 0, 18.6630472009672m, 12 },
                    { 84, 7, 0, 0, 39.0601871051498m, 9 },
                    { 85, 6, 0, 0, 24.2789607679398m, 18 },
                    { 86, 1, 0, 0, 15.2595323727875m, 3 },
                    { 87, 2, 0, 0, 23.2013078504338m, 6 },
                    { 88, 12, 0, 0, 95.7719766157634m, 27 },
                    { 89, 15, 0, 0, 76.4785366857905m, 9 },
                    { 90, 11, 0, 0, 97.5035185855773m, 8 },
                    { 91, 13, 0, 0, 40.0930027326931m, 18 },
                    { 92, 14, 0, 0, 45.91956033606m, 27 },
                    { 93, 10, 0, 0, 82.8010109228632m, 3 },
                    { 94, 17, 0, 0, 99.699333904711m, 16 },
                    { 95, 27, 0, 0, 19.0096836651164m, 3 },
                    { 96, 4, 0, 0, 82.5694634276877m, 3 },
                    { 97, 22, 0, 0, 69.6319021070175m, 27 },
                    { 98, 10, 0, 0, 78.3917784948473m, 1 },
                    { 99, 21, 0, 0, 62.4691785801863m, 16 },
                    { 100, 23, 0, 0, 52.407292531749m, 16 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 1", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 6, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 13, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 15, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 18, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 20, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 21, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 22, 9, "Content for Lesson 3 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" },
                    { 23, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 24, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 3 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 28, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 3 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 12", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 32, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 34, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 35, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 36, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 37, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 38, 15, "Content for Lesson 3 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 15", "https://sadat.vip/" },
                    { 39, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 40, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 41, 16, "Content for Lesson 3 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 16", "https://sadat.vip/" },
                    { 42, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 43, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 44, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 45, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 46, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 47, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 49, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 50, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 51, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 52, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 53, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 54, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 55, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 56, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 57, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 59, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 60, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 62, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 64, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 65, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" },
                    { 66, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 67, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" },
                    { 68, 26, "Content for Lesson 3 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 3 for Chapter 26", "https://sadat.vip/" },
                    { 69, 27, "Content for Lesson 1 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 27", "https://sadat.vip/" },
                    { 70, 27, "Content for Lesson 2 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 27", "https://sadat.vip/" }
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
                name: "Category");

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
                name: "instructor");
        }
    }
}
