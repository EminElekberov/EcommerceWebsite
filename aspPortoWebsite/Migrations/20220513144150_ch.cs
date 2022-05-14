using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class ch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderInformation",
                table: "Checkouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Checkouts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checkouts_UserId",
                table: "Checkouts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_AspNetUsers_UserId",
                table: "Checkouts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_AspNetUsers_UserId",
                table: "Checkouts");

            migrationBuilder.DropIndex(
                name: "IX_Checkouts_UserId",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "OrderInformation",
                table: "Checkouts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Checkouts");
        }
    }
}
