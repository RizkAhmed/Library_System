using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCRUD.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookUserAccount",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    UserAccountsId = table.Column<int>(type: "int", nullable: false),
                    UserAccountId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_bookUserAccount_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bookUserAccount_userAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "userAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookUserAccount_BookId",
                table: "bookUserAccount",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_bookUserAccount_UserAccountId",
                table: "bookUserAccount",
                column: "UserAccountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookUserAccount");
        }
    }
}
