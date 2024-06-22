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
                keyValue: 5,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 2, "Description for Chapter 3 in Course 2", "Chapter 3 for Course 2" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 3, "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 4, "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 5", "Chapter 1 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 5, "Description for Chapter 2 in Course 5", "Chapter 2 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 5, "Description for Chapter 3 in Course 5", "Chapter 3 for Course 5" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

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
                values: new object[] { "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 3 in Course 8", "Chapter 3 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

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
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9" });

            migrationBuilder.InsertData(
                table: "Chapters",
                columns: new[] { "Id", "CourseId", "Description", "IsDeleted", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 24, 10, "Description for Chapter 1 in Course 10", false, "Chapter 1 for Course 10", "https://sadat.vip/" },
                    { 25, 10, "Description for Chapter 2 in Course 10", false, "Chapter 2 for Course 10", "https://sadat.vip/" }
                });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(13), new DateTime(2024, 6, 29, 9, 59, 26, 840, DateTimeKind.Local).AddTicks(9995), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(266), new DateTime(2024, 7, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(263), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(312), new DateTime(2024, 6, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(310), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 21, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(330), new DateTime(2024, 7, 2, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(328), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(352), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(349), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(370), new DateTime(2024, 7, 4, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(368), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 16, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(384), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(436), new DateTime(2024, 6, 28, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(434), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(453), new DateTime(2024, 7, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(451), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(467), new DateTime(2024, 7, 3, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(465), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(585), new DateTime(2024, 7, 5, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(582), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 1, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(600), new DateTime(2024, 7, 2, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(598), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(616), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(614), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(633), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(647), new DateTime(2024, 7, 6, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(645), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(878), new DateTime(2024, 6, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(876), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 11, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(896), new DateTime(2024, 7, 4, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(894), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 8, 16, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(911), new DateTime(2024, 6, 30, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(908), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 27, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(924), new DateTime(2024, 6, 28, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(922), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "/Images/DefaultCourseImg.png", "22/06/2024 9:59:26 am", new DateTime(2024, 7, 22, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(939), new DateTime(2024, 6, 29, 9, 59, 26, 841, DateTimeKind.Local).AddTicks(936) });

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
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 63.3895773568009m });

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
                column: "Result",
                value: 23.0605900327497m);

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
                column: "Result",
                value: 53.6113109820833m);

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
                columns: new[] { "Points", "Result" },
                values: new object[] { 770, 65.1894116189983m });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 1, "Content for Lesson 3 in Chapter 1", new TimeSpan(0, 0, 41, 0, 0), "Lesson 3 for Chapter 1" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 13, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 13, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 3 in Chapter 2", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 39, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 55, 0, 0), "Lesson 2 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 4", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 4, "Content for Lesson 3 in Chapter 4", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 48, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 19, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 6" });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 31, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 7" });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 37, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 21, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 3 in Chapter 8", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 53, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 58, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 10, "Content for Lesson 3 in Chapter 10", "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 51, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", new TimeSpan(0, 0, 22, 0, 0), "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 21, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 44, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 31, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 3 in Chapter 13", new TimeSpan(0, 0, 23, 0, 0), "Lesson 3 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 59, 0, 0), "Lesson 2 for Chapter 14" });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 10, 0, 0), "Lesson 1 for Chapter 15" });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 19, 0, 0), "Lesson 1 for Chapter 16" });

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
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 33, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 15, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 28, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 3 in Chapter 22", new TimeSpan(0, 0, 22, 0, 0), "Lesson 3 for Chapter 22" });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 57, 23, "Content for Lesson 1 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 23", "https://sadat.vip/" },
                    { 58, 23, "Content for Lesson 2 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 23", "https://sadat.vip/" },
                    { 59, 23, "Content for Lesson 3 in Chapter 23", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 42, 0, 0), "Lesson 3 for Chapter 23", "https://sadat.vip/" }
                });

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

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "ChapterId", "Content", "IsDeleted", "TaskLink", "Time", "Title", "downloadLink" },
                values: new object[,]
                {
                    { 60, 24, "Content for Lesson 1 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 57, 0, 0), "Lesson 1 for Chapter 24", "https://sadat.vip/" },
                    { 61, 24, "Content for Lesson 2 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 48, 0, 0), "Lesson 2 for Chapter 24", "https://sadat.vip/" },
                    { 62, 24, "Content for Lesson 3 in Chapter 24", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 12, 0, 0), "Lesson 3 for Chapter 24", "https://sadat.vip/" },
                    { 63, 25, "Content for Lesson 1 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 37, 0, 0), "Lesson 1 for Chapter 25", "https://sadat.vip/" },
                    { 64, 25, "Content for Lesson 2 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 56, 0, 0), "Lesson 2 for Chapter 25", "https://sadat.vip/" },
                    { 65, 25, "Content for Lesson 3 in Chapter 25", false, "https://www.youtube.com/watch?v=0W4KRuw7m9U", new TimeSpan(0, 0, 51, 0, 0), "Lesson 3 for Chapter 25", "https://sadat.vip/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 58);

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
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bab2168e-cd6e-49a5-a9b4-4c462ac2bb59", "AQAAAAIAAYagAAAAEFjRwVlbWrieEJHAWjyYbQUGyoc6ZdkfWRj0Ym4BTD5zALZ4Use/Bo+WvNREP1fG2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "484b9dd1-516f-4b39-9480-b80299fa3c50", "AQAAAAIAAYagAAAAELLFUs0tDLvwb4Hb59Q/R7ewvLafa2C58voQql9wS/IqzZ9Hz3EMsgqB0KSjfWaMOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e08cc13d-fa3d-45da-a787-47c8945d05b6", "AQAAAAIAAYagAAAAEPa/UZ9AD5YyvA0mp3xsxKQKmHnUa682bu4UuS9HSqfMRGwkva9al3OP5rn9hG/onw==" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 3, "Description for Chapter 1 in Course 3", "Chapter 1 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 3", "Chapter 2 for Course 3" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 4, "Description for Chapter 1 in Course 4", "Chapter 1 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 4", "Chapter 2 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 4", "Chapter 3 for Course 4" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 5, "Description for Chapter 1 in Course 5", "Chapter 1 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 5", "Chapter 2 for Course 5" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 1 in Course 6", "Chapter 1 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 6, "Description for Chapter 2 in Course 6", "Chapter 2 for Course 6" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 1 in Course 7", "Chapter 1 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 7, "Description for Chapter 2 in Course 7", "Chapter 2 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 7", "Chapter 3 for Course 7" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 8, "Description for Chapter 1 in Course 8", "Chapter 1 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 2 in Course 8", "Chapter 2 for Course 8" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 1 in Course 9", "Chapter 1 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 9, "Description for Chapter 2 in Course 9", "Chapter 2 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Description for Chapter 3 in Course 9", "Chapter 3 for Course 9" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 10, "Description for Chapter 1 in Course 10", "Chapter 1 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Chapters",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Description", "Title" },
                values: new object[] { 10, "Description for Chapter 2 in Course 10", "Chapter 2 for Course 10" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4216), new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4206), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 7, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4329), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 6, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4397), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 21, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4433), new DateTime(2024, 7, 2, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4428), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4483), new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4478), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4518), new DateTime(2024, 7, 4, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4514), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 16, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4542), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 6, 28, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4620), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 7, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4647), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 7, 3, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4819), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4850), new DateTime(2024, 7, 5, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4846), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 1, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4872), new DateTime(2024, 7, 2, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(4868), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5069), new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5066), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5099), new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5162), new DateTime(2024, 7, 6, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5157), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 6, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5190), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 11, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 7, 4, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5219), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 8, 16, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5247), new DateTime(2024, 6, 30, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5243), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 27, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5269), new DateTime(2024, 6, 28, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5265), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseImagePath", "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "/ Images / DefaultCourseImg.png", "22/06/2024 9:55:46 am", new DateTime(2024, 7, 22, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5290), new DateTime(2024, 6, 29, 9, 55, 46, 549, DateTimeKind.Local).AddTicks(5287) });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Points", "Result" },
                values: new object[] { 960, 2.10767442887495m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 38.7329446470883m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Points", "Result" },
                values: new object[] { 400, 0.696204449674564m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 45.9126005095335m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Points", "Result" },
                values: new object[] { 480, 15.1268537559829m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Points", "Result" },
                values: new object[] { 700, 16.6523499369984m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Points", "Result" },
                values: new object[] { 400, 60.6645946962313m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Points", "Result" },
                values: new object[] { 950, 49.7195680976626m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Points", "Result" },
                values: new object[] { 400, 34.5634215893546m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Points", "Result" },
                values: new object[] { 350, 44.3158464455209m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Points", "Result" },
                values: new object[] { 750, 20.7224183024248m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 53.5935528406216m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Points", "Result" },
                values: new object[] { 500, 31.6188586927732m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Points", "Result" },
                values: new object[] { 860, 31.1394892177886m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Points", "Result" },
                values: new object[] { 920, 11.96711642206m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Points", "Result" },
                values: new object[] { 200, 73.5755608770866m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Points", "Result" },
                values: new object[] { 60, 82.3104399755859m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Points", "Result" },
                values: new object[] { 230, 54.9405232039624m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Points", "Result" },
                values: new object[] { 940, 22.0312417499487m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Points", "Result" },
                values: new object[] { 300, 41.5845810565632m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Points", "Result" },
                values: new object[] { 1000, 29.9279971579442m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 22.6677801495418m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 49.3635774093281m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Points", "Result" },
                values: new object[] { 90, 78.1701464048519m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 0.210631876150413m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Points", "Result" },
                values: new object[] { 30, 32.9820616380855m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Points", "Result" },
                values: new object[] { 730, 85.3270972118296m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Points", "Result" },
                values: new object[] { 80, 1.49338316930054m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Points", "Result" },
                values: new object[] { 720, 22.040935051195m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Points", "Result" },
                values: new object[] { 890, 72.9948320628469m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Points", "Result" },
                values: new object[] { 770, 48.3717202833934m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Points", "Result" },
                values: new object[] { 240, 61.7935738949366m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Points", "Result" },
                values: new object[] { 620, 27.8276691048599m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Points", "Result" },
                values: new object[] { 810, 43.9833510931792m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Points", "Result" },
                values: new object[] { 480, 8.32219579396049m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Points", "Result" },
                values: new object[] { 740, 56.7865862253799m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 79.8429369272167m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 91.4365672098637m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Points", "Result" },
                values: new object[] { 830, 97.0154712337536m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Points", "Result" },
                values: new object[] { 870, 28.3477540029361m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Points", "Result" },
                values: new object[] { 330, 74.2880907532118m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 2.68901434878218m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Points", "Result" },
                values: new object[] { 710, 17.0782747657317m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Points", "Result" },
                values: new object[] { 210, 25.0941931764319m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Points", "Result" },
                values: new object[] { 250, 7.43303325764869m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                column: "Result",
                value: 73.1282510409144m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 64.4146719003981m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Points", "Result" },
                values: new object[] { 930, 5.69810535060713m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Points", "Result" },
                values: new object[] { 60, 4.92767451426871m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Points", "Result" },
                values: new object[] { 750, 9.0390170513892m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Points", "Result" },
                values: new object[] { 0, 50.8740157973935m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Points", "Result" },
                values: new object[] { 540, 71.3285969564476m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Points", "Result" },
                values: new object[] { 980, 4.33585749099484m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Points", "Result" },
                values: new object[] { 780, 32.7722806211955m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Points", "Result" },
                values: new object[] { 190, 84.241556054282m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Points", "Result" },
                values: new object[] { 580, 78.2145952280529m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                column: "Result",
                value: 42.5207171240993m);

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Points", "Result" },
                values: new object[] { 630, 71.4110963894256m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Points", "Result" },
                values: new object[] { 760, 96.0504466535224m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Points", "Result" },
                values: new object[] { 410, 22.8764974976167m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Points", "Result" },
                values: new object[] { 610, 95.8982840390278m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Points", "Result" },
                values: new object[] { 740, 74.27230775527m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 76.2486090974163m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Points", "Result" },
                values: new object[] { 190, 70.9582350313459m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Points", "Result" },
                values: new object[] { 510, 27.5634921022718m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Points", "Result" },
                values: new object[] { 620, 87.3364692155988m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Points", "Result" },
                values: new object[] { 880, 14.0460704106794m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Points", "Result" },
                values: new object[] { 990, 30.9550799618138m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Points", "Result" },
                values: new object[] { 70, 73.6952456040039m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Points", "Result" },
                values: new object[] { 540, 88.2020742377125m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Points", "Result" },
                values: new object[] { 250, 71.5349406342558m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Points", "Result" },
                values: new object[] { 400, 59.0917785955575m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Points", "Result" },
                values: new object[] { 880, 31.016264203867m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 5.8850945012945m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Points", "Result" },
                values: new object[] { 940, 63.7968931150628m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 85.2074916754957m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Points", "Result" },
                values: new object[] { 150, 53.1663797419998m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Points", "Result" },
                values: new object[] { 130, 90.7606355353867m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Points", "Result" },
                values: new object[] { 850, 62.2617673927969m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 33.9407980982993m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Points", "Result" },
                values: new object[] { 760, 43.221585581831m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Points", "Result" },
                values: new object[] { 870, 66.8165590011004m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Points", "Result" },
                values: new object[] { 180, 54.1158188150042m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Points", "Result" },
                values: new object[] { 860, 58.1061345714383m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Points", "Result" },
                values: new object[] { 280, 5.67676234003762m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Points", "Result" },
                values: new object[] { 650, 37.5275805307411m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Points", "Result" },
                values: new object[] { 1000, 94.3124934567654m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Points", "Result" },
                values: new object[] { 370, 11.2038440942784m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Points", "Result" },
                values: new object[] { 50, 23.3480101522682m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Points", "Result" },
                values: new object[] { 150, 24.7478355130667m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Points", "Result" },
                values: new object[] { 340, 39.1928895785629m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Points", "Result" },
                values: new object[] { 760, 19.273337079728m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Points", "Result" },
                values: new object[] { 460, 35.7493888332068m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Points", "Result" },
                values: new object[] { 360, 61.3789854097933m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Points", "Result" },
                values: new object[] { 920, 24.9395689997209m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Points", "Result" },
                values: new object[] { 470, 46.447376838547m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Points", "Result" },
                values: new object[] { 680, 60.6714758406906m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Points", "Result" },
                values: new object[] { 520, 11.4182633192076m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Points", "Result" },
                values: new object[] { 670, 85.8939103673344m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Points", "Result" },
                values: new object[] { 900, 29.7187039645832m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Points", "Result" },
                values: new object[] { 430, 43.1638197263043m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Points", "Result" },
                values: new object[] { 840, 83.2063701577527m });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new TimeSpan(0, 0, 13, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new TimeSpan(0, 0, 48, 0, 0));

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 2, "Content for Lesson 1 in Chapter 2", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 2", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 2", new TimeSpan(0, 0, 44, 0, 0), "Lesson 3 for Chapter 2" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 3, "Content for Lesson 1 in Chapter 3", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 3" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 3", new TimeSpan(0, 0, 11, 0, 0), "Lesson 2 for Chapter 3" });

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
                values: new object[] { "Content for Lesson 2 in Chapter 4", new TimeSpan(0, 0, 43, 0, 0), "Lesson 2 for Chapter 4" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 1 in Chapter 5", new TimeSpan(0, 0, 59, 0, 0), "Lesson 1 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 5, "Content for Lesson 2 in Chapter 5", new TimeSpan(0, 0, 36, 0, 0), "Lesson 2 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 5", new TimeSpan(0, 0, 43, 0, 0), "Lesson 3 for Chapter 5" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 6, "Content for Lesson 1 in Chapter 6", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 6", new TimeSpan(0, 0, 54, 0, 0), "Lesson 2 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 6", new TimeSpan(0, 0, 49, 0, 0), "Lesson 3 for Chapter 6" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 7, "Content for Lesson 1 in Chapter 7", new TimeSpan(0, 0, 32, 0, 0), "Lesson 1 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 7", new TimeSpan(0, 0, 37, 0, 0), "Lesson 2 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 7", new TimeSpan(0, 0, 54, 0, 0), "Lesson 3 for Chapter 7" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 8, "Content for Lesson 1 in Chapter 8", new TimeSpan(0, 0, 18, 0, 0), "Lesson 1 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 8", new TimeSpan(0, 0, 16, 0, 0), "Lesson 2 for Chapter 8" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 1 in Chapter 9", new TimeSpan(0, 0, 41, 0, 0), "Lesson 1 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 9, "Content for Lesson 2 in Chapter 9", new TimeSpan(0, 0, 47, 0, 0), "Lesson 2 for Chapter 9" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 1 in Chapter 10", new TimeSpan(0, 0, 16, 0, 0), "Lesson 1 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 10, "Content for Lesson 2 in Chapter 10", new TimeSpan(0, 0, 14, 0, 0), "Lesson 2 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 10", new TimeSpan(0, 0, 29, 0, 0), "Lesson 3 for Chapter 10" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 11, "Content for Lesson 1 in Chapter 11", new TimeSpan(0, 0, 12, 0, 0), "Lesson 1 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ChapterId", "Content", "Title" },
                values: new object[] { 11, "Content for Lesson 2 in Chapter 11", "Lesson 2 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 11", new TimeSpan(0, 0, 32, 0, 0), "Lesson 3 for Chapter 11" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 12, "Content for Lesson 1 in Chapter 12", new TimeSpan(0, 0, 17, 0, 0), "Lesson 1 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 12", new TimeSpan(0, 0, 34, 0, 0), "Lesson 2 for Chapter 12" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 13, "Content for Lesson 1 in Chapter 13", new TimeSpan(0, 0, 47, 0, 0), "Lesson 1 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 13", new TimeSpan(0, 0, 29, 0, 0), "Lesson 2 for Chapter 13" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 1 in Chapter 14", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 14, "Content for Lesson 2 in Chapter 14", new TimeSpan(0, 0, 27, 0, 0), "Lesson 2 for Chapter 14" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 1 in Chapter 15", new TimeSpan(0, 0, 20, 0, 0), "Lesson 1 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 2 in Chapter 15", new TimeSpan(0, 0, 35, 0, 0), "Lesson 2 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 15, "Content for Lesson 3 in Chapter 15", new TimeSpan(0, 0, 18, 0, 0), "Lesson 3 for Chapter 15" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 1 in Chapter 16", new TimeSpan(0, 0, 55, 0, 0), "Lesson 1 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 16, "Content for Lesson 2 in Chapter 16", new TimeSpan(0, 0, 20, 0, 0), "Lesson 2 for Chapter 16" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 1 in Chapter 17", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 2 in Chapter 17", new TimeSpan(0, 0, 28, 0, 0), "Lesson 2 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 17, "Content for Lesson 3 in Chapter 17", new TimeSpan(0, 0, 52, 0, 0), "Lesson 3 for Chapter 17" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 1 in Chapter 18", new TimeSpan(0, 0, 29, 0, 0), "Lesson 1 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 2 in Chapter 18", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 18, "Content for Lesson 3 in Chapter 18", new TimeSpan(0, 0, 35, 0, 0), "Lesson 3 for Chapter 18" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 1 in Chapter 19", new TimeSpan(0, 0, 27, 0, 0), "Lesson 1 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 19, "Content for Lesson 2 in Chapter 19", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 3 in Chapter 19", new TimeSpan(0, 0, 15, 0, 0), "Lesson 3 for Chapter 19" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 20, "Content for Lesson 1 in Chapter 20", new TimeSpan(0, 0, 33, 0, 0), "Lesson 1 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 20", new TimeSpan(0, 0, 15, 0, 0), "Lesson 2 for Chapter 20" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 21, "Content for Lesson 1 in Chapter 21", new TimeSpan(0, 0, 54, 0, 0), "Lesson 1 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 21", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 21" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 22, "Content for Lesson 1 in Chapter 22", new TimeSpan(0, 0, 11, 0, 0), "Lesson 1 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "Time", "Title" },
                values: new object[] { "Content for Lesson 2 in Chapter 22", new TimeSpan(0, 0, 41, 0, 0), "Lesson 2 for Chapter 22" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 1 in Chapter 23", new TimeSpan(0, 0, 40, 0, 0), "Lesson 1 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "ChapterId", "Content", "Time", "Title" },
                values: new object[] { 23, "Content for Lesson 2 in Chapter 23", new TimeSpan(0, 0, 10, 0, 0), "Lesson 2 for Chapter 23" });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/06/2024 9:55:46 am");
        }
    }
}
