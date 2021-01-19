using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementApp.Data.Migrations
{
    public partial class Somethingschanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ISBN",
                table: "Book",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 13);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ISBN",
                table: "Book",
                type: "int",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
