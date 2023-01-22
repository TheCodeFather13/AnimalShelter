using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddDataToDbSecondTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5762e32-a7a6-4573-955e-0b3d0fe0eb31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c974fa-b52d-4b51-82f5-682df2ddce67");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30b835e5-b0b7-44b3-a8c6-b758e4882443", "ba38d98d-d917-4db0-9930-27d11bc2464f", "Admin", "ADMIN" },
                    { "74e2e38b-743a-4ea3-b6de-b5327777a901", "eaa11c74-92ff-4a7a-b30c-b4972224596c", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b835e5-b0b7-44b3-a8c6-b758e4882443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74e2e38b-743a-4ea3-b6de-b5327777a901");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "CategoryId", "Contacts", "DayOfPublication", "Gender", "ImagePath", "IsVaccinated", "Name" },
                values: new object[,]
                {
                    { 1, "1 месяц", 1, "Maria 079245611", new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1673), "Female", "css/Images/Cat1.jpg", false, "Муся" },
                    { 2, "5 месяцев", 1, "Svetlana 069367315", new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1675), "Male", "css/Images/Cat2.jpg", false, "Вася" },
                    { 3, "1 год", 1, "Georgii 079996377", new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1676), "Female", "css/Images/Cat3.jpg", false, "Бусинка" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5762e32-a7a6-4573-955e-0b3d0fe0eb31", "9c092d22-ef96-4ae4-9054-dd55719c9b61", "Admin", "ADMIN" },
                    { "c7c974fa-b52d-4b51-82f5-682df2ddce67", "a6677bba-41ab-4863-b083-8f79e95616c4", "User", "USER" }
                });
        }
    }
}
