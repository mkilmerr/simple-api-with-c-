using Microsoft.EntityFrameworkCore.Migrations;

namespace crud.Migrations
{
    public partial class UserDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Salario",
                table: "UserTbl",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salario",
                table: "UserTbl",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
