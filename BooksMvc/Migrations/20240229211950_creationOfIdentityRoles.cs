using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class creationOfIdentityRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e0dd8cf-a84b-40a8-bfc9-fef8ea6dcea5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ad69102-47a8-4517-8a36-c0472e52f690");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2533cde-8283-4010-91aa-65d38f2f4e80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eadebf0a-02fe-4127-8781-341b5d435060");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33e53f05-536b-473d-acb2-798c53d71b26", "4", "user", "user" },
                    { "91f74e3a-4761-4b75-8fe8-beab090e7e56", "2", "Manager", "Manager" },
                    { "ba5a9641-1a52-4e38-ad0b-1e0c549d7e0e", "1", "Admin", "Admin" },
                    { "c6957c51-b837-4b4a-9580-982356d9783a", "3", "HelpDesk", "HelpDesk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33e53f05-536b-473d-acb2-798c53d71b26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91f74e3a-4761-4b75-8fe8-beab090e7e56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba5a9641-1a52-4e38-ad0b-1e0c549d7e0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6957c51-b837-4b4a-9580-982356d9783a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3e0dd8cf-a84b-40a8-bfc9-fef8ea6dcea5", "1", "Admin", "Admin" },
                    { "7ad69102-47a8-4517-8a36-c0472e52f690", "3", "HelpDesk", "HelpDesk" },
                    { "b2533cde-8283-4010-91aa-65d38f2f4e80", "4", "user", "user" },
                    { "eadebf0a-02fe-4127-8781-341b5d435060", "2", "Manager", "Manager" }
                });
        }
    }
}
