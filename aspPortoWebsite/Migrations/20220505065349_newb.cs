using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class newb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BooksId",
                table: "Reviews",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BooksId",
                table: "Reviews",
                column: "BooksId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Books_BooksId",
                table: "Reviews",
                column: "BooksId",
                principalTable: "Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Books_BooksId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_BooksId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "BooksId",
                table: "Reviews");
        }
    }
}
