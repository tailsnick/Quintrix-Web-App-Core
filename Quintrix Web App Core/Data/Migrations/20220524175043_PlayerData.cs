using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quintrix_Web_App_Core.Data.Migrations
{
    public partial class PlayerData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Speed",
                table: "PlayerModels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speed",
                table: "PlayerModels");
        }
    }
}
