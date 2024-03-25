using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId1",
                table: "Books",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryId1",
                table: "Books",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryId1",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryId1",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Books");
        }
    }
}
