using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Esquema.Migrations
{
    public partial class Person_V13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApellidoPerson",
                table: "Persona");

            migrationBuilder.RenameColumn(
                name: "NombrePerson",
                table: "Persona",
                newName: "DatosPerson");

            migrationBuilder.AddColumn<int>(
                name: "Id_Operacion",
                table: "Adoptante",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id_Operacion",
                table: "Adoptante");

            migrationBuilder.RenameColumn(
                name: "DatosPerson",
                table: "Persona",
                newName: "NombrePerson");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoPerson",
                table: "Persona",
                type: "varchar(10)",
                nullable: true);
        }
    }
}
