using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddVaccination : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15814282-b0a3-4372-a9c6-0cfb78025246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ba09528-869e-419c-b9ea-28743c143509");

            migrationBuilder.AddColumn<bool>(
                name: "IsVaccinated",
                table: "Animals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                columns: new[] { "DayOfPublication", "IsVaccinated" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1231), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                columns: new[] { "DayOfPublication", "IsVaccinated" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1233), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                columns: new[] { "DayOfPublication", "IsVaccinated" },
                values: new object[] { new DateTime(2023, 1, 14, 16, 56, 32, 41, DateTimeKind.Utc).AddTicks(1234), false });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "19c19113-e251-4e34-8ed0-b345a7fdcb34", "3e685660-279c-4e00-b7ac-3624442ec4e3", "Admin", "ADMIN" },
                    { "7ccabd0f-ee51-4de1-a17d-8a4d58518cc5", "d0dd9db7-3da2-4e5f-aa09-82792125fb77", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19c19113-e251-4e34-8ed0-b345a7fdcb34");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ccabd0f-ee51-4de1-a17d-8a4d58518cc5");

            migrationBuilder.DropColumn(
                name: "IsVaccinated",
                table: "Animals");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 6, 17, 34, 48, 737, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 6, 17, 34, 48, 737, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 6, 17, 34, 48, 737, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "15814282-b0a3-4372-a9c6-0cfb78025246", "fb743de3-6605-4a05-89db-7a47cf3676ae", "Admin", "ADMIN" },
                    { "8ba09528-869e-419c-b9ea-28743c143509", "a6c701da-e566-4e4c-9ae3-d57c374197a0", "User", "USER" }
                });
        }
    }
}
