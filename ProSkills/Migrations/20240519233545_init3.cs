using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 19, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6761), new DateTime(2024, 5, 27, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6757), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 4, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6809), new DateTime(2024, 6, 3, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6807) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6820), new DateTime(2024, 5, 25, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6818), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 19, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6840), new DateTime(2024, 5, 30, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6838), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6850), new DateTime(2024, 5, 27, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6848), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 9, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6860), new DateTime(2024, 6, 1, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6859), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 14, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6870), new DateTime(2024, 5, 28, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6868), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6884), new DateTime(2024, 5, 26, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6883), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6895), new DateTime(2024, 5, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6893), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 4, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6904), new DateTime(2024, 5, 31, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6903), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 9, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6914), new DateTime(2024, 6, 2, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6912), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6926), new DateTime(2024, 5, 30, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6925), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6936), new DateTime(2024, 5, 28, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6935), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 19, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6946), new DateTime(2024, 5, 27, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6944), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 4, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6955), new DateTime(2024, 6, 3, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6954), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6967), new DateTime(2024, 5, 25, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6966), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 9, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6977), new DateTime(2024, 6, 1, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6975), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 14, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6986), new DateTime(2024, 5, 28, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6985), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6996), new DateTime(2024, 5, 26, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(6994), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7009), new DateTime(2024, 5, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7007), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 4, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7019), new DateTime(2024, 5, 31, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7018), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 9, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7029), new DateTime(2024, 6, 2, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7028), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 29, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7040), new DateTime(2024, 5, 30, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7039), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7081), new DateTime(2024, 5, 28, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7078), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 19, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7091), new DateTime(2024, 5, 27, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7090), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 4, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7101), new DateTime(2024, 6, 3, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7099), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7112), new DateTime(2024, 5, 25, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7110), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 9, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 6, 1, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7126), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 7, 14, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7139), new DateTime(2024, 5, 28, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7137), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "20/05/2024 2:35:45 am", new DateTime(2024, 6, 24, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 5, 26, 2, 35, 45, 425, DateTimeKind.Local).AddTicks(7148), 14 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.InsertData(
                table: "Trainee",
                columns: new[] { "Id", "Bio", "CreatedAt", "Email", "IsDeleted", "Name", "Password" },
                values: new object[,]
                {
                    { 1, "Bio for Trainee 1", "20/05/2024 2:35:45 am", "Trainee1@example.com", false, "Trainee 1", "password1" },
                    { 2, "Bio for Trainee 2", "20/05/2024 2:35:45 am", "Trainee2@example.com", false, "Trainee 2", "password2" },
                    { 3, "Bio for Trainee 3", "20/05/2024 2:35:45 am", "Trainee3@example.com", false, "Trainee 3", "password3" },
                    { 4, "Bio for Trainee 4", "20/05/2024 2:35:45 am", "Trainee4@example.com", false, "Trainee 4", "password4" },
                    { 5, "Bio for Trainee 5", "20/05/2024 2:35:45 am", "Trainee5@example.com", false, "Trainee 5", "password5" },
                    { 6, "Bio for Trainee 6", "20/05/2024 2:35:45 am", "Trainee6@example.com", false, "Trainee 6", "password6" },
                    { 7, "Bio for Trainee 7", "20/05/2024 2:35:45 am", "Trainee7@example.com", false, "Trainee 7", "password7" },
                    { 8, "Bio for Trainee 8", "20/05/2024 2:35:45 am", "Trainee8@example.com", false, "Trainee 8", "password8" },
                    { 9, "Bio for Trainee 9", "20/05/2024 2:35:45 am", "Trainee9@example.com", false, "Trainee 9", "password9" },
                    { 10, "Bio for Trainee 10", "20/05/2024 2:35:45 am", "Trainee10@example.com", false, "Trainee 10", "password10" },
                    { 11, "Bio for Trainee 11", "20/05/2024 2:35:45 am", "Trainee11@example.com", false, "Trainee 11", "password11" },
                    { 12, "Bio for Trainee 12", "20/05/2024 2:35:45 am", "Trainee12@example.com", false, "Trainee 12", "password12" },
                    { 13, "Bio for Trainee 13", "20/05/2024 2:35:45 am", "Trainee13@example.com", false, "Trainee 13", "password13" },
                    { 14, "Bio for Trainee 14", "20/05/2024 2:35:45 am", "Trainee14@example.com", false, "Trainee 14", "password14" },
                    { 15, "Bio for Trainee 15", "20/05/2024 2:35:45 am", "Trainee15@example.com", false, "Trainee 15", "password15" },
                    { 16, "Bio for Trainee 16", "20/05/2024 2:35:45 am", "Trainee16@example.com", false, "Trainee 16", "password16" },
                    { 17, "Bio for Trainee 17", "20/05/2024 2:35:45 am", "Trainee17@example.com", false, "Trainee 17", "password17" },
                    { 18, "Bio for Trainee 18", "20/05/2024 2:35:45 am", "Trainee18@example.com", false, "Trainee 18", "password18" },
                    { 19, "Bio for Trainee 19", "20/05/2024 2:35:45 am", "Trainee19@example.com", false, "Trainee 19", "password19" },
                    { 20, "Bio for Trainee 20", "20/05/2024 2:35:45 am", "Trainee20@example.com", false, "Trainee 20", "password20" },
                    { 21, "Bio for Trainee 21", "20/05/2024 2:35:45 am", "Trainee21@example.com", false, "Trainee 21", "password21" },
                    { 22, "Bio for Trainee 22", "20/05/2024 2:35:45 am", "Trainee22@example.com", false, "Trainee 22", "password22" },
                    { 23, "Bio for Trainee 23", "20/05/2024 2:35:45 am", "Trainee23@example.com", false, "Trainee 23", "password23" },
                    { 24, "Bio for Trainee 24", "20/05/2024 2:35:45 am", "Trainee24@example.com", false, "Trainee 24", "password24" },
                    { 25, "Bio for Trainee 25", "20/05/2024 2:35:45 am", "Trainee25@example.com", false, "Trainee 25", "password25" },
                    { 26, "Bio for Trainee 26", "20/05/2024 2:35:45 am", "Trainee26@example.com", false, "Trainee 26", "password26" },
                    { 27, "Bio for Trainee 27", "20/05/2024 2:35:45 am", "Trainee27@example.com", false, "Trainee 27", "password27" },
                    { 28, "Bio for Trainee 28", "20/05/2024 2:35:45 am", "Trainee28@example.com", false, "Trainee 28", "password28" },
                    { 29, "Bio for Trainee 29", "20/05/2024 2:35:45 am", "Trainee29@example.com", false, "Trainee 29", "password29" },
                    { 30, "Bio for Trainee 30", "20/05/2024 2:35:45 am", "Trainee30@example.com", false, "Trainee 30", "password30" }
                });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "20/05/2024 2:35:45 am");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8301), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8358), new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8356) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8369), new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8368), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8391), new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8389), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8401), new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8399), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8411), new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8409), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8420), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8433), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 5, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8443), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8455), new DateTime(2024, 5, 29, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8453), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 5, 31, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8463), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8478), new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8476), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8488), new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8487), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8498), new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8497), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8507), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8521), new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8519), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8531), new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8530), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8540), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8552), new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8550), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8564), new DateTime(2024, 5, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8563), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 5, 29, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8573), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8585), new DateTime(2024, 5, 31, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8583), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 27, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8594), new DateTime(2024, 5, 28, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8593), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8605), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 17, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8617), new DateTime(2024, 5, 25, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8615), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 2, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8653), new DateTime(2024, 6, 1, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8651), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8665), new DateTime(2024, 5, 23, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8663), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 7, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8678), new DateTime(2024, 5, 30, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8675), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 7, 12, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8688), new DateTime(2024, 5, 26, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8686), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "18/05/2024 9:07:33 pm", new DateTime(2024, 6, 22, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8698), new DateTime(2024, 5, 24, 21, 7, 33, 721, DateTimeKind.Local).AddTicks(8696), 2 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "18/05/2024 9:07:33 pm");
        }
    }
}
