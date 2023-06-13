using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Esquema.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adoptante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Persona = table.Column<int>(type: "int", nullable: false),
                    Id_Entrega = table.Column<int>(type: "int", nullable: false),
                    LugarEntrega = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptante", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePerson = table.Column<string>(type: "varchar(10)", nullable: true),
                    ApellidoPerson = table.Column<string>(type: "varchar(10)", nullable: true),
                    FechaPerson = table.Column<string>(type: "varchar(10)", nullable: true),
                    SexoPerson = table.Column<string>(type: "varchar(10)", nullable: true),
                    DireccionPerson = table.Column<string>(type: "varchar(10)", nullable: true),
                    estado = table.Column<string>(type: "varchar(10)", nullable: false),
                    AdoptanteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persona_Adoptante_AdoptanteID",
                        column: x => x.AdoptanteID,
                        principalTable: "Adoptante",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Persona_AdoptanteID",
                table: "Persona",
                column: "AdoptanteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Adoptante");
        }
    }
}
