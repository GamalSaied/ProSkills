using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class @in : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 10, "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 10", "Chapter 3 for Course 10" });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7384), new DateTime(2024, 6, 24, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7382), 11 });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 6, 28, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7471), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 7, 23, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 6, 26, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7483) });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7604), new DateTime(2024, 7, 1, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7602), 1 });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:53:05 pm", new DateTime(2024, 8, 7, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7683), new DateTime(2024, 6, 30, 20, 53, 5, 801, DateTimeKind.Local).AddTicks(7681), 12 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 47.8937996984905m, 26 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 27, 22.0648323575918m });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 20, 83.4125187520903m });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 12.6539437909285m, 13 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 95.2957354570127m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 10, 71.3903931474592m });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 91.1697309867247m, 10 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 5, 59.1625817017144m });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 86.5970242663822m, 18 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 48.3160068793502m, 20 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 52.4227049837258m, 7 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 49.2457582614928m, 5 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 26.9992756692471m, 12 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 19, 75.3919162686418m });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 3", new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 4", new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 55, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new TimeSpan(0, 0, 33, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new TimeSpan(0, 0, 10, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new TimeSpan(0, 0, 56, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new TimeSpan(0, 0, 44, 0, 0));

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 7" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 8", new TimeSpan(0, 0, 45, 0, 0), "Lesson 3 for Chapter 8" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 9" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 10, 0, 0), "Lesson 3 for Chapter 10" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 12", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 12" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 13" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 14" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 15", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 15" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 16" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 17" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 18" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                column: "Time",
                value: new TimeSpan(0, 0, 19, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                column: "Time",
                value: new TimeSpan(0, 0, 21, 0, 0));

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                column: "Time",
                value: new TimeSpan(0, 0, 44, 0, 0));

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 25", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 26, "Content for Lesson 1 in Chapter 26", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 26" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 26, "Content for Lesson 2 in Chapter 26", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 26" });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProfilePictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

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
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 5, "Description for Chapter 3 in Course 5", "Chapter 3 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 3 in Course 6", "Chapter 3 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[] { 27, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6854), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6939), new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6938), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6950), new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6949), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 17, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6961), new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6959), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6991), new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(6989), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7059), new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7057), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7071), new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7070), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7079), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7095), new DateTime(2024, 6, 27, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7093), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7104), new DateTime(2024, 6, 29, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7103), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7114), new DateTime(2024, 7, 1, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7113), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7124), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7149), new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7147), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7159), new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7157), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7167), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7179), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7190), new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7189), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7200), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7211), new DateTime(2024, 6, 27, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7210), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 6, 29, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7222), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7234), new DateTime(2024, 7, 1, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7233), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7244), new DateTime(2024, 6, 28, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7242), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7253), new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7252), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 18, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7265), new DateTime(2024, 6, 25, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7264), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7275), new DateTime(2024, 7, 2, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7274), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7285), new DateTime(2024, 6, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7284), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 7, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7295), new DateTime(2024, 6, 30, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7293), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 8, 12, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7307), new DateTime(2024, 6, 26, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7305), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 8:50:06 pm", new DateTime(2024, 7, 23, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 6, 24, 20, 50, 6, 184, DateTimeKind.Local).AddTicks(7339), 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 29.2304573496523m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 77.2584920286288m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 30.370489916487m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 78.4444540462476m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 33.4262016275631m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 43.0587710759161m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 24, 74.1857275102714m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 33.2940037729702m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 4.22994460973907m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 87.5739786098969m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 16, 97.8100440729288m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 72.838044321346m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 71.9304899876743m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 7.9414219962881m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 41.2642863555616m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 65.7306229426696m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 76.0004226418612m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 46.1360176492361m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 9, 76.6667116115545m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 15.1330080911454m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 88.2671207345284m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 2.31945557192116m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 51.6792645524333m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 88.3343339440619m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 33.1965991079281m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 10.9616368364859m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 89.7133783862609m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 32.4478723557431m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 56.8432986838991m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 36.3655885760552m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 55.2623086623332m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 81.8030138895135m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 53.5295813442613m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 71.8643230490201m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 95.1055157326602m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 76.80160774419m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 24.4227137604087m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 4, 23.7847618401718m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 16.8855530839768m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 65.1895166769946m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 58.0177519038646m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 53.7821274426613m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 48.0640888305352m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 56.6807163012449m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 7.84023593211273m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 49.3508347225977m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 9.97614833374555m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 96.0082138988742m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 95.4655910908143m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 5.33144458353526m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 99.2717944752473m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 72.8460600047835m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 16.1478527224918m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 78.6383658243015m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 98.3909298749875m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 94.1970615886748m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 13.6162401594429m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 94.1073971262043m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 13.1730171219851m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 60.9081786306074m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 38.7846678355564m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 29.3997424164213m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 99.6902751787141m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 86.978063638781m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 55.1067722565041m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 79.9680659687628m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 5.97867456661884m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 95.5753604905131m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 61.6894892245441m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 18.7719521394621m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 62.9007877276497m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 26.0531097937538m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 63.3114648684706m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 5.0528100682095m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 50.8740259751658m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 10.5617015579769m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 95.0568516475796m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 37.2286345368669m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 37.3981599358652m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 51.7923149368271m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 72.5115340704126m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 47.883858935825m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 38.2633671949684m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 14.4632269088425m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 45.1971950276224m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 2.43867486193614m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 82.657390171702m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 34.4831387629028m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 63.0228003912307m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 40.8139255876849m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 2.70953881374156m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 27.0603348081718m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 62.9742825104302m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 17.0069968859174m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 58.5191829139555m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 66.5464366058894m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 48.6837129096466m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 69.5296989739603m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 28, 35.1511211326402m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 29.0615342552484m, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 19, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 14, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 1, "Content for Lesson 3 in Chapter 1", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 1" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 3 in Chapter 2", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 49, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new TimeSpan(0, 0, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new TimeSpan(0, 0, 53, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                column: "Time",
                value: new TimeSpan(0, 0, 38, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                column: "Time",
                value: new TimeSpan(0, 0, 35, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 3 in Chapter 8", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 34, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 3 in Chapter 13", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                column: "Time",
                value: new TimeSpan(0, 0, 32, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                column: "Time",
                value: new TimeSpan(0, 0, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                column: "Time",
                value: new TimeSpan(0, 0, 35, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 3 in Chapter 24", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 3 in Chapter 25", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 25" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 67, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 68, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" }
                });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/06/2024 8:50:06 pm");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 69, 27, "Content for Lesson 1 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 27", "https://sadat.vip/" },
                    { 70, 27, "Content for Lesson 2 in Chapter 27", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 27", "https://sadat.vip/" }
                });
        }
    }
}
