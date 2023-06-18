using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCRUD.Migrations
{
    public partial class fav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookUserAccount",
                columns: table => new
                {
                    FavoritBooksId = table.Column<int>(type: "int", nullable: false),
                    FavoritByUsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUserAccount", x => new { x.FavoritBooksId, x.FavoritByUsersId });
                    table.ForeignKey(
                        name: "FK_BookUserAccount_books_FavoritBooksId",
                        column: x => x.FavoritBooksId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUserAccount_userAccounts_FavoritByUsersId",
                        column: x => x.FavoritByUsersId,
                        principalTable: "userAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookUserAccount_FavoritByUsersId",
                table: "BookUserAccount",
                column: "FavoritByUsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUserAccount");
        }
    }
}
