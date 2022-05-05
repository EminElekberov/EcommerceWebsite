using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class shopscategoryies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShopByCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    ProductCategoryiesId = table.Column<int>(nullable: true),
                    ProductsCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopByCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopByCategories_productCategories_ProductCategoryiesId",
                        column: x => x.ProductCategoryiesId,
                        principalTable: "productCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShopByCategories_ProductCategoryiesId",
                table: "ShopByCategories",
                column: "ProductCategoryiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShopByCategories");
        }
    }
}
