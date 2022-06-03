using Microsoft.EntityFrameworkCore.Migrations;

namespace OtobusBileti.Data.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    SehirId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SehirAd = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.SehirId);
                });

            migrationBuilder.CreateTable(
                name: "Yollar",
                columns: table => new
                {
                    YolId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nereden = table.Column<string>(type: "TEXT", nullable: true),
                    Nereye = table.Column<string>(type: "TEXT", nullable: true),
                    Tarih = table.Column<string>(type: "TEXT", nullable: true),
                    Saat = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yollar", x => x.YolId);
                });

            migrationBuilder.CreateTable(
                name: "Yolcular",
                columns: table => new
                {
                    YolcuId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Soyad = table.Column<string>(type: "TEXT", nullable: true),
                    Nereden = table.Column<string>(type: "TEXT", nullable: true),
                    Nereye = table.Column<string>(type: "TEXT", nullable: true),
                    KoltukNo = table.Column<int>(type: "INTEGER", nullable: false),
                    Fiyat = table.Column<int>(type: "INTEGER", nullable: false),
                    YolId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yolcular", x => x.YolcuId);
                    table.ForeignKey(
                        name: "FK_Yolcular_Yollar_YolId",
                        column: x => x.YolId,
                        principalTable: "Yollar",
                        principalColumn: "YolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Yolcular_YolId",
                table: "Yolcular",
                column: "YolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sehirler");

            migrationBuilder.DropTable(
                name: "Yolcular");

            migrationBuilder.DropTable(
                name: "Yollar");
        }
    }
}
