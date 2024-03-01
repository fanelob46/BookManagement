using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddseedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8236047e-2747-475c-85d4-9abbcacdd3f0", "4", "user", "user" },
                    { "ac9a6ef9-3382-4545-97d4-1dd5f4ab5bf5", "2", "Manager", "Manager" },
                    { "e65797d3-6d33-4062-b9df-f62f1c300ac6", "1", "Admin", "Admin" },
                    { "eaae14a0-fd4b-40f2-a581-87663bd3e4da", "3", "HelpDesk", "HelpDesk" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8236047e-2747-475c-85d4-9abbcacdd3f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac9a6ef9-3382-4545-97d4-1dd5f4ab5bf5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e65797d3-6d33-4062-b9df-f62f1c300ac6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eaae14a0-fd4b-40f2-a581-87663bd3e4da");

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
    }
}
