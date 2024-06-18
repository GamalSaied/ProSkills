using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class newStart : Migration
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
                    { 1, "25/05/2024 11:52:02 م", "", false, "Revit" },
                    { 2, "25/05/2024 11:52:02 م", "", false, "Sap" },
                    { 3, "25/05/2024 11:52:02 م", "", false, "Etabs" },
                    { 4, "25/05/2024 11:52:02 م", "", false, "Forge" },
                    { 5, "25/05/2024 11:52:02 م", "", false, "primavera" },
                    { 6, "25/05/2024 11:52:02 م", "", false, "wpf" },
                    { 7, "25/05/2024 11:52:02 م", "", false, "Windows Form" },
                    { 8, "25/05/2024 11:52:02 م", "", false, "NavisWorks" },
                    { 9, "25/05/2024 11:52:02 م", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "25/05/2024 11:52:02 م", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "25/05/2024 11:52:02 م", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "25/05/2024 11:52:02 م", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "25/05/2024 11:52:02 م", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "Country", "CreatedAt", "Email", "IsDeleted", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", null, "25/05/2024 11:52:02 م", "Trainee1@example.com", false, "Trainee 1", null },
                    { 2, "Bio for Trainee 2", null, "25/05/2024 11:52:02 م", "Trainee2@example.com", false, "Trainee 2", null },
                    { 3, "Bio for Trainee 3", null, "25/05/2024 11:52:02 م", "Trainee3@example.com", false, "Trainee 3", null },
                    { 4, "Bio for Trainee 4", null, "25/05/2024 11:52:02 م", "Trainee4@example.com", false, "Trainee 4", null },
                    { 5, "Bio for Trainee 5", null, "25/05/2024 11:52:02 م", "Trainee5@example.com", false, "Trainee 5", null },
                    { 6, "Bio for Trainee 6", null, "25/05/2024 11:52:02 م", "Trainee6@example.com", false, "Trainee 6", null },
                    { 7, "Bio for Trainee 7", null, "25/05/2024 11:52:02 م", "Trainee7@example.com", false, "Trainee 7", null },
                    { 8, "Bio for Trainee 8", null, "25/05/2024 11:52:02 م", "Trainee8@example.com", false, "Trainee 8", null },
                    { 9, "Bio for Trainee 9", null, "25/05/2024 11:52:02 م", "Trainee9@example.com", false, "Trainee 9", null },
                    { 10, "Bio for Trainee 10", null, "25/05/2024 11:52:02 م", "Trainee10@example.com", false, "Trainee 10", null },
                    { 11, "Bio for Trainee 11", null, "25/05/2024 11:52:02 م", "Trainee11@example.com", false, "Trainee 11", null },
                    { 12, "Bio for Trainee 12", null, "25/05/2024 11:52:02 م", "Trainee12@example.com", false, "Trainee 12", null },
                    { 13, "Bio for Trainee 13", null, "25/05/2024 11:52:02 م", "Trainee13@example.com", false, "Trainee 13", null },
                    { 14, "Bio for Trainee 14", null, "25/05/2024 11:52:02 م", "Trainee14@example.com", false, "Trainee 14", null },
                    { 15, "Bio for Trainee 15", null, "25/05/2024 11:52:02 م", "Trainee15@example.com", false, "Trainee 15", null },
                    { 16, "Bio for Trainee 16", null, "25/05/2024 11:52:02 م", "Trainee16@example.com", false, "Trainee 16", null },
                    { 17, "Bio for Trainee 17", null, "25/05/2024 11:52:02 م", "Trainee17@example.com", false, "Trainee 17", null },
                    { 18, "Bio for Trainee 18", null, "25/05/2024 11:52:02 م", "Trainee18@example.com", false, "Trainee 18", null },
                    { 19, "Bio for Trainee 19", null, "25/05/2024 11:52:02 م", "Trainee19@example.com", false, "Trainee 19", null },
                    { 20, "Bio for Trainee 20", null, "25/05/2024 11:52:02 م", "Trainee20@example.com", false, "Trainee 20", null },
                    { 21, "Bio for Trainee 21", null, "25/05/2024 11:52:02 م", "Trainee21@example.com", false, "Trainee 21", null },
                    { 22, "Bio for Trainee 22", null, "25/05/2024 11:52:02 م", "Trainee22@example.com", false, "Trainee 22", null },
                    { 23, "Bio for Trainee 23", null, "25/05/2024 11:52:02 م", "Trainee23@example.com", false, "Trainee 23", null },
                    { 24, "Bio for Trainee 24", null, "25/05/2024 11:52:02 م", "Trainee24@example.com", false, "Trainee 24", null },
                    { 25, "Bio for Trainee 25", null, "25/05/2024 11:52:02 م", "Trainee25@example.com", false, "Trainee 25", null },
                    { 26, "Bio for Trainee 26", null, "25/05/2024 11:52:02 م", "Trainee26@example.com", false, "Trainee 26", null },
                    { 27, "Bio for Trainee 27", null, "25/05/2024 11:52:02 م", "Trainee27@example.com", false, "Trainee 27", null },
                    { 28, "Bio for Trainee 28", null, "25/05/2024 11:52:02 م", "Trainee28@example.com", false, "Trainee 28", null },
                    { 30, "Bio for Trainee 30", null, "25/05/2024 11:52:02 م", "Trainee30@example.com", false, "Trainee 30", null }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "25/05/2024 11:52:02 م", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "25/05/2024 11:52:02 م", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "25/05/2024 11:52:02 م", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "25/05/2024 11:52:02 م", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "25/05/2024 11:52:02 م", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "25/05/2024 11:52:02 م", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "25/05/2024 11:52:02 م", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "25/05/2024 11:52:02 م", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "25/05/2024 11:52:02 م", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "25/05/2024 11:52:02 م", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "25/05/2024 11:52:02 م", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "25/05/2024 11:52:02 م", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "25/05/2024 11:52:02 م", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "25/05/2024 11:52:02 م", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "25/05/2024 11:52:02 م", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "25/05/2024 11:52:02 م", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "25/05/2024 11:52:02 م", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "25/05/2024 11:52:02 م", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "25/05/2024 11:52:02 م", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "25/05/2024 11:52:02 م", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "25/05/2024 11:52:02 م", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "25/05/2024 11:52:02 م", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "25/05/2024 11:52:02 م", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "25/05/2024 11:52:02 م", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "25/05/2024 11:52:02 م", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "25/05/2024 11:52:02 م", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "25/05/2024 11:52:02 م", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "25/05/2024 11:52:02 م", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "25/05/2024 11:52:02 م", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "25/05/2024 11:52:02 م", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 24, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3316), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 6, 1, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3304), 10.5, 1 },
                    { 2, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 9, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3401), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 8, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3395), 15.199999999999999, 15 },
                    { 3, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3427), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 30, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3423), 11.699999999999999, 3 },
                    { 4, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 24, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3464), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3461), 13.5, 5 },
                    { 5, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3497), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 6, 1, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3491), 14.1, 6 },
                    { 6, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 14, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3521), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 6, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3517), 12.300000000000001, 14 },
                    { 7, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 19, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3544), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 6, 2, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3540), 12.800000000000001, 10 },
                    { 8, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3581), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 31, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3578), 13.199999999999999, 8 },
                    { 9, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3605), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 3, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3601), 10.800000000000001, 7 },
                    { 10, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 9, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3627), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 5, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3624), 12.199999999999999, 4 },
                    { 11, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 14, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3661), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 7, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3657), 13.5, 8 },
                    { 12, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3688), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3684), 13.1, 3 },
                    { 13, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3722), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 6, 2, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3711), 10.6, 2 },
                    { 14, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 24, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3747), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 6, 1, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3743), 11.199999999999999, 2 },
                    { 15, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 9, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3769), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 8, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3766), 15.800000000000001, 13 },
                    { 16, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3804), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 30, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3800), 12.5, 3 },
                    { 17, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 14, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3827), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 6, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3824), 13.800000000000001, 4 },
                    { 18, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 19, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3850), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 6, 2, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3846), 12.300000000000001, 9 },
                    { 19, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3872), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 31, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3868), 13.1, 9 },
                    { 20, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3908), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 6, 3, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(3901), 11.800000000000001, 10 },
                    { 21, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 9, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4054), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 5, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4049), 12.5, 9 },
                    { 22, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 14, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4080), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 6, 7, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4077), 13.199999999999999, 4 },
                    { 23, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4115), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 4, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4111), 13.6, 10 },
                    { 24, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4142), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 6, 2, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4138), 10.9, 6 },
                    { 25, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 24, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4165), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 6, 1, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4162), 11.4, 7 },
                    { 26, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 9, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4200), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 8, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4196), 15.199999999999999, 7 },
                    { 27, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4223), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 30, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4219), 13.699999999999999, 12 },
                    { 28, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 14, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4258), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 6, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4250), 14.300000000000001, 7 },
                    { 29, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 19, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4282), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 6, 2, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4279), 12.6, 6 },
                    { 30, "path/to/trainee/image.jpg", "25/05/2024 11:52:02 م", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 29, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4305), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 31, 23, 52, 2, 182, DateTimeKind.Local).AddTicks(4302), 13.9, 8 }
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
                    { 9, 3, "Description for Chapter 3 in Course 3", false, "Chapter 3 for Course 3", "https://sadat.vip/" },
                    { 10, 4, "Description for Chapter 1 in Course 4", false, "Chapter 1 for Course 4", "https://sadat.vip/" },
                    { 11, 4, "Description for Chapter 2 in Course 4", false, "Chapter 2 for Course 4", "https://sadat.vip/" },
                    { 12, 5, "Description for Chapter 1 in Course 5", false, "Chapter 1 for Course 5", "https://sadat.vip/" },
                    { 13, 5, "Description for Chapter 2 in Course 5", false, "Chapter 2 for Course 5", "https://sadat.vip/" },
                    { 14, 5, "Description for Chapter 3 in Course 5", false, "Chapter 3 for Course 5", "https://sadat.vip/" },
                    { 15, 6, "Description for Chapter 1 in Course 6", false, "Chapter 1 for Course 6", "https://sadat.vip/" },
                    { 16, 6, "Description for Chapter 2 in Course 6", false, "Chapter 2 for Course 6", "https://sadat.vip/" },
                    { 17, 6, "Description for Chapter 3 in Course 6", false, "Chapter 3 for Course 6", "https://sadat.vip/" },
                    { 18, 7, "Description for Chapter 1 in Course 7", false, "Chapter 1 for Course 7", "https://sadat.vip/" },
                    { 19, 7, "Description for Chapter 2 in Course 7", false, "Chapter 2 for Course 7", "https://sadat.vip/" },
                    { 20, 8, "Description for Chapter 1 in Course 8", false, "Chapter 1 for Course 8", "https://sadat.vip/" },
                    { 21, 8, "Description for Chapter 2 in Course 8", false, "Chapter 2 for Course 8", "https://sadat.vip/" },
                    { 22, 8, "Description for Chapter 3 in Course 8", false, "Chapter 3 for Course 8", "https://sadat.vip/" },
                    { 23, 9, "Description for Chapter 1 in Course 9", false, "Chapter 1 for Course 9", "https://sadat.vip/" },
                    { 24, 9, "Description for Chapter 2 in Course 9", false, "Chapter 2 for Course 9", "https://sadat.vip/" },
                    { 25, 9, "Description for Chapter 3 in Course 9", false, "Chapter 3 for Course 9", "https://sadat.vip/" },
                    { 26, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 27, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" },
                    { 28, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 12, 81.3057170578552m, 23 },
                    { 2, 10, 41.7445779389192m, 22 },
                    { 3, 8, 85.0915605323306m, 17 },
                    { 4, 3, 85.4023268417899m, 8 },
                    { 5, 21, 45.8127758411834m, 2 },
                    { 6, 19, 15.9300672743476m, 4 },
                    { 7, 21, 66.8431897157294m, 1 },
                    { 8, 27, 32.8715079421013m, 11 },
                    { 9, 12, 54.4523502615241m, 28 },
                    { 10, 15, 26.1527206385009m, 7 },
                    { 11, 16, 79.9999116463164m, 1 },
                    { 12, 7, 24.3051034664215m, 2 },
                    { 13, 26, 50.1056616707208m, 27 },
                    { 14, 28, 96.6429611022655m, 6 },
                    { 15, 3, 22.9563565234492m, 6 },
                    { 16, 7, 91.1733569395257m, 8 },
                    { 17, 3, 84.7923887468615m, 17 },
                    { 18, 16, 57.9038102377038m, 24 },
                    { 19, 13, 75.9100612794993m, 28 },
                    { 20, 13, 26.8657291736787m, 11 },
                    { 21, 19, 6.03716557732337m, 3 },
                    { 22, 8, 75.4559058892007m, 17 },
                    { 23, 28, 74.6465601578911m, 2 },
                    { 24, 4, 21.3213682978635m, 13 },
                    { 25, 22, 50.578888104972m, 6 },
                    { 26, 26, 20.9089976300364m, 9 },
                    { 27, 2, 9.70062802737312m, 26 },
                    { 28, 5, 27.6411887849239m, 25 },
                    { 29, 15, 8.49970075797667m, 19 },
                    { 30, 12, 48.0042528797037m, 15 },
                    { 31, 15, 21.0442700914172m, 23 },
                    { 32, 25, 84.5347595040379m, 8 },
                    { 33, 19, 97.1719168976702m, 25 },
                    { 34, 2, 88.5507541975734m, 13 },
                    { 35, 8, 62.034262739198m, 20 },
                    { 36, 1, 48.5015326428198m, 27 },
                    { 37, 12, 62.6568884377569m, 14 },
                    { 38, 14, 86.6181469001331m, 15 },
                    { 39, 12, 90.3869198359446m, 1 },
                    { 40, 12, 93.724957667413m, 3 },
                    { 41, 1, 30.3327866959592m, 25 },
                    { 42, 26, 52.0638967872557m, 4 },
                    { 43, 13, 70.2167838776668m, 19 },
                    { 44, 26, 18.3838525309926m, 24 },
                    { 45, 25, 24.5420710362063m, 4 },
                    { 46, 15, 97.70887155602m, 23 },
                    { 47, 10, 47.3160333730652m, 11 },
                    { 48, 24, 51.5265500358284m, 6 },
                    { 49, 22, 14.8845111139144m, 2 },
                    { 50, 5, 78.5744920407088m, 8 },
                    { 51, 26, 32.9983597226701m, 25 },
                    { 52, 5, 13.9442684591194m, 25 },
                    { 53, 4, 25.0174703995849m, 19 },
                    { 54, 25, 72.9599849555272m, 5 },
                    { 55, 2, 94.0791771106351m, 5 },
                    { 56, 12, 24.2531864224578m, 1 },
                    { 57, 23, 15.8503044822325m, 22 },
                    { 58, 4, 54.0084332193817m, 3 },
                    { 59, 12, 39.4430280166674m, 13 },
                    { 60, 12, 39.5254550036171m, 15 },
                    { 61, 18, 69.8275895146548m, 26 },
                    { 62, 7, 7.1660567468445m, 19 },
                    { 63, 25, 6.96686032908452m, 5 },
                    { 64, 16, 92.8663736455912m, 27 },
                    { 65, 27, 56.9371892822355m, 22 },
                    { 66, 7, 37.1045384437954m, 16 },
                    { 67, 16, 65.9977157279647m, 7 },
                    { 68, 22, 5.92341920694416m, 20 },
                    { 69, 24, 36.1716243776994m, 6 },
                    { 70, 23, 62.928764860699m, 25 },
                    { 71, 15, 90.567000683017m, 22 },
                    { 72, 9, 85.0478652690481m, 6 },
                    { 73, 20, 56.7457197581254m, 27 },
                    { 74, 9, 47.689112281219m, 27 },
                    { 75, 21, 47.8545391437967m, 22 },
                    { 76, 10, 24.1924940109471m, 2 },
                    { 77, 15, 76.9935401626017m, 2 },
                    { 78, 7, 16.4353821975641m, 18 },
                    { 79, 15, 72.4833060414042m, 26 },
                    { 80, 14, 17.7422245571998m, 7 },
                    { 81, 28, 44.2319931284857m, 22 },
                    { 82, 17, 18.9617004417328m, 6 },
                    { 83, 19, 97.4545300515081m, 20 },
                    { 84, 23, 45.1888634620505m, 18 },
                    { 85, 3, 82.009581043567m, 14 },
                    { 86, 23, 19.0962370769243m, 25 },
                    { 87, 6, 51.4950607288135m, 17 },
                    { 88, 5, 44.3492127832373m, 14 },
                    { 89, 10, 47.5083939692731m, 26 },
                    { 90, 14, 50.6945292276447m, 2 },
                    { 91, 10, 84.7877389335204m, 23 },
                    { 92, 13, 51.0448020057128m, 27 },
                    { 93, 25, 11.7712575216004m, 28 },
                    { 94, 12, 66.7571493590293m, 2 },
                    { 95, 6, 67.1630428339199m, 1 },
                    { 96, 18, 67.8305484046729m, 17 },
                    { 97, 17, 39.7907785390014m, 26 },
                    { 98, 4, 36.7221140240003m, 15 },
                    { 99, 1, 43.3469952486283m, 20 },
                    { 100, 2, 60.8149903070859m, 13 }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 1", "https://sadat.vip/" },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 1", "https://sadat.vip/" },
                    { 3, 2, "Content for Lesson 1 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 2", "https://sadat.vip/" },
                    { 4, 2, "Content for Lesson 2 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 2", "https://sadat.vip/" },
                    { 5, 2, "Content for Lesson 3 in Chapter 2", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 2", "https://sadat.vip/" },
                    { 6, 3, "Content for Lesson 1 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" },
                    { 7, 3, "Content for Lesson 2 in Chapter 3", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" },
                    { 8, 4, "Content for Lesson 1 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" },
                    { 9, 4, "Content for Lesson 2 in Chapter 4", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" },
                    { 10, 5, "Content for Lesson 1 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" },
                    { 11, 5, "Content for Lesson 2 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" },
                    { 12, 5, "Content for Lesson 3 in Chapter 5", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" },
                    { 13, 6, "Content for Lesson 1 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" },
                    { 14, 6, "Content for Lesson 2 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" },
                    { 15, 6, "Content for Lesson 3 in Chapter 6", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 6", "https://sadat.vip/" },
                    { 16, 7, "Content for Lesson 1 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" },
                    { 17, 7, "Content for Lesson 2 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" },
                    { 18, 7, "Content for Lesson 3 in Chapter 7", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 3 for Chapter 7", "https://sadat.vip/" },
                    { 19, 8, "Content for Lesson 1 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" },
                    { 20, 8, "Content for Lesson 2 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" },
                    { 21, 8, "Content for Lesson 3 in Chapter 8", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 3 for Chapter 8", "https://sadat.vip/" },
                    { 22, 9, "Content for Lesson 1 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" },
                    { 23, 9, "Content for Lesson 2 in Chapter 9", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" },
                    { 24, 10, "Content for Lesson 1 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" },
                    { 25, 10, "Content for Lesson 2 in Chapter 10", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" },
                    { 26, 11, "Content for Lesson 1 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" },
                    { 27, 11, "Content for Lesson 2 in Chapter 11", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" },
                    { 28, 12, "Content for Lesson 1 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" },
                    { 29, 12, "Content for Lesson 2 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" },
                    { 30, 12, "Content for Lesson 3 in Chapter 12", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 12", "https://sadat.vip/" },
                    { 31, 13, "Content for Lesson 1 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" },
                    { 32, 13, "Content for Lesson 2 in Chapter 13", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" },
                    { 33, 14, "Content for Lesson 1 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" },
                    { 34, 14, "Content for Lesson 2 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" },
                    { 35, 14, "Content for Lesson 3 in Chapter 14", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 14", "https://sadat.vip/" },
                    { 36, 15, "Content for Lesson 1 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" },
                    { 37, 15, "Content for Lesson 2 in Chapter 15", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" },
                    { 38, 16, "Content for Lesson 1 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" },
                    { 39, 16, "Content for Lesson 2 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" },
                    { 40, 16, "Content for Lesson 3 in Chapter 16", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 16", "https://sadat.vip/" },
                    { 41, 17, "Content for Lesson 1 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" },
                    { 42, 17, "Content for Lesson 2 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" },
                    { 43, 17, "Content for Lesson 3 in Chapter 17", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" },
                    { 44, 18, "Content for Lesson 1 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" },
                    { 45, 18, "Content for Lesson 2 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" },
                    { 46, 18, "Content for Lesson 3 in Chapter 18", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" },
                    { 47, 19, "Content for Lesson 1 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" },
                    { 48, 19, "Content for Lesson 2 in Chapter 19", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" },
                    { 49, 20, "Content for Lesson 1 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" },
                    { 50, 20, "Content for Lesson 2 in Chapter 20", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" },
                    { 51, 21, "Content for Lesson 1 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" },
                    { 52, 21, "Content for Lesson 2 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" },
                    { 53, 21, "Content for Lesson 3 in Chapter 21", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" },
                    { 54, 22, "Content for Lesson 1 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" },
                    { 55, 22, "Content for Lesson 2 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" },
                    { 56, 22, "Content for Lesson 3 in Chapter 22", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 3 for Chapter 22", "https://sadat.vip/" },
                    { 57, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 59, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 60, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 62, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 64, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 65, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" },
                    { 66, 26, "Content for Lesson 3 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 3 for Chapter 26", "https://sadat.vip/" },
                    { 67, 27, "Content for Lesson 1 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 27", "https://sadat.vip/" },
                    { 68, 27, "Content for Lesson 2 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 27", "https://sadat.vip/" },
                    { 69, 27, "Content for Lesson 3 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 3 for Chapter 27", "https://sadat.vip/" },
                    { 70, 28, "Content for Lesson 1 in Chapter 28", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 28", "https://sadat.vip/" },
                    { 71, 28, "Content for Lesson 2 in Chapter 28", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 28", "https://sadat.vip/" }
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
