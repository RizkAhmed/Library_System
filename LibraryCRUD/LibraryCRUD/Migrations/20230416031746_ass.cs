using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCRUD.Migrations
{
    public partial class ass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookUserAccount");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bookUserAccount",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: true),
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    UserAccountId = table.Column<int>(type: "int", nullable: true),
                    UserAccountsId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "BookUserAccount",
                columns: table => new
                {
                    BooksId = table.Column<int>(type: "int", nullable: false),
                    UserAccountsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUserAccount", x => new { x.BooksId, x.UserAccountsId });
                    table.ForeignKey(
                        name: "FK_BookUserAccount_books_BooksId",
                        column: x => x.BooksId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUserAccount_userAccounts_UserAccountsId",
                        column: x => x.UserAccountsId,
                        principalTable: "userAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bookUserAccount_BookId",
                table: "bookUserAccount",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_bookUserAccount_UserAccountId",
                table: "bookUserAccount",
                column: "UserAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_BookUserAccount_UserAccountsId",
                table: "BookUserAccount",
                column: "UserAccountsId");
        }
    }
}
