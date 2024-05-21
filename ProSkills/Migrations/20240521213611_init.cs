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
                    { 1, "22/05/2024 00:36:11", "", false, "Revit" },
                    { 2, "22/05/2024 00:36:11", "", false, "Sap" },
                    { 3, "22/05/2024 00:36:11", "", false, "Etabs" },
                    { 4, "22/05/2024 00:36:11", "", false, "Forge" },
                    { 5, "22/05/2024 00:36:11", "", false, "primavera" },
                    { 6, "22/05/2024 00:36:11", "", false, "wpf" },
                    { 7, "22/05/2024 00:36:11", "", false, "Windows Form" },
                    { 8, "22/05/2024 00:36:11", "", false, "NavisWorks" },
                    { 9, "22/05/2024 00:36:11", "", false, "Graphics" }
                });

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "22/05/2024 00:36:11", 10, "image1.jpg", false, "free", 5, 15, 20, 1024.0 },
                    { 2, "22/05/2024 00:36:11", 10, "image2.jpg", false, "Premium", 5, 15, 40, 1024.0 },
                    { 3, "22/05/2024 00:36:11", 10, "image3.jpg", false, "Advanced", 5, 15, 40, 1024.0 }
                });

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "isAvalible", "packageid" },
                values: new object[] { 3, "gamal", "22/05/2024 00:36:11", false, "premium", true, 1 });

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", "22/05/2024 00:36:11", "Trainee1@example.com", false, "Trainee 1", "password1" },
                    { 2, "Bio for Trainee 2", "22/05/2024 00:36:11", "Trainee2@example.com", false, "Trainee 2", "password2" },
                    { 3, "Bio for Trainee 3", "22/05/2024 00:36:11", "Trainee3@example.com", false, "Trainee 3", "password3" },
                    { 4, "Bio for Trainee 4", "22/05/2024 00:36:11", "Trainee4@example.com", false, "Trainee 4", "password4" },
                    { 5, "Bio for Trainee 5", "22/05/2024 00:36:11", "Trainee5@example.com", false, "Trainee 5", "password5" },
                    { 6, "Bio for Trainee 6", "22/05/2024 00:36:11", "Trainee6@example.com", false, "Trainee 6", "password6" },
                    { 7, "Bio for Trainee 7", "22/05/2024 00:36:11", "Trainee7@example.com", false, "Trainee 7", "password7" },
                    { 8, "Bio for Trainee 8", "22/05/2024 00:36:11", "Trainee8@example.com", false, "Trainee 8", "password8" },
                    { 9, "Bio for Trainee 9", "22/05/2024 00:36:11", "Trainee9@example.com", false, "Trainee 9", "password9" },
                    { 10, "Bio for Trainee 10", "22/05/2024 00:36:11", "Trainee10@example.com", false, "Trainee 10", "password10" },
                    { 11, "Bio for Trainee 11", "22/05/2024 00:36:11", "Trainee11@example.com", false, "Trainee 11", "password11" },
                    { 12, "Bio for Trainee 12", "22/05/2024 00:36:11", "Trainee12@example.com", false, "Trainee 12", "password12" },
                    { 13, "Bio for Trainee 13", "22/05/2024 00:36:11", "Trainee13@example.com", false, "Trainee 13", "password13" },
                    { 14, "Bio for Trainee 14", "22/05/2024 00:36:11", "Trainee14@example.com", false, "Trainee 14", "password14" },
                    { 15, "Bio for Trainee 15", "22/05/2024 00:36:11", "Trainee15@example.com", false, "Trainee 15", "password15" },
                    { 16, "Bio for Trainee 16", "22/05/2024 00:36:11", "Trainee16@example.com", false, "Trainee 16", "password16" },
                    { 17, "Bio for Trainee 17", "22/05/2024 00:36:11", "Trainee17@example.com", false, "Trainee 17", "password17" },
                    { 18, "Bio for Trainee 18", "22/05/2024 00:36:11", "Trainee18@example.com", false, "Trainee 18", "password18" },
                    { 19, "Bio for Trainee 19", "22/05/2024 00:36:11", "Trainee19@example.com", false, "Trainee 19", "password19" },
                    { 20, "Bio for Trainee 20", "22/05/2024 00:36:11", "Trainee20@example.com", false, "Trainee 20", "password20" },
                    { 21, "Bio for Trainee 21", "22/05/2024 00:36:11", "Trainee21@example.com", false, "Trainee 21", "password21" },
                    { 22, "Bio for Trainee 22", "22/05/2024 00:36:11", "Trainee22@example.com", false, "Trainee 22", "password22" },
                    { 23, "Bio for Trainee 23", "22/05/2024 00:36:11", "Trainee23@example.com", false, "Trainee 23", "password23" },
                    { 24, "Bio for Trainee 24", "22/05/2024 00:36:11", "Trainee24@example.com", false, "Trainee 24", "password24" },
                    { 25, "Bio for Trainee 25", "22/05/2024 00:36:11", "Trainee25@example.com", false, "Trainee 25", "password25" },
                    { 26, "Bio for Trainee 26", "22/05/2024 00:36:11", "Trainee26@example.com", false, "Trainee 26", "password26" },
                    { 27, "Bio for Trainee 27", "22/05/2024 00:36:11", "Trainee27@example.com", false, "Trainee 27", "password27" },
                    { 28, "Bio for Trainee 28", "22/05/2024 00:36:11", "Trainee28@example.com", false, "Trainee 28", "password28" },
                    { 29, "Bio for Trainee 29", "22/05/2024 00:36:11", "Trainee29@example.com", false, "Trainee 29", "password29" },
                    { 30, "Bio for Trainee 30", "22/05/2024 00:36:11", "Trainee30@example.com", false, "Trainee 30", "password30" }
                });

            migrationBuilder.InsertData(
                table: "instructor",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password", "Speciallization" },
                values: new object[,]
                {
                    { 1, "Bio for Instructor 1", "22/05/2024 00:36:11", "instructor1@example.com", false, "Instructor 1", "password1", null },
                    { 2, "Bio for Instructor 2", "22/05/2024 00:36:11", "instructor2@example.com", false, "Instructor 2", "password2", null },
                    { 3, "Bio for Instructor 3", "22/05/2024 00:36:11", "instructor3@example.com", false, "Instructor 3", "password3", null },
                    { 4, "Bio for Instructor 4", "22/05/2024 00:36:11", "instructor4@example.com", false, "Instructor 4", "password4", null },
                    { 5, "Bio for Instructor 5", "22/05/2024 00:36:11", "instructor5@example.com", false, "Instructor 5", "password5", null },
                    { 6, "Bio for Instructor 6", "22/05/2024 00:36:11", "instructor6@example.com", false, "Instructor 6", "password6", null },
                    { 7, "Bio for Instructor 7", "22/05/2024 00:36:11", "instructor7@example.com", false, "Instructor 7", "password7", null },
                    { 8, "Bio for Instructor 8", "22/05/2024 00:36:11", "instructor8@example.com", false, "Instructor 8", "password8", null },
                    { 9, "Bio for Instructor 9", "22/05/2024 00:36:11", "instructor9@example.com", false, "Instructor 9", "password9", null },
                    { 10, "Bio for Instructor 10", "22/05/2024 00:36:11", "instructor10@example.com", false, "Instructor 10", "password10", null },
                    { 11, "Bio for Instructor 11", "22/05/2024 00:36:11", "instructor11@example.com", false, "Instructor 11", "password11", null },
                    { 12, "Bio for Instructor 12", "22/05/2024 00:36:11", "instructor12@example.com", false, "Instructor 12", "password12", null },
                    { 13, "Bio for Instructor 13", "22/05/2024 00:36:11", "instructor13@example.com", false, "Instructor 13", "password13", null },
                    { 14, "Bio for Instructor 14", "22/05/2024 00:36:11", "instructor14@example.com", false, "Instructor 14", "password14", null },
                    { 15, "Bio for Instructor 15", "22/05/2024 00:36:11", "instructor15@example.com", false, "Instructor 15", "password15", null },
                    { 16, "Bio for Instructor 16", "22/05/2024 00:36:11", "instructor16@example.com", false, "Instructor 16", "password16", null },
                    { 17, "Bio for Instructor 17", "22/05/2024 00:36:11", "instructor17@example.com", false, "Instructor 17", "password17", null },
                    { 18, "Bio for Instructor 18", "22/05/2024 00:36:11", "instructor18@example.com", false, "Instructor 18", "password18", null },
                    { 19, "Bio for Instructor 19", "22/05/2024 00:36:11", "instructor19@example.com", false, "Instructor 19", "password19", null },
                    { 20, "Bio for Instructor 20", "22/05/2024 00:36:11", "instructor20@example.com", false, "Instructor 20", "password20", null },
                    { 21, "Bio for Instructor 21", "22/05/2024 00:36:11", "instructor21@example.com", false, "Instructor 21", "password21", null },
                    { 22, "Bio for Instructor 22", "22/05/2024 00:36:11", "instructor22@example.com", false, "Instructor 22", "password22", null },
                    { 23, "Bio for Instructor 23", "22/05/2024 00:36:11", "instructor23@example.com", false, "Instructor 23", "password23", null },
                    { 24, "Bio for Instructor 24", "22/05/2024 00:36:11", "instructor24@example.com", false, "Instructor 24", "password24", null },
                    { 25, "Bio for Instructor 25", "22/05/2024 00:36:11", "instructor25@example.com", false, "Instructor 25", "password25", null },
                    { 26, "Bio for Instructor 26", "22/05/2024 00:36:11", "instructor26@example.com", false, "Instructor 26", "password26", null },
                    { 27, "Bio for Instructor 27", "22/05/2024 00:36:11", "instructor27@example.com", false, "Instructor 27", "password27", null },
                    { 28, "Bio for Instructor 28", "22/05/2024 00:36:11", "instructor28@example.com", false, "Instructor 28", "password28", null },
                    { 29, "Bio for Instructor 29", "22/05/2024 00:36:11", "instructor29@example.com", false, "Instructor 29", "password29", null },
                    { 30, "Bio for Instructor 30", "22/05/2024 00:36:11", "instructor30@example.com", false, "Instructor 30", "password30", null }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfTrainees", "RedeemCode", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2162), 40, false, "Online", "Introduction to Programming", 5, 20, 25, null, new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2157), 10.5, 5 },
                    { 2, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2220), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2218), 15.199999999999999, 6 },
                    { 3, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2233), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, null, new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2232), 11.699999999999999, 15 },
                    { 4, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2246), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, null, new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2244), 13.5, 6 },
                    { 5, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the design and management of relational databases.", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2268), 50, false, "Online", "Database Design and Management", 7, 25, 30, null, new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2266), 14.1, 13 },
                    { 6, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2281), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2279), 12.300000000000001, 9 },
                    { 7, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2293), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, null, new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2291), 12.800000000000001, 1 },
                    { 8, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2348), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, null, new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2345), 13.199999999999999, 10 },
                    { 9, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of Python programming language.", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2365), 40, false, "Online", "Python Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 31, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2363), 10.800000000000001, 1 },
                    { 10, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2377), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, null, new DateTime(2024, 6, 2, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2375), 12.199999999999999, 14 },
                    { 11, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2389), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, null, new DateTime(2024, 6, 4, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2387), 13.5, 12 },
                    { 12, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers essential concepts in computer networks.", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2400), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, null, new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2399), 13.1, 14 },
                    { 13, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2414), 40, false, "Online", "Introduction to Linux", 5, 20, 25, null, new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2412), 10.6, 5 },
                    { 14, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2426), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, null, new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2425), 11.199999999999999, 10 },
                    { 15, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2438), 60, false, "Online", "Frontend Web Development", 7, 25, 30, null, new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2436), 15.800000000000001, 4 },
                    { 16, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2450), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2448), 12.5, 12 },
                    { 17, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2464), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, null, new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2462), 13.800000000000001, 7 },
                    { 18, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2475), 50, false, "Online", "Node.js Development", 6, 23, 20, null, new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2474), 12.300000000000001, 11 },
                    { 19, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2487), 45, false, "Online", "Databases for Developers", 6, 22, 25, null, new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2485), 13.1, 12 },
                    { 20, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2499), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, null, new DateTime(2024, 5, 31, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2497), 11.800000000000001, 1 },
                    { 21, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2513), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, null, new DateTime(2024, 6, 2, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2511), 12.5, 4 },
                    { 22, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of Ruby programming language.", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2525), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, null, new DateTime(2024, 6, 4, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2523), 13.199999999999999, 1 },
                    { 23, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2537), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, null, new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2535), 13.6, 1 },
                    { 24, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2548), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, null, new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2547), 10.9, 5 },
                    { 25, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2563), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, null, new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2560), 11.4, 3 },
                    { 26, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2574), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, null, new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2572), 15.199999999999999, 4 },
                    { 27, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2586), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, null, new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2584), 13.699999999999999, 3 },
                    { 28, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2598), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, null, new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2596), 14.300000000000001, 10 },
                    { 29, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2612), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, null, new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2610), 12.6, 5 },
                    { 30, "path/to/trainee/image.jpg", "22/05/2024 00:36:11", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2624), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, null, new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2623), 13.9, 15 }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainee",
                columns: new[] { "Id", "CourseId", "Result", "TraineeId" },
                values: new object[,]
                {
                    { 1, 20, 71.1613564945595m, 29 },
                    { 2, 24, 92.4907439582707m, 18 },
                    { 3, 2, 12.9025662252994m, 19 },
                    { 4, 3, 37.7301943626074m, 3 },
                    { 5, 4, 31.6867157531469m, 5 },
                    { 6, 2, 40.7925317353526m, 20 },
                    { 7, 10, 57.0923623681206m, 22 },
                    { 8, 15, 38.0620238384585m, 19 },
                    { 9, 24, 81.3724931776416m, 24 },
                    { 10, 26, 13.3557429146208m, 21 },
                    { 11, 13, 70.1447682081679m, 15 },
                    { 12, 22, 95.3605836207342m, 3 },
                    { 13, 24, 83.6084560882318m, 24 },
                    { 14, 14, 70.8110661248603m, 25 },
                    { 15, 20, 44.733141144009m, 18 },
                    { 16, 9, 53.0721816087976m, 17 },
                    { 17, 4, 58.474939678364m, 24 },
                    { 18, 19, 65.9728141082256m, 11 },
                    { 19, 18, 21.677144570921m, 22 },
                    { 20, 22, 83.2028729601518m, 13 },
                    { 21, 22, 53.1340170636616m, 8 },
                    { 22, 22, 81.0363177624544m, 3 },
                    { 23, 15, 24.1515382688823m, 22 },
                    { 24, 14, 65.2684078430843m, 20 },
                    { 25, 17, 1.04267310528149m, 7 },
                    { 26, 22, 90.0470547683466m, 28 },
                    { 27, 14, 46.1513249390682m, 11 },
                    { 28, 12, 14.1357229005456m, 26 },
                    { 29, 3, 72.1222062336048m, 23 },
                    { 30, 23, 45.7031320795825m, 23 },
                    { 31, 11, 80.2233991341976m, 28 },
                    { 32, 13, 89.3837419874334m, 15 },
                    { 33, 20, 41.7045441036839m, 22 },
                    { 34, 4, 35.2279553674243m, 11 },
                    { 35, 15, 9.76290859274842m, 23 },
                    { 36, 4, 67.8011244903698m, 5 },
                    { 37, 6, 76.2124657162286m, 5 },
                    { 38, 24, 97.342842701762m, 7 },
                    { 39, 3, 15.2115179720644m, 3 },
                    { 40, 30, 17.4607751899115m, 20 },
                    { 41, 22, 68.800003423162m, 9 },
                    { 42, 16, 18.6199002851801m, 8 },
                    { 43, 29, 99.5200876793074m, 19 },
                    { 44, 20, 19.3470159456515m, 30 },
                    { 45, 7, 99.8431462397312m, 21 },
                    { 46, 29, 48.8934210040138m, 12 },
                    { 47, 19, 97.2539183913734m, 23 },
                    { 48, 10, 0.0621498745850713m, 22 },
                    { 49, 25, 2.28132999920877m, 13 },
                    { 50, 16, 57.3858374123308m, 30 },
                    { 51, 22, 84.1850954172496m, 19 },
                    { 52, 4, 17.3540486475692m, 27 },
                    { 53, 17, 29.9701309723748m, 15 },
                    { 54, 27, 89.2896822073602m, 23 },
                    { 55, 8, 47.7359800428418m, 26 },
                    { 56, 12, 55.301824447828m, 20 },
                    { 57, 21, 62.1606711516248m, 18 },
                    { 58, 18, 88.8210264764184m, 28 },
                    { 59, 23, 63.1835572602905m, 7 },
                    { 60, 11, 3.92482094979036m, 22 },
                    { 61, 28, 10.3360631788836m, 17 },
                    { 62, 17, 63.8098088242855m, 16 },
                    { 63, 10, 90.2842674936858m, 19 },
                    { 64, 4, 92.0960082429779m, 30 },
                    { 65, 12, 18.2828211705224m, 22 },
                    { 66, 28, 37.9681971691773m, 15 },
                    { 67, 14, 49.180835544546m, 15 },
                    { 68, 17, 11.0709022980153m, 10 },
                    { 69, 20, 68.2443056394096m, 7 },
                    { 70, 4, 70.4067995030111m, 12 },
                    { 71, 11, 87.2274094868946m, 15 },
                    { 72, 23, 75.9061166107247m, 2 },
                    { 73, 25, 25.410835350131m, 18 },
                    { 74, 26, 30.3273550143638m, 21 },
                    { 75, 14, 14.1385934697575m, 1 },
                    { 76, 4, 80.7118921545628m, 23 },
                    { 77, 29, 58.2888189746469m, 4 },
                    { 78, 12, 0.519404163787707m, 22 },
                    { 79, 5, 47.1260235091441m, 4 },
                    { 80, 5, 93.2698730689095m, 10 },
                    { 81, 26, 72.9170197855459m, 6 },
                    { 82, 25, 86.8243057853334m, 22 },
                    { 83, 15, 77.6300596527255m, 18 },
                    { 84, 9, 24.4653279205569m, 15 },
                    { 85, 5, 83.8342103771048m, 10 },
                    { 86, 24, 71.9779584375532m, 3 },
                    { 87, 3, 97.7003080062211m, 6 },
                    { 88, 12, 93.0302130844177m, 24 },
                    { 89, 24, 98.562026249366m, 21 },
                    { 90, 18, 4.24208368843516m, 3 },
                    { 91, 1, 75.2972187987208m, 14 },
                    { 92, 28, 37.5011865958001m, 26 },
                    { 93, 17, 68.1738648647406m, 12 },
                    { 94, 24, 13.8406939544188m, 25 },
                    { 95, 7, 99.4019171514611m, 25 },
                    { 96, 22, 21.2985019870264m, 3 },
                    { 97, 9, 39.9154127218535m, 16 },
                    { 98, 25, 29.3481386863979m, 29 },
                    { 99, 1, 4.56972482477093m, 1 },
                    { 100, 30, 21.6426539838833m, 27 }
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
