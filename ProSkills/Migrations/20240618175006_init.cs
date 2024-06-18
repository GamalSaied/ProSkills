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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<int>(type: "int", nullable: true),
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
                    { 1, "18/06/2024 8:50:06 pm", "", false, "Revit" },
                    { 2, "18/06/2024 8:50:06 pm", "", false, "Sap" },
                    { 3, "18/06/2024 8:50:06 pm", "", false, "Etabs" },
                    { 4, "18/06/2024 8:50:06 pm", "", false, "Forge" },
                    { 5, "18/06/2024 8:50:06 pm", "", false, "primavera" },
                    { 6, "18/06/2024 8:50:06 pm", "", false, "wpf" },
                    { 7, "18/06/2024 8:50:06 pm", "", false, "Windows Form" },
                    { 8, "18/06/2024 8:50:06 pm", "", false, "NavisWorks" },
                    { 9, "18/06/2024 8:50:06 pm", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "18/06/2024 8:50:06 pm", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "18/06/2024 8:50:06 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "18/06/2024 8:50:06 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "18/06/2024 8:50:06 pm", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "18/06/2024 8:50:06 pm", "Trainee1@example.com", false, "Trainee 1", null },
                    { 2, "Bio for Trainee 2", null, "18/06/2024 8:50:06 pm", "Trainee2@example.com", false, "Trainee 2", null },
                    { 3, "Bio for Trainee 3", null, "18/06/2024 8:50:06 pm", "Trainee3@example.com", false, "Trainee 3", null },
                    { 4, "Bio for Trainee 4", null, "18/06/2024 8:50:06 pm", "Trainee4@example.com", false, "Trainee 4", null },
                    { 5, "Bio for Trainee 5", null, "18/06/2024 8:50:06 pm", "Trainee5@example.com", false, "Trainee 5", null },
                    { 6, "Bio for Trainee 6", null, "18/06/2024 8:50:06 pm", "Trainee6@example.com", false, "Trainee 6", null },
                    { 7, "Bio for Trainee 7", null, "18/06/2024 8:50:06 pm", "Trainee7@example.com", false, "Trainee 7", null },
                    { 8, "Bio for Trainee 8", null, "18/06/2024 8:50:06 pm", "Trainee8@example.com", false, "Trainee 8", null },
                    { 9, "Bio for Trainee 9", null, "18/06/2024 8:50:06 pm", "Trainee9@example.com", false, "Trainee 9", null },
                    { 10, "Bio for Trainee 10", null, "18/06/2024 8:50:06 pm", "Trainee10@example.com", false, "Trainee 10", null },
                    { 11, "Bio for Trainee 11", null, "18/06/2024 8:50:06 pm", "Trainee11@example.com", false, "Trainee 11", null },
                    { 12, "Bio for Trainee 12", null, "18/06/2024 8:50:06 pm", "Trainee12@example.com", false, "Trainee 12", null },
                    { 13, "Bio for Trainee 13", null, "18/06/2024 8:50:06 pm", "Trainee13@example.com", false, "Trainee 13", null },
                    { 14, "Bio for Trainee 14", null, "18/06/2024 8:50:06 pm", "Trainee14@example.com", false, "Trainee 14", null },
                    { 15, "Bio for Trainee 15", null, "18/06/2024 8:50:06 pm", "Trainee15@example.com", false, "Trainee 15", null },
                    { 16, "Bio for Trainee 16", null, "18/06/2024 8:50:06 pm", "Trainee16@example.com", false, "Trainee 16", null },
                    { 17, "Bio for Trainee 17", null, "18/06/2024 8:50:06 pm", "Trainee17@example.com", false, "Trainee 17", null },
                    { 18, "Bio for Trainee 18", null, "18/06/2024 8:50:06 pm", "Trainee18@example.com", false, "Trainee 18", null },
                    { 19, "Bio for Trainee 19", null, "18/06/2024 8:50:06 pm", "Trainee19@example.com", false, "Trainee 19", null },
                    { 20, "Bio for Trainee 20", null, "18/06/2024 8:50:06 pm", "Trainee20@example.com", false, "Trainee 20", null },
                    { 21, "Bio for Trainee 21", null, "18/06/2024 8:50:06 pm", "Trainee21@example.com", false, "Trainee 21", null },
                    { 22, "Bio for Trainee 22", null, "18/06/2024 8:50:06 pm", "Trainee22@example.com", false, "Trainee 22", null },
                    { 23, "Bio for Trainee 23", null, "18/06/2024 8:50:06 pm", "Trainee23@example.com", false, "Trainee 23", null },
                    { 24, "Bio for Trainee 24", null, "18/06/2024 8:50:06 pm", "Trainee24@example.com", false, "Trainee 24", null },
                    { 25, "Bio for Trainee 25", null, "18/06/2024 8:50:06 pm", "Trainee25@example.com", false, "Trainee 25", null },
                    { 26, "Bio for Trainee 26", null, "18/06/2024 8:50:06 pm", "Trainee26@example.com", false, "Trainee 26", null },
                    { 27, "Bio for Trainee 27", null, "18/06/2024 8:50:06 pm", "Trainee27@example.com", false, "Trainee 27", null },
                    { 28, "Bio for Trainee 28", null, "18/06/2024 8:50:06 pm", "Trainee28@example.com", false, "Trainee 28", null },
                    { 30, "Bio for Trainee 30", null, "18/06/2024 8:50:06 pm", "Trainee30@example.com", false, "Trainee 30", null }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "18/06/2024 8:50:06 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "18/06/2024 8:50:06 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "18/06/2024 8:50:06 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "18/06/2024 8:50:06 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "18/06/2024 8:50:06 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "18/06/2024 8:50:06 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "18/06/2024 8:50:06 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "18/06/2024 8:50:06 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "18/06/2024 8:50:06 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "18/06/2024 8:50:06 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "18/06/2024 8:50:06 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "18/06/2024 8:50:06 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "18/06/2024 8:50:06 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "18/06/2024 8:50:06 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "18/06/2024 8:50:06 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "18/06/2024 8:50:06 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "18/06/2024 8:50:06 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "18/06/2024 8:50:06 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "18/06/2024 8:50:06 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "18/06/2024 8:50:06 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "18/06/2024 8:50:06 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "18/06/2024 8:50:06 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "18/06/2024 8:50:06 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "18/06/2024 8:50:06 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "18/06/2024 8:50:06 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "18/06/2024 8:50:06 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "18/06/2024 8:50:06 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "18/06/2024 8:50:06 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "18/06/2024 8:50:06 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "18/06/2024 8:50:06 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6860), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6854), 10.5, 13 },
                    { 2, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6939), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6938), 15.199999999999999, 11 },
                    { 3, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6950), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6949), 11.699999999999999, 12 },
                    { 4, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 8, 17, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6961), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6959), 13.5, 14 },
                    { 5, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6991), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6989), 14.1, 5 },
                    { 6, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7059), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7057), 12.300000000000001, 9 },
                    { 7, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7071), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7070), 12.800000000000001, 13 },
                    { 8, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers software engineering principles and best practices.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7081), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7079), 13.199999999999999, 7 },
                    { 9, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7095), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 27, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7093), 10.800000000000001, 13 },
                    { 10, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7104), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 29, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7103), 12.199999999999999, 3 },
                    { 11, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7114), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 7, 1, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7113), 13.5, 10 },
                    { 12, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7126), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7124), 13.1, 14 },
                    { 13, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7138), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7137), 10.6, 2 },
                    { 14, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of mobile app development.", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7149), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7147), 11.199999999999999, 5 },
                    { 15, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7159), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7157), 15.800000000000001, 13 },
                    { 16, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7168), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7167), 12.5, 7 },
                    { 17, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7181), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7179), 13.800000000000001, 14 },
                    { 18, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7190), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7189), 12.300000000000001, 11 },
                    { 19, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers database concepts and technologies for developers.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7201), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7200), 13.1, 7 },
                    { 20, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7211), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 27, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7210), 11.800000000000001, 2 },
                    { 21, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7223), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 29, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7222), 12.5, 12 },
                    { 22, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of Ruby programming language.", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7234), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 7, 1, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7233), 13.199999999999999, 9 },
                    { 23, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7244), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7242), 13.6, 4 },
                    { 24, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7253), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7252), 10.9, 10 },
                    { 25, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7265), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7264), 11.4, 8 },
                    { 26, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7275), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7274), 15.199999999999999, 5 },
                    { 27, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7285), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7284), 13.699999999999999, 15 },
                    { 28, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7295), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7293), 14.300000000000001, 4 },
                    { 29, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7307), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7305), 12.6, 15 },
                    { 30, "path/to/trainee/image.jpg", "18/06/2024 8:50:06 pm", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7341), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7339), 13.9, 13 }
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
                    { 11, 4, "Description for Chapter 3 in Course 4", false, "Chapter 3 for Course 4", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 13, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 14, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 15, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 16, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 17, 6, "Description for Chapter 3 in Course 6", false, "Chapter 3 for Course 6", "https://sadat.vip/" },
                    { 18, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 19, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 20, 7, "Description for Chapter 3 in Course 7", false, "Chapter 3 for Course 7", "https://sadat.vip/" },
                    { 21, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 22, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 23, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 24, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 25, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 26, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 27, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 10, 29.2304573496523m, 2 },
                    { 2, 16, 77.2584920286288m, 25 },
                    { 3, 1, 30.370489916487m, 24 },
                    { 4, 21, 78.4444540462476m, 23 },
                    { 5, 23, 33.4262016275631m, 5 },
                    { 6, 11, 43.0587710759161m, 6 },
                    { 7, 24, 74.1857275102714m, 15 },
                    { 8, 8, 33.2940037729702m, 7 },
                    { 9, 21, 4.22994460973907m, 23 },
                    { 10, 7, 87.5739786098969m, 26 },
                    { 11, 16, 97.8100440729288m, 9 },
                    { 12, 9, 72.838044321346m, 3 },
                    { 13, 18, 71.9304899876743m, 12 },
                    { 14, 15, 7.9414219962881m, 24 },
                    { 15, 12, 41.2642863555616m, 8 },
                    { 16, 14, 65.7306229426696m, 2 },
                    { 17, 2, 76.0004226418612m, 15 },
                    { 18, 4, 46.1360176492361m, 21 },
                    { 19, 9, 76.6667116115545m, 10 },
                    { 20, 12, 15.1330080911454m, 22 },
                    { 21, 18, 88.2671207345284m, 16 },
                    { 22, 9, 2.31945557192116m, 28 },
                    { 23, 16, 51.6792645524333m, 28 },
                    { 24, 1, 88.3343339440619m, 2 },
                    { 25, 7, 33.1965991079281m, 18 },
                    { 26, 12, 10.9616368364859m, 13 },
                    { 27, 26, 89.7133783862609m, 24 },
                    { 28, 23, 32.4478723557431m, 18 },
                    { 29, 11, 56.8432986838991m, 11 },
                    { 30, 5, 36.3655885760552m, 1 },
                    { 31, 3, 55.2623086623332m, 22 },
                    { 32, 8, 81.8030138895135m, 27 },
                    { 33, 13, 53.5295813442613m, 11 },
                    { 34, 17, 71.8643230490201m, 13 },
                    { 35, 5, 95.1055157326602m, 24 },
                    { 36, 26, 76.80160774419m, 1 },
                    { 37, 4, 24.4227137604087m, 5 },
                    { 38, 4, 23.7847618401718m, 23 },
                    { 39, 21, 16.8855530839768m, 16 },
                    { 40, 6, 65.1895166769946m, 2 },
                    { 41, 28, 58.0177519038646m, 12 },
                    { 42, 2, 53.7821274426613m, 6 },
                    { 43, 26, 48.0640888305352m, 10 },
                    { 44, 9, 56.6807163012449m, 22 },
                    { 45, 10, 7.84023593211273m, 15 },
                    { 46, 19, 49.3508347225977m, 6 },
                    { 47, 12, 9.97614833374555m, 8 },
                    { 48, 3, 96.0082138988742m, 27 },
                    { 49, 3, 95.4655910908143m, 4 },
                    { 50, 13, 5.33144458353526m, 5 },
                    { 51, 4, 99.2717944752473m, 10 },
                    { 52, 27, 72.8460600047835m, 16 },
                    { 53, 12, 16.1478527224918m, 23 },
                    { 54, 20, 78.6383658243015m, 17 },
                    { 55, 19, 98.3909298749875m, 17 },
                    { 56, 18, 94.1970615886748m, 24 },
                    { 57, 7, 13.6162401594429m, 28 },
                    { 58, 23, 94.1073971262043m, 28 },
                    { 59, 12, 13.1730171219851m, 14 },
                    { 60, 20, 60.9081786306074m, 4 },
                    { 61, 16, 38.7846678355564m, 6 },
                    { 62, 3, 29.3997424164213m, 2 },
                    { 63, 14, 99.6902751787141m, 26 },
                    { 64, 2, 86.978063638781m, 15 },
                    { 65, 14, 55.1067722565041m, 21 },
                    { 66, 5, 79.9680659687628m, 16 },
                    { 67, 16, 5.97867456661884m, 28 },
                    { 68, 21, 95.5753604905131m, 28 },
                    { 69, 19, 61.6894892245441m, 9 },
                    { 70, 21, 18.7719521394621m, 24 },
                    { 71, 25, 62.9007877276497m, 26 },
                    { 72, 12, 26.0531097937538m, 16 },
                    { 73, 24, 63.3114648684706m, 17 },
                    { 74, 23, 5.0528100682095m, 28 },
                    { 75, 23, 50.8740259751658m, 6 },
                    { 76, 13, 10.5617015579769m, 23 },
                    { 77, 12, 95.0568516475796m, 17 },
                    { 78, 5, 37.2286345368669m, 13 },
                    { 79, 12, 37.3981599358652m, 10 },
                    { 80, 23, 51.7923149368271m, 28 },
                    { 81, 25, 72.5115340704126m, 12 },
                    { 82, 17, 47.883858935825m, 11 },
                    { 83, 12, 38.2633671949684m, 12 },
                    { 84, 11, 14.4632269088425m, 3 },
                    { 85, 2, 45.1971950276224m, 4 },
                    { 86, 5, 2.43867486193614m, 25 },
                    { 87, 24, 82.657390171702m, 21 },
                    { 88, 19, 34.4831387629028m, 23 },
                    { 89, 22, 63.0228003912307m, 2 },
                    { 90, 15, 40.8139255876849m, 4 },
                    { 91, 4, 2.70953881374156m, 3 },
                    { 92, 15, 27.0603348081718m, 7 },
                    { 93, 6, 62.9742825104302m, 5 },
                    { 94, 12, 17.0069968859174m, 16 },
                    { 95, 5, 58.5191829139555m, 16 },
                    { 96, 4, 66.5464366058894m, 9 },
                    { 97, 2, 48.6837129096466m, 1 },
                    { 98, 5, 69.5296989739603m, 12 },
                    { 99, 28, 35.1511211326402m, 19 },
                    { 100, 23, 29.0615342552484m, 22 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 1", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 6, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 8, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 10, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 13, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 16, 6, "Content for Lesson 3 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 6", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 19, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 20, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 21, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 22, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 23, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 24, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 25, 9, "Content for Lesson 3 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" },
                    { 26, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 27, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 28, 10, "Content for Lesson 3 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" },
                    { 29, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 30, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 31, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 32, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 33, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 34, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 35, 13, "Content for Lesson 3 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 13", "https://sadat.vip/" },
                    { 36, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 37, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 38, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 39, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 40, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 41, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 42, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 43, 16, "Content for Lesson 3 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 16", "https://sadat.vip/" },
                    { 44, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 45, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 46, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 47, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 49, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 50, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 51, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 52, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 53, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 54, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 55, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 56, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 57, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 59, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 60, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 62, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 63, 24, "Content for Lesson 3 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 24", "https://sadat.vip/" },
                    { 64, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 65, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 66, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" },
                    { 67, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 68, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" },
                    { 69, 27, "Content for Lesson 1 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 27", "https://sadat.vip/" },
                    { 70, 27, "Content for Lesson 2 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 27", "https://sadat.vip/" }
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
