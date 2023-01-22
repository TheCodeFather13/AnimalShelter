using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddSectionsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "27b2f480-0dfb-4eaa-935e-23ca6deff0f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c30553d1-288d-43e2-8117-3cbdf122c34c");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");

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
    }
}
