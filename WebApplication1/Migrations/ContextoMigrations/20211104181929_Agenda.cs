using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations.ContextoMigrations
{
    public partial class Agenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HORARIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CLIENTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SUPORTE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LOCAL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHECKIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CHECKOUT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DISTKM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");
        }
    }
}
