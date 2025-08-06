using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ravi.PieShop.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "United States" },
                    { 2, "Canada" },
                    { 3, "United Kingdom" },
                    { 4, "Mexico" },
                    { 5, "Germany" },
                    { 6, "Japan" }
                });

            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "JobCategoryId", "JobCategoryName" },
                values: new object[,]
                {
                    { 1, "Software Engineer" },
                    { 2, "Data Scientist" },
                    { 3, "Product Manager" },
                    { 4, "UX Designer" },
                    { 5, "DevOps Engineer" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "City", "Comment", "CountryId", "Email", "ExitDate", "FirstName", "Gender", "ImageName", "IsOnHoliday", "JobCategoryId", "JoinedDate", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "Smoker", "Street", "Zip" },
                values: new object[] { 1, new DateTime(1987, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anytown", "New employee, eager to learn.", 1, "jdoe@anywhere.com", null, "John", 0, null, false, 1, new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Doe", 37.774900000000002, -122.4194, 1, "123-456-7890", false, "123 Main St", "12345" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "JobCategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "JobCategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "JobCategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "JobCategoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "JobCategoryId",
                keyValue: 1);
        }
    }
}
