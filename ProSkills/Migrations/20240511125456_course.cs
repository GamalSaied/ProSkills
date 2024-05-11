using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class course : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CourseImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false),
                    NumberOfStudents = table.Column<int>(type: "int", nullable: false),
                    TotalFilesSize = table.Column<double>(type: "float", nullable: false),
                    NumberOfAssessment = table.Column<int>(type: "int", nullable: false),
                    NumberOfLessons = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    instructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_instructor_instructorId",
                        column: x => x.instructorId,
                        principalTable: "instructor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CourseImagePath", "CreatedAt", "Description", "EndAt", "Hours", "IsDeleted", "Location", "Name", "NumberOfAssessment", "NumberOfLessons", "NumberOfStudents", "StartAt", "TotalFilesSize", "instructorId" },
                values: new object[,]
                {
                    { 1, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an introduction to programming concepts and techniques.", new DateTime(2024, 6, 10, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1368), 40, false, "Online", "Introduction to Programming", 5, 20, 25, new DateTime(2024, 5, 18, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1360), 10.5, 14 },
                    { 2, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of web development including HTML, CSS, and JavaScript.", new DateTime(2024, 6, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1443), 60, false, "Online", "Web Development Fundamentals", 7, 25, 30, new DateTime(2024, 5, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1440), 15.199999999999999, 4 },
                    { 3, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers fundamental data structures and algorithms.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1481), 45, false, "Online", "Data Structures and Algorithms", 6, 22, 20, new DateTime(2024, 5, 16, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1478), 11.699999999999999, 1 },
                    { 4, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an introduction to machine learning concepts and techniques.", new DateTime(2024, 7, 10, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1503), 55, false, "Online", "Machine Learning Basics", 6, 23, 25, new DateTime(2024, 5, 21, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1500), 13.5, 9 },
                    { 5, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the design and management of relational databases.", new DateTime(2024, 6, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1525), 50, false, "Online", "Database Design and Management", 7, 25, 30, new DateTime(2024, 5, 18, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1522), 14.1, 6 },
                    { 6, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an overview of cybersecurity concepts and principles.", new DateTime(2024, 6, 30, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1547), 55, false, "Online", "Cybersecurity Fundamentals", 6, 24, 25, new DateTime(2024, 5, 23, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1543), 12.300000000000001, 14 },
                    { 7, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers fundamental concepts and techniques in artificial intelligence.", new DateTime(2024, 7, 5, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1573), 50, false, "Online", "Artificial Intelligence Basics", 6, 23, 20, new DateTime(2024, 5, 19, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1570), 12.800000000000001, 2 },
                    { 8, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers software engineering principles and best practices.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1596), 45, false, "Online", "Software Engineering Principles", 6, 22, 30, new DateTime(2024, 5, 17, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1593), 13.199999999999999, 3 },
                    { 9, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of Python programming language.", new DateTime(2024, 6, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1618), 40, false, "Online", "Python Programming Basics", 5, 20, 25, new DateTime(2024, 5, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1615), 10.800000000000001, 11 },
                    { 10, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers data analysis techniques using Python programming language.", new DateTime(2024, 6, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1643), 50, false, "Online", "Data Analysis with Python", 6, 22, 20, new DateTime(2024, 5, 22, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1639), 12.199999999999999, 2 },
                    { 11, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the fundamentals of Java programming language.", new DateTime(2024, 6, 30, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1667), 55, false, "Online", "Java Programming Fundamentals", 6, 24, 25, new DateTime(2024, 5, 24, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1664), 13.5, 2 },
                    { 12, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers essential concepts in computer networks.", new DateTime(2024, 6, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1689), 45, false, "Online", "Computer Networks Essentials", 6, 22, 30, new DateTime(2024, 5, 21, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1686), 13.1, 13 },
                    { 13, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an introduction to the Linux operating system.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1722), 40, false, "Online", "Introduction to Linux", 5, 20, 25, new DateTime(2024, 5, 19, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1718), 10.6, 15 },
                    { 14, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of mobile app development.", new DateTime(2024, 6, 10, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1744), 35, false, "Online", "Mobile App Development Basics", 5, 18, 20, new DateTime(2024, 5, 18, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1741), 11.199999999999999, 1 },
                    { 15, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers frontend web development technologies and frameworks.", new DateTime(2024, 6, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1771), 60, false, "Online", "Frontend Web Development", 7, 25, 30, new DateTime(2024, 5, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1768), 15.800000000000001, 7 },
                    { 16, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an introduction to cloud computing concepts and services.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1792), 45, false, "Online", "Cloud Computing Fundamentals", 6, 22, 25, new DateTime(2024, 5, 16, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1789), 12.5, 11 },
                    { 17, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the fundamentals of React.js library for building user interfaces.", new DateTime(2024, 6, 30, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1815), 55, false, "Online", "React.js Fundamentals", 6, 24, 30, new DateTime(2024, 5, 23, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1811), 13.800000000000001, 9 },
                    { 18, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers server-side development with Node.js runtime environment.", new DateTime(2024, 7, 5, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1836), 50, false, "Online", "Node.js Development", 6, 23, 20, new DateTime(2024, 5, 19, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1832), 12.300000000000001, 3 },
                    { 19, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers database concepts and technologies for developers.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1860), 45, false, "Online", "Databases for Developers", 6, 22, 25, new DateTime(2024, 5, 17, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1857), 13.1, 10 },
                    { 20, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course provides an introduction to deep learning concepts and techniques.", new DateTime(2024, 6, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1882), 40, false, "Online", "Deep Learning Fundamentals", 5, 20, 30, new DateTime(2024, 5, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1878), 11.800000000000001, 5 },
                    { 21, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers essential cybersecurity concepts and practices.", new DateTime(2024, 6, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1903), 50, false, "Online", "Cybersecurity Essentials", 6, 22, 20, new DateTime(2024, 5, 22, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1900), 12.5, 2 },
                    { 22, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of Ruby programming language.", new DateTime(2024, 6, 30, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1925), 55, false, "Online", "Ruby Programming Basics", 6, 24, 25, new DateTime(2024, 5, 24, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1921), 13.199999999999999, 9 },
                    { 23, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers fundamental concepts in computer architecture.", new DateTime(2024, 6, 20, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1949), 45, false, "Online", "Computer Architecture Fundamentals", 6, 22, 30, new DateTime(2024, 5, 21, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1946), 13.6, 2 },
                    { 24, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of JavaScript programming language.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1971), 40, false, "Online", "JavaScript Programming Basics", 5, 20, 25, new DateTime(2024, 5, 19, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1967), 10.9, 6 },
                    { 25, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers fundamental concepts and techniques in software testing.", new DateTime(2024, 6, 10, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1991), 35, false, "Online", "Software Testing Fundamentals", 5, 18, 20, new DateTime(2024, 5, 18, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(1988), 11.4, 8 },
                    { 26, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the fundamentals of Angular framework for building web applications.", new DateTime(2024, 6, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2012), 60, false, "Online", "Angular Framework Fundamentals", 7, 25, 30, new DateTime(2024, 5, 25, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2009), 15.199999999999999, 12 },
                    { 27, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the basics of iOS app development using Swift programming language.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2035), 45, false, "Online", "iOS App Development Basics", 6, 22, 25, new DateTime(2024, 5, 16, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2032), 13.699999999999999, 11 },
                    { 28, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers server-side web development with ASP.NET Core framework.", new DateTime(2024, 6, 30, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2116), 55, false, "Online", "ASP.NET Core Development", 6, 24, 30, new DateTime(2024, 5, 23, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2103), 14.300000000000001, 3 },
                    { 29, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the fundamentals of C# programming language.", new DateTime(2024, 7, 5, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2151), 50, false, "Online", "C# Programming Fundamentals", 6, 23, 20, new DateTime(2024, 5, 19, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2148), 12.6, 8 },
                    { 30, "path/to/trainee/image.jpg", "11/05/2024 03:54:55 م", "This course covers the fundamentals of game development using Unity game engine.", new DateTime(2024, 6, 15, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2172), 45, false, "Online", "Unity Game Development Fundamentals", 6, 22, 25, new DateTime(2024, 5, 17, 15, 54, 55, 603, DateTimeKind.Local).AddTicks(2169), 13.9, 9 }
                });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "11/05/2024 03:54:55 م");

            migrationBuilder.CreateIndex(
                name: "IX_Course_instructorId",
                table: "Course",
                column: "instructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedAt", "Hours", "Image", "IsDeleted", "Name", "NumberOfAssesments", "NumberOfLessons", "NumberOfTrainees", "TotlaFileSize" },
                values: new object[,]
                {
                    { 1, "11/05/2024 11:00:20 ص", 30, "", false, "package Free", 100, 100, 100, 20.0 },
                    { 2, "11/05/2024 11:00:20 ص", 60, "", false, "package Premium", 200, 200, 200, 40.0 },
                    { 3, "11/05/2024 11:00:20 ص", 100, "", false, "package Premium Advanced", 400, 400, 400, 100.0 }
                });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "11/05/2024 11:00:20 ص");
        }
    }
}
