using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class inty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chapter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    downloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chapter_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    downloadLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaskLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Time = table.Column<TimeSpan>(type: "time", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lesson_Chapter_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 21, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8155), new DateTime(2024, 5, 29, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8151), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 6, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 6, 5, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8194), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8206), new DateTime(2024, 5, 27, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8204), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 21, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8227), new DateTime(2024, 6, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8225), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8236), new DateTime(2024, 5, 29, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8235), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 11, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 6, 3, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8245), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 16, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8255), new DateTime(2024, 5, 30, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8254), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 5, 28, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8266), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8277), new DateTime(2024, 5, 31, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8275), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 6, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8286), new DateTime(2024, 6, 2, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8285), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 11, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8296), new DateTime(2024, 6, 4, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8295), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8307), new DateTime(2024, 6, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8306), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8317), new DateTime(2024, 5, 30, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8315), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 21, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8326), new DateTime(2024, 5, 29, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8324), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 6, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8335), new DateTime(2024, 6, 5, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8334), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8347), new DateTime(2024, 5, 27, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8345), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 11, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8356), new DateTime(2024, 6, 3, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8354), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 16, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8394), new DateTime(2024, 5, 30, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8392), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8404), new DateTime(2024, 5, 28, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8415), new DateTime(2024, 5, 31, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8414), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 6, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8425), new DateTime(2024, 6, 2, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8424), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 11, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 6, 4, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8433), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 6, 1, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8443), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8456), new DateTime(2024, 5, 30, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8454), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 21, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 5, 29, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8463), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 6, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8474), new DateTime(2024, 6, 5, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8473), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8483), new DateTime(2024, 5, 27, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8482), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 11, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 6, 3, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8493), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 7, 16, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 5, 30, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8502), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "22/05/2024 4:13:08 am", new DateTime(2024, 6, 26, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8513), new DateTime(2024, 5, 28, 4, 13, 8, 245, DateTimeKind.Local).AddTicks(8512), 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 38.3174636301556m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 77.0061176700896m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 6.22352397527876m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 72.64833651898m, 6 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 79.7497695501043m, 25 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 24, 94.8256170255302m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 12, 94.4202853726518m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 40.7784996232669m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 73.8432900198056m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 8.19790807216856m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 85.019963472481m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 10.6739610222656m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 3, 86.3601290480304m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 88.2300507314242m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 83.5307415172606m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 83.5133734811495m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 67.7730526875572m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 95.3018130538701m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 82.1307857759459m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 97.9979544728852m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 17.4907865058996m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 49.3168029166474m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 28, 18.8781414570796m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 93.2244777101468m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 49.182689116682m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 39.9717340355215m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 69.0828801941417m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 94.4025308928603m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 96.3485781649915m, 11 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 31.7006892716309m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 58.2944689835464m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 47.6218425468775m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 92.9203772533339m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 14.3668758804026m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 69.580346540506m, 30 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 96.0225447976823m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 95.0597021563707m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 28, 81.7375216772558m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 12.232044150095m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 11.3725618006684m, 10 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 55.0723038275361m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 37.2455862595191m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 13.4760641221801m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 21, 8.7014791215268m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 16.4609696443066m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 9, 97.3122470203394m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 33.1031149755823m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 2, 31.3771421512973m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 7.73177293824803m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 62.1891664859269m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 53.8794449390587m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 41.586004077702m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 42.0199886466422m, 28 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 8.37457583383674m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 5, 22.6762318513898m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 93.5755994791459m, 27 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 32.0285156760915m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 76.6577216929669m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 42.9830984735284m, 24 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 38.5471107770729m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 80.3424110335099m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 60.5967339310795m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 66.2027090892429m, 14 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 13.9139828620513m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 33.4961737793784m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 57.1631901701925m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 30.8544906795097m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 13, 13.0644692970093m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 14, 8.3460761207437m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 5.26342492838435m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 42.1081887604406m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 99.7574520075426m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 83.0277222247311m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 98.7378731050397m, 1 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 76.3629954313178m, 26 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 17.5967394384684m, 13 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 14.6382422501294m, 22 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 26, 99.116332426912m, 21 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 16, 74.0718477678525m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 21.1011412895811m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 16, 85.940621245891m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 39.6177607515521m, 17 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 44.955315246054m, 19 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 22, 65.3370065540383m, 12 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 29, 46.7816556234995m, 2 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 3, 7.51056844598566m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 40.1698162458m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 35.6705847199322m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 18, 26.0533273267996m, 18 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 37.9998435159837m, 20 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 19, 79.7400171720102m, 23 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 9, 98.8426306835731m, 5 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 6, 22.1263518938085m, 15 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 67.9060102891503m, 7 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 32.7475421479913m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 1, 34.0263203085983m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 89.768926983001m, 29 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 28, 1.92987189012276m, 9 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 1.79963915898341m, 3 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 15, 23.6110995210505m, 21 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 4:13:08 am");

            migrationBuilder.CreateIndex(
                name: "IX_Chapter_CourseId",
                table: "Chapter",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Lesson_ChapterId",
                table: "Lesson",
                column: "ChapterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Chapter");

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
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "22/05/2024 3:06:15 am", new DateTime(2024, 6, 26, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 5, 28, 3, 6, 15, 261, DateTimeKind.Local).AddTicks(6653) });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 34.0890352628727m, 8 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 8, 57.4212873146928m, 10 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 11, 79.6602035727503m, 16 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 28, 36.4172305094766m });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 4, 86.3059781924457m });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 27, 56.2331964026594m, 13 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 39.7349168721793m, 11 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 9, 40.4716445605042m });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 21.5992207935455m, 5 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 7, 35.0108521062712m });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 20, 88.237964549637m, 4 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 80.4959085128094m, 8 });

            migrationBuilder.UpdateData(
                table: "CourseTrainee",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 14.4570625752456m, 9 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 44.0442813240036m, 1 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 25, 38.7878487844141m, 30 });

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
                columns: new[] { "Result", "TraineeId" },
                values: new object[] { 37.5641910059266m, 18 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 30, 35.7149428900199m, 26 });

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
                columns: new[] { "CourseId", "Result" },
                values: new object[] { 28, 50.3769419862079m });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 23, 40.7074706432168m, 3 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 7, 81.1875946039921m, 13 });

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
                columns: new[] { "CourseId", "Result", "TraineeId" },
                values: new object[] { 17, 27.3562613196877m, 25 });

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
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

            migrationBuilder.UpdateData(
                table: "Trainee",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "22/05/2024 3:06:15 am");

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
    }
}
