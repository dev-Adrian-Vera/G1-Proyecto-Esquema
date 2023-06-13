using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto_Esquema.Migrations
{
    public partial class Person_V11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaEntrega",
                table: "Adoptante",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id_Mascota",
                table: "Adoptante",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaEntrega",
                table: "Adoptante");

            migrationBuilder.DropColumn(
                name: "Id_Mascota",
                table: "Adoptante");
        }
    }
}
