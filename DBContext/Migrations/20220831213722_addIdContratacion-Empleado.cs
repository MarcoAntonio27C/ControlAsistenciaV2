using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBContext.Migrations
{
    public partial class addIdContratacionEmpleado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "IdContratacion",
                table: "Empleado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Contratacion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contratacion", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contratacion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("4b7d03f3-ef7d-4e42-ad73-f520c6d65edd"), "ASIMILADOS" },
                    { new Guid("499c6384-159a-49b1-bb24-36f13ae9fb10"), "BASE" },
                    { new Guid("0fb4c79b-8dfd-468a-9e42-98fd742383ff"), "CONFIANZA" },
                    { new Guid("17805612-54b0-43ef-9860-6964ba543617"), "HONORARIOS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contratacion");

            migrationBuilder.DropColumn(
                name: "IdContratacion",
                table: "Empleado");
        }
    }
}
