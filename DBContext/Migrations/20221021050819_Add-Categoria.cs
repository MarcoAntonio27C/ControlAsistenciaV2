using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBContext.Migrations
{
    public partial class AddCategoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("0524769e-c144-4772-a050-811e7d2b68ce"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("061bc395-9e04-40d9-824c-0c740f63af15"));

            migrationBuilder.DeleteData(
                table: "Usuario",
                keyColumn: "Id",
                keyValue: new Guid("67bb4459-8401-4b49-8ac8-67d3219fbfc8"));

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdCategoria",
                table: "Empleado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Empleado",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3af153fd-fe52-4fdb-8e8f-494f4df51752"), "OFICIAL M", "G0003" },
                    { new Guid("7a2ae1c5-a1ea-4639-a813-5b423642388f"), "ASESOR TECNICO", "Q11C3" },
                    { new Guid("3463e60f-7b48-4d37-9656-7cc6a26f098b"), "COORDINADOR DE MEDIOS ALTERNATIVOS", "R12C3" },
                    { new Guid("994a0ed5-4eee-4d10-9459-59c43455b5b0"), "SUBDIRECTOR", "R12D4" },
                    { new Guid("81070038-3f51-450d-bb21-9b0a7bde8ff5"), "AGENTE DEL MINISTERIO PUBLICO", "R13A1" },
                    { new Guid("7c67824a-890a-4749-90de-cfbcccee02f6"), "FISCAL INVESTIGADOR", "R13A4" },
                    { new Guid("672e609a-7c35-4746-b362-eda8862f2198"), "COMANDANTE MINISTERIAL", "R14A1" },
                    { new Guid("afcc3719-7d77-462d-b811-8fde6ca6ffde"), "INSPECTOR GENERAL", "R16A1" },
                    { new Guid("88c28bb3-eb4c-4de3-bd94-07f6b7f548d1"), "JEFE DE GRUPO MINISTERIAL", "S18B2" },
                    { new Guid("60fd3fb1-8546-4446-968c-804c54bd1dc8"), "JEFE DE DEPARTAMENTO", "S20A1" },
                    { new Guid("da8a0b96-e23c-464d-b09d-c2f9c55cafb0"), "OFICIAL MINISTERIAL", "T21C1" },
                    { new Guid("6644b65a-7b20-428f-9f4e-054cc8fdef8a"), "AGENTE INVESTIGADOR", "T21C3" },
                    { new Guid("96dc08e2-a9a9-4809-829d-13a42bafcc42"), "PERITO JEFE", "T22A2" },
                    { new Guid("b4c2c672-e8a4-4bd3-b65b-8eae657dc765"), "PERITO SUPERIOR", "T23A2" },
                    { new Guid("6d9c83c1-20c8-4a49-9a04-bd8d6ba5c1e0"), "PERITO ESPECIALIZADO", "T23B1" },
                    { new Guid("5e5504f6-8688-4ff1-b6e1-46ab08d5f21e"), "PERITO TECNICO", "T24A2" },
                    { new Guid("cc60dd4d-29b3-442d-9d63-d8356f9aa333"), "FACILITADOR", "T25A2" },
                    { new Guid("ad961859-cc43-4901-a820-81c5f77283b0"), "AUXILIAR FACILITADOR", "T26A1" },
                    { new Guid("a713a84f-5b5a-4a3a-98f7-043d054d507b"), "INVITADOR", "T27A1" },
                    { new Guid("c5ad47f8-a385-4762-8d6c-18dfb69d8fa5"), "AUXILIAR DEL MINISTERIO PUBLICO", "T28C3" },
                    { new Guid("1e15c6ca-7cdf-46ee-a390-cf4c2eeeb36e"), "OFICIAL DEL MINISTERIO PUBLICO", "T29A1" },
                    { new Guid("3974fee6-7964-443a-b5a0-5853047b7731"), "ANALISTA INVESTIGADOR", "U30A4" },
                    { new Guid("f1e3746f-a8ab-4c8d-9596-10b3a3fb6ed3"), "VISITADOR", "Q10D4" },
                    { new Guid("efb112b6-40e9-470b-9b2b-dade1a3205ea"), "ANALISTA", "U30C3" },
                    { new Guid("d3d7f48b-3ac9-45b1-8abf-d3b5c1b6f978"), "ASESOR ESPECIAL", "Q09A1" },
                    { new Guid("baf11cee-b98d-403f-82fe-3133353c5eaf"), "FISCAL ", "P06B2" },
                    { new Guid("b072f69c-913e-4f29-b6b8-fec68c0548e0"), "OFICIAL R", "G0020" },
                    { new Guid("938b12b1-0d36-4676-ac48-ecb8ffea54f7"), "AGENTE DEL MINISTERIO PUBLICO", "G0905" },
                    { new Guid("3faf5fe9-74d6-4254-938c-860fe5d6ecc6"), "OFICIAL I", "G0907" },
                    { new Guid("cc1a9117-feea-485c-a9d2-7c9887e1bb3f"), "OFICIAL E", "G0911" },
                    { new Guid("fe7271b2-cb0e-46f5-a742-16e3e4fc5926"), "OFICIAL A", "G1301" },
                    { new Guid("b789a7eb-9e69-4105-bbea-be0531ada765"), "AGENTE MINISTERIAL", "G1601" },
                    { new Guid("b75eeeea-94b0-412b-b290-90bc5f565518"), "HONORARIOS", "H3001" },
                    { new Guid("d538ee39-7911-4722-aad7-67047ef095f6"), "FISCAL GENERAL", "M01A1" },
                    { new Guid("a4f89176-b60b-4b8a-a292-1ef98b3f288c"), "FISCAL ESPECIAL O REGIONAL", "N02A1" },
                    { new Guid("c0f55aec-b749-4aa6-85be-a7b206074f89"), "OFICIAL MAYOR", "N03A1" },
                    { new Guid("d706b04f-41e4-4cd4-9c94-ad9cc0c1f47a"), "JEFE DE LA OFICINA DEL FISCAL GENERAL", "N03B2" },
                    { new Guid("3089d436-6c78-4178-b2e0-0e04e316c538"), "TITULAR DE LA AGENCIA ESTATAL DE INVESTIGACION", "O03A1" },
                    { new Guid("92d0bb9f-8db1-4b18-8a2b-0841169fad5d"), "TITULAR DEL INSTITUTO DE CIENCIAS FORENSES", "O03A2" },
                    { new Guid("f5ffbd42-3523-4f50-a9ac-88a110872e2d"), "TITULAR DEL ORGANO INTERNO DE CONTROL", "O03A3" },
                    { new Guid("64adafa4-9440-473e-8b8f-c9ab1e97035e"), "TITULAR DE LA VISITADURIA GENERAL", "O03A4" },
                    { new Guid("4159806c-af91-4b2d-ada6-b0274036431e"), "TITULAR DEL INSTITUTO DE FORMACION PROFESIONAL", "O03A5" }
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Descripcion", "Nombre" },
                values: new object[,]
                {
                    { new Guid("868361a4-d6b8-4b49-8cc2-b1ad373a43ea"), "COORDINADOR GENERAL", "O04A1" },
                    { new Guid("15e40268-c5ec-4b11-acae-cf743fb4e6c2"), "DIRECTOR DE AREA", "O04C3" },
                    { new Guid("c37f714f-d746-4bd3-9a65-4727a129209f"), "COORDINADOR", "P004A5" },
                    { new Guid("0eb6dc3e-500a-450e-a799-9a560723dc0b"), "COORDINADOR", "P04A5" },
                    { new Guid("f4cfe54d-60aa-4853-96c3-002fa5380098"), "TITULAR DE UNIDAD", "P06A1" },
                    { new Guid("6d1258c0-13bd-4254-9574-94735a902766"), "DIRECTOR DE AREA", "P06C3" },
                    { new Guid("1046ec42-4fe0-47f7-b3dc-29987941ff5d"), "AUXILIAR", "V31C4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "IdCategoria",
                table: "Empleado");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Empleado");

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Activo", "Administrador", "IdRol", "IdUnidadAdministrativa", "NombreUsuario", "Password" },
                values: new object[] { new Guid("061bc395-9e04-40d9-824c-0c740f63af15"), true, null, "9a39bcce-b092-4f90-9de7-9e0fb2137034", "", "oficialiaMayor", "oficialiaMayor" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Activo", "Administrador", "IdRol", "IdUnidadAdministrativa", "NombreUsuario", "Password" },
                values: new object[] { new Guid("67bb4459-8401-4b49-8ac8-67d3219fbfc8"), true, null, "592d923a-9d0b-424c-8bc3-0c42ff72495e", "0e3aa015-4581-4c88-a8c9-679dd80b0d13", "cgesi", "cgesi" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Activo", "Administrador", "IdRol", "IdUnidadAdministrativa", "NombreUsuario", "Password" },
                values: new object[] { new Guid("0524769e-c144-4772-a050-811e7d2b68ce"), true, null, "a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7", "", "visitaduria", "visitaduria" });
        }
    }
}
