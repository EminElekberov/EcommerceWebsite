using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class checkout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Checkouts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: false),
                    SteetAddress = table.Column<string>(nullable: false),
                    Town = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    EmailAddress = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkouts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Checkouts");
        }
    }
}
