using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionsToDbNr3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d57907f-829a-486f-af35-31af842374e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c5fc51e-29d9-43b2-bbef-80e302841ef5");

            migrationBuilder.DropColumn(
                name: "InfoAboutAnimal",
                table: "ClientOrders");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83496a1b-0a74-4699-b4f8-6949d57b0f6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8b54529-14c6-4e6d-881e-0233d9782ec1");

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
                value: new DateTime(2023, 1, 21, 17, 57, 59, 145, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 57, 59, 145, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 57, 59, 145, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0d57907f-829a-486f-af35-31af842374e8", "5bc04a2b-8957-48fe-8c91-70b0e6a0cd6f", "Admin", "ADMIN" },
                    { "3c5fc51e-29d9-43b2-bbef-80e302841ef5", "7fbee912-8333-4a05-bf9d-41c3455974e9", "User", "USER" }
                });
        }
    }
}
