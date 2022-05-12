using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace AppStoreOne.DataAccess.Migrations
{
    public partial class initDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MusteriAdi = table.Column<string>(maxLength: 250, nullable: true),
                    Telefon = table.Column<string>(maxLength: 200, nullable: true),
                    Gsm = table.Column<string>(maxLength: 200, nullable: true),
                    Fax = table.Column<string>(maxLength: 200, nullable: true),
                    Adres1 = table.Column<string>(maxLength: 2000, nullable: true),
                    Adres2 = table.Column<string>(maxLength: 2000, nullable: true),
                    Eposta = table.Column<string>(maxLength: 200, nullable: true),
                    Web = table.Column<string>(maxLength: 200, nullable: true),
                    IdentityNo = table.Column<string>(maxLength: 200, nullable: true),
                    MusteriBilgi = table.Column<string>(maxLength: 5000, nullable: true),
                    MusteriTip = table.Column<int>(nullable: false, defaultValue: 1)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(maxLength: 200, nullable: true),
                    FullName = table.Column<string>(maxLength: 200, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 200, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: true),
                    AuthType = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "estates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Baslik = table.Column<string>(maxLength: 500, nullable: true),
                    Adres = table.Column<string>(maxLength: 2000, nullable: true),
                    SiteAdi = table.Column<string>(maxLength: 200, nullable: true),
                    Il = table.Column<string>(maxLength: 200, nullable: true),
                    Ilce = table.Column<string>(maxLength: 200, nullable: true),
                    Semt = table.Column<string>(maxLength: 200, nullable: true),
                    Blok = table.Column<string>(maxLength: 200, nullable: true),
                    Kat = table.Column<string>(maxLength: 200, nullable: true),
                    DaireNo = table.Column<string>(maxLength: 200, nullable: true),
                    Ada = table.Column<string>(maxLength: 200, nullable: true),
                    Pafta = table.Column<string>(maxLength: 200, nullable: true),
                    Parsel = table.Column<string>(maxLength: 200, nullable: true),
                    Bilgi = table.Column<string>(maxLength: 5000, nullable: true),
                    EmlakTipi = table.Column<int>(nullable: false, defaultValue: 1)
                        .Annotation("Sqlite:Autoincrement", true),
                    M2 = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("Sqlite:Autoincrement", true),
                    Oda = table.Column<int>(maxLength: 200, nullable: false),
                    Salon = table.Column<int>(maxLength: 200, nullable: false),
                    Banyo = table.Column<int>(maxLength: 200, nullable: false),
                    Fiyat = table.Column<double>(nullable: false),
                    Islem = table.Column<int>(nullable: false),
                    Durum = table.Column<int>(nullable: false, defaultValue: 0)
                        .Annotation("Sqlite:Autoincrement", true),
                    SahipId = table.Column<int>(nullable: false),
                    IslemTarih = table.Column<DateTime>(nullable: false),
                    SonlanmaTarih = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estates_customers_SahipId",
                        column: x => x.SahipId,
                        principalTable: "customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_estates_SahipId",
                table: "estates",
                column: "SahipId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "estates");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
