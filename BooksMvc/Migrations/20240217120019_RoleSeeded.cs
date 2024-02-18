using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class RoleSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d95c10f-0c8e-4b90-9fa5-bc8c8b0a65e7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cb9c81d-eb22-4a5e-be54-43f286c28d8a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "88f3e0ce-6f8d-4810-a110-2c4021ab020c", "1", "Admin", "Admin" },
                    { "96586124-0bc0-47c9-910e-cc7c4ff3d460", "2", "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88f3e0ce-6f8d-4810-a110-2c4021ab020c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96586124-0bc0-47c9-910e-cc7c4ff3d460");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d95c10f-0c8e-4b90-9fa5-bc8c8b0a65e7", "1", "Admin", "Admin" },
                    { "6cb9c81d-eb22-4a5e-be54-43f286c28d8a", "2", "user", "user" }
                });
        }
    }
}
