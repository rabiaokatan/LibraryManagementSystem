using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementApp.Data.Migrations
{
    public partial class Authoradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author",
                table: "Author");

            migrationBuilder.RenameTable(
                name: "Author",
                newName: "Author_1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author_1",
                table: "Author_1",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_1_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author_1",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_1_AuthorId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Author_1",
                table: "Author_1");

            migrationBuilder.RenameTable(
                name: "Author_1",
                newName: "Author");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Author",
                table: "Author",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Author",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
