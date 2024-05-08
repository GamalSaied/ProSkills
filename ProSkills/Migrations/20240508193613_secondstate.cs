using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class secondstate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedAt", "Image", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, "08/05/2024 10:36:13 م", "", false, "Revit" },
                    { 2, "08/05/2024 10:36:13 م", "", false, "Sap" },
                    { 3, "08/05/2024 10:36:13 م", "", false, "Etabs" },
                    { 4, "08/05/2024 10:36:13 م", "", false, "Forge" },
                    { 5, "08/05/2024 10:36:13 م", "", false, "primavera" },
                    { 6, "08/05/2024 10:36:13 م", "", false, "wpf" },
                    { 7, "08/05/2024 10:36:13 م", "", false, "Windows Form" },
                    { 8, "08/05/2024 10:36:13 م", "", false, "NavisWorks" },
                    { 9, "08/05/2024 10:36:13 م", "", false, "Graphics" }
                });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "08/05/2024 10:36:13 م");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "08/05/2024 05:51:53 م");
        }
    }
}
