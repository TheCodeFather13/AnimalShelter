using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionsToDbNr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b5a7c3f-c0a9-4cc0-a2dd-5cee7b9d853c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f67e1a0-d711-4e9b-8e13-bbeb18c1bf93");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d57907f-829a-486f-af35-31af842374e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c5fc51e-29d9-43b2-bbef-80e302841ef5");

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalId = table.Column<int>(type: "int", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                value: new DateTime(2023, 1, 21, 17, 54, 2, 234, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 2,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 54, 2, 234, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "AnimalId",
                keyValue: 3,
                column: "DayOfPublication",
                value: new DateTime(2023, 1, 21, 17, 54, 2, 234, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b5a7c3f-c0a9-4cc0-a2dd-5cee7b9d853c", "dba0e8c9-1a0b-4604-b7bc-c918bd1e741f", "User", "USER" },
                    { "1f67e1a0-d711-4e9b-8e13-bbeb18c1bf93", "add7e9a8-8429-4ef1-9cf7-02beb3a22088", "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_AnimalId",
                table: "Images",
                column: "AnimalId");
        }
    }
}
