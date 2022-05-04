using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class duiebcissf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryModel_Categories_CategoryID",
                table: "GalleryModel");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "GalleryModel",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryModel_CategoryID",
                table: "GalleryModel",
                newName: "IX_GalleryModel_CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "GalleryModel",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryModel_Categories_CategoryId",
                table: "GalleryModel",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GalleryModel_Categories_CategoryId",
                table: "GalleryModel");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "GalleryModel",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_GalleryModel_CategoryId",
                table: "GalleryModel",
                newName: "IX_GalleryModel_CategoryID");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryID",
                table: "GalleryModel",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_GalleryModel_Categories_CategoryID",
                table: "GalleryModel",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
