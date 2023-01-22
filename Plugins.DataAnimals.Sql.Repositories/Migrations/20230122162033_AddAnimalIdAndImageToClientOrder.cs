using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Plugins.DataAnimals.Sql.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class AddAnimalIdAndImageToClientOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "30b835e5-b0b7-44b3-a8c6-b758e4882443");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74e2e38b-743a-4ea3-b6de-b5327777a901");

            migrationBuilder.AddColumn<string>(
                name: "animalId",
                table: "ClientOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "animalImagePath",
                table: "ClientOrders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1b11f1c9-42df-4ce6-bdc9-2d682d1c5ef5", "4d79cfda-8127-4ac1-a405-9bb04b2ea4c3", "User", "USER" },
                    { "37f152e2-7c20-49fe-9dfa-cac315440d28", "1bee4f9e-b069-4ca2-a5e0-97df808de4c4", "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b11f1c9-42df-4ce6-bdc9-2d682d1c5ef5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37f152e2-7c20-49fe-9dfa-cac315440d28");

            migrationBuilder.DropColumn(
                name: "animalId",
                table: "ClientOrders");

            migrationBuilder.DropColumn(
                name: "animalImagePath",
                table: "ClientOrders");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "30b835e5-b0b7-44b3-a8c6-b758e4882443", "ba38d98d-d917-4db0-9930-27d11bc2464f", "Admin", "ADMIN" },
                    { "74e2e38b-743a-4ea3-b6de-b5327777a901", "eaa11c74-92ff-4a7a-b30c-b4972224596c", "User", "USER" }
                });
        }
    }
}
