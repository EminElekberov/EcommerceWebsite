using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class myblogsh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "ContactsForms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ContactsForms",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "ContactsForms");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ContactsForms");
        }
    }
}
