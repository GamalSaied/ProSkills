using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 1, "Description for Chapter 3 in Course 1", "Chapter 3 for Course 1" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 2", "Chapter 1 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 2", "Chapter 2 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 4, "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 5", "Chapter 1 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 5", "Chapter 2 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 18, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 6, 25, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(3955), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4006), new DateTime(2024, 7, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4004), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4016), new DateTime(2024, 6, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4015), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 17, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4026), new DateTime(2024, 6, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4025), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4045), new DateTime(2024, 6, 25, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4044), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 6, 30, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4054), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 12, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4066), new DateTime(2024, 6, 26, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4064), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 6, 24, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4074) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4087), new DateTime(2024, 6, 27, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4085), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4121), new DateTime(2024, 6, 29, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4119), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4132), new DateTime(2024, 7, 1, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4130), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 6, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4154), new DateTime(2024, 6, 26, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4152), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 18, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4163), new DateTime(2024, 6, 25, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4162), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4172), new DateTime(2024, 7, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4171), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4182), new DateTime(2024, 6, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4180), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4194), new DateTime(2024, 6, 30, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4192), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 12, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 6, 26, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4202), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4213), new DateTime(2024, 6, 24, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4211), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 6, 27, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4221), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4234), new DateTime(2024, 6, 29, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4233), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4244), new DateTime(2024, 7, 1, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4253), new DateTime(2024, 6, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4252), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 6, 26, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4261), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 18, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4274), new DateTime(2024, 6, 25, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4273), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4283), new DateTime(2024, 7, 2, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4282), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 6, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4291), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 6, 30, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4300) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 12, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 6, 26, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4311), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4322), new DateTime(2024, 6, 24, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4321), 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 89.4622518939256m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 13.6217942418732m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 12, 55.1565078604477m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 35.5102536738466m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 73.8980718507581m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 93.5365565751963m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 57.912215995472m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 56.7594521783322m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 8.34167022709729m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 21.7680462420152m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 15.8735408209392m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 75.3592391574779m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 34.1507215437118m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 24.3100878292392m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 5, 33.6383844289946m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 48.6943407327045m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 77.0946699629032m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 57.9343488592255m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 22.4468187321247m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 34.419281235527m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 20.6128715851394m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 4.04490025876908m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 26.8142635636445m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 38.0447716388986m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 78.3596069220274m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 54.4959390346754m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 61.4178072418288m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 20.2804043214987m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 20.9609025830293m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 27.1040830845612m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 43.0853535905655m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 78.0025767264469m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 24.134897611349m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 90.2027171532726m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 78.841611090927m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 82.6440774366923m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 15.2427530176584m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 70.5499164863768m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 12.0297994085021m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 80.3069353903803m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 60.6282761735586m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 64.0788662038923m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 3.79359403544652m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 91.93908507749m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 2, 57.0846361969349m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 45.9494539187224m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 65.1044950965776m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 76.4694618695931m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 55.2023417906825m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 95.090536720351m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 84.2652390619075m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 30.8833760106098m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 15.351481055305m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 50.6595948398533m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 42.3526884455647m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 62.9179612607349m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 89.4870375539891m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 70.343884385346m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 35.1191794427527m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 73.2949022957991m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 30.6281636262594m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 73.2949754510266m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 9.34509450907435m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 3.21734633250156m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 64.4059881373758m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 7.56336570622983m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 87.4818378247659m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 63.5501994954246m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 10.1306668062899m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 39.734066439869m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 91.7684543715229m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 34.8401220169161m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 63.3422935827733m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 74.5581524579089m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 95.8531631639915m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 27.6916156091616m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 59.5688229019036m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 63.871336405145m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 92.2610141035756m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 64.9312313522976m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 5.42532372161995m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 98.8977497433122m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 15.4147480579843m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 95.561449354487m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 22.8699091921742m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 69.1651413997159m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 97.0562140952736m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 82.0721259600414m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 8.36014647360681m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 12.1278347483506m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 38.7338488815921m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 35.2844016609194m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 30.0671074168634m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 22.4501310662825m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 98.9200428082476m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 49.598781666055m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 3.33304147919808m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 11.3476563390118m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 38.0826983584033m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 94.407545327262m, 7 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 33, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 59, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 29, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 22, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 48, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 45, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 4, "Content for Lesson 1 in Chapter 4", "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 3 in Chapter 11", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 24, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 42, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 3 in Chapter 15", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 10:36:30 pm");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 2, "Description for Chapter 1 in Course 2", "Chapter 1 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 2", "Chapter 2 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 2", "Chapter 3 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 5, "Description for Chapter 1 in Course 5", "Chapter 1 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 5", "Chapter 2 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 5", "Chapter 3 for Course 5" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[] { 26, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 18, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7227), new DateTime(2024, 6, 25, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7221), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7294), new DateTime(2024, 7, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7291), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 6, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7315), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 17, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7329), new DateTime(2024, 6, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7328), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7343), new DateTime(2024, 6, 25, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7341), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7355), new DateTime(2024, 6, 30, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7353), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 12, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7371), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7369), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7384), new DateTime(2024, 6, 24, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 6, 27, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7429), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7445), new DateTime(2024, 6, 29, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7443), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7460), new DateTime(2024, 7, 1, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7458), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 6, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7471) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7483), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 18, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 6, 25, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7496), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 7, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7511), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7525), new DateTime(2024, 6, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7523), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7537), new DateTime(2024, 6, 30, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7536), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 12, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7547), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 6, 24, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7562), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7577), new DateTime(2024, 6, 27, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7575), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7590), new DateTime(2024, 6, 29, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7589), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 7, 1, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7619), new DateTime(2024, 6, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7617), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7631), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7629), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 18, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 6, 25, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7642), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7656), new DateTime(2024, 7, 2, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7654), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7671), new DateTime(2024, 6, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7669), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 6, 30, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7681) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 12, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7695), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7693), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7707), new DateTime(2024, 6, 24, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7705), 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 24.1665563659523m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 18.7611019968898m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 4, 47.8937996984905m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 13.2771003408881m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 10.3499518279874m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 49.9027710349078m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 22.0648323575918m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 93.9751645805778m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 37.5100572756711m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 57.6909491333451m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 83.4125187520903m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 64.338002995371m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 28.2652610867778m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 15.1391877534137m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 3, 12.6539437909285m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 14.9809113706144m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 0.874174686671636m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 95.2957354570127m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 71.3903931474592m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 1.24676715059955m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 91.6727453288148m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 59.5642992988722m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 91.985671039709m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 11.4472947314672m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 1.15702720033702m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 91.1697309867247m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 61.4919637485133m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 53.5251086749311m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 67.5419635296237m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 80.3339376679587m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 8.70369965102685m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 55.6110000901812m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 70.9183447107226m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 89.04316483831m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 12.1452745826112m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 35.2062230801636m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 69.6389700750324m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 59.1625817017144m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 57.8234411881342m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 9.51041548212574m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 77.8815062419535m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 18.5337298078787m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 86.5970242663822m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 25.2674296046485m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 19, 48.3160068793502m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 18.6058739656262m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 52.8166959657962m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 70.4531142501183m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 3.58120599626942m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 37.0717436882001m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 83.4215598750097m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 77.2045439938989m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 78.8264452993492m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 70.7235875782006m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 52.4227049837258m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 75.791131069125m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 67.0958765518445m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 16.831039090559m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 40.4656832629663m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 35.0658789848398m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 94.0858049952451m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 49.3398940249603m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 57.2190173957378m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 83.6569063135269m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 71.273855171257m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 56.344668817733m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 49.2457582614928m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 56.5853996992467m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 32.9342550058715m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 81.1619706084691m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 22.2291162826716m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 93.332574141562m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 52.8884372834702m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 72.1361628206172m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 34.3079988550912m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 87.4408404197978m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 4.93802676013368m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 95.9518235312349m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 92.4890581298871m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 24.9687616741872m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 84.6742234148864m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 23.2698647787679m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 71.267755900276m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 1.33416778457872m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 88.6284065362198m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 47.1121495524649m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 22.4564632798237m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 34.5099946331597m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 97.4167491492434m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 77.7854405758692m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 34.4665149923899m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 43.3988213792904m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 2.96322851697366m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 11.7000576970297m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 89.2361604913885m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 28.386545596355m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 26.9992756692471m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 56.2922546453726m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 75.3919162686418m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 20.3073474985756m, 6 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 48, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 15, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 46, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 35, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 37, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 58, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 3, "Content for Lesson 3 in Chapter 3", "Lesson 3 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 3 in Chapter 4", new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 3 in Chapter 5", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 3 in Chapter 8", new TimeSpan(0, 0, 45, 0, 0), "Lesson 3 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 50, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 3 in Chapter 12", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 3 in Chapter 15", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 60, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 62, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 64, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" }
                });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 8:53:05 pm");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 65, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 66, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" }
                });
        }
    }
}
