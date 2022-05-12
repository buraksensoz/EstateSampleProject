using Microsoft.EntityFrameworkCore.Migrations;

namespace AppStoreOne.DataAccess.Migrations
{
    public partial class CustomerBankDetail_18032022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Banka",
                table: "customers",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankaSube",
                table: "customers",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Iban",
                table: "customers",
                maxLength: 200,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Banka",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "BankaSube",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Iban",
                table: "customers");
        }
    }
}
