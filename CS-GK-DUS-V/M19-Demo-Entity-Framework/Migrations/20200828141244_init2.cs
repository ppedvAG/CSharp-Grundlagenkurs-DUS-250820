using Microsoft.EntityFrameworkCore.Migrations;

namespace M19_Demo_Entity_Framework.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DieTransportmittel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    MaximalGeschwindigkeit = table.Column<uint>(nullable: false),
                    Preis = table.Column<double>(nullable: false),
                    AktuelleGeschwindigkeit = table.Column<uint>(nullable: false),
                    FZustand = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DieTransportmittel", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DieTransportmittel");
        }
    }
}
