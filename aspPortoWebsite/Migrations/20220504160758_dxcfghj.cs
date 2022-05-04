using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class dxcfghj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productCategoryId",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_productCategoryId",
                table: "Books",
                column: "productCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_productCategories_productCategoryId",
                table: "Books",
                column: "productCategoryId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_productCategories_productCategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_productCategoryId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "productCategoryId",
                table: "Books");
        }
    }
}
