using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2fbab35b-51f4-4a5b-a119-b77a17df038a", "4", "user", "user" },
                    { "510315f0-0c38-4e0c-b03f-8435c1319b39", "1", "Admin", "Admin" },
                    { "5ae4a66f-403c-4702-a89f-5ce01f800414", "2", "user", "Manager" },
                    { "bebb8268-515e-42ad-9865-49145e5d5935", "3", "user", "HelpDesk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2fbab35b-51f4-4a5b-a119-b77a17df038a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "510315f0-0c38-4e0c-b03f-8435c1319b39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ae4a66f-403c-4702-a89f-5ce01f800414");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bebb8268-515e-42ad-9865-49145e5d5935");
        }
    }
}
