using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class newIntial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalInformation",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastPrice",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PresentPrice",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductCategoryiesId",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductsCategoryId",
                table: "Categories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SizeGuid",
                table: "Categories",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sku",
                table: "Categories",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    className = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductCategoryiesId",
                table: "Categories",
                column: "ProductCategoryiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_ProductCategory_ProductCategoryiesId",
                table: "Categories",
                column: "ProductCategoryiesId",
                principalTable: "ProductCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_ProductCategory_ProductCategoryiesId",
                table: "Categories");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ProductCategoryiesId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "AdditionalInformation",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PastPrice",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PresentPrice",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductCategoryiesId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ProductsCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SizeGuid",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Sku",
                table: "Categories");
        }
    }
}
