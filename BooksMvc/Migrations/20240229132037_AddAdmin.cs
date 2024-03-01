using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "44fcd7e7-9218-435f-8095-0d238340cf4b", "2", "Manager", "Manager" },
                    { "c7ac8621-968e-4195-a2bf-4357233223a3", "3", "HelpDesk", "HelpDesk" },
                    { "c84d0128-ab7a-49e3-a515-709a8c5e426d", "4", "user", "user" },
                    { "d651079b-9d1c-40a8-bad4-016e365c3fe5", "1", "Admin", "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44fcd7e7-9218-435f-8095-0d238340cf4b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7ac8621-968e-4195-a2bf-4357233223a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c84d0128-ab7a-49e3-a515-709a8c5e426d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d651079b-9d1c-40a8-bad4-016e365c3fe5");

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
    }
}
