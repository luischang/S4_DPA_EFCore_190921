using Microsoft.EntityFrameworkCore.Migrations;

namespace S4_DPA_EFCore.CodeFirst.Migrations
{
    public partial class NewcolumnStatusinPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Player",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Player");
        }
    }
}
