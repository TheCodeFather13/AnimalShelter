using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19c19113-e251-4e34-8ed0-b345a7fdcb34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ccabd0f-ee51-4de1-a17d-8a4d58518cc5");

            migrationBuilder.AddColumn<string>(
                name: "InfoAboutAnimal",
                table: "ClientOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 16, 9, 22, 16, 650, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 16, 9, 22, 16, 650, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 16, 9, 22, 16, 650, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "27b2f480-0dfb-4eaa-935e-23ca6deff0f3", "4bb76d99-e692-490a-aed3-5377097fc930", "User", "USER" },
                    { "c30553d1-288d-43e2-8117-3cbdf122c34c", "1b3fefdc-27cd-4bde-b7b1-307df408d895", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27b2f480-0dfb-4eaa-935e-23ca6deff0f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c30553d1-288d-43e2-8117-3cbdf122c34c");

            migrationBuilder.DropColumn(
                name: "InfoAboutAnimal",
                table: "ClientOrders");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1234));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19c19113-e251-4e34-8ed0-b345a7fdcb34", "3e685660-279c-4e00-b7ac-3624442ec4e3", "Admin", "ADMIN" },
                    { "7ccabd0f-ee51-4de1-a17d-8a4d58518cc5", "d0dd9db7-3da2-4e5f-aa09-82792125fb77", "User", "USER" }
                });
        }
    }
}
