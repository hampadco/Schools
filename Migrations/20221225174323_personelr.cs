using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace scools.Migrations
{
    public partial class personelr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calss",
                table: "tbl_Personels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Calss",
                table: "tbl_Personels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
