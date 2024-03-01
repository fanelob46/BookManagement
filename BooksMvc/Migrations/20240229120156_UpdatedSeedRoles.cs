using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6a60f48c-3731-4319-92e4-ac1effd5e933");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9a3e5e-9682-42a7-b377-1dd84d79682a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6a60f48c-3731-4319-92e4-ac1effd5e933", "1", "Admin", "Admin" },
                    { "8e9a3e5e-9682-42a7-b377-1dd84d79682a", "2", "user", "user" }
                });
        }
    }
}
