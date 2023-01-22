using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalIdAndImageToClientOrderNr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b11f1c9-42df-4ce6-bdc9-2d682d1c5ef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37f152e2-7c20-49fe-9dfa-cac315440d28");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "698ea1dc-9b9c-4d8f-96e5-b3f9ade0c5de", "9bb25d83-f691-4254-9f36-695f0e43399e", "Admin", "ADMIN" },
                    { "8539790f-dfef-4a58-8f0f-bfca4407766c", "a9a80cd4-71ed-43c1-8c21-46e1fcb9be0f", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "698ea1dc-9b9c-4d8f-96e5-b3f9ade0c5de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8539790f-dfef-4a58-8f0f-bfca4407766c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b11f1c9-42df-4ce6-bdc9-2d682d1c5ef5", "4d79cfda-8127-4ac1-a405-9bb04b2ea4c3", "User", "USER" },
                    { "37f152e2-7c20-49fe-9dfa-cac315440d28", "1bee4f9e-b069-4ca2-a5e0-97df808de4c4", "Admin", "ADMIN" }
                });
        }
    }
}
