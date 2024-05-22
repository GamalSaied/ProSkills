using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "country",
                table: "AspNetUsers",
                newName: "Country");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Trainee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 21, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6317), new DateTime(2024, 5, 29, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6312), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 6, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6415), new DateTime(2024, 6, 5, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6413), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6428), new DateTime(2024, 5, 27, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6426), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 21, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6440), new DateTime(2024, 6, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6439), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6452), new DateTime(2024, 5, 29, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6450), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 11, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6466), new DateTime(2024, 6, 3, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6464), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 16, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6477), new DateTime(2024, 5, 30, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6476), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6488), new DateTime(2024, 5, 28, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6487), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6499), new DateTime(2024, 5, 31, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6498), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 6, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6514), new DateTime(2024, 6, 2, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6512), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 11, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6525), new DateTime(2024, 6, 4, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6523), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 6, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6534), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6547), new DateTime(2024, 5, 30, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6545), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 21, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 5, 29, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6559), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 6, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 6, 5, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6570), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 5, 27, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6614), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 11, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6630), new DateTime(2024, 6, 3, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6628), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 16, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6644), new DateTime(2024, 5, 30, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6642), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 5, 28, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6653), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6666), new DateTime(2024, 5, 31, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6664), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 6, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6677), new DateTime(2024, 6, 2, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6675), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 11, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6690), new DateTime(2024, 6, 4, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6688), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6707), new DateTime(2024, 6, 1, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6700), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6718), new DateTime(2024, 5, 30, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6716), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 21, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6729), new DateTime(2024, 5, 29, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6727), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 6, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 6, 5, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6741), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 5, 27, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6752), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 11, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6764), new DateTime(2024, 6, 3, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6763), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 7, 16, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 5, 30, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6774), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 5, 28, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6788), 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 25.4292103030219m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 49.740855689355m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 89.6512631337714m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 15, 34.0890352628727m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 45.9653782626079m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 57.4212873146928m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 35.1592904830979m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 30.5132684377618m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 27.969487951166m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 58.1538603073442m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 98.0272943192627m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 11, 79.6602035727503m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 36.4172305094766m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 60.786586110184m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 88.4790227237922m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 83.4446348868984m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 94.2528412315872m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 57.9445759034109m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 8.32422474272467m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 8.28529354659001m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 3.64662562394534m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 0.177171094989259m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 86.3059781924457m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 13.1533217434879m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 46.7434961673686m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 20.7396729552047m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 23.4212494241054m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 71.5806130670788m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 56.2331964026594m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 50.0657461384132m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 75.2129374139886m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 4.49846346751345m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 83.6825525512725m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 2.56192243525688m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 39.7349168721793m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 0.209799202891314m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 92.8552595544072m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 40.4716445605042m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 21.5992207935455m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 25.2476624300172m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 77.1422206448681m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 21.8408553390196m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 15.5198948563107m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 33.4534688098242m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 16.8285121747568m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 35.0108521062712m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 88.3269469831623m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 83.0768878293262m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 51.6719621636479m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 35.7560060440694m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 51.6481658034828m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 20, 88.237964549637m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 80.4959085128094m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 14.4570625752456m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 1.21597181214023m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 47.665079415479m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 44.0442813240036m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 42.7201780790147m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 72.5283197016444m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 85.0706623303777m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 31.3240008922509m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 55.6849417435448m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 38.7878487844141m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 70.2554453480271m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 73.5503889572172m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 4, 92.7050602797442m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 37.5641910059266m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 23.9307510447134m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 67.2215688132013m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 83.6979712817659m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 18.1260702630268m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 45.0301127913748m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 30, 35.7149428900199m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 3.51206472610696m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 42.3173816180309m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 64.0814562547628m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 21.1716436100275m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 61.5164195830524m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 83.9329303134617m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 9.75911405091106m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 50.3769419862079m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 0.0339632536041634m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 46.5706315929048m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 4.25894126965198m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 0.936885474721361m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 29.0201050162975m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 23, 40.7074706432168m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 72.7227001414763m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 97.1605355912384m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 26.4257325398189m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 7, 81.1875946039921m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 64.4404467900936m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 32.2898814339502m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 35.1854282118725m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 37.9757606409307m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 83.7386036321116m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 75.3229385495182m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 61.8570902178789m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 27.3562613196877m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 37.795450704463m, 5 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Phone", "country" },
                values: new object[] { "22/05/2024 3:06:15 am", null, null });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "CreatedAt",
                table: "Trainee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6465), new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6461), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6510), new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6509), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6521), new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6520), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6541), new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6539), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6550), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6561), new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6560), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6570), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6585), new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6583), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6595), new DateTime(2024, 5, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6594), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 6, 1, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6604), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6615), new DateTime(2024, 6, 3, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6614), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6628), new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6626), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6636), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6647), new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6646), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6657), new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6656), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6668), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6679), new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6678), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6689), new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6688), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6699), new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6698), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6711), new DateTime(2024, 5, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6710), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 6, 1, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6746), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6759), new DateTime(2024, 6, 3, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6757), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 30, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6769), new DateTime(2024, 5, 31, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6767), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6780), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 20, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 5, 28, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6790), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 5, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 6, 4, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6800), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6811), new DateTime(2024, 5, 26, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6810), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 10, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6823), new DateTime(2024, 6, 2, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6822), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 7, 15, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6833), new DateTime(2024, 5, 29, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6831), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "21/05/2024 7:29:44 pm", new DateTime(2024, 6, 25, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6842), new DateTime(2024, 5, 27, 19, 29, 44, 366, DateTimeKind.Local).AddTicks(6841), 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 19.1749337106689m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 46.6796768458176m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 62.7003887232847m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 11, 37.4084053574589m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 40.5699687964192m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 82.5664183311241m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 78.0749065582054m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 65.3502171816766m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 74.1341561146674m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 55.3219891421489m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 75.3388857721978m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 9, 80.1451020833722m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 68.3096739650878m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 21.0977265382282m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 47.6951970099906m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 38.2444102428454m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 87.2865106999846m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 30.727214995569m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 5.7866581186213m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 81.8649308811601m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 16.2863620230387m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 91.9954547840499m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 53.4130835903366m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 61.3851491094783m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 2.02132861604816m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 50.7807075258199m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 83.9060470282443m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 4.5557779063121m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 69.6673272192654m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 12.1990048795385m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 75.8789188056828m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 56.5519965248669m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 25.5863837585953m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 95.3258815527437m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 33.1998936758888m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 24.3992420065169m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 77.585760254887m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 33.4171985478989m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 72.5408504416773m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 90.9334698863028m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 48.3397284161816m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 64.5294063775591m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 11.9182232194373m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 90.2550192608888m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 26.5566647154284m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 65.7972518720607m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 27.1890820132206m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 19.4819658754278m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 6.33020425237062m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 77.838114806634m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 59.5922285840699m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 5, 93.7522670459113m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 78.5097480367326m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 47.4693405604489m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 90.0030150304717m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 6.15272030534172m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 5.0974448864768m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 78.5946991956794m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 11.3149150062716m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 26.8265105233371m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 71.7046935257582m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 29.1815735063864m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 93.2720870998049m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 88.8366625236615m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 12.9179962970898m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 23.8812237715772m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 91.2487607857698m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 19.8247123602721m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 5.6714732499634m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 36.5281698740443m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 3.93470025996839m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 82.5702791111988m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 29, 65.9762750787748m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 4.94241347339177m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 55.2809761151237m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 82.903618176327m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 18.3088054561647m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 4.11466199072354m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 26.4022625646932m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 17.4617714544885m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 6.48022604192027m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 53.0048864425279m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 60.4575864454783m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 4.08313486754807m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 10, 9.93252631636748m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 63.5658489336782m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 2, 43.4987310825468m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 81.4568181365481m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 82.6170502288305m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 38.8460583954367m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 19, 78.9899807619574m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 23.933482378688m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 53.1558540050751m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 88.5831574621364m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 19.492958541044m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 6.38022297341125m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 65.435108146968m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 14.6441193806448m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 87.0904835632484m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 60.8813308384751m, 29 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "21/05/2024 7:29:44 pm");
        }
    }
}
