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
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Course_CourseId",
                table: "Assessments");

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "instructor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Assessments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f8485b5e-3e2d-4a02-b009-be9343cabb76", "AQAAAAIAAYagAAAAEISvligWeApWnc+rOGiFnorJ0Hgrc+QajapxBDssnayc4SSTG0mG4v3NWUmihakd2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae8a7d35-124f-4491-abfc-a75636bf9d46", "AQAAAAIAAYagAAAAEAfZzd1T0QE8U6MJovAS4s+TicfQbBeXGcmai3ca2rV16rHLHhSKoi1yOsVz7kcfGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2fd19777-6311-41bd-8274-8f38b49e2cb6", "AQAAAAIAAYagAAAAEB6qNhZrQzwDFhrb9/zIBayesEXLcRBphPFkmGMmArEjpS0fXH80ngYJkbARrR8h+A==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

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
                keyValue: 16,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 3 in Course 6", "Chapter 3 for Course 6" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 22, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6843), new DateTime(2024, 6, 29, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6838), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 6, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6910), new DateTime(2024, 7, 6, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6908) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6924), new DateTime(2024, 6, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6922), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 21, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6936), new DateTime(2024, 7, 2, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6935), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 1, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6948), new DateTime(2024, 6, 29, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6946), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 11, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6964), new DateTime(2024, 7, 4, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6962), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 16, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6980), new DateTime(2024, 6, 30, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(6978), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7001), new DateTime(2024, 6, 28, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7000), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 1, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7013), new DateTime(2024, 7, 1, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7012), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 6, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 7, 3, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7027), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 11, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7041), new DateTime(2024, 7, 5, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7040), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 1, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7094), new DateTime(2024, 7, 2, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7092), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7108), new DateTime(2024, 6, 30, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7106), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 22, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7123), new DateTime(2024, 6, 29, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7122), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 6, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 7, 6, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7136), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7155), new DateTime(2024, 6, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7153), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 11, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7166), new DateTime(2024, 7, 4, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7165), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 8, 16, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7181), new DateTime(2024, 6, 30, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7179), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 27, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7193), new DateTime(2024, 6, 28, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7191), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 11:36:58 am", new DateTime(2024, 7, 22, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 6, 29, 11, 36, 58, 407, DateTimeKind.Local).AddTicks(7203), 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 83.2789342381878m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Points", "Result" },
                values: new object[] { 640, 89.0442196755535m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Points", "Result" },
                values: new object[] { 990, 36.8934047967138m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Points", "Result" },
                values: new object[] { 580, 95.9332693890375m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 57.3804802850713m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Points", "Result" },
                values: new object[] { 720, 45.2317758963981m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "Result",
                value: 26.4664538542496m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Points", "Result" },
                values: new object[] { 50, 3.35000475987872m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 88.2942473779415m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Points", "Result" },
                values: new object[] { 100, 81.838458274449m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Points", "Result" },
                values: new object[] { 210, 52.4793885546174m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Points", "Result" },
                values: new object[] { 210, 89.4288021254278m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Points", "Result" },
                values: new object[] { 840, 17.5749441705598m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Points", "Result" },
                values: new object[] { 470, 26.2836206598432m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Points", "Result" },
                values: new object[] { 0, 2.01755722642615m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 8.75491538145624m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 1.75448668774804m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 41.1062497988861m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Points", "Result" },
                values: new object[] { 0, 23.2239634867112m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Points", "Result" },
                values: new object[] { 100, 21.0023807159815m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Points", "Result" },
                values: new object[] { 10, 94.1475800473344m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Points", "Result" },
                values: new object[] { 250, 89.6150293608445m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Points", "Result" },
                values: new object[] { 170, 79.7023966704681m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Points", "Result" },
                values: new object[] { 320, 24.2728801636761m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Points", "Result" },
                values: new object[] { 350, 8.55636712217384m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Points", "Result" },
                values: new object[] { 210, 89.7018298141314m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Points", "Result" },
                values: new object[] { 940, 97.8489726212476m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 83.8665907998977m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Points", "Result" },
                values: new object[] { 870, 59.1261218126738m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Points", "Result" },
                values: new object[] { 70, 52.9386888496396m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Points", "Result" },
                values: new object[] { 350, 39.7171680554735m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Points", "Result" },
                values: new object[] { 490, 74.2019788557441m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 60.4178027751938m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Points", "Result" },
                values: new object[] { 250, 30.1673931425476m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Points", "Result" },
                values: new object[] { 870, 62.7399428455622m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Points", "Result" },
                values: new object[] { 570, 93.2531162081022m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Points", "Result" },
                values: new object[] { 30, 55.548033351137m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 3.47949873198885m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Points", "Result" },
                values: new object[] { 650, 53.14765633006m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Points", "Result" },
                values: new object[] { 770, 47.6238376068074m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Points", "Result" },
                values: new object[] { 530, 67.2462270176056m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Points", "Result" },
                values: new object[] { 660, 7.13469765488894m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Points", "Result" },
                values: new object[] { 460, 52.2341975813039m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Points", "Result" },
                values: new object[] { 630, 35.9842498450116m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Points", "Result" },
                values: new object[] { 840, 32.8509034287276m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 8.51707455946463m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Points", "Result" },
                values: new object[] { 670, 32.428481041529m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Points", "Result" },
                values: new object[] { 730, 90.1794922819683m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Points", "Result" },
                values: new object[] { 190, 91.8004531439888m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Points", "Result" },
                values: new object[] { 350, 37.557299281653m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Points", "Result" },
                values: new object[] { 330, 74.6728258445832m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 99.2677438307616m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Points", "Result" },
                values: new object[] { 500, 5.62237534747846m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Points", "Result" },
                values: new object[] { 140, 96.6354990857777m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Points", "Result" },
                values: new object[] { 980, 71.3988001120781m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Points", "Result" },
                values: new object[] { 110, 78.4722985015953m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Points", "Result" },
                values: new object[] { 490, 28.3963035746971m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Points", "Result" },
                values: new object[] { 700, 84.8423442731793m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Points", "Result" },
                values: new object[] { 800, 90.9069247556672m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Points", "Result" },
                values: new object[] { 800, 71.4888467929308m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 41.4237136648741m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Points", "Result" },
                values: new object[] { 130, 95.7697690709566m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Points", "Result" },
                values: new object[] { 710, 0.889140898927809m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 4.68215615960698m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Points", "Result" },
                values: new object[] { 50, 43.7829719124942m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 9.97456885473533m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Points", "Result" },
                values: new object[] { 390, 19.0166544804761m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Points", "Result" },
                values: new object[] { 590, 34.7086269090676m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Points", "Result" },
                values: new object[] { 550, 18.4283134003863m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Points", "Result" },
                values: new object[] { 120, 58.9747579614904m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 37.4438815468021m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 65.4742537239022m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Points", "Result" },
                values: new object[] { 500, 73.0852842893117m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 66.5425104991284m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Points", "Result" },
                values: new object[] { 710, 69.154203755213m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Points", "Result" },
                values: new object[] { 560, 40.373630208886m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Points", "Result" },
                values: new object[] { 100, 47.5409457472767m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Points", "Result" },
                values: new object[] { 770, 72.3391855878132m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 46.0283974432789m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Points", "Result" },
                values: new object[] { 790, 82.7172344918932m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Points", "Result" },
                values: new object[] { 300, 21.8187253933047m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Points", "Result" },
                values: new object[] { 90, 37.6655707767268m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Points", "Result" },
                values: new object[] { 0, 42.873479490222m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 43.6425177863415m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Points", "Result" },
                values: new object[] { 700, 31.8705033403716m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                column: "Result",
                value: 80.6826046858034m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 33.4627659965669m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 63.4093987963871m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Points", "Result" },
                values: new object[] { 0, 0.872193928785547m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Points", "Result" },
                values: new object[] { 130, 31.6461462048621m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Points", "Result" },
                values: new object[] { 790, 99.1332270792912m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Points", "Result" },
                values: new object[] { 160, 44.428505244408m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 66.7490897999322m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Points", "Result" },
                values: new object[] { 640, 12.0893294477987m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Points", "Result" },
                values: new object[] { 910, 99.713508107369m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Points", "Result" },
                values: new object[] { 790, 86.7826939677288m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Points", "Result" },
                values: new object[] { 40, 35.5348961224124m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Points", "Result" },
                values: new object[] { 900, 97.7406128920961m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Points", "Result" },
                values: new object[] { 200, 72.6135897805181m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Points", "Result" },
                values: new object[] { 380, 70.2079798347631m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 64.0729270336396m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Points", "Result" },
                values: new object[] { 490, 50.6494544220344m });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 30, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 36, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 25, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 17, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 32, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 41, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeSpan(0, 0, 48, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeSpan(0, 0, 33, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeSpan(0, 0, 21, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new TimeSpan(0, 0, 26, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 43, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new TimeSpan(0, 0, 17, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new TimeSpan(0, 0, 17, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 3 in Chapter 5", new TimeSpan(0, 0, 11, 0, 0), "Lesson 3 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 23, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 18, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new TimeSpan(0, 0, 57, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new TimeSpan(0, 0, 20, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new TimeSpan(0, 0, 26, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new TimeSpan(0, 0, 57, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new TimeSpan(0, 0, 53, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new TimeSpan(0, 0, 24, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                column: "Time",
                value: new TimeSpan(0, 0, 22, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                column: "Time",
                value: new TimeSpan(0, 0, 31, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                column: "Time",
                value: new TimeSpan(0, 0, 25, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                column: "Time",
                value: new TimeSpan(0, 0, 52, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 3 in Chapter 11", new TimeSpan(0, 0, 28, 0, 0), "Lesson 3 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                column: "Time",
                value: new TimeSpan(0, 0, 51, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                column: "Time",
                value: new TimeSpan(0, 0, 19, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 24, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 30, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 38, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 20", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                column: "Time",
                value: new TimeSpan(0, 0, 57, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                column: "Time",
                value: new TimeSpan(0, 0, 18, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 58, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                column: "Time",
                value: new TimeSpan(0, 0, 28, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                column: "Time",
                value: new TimeSpan(0, 0, 26, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 24", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 25", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: "22/06/2024 11:36:58 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "ImagePath" },
                values: new object[] { "22/06/2024 11:36:58 am", "\\ThemeFront\\img\\User.jpg" });

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Course_CourseId",
                table: "Assessments",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Course_CourseId",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "instructor");

            migrationBuilder.AlterColumn<int>(
                name: "CourseId",
                table: "Assessments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "596a0f33-b0e8-46af-a693-9e12993a2583", "AQAAAAIAAYagAAAAEL8HMGHY+ugqPsWcio7e4FsyExQpm602MwGvMgvma6G9UeXgF+djYJg1vmZCc1Wbkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a39c0f2-08f1-4b05-ad97-6e5ee6bd7c03", "AQAAAAIAAYagAAAAELp2al6NsrsdcnD0pI6BMo04X5piv69BHAqfkLCtDFGMVZ5H07qxoOgWZcRr6Pzrjg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13ee6a1a-cb48-4fcb-a806-0c7926ec708d", "AQAAAAIAAYagAAAAEFCdipWM/j540LrzCTpu5k63lRWhDKNCk2MC15g4RfDwMWa65LvNIPeEaOiO4BX0JA==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 8", "Chapter 3 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 6, 29, 9, 59, 26, 840, DateTimeKind.Local).AddTicks(9995), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 7, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 6, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(310), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 21, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 7, 2, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(328), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(349), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(370), new DateTime(2024, 7, 4, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(368), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 16, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(384), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 6, 28, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(434), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 7, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(451), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 7, 3, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(465), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(585), new DateTime(2024, 7, 5, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(582), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 7, 2, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(598), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(616), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(614), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(631), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 7, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(645), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 6, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(876), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 7, 4, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(894), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 8, 16, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(908), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 6, 28, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(922), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(936), 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Points", "Result" },
                values: new object[] { 630, 15.9524879372362m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Points", "Result" },
                values: new object[] { 400, 8.88800423047382m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Points", "Result" },
                values: new object[] { 160, 32.0386053310298m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Points", "Result" },
                values: new object[] { 700, 33.9877118414109m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Points", "Result" },
                values: new object[] { 570, 15.4715873960541m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Points", "Result" },
                values: new object[] { 610, 84.7588699938632m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "Result",
                value: 63.3895773568009m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Points", "Result" },
                values: new object[] { 580, 2.84173871106468m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 37.4191131274135m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Points", "Result" },
                values: new object[] { 700, 39.5616181426371m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Points", "Result" },
                values: new object[] { 850, 58.5927250645765m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Points", "Result" },
                values: new object[] { 200, 39.7158879282507m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Points", "Result" },
                values: new object[] { 950, 58.5688273510435m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Points", "Result" },
                values: new object[] { 90, 36.1430233254375m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Points", "Result" },
                values: new object[] { 240, 92.7776328572452m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Points", "Result" },
                values: new object[] { 530, 90.9183199885248m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Points", "Result" },
                values: new object[] { 140, 43.0385450366024m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Points", "Result" },
                values: new object[] { 980, 31.7194896504794m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Points", "Result" },
                values: new object[] { 220, 11.8310036046508m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Points", "Result" },
                values: new object[] { 570, 37.1856146480227m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Points", "Result" },
                values: new object[] { 240, 0.203743047215577m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Points", "Result" },
                values: new object[] { 360, 83.1672445891112m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Points", "Result" },
                values: new object[] { 920, 85.1657910029518m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 9.23678432823264m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Points", "Result" },
                values: new object[] { 840, 32.2749743004841m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Points", "Result" },
                values: new object[] { 690, 48.9582192441664m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Points", "Result" },
                values: new object[] { 590, 59.2803542101853m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Points", "Result" },
                values: new object[] { 50, 97.4937644291268m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Points", "Result" },
                values: new object[] { 170, 34.4542057418297m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 54.1521150358344m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Points", "Result" },
                values: new object[] { 20, 76.9382968295075m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Points", "Result" },
                values: new object[] { 60, 6.51187704563575m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Points", "Result" },
                values: new object[] { 1000, 99.5016068670484m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Points", "Result" },
                values: new object[] { 710, 58.1373271074111m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Points", "Result" },
                values: new object[] { 690, 50.2531941506485m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Points", "Result" },
                values: new object[] { 680, 98.9569071453537m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Points", "Result" },
                values: new object[] { 280, 28.1504722199145m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Points", "Result" },
                values: new object[] { 640, 8.03094451346761m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 18.1010249338524m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Points", "Result" },
                values: new object[] { 900, 84.0561454576568m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Points", "Result" },
                values: new object[] { 390, 32.9187903371663m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Points", "Result" },
                values: new object[] { 60, 0.680117719762718m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 45.8706949543367m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Points", "Result" },
                values: new object[] { 310, 67.9154896525998m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Points", "Result" },
                values: new object[] { 990, 40.2471730202289m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Points", "Result" },
                values: new object[] { 750, 23.0605900327497m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Points", "Result" },
                values: new object[] { 110, 15.3479659123932m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Points", "Result" },
                values: new object[] { 670, 75.2249740267213m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 97.395741849208m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Points", "Result" },
                values: new object[] { 670, 21.967414280368m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 28.0677800094129m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Points", "Result" },
                values: new object[] { 690, 96.4591606861611m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Points", "Result" },
                values: new object[] { 80, 88.8865296159414m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Points", "Result" },
                values: new object[] { 80, 37.0717958139099m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Points", "Result" },
                values: new object[] { 80, 2.48728950597966m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Points", "Result" },
                values: new object[] { 350, 87.7821793439936m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Points", "Result" },
                values: new object[] { 660, 53.6113109820833m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Points", "Result" },
                values: new object[] { 660, 82.6041744041088m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Points", "Result" },
                values: new object[] { 850, 41.1967414947m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Points", "Result" },
                values: new object[] { 790, 41.2498788175078m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Points", "Result" },
                values: new object[] { 380, 30.2419002042884m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Points", "Result" },
                values: new object[] { 550, 28.5064632234741m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 64.2775369844626m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Points", "Result" },
                values: new object[] { 460, 78.7843178974376m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Points", "Result" },
                values: new object[] { 850, 18.9148812633862m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Points", "Result" },
                values: new object[] { 770, 45.5063786950015m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Points", "Result" },
                values: new object[] { 50, 23.3707926740437m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Points", "Result" },
                values: new object[] { 720, 78.6581033935084m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Points", "Result" },
                values: new object[] { 840, 91.4777191044983m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Points", "Result" },
                values: new object[] { 10, 47.5893409200726m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Points", "Result" },
                values: new object[] { 490, 7.90298721204833m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Points", "Result" },
                values: new object[] { 300, 75.5217857452783m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Points", "Result" },
                values: new object[] { 40, 67.1335723618218m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Points", "Result" },
                values: new object[] { 470, 96.524789497742m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Points", "Result" },
                values: new object[] { 610, 36.4543755962202m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Points", "Result" },
                values: new object[] { 620, 20.5576154631145m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Points", "Result" },
                values: new object[] { 500, 4.93327917941474m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Points", "Result" },
                values: new object[] { 800, 5.59322098122931m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 69.5673210955132m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Points", "Result" },
                values: new object[] { 450, 49.3390295064256m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Points", "Result" },
                values: new object[] { 800, 3.50717169508755m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Points", "Result" },
                values: new object[] { 130, 12.0754299700069m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Points", "Result" },
                values: new object[] { 620, 12.4017263682749m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Points", "Result" },
                values: new object[] { 630, 15.8305571828944m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Points", "Result" },
                values: new object[] { 420, 50.5571532013624m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                column: "Result",
                value: 65.1894116189983m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Points", "Result" },
                values: new object[] { 500, 34.1726963388345m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 4.07398109422864m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 7.93065177610168m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Points", "Result" },
                values: new object[] { 740, 66.6723460453336m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Points", "Result" },
                values: new object[] { 120, 33.8871935895116m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Points", "Result" },
                values: new object[] { 630, 50.2451253959538m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 32.9952994017342m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Points", "Result" },
                values: new object[] { 530, 51.5699429873322m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 55.3142091538299m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Points", "Result" },
                values: new object[] { 710, 4.07178061615064m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Points", "Result" },
                values: new object[] { 380, 55.2080450981856m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Points", "Result" },
                values: new object[] { 970, 82.1583156392286m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 14.0454024454676m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Points", "Result" },
                values: new object[] { 140, 15.5386231009142m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Points", "Result" },
                values: new object[] { 30, 58.1624284618179m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Points", "Result" },
                values: new object[] { 530, 22.6461700449216m });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 42, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 38, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 41, 0, 0));

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
                value: new TimeSpan(0, 0, 13, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 12, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                column: "Time",
                value: new TimeSpan(0, 0, 39, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                column: "Time",
                value: new TimeSpan(0, 0, 55, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                column: "Time",
                value: new TimeSpan(0, 0, 40, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                column: "Time",
                value: new TimeSpan(0, 0, 47, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                column: "Time",
                value: new TimeSpan(0, 0, 51, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                column: "Time",
                value: new TimeSpan(0, 0, 48, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                column: "Time",
                value: new TimeSpan(0, 0, 19, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                column: "Time",
                value: new TimeSpan(0, 0, 28, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                column: "Time",
                value: new TimeSpan(0, 0, 21, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                column: "Time",
                value: new TimeSpan(0, 0, 22, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                column: "Time",
                value: new TimeSpan(0, 0, 53, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                column: "Time",
                value: new TimeSpan(0, 0, 41, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                column: "Time",
                value: new TimeSpan(0, 0, 58, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                column: "Time",
                value: new TimeSpan(0, 0, 34, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                column: "Time",
                value: new TimeSpan(0, 0, 41, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                column: "Time",
                value: new TimeSpan(0, 0, 51, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                column: "Time",
                value: new TimeSpan(0, 0, 22, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 13", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                column: "Time",
                value: new TimeSpan(0, 0, 11, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                column: "Time",
                value: new TimeSpan(0, 0, 59, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 3 in Chapter 15", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 27, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 25, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                column: "Time",
                value: new TimeSpan(0, 0, 15, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                column: "Time",
                value: new TimeSpan(0, 0, 10, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                column: "Time",
                value: new TimeSpan(0, 0, 37, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                column: "Time",
                value: new TimeSpan(0, 0, 27, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 42, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 3 in Chapter 24", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[] { 65, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/06/2024 9:59:26 am");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Course_CourseId",
                table: "Assessments",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "Id");
        }
    }
}
