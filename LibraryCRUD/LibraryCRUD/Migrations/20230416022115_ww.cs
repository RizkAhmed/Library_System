using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryCRUD.Migrations
{
    public partial class ww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUserAccount_UserAccounts_UserAccountsId",
                table: "BookUserAccount");

            migrationBuilder.DropTable(
                name: "FavoriteBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts");

            migrationBuilder.RenameTable(
                name: "UserAccounts",
                newName: "userAccounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userAccounts",
                table: "userAccounts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUserAccount_userAccounts_UserAccountsId",
                table: "BookUserAccount",
                column: "UserAccountsId",
                principalTable: "userAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookUserAccount_userAccounts_UserAccountsId",
                table: "BookUserAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userAccounts",
                table: "userAccounts");

            migrationBuilder.RenameTable(
                name: "userAccounts",
                newName: "UserAccounts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAccounts",
                table: "UserAccounts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "FavoriteBooks",
                columns: table => new
                {
                    UserAccountId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteBooks", x => new { x.UserAccountId, x.BookId });
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_books_BookId",
                        column: x => x.BookId,
                        principalTable: "books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteBooks_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBooks_BookId",
                table: "FavoriteBooks",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookUserAccount_UserAccounts_UserAccountsId",
                table: "BookUserAccount",
                column: "UserAccountsId",
                principalTable: "UserAccounts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
