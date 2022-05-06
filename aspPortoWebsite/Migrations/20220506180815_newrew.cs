using Microsoft.EntityFrameworkCore.Migrations;

namespace aspPortoWebsite.Migrations
{
    public partial class newrew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyBlogCollectionReviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    MyBlogCollectionid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBlogCollectionReviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyBlogCollectionReviews_MyBlogCollections_MyBlogCollectionid",
                        column: x => x.MyBlogCollectionid,
                        principalTable: "MyBlogCollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyBlogCollectionReviews_MyBlogCollectionid",
                table: "MyBlogCollectionReviews",
                column: "MyBlogCollectionid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyBlogCollectionReviews");
        }
    }
}
