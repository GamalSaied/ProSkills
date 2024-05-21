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
                    Phone = table.Column<int>(type: "int", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "21/05/2024 7:29:44 pm", "", false, "Revit" },
                    { 2, "21/05/2024 7:29:44 pm", "", false, "Sap" },
                    { 3, "21/05/2024 7:29:44 pm", "", false, "Etabs" },
                    { 4, "21/05/2024 7:29:44 pm", "", false, "Forge" },
                    { 5, "21/05/2024 7:29:44 pm", "", false, "primavera" },
                    { 6, "21/05/2024 7:29:44 pm", "", false, "wpf" },
                    { 7, "21/05/2024 7:29:44 pm", "", false, "Windows Form" },
                    { 8, "21/05/2024 7:29:44 pm", "", false, "NavisWorks" },
                    { 9, "21/05/2024 7:29:44 pm", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "21/05/2024 7:29:44 pm", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "21/05/2024 7:29:44 pm", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "21/05/2024 7:29:44 pm", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "21/05/2024 7:29:44 pm", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", "21/05/2024 7:29:44 pm", "Trainee1@example.com", false, "Trainee 1", "password1" },
                    { 2, "Bio for Trainee 2", "21/05/2024 7:29:44 pm", "Trainee2@example.com", false, "Trainee 2", "password2" },
                    { 3, "Bio for Trainee 3", "21/05/2024 7:29:44 pm", "Trainee3@example.com", false, "Trainee 3", "password3" },
                    { 4, "Bio for Trainee 4", "21/05/2024 7:29:44 pm", "Trainee4@example.com", false, "Trainee 4", "password4" },
                    { 5, "Bio for Trainee 5", "21/05/2024 7:29:44 pm", "Trainee5@example.com", false, "Trainee 5", "password5" },
                    { 6, "Bio for Trainee 6", "21/05/2024 7:29:44 pm", "Trainee6@example.com", false, "Trainee 6", "password6" },
                    { 7, "Bio for Trainee 7", "21/05/2024 7:29:44 pm", "Trainee7@example.com", false, "Trainee 7", "password7" },
                    { 8, "Bio for Trainee 8", "21/05/2024 7:29:44 pm", "Trainee8@example.com", false, "Trainee 8", "password8" },
                    { 9, "Bio for Trainee 9", "21/05/2024 7:29:44 pm", "Trainee9@example.com", false, "Trainee 9", "password9" },
                    { 10, "Bio for Trainee 10", "21/05/2024 7:29:44 pm", "Trainee10@example.com", false, "Trainee 10", "password10" },
                    { 11, "Bio for Trainee 11", "21/05/2024 7:29:44 pm", "Trainee11@example.com", false, "Trainee 11", "password11" },
                    { 12, "Bio for Trainee 12", "21/05/2024 7:29:44 pm", "Trainee12@example.com", false, "Trainee 12", "password12" },
                    { 13, "Bio for Trainee 13", "21/05/2024 7:29:44 pm", "Trainee13@example.com", false, "Trainee 13", "password13" },
                    { 14, "Bio for Trainee 14", "21/05/2024 7:29:44 pm", "Trainee14@example.com", false, "Trainee 14", "password14" },
                    { 15, "Bio for Trainee 15", "21/05/2024 7:29:44 pm", "Trainee15@example.com", false, "Trainee 15", "password15" },
                    { 16, "Bio for Trainee 16", "21/05/2024 7:29:44 pm", "Trainee16@example.com", false, "Trainee 16", "password16" },
                    { 17, "Bio for Trainee 17", "21/05/2024 7:29:44 pm", "Trainee17@example.com", false, "Trainee 17", "password17" },
                    { 18, "Bio for Trainee 18", "21/05/2024 7:29:44 pm", "Trainee18@example.com", false, "Trainee 18", "password18" },
                    { 19, "Bio for Trainee 19", "21/05/2024 7:29:44 pm", "Trainee19@example.com", false, "Trainee 19", "password19" },
                    { 20, "Bio for Trainee 20", "21/05/2024 7:29:44 pm", "Trainee20@example.com", false, "Trainee 20", "password20" },
                    { 21, "Bio for Trainee 21", "21/05/2024 7:29:44 pm", "Trainee21@example.com", false, "Trainee 21", "password21" },
                    { 22, "Bio for Trainee 22", "21/05/2024 7:29:44 pm", "Trainee22@example.com", false, "Trainee 22", "password22" },
                    { 23, "Bio for Trainee 23", "21/05/2024 7:29:44 pm", "Trainee23@example.com", false, "Trainee 23", "password23" },
                    { 24, "Bio for Trainee 24", "21/05/2024 7:29:44 pm", "Trainee24@example.com", false, "Trainee 24", "password24" },
                    { 25, "Bio for Trainee 25", "21/05/2024 7:29:44 pm", "Trainee25@example.com", false, "Trainee 25", "password25" },
                    { 26, "Bio for Trainee 26", "21/05/2024 7:29:44 pm", "Trainee26@example.com", false, "Trainee 26", "password26" },
                    { 27, "Bio for Trainee 27", "21/05/2024 7:29:44 pm", "Trainee27@example.com", false, "Trainee 27", "password27" },
                    { 28, "Bio for Trainee 28", "21/05/2024 7:29:44 pm", "Trainee28@example.com", false, "Trainee 28", "password28" },
                    { 29, "Bio for Trainee 29", "21/05/2024 7:29:44 pm", "Trainee29@example.com", false, "Trainee 29", "password29" },
                    { 30, "Bio for Trainee 30", "21/05/2024 7:29:44 pm", "Trainee30@example.com", false, "Trainee 30", "password30" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "21/05/2024 7:29:44 pm", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "21/05/2024 7:29:44 pm", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "21/05/2024 7:29:44 pm", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "21/05/2024 7:29:44 pm", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "21/05/2024 7:29:44 pm", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "21/05/2024 7:29:44 pm", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "21/05/2024 7:29:44 pm", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "21/05/2024 7:29:44 pm", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "21/05/2024 7:29:44 pm", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "21/05/2024 7:29:44 pm", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "21/05/2024 7:29:44 pm", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "21/05/2024 7:29:44 pm", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "21/05/2024 7:29:44 pm", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "21/05/2024 7:29:44 pm", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "21/05/2024 7:29:44 pm", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "21/05/2024 7:29:44 pm", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "21/05/2024 7:29:44 pm", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "21/05/2024 7:29:44 pm", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "21/05/2024 7:29:44 pm", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "21/05/2024 7:29:44 pm", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "21/05/2024 7:29:44 pm", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "21/05/2024 7:29:44 pm", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "21/05/2024 7:29:44 pm", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "21/05/2024 7:29:44 pm", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "21/05/2024 7:29:44 pm", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "21/05/2024 7:29:44 pm", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "21/05/2024 7:29:44 pm", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "21/05/2024 7:29:44 pm", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "21/05/2024 7:29:44 pm", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "21/05/2024 7:29:44 pm", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6465), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6461), 10.5, 14 },
                    { 2, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6510), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6509), 15.199999999999999, 2 },
                    { 3, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6521), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6520), 11.699999999999999, 1 },
                    { 4, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6541), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6539), 13.5, 12 },
                    { 5, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the design and management of relational databases.", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6551), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6550), 14.1, 7 },
                    { 6, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6561), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6560), 12.300000000000001, 1 },
                    { 7, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6572), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6570), 12.800000000000001, 1 },
                    { 8, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6585), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6583), 13.199999999999999, 1 },
                    { 9, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of Python programming language.", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6595), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6594), 10.800000000000001, 13 },
                    { 10, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6605), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 1, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6604), 12.199999999999999, 5 },
                    { 11, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6615), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 3, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6614), 13.5, 3 },
                    { 12, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers essential concepts in computer networks.", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6628), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6626), 13.1, 8 },
                    { 13, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6638), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6636), 10.6, 8 },
                    { 14, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6647), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6646), 11.199999999999999, 14 },
                    { 15, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6657), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6656), 15.800000000000001, 11 },
                    { 16, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6670), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6668), 12.5, 8 },
                    { 17, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6679), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6678), 13.800000000000001, 13 },
                    { 18, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6689), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6688), 12.300000000000001, 3 },
                    { 19, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6699), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6698), 13.1, 14 },
                    { 20, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6711), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 5, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6710), 11.800000000000001, 13 },
                    { 21, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6748), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 1, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6746), 12.5, 15 },
                    { 22, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6759), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 6, 3, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6757), 13.199999999999999, 11 },
                    { 23, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6769), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6767), 13.6, 8 },
                    { 24, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6781), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6780), 10.9, 9 },
                    { 25, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6791), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6790), 11.4, 1 },
                    { 26, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6801), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6800), 15.199999999999999, 9 },
                    { 27, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6811), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6810), 13.699999999999999, 3 },
                    { 28, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6823), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6822), 14.300000000000001, 2 },
                    { 29, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6833), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6831), 12.6, 5 },
                    { 30, "path/to/trainee/image.jpg", "21/05/2024 7:29:44 pm", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6842), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6841), 13.9, 6 }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 21, 19.1749337106689m, 19 },
                    { 2, 26, 46.6796768458176m, 9 },
                    { 3, 29, 62.7003887232847m, 6 },
                    { 4, 11, 37.4084053574589m, 8 },
                    { 5, 15, 40.5699687964192m, 29 },
                    { 6, 8, 82.5664183311241m, 13 },
                    { 7, 8, 78.0749065582054m, 18 },
                    { 8, 9, 65.3502171816766m, 26 },
                    { 9, 7, 74.1341561146674m, 30 },
                    { 10, 19, 55.3219891421489m, 9 },
                    { 11, 17, 75.3388857721978m, 14 },
                    { 12, 9, 80.1451020833722m, 16 },
                    { 13, 19, 68.3096739650878m, 21 },
                    { 14, 2, 21.0977265382282m, 15 },
                    { 15, 3, 47.6951970099906m, 17 },
                    { 16, 3, 38.2444102428454m, 10 },
                    { 17, 18, 87.2865106999846m, 25 },
                    { 18, 12, 30.727214995569m, 4 },
                    { 19, 14, 5.7866581186213m, 20 },
                    { 20, 20, 81.8649308811601m, 26 },
                    { 21, 3, 16.2863620230387m, 22 },
                    { 22, 14, 91.9954547840499m, 12 },
                    { 23, 11, 53.4130835903366m, 20 },
                    { 24, 13, 61.3851491094783m, 29 },
                    { 25, 3, 2.02132861604816m, 20 },
                    { 26, 27, 50.7807075258199m, 27 },
                    { 27, 18, 83.9060470282443m, 25 },
                    { 28, 6, 4.5557779063121m, 15 },
                    { 29, 27, 69.6673272192654m, 26 },
                    { 30, 15, 12.1990048795385m, 30 },
                    { 31, 26, 75.8789188056828m, 25 },
                    { 32, 23, 56.5519965248669m, 5 },
                    { 33, 2, 25.5863837585953m, 8 },
                    { 34, 30, 95.3258815527437m, 15 },
                    { 35, 18, 33.1998936758888m, 14 },
                    { 36, 6, 24.3992420065169m, 2 },
                    { 37, 1, 77.585760254887m, 15 },
                    { 38, 22, 33.4171985478989m, 19 },
                    { 39, 10, 72.5408504416773m, 12 },
                    { 40, 3, 90.9334698863028m, 10 },
                    { 41, 8, 48.3397284161816m, 30 },
                    { 42, 18, 64.5294063775591m, 17 },
                    { 43, 24, 11.9182232194373m, 19 },
                    { 44, 1, 90.2550192608888m, 7 },
                    { 45, 20, 26.5566647154284m, 6 },
                    { 46, 12, 65.7972518720607m, 10 },
                    { 47, 10, 27.1890820132206m, 11 },
                    { 48, 19, 19.4819658754278m, 23 },
                    { 49, 3, 6.33020425237062m, 1 },
                    { 50, 12, 77.838114806634m, 8 },
                    { 51, 21, 59.5922285840699m, 7 },
                    { 52, 5, 93.7522670459113m, 4 },
                    { 53, 18, 78.5097480367326m, 26 },
                    { 54, 18, 47.4693405604489m, 22 },
                    { 55, 16, 90.0030150304717m, 8 },
                    { 56, 19, 6.15272030534172m, 28 },
                    { 57, 5, 5.0974448864768m, 2 },
                    { 58, 3, 78.5946991956794m, 2 },
                    { 59, 26, 11.3149150062716m, 20 },
                    { 60, 13, 26.8265105233371m, 20 },
                    { 61, 1, 71.7046935257582m, 2 },
                    { 62, 16, 29.1815735063864m, 6 },
                    { 63, 25, 93.2720870998049m, 29 },
                    { 64, 26, 88.8366625236615m, 26 },
                    { 65, 18, 12.9179962970898m, 28 },
                    { 66, 1, 23.8812237715772m, 13 },
                    { 67, 17, 91.2487607857698m, 5 },
                    { 68, 16, 19.8247123602721m, 23 },
                    { 69, 1, 5.6714732499634m, 11 },
                    { 70, 27, 36.5281698740443m, 26 },
                    { 71, 28, 3.93470025996839m, 17 },
                    { 72, 2, 82.5702791111988m, 1 },
                    { 73, 29, 65.9762750787748m, 26 },
                    { 74, 24, 4.94241347339177m, 12 },
                    { 75, 21, 55.2809761151237m, 16 },
                    { 76, 6, 82.903618176327m, 4 },
                    { 77, 9, 18.3088054561647m, 24 },
                    { 78, 9, 4.11466199072354m, 2 },
                    { 79, 15, 26.4022625646932m, 20 },
                    { 80, 3, 17.4617714544885m, 16 },
                    { 81, 30, 6.48022604192027m, 13 },
                    { 82, 22, 53.0048864425279m, 21 },
                    { 83, 21, 60.4575864454783m, 13 },
                    { 84, 2, 4.08313486754807m, 15 },
                    { 85, 10, 9.93252631636748m, 8 },
                    { 86, 18, 63.5658489336782m, 14 },
                    { 87, 2, 43.4987310825468m, 3 },
                    { 88, 28, 81.4568181365481m, 19 },
                    { 89, 9, 82.6170502288305m, 19 },
                    { 90, 15, 38.8460583954367m, 6 },
                    { 91, 19, 78.9899807619574m, 13 },
                    { 92, 26, 23.933482378688m, 4 },
                    { 93, 26, 53.1558540050751m, 7 },
                    { 94, 25, 88.5831574621364m, 2 },
                    { 95, 26, 19.492958541044m, 15 },
                    { 96, 3, 6.38022297341125m, 12 },
                    { 97, 22, 65.435108146968m, 15 },
                    { 98, 30, 14.6441193806448m, 15 },
                    { 99, 17, 87.0904835632484m, 26 },
                    { 100, 18, 60.8813308384751m, 29 }
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
                name: "Course");

            migrationBuilder.DropTable(
                name: "instructor");
        }
    }
}
