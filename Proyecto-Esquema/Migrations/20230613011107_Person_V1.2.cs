using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Esquema.Migrations
{
    public partial class Person_V12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CedulaPerson",
                table: "Persona",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReferenciaAdoptante",
                table: "Adoptante",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CedulaPerson",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "ReferenciaAdoptante",
                table: "Adoptante");
        }
    }
}
