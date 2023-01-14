using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a974d29d-fdc6-4272-bc8b-ddb9bd79cdf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fdc81aba-e4c7-46d8-83e5-a1dd97e8407a");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClientOrders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Contacts",
                table: "ClientOrders",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnimalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Animals_AnimalId",
                        column: x => x.AnimalId,
                        principalTable: "Animals",
                        principalColumn: "AnimalId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_AnimalId",
                table: "Images",
                column: "AnimalId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "15814282-b0a3-4372-a9c6-0cfb78025246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ba09528-869e-419c-b9ea-28743c143509");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ClientOrders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Contacts",
                table: "ClientOrders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

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
    }
}
