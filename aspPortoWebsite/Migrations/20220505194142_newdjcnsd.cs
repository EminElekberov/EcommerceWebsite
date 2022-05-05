using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class newdjcnsd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopByCategories_productCategories_ProductCategoryiesId",
                table: "ShopByCategories");

            migrationBuilder.DropIndex(
                name: "IX_ShopByCategories_ProductCategoryiesId",
                table: "ShopByCategories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryiesId",
                table: "ShopByCategories");

            migrationBuilder.CreateIndex(
                name: "IX_ShopByCategories_ProductsCategoryId",
                table: "ShopByCategories",
                column: "ProductsCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopByCategories_productCategories_ProductsCategoryId",
                table: "ShopByCategories",
                column: "ProductsCategoryId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopByCategories_productCategories_ProductsCategoryId",
                table: "ShopByCategories");

            migrationBuilder.DropIndex(
                name: "IX_ShopByCategories_ProductsCategoryId",
                table: "ShopByCategories");

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryiesId",
                table: "ShopByCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShopByCategories_ProductCategoryiesId",
                table: "ShopByCategories",
                column: "ProductCategoryiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopByCategories_productCategories_ProductCategoryiesId",
                table: "ShopByCategories",
                column: "ProductCategoryiesId",
                principalTable: "productCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
