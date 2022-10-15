using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBContext.Migrations
{
    public partial class addHoraAsistencia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<TimeSpan>(
                name: "Hora",
                table: "Asistencia",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Asistencia");
        }
    }
}
