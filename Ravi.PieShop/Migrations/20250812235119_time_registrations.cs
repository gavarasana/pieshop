using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ravi.PieShop.Migrations
{
    /// <inheritdoc />
    public partial class time_registrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 33,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 37,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 54,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 80,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 191,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 228,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 256,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 257,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 298,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 321,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 333,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 381,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 396,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 424,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 484,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 556,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 615,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 632,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 714,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 725,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 777,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 784,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 832,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 872,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 898,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 945,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 1,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 33,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 37,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 54,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 80,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 191,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 228,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 256,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 257,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 298,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 321,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 333,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 381,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 396,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 424,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 484,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 556,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 615,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 632,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 714,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 725,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 37, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 7, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 777,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 784,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 5, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 17, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 5, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 832,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 48, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 14, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 23, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 4, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 10, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 35, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 9, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 22, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 24, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 872,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 47, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 25, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 49, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 38, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 17, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 49, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 58, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 46, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 898,
                column: "StartTime",
                value: new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 40, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 4, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 29, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 6, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 21, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 13, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 20, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 33, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 53, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 13, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 12, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 40, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 54, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 21, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 41, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 12, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 33, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 945,
                column: "EndTime",
                value: new DateTime(2023, 10, 1, 16, 43, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 51, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 31, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 57, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 43, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 51, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 15, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 38, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 19, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 2, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 27, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 16, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 56, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 26, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 55, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 2, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 6, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 46, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 18, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 26, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 8, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 1, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 47, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 54, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 57, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 42, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 32, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 28, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 41, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 7, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 56, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 59, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 44, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 34, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 48, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 9, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 1, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 16, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 19, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 14, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 36, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 8, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 11, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 32, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 55, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 27, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 35, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 52, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 45, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 39, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 36, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 25, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 42, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 53, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 29, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 3, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 31, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 28, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 10, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 39, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 24, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 22, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 37, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 18, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 3, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 59, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 16, 44, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 58, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 8, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TimeRegistrations",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2023, 10, 1, 17, 52, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 1, 9, 25, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
