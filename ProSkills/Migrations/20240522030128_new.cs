using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_instructor_instructorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTrainee_Course_CourseId",
                table: "CourseTrainee");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTrainee_Trainee_TraineeId",
                table: "CourseTrainee");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Course_CourseId",
                table: "Steps");

            migrationBuilder.RenameColumn(
                name: "country",
                table: "AspNetUsers",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Trainee",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "country",
                table: "Trainee",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Country",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    downloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
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
                    ChapterId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Description for Chapter 1 in Course 1", "Chapter 1 for Course 1", null },
                    { 2, 1, "Description for Chapter 2 in Course 1", "Chapter 2 for Course 1", null },
                    { 3, 1, "Description for Chapter 3 in Course 1", "Chapter 3 for Course 1", null },
                    { 4, 2, "Description for Chapter 1 in Course 2", "Chapter 1 for Course 2", null },
                    { 5, 2, "Description for Chapter 2 in Course 2", "Chapter 2 for Course 2", null },
                    { 6, 3, "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3", null },
                    { 7, 3, "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3", null },
                    { 8, 4, "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4", null },
                    { 9, 4, "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4", null },
                    { 10, 5, "Description for Chapter 1 in Course 5", "Chapter 1 for Course 5", null },
                    { 11, 5, "Description for Chapter 2 in Course 5", "Chapter 2 for Course 5", null },
                    { 12, 6, "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6", null },
                    { 13, 6, "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6", null },
                    { 14, 6, "Description for Chapter 3 in Course 6", "Chapter 3 for Course 6", null },
                    { 15, 7, "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7", null },
                    { 16, 7, "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7", null },
                    { 17, 7, "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7", null },
                    { 18, 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8", null },
                    { 19, 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8", null },
                    { 20, 8, "Description for Chapter 3 in Course 8", "Chapter 3 for Course 8", null },
                    { 21, 9, "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9", null },
                    { 22, 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9", null },
                    { 23, 9, "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9", null },
                    { 24, 10, "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10", null },
                    { 25, 10, "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10", null },
                    { 26, 10, "Description for Chapter 3 in Course 10", "Chapter 3 for Course 10", null }
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 21, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3144), new DateTime(2024, 5, 29, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3140), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3249), new DateTime(2024, 6, 5, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3247), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3264), new DateTime(2024, 5, 27, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3262), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 21, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3277), new DateTime(2024, 6, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3275), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 5, 29, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3288), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 11, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3304), new DateTime(2024, 6, 3, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3302), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 16, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 5, 30, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3316), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3329), new DateTime(2024, 5, 28, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3327), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 5, 31, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3339), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 6, 2, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3354), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 11, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3368), new DateTime(2024, 6, 4, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3366), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3379), new DateTime(2024, 6, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3377), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3391), new DateTime(2024, 5, 30, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3389), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 21, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 5, 29, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3403), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 6, 5, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3418), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3432), new DateTime(2024, 5, 27, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3430), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 11, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 6, 3, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3443), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 16, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3458), new DateTime(2024, 5, 30, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3456), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3470), new DateTime(2024, 5, 28, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3468), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 5, 31, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3525), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 6, 2, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 11, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3556), new DateTime(2024, 6, 4, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3554), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3568), new DateTime(2024, 6, 1, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3566), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3581), new DateTime(2024, 5, 30, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3579), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 21, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 5, 29, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3590), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 6, 5, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3605), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 5, 27, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3618), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 11, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3632), new DateTime(2024, 6, 3, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3630), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 16, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 5, 30, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3642), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 6, 26, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 5, 28, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3656), 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 95.1830523028127m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 87.0967537118982m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 79.3693078161534m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 78.5245677317938m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 94.4275410073437m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 66.2413586068184m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 13.6638686598027m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 57.7717607531089m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 38.0079429154451m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 38.111474407544m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 61.6700822134533m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 67.0651469744494m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 93.0750449701216m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 19.6439312944601m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 76.8613115620373m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 58.2434500362282m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 30.1087675417281m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 91.97543994663m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 32.872938568452m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 21.960162903106m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 3.19502144933148m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 40.5213779842661m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 45.8004846625121m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 41.2988823159094m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 15.5163519564237m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 86.7353050065908m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 6.89273728746637m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 75.5582994937424m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 2.00292068759136m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 9.1341416522749m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 64.7760170892097m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 49.9759484868719m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 74.0692382350289m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 83.7357956668835m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 66.6842296146362m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 98.5293823658679m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 1.78820253947151m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 47.8282223760957m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 19.6149135388507m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 2.95275067127573m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 13.3271195842427m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 89.9306776192999m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 40.4927874716999m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 74.4458592095196m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 18.9013559159102m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 19.5807613493128m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 17.6846918462917m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 11.9168291688508m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 79.8853516699861m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 0.477994093745993m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 39.5171638616661m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 44.9303510467839m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 89.0945595096323m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 72.4319430937536m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 55.5088718855958m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 43.5374756887351m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 2.86011770646851m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 23.7206851852479m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 50.30879745813m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 64.2223496227949m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 20.8090567972928m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 43.2793693797569m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 75.6918278858614m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 7.18368119627447m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 41.2940205143334m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 91.0144995805391m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 90.0690947771404m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 37.8541802741809m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 42.1375343006439m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 51.2416903453446m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 85.2558019312752m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 35.0218822028181m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 47.2664170120585m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 3, 19.8975474992023m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 5.70345820165116m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 64.3054498500926m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 71.8105702149174m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 14.3793628753474m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 32.6522310079836m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 45.6337044008892m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 90.1180956617521m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 96.346701594709m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 16.0846119762525m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 67.9817619260614m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 95.326167091381m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 3.04749917331352m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 91.935563738559m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 37.3478946253843m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 12.497697339639m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 7.38598213417832m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 71.2981244544709m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 57.3143886517684m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 46.6195847012297m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 37.2419201650997m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 90.5566288418496m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 3.24801886180023m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 27.6922824176196m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 70.4287994406775m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 41.0277593223561m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 22.8772889835886m, 8 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 06:01:27", null, null });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 1, 1, "Content for Lesson 1 in Chapter 1", null, new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 1", null },
                    { 2, 1, "Content for Lesson 2 in Chapter 1", null, new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 1", null },
                    { 3, 1, "Content for Lesson 3 in Chapter 1", null, new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 1", null },
                    { 4, 2, "Content for Lesson 1 in Chapter 2", null, new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 2", null },
                    { 5, 2, "Content for Lesson 2 in Chapter 2", null, new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 2", null },
                    { 6, 2, "Content for Lesson 3 in Chapter 2", null, new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 2", null },
                    { 7, 3, "Content for Lesson 1 in Chapter 3", null, new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 3", null },
                    { 8, 3, "Content for Lesson 2 in Chapter 3", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 3", null },
                    { 9, 3, "Content for Lesson 3 in Chapter 3", null, new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 3", null },
                    { 10, 4, "Content for Lesson 1 in Chapter 4", null, new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 4", null },
                    { 11, 4, "Content for Lesson 2 in Chapter 4", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 4", null },
                    { 12, 5, "Content for Lesson 1 in Chapter 5", null, new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 5", null },
                    { 13, 5, "Content for Lesson 2 in Chapter 5", null, new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 5", null },
                    { 14, 5, "Content for Lesson 3 in Chapter 5", null, new TimeSpan(0, 0, 56, 0, 0), "Lesson 3 for Chapter 5", null },
                    { 15, 6, "Content for Lesson 1 in Chapter 6", null, new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 6", null },
                    { 16, 6, "Content for Lesson 2 in Chapter 6", null, new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 6", null },
                    { 17, 6, "Content for Lesson 3 in Chapter 6", null, new TimeSpan(0, 0, 46, 0, 0), "Lesson 3 for Chapter 6", null },
                    { 18, 7, "Content for Lesson 1 in Chapter 7", null, new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 7", null },
                    { 19, 7, "Content for Lesson 2 in Chapter 7", null, new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 7", null },
                    { 20, 8, "Content for Lesson 1 in Chapter 8", null, new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 8", null },
                    { 21, 8, "Content for Lesson 2 in Chapter 8", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 8", null },
                    { 22, 8, "Content for Lesson 3 in Chapter 8", null, new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 8", null },
                    { 23, 9, "Content for Lesson 1 in Chapter 9", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 9", null },
                    { 24, 9, "Content for Lesson 2 in Chapter 9", null, new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 9", null },
                    { 25, 10, "Content for Lesson 1 in Chapter 10", null, new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 10", null },
                    { 26, 10, "Content for Lesson 2 in Chapter 10", null, new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 10", null },
                    { 27, 10, "Content for Lesson 3 in Chapter 10", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 10", null },
                    { 28, 11, "Content for Lesson 1 in Chapter 11", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 11", null },
                    { 29, 11, "Content for Lesson 2 in Chapter 11", null, new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 11", null },
                    { 30, 11, "Content for Lesson 3 in Chapter 11", null, new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 11", null },
                    { 31, 12, "Content for Lesson 1 in Chapter 12", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 12", null },
                    { 32, 12, "Content for Lesson 2 in Chapter 12", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 12", null },
                    { 33, 12, "Content for Lesson 3 in Chapter 12", null, new TimeSpan(0, 0, 56, 0, 0), "Lesson 3 for Chapter 12", null },
                    { 34, 13, "Content for Lesson 1 in Chapter 13", null, new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 13", null },
                    { 35, 13, "Content for Lesson 2 in Chapter 13", null, new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 13", null },
                    { 36, 13, "Content for Lesson 3 in Chapter 13", null, new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 13", null },
                    { 37, 14, "Content for Lesson 1 in Chapter 14", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 14", null },
                    { 38, 14, "Content for Lesson 2 in Chapter 14", null, new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 14", null },
                    { 39, 14, "Content for Lesson 3 in Chapter 14", null, new TimeSpan(0, 0, 17, 0, 0), "Lesson 3 for Chapter 14", null },
                    { 40, 15, "Content for Lesson 1 in Chapter 15", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 15", null },
                    { 41, 15, "Content for Lesson 2 in Chapter 15", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 15", null },
                    { 42, 15, "Content for Lesson 3 in Chapter 15", null, new TimeSpan(0, 0, 30, 0, 0), "Lesson 3 for Chapter 15", null },
                    { 43, 16, "Content for Lesson 1 in Chapter 16", null, new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 16", null },
                    { 44, 16, "Content for Lesson 2 in Chapter 16", null, new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 16", null },
                    { 45, 16, "Content for Lesson 3 in Chapter 16", null, new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 16", null },
                    { 46, 17, "Content for Lesson 1 in Chapter 17", null, new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 17", null },
                    { 47, 17, "Content for Lesson 2 in Chapter 17", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 17", null },
                    { 48, 18, "Content for Lesson 1 in Chapter 18", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 18", null },
                    { 49, 18, "Content for Lesson 2 in Chapter 18", null, new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 18", null },
                    { 50, 18, "Content for Lesson 3 in Chapter 18", null, new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 18", null },
                    { 51, 19, "Content for Lesson 1 in Chapter 19", null, new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 19", null },
                    { 52, 19, "Content for Lesson 2 in Chapter 19", null, new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 19", null },
                    { 53, 20, "Content for Lesson 1 in Chapter 20", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 20", null },
                    { 54, 20, "Content for Lesson 2 in Chapter 20", null, new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 20", null },
                    { 55, 20, "Content for Lesson 3 in Chapter 20", null, new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 20", null },
                    { 56, 21, "Content for Lesson 1 in Chapter 21", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 21", null },
                    { 57, 21, "Content for Lesson 2 in Chapter 21", null, new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 21", null },
                    { 58, 22, "Content for Lesson 1 in Chapter 22", null, new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 22", null },
                    { 59, 22, "Content for Lesson 2 in Chapter 22", null, new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22", null },
                    { 60, 22, "Content for Lesson 3 in Chapter 22", null, new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 22", null },
                    { 61, 23, "Content for Lesson 1 in Chapter 23", null, new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 23", null },
                    { 62, 23, "Content for Lesson 2 in Chapter 23", null, new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 23", null },
                    { 63, 23, "Content for Lesson 3 in Chapter 23", null, new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 23", null },
                    { 64, 24, "Content for Lesson 1 in Chapter 24", null, new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 24", null },
                    { 65, 24, "Content for Lesson 2 in Chapter 24", null, new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 24", null },
                    { 66, 24, "Content for Lesson 3 in Chapter 24", null, new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 24", null },
                    { 67, 25, "Content for Lesson 1 in Chapter 25", null, new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 25", null },
                    { 68, 25, "Content for Lesson 2 in Chapter 25", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 25", null },
                    { 69, 26, "Content for Lesson 1 in Chapter 26", null, new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 26", null },
                    { 70, 26, "Content for Lesson 2 in Chapter 26", null, new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 26", null },
                    { 71, 26, "Content for Lesson 3 in Chapter 26", null, new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 26", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ChapterId",
                table: "Lessons",
                column: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_instructor_instructorId",
                table: "Course",
                column: "instructorId",
                principalTable: "instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTrainee_Course_CourseId",
                table: "CourseTrainee",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTrainee_Trainee_TraineeId",
                table: "CourseTrainee",
                column: "TraineeId",
                principalTable: "Trainee",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Course_CourseId",
                table: "Steps",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_instructor_instructorId",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTrainee_Course_CourseId",
                table: "CourseTrainee");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTrainee_Trainee_TraineeId",
                table: "CourseTrainee");

            migrationBuilder.DropForeignKey(
                name: "FK_Steps_Course_CourseId",
                table: "Steps");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Trainee");

            migrationBuilder.DropColumn(
                name: "country",
                table: "Trainee");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "AspNetUsers",
                newName: "country");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2162), new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2157), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2220), new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2218), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2233), new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2232), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2246), new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2244), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2268), new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2266), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2281), new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2279), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2293), new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2291), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2348), new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2345), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2365), new DateTime(2024, 5, 31, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2363), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2377), new DateTime(2024, 6, 2, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2375), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2389), new DateTime(2024, 6, 4, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2387), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2399), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2414), new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2412), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2426), new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2425), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2438), new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2436), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2450), new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2448), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2464), new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2462), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2475), new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2474), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2487), new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2485), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2499), new DateTime(2024, 5, 31, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2497), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2513), new DateTime(2024, 6, 2, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2511) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2525), new DateTime(2024, 6, 4, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2523), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2537), new DateTime(2024, 6, 1, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2535), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2548), new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2547), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 21, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2563), new DateTime(2024, 5, 29, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2560), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 6, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2574), new DateTime(2024, 6, 5, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2572), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2586), new DateTime(2024, 5, 27, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2584), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 11, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2598), new DateTime(2024, 6, 3, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2596), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 7, 16, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2612), new DateTime(2024, 5, 30, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2610), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 00:36:11", new DateTime(2024, 6, 26, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2624), new DateTime(2024, 5, 28, 0, 36, 11, 510, DateTimeKind.Local).AddTicks(2623), 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 71.1613564945595m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 92.4907439582707m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 12.9025662252994m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 37.7301943626074m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 31.6867157531469m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 40.7925317353526m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 57.0923623681206m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 38.0620238384585m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 81.3724931776416m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 13.3557429146208m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 70.1447682081679m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 95.3605836207342m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 83.6084560882318m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 70.8110661248603m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 44.733141144009m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 53.0721816087976m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 58.474939678364m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 65.9728141082256m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 21.677144570921m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 83.2028729601518m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 53.1340170636616m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 81.0363177624544m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 24.1515382688823m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 65.2684078430843m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 1.04267310528149m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 90.0470547683466m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 46.1513249390682m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 14.1357229005456m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 72.1222062336048m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 45.7031320795825m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 80.2233991341976m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 89.3837419874334m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 41.7045441036839m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 35.2279553674243m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 9.76290859274842m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 67.8011244903698m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 76.2124657162286m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 97.342842701762m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 15.2115179720644m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 17.4607751899115m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 68.800003423162m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 18.6199002851801m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 99.5200876793074m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 19.3470159456515m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 99.8431462397312m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 48.8934210040138m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 97.2539183913734m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 0.0621498745850713m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 2.28132999920877m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 57.3858374123308m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 84.1850954172496m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 17.3540486475692m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 29.9701309723748m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 89.2896822073602m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 47.7359800428418m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 55.301824447828m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 62.1606711516248m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 88.8210264764184m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 63.1835572602905m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 3.92482094979036m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 10.3360631788836m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 63.8098088242855m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 90.2842674936858m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 92.0960082429779m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 18.2828211705224m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 37.9681971691773m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 49.180835544546m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 11.0709022980153m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 68.2443056394096m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 70.4067995030111m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 87.2274094868946m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 75.9061166107247m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 25.410835350131m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 26, 30.3273550143638m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 14.1385934697575m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 80.7118921545628m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 58.2888189746469m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 0.519404163787707m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 47.1260235091441m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 93.2698730689095m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 72.9170197855459m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 86.8243057853334m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 77.6300596527255m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 24.4653279205569m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 83.8342103771048m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 71.9779584375532m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 97.7003080062211m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 93.0302130844177m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 98.562026249366m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 4.24208368843516m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 75.2972187987208m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 37.5011865958001m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 68.1738648647406m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 13.8406939544188m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 99.4019171514611m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 21.2985019870264m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 39.9154127218535m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 29.3481386863979m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 4.56972482477093m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 21.6426539838833m, 27 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 00:36:11");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_instructor_instructorId",
                table: "Course",
                column: "instructorId",
                principalTable: "instructor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTrainee_Course_CourseId",
                table: "CourseTrainee",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTrainee_Trainee_TraineeId",
                table: "CourseTrainee",
                column: "TraineeId",
                principalTable: "Trainee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Steps_Course_CourseId",
                table: "Steps",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
