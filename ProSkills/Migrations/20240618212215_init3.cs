using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 2, "Description for Chapter 3 in Course 2", "Chapter 3 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 3, "Description for Chapter 3 in Course 3", "Chapter 3 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 19, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7426), new DateTime(2024, 6, 26, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7421) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7484), new DateTime(2024, 7, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7482), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 6, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7494), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 18, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 6, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7514), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7527), new DateTime(2024, 6, 26, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7526), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 8, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 7, 1, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7537), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 13, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 6, 27, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7548), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7564), new DateTime(2024, 6, 25, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7562), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7575), new DateTime(2024, 6, 28, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7573), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7586), new DateTime(2024, 6, 30, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7584), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 8, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7597), new DateTime(2024, 7, 2, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7595), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7611), new DateTime(2024, 6, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7610), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7622), new DateTime(2024, 6, 27, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7621), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 19, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7634), new DateTime(2024, 6, 26, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7632), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7644), new DateTime(2024, 7, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7643), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7658), new DateTime(2024, 6, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7657), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 8, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7670), new DateTime(2024, 7, 1, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7668), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 13, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 6, 27, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7679), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7719), new DateTime(2024, 6, 25, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7717), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 6, 28, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7731), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7744), new DateTime(2024, 6, 30, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7742), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 8, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7755), new DateTime(2024, 7, 2, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7754), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7766), new DateTime(2024, 6, 29, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7764), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7779), new DateTime(2024, 6, 27, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7778), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 19, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7790), new DateTime(2024, 6, 26, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7789), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7801), new DateTime(2024, 7, 3, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7800), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7813), new DateTime(2024, 6, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7811), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 8, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7826), new DateTime(2024, 7, 1, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7825), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 8, 13, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7837), new DateTime(2024, 6, 27, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7835), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 12:22:14 am", new DateTime(2024, 7, 24, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7848), new DateTime(2024, 6, 25, 0, 22, 14, 858, DateTimeKind.Local).AddTicks(7846), 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 80.3310938864859m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 28.3381534268046m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 81.7732426048666m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 1, 90.9516012879648m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 92.4773777486615m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 97.1016173802379m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 83.0879148952294m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 55.4748128882851m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 80.3924304993692m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 34.6369511394839m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 82.2701508188935m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 27.4042909558908m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 52.3599270879668m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 9.35780292799429m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 13.1538134597191m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 39.3184977981643m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 13.2519681371103m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 95.1218019097306m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 64.3136195666148m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 50.6142551547504m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 99.6772657431038m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 48.9843936494357m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 4.88240607850785m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 9.10263526029931m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 31.1075215028003m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 90.4799052597159m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 23.074239967059m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 26.0437965808918m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 29.3945143662474m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 72.1352672725378m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 73.6127934352417m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 27.7396592084426m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 32.1721069947042m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 76.5986730493089m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 85.3104380451056m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 25.284684995359m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 32.5913820323878m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 87.7010578180186m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 86.2612128521364m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 13.8600255568059m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 67.0245382176915m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 71.3334911033392m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 83.6094247891317m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 69.0493204890537m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 0.8945131746662m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 1.4042131452488m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 38.2163550863365m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 1.18593581822m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 72.7135181185846m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 64.8060297411356m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 96.2055561929581m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 88.8326271161731m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 33.5878964165407m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 13.5158432099687m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 18.044338317853m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 74.985166023246m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 37.2003210345847m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 99.0533233132476m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 1.75049947325647m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 25.3633535970783m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 80.8940408319943m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 84.6340090903633m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 59.3564986978677m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 21.3975022017052m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 65.1865805720798m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 84.766999872036m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 57.3616054255509m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 9.26845359208237m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 92.7344762767551m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 86.0963722741044m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 44.5200785511926m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 10.3578821921509m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 39.1481383133661m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 33.2473447913379m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 2.9877370499144m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 13.3694682344134m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 83.239323179679m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 14.719383152694m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 79.7447621430616m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 93.2454199482564m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 28.1707037882559m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 55.9981906280697m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 32.7638153499023m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 75.9010722416549m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 50.1569571381969m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 7.07374767471504m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 50.7252396622744m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 61.8282083770607m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 94.8900576093537m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 50.2477355908691m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 19.1876620568383m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 55.8439429345638m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 2.9473644753113m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 19.8780695928686m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 80.7753851015253m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 16.5936475216543m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 6.8927074962283m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 73.2103619660586m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 21.516772441972m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 12.8956407199609m, 19 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 27, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 50, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 1, "Content for Lesson 3 in Chapter 1", new TimeSpan(0, 0, 11, 0, 0), "Lesson 3 for Chapter 1" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 3 in Chapter 4", new TimeSpan(0, 0, 25, 0, 0), "Lesson 3 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 3 in Chapter 5", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 24, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 3 in Chapter 11", new TimeSpan(0, 0, 50, 0, 0), "Lesson 3 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                column: "Time",
                value: new TimeSpan(0, 0, 12, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                column: "Time",
                value: new TimeSpan(0, 0, 20, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 28, 0, 0), "Lesson 3 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                column: "Time",
                value: new TimeSpan(0, 0, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                column: "Time",
                value: new TimeSpan(0, 0, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                column: "Time",
                value: new TimeSpan(0, 0, 40, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                column: "Time",
                value: new TimeSpan(0, 0, 53, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                column: "Time",
                value: new TimeSpan(0, 0, 18, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 57, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Content", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 24", "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 60, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 12:22:14 am");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "AspNetUsers");

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
                keyValue: 6,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 3, "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 3", "Chapter 3 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 4, "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4" });

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
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 18, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(3959), new DateTime(2024, 6, 25, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(3955) });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 23, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 6, 24, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4074), 11 });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 7, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4142), new DateTime(2024, 6, 28, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4140), 7 });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4244), new DateTime(2024, 7, 1, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4243), 1 });

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/06/2024 10:36:30 pm", new DateTime(2024, 8, 7, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 6, 30, 22, 36, 30, 648, DateTimeKind.Local).AddTicks(4300), 12 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 55.1565078604477m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 25, 35.5102536738466m });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 33.6383844289946m, 13 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 57.0846361969349m, 20 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 95.090536720351m, 19 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 42.3526884455647m, 28 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 30.0671074168634m, 22 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 3.33304147919808m, 4 });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 4" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 10" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 11", new TimeSpan(0, 0, 21, 0, 0), "Lesson 3 for Chapter 11" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 12" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 42, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                column: "Time",
                value: new TimeSpan(0, 0, 17, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                column: "Time",
                value: new TimeSpan(0, 0, 39, 0, 0));

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 16" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                column: "Time",
                value: new TimeSpan(0, 0, 26, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                column: "Time",
                value: new TimeSpan(0, 0, 41, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                column: "Time",
                value: new TimeSpan(0, 0, 20, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                column: "Time",
                value: new TimeSpan(0, 0, 56, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                column: "Time",
                value: new TimeSpan(0, 0, 40, 0, 0));

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 20" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 21" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 33, 0, 0), "Lesson 3 for Chapter 22" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 23" });

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
                columns: new[] { "Content", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 24", "Lesson 2 for Chapter 24" });

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
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 25" });

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
    }
}
