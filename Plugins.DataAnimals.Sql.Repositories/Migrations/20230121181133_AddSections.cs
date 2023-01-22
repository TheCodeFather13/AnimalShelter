using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddSections : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83496a1b-0a74-4699-b4f8-6949d57b0f6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b54529-14c6-4e6d-881e-0233d9782ec1");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 18, 11, 33, 237, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5762e32-a7a6-4573-955e-0b3d0fe0eb31", "9c092d22-ef96-4ae4-9054-dd55719c9b61", "Admin", "ADMIN" },
                    { "c7c974fa-b52d-4b51-82f5-682df2ddce67", "a6677bba-41ab-4863-b083-8f79e95616c4", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5762e32-a7a6-4573-955e-0b3d0fe0eb31");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7c974fa-b52d-4b51-82f5-682df2ddce67");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 59, 37, 669, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 59, 37, 669, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 59, 37, 669, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "83496a1b-0a74-4699-b4f8-6949d57b0f6b", "f4c507fb-3ae5-4437-982f-81e0175424d8", "Admin", "ADMIN" },
                    { "d8b54529-14c6-4e6d-881e-0233d9782ec1", "153b3289-fe0c-4932-9173-81922ed8e222", "User", "USER" }
                });
        }
    }
}
