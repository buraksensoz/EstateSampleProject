using Microsoft.EntityFrameworkCore.Migrations;

namespace AppStoreOne.DataAccess.Migrations
{
    public partial class estateupgrade_15032022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Balkon",
                table: "estates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mutfak",
                table: "estates",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Balkon",
                table: "estates");

            migrationBuilder.DropColumn(
                name: "Mutfak",
                table: "estates");
        }
    }
}
