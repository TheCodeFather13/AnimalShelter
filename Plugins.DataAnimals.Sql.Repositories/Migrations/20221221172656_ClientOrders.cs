using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class ClientOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "038c96fe-c66e-46cf-a219-26661b25dc86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d699f20-d6e1-4496-a41a-1cb3138ebd6f");

            migrationBuilder.CreateTable(
                name: "ClientOrders",
                columns: table => new
                {
                    ClientOrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacts = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrders", x => x.ClientOrderId);
                });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 21, 17, 26, 56, 755, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 21, 17, 26, 56, 755, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 21, 17, 26, 56, 755, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a974d29d-fdc6-4272-bc8b-ddb9bd79cdf5", "dc8d8493-e0b0-4b2e-8eb9-8b9382a47d8d", "User", "USER" },
                    { "fdc81aba-e4c7-46d8-83e5-a1dd97e8407a", "ff59c735-b14d-46df-bd09-7db58b39b17e", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientOrders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a974d29d-fdc6-4272-bc8b-ddb9bd79cdf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdc81aba-e4c7-46d8-83e5-a1dd97e8407a");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 1,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 6, 11, 41, 16, 733, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 6, 11, 41, 16, 733, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2022, 12, 6, 11, 41, 16, 733, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "038c96fe-c66e-46cf-a219-26661b25dc86", "918d18f1-a3b8-4623-b0b6-b72893f19eb4", "Admin", "ADMIN" },
                    { "1d699f20-d6e1-4496-a41a-1cb3138ebd6f", "8235ae3c-e451-46e1-87c8-572a5ad48e01", "User", "USER" }
                });
        }
    }
}
