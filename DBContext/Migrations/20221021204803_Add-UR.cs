using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBContext.Migrations
{
    public partial class AddUR : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UR",
                table: "UnidadAdministrativa",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"),
                column: "UR",
                value: "222");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"),
                column: "UR",
                value: "636");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"),
                column: "UR",
                value: "632");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"),
                column: "UR",
                value: "413");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"),
                column: "UR",
                value: "206");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"),
                column: "UR",
                value: "737");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"),
                column: "UR",
                value: "238");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"),
                column: "UR",
                value: "628");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"),
                column: "UR",
                value: "220");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"),
                column: "UR",
                value: "204");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"),
                column: "UR",
                value: "205");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"),
                column: "UR",
                value: "101");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"),
                column: "UR",
                value: "635");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"),
                column: "UR",
                value: "311");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"),
                column: "UR",
                value: "427");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"),
                column: "UR",
                value: "621");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"),
                column: "UR",
                value: "634");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"),
                column: "UR",
                value: "224");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"),
                column: "UR",
                value: "630");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"),
                column: "UR",
                value: "633");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"),
                column: "UR",
                value: "631");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("96559f1b-3880-4339-9c73-fed0ec116105"),
                column: "UR",
                value: "219");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"),
                column: "UR",
                value: "225");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"),
                column: "UR",
                value: "626");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"),
                column: "UR",
                value: "307");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"),
                column: "UR",
                value: "509");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"),
                column: "UR",
                value: "614");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("d052658e-e743-478d-aa94-21f279ddde3d"),
                column: "UR",
                value: "202");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"),
                column: "UR",
                value: "217");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"),
                column: "UR",
                value: "612");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"),
                column: "UR",
                value: "223");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"),
                column: "UR",
                value: "203");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"),
                column: "UR",
                value: "629");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativa",
                keyColumn: "Id",
                keyValue: new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"),
                column: "UR",
                value: "639");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UR",
                table: "UnidadAdministrativa");
        }
    }
}
