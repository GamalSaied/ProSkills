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
                    country = table.Column<int>(type: "int", nullable: false),
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
                    { 1, "24/05/2024 8:01:00 pm", "", false, "Revit" },
                    { 2, "24/05/2024 8:01:00 pm", "", false, "Sap" },
                    { 3, "24/05/2024 8:01:00 pm", "", false, "Etabs" },
                    { 4, "24/05/2024 8:01:00 pm", "", false, "Forge" },
                    { 5, "24/05/2024 8:01:00 pm", "", false, "primavera" },
                    { 6, "24/05/2024 8:01:00 pm", "", false, "wpf" },
                    { 7, "24/05/2024 8:01:00 pm", "", false, "Windows Form" },
                    { 8, "24/05/2024 8:01:00 pm", "", false, "NavisWorks" },
                    { 9, "24/05/2024 8:01:00 pm", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "24/05/2024 8:01:00 pm", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "24/05/2024 8:01:00 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "24/05/2024 8:01:00 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "24/05/2024 8:01:00 pm", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Phone", "country" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", "24/05/2024 8:01:00 pm", "Trainee1@example.com", false, "Trainee 1", "password1", null, null },
                    { 2, "Bio for Trainee 2", "24/05/2024 8:01:00 pm", "Trainee2@example.com", false, "Trainee 2", "password2", null, null },
                    { 3, "Bio for Trainee 3", "24/05/2024 8:01:00 pm", "Trainee3@example.com", false, "Trainee 3", "password3", null, null },
                    { 4, "Bio for Trainee 4", "24/05/2024 8:01:00 pm", "Trainee4@example.com", false, "Trainee 4", "password4", null, null },
                    { 5, "Bio for Trainee 5", "24/05/2024 8:01:00 pm", "Trainee5@example.com", false, "Trainee 5", "password5", null, null },
                    { 6, "Bio for Trainee 6", "24/05/2024 8:01:00 pm", "Trainee6@example.com", false, "Trainee 6", "password6", null, null },
                    { 7, "Bio for Trainee 7", "24/05/2024 8:01:00 pm", "Trainee7@example.com", false, "Trainee 7", "password7", null, null },
                    { 8, "Bio for Trainee 8", "24/05/2024 8:01:00 pm", "Trainee8@example.com", false, "Trainee 8", "password8", null, null },
                    { 9, "Bio for Trainee 9", "24/05/2024 8:01:00 pm", "Trainee9@example.com", false, "Trainee 9", "password9", null, null },
                    { 10, "Bio for Trainee 10", "24/05/2024 8:01:00 pm", "Trainee10@example.com", false, "Trainee 10", "password10", null, null },
                    { 11, "Bio for Trainee 11", "24/05/2024 8:01:00 pm", "Trainee11@example.com", false, "Trainee 11", "password11", null, null },
                    { 12, "Bio for Trainee 12", "24/05/2024 8:01:00 pm", "Trainee12@example.com", false, "Trainee 12", "password12", null, null },
                    { 13, "Bio for Trainee 13", "24/05/2024 8:01:00 pm", "Trainee13@example.com", false, "Trainee 13", "password13", null, null },
                    { 14, "Bio for Trainee 14", "24/05/2024 8:01:00 pm", "Trainee14@example.com", false, "Trainee 14", "password14", null, null },
                    { 15, "Bio for Trainee 15", "24/05/2024 8:01:00 pm", "Trainee15@example.com", false, "Trainee 15", "password15", null, null },
                    { 16, "Bio for Trainee 16", "24/05/2024 8:01:00 pm", "Trainee16@example.com", false, "Trainee 16", "password16", null, null },
                    { 17, "Bio for Trainee 17", "24/05/2024 8:01:00 pm", "Trainee17@example.com", false, "Trainee 17", "password17", null, null },
                    { 18, "Bio for Trainee 18", "24/05/2024 8:01:00 pm", "Trainee18@example.com", false, "Trainee 18", "password18", null, null },
                    { 19, "Bio for Trainee 19", "24/05/2024 8:01:00 pm", "Trainee19@example.com", false, "Trainee 19", "password19", null, null },
                    { 20, "Bio for Trainee 20", "24/05/2024 8:01:00 pm", "Trainee20@example.com", false, "Trainee 20", "password20", null, null },
                    { 21, "Bio for Trainee 21", "24/05/2024 8:01:00 pm", "Trainee21@example.com", false, "Trainee 21", "password21", null, null },
                    { 22, "Bio for Trainee 22", "24/05/2024 8:01:00 pm", "Trainee22@example.com", false, "Trainee 22", "password22", null, null },
                    { 23, "Bio for Trainee 23", "24/05/2024 8:01:00 pm", "Trainee23@example.com", false, "Trainee 23", "password23", null, null },
                    { 24, "Bio for Trainee 24", "24/05/2024 8:01:00 pm", "Trainee24@example.com", false, "Trainee 24", "password24", null, null },
                    { 25, "Bio for Trainee 25", "24/05/2024 8:01:00 pm", "Trainee25@example.com", false, "Trainee 25", "password25", null, null },
                    { 26, "Bio for Trainee 26", "24/05/2024 8:01:00 pm", "Trainee26@example.com", false, "Trainee 26", "password26", null, null },
                    { 27, "Bio for Trainee 27", "24/05/2024 8:01:00 pm", "Trainee27@example.com", false, "Trainee 27", "password27", null, null },
                    { 28, "Bio for Trainee 28", "24/05/2024 8:01:00 pm", "Trainee28@example.com", false, "Trainee 28", "password28", null, null },
                    { 29, "Bio for Trainee 29", "24/05/2024 8:01:00 pm", "Trainee29@example.com", false, "Trainee 29", "password29", null, null },
                    { 30, "Bio for Trainee 30", "24/05/2024 8:01:00 pm", "Trainee30@example.com", false, "Trainee 30", "password30", null, null }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "24/05/2024 8:01:00 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "24/05/2024 8:01:00 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "24/05/2024 8:01:00 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "24/05/2024 8:01:00 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "24/05/2024 8:01:00 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "24/05/2024 8:01:00 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "24/05/2024 8:01:00 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "24/05/2024 8:01:00 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "24/05/2024 8:01:00 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "24/05/2024 8:01:00 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "24/05/2024 8:01:00 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "24/05/2024 8:01:00 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "24/05/2024 8:01:00 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "24/05/2024 8:01:00 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "24/05/2024 8:01:00 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "24/05/2024 8:01:00 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "24/05/2024 8:01:00 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "24/05/2024 8:01:00 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "24/05/2024 8:01:00 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "24/05/2024 8:01:00 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "24/05/2024 8:01:00 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "24/05/2024 8:01:00 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "24/05/2024 8:01:00 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "24/05/2024 8:01:00 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "24/05/2024 8:01:00 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "24/05/2024 8:01:00 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "24/05/2024 8:01:00 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "24/05/2024 8:01:00 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "24/05/2024 8:01:00 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "24/05/2024 8:01:00 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 23, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(239), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 5, 31, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(236), 10.5, 10 },
                    { 2, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 8, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(280), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 7, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(279), 15.199999999999999, 10 },
                    { 3, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(292), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 29, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(290), 11.699999999999999, 12 },
                    { 4, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 23, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(303), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(302), 13.5, 4 },
                    { 5, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(322), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 5, 31, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(320), 14.1, 10 },
                    { 6, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 13, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(332), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 5, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(330), 12.300000000000001, 10 },
                    { 7, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 18, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(341), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 1, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(339), 12.800000000000001, 4 },
                    { 8, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(350), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 30, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(349), 13.199999999999999, 3 },
                    { 9, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(362), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 2, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(360), 10.800000000000001, 1 },
                    { 10, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 8, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(371), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 4, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(370), 12.199999999999999, 2 },
                    { 11, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 13, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(381), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 6, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(379), 13.5, 11 },
                    { 12, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(390), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(389), 13.1, 14 },
                    { 13, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(403), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 1, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(401), 10.6, 12 },
                    { 14, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 23, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(439), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 5, 31, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(437), 11.199999999999999, 9 },
                    { 15, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 8, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(449), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 7, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(448), 15.800000000000001, 6 },
                    { 16, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(458), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 29, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(457), 12.5, 5 },
                    { 17, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 13, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(470), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 5, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(469), 13.800000000000001, 9 },
                    { 18, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 18, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(480), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 1, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(478), 12.300000000000001, 3 },
                    { 19, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(489), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 30, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(487), 13.1, 12 },
                    { 20, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(498), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 2, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(497), 11.800000000000001, 9 },
                    { 21, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 8, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(509), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 4, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(508), 12.5, 2 },
                    { 22, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 13, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(519), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 6, 6, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(517), 13.199999999999999, 12 },
                    { 23, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(528), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 3, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(527), 13.6, 13 },
                    { 24, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(537), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 1, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(536), 10.9, 6 },
                    { 25, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 23, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(549), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 5, 31, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(548), 11.4, 4 },
                    { 26, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 8, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(559), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 7, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(557), 15.199999999999999, 13 },
                    { 27, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(568), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 29, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(566), 13.699999999999999, 4 },
                    { 28, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 13, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(577), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 5, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(575), 14.300000000000001, 10 },
                    { 29, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 18, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(589), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 1, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(588), 12.6, 15 },
                    { 30, "path/to/trainee/image.jpg", "24/05/2024 8:01:00 pm", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 28, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(599), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 30, 20, 1, 0, 398, DateTimeKind.Local).AddTicks(597), 13.9, 9 }
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
                    { 11, 4, "Description for Chapter 3 in Course 4", false, "Chapter 3 for Course 4", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 13, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 14, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 15, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 16, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 17, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 18, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 19, 7, "Description for Chapter 3 in Course 7", false, "Chapter 3 for Course 7", "https://sadat.vip/" },
                    { 20, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 21, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 22, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 23, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 24, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 25, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 26, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 23, 35.2973689537996m, 20 },
                    { 2, 6, 37.962911720922m, 9 },
                    { 3, 3, 55.8924684800173m, 16 },
                    { 4, 25, 50.3536109010528m, 16 },
                    { 5, 13, 97.7358332191715m, 16 },
                    { 6, 16, 51.5185712799195m, 4 },
                    { 7, 1, 90.3600980794526m, 25 },
                    { 8, 24, 28.000761272746m, 11 },
                    { 9, 6, 36.9501626205736m, 1 },
                    { 10, 15, 84.0909467642233m, 18 },
                    { 11, 16, 77.7393352396978m, 30 },
                    { 12, 8, 11.4018655138764m, 29 },
                    { 13, 9, 74.223502015529m, 8 },
                    { 14, 20, 35.3352396098571m, 7 },
                    { 15, 20, 50.0944888953863m, 18 },
                    { 16, 7, 75.851732850516m, 15 },
                    { 17, 29, 19.7448482576666m, 30 },
                    { 18, 1, 8.47433022192156m, 17 },
                    { 19, 11, 82.2382955266705m, 3 },
                    { 20, 18, 23.991358715824m, 16 },
                    { 21, 7, 14.2100542759988m, 24 },
                    { 22, 1, 6.1044423376773m, 3 },
                    { 23, 25, 21.3643687826592m, 11 },
                    { 24, 10, 1.63394489855619m, 23 },
                    { 25, 13, 50.5162701249501m, 11 },
                    { 26, 6, 49.3100927905601m, 22 },
                    { 27, 6, 93.8332254472405m, 17 },
                    { 28, 28, 74.8263793742908m, 29 },
                    { 29, 6, 22.5003130396912m, 10 },
                    { 30, 24, 26.3129159710678m, 26 },
                    { 31, 13, 57.2048442599923m, 27 },
                    { 32, 15, 29.799891009179m, 11 },
                    { 33, 24, 59.7850920737648m, 12 },
                    { 34, 16, 52.460803454652m, 10 },
                    { 35, 7, 4.65876674620954m, 29 },
                    { 36, 22, 38.7889646679986m, 26 },
                    { 37, 2, 3.10843284325005m, 12 },
                    { 38, 27, 22.2233040016405m, 15 },
                    { 39, 2, 10.6733358768689m, 1 },
                    { 40, 3, 28.2318440057016m, 8 },
                    { 41, 29, 28.9192151913994m, 5 },
                    { 42, 19, 82.4815940734864m, 20 },
                    { 43, 12, 52.0181440416403m, 22 },
                    { 44, 27, 32.6504290358177m, 2 },
                    { 45, 17, 14.8648853226329m, 25 },
                    { 46, 28, 16.8464145466145m, 3 },
                    { 47, 11, 97.2878370524035m, 5 },
                    { 48, 14, 35.155067444419m, 10 },
                    { 49, 5, 66.516463516028m, 16 },
                    { 50, 13, 78.7595452268808m, 10 },
                    { 51, 2, 54.808966782053m, 28 },
                    { 52, 11, 5.83995078192069m, 25 },
                    { 53, 24, 57.35598401358m, 1 },
                    { 54, 8, 32.942973541813m, 30 },
                    { 55, 6, 15.9512371812152m, 9 },
                    { 56, 9, 93.1687133426878m, 13 },
                    { 57, 15, 51.1521842642809m, 7 },
                    { 58, 19, 10.7348965838216m, 7 },
                    { 59, 2, 93.2701788681267m, 15 },
                    { 60, 16, 13.3129865672974m, 12 },
                    { 61, 16, 56.9858074223726m, 14 },
                    { 62, 18, 37.1256609698708m, 6 },
                    { 63, 27, 70.8071398861496m, 4 },
                    { 64, 21, 89.3162189764204m, 27 },
                    { 65, 1, 7.27508380005639m, 25 },
                    { 66, 14, 48.563376832387m, 14 },
                    { 67, 8, 36.3870630834707m, 26 },
                    { 68, 28, 6.54331408581984m, 8 },
                    { 69, 20, 94.2280238669323m, 1 },
                    { 70, 12, 72.7310883110175m, 26 },
                    { 71, 28, 76.6564186400664m, 20 },
                    { 72, 8, 13.658403776927m, 10 },
                    { 73, 6, 22.3522806578799m, 4 },
                    { 74, 29, 59.5471577079029m, 25 },
                    { 75, 23, 15.6154407489442m, 16 },
                    { 76, 5, 15.828502994686m, 15 },
                    { 77, 4, 23.7174183387206m, 1 },
                    { 78, 7, 59.6461457890036m, 14 },
                    { 79, 4, 99.667981034181m, 9 },
                    { 80, 1, 6.34482571266521m, 24 },
                    { 81, 30, 93.4778798265698m, 28 },
                    { 82, 1, 19.2586995721859m, 6 },
                    { 83, 21, 96.0157203946278m, 19 },
                    { 84, 9, 35.6325958100775m, 5 },
                    { 85, 21, 13.8909184645841m, 30 },
                    { 86, 24, 80.0513079416208m, 24 },
                    { 87, 8, 43.1494853343096m, 20 },
                    { 88, 10, 33.7520679185195m, 12 },
                    { 89, 27, 32.7933164465811m, 4 },
                    { 90, 1, 11.1318523643693m, 27 },
                    { 91, 11, 72.1046907397996m, 11 },
                    { 92, 30, 88.1728723051096m, 21 },
                    { 93, 4, 58.5800240663604m, 1 },
                    { 94, 23, 59.5125915744863m, 17 },
                    { 95, 8, 32.8370987309556m, 24 },
                    { 96, 16, 4.74385406912736m, 5 },
                    { 97, 10, 58.776889529845m, 16 },
                    { 98, 24, 43.1032926196967m, 27 },
                    { 99, 18, 85.716201104273m, 13 },
                    { 100, 29, 31.0436467543657m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 1", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 6, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 9, 3, "Content for Lesson 3 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 3", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 11, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 12, 4, "Content for Lesson 3 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 4", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 14, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 15, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 16, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 17, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 19, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 20, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 21, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 22, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 23, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 24, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 25, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 26, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 27, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 28, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 29, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 30, 11, "Content for Lesson 3 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" },
                    { 31, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 32, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 34, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 35, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 36, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 37, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 38, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 39, 15, "Content for Lesson 3 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 15", "https://sadat.vip/" },
                    { 40, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 41, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 42, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 43, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 44, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 45, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 46, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 47, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 3 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" },
                    { 49, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 50, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 51, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 52, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 53, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 54, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 55, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 56, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 57, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 59, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 60, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 61, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 62, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" },
                    { 64, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 65, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" }
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
