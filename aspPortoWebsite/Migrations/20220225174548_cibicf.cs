using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class cibicf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(maxLength: 255, nullable: false),
                    Name = table.Column<string>(maxLength: 15, nullable: false),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrendWord = table.Column<string>(nullable: false),
                    DisCount = table.Column<string>(nullable: false),
                    ClothType = table.Column<string>(maxLength: 15, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fullname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentAdresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAdresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAdresses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 1, "On Jackets", "Get up to 60% off", "slide1.jpg", 130, "Winter Fashion Trends" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "ID", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 2, "On Coat", "Get up to 10% off", "slide2.jpg", 200, "Season Fashion Trends" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAdresses_StudentId",
                table: "StudentAdresses",
                column: "StudentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "StudentAdresses");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
