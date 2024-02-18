using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class RolesSeededd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49e37045-f83c-4e0f-a136-a904bf74e5e0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "822be4e8-5b37-40e4-b44c-c4fc88fd1c16");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d95c10f-0c8e-4b90-9fa5-bc8c8b0a65e7", "1", "Admin", "Admin" },
                    { "6cb9c81d-eb22-4a5e-be54-43f286c28d8a", "2", "user", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "49e37045-f83c-4e0f-a136-a904bf74e5e0", "1", "user", "user" },
                    { "822be4e8-5b37-40e4-b44c-c4fc88fd1c16", "1", "Admin", "Admin" }
                });
        }
    }
}
