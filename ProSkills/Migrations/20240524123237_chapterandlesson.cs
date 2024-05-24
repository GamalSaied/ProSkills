using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class chapterandlesson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

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
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 23, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1543), new DateTime(2024, 5, 31, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1538), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 8, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1600), new DateTime(2024, 6, 7, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1598), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1613), new DateTime(2024, 5, 29, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1611), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 23, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1627), new DateTime(2024, 6, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1625), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 5, 31, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1647), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 13, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1662), new DateTime(2024, 6, 5, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1660), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 18, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1674), new DateTime(2024, 6, 1, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1672), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1686), new DateTime(2024, 5, 30, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1684), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1702), new DateTime(2024, 6, 2, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1700), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 8, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1714), new DateTime(2024, 6, 4, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1712), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 13, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1727), new DateTime(2024, 6, 6, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1725), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1739), new DateTime(2024, 6, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1737), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1753), new DateTime(2024, 6, 1, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1751), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 23, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1766), new DateTime(2024, 5, 31, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1764), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 8, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1778), new DateTime(2024, 6, 7, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1776), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 5, 29, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1788), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 13, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 6, 5, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1802), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 18, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1816), new DateTime(2024, 6, 1, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1814), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1828), new DateTime(2024, 5, 30, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(1826), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2271), new DateTime(2024, 6, 2, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2268), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 8, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2288), new DateTime(2024, 6, 4, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2286), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 13, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2301), new DateTime(2024, 6, 6, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2299), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2313), new DateTime(2024, 6, 3, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2311), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2325), new DateTime(2024, 6, 1, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2323), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 23, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2339), new DateTime(2024, 5, 31, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2337), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 8, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2351), new DateTime(2024, 6, 7, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2349), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2363), new DateTime(2024, 5, 29, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 13, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2375), new DateTime(2024, 6, 5, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2373), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 7, 18, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2390), new DateTime(2024, 6, 1, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2388), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:32:36", new DateTime(2024, 6, 28, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 5, 30, 15, 32, 36, 318, DateTimeKind.Local).AddTicks(2400), 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 34.3838199585314m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 88.3023611673383m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 60.1717482504511m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 96.277977751814m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 50.7925808139935m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 70.3313148323202m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 12.4296853289371m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 47.2200336630706m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 71.015525034857m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 10.6570913671663m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 47.8528086338664m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 42.7897510877506m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 5.01453242966312m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 55.6004333408984m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 86.6392817573534m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 14.3281746685096m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 84.7776868649202m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 92.8523270416994m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 48.1521045637908m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 75.5521295664957m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 26.3932380953833m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 63.6817782710603m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 29.2870902205559m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 12.494926037796m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 59.5366091225084m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 67.7226771970251m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 24.2697668981533m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 87.6022931719078m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 10, 33.6077064817174m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 87.8140169231233m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 59.7449357383949m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 26.6153175858051m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 40.8907080460504m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 56.6974165442874m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 4.51904521864043m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 89.6349087917199m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 98.1621946412244m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 87.0220932114896m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 32.7017036939198m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 60.3468278385698m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 78.3858395165178m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 64.2267144086699m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 59.9041480657899m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 3, 64.9536822153613m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 25.1027494138993m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 84.9345732341876m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 40.5920825021119m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 79.091482193904m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 5.36255894035967m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 22.433525225997m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 37.5773171167364m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 97.5340485606094m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 38.1566273953445m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 58.6562352182957m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 86.816921629703m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 14.8885653950444m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 27.7287517619201m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 4.19772917092535m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 46.7604606877138m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 52.114776795779m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 29.6957639796751m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 73.5476520937904m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 52.1662162304113m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 19.4954035530916m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 32.7596659172034m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 31.332173108954m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 54.3982783891342m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 0.60697345643892m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 8.70605489448181m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 91.6991647367827m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 49.1524152514106m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 31.4730926041025m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 22.4835773186325m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 8.29783519480816m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 43.4120829286999m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 32.3908928554487m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 55.1702566166691m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 61.5823439372001m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 78.1292469066354m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 99.5926380435397m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 94.8319742706619m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 67.2655382820489m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 23.1925046471915m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 57.4435142505981m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 21.2779339966969m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 58.8119653976868m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 13.6855004838361m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 33.4407882841445m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 27.3051908139579m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 70.2792224666796m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 16.0518376738366m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 9.29616481549623m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 25.0290255430754m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 33.3233758891505m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 51.5779620483889m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 58.5424086360256m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 22, 42.5342086094179m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 76.3900562859464m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 10, 35.1109135639002m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 2.85740271162159m, 22 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 21, 0, 0));

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
                column: "Time",
                value: new TimeSpan(0, 0, 28, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 44, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 52, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 50, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeSpan(0, 0, 49, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeSpan(0, 0, 29, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeSpan(0, 0, 37, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new TimeSpan(0, 0, 56, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 35, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 3 in Chapter 5", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 8", "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 3 in Chapter 12", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 52, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 23, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 29, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 3 in Chapter 24", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 62, 25, "Content for Lesson 3 in Chapter 25", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "24/05/2024 15:32:36");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 26, 10, "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 23, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4186), new DateTime(2024, 5, 31, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4180), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 8, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4238), new DateTime(2024, 6, 7, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4235), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4250), new DateTime(2024, 5, 29, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4248), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 23, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4264), new DateTime(2024, 6, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4262), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 5, 31, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4286), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 13, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 6, 5, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4299), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 18, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4313), new DateTime(2024, 6, 1, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4311), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 5, 30, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4323), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4342), new DateTime(2024, 6, 2, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4339), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 8, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4354), new DateTime(2024, 6, 4, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4352), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 13, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4366), new DateTime(2024, 6, 6, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4365), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4378), new DateTime(2024, 6, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4376), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4394), new DateTime(2024, 6, 1, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4392), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 23, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 5, 31, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4404), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 8, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4418), new DateTime(2024, 6, 7, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4416), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4431), new DateTime(2024, 5, 29, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4430), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 13, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4446), new DateTime(2024, 6, 5, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4444), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 18, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4458), new DateTime(2024, 6, 1, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4456), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 5, 30, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4468), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4525), new DateTime(2024, 6, 2, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4522), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 8, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4541), new DateTime(2024, 6, 4, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4539), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 13, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4553), new DateTime(2024, 6, 6, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4551), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4565), new DateTime(2024, 6, 3, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4563), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 6, 1, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4575), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 23, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 5, 31, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4589), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 8, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 6, 7, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4602), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 5, 29, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 13, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 6, 5, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4626), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 7, 18, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4643), new DateTime(2024, 6, 1, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4641), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "24/05/2024 15:31:41", new DateTime(2024, 6, 28, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 5, 30, 15, 31, 41, 28, DateTimeKind.Local).AddTicks(4653), 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 81.2804774441258m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 71.9595815594982m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 74.8493582630084m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 51.3566873739359m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 89.8449260234023m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 18.2881167255378m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 11.0514614822378m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 90.9269688539021m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 44.4964871192524m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 65.434155377333m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 5.99450257891387m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 0.134079298178247m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 44.1037546972156m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 73.9037574365472m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 77.3437691014569m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 64.952370409513m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 24.179278817068m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 18.3464020583567m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 16.9663300670855m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 59.3851927294548m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 97.1327467062642m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 88.9763445939675m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 22.5933377518911m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 87.4344407179992m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 30.4852981991604m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 86.9287267640403m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 2.59433335461042m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 84.3159758663372m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 23, 47.98227925872m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 75.4310941268303m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 45.4465101033633m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 2.60567561723963m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 34.3334350819235m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 47.0591961586097m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 33.0425349152463m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 41.296387874231m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 90.091544611856m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 62.791269830242m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 4.64372117762886m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 59.8875815321108m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 16.4642089165916m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 90.9502501883792m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 5.73900230370822m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 10, 74.7623682681034m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 69.9405144431166m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 82.6734701390467m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 34.1398940084843m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 57.2132007505302m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 52.4119855799568m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 93.696831000589m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 25.4324850448353m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 92.8338517498968m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 98.5714176941547m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 94.1326980414403m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 92.7774241727385m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 83.8983581662097m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 15.0801898949434m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 53.4074073247239m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 82.5152213500561m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 88.9398072929225m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 79.2015871719404m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 6.39319296673166m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 80.3323545500709m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 26.4281010401767m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 32.3337473033857m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 79.120617294603m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 96.2969800403621m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 48.1468320199564m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 65.6480349751126m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 30.1523489318172m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 54.2438046396111m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 24.3454106919503m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 21.1947447426098m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 43.9889563001081m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 33.0269610965019m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 25.3859936117145m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 1.64167300793103m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 82.88323728321m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 41.9616741450583m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 73.2101513544002m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 27.4066464012263m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 4.92750248841729m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 2.36832523888306m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 40.8923248297979m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 0.197782938747038m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 82.15889919407m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 85.3048190381481m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 18.7407199907105m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 63.9238234784064m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 15.6367715228294m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 31.7469046516386m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 9.20307264664661m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 14.5588706443065m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 72.9633316083263m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 24.5328126402906m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 99.6850520105273m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 9, 70.2337943685004m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 94.3214068167706m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 7, 25.9444511829357m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 58.659943395956m, 2 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 58, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 54, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 47, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 13, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 15, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 10, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeSpan(0, 0, 19, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeSpan(0, 0, 27, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeSpan(0, 0, 57, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new TimeSpan(0, 0, 24, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 28, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 40, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 8", "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 52, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 3 in Chapter 12", new TimeSpan(0, 0, 53, 0, 0), "Lesson 3 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 26, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 3 in Chapter 24", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 26, "Content for Lesson 1 in Chapter 26", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 26" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 26, "Content for Lesson 2 in Chapter 26", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 26" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 26, "Content for Lesson 3 in Chapter 26", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 26" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "24/05/2024 15:31:41");
        }
    }
}
