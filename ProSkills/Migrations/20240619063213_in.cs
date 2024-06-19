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
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Service",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Service",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<double>(
                name: "Duration",
                table: "Service",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "InstructorName",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReviewCount",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 4, "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 3 in Course 8", "Chapter 3 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[] { 26, 10, "Description for Chapter 3 in Course 10", false, "Chapter 3 for Course 10", "https://sadat.vip/" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 19, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(7991), new DateTime(2024, 6, 26, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(7987), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8079), new DateTime(2024, 7, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8077), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8092), new DateTime(2024, 6, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8090), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 18, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8105), new DateTime(2024, 6, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8104), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8116), new DateTime(2024, 6, 26, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8114), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 8, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8128), new DateTime(2024, 7, 1, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8126), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 13, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8137), new DateTime(2024, 6, 27, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8136), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8147), new DateTime(2024, 6, 25, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8145), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8156), new DateTime(2024, 6, 28, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8155), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8168), new DateTime(2024, 6, 30, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8167), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 8, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8178), new DateTime(2024, 7, 2, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8176), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8187), new DateTime(2024, 6, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8185), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 6, 27, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8195), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 19, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8208), new DateTime(2024, 6, 26, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8207), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 7, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 6, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8225), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 8, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 7, 1, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8235), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 13, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8247), new DateTime(2024, 6, 27, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8246), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8257), new DateTime(2024, 6, 25, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8255), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8293), new DateTime(2024, 6, 28, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8265), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8306), new DateTime(2024, 6, 30, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8304), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 8, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8318), new DateTime(2024, 7, 2, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8317), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8328), new DateTime(2024, 6, 29, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8326), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8337), new DateTime(2024, 6, 27, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8335), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 19, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 6, 26, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8345), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8386), new DateTime(2024, 7, 3, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8384), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8396), new DateTime(2024, 6, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8395), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 8, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8406), new DateTime(2024, 7, 1, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 8, 13, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 6, 27, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8414), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:32:13 am", new DateTime(2024, 7, 24, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 6, 25, 9, 32, 13, 149, DateTimeKind.Local).AddTicks(8427), 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 18, 90.7220064080843m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 23.5005795512412m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 28.1686484177m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 81.4277335097817m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 36.6207408161153m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 69.3693397302325m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 64.6381727391891m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 82.3746593606055m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 84.9294043471089m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 11.2866818278754m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 61.540879419312m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 78.3180355482493m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 30.4099856888432m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 69.3597333443747m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 60.8574368909017m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 59.6399297650082m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 56.3649159897055m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 54.1993310192293m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 62.0693048226172m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 87.0932236870254m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 32.8729818421052m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 98.2299068648497m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 52.3015037578141m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 53.1735589805078m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 59.6869051587674m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 76.5664777815949m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 79.3376069784896m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 54.4287011799009m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 47.0917166346398m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 32.5186440341643m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 78.8368044681153m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 27.0388528926882m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 92.1592531781288m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 88.8788083523334m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 15.2589047971382m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 44.5302644806629m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 6, 63.122006396966m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 36.6195570822352m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 16.6712284580491m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 38.3754871162404m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 55.27255294618m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 34.576606893996m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 36.7819489903967m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 1.39668993672448m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 21.831506019691m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 51.4935862124533m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 22.9414910802131m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 42.3251395026319m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 92.4858536295631m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 52.1445638021408m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 36.9469157183284m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 15.1271553943481m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 92.741122987221m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 20, 62.3858674471218m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 23.6110397065495m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 91.4588331201318m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 54.4892138354692m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 92.622846295985m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 46.907371189401m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 21.3713990488989m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 55.1704364019012m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 10.5016315226989m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 40.1943373794886m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 9.68414702124305m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 24.2532419577067m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 14.5960105010787m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 98.8369749957851m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 70.6812503077865m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 52.849844240348m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 90.5168941979462m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 72.5998082014742m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 41.9226063651948m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 79.5990654235411m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 95.2693891301476m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 54.7008173745157m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 60.0733898228948m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 63.9302157693938m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 94.4476076311734m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 97.9091789325564m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 18.6932197724604m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 8.01955152400264m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 13.6703481833553m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 49.4946365471613m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 53.5851574597885m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 7.36442272455297m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 96.7913217290066m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 76.2927604389817m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 70.1368128946504m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 79.5353496586174m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 88.6016067879466m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 14.1859232674174m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 66.1276591086617m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 1.13259626829786m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 84.8987834408779m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 75.2341665421461m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 76.738962471803m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 87.9728222757313m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 16.8027752701827m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 9.25834410456342m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 22.5342811664041m, 16 });

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
                value: new TimeSpan(0, 0, 39, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                column: "Time",
                value: new TimeSpan(0, 0, 58, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 10, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 12, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 56, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 3 in Chapter 3", new TimeSpan(0, 0, 16, 0, 0), "Lesson 3 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 3 in Chapter 4", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 32, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 49, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 25, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 3 in Chapter 8", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 43, 0, 0), "Lesson 1 for Chapter 10" });

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
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 25, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 34, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 26, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 12" });

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
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 3 in Chapter 13", new TimeSpan(0, 0, 45, 0, 0), "Lesson 3 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 55, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 17, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 45, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 11, 0, 0), "Lesson 3 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 3 in Chapter 20", new TimeSpan(0, 0, 42, 0, 0), "Lesson 3 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 52, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 59, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 14, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 60, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 39, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 46, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 62, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 49, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 63, 24, "Content for Lesson 3 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 3 for Chapter 24", "https://sadat.vip/" },
                    { 64, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 65, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 40, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 66, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" }
                });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 9:32:13 am");

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 67, 26, "Content for Lesson 1 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 26", "https://sadat.vip/" },
                    { 68, 26, "Content for Lesson 2 in Chapter 26", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 26", "https://sadat.vip/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "InstructorName",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ReviewCount",
                table: "Service");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Service",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 3, "Description for Chapter 3 in Course 3", "Chapter 3 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 10, "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 10", "Chapter 3 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9602), new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9598), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9651), new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9649), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9690), new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9689), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 18, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9714), new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9712), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9724), new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9723), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9734), new DateTime(2024, 7, 1, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9733), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 13, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9748), new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9746), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9762), new DateTime(2024, 6, 25, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9760), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9774), new DateTime(2024, 6, 28, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9772), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 6, 30, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9783), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9795), new DateTime(2024, 7, 2, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9793), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9807), new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9806), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9849), new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9847), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9860), new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9859), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9871), new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9883), new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9881), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9893), new DateTime(2024, 7, 1, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9892), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 13, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9903), new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9901), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9913), new DateTime(2024, 6, 25, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9911), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9925), new DateTime(2024, 6, 28, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9924), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9935), new DateTime(2024, 6, 30, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9934), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 8, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9945), new DateTime(2024, 7, 2, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9944), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9955), new DateTime(2024, 6, 29, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9954), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9967), new DateTime(2024, 6, 27, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9965), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 19, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9977), new DateTime(2024, 6, 26, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9975), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9986), new DateTime(2024, 7, 3, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9985), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9996), new DateTime(2024, 6, 24, 9, 6, 19, 831, DateTimeKind.Local).AddTicks(9995), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 8, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(10), new DateTime(2024, 7, 1, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(8) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 8, 13, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(21), new DateTime(2024, 6, 27, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(19), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "19/06/2024 9:06:19 am", new DateTime(2024, 7, 24, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(31), new DateTime(2024, 6, 25, 9, 6, 19, 832, DateTimeKind.Local).AddTicks(29), 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 1, 55.1532688064529m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 26.6610250808211m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 55.2309441168533m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 76.3906458053626m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 54.2653055921142m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 24.6096032809317m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 94.9400959265591m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 81.328919545353m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 21.5919435888571m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 29.8280855957526m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 60.2929847514642m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 16.2511810568416m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 28.5484498635912m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 88.8947903777376m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 72.6421258798176m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 89.7921073990626m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 17.8567441054018m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 24.5836403415671m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 50.0108739367166m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 24.138872480522m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 46.333615138887m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 51.6665583868402m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 58.7586227879225m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 43.9401391966398m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 37.8212117531538m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 58.3166322095881m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 22.9104573608962m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 71.6804433380751m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 60.7073278514154m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 78.3481962172574m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 57.6067721572026m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 65.4258165165357m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 95.112873527267m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 19.5817810825069m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 49.4575742629888m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 48.0932090869347m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 15, 11.7960777851343m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 25.5506926370451m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 84.0089451592751m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 24.9576368986876m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 4.10661639163715m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 75.4491807276114m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 74.3705789162154m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 36.1292903737349m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 91.1611258588051m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 9.81839813465214m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 81.5259567666507m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 93.724251208762m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 91.6670015316294m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 43.7862356227735m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 98.4331935350716m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 30.7574503874438m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 91.5143409734975m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 15, 6.61362853022m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 22.6636382020795m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 67.6297372323654m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 11.6805279011937m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 35.027308845738m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 79.712720202916m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 12.671466641676m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 30.6858395488969m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 86.3792028360851m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 75.6882929301606m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 61.2634373021175m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 77.1633389989271m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 59.7652741425409m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 58.8639266620847m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 98.5416642045032m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 23.6250265922517m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 86.5072656466642m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 65.6117991760971m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 50.818340253944m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 83.7541443582992m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 3.37649580235295m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 70.0275267948643m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 17.5433119841682m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 9.92400495737402m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 32.7546254382929m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 54.4860696471173m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 11.2302950601846m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 67.0550951119106m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 54.5509371810474m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 27.2553865437216m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 48.4396651942827m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 63.8830616933402m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 85.6409176157924m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 54.6406840451999m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 85.8174456423418m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 22.0588160553099m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 73.7302435445948m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 0.537604292460281m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 12.4579804583952m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 14.7367670063852m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 60.5661803973297m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 33.2920780579398m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 64.8127815662574m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 87.804751764421m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 23.7190561113773m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 49.2717337975873m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 96.3220699893526m, 9 });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 39, 0, 0));

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
                value: new TimeSpan(0, 0, 31, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                column: "Time",
                value: new TimeSpan(0, 0, 49, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                column: "Time",
                value: new TimeSpan(0, 0, 22, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                column: "Time",
                value: new TimeSpan(0, 0, 25, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 12, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 22, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 36, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 42, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 56, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 58, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 3 in Chapter 9", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 45, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 42, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 3 in Chapter 14", new TimeSpan(0, 0, 47, 0, 0), "Lesson 3 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 3 in Chapter 16", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 50, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 20, 0, 0), "Lesson 3 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 35, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 40, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 26, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 53, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 44, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 3 in Chapter 21", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 46, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 3 in Chapter 23", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 1 in Chapter 24", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 24, "Content for Lesson 2 in Chapter 24", new TimeSpan(0, 0, 24, 0, 0), "Lesson 2 for Chapter 24" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 1 in Chapter 25", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 25, "Content for Lesson 2 in Chapter 25", new TimeSpan(0, 0, 39, 0, 0), "Lesson 2 for Chapter 25" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "19/06/2024 9:06:19 am");
        }
    }
}
