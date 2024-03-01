using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class addRoleAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "3e0dd8cf-a84b-40a8-bfc9-fef8ea6dcea5", "1", "Admin", "Admin" },
                    { "7ad69102-47a8-4517-8a36-c0472e52f690", "3", "HelpDesk", "HelpDesk" },
                    { "b2533cde-8283-4010-91aa-65d38f2f4e80", "4", "user", "user" },
                    { "eadebf0a-02fe-4127-8781-341b5d435060", "2", "Manager", "Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "44fcd7e7-9218-435f-8095-0d238340cf4b", "2", "Manager", "Manager" },
                    { "c7ac8621-968e-4195-a2bf-4357233223a3", "3", "HelpDesk", "HelpDesk" },
                    { "c84d0128-ab7a-49e3-a515-709a8c5e426d", "4", "user", "user" },
                    { "d651079b-9d1c-40a8-bad4-016e365c3fe5", "1", "Admin", "Admin" }
                });
        }
    }
}
