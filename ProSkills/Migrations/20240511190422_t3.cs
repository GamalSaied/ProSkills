using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProSkills.Migrations
{
    /// <inheritdoc />
    public partial class t3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "packageId",
                table: "RedeemCode",
                newName: "packageid");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 10, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3457), new DateTime(2024, 5, 18, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3451), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3519), new DateTime(2024, 5, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3517), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 5, 16, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3532), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 7, 10, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3559), new DateTime(2024, 5, 21, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3557), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3573), new DateTime(2024, 5, 18, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3571), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 30, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 5, 23, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3585), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 7, 5, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 5, 19, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3617), new DateTime(2024, 5, 17, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3614), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 5, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3628), 6 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3643), new DateTime(2024, 5, 22, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3641), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 30, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 5, 24, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3656), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 5, 21, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3673), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 5, 19, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3685), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 10, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 5, 18, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3698), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3714), new DateTime(2024, 5, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3712), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 5, 16, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3727), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 30, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3742), new DateTime(2024, 5, 23, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3740), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 7, 5, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3755), new DateTime(2024, 5, 19, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3753), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3768), new DateTime(2024, 5, 17, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3766), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3783), new DateTime(2024, 5, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3781), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3796), new DateTime(2024, 5, 22, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3794), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 30, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3809), new DateTime(2024, 5, 24, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3807), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 20, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3822), new DateTime(2024, 5, 21, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3838), new DateTime(2024, 5, 19, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3836), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 10, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3851), new DateTime(2024, 5, 18, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3849), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3864), new DateTime(2024, 5, 25, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3862), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3878), new DateTime(2024, 5, 16, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3876), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 30, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3893), new DateTime(2024, 5, 23, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3891), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 7, 5, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3906), new DateTime(2024, 5, 19, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3904), 3 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 10:04:22 م", new DateTime(2024, 6, 15, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 5, 17, 22, 4, 22, 688, DateTimeKind.Local).AddTicks(3917), 15 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.InsertData(
                table: "RedeemCode",
                columns: new[] { "Id", "Code", "CreatedAt", "IsDeleted", "PackageName", "packageid" },
                values: new object[] { 3, "gamal", "11/05/2024 10:04:22 م", false, "premium", 1 });

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "11/05/2024 10:04:22 م");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RedeemCode",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameColumn(
                name: "packageid",
                table: "RedeemCode",
                newName: "packageId");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 10, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 5, 18, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3343), 13 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 5, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3422), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3459), new DateTime(2024, 5, 16, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3456), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 7, 10, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3557), new DateTime(2024, 5, 21, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3554), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3578), new DateTime(2024, 5, 18, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3575), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 30, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 5, 23, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3592), 12 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 7, 5, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3616), new DateTime(2024, 5, 19, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3633), new DateTime(2024, 5, 17, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3630), 9 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3650), new DateTime(2024, 5, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3647), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 5, 22, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3664), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 30, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 5, 24, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3685), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3705), new DateTime(2024, 5, 21, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3703), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3722), new DateTime(2024, 5, 19, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3719), 7 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 10, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3739), new DateTime(2024, 5, 18, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3736), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3760), new DateTime(2024, 5, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3757), 4 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3777), new DateTime(2024, 5, 16, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3774), 11 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 30, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3794), new DateTime(2024, 5, 23, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3791), 8 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 7, 5, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 5, 19, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3809), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3831), new DateTime(2024, 5, 17, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3829), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3848), new DateTime(2024, 5, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3846), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3865), new DateTime(2024, 5, 22, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3862), 2 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 30, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3882), new DateTime(2024, 5, 24, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3879), 15 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedAt", "EndAt", "StartAt" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 20, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 5, 21, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 5, 19, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3916), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 10, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3936), new DateTime(2024, 5, 18, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3933), 10 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 5, 25, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3950), 5 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3973), new DateTime(2024, 5, 16, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3970), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 30, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3990), new DateTime(2024, 5, 23, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(3987), 14 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 7, 5, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(4007), new DateTime(2024, 5, 19, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(4004), 1 });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "EndAt", "StartAt", "instructorId" },
                values: new object[] { "11/05/2024 09:00:39 م", new DateTime(2024, 6, 15, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(4023), new DateTime(2024, 5, 17, 21, 0, 39, 675, DateTimeKind.Local).AddTicks(4021), 11 });

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");

            migrationBuilder.UpdateData(
                table: "instructor",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: "11/05/2024 09:00:39 م");
        }
    }
}
