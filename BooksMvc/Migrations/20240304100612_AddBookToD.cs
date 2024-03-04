using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddBookToD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "ISBN",
                table: "Books",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "LendingPrice",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3bc53cab-4ec0-42dc-ab0e-d3b08b14ac7a", "3", "HelpDesk", "HelpDesk" },
                    { "6f6937c4-d180-4d9f-8a14-376f3e518b36", "1", "Admin", "Admin" },
                    { "7a2e80ee-aeb4-48ad-9413-e2120f711a56", "4", "user", "user" },
                    { "fc1f0f82-7d92-4f9a-a73b-4787b43a5429", "2", "Manager", "Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3bc53cab-4ec0-42dc-ab0e-d3b08b14ac7a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f6937c4-d180-4d9f-8a14-376f3e518b36");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7a2e80ee-aeb4-48ad-9413-e2120f711a56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1f0f82-7d92-4f9a-a73b-4787b43a5429");

            migrationBuilder.DropColumn(
                name: "LendingPrice",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Books",
                newName: "ISBN");

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
    }
}
