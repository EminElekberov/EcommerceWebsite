using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class hbidia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Books_ProductsCategoryId",
                table: "Books",
                column: "ProductsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_productCategories_ProductsCategoryId",
                table: "Books",
                column: "ProductsCategoryId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_productCategories_ProductsCategoryId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_ProductsCategoryId",
                table: "Books");

            migrationBuilder.AddColumn<int>(
                name: "productCategoryId",
                table: "Books",
                type: "int",
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
    }
}
