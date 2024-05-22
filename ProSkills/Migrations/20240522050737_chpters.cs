using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class chpters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59);

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
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 2, "Description for Chapter 1 in Course 2", "Chapter 1 for Course 2", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 2", "Chapter 2 for Course 2", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 3, "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 4, "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 5, "Description for Chapter 3 in Course 5", "Chapter 3 for Course 5", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 15,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                column: "downloadLink",
                value: "https://sadat.vip/");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 9, "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 10, "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 10, "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 21, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 5, 29, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(661), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 6, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(721), new DateTime(2024, 6, 5, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(719), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(748), new DateTime(2024, 5, 27, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(745), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 21, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(761), new DateTime(2024, 6, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(759), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(774), new DateTime(2024, 5, 29, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(771), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 11, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(785), new DateTime(2024, 6, 3, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(783), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 16, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(800), new DateTime(2024, 5, 30, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(798), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(812), new DateTime(2024, 5, 28, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(810), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(823), new DateTime(2024, 5, 31, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(822), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 6, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(835), new DateTime(2024, 6, 2, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(833), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 11, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(853), new DateTime(2024, 6, 4, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(851), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(865), new DateTime(2024, 6, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(863), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(877), new DateTime(2024, 5, 30, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(875), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 21, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(889), new DateTime(2024, 5, 29, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(887), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 6, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(903), new DateTime(2024, 6, 5, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(901), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(915), new DateTime(2024, 5, 27, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(913), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 11, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(926), new DateTime(2024, 6, 3, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(924), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 16, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(938), new DateTime(2024, 5, 30, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(936), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(952), new DateTime(2024, 5, 28, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(950), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 5, 31, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1008), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 6, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1025), new DateTime(2024, 6, 2, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1024), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 11, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1037), new DateTime(2024, 6, 4, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1035), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1053), new DateTime(2024, 6, 1, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1051), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1065), new DateTime(2024, 5, 30, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1063), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 21, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1077), new DateTime(2024, 5, 29, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1075), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 6, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1089), new DateTime(2024, 6, 5, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1088), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1104), new DateTime(2024, 5, 27, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1102), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 11, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1116), new DateTime(2024, 6, 3, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1114), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 7, 16, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1128), new DateTime(2024, 5, 30, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1126), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 08:07:36", new DateTime(2024, 6, 26, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1140), new DateTime(2024, 5, 28, 8, 7, 36, 916, DateTimeKind.Local).AddTicks(1138), 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 82.8140473016216m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 52.870605664444m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 93.6611993110084m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 57.9068455539501m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 82.8939958942981m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 75.9474375062104m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 31.3422837399989m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 90.3672110426584m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 56.83578445136m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 37.6125510518142m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 7.97721646305344m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 79.3621922601725m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 66.616144517367m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 65.8614287763862m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 93.985820036911m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 31.7470706091697m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 19.446870118966m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 45.002051356315m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 10.8270918108261m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 43.5928999642214m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 78.1185482112418m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 98.6320145320974m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 14.4181287237562m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 53.8562591234962m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 49.1997195606339m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 24.435941973659m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 66.6508462416312m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 42.4274229240685m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 25.7477228394095m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 37.2566780686171m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 2, 51.7791873666458m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 90.0901879066012m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 99.9061811651702m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 12.1937697172821m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 35.9101428759785m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 57.5059797894224m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 25.7109041400169m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 11.9756272492762m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 4.47679579745534m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 92.3502953842794m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 63.8605419797085m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 29.5865703264069m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 52.2540389205962m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 71.5951792537969m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 67.0113075130606m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 39.4663193771102m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 29.6283214876633m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 94.6544392200151m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 98.1050712184014m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 77.277740281176m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 59.2012021228411m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 53.0348439252833m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 29.2619168412851m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 72.644112786985m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 36.6463062112709m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 40.6317279022722m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 50.1149529166523m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 76.720755640904m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 27, 60.5249953339909m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 34.5744272682045m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 82.1889874467124m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 96.9146043003948m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 13.9596404158093m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 81.4667981130458m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 3.64033793523707m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 32.4532838742729m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 19.5663347357642m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 5.76198141250163m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 75.8570612332846m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 44.5081204274753m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 2.85967917938023m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 58.6145523786507m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 19.2922289339899m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 92.6048689739322m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 61.143659925951m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 33.7994882452183m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 4.13653440114712m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 58.484063219717m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 48.5219863919705m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 4.45028656187941m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 30.8972223705415m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 6.99213362143702m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 56.7542438682385m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 67.6827084048858m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 40.6954102770298m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 77.4361935988137m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 42.6059820467051m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 8.04838126082759m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 93.1967131067614m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 16, 28.6869465410544m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 26.4408793916483m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 22.9065578648098m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 24.3380572208627m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 3.08252481731258m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 18.7974406557162m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 1.09875929740103m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 53.6906899634719m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 61.352278268484m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 74.5729911769748m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 56.8243306189725m, 24 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 55, 0, 0), "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 3, "Content for Lesson 1 in Chapter 3", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 3", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 3", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 3", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 3 in Chapter 3", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 3 for Chapter 3", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 4, "Content for Lesson 1 in Chapter 4", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 4", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 4", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 4", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 5", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 5", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 5", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 3 in Chapter 5", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 3 for Chapter 5", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 6", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 6", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 6", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 7", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 7", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 8", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 8", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 2 for Chapter 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 9", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 3 in Chapter 10", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 11", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 11", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 3 in Chapter 11", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 11", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 12", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 12", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 13", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 13", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 14", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 14", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 15", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 15", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 16", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 16", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 17", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 17", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 17, "Content for Lesson 3 in Chapter 17", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 3 for Chapter 17", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 18", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 18", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 18", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 19", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 30, 0, 0), "Lesson 2 for Chapter 19", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 19, "Content for Lesson 3 in Chapter 19", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 19", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 20", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 20", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 29, 0, 0), "Lesson 3 for Chapter 20", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 21", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 21", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 21", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 22", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 22", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 08:07:36");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 1,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 2,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 1, "Description for Chapter 3 in Course 1", "Chapter 3 for Course 1", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 2", "Chapter 1 for Course 2", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 2, "Description for Chapter 2 in Course 2", "Chapter 2 for Course 2", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 3, "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 6, "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 3 in Course 6", "Chapter 3 for Course 6", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 15,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                column: "downloadLink",
                value: null);

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 7, "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 8, "Description for Chapter 3 in Course 8", "Chapter 3 for Course 8", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Title", "downloadLink" },
                values: new object[] { "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9", null });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Description", "Title", "downloadLink" },
                values: new object[] { 9, "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9", null });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "Title", "downloadLink" },
                values: new object[,]
                {
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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 06:01:27", new DateTime(2024, 7, 6, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 6, 2, 6, 1, 27, 690, DateTimeKind.Local).AddTicks(3540), 4 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 79.3693078161534m, 13 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 57.7717607531089m, 22 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 40.5213779842661m, 10 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 12, 64.7760170892097m });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 89.9306776192999m, 15 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 26, 50.30879745813m });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 75.6918278858614m, 15 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 91.0144995805391m, 5 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 42.1375343006439m, 30 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 19.8975474992023m, 21 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 20, 7.38598213417832m });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 37.2419201650997m, 24 });

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
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { null, new TimeSpan(0, 0, 53, 0, 0), null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { null, new TimeSpan(0, 0, 17, 0, 0), null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { null, new TimeSpan(0, 0, 20, 0, 0), null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { null, new TimeSpan(0, 0, 42, 0, 0), null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "TaskLink", "Time", "downloadLink" },
                values: new object[] { null, new TimeSpan(0, 0, 23, 0, 0), null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 2, "Content for Lesson 3 in Chapter 2", null, new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 2", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 3", null, new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 3", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 3", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 3", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 3, "Content for Lesson 3 in Chapter 3", null, new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 3", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", null, new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 4", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 4, "Content for Lesson 2 in Chapter 4", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 4", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 5", null, new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 5", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 2 in Chapter 5", null, new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 5", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 5, "Content for Lesson 3 in Chapter 5", null, new TimeSpan(0, 0, 56, 0, 0), "Lesson 3 for Chapter 5", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 6", null, new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 6", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", null, new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 6", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 6, "Content for Lesson 3 in Chapter 6", null, new TimeSpan(0, 0, 46, 0, 0), "Lesson 3 for Chapter 6", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", null, new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 7", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", null, new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 7", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", null, new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 8", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 8", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 8, "Content for Lesson 3 in Chapter 8", null, new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 8", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 9", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", null, new TimeSpan(0, 0, 51, 0, 0), "Lesson 2 for Chapter 9", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 10", null, new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 10", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", null, new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 10", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 10", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { "Content for Lesson 1 in Chapter 11", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 11", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", null, new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 11", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 11, "Content for Lesson 3 in Chapter 11", null, new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 11", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 12", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 12", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 12, "Content for Lesson 3 in Chapter 12", null, new TimeSpan(0, 0, 56, 0, 0), "Lesson 3 for Chapter 12", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", null, new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 13", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", null, new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 13", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 13, "Content for Lesson 3 in Chapter 13", null, new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 13", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", null, new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 14", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", null, new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 14", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", null, new TimeSpan(0, 0, 17, 0, 0), "Lesson 3 for Chapter 14", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 15", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 15", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 15, "Content for Lesson 3 in Chapter 15", null, new TimeSpan(0, 0, 30, 0, 0), "Lesson 3 for Chapter 15", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", null, new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 16", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", null, new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 16", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", null, new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 16", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", null, new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 17", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", null, new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 17", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", null, new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 18", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", null, new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 18", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", null, new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 18", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", null, new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 19", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", null, new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 19", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 20", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", null, new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 20", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", null, new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 20", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", null, new TimeSpan(0, 0, 38, 0, 0), "Lesson 1 for Chapter 21", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", null, new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 21", null });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", null, new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 22", null });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 59, 22, "Content for Lesson 2 in Chapter 22", null, new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22", null },
                    { 60, 22, "Content for Lesson 3 in Chapter 22", null, new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 22", null },
                    { 61, 23, "Content for Lesson 1 in Chapter 23", null, new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 23", null },
                    { 62, 23, "Content for Lesson 2 in Chapter 23", null, new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 23", null },
                    { 63, 23, "Content for Lesson 3 in Chapter 23", null, new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 23", null }
                });

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
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 06:01:27");

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
                    { 64, 24, "Content for Lesson 1 in Chapter 24", null, new TimeSpan(0, 0, 31, 0, 0), "Lesson 1 for Chapter 24", null },
                    { 65, 24, "Content for Lesson 2 in Chapter 24", null, new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 24", null },
                    { 66, 24, "Content for Lesson 3 in Chapter 24", null, new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 24", null },
                    { 67, 25, "Content for Lesson 1 in Chapter 25", null, new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 25", null },
                    { 68, 25, "Content for Lesson 2 in Chapter 25", null, new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 25", null },
                    { 69, 26, "Content for Lesson 1 in Chapter 26", null, new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 26", null },
                    { 70, 26, "Content for Lesson 2 in Chapter 26", null, new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 26", null },
                    { 71, 26, "Content for Lesson 3 in Chapter 26", null, new TimeSpan(0, 0, 13, 0, 0), "Lesson 3 for Chapter 26", null }
                });
        }
    }
}
