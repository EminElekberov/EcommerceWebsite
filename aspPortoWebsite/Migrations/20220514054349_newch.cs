using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class newch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Sales",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Sales",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderInformation",
                table: "Sales",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Sales",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SteetAddress",
                table: "Sales",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Town",
                table: "Sales",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "OrderInformation",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "SteetAddress",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "Town",
                table: "Sales");
        }
    }
}
