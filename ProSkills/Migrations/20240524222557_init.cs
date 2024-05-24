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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<int>(type: "int", nullable: false),
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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    country = table.Column<int>(type: "int", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: true),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "25/05/2024 01:25:57", "", false, "Revit" },
                    { 2, "25/05/2024 01:25:57", "", false, "Sap" },
                    { 3, "25/05/2024 01:25:57", "", false, "Etabs" },
                    { 4, "25/05/2024 01:25:57", "", false, "Forge" },
                    { 5, "25/05/2024 01:25:57", "", false, "primavera" },
                    { 6, "25/05/2024 01:25:57", "", false, "wpf" },
                    { 7, "25/05/2024 01:25:57", "", false, "Windows Form" },
                    { 8, "25/05/2024 01:25:57", "", false, "NavisWorks" },
                    { 9, "25/05/2024 01:25:57", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "25/05/2024 01:25:57", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "25/05/2024 01:25:57", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "25/05/2024 01:25:57", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "25/05/2024 01:25:57", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Phone", "country" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", "25/05/2024 01:25:57", "Trainee1@example.com", false, "Trainee 1", "password1", null, null },
                    { 2, "Bio for Trainee 2", "25/05/2024 01:25:57", "Trainee2@example.com", false, "Trainee 2", "password2", null, null },
                    { 3, "Bio for Trainee 3", "25/05/2024 01:25:57", "Trainee3@example.com", false, "Trainee 3", "password3", null, null },
                    { 4, "Bio for Trainee 4", "25/05/2024 01:25:57", "Trainee4@example.com", false, "Trainee 4", "password4", null, null },
                    { 5, "Bio for Trainee 5", "25/05/2024 01:25:57", "Trainee5@example.com", false, "Trainee 5", "password5", null, null },
                    { 6, "Bio for Trainee 6", "25/05/2024 01:25:57", "Trainee6@example.com", false, "Trainee 6", "password6", null, null },
                    { 7, "Bio for Trainee 7", "25/05/2024 01:25:57", "Trainee7@example.com", false, "Trainee 7", "password7", null, null },
                    { 8, "Bio for Trainee 8", "25/05/2024 01:25:57", "Trainee8@example.com", false, "Trainee 8", "password8", null, null },
                    { 9, "Bio for Trainee 9", "25/05/2024 01:25:57", "Trainee9@example.com", false, "Trainee 9", "password9", null, null },
                    { 10, "Bio for Trainee 10", "25/05/2024 01:25:57", "Trainee10@example.com", false, "Trainee 10", "password10", null, null },
                    { 11, "Bio for Trainee 11", "25/05/2024 01:25:57", "Trainee11@example.com", false, "Trainee 11", "password11", null, null },
                    { 12, "Bio for Trainee 12", "25/05/2024 01:25:57", "Trainee12@example.com", false, "Trainee 12", "password12", null, null },
                    { 13, "Bio for Trainee 13", "25/05/2024 01:25:57", "Trainee13@example.com", false, "Trainee 13", "password13", null, null },
                    { 14, "Bio for Trainee 14", "25/05/2024 01:25:57", "Trainee14@example.com", false, "Trainee 14", "password14", null, null },
                    { 15, "Bio for Trainee 15", "25/05/2024 01:25:57", "Trainee15@example.com", false, "Trainee 15", "password15", null, null },
                    { 16, "Bio for Trainee 16", "25/05/2024 01:25:57", "Trainee16@example.com", false, "Trainee 16", "password16", null, null },
                    { 17, "Bio for Trainee 17", "25/05/2024 01:25:57", "Trainee17@example.com", false, "Trainee 17", "password17", null, null },
                    { 18, "Bio for Trainee 18", "25/05/2024 01:25:57", "Trainee18@example.com", false, "Trainee 18", "password18", null, null },
                    { 19, "Bio for Trainee 19", "25/05/2024 01:25:57", "Trainee19@example.com", false, "Trainee 19", "password19", null, null },
                    { 20, "Bio for Trainee 20", "25/05/2024 01:25:57", "Trainee20@example.com", false, "Trainee 20", "password20", null, null },
                    { 21, "Bio for Trainee 21", "25/05/2024 01:25:57", "Trainee21@example.com", false, "Trainee 21", "password21", null, null },
                    { 22, "Bio for Trainee 22", "25/05/2024 01:25:57", "Trainee22@example.com", false, "Trainee 22", "password22", null, null },
                    { 23, "Bio for Trainee 23", "25/05/2024 01:25:57", "Trainee23@example.com", false, "Trainee 23", "password23", null, null },
                    { 24, "Bio for Trainee 24", "25/05/2024 01:25:57", "Trainee24@example.com", false, "Trainee 24", "password24", null, null },
                    { 25, "Bio for Trainee 25", "25/05/2024 01:25:57", "Trainee25@example.com", false, "Trainee 25", "password25", null, null },
                    { 26, "Bio for Trainee 26", "25/05/2024 01:25:57", "Trainee26@example.com", false, "Trainee 26", "password26", null, null },
                    { 27, "Bio for Trainee 27", "25/05/2024 01:25:57", "Trainee27@example.com", false, "Trainee 27", "password27", null, null },
                    { 28, "Bio for Trainee 28", "25/05/2024 01:25:57", "Trainee28@example.com", false, "Trainee 28", "password28", null, null },
                    { 30, "Bio for Trainee 30", "25/05/2024 01:25:57", "Trainee30@example.com", false, "Trainee 30", "password30", null, null }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "25/05/2024 01:25:57", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "25/05/2024 01:25:57", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "25/05/2024 01:25:57", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "25/05/2024 01:25:57", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "25/05/2024 01:25:57", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "25/05/2024 01:25:57", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "25/05/2024 01:25:57", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "25/05/2024 01:25:57", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "25/05/2024 01:25:57", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "25/05/2024 01:25:57", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "25/05/2024 01:25:57", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "25/05/2024 01:25:57", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "25/05/2024 01:25:57", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "25/05/2024 01:25:57", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "25/05/2024 01:25:57", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "25/05/2024 01:25:57", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "25/05/2024 01:25:57", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "25/05/2024 01:25:57", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "25/05/2024 01:25:57", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "25/05/2024 01:25:57", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "25/05/2024 01:25:57", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "25/05/2024 01:25:57", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "25/05/2024 01:25:57", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "25/05/2024 01:25:57", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "25/05/2024 01:25:57", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "25/05/2024 01:25:57", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "25/05/2024 01:25:57", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "25/05/2024 01:25:57", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "25/05/2024 01:25:57", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "25/05/2024 01:25:57", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 24, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(4841), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 6, 1, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(4836), 10.5, 10 },
                    { 2, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 9, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5003), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 8, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(4999), 15.199999999999999, 14 },
                    { 3, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5019), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 30, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5017), 11.699999999999999, 9 },
                    { 4, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 24, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5035), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5032), 13.5, 10 },
                    { 5, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5047), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 6, 1, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5045), 14.1, 5 },
                    { 6, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 14, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5064), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 6, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5062), 12.300000000000001, 15 },
                    { 7, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 19, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5078), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 2, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5076), 12.800000000000001, 7 },
                    { 8, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5091), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 31, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5089), 13.199999999999999, 10 },
                    { 9, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5104), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 3, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5102), 10.800000000000001, 15 },
                    { 10, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 9, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5119), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 5, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5117), 12.199999999999999, 12 },
                    { 11, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 14, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5133), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 7, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5131), 13.5, 11 },
                    { 12, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5146), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5144), 13.1, 6 },
                    { 13, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5158), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 2, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5156), 10.6, 1 },
                    { 14, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 24, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5173), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 6, 1, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5171), 11.199999999999999, 5 },
                    { 15, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 9, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5187), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 8, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5185), 15.800000000000001, 3 },
                    { 16, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5201), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 30, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5199), 12.5, 6 },
                    { 17, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 14, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5214), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 6, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5212), 13.800000000000001, 14 },
                    { 18, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 19, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5229), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 2, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5227), 12.300000000000001, 14 },
                    { 19, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5242), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 31, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5240), 13.1, 5 },
                    { 20, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5255), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 3, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5253), 11.800000000000001, 10 },
                    { 21, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 9, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5268), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 5, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5266), 12.5, 6 },
                    { 22, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 14, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5283), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 6, 7, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5281), 13.199999999999999, 10 },
                    { 23, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5295), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 4, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5293), 13.6, 4 },
                    { 24, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5308), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 2, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5306), 10.9, 14 },
                    { 25, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 24, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5321), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 6, 1, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5319), 11.4, 1 },
                    { 26, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 9, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5387), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 8, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5385), 15.199999999999999, 15 },
                    { 27, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5402), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 30, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5400), 13.699999999999999, 15 },
                    { 28, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 14, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5415), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 6, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5413), 14.300000000000001, 12 },
                    { 29, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 19, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5428), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 2, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5426), 12.6, 10 },
                    { 30, "path/to/trainee/image.jpg", "25/05/2024 01:25:57", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 29, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5444), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 31, 1, 25, 57, 94, DateTimeKind.Local).AddTicks(5442), 13.9, 5 }
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
                    { 5, 2, "Description for Chapter 3 in Course 2", false, "Chapter 3 for Course 2", "https://sadat.vip/" },
                    { 6, 3, "Description for Chapter 1 in Course 3", false, "Chapter 1 for Course 3", "https://sadat.vip/" },
                    { 7, 3, "Description for Chapter 2 in Course 3", false, "Chapter 2 for Course 3", "https://sadat.vip/" },
                    { 8, 3, "Description for Chapter 3 in Course 3", false, "Chapter 3 for Course 3", "https://sadat.vip/" },
                    { 9, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 10, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 11, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 13, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 14, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 15, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 16, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 17, 7, "Description for Chapter 3 in Course 7", false, "Chapter 3 for Course 7", "https://sadat.vip/" },
                    { 18, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 19, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 20, 8, "Description for Chapter 3 in Course 8", false, "Chapter 3 for Course 8", "https://sadat.vip/" },
                    { 21, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 22, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 23, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 24, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 15, 72.3461953613911m, 25 },
                    { 2, 26, 26.8518939358923m, 14 },
                    { 3, 16, 9.62349902963819m, 11 },
                    { 4, 9, 46.5989224267001m, 5 },
                    { 5, 24, 93.0640282798149m, 13 },
                    { 6, 12, 77.2052073024581m, 24 },
                    { 7, 9, 27.1202239922275m, 14 },
                    { 8, 4, 0.391688041019356m, 25 },
                    { 9, 15, 59.364878370332m, 26 },
                    { 10, 22, 13.1549979932599m, 5 },
                    { 11, 15, 52.9412964800806m, 25 },
                    { 12, 3, 9.43368901091168m, 20 },
                    { 13, 3, 49.2028560688116m, 25 },
                    { 14, 27, 49.9000348846289m, 17 },
                    { 15, 28, 54.5129077056902m, 14 },
                    { 16, 22, 69.5269428670641m, 1 },
                    { 17, 5, 50.1620713456995m, 19 },
                    { 18, 10, 40.2214890970509m, 17 },
                    { 19, 10, 98.0052420824706m, 2 },
                    { 20, 13, 18.8024342862071m, 16 },
                    { 21, 27, 26.6831846468413m, 8 },
                    { 22, 26, 83.203553290953m, 19 },
                    { 23, 7, 9.09322831886079m, 17 },
                    { 24, 15, 76.7301271477417m, 15 },
                    { 25, 22, 0.744674128108158m, 27 },
                    { 26, 19, 94.5599213437474m, 26 },
                    { 27, 3, 66.2262161790768m, 22 },
                    { 28, 18, 3.12231904476673m, 21 },
                    { 29, 22, 17.2846674279799m, 6 },
                    { 30, 10, 18.4935840244243m, 3 },
                    { 31, 20, 5.29007420262336m, 23 },
                    { 32, 9, 25.3976560797253m, 14 },
                    { 33, 27, 96.6750873952545m, 6 },
                    { 34, 27, 28.1988983319502m, 24 },
                    { 35, 14, 44.1066373637788m, 1 },
                    { 36, 5, 10.0703839713029m, 20 },
                    { 37, 17, 57.82494863902m, 9 },
                    { 38, 21, 48.8085884657611m, 19 },
                    { 39, 9, 58.3649652242467m, 5 },
                    { 40, 27, 97.0456553343353m, 19 },
                    { 41, 13, 0.201951784196297m, 5 },
                    { 42, 11, 75.8295331057545m, 26 },
                    { 43, 24, 89.724240407774m, 28 },
                    { 44, 15, 17.7229243647448m, 10 },
                    { 45, 7, 27.0355538431206m, 23 },
                    { 46, 23, 35.5541886460892m, 23 },
                    { 47, 12, 48.8798960519306m, 17 },
                    { 48, 24, 2.82847080658042m, 19 },
                    { 49, 1, 12.1120490770934m, 10 },
                    { 50, 17, 27.005385493625m, 11 },
                    { 51, 26, 20.4189898500425m, 6 },
                    { 52, 12, 60.589107914037m, 9 },
                    { 53, 13, 22.6398890001136m, 9 },
                    { 54, 15, 71.3928795061538m, 28 },
                    { 55, 26, 26.2693603705498m, 22 },
                    { 56, 25, 62.9828644912632m, 11 },
                    { 57, 1, 36.9613996495277m, 21 },
                    { 58, 24, 10.2547862438542m, 21 },
                    { 59, 6, 51.8715864071559m, 19 },
                    { 60, 15, 59.2971321070686m, 11 },
                    { 61, 7, 26.4475562180244m, 19 },
                    { 62, 11, 9.25939272178162m, 11 },
                    { 63, 9, 9.43893857577824m, 11 },
                    { 64, 28, 11.9157004475332m, 20 },
                    { 65, 18, 81.1850456846478m, 10 },
                    { 66, 11, 41.9985123299692m, 9 },
                    { 67, 23, 5.19229177036749m, 9 },
                    { 68, 9, 58.0448275383842m, 19 },
                    { 69, 4, 69.3548101687114m, 28 },
                    { 70, 17, 14.4224662325552m, 27 },
                    { 71, 26, 33.2564195530562m, 10 },
                    { 72, 28, 45.034048368313m, 26 },
                    { 73, 6, 35.0321769691799m, 24 },
                    { 74, 7, 2.66884781364607m, 10 },
                    { 75, 18, 94.319433981052m, 15 },
                    { 76, 17, 59.3138851630591m, 20 },
                    { 77, 27, 62.5773227925346m, 13 },
                    { 78, 24, 55.8509769167982m, 15 },
                    { 79, 26, 49.029530705118m, 27 },
                    { 80, 12, 92.9774426754402m, 28 },
                    { 81, 19, 77.1747706426241m, 18 },
                    { 82, 23, 56.3074426735291m, 24 },
                    { 83, 5, 26.6099068494253m, 16 },
                    { 84, 1, 65.060547596487m, 12 },
                    { 85, 11, 73.4333803470673m, 12 },
                    { 86, 10, 80.1873983688856m, 19 },
                    { 87, 15, 45.7304875220583m, 27 },
                    { 88, 7, 94.8900357790812m, 20 },
                    { 89, 17, 77.1824969818751m, 19 },
                    { 90, 25, 26.1069271329407m, 28 },
                    { 91, 2, 75.1557735969254m, 21 },
                    { 92, 2, 52.7556521173317m, 24 },
                    { 93, 25, 5.10360576118656m, 21 },
                    { 94, 8, 43.0063694863772m, 13 },
                    { 95, 21, 26.0806654661228m, 24 },
                    { 96, 24, 46.500179159404m, 7 },
                    { 97, 17, 53.5452796507048m, 9 },
                    { 98, 7, 53.8190225132151m, 20 },
                    { 99, 18, 32.9935683617477m, 18 },
                    { 100, 5, 78.7069209039549m, 19 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 1", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 3 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 3", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 11, 4, "Content for Lesson 3 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 4", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 20, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 21, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 22, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 23, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 24, 9, "Content for Lesson 3 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 26, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 28, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 31, 12, "Content for Lesson 3 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 12", "https://sadat.vip/" },
                    { 32, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 34, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 35, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 36, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 37, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 38, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 39, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 40, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 41, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 42, 16, "Content for Lesson 3 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 16", "https://sadat.vip/" },
                    { 43, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 44, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 45, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 46, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 47, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 48, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 49, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 50, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 51, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 52, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 53, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 54, 20, "Content for Lesson 3 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 3 for Chapter 20", "https://sadat.vip/" },
                    { 55, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 56, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 57, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 58, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 59, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 60, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 61, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 62, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 63, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" }
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
                name: "Lessons");

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
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
