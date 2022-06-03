using Microsoft.EntityFrameworkCore.Migrations;

namespace OtobusBileti.Data.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fiyat",
                table: "Yollar",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Saat",
                table: "Yolcular",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tarih",
                table: "Yolcular",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Yollar");

            migrationBuilder.DropColumn(
                name: "Saat",
                table: "Yolcular");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Yolcular");
        }
    }
}
