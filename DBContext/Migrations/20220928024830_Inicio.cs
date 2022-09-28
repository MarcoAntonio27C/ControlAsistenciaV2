using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DBContext.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Asistencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asistencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargoHomologado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoHomologado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CentroTrabajo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroTrabajo", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NombreCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroExpediente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huella = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IdMunicipio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInmueble = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCargoHomologado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCentroTrabajo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadAdministrativa = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdContratacion = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Incidencia",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdEmpleado = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inmueble",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdMunicipio = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmueble", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadAdministrativa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadAdministrativa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdUnidadAdministrativa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IdRol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0070bd8e-273e-482e-ba58-dad454c62ed0"), "AGENTE DEL MINISTERIO PUBLICO" },
                    { new Guid("df2ddadb-d63b-46e9-be76-64138fee6faa"), "JEFE DE DEPARTAMENTO" },
                    { new Guid("ebd7e347-d65f-4343-bcd2-529402ebda61"), "JEFE DE DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" },
                    { new Guid("32060da9-0901-4f9b-a806-e2e8ae303de0"), "JEFE DE DEPARTAMENTO DE INDICIOS Y BIENES AFECTOS" },
                    { new Guid("6eee3b50-837f-41ed-91c1-2dd785e258a7"), "JEFE DE DEPARTAMENTO DE INFORMACION VEHICULAR DE LA DIRECCION DE INVESTIGACION" },
                    { new Guid("21dfd6f3-d8ff-4669-93b5-97524466e877"), "JEFE DE GRUPO MINISTERIAL" },
                    { new Guid("e3454200-4671-485f-9e08-719787d0bae5"), "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE ATLIXCO)" },
                    { new Guid("cd69558f-e281-481e-8902-583a4efaf591"), "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE TEPEACA)" },
                    { new Guid("6e78e0e5-61ba-4953-ae0e-5fc49c672ca4"), "JEFE DE GRUPO MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("285c591d-db0a-4bba-b459-acecb86e1d26"), "JEFE DEL DEPARTAMENTO DE APOYO TECNICO" },
                    { new Guid("82820c08-7c24-4137-b373-8d84d63595cd"), "JEFE DEL DEPARTAMENTO DE CONTROL VEHICULAR" },
                    { new Guid("ca6afe02-552c-43d1-b6ca-1b2bc70079ed"), "JEFE DEL DEPARTAMENTO DE DISEÑO E IMAGEN INSTITUCIONAL" },
                    { new Guid("b525b311-4f98-40ce-bd58-b3dbcc07870f"), "JEFE DEL DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANA" },
                    { new Guid("28e741e9-acb6-41c7-82b7-cbb37e56e81d"), "JEFA DEL DEPARTAMENTO DE PROCEDIMIENTOS PARA EL DESTINO FINAL DE BIENES ASEGURADOS" },
                    { new Guid("e60a3b7b-a373-4d8a-9b2c-9af59d76b058"), "JEFE DEL DEPARTAMENTO JURIDICO DE MANUALES ADMINISTRATIVOS" },
                    { new Guid("380902ed-7f02-4aa1-b3f7-4da126758cce"), "OFICIAL E" },
                    { new Guid("4d470068-0992-49da-bd6d-889ea7d81d16"), "OFICIAL I" },
                    { new Guid("0ff23130-66e4-4b73-be4b-7b48972f6b57"), "OFICIAL M" },
                    { new Guid("1fd19c0d-6e4b-420f-8c3f-e26bb42b0b58"), "OFICIAL R" },
                    { new Guid("d60baaba-9899-4373-9dd2-8b57c27dc920"), "OFICIAL DEL MINISTERIO PUBLICO" },
                    { new Guid("052188e8-a6a7-419f-add5-87c37956cac2"), "OFICIAL MAYOR" },
                    { new Guid("1f1806ae-43da-487f-a288-3d1d63768d9a"), "PERITA" },
                    { new Guid("b4fcbc88-6ff4-4daf-950a-2938709cf976"), "PERITO" },
                    { new Guid("456acc8a-4935-4ca5-b17e-5fb4c6bfd73c"), "RESPONSABLE DEL AREA DE LO CONTENCIOSO DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("97e54f09-f4cc-4a27-a4f6-52be1e8f47cf"), "SUBDIRECTOR" },
                    { new Guid("3121524c-99f0-487f-88b0-6621887839b6"), "SUBDIRECTOR ACADEMICO" },
                    { new Guid("48803d8f-164c-44e9-ab09-c951671031c9"), "SUBDIRECTOR DE APOYO TECNICO OPERATIVO" },
                    { new Guid("a395f422-70e7-48c9-b13c-16de0d55bf2e"), "OFICIAL A" },
                    { new Guid("31b06268-ca1c-4775-b724-59ed79ce4370"), "JEFA DEL DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA DE LA DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO DE LA OFICIALIA MAYOR" },
                    { new Guid("64137a6c-dc7c-49a6-b9e2-cca1f2aa7321"), "JEFA DEL DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" },
                    { new Guid("01782ed3-28f0-4164-ad85-0b550ffd680f"), "JEFA DEL DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" },
                    { new Guid("98816d58-bc4f-4cf2-8174-af6ec4fe2536"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("b48943c1-2b9d-4e41-ba76-45102bb26f70"), "FACILITADOR" },
                    { new Guid("ead0ca7f-3539-485b-858f-1f94ba8b425e"), "FACILITADORA" },
                    { new Guid("9d56c9bb-8cfb-46c9-a280-2aa3e6caa645"), "FISCAL DE INVESTIGACION METROPOLITANA" },
                    { new Guid("ddd429ca-cc9f-4276-963b-325e9bee0d98"), "FISCAL DE INVESTIGACION REGIONAL" },
                    { new Guid("8bfdee00-f911-4db6-a5b5-edf39287442c"), "FISCAL DE ZONA PONIENTE" },
                    { new Guid("9fd390b9-193e-47e8-9e38-89d02207d692"), "FISCAL DE ZONA SUR DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("6d654e8f-092a-42ad-aae7-e943449a0943"), "FISCAL ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES,COORDINADORA DE INVESTIGACION" },
                    { new Guid("276b7d3e-97e7-446c-9e88-8a7654539d21"), "FISCAL ESPECIALIZADO DE ASUNTOS INTERNOS" },
                    { new Guid("918581f8-a433-44c4-886c-3b2ebc0af1ce"), "FISCAL ESPECIALIZADO DE COMBATE A LA CORRUPCION" },
                    { new Guid("10f6f8b8-d335-4443-b45e-3e59d18e1e6e"), "FISCAL ESPECIALIZADO EN DERECHOS HUMANOS" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("93dc515d-8be6-4cba-a462-5d6c21d8d36e"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("d6733ae1-e755-4d61-bb38-7ec6b5a4e54c"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PRECEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("d245a596-e535-441a-970f-58e9885e4f55"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("c7db04e6-ae2e-4d0c-9d34-f65cfd37a4e8"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("ca3992c2-4746-4dbf-9aed-aeb1c5569442"), "FISCAL GENERAL DEL ESTADO" },
                    { new Guid("90842e57-8a55-48df-b6e7-1d9c3af1864f"), "HONORARIOS" },
                    { new Guid("61157e2b-62ff-4333-bb64-0f345589f6e1"), "INSPECTOR GENERAL" },
                    { new Guid("870473bb-6d02-4b28-b0c9-5cdd1d248a8e"), "INVITADOR" },
                    { new Guid("c823b122-b8f5-42ba-9414-566d87efd431"), "JEFA DE DEPARTAMENTO" },
                    { new Guid("e8352fcb-3957-4935-a616-21ac7e7d4e26"), "JEFA DE DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("6a6d65ea-807d-4587-bfe4-7e42fb8fdcbf"), "JEFA DEL DEPARTAMENTO DE APOYO TECNICO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("24dd5f75-2153-439d-805b-97a2c639a7cc"), "JEFA DEL DEPARTAMENTO DE CONTROL DE INMUEBLES" },
                    { new Guid("2bd9c244-7ecb-4c51-959f-56d1740df1e5"), "JEFA DEL DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" },
                    { new Guid("a956c63c-9ae7-44d4-9e65-f4c9c13be14f"), "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE INVERSION Y BANCO DE PROYECTOS" },
                    { new Guid("b6d5e045-89f9-4efa-be83-6da998c7a288"), "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE PERSONAL DE LA SUBDIRECCION DE SERVICIOS PERSONALES DE LA DIRECCION DE ADMINISTRACION DE LA OFICIALIA MAYOR" },
                    { new Guid("ac0670ef-5e56-4169-b8c3-52946735a52c"), "JEFA DEL DEPARTAMENTO DE GESTION DOCUMENTAL DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("5c2ec8c9-366f-4b4b-af00-ff1ba9a4a5c3"), "SUBDIRECTOR DE CONTABILIDAD" },
                    { new Guid("ce046471-3379-4623-a332-b0edcfb8436c"), "SUBDIRECTOR DE CONTROL Y SEGUIMIENTO DOCUMENTAL" },
                    { new Guid("78b8c0b7-cfb5-44c7-9ec7-0a0d4815dd38"), "SUBDIRECTOR DE PROFESIONALIZACION" },
                    { new Guid("5498bc88-668b-4fb2-ad4e-0778b1a81da5"), "SUBDIRECTOR DE REDES DE LA DIRECCION DE INFRAESTRUCTURA TECNOLOGICA DE LA COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("30840112-1f1b-45aa-9cb0-14e6c6144f31"), "TITULAR DE LA UNIDAD DE LOCALIZACION DE PERSONAS DESAPARECIDAS" },
                    { new Guid("1e9cd6c8-6b3d-4866-999a-9cda4f0bbec3"), "TITULAR DE LA UNIDAD DE SITUACION PATRIMONIAL DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("9ed31933-8313-4748-a176-dafaceb9cd7b"), "TITULAR DE LA UNIDAD DE SUSTANCIACION DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("2ceae80a-4917-4f95-844f-a13384f95b7c"), "TITULAR DE LA UNIDAD DE TRANSPARENCIA" },
                    { new Guid("6cb860f2-6b9e-445c-b3a6-1e0583c21f26"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS AMBIENTALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("b1f2683b-c7cd-42a6-b431-b24f7c368a0f"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("9e1290b8-ad9d-4700-ae38-26fb98365e81"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("7d7ee08f-65c3-46f5-ac58-9b4912e7a058"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("2e38b98f-f066-452b-b715-c2dd21faacc5"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("291dc9a8-a8ab-4da2-85b4-8be00e6aed74"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("65229047-cce6-4e06-b140-5cb2223d4a67"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DEL DELITO DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("03bd1358-2376-4ba3-85fc-88465942d49b"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("d9029a11-8352-495b-9a2e-22348f14ab47"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" },
                    { new Guid("496db39d-1c1b-4a32-998b-44c0fce2c6d2"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("dfa352cc-fbe7-401e-90ec-99bc38dacc5f"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" },
                    { new Guid("9c55b6d8-cc86-411b-9cdb-38c132a26f83"), "TITULAR DE LA UNIDAD RESOLUTORA DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("bd136a8f-3879-4e2d-bd48-1c4a6b9dd56c"), "TITULAR DE LA UNIDAD UNIDAD PARA LA BUSQUEDA DE MUJERES Y NIÑAS DESAPARECIDAS Y DELITOS RELACIONADOS A TRAVES DE LA APLICACION DEL PROTOCOLO ALBA Y LA COORDINACION CON LA ALERTA AMBER DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("9040e2fd-f60e-4800-85ef-26018a14c24c"), "TITULAR DE UNIDAD" },
                    { new Guid("0bd53293-b95d-4276-b09b-8628b75c6980"), "TITULAR DE UNIDAD DE APOYO ADMINISTRATIVO" },
                    { new Guid("8e2b4ed0-fc42-4c2e-a528-85b70589743b"), "TITULAR DE UNIDAD ESPECIALIZADA DE INVESTIGACION DE ASUNTOS INDIGENAS" },
                    { new Guid("0dcdc1f9-77bd-43c7-89b3-29c91ae6eb42"), "TITULAR DEL DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("d388f315-0de9-40af-9f45-913df7598958"), "TITULAR DEL INSTITUTO DE CIENCIAS FORENSES" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("ed744b86-b5a7-4571-b526-002bcb325c40"), "TITULAR DEL INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("0d82b2c1-ac48-463c-bb28-e84e2476af9d"), "TITULAR DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("c18ec14d-45ec-426a-8a45-0e364b290909"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN ROBO A CASA HABITACION Y ROBO A COMERCIO" },
                    { new Guid("4aecf7ca-1011-4961-b71d-cbffdbb07d97"), "VISITADOR GENERAL" },
                    { new Guid("027113b2-4d5b-408a-aaa3-7827f22cf95a"), "VISITADORA" },
                    { new Guid("8d95c0af-5d98-4c66-96be-d221830c93f5"), "TITULAR DE LA UNIDAD DE INVESTIGCION DE PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" },
                    { new Guid("e2f39ac3-1c3c-4862-916d-0a3dd027b5aa"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("822d6ff9-b313-40e4-bac5-d41c9daf1b09"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN VIOLENCIA FAMILIAR Y DELITOS DE GENERO" },
                    { new Guid("500d4da6-623e-4dd9-ac80-c5b898c83268"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN DELITOS FINANCIEROS Y PATRIMONIALES" },
                    { new Guid("bda8ef33-c931-4ca0-9ecd-0a16f2d83a54"), "SUBDIRECTOR DE SUMINISTROS" },
                    { new Guid("0290a5d1-7455-413f-9648-e24975957ae2"), "SUBDIRECTOR DE TESORERIA DE LA DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL" },
                    { new Guid("0306cea5-19d3-47db-8db5-2de93aad5ace"), "SUBDIRECTORA DE CONTROL DE GESTION DE LA DIRECCION DE AUDITORIA DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("ce5e87b4-70d0-43f9-b09b-383e8e8d928b"), "SUBDIRECTORA DE FONDOS Y POLITICA PRESUPUESTAL" },
                    { new Guid("e51f1854-2b21-4dac-89c8-6276f8b6c078"), "SUBDIRECTORA DE GLOSA DE GASTO CORRIENTE E INVERSION" },
                    { new Guid("62b3f997-87a0-479a-8f9e-f22f5580c1b6"), "SUBDIRECTORA DE LA DELEGACION TEHUACAN" },
                    { new Guid("4e58d707-6fb6-4166-9636-180c55bf49eb"), "SUBDIRECTORA DE RECEPCION Y DESPACHO DOCUMENTAL" },
                    { new Guid("2fc77250-e06d-4bd6-991b-5461f1b7e3d7"), "SUBDIRECTORA DE SERVICIO CIVIL DE CARRERA" },
                    { new Guid("46e8b6c7-49a3-48bd-bcee-500e6e0168bf"), "SUBDIRECTORA DE SERVICIOS PERSONALES" },
                    { new Guid("485facc9-a615-4fd8-ab5a-7ef0f436b919"), "SUBDIRECTORA DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("53b3536b-0784-4182-a281-8321b6918d53"), "TITULAR DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("a5d129ea-6a6d-4a7f-97f7-e13b079d5d07"), "TITULAR DE LA DIRECCION METROPOLITANA DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("b37f5e86-e8a8-4c1b-a5a2-d04af49ce6de"), "TITULAR DE LA DIRECCION REGIONAL DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("0782de9d-c073-4803-8942-e46159000dbb"), "TITULAR DE LA OFICINA DEL FISCAL GENERAL DEL ESTADO" },
                    { new Guid("2a18bd1a-b839-4652-bd9f-bad89e05e988"), "TITULAR DE LA UNIDAD" },
                    { new Guid("08047d22-6343-4f95-abdc-3aae79b52af8"), "TITULAR DE LA UNIDAD COORDINADORA DE ARCHIVOS DE LA COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("4460bebc-8654-4216-a6b6-6c8627fe0627"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("46f5e15a-1ced-4567-b97b-a84e4382ed83"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("dfb8e870-5acc-4749-ae70-57b456c5daf7"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("d705f76d-90ec-4a3a-84ef-fdfd7b52a29b"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("11643076-3e15-43d0-b216-d7b461a4ca92"), "TITULAR DE LA UNIDAD DE DERECHOS HUMANOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("9bb09f9b-874d-462e-aff6-25671d04ab2f"), "TITULAR DE LA UNIDAD DE FLAGRANCIA" },
                    { new Guid("dca41a55-dc74-49df-83ee-e4fdb0b5b39a"), "TITULAR DE LA UNIDAD DE FLAGRANCIA CENTRAL I" },
                    { new Guid("45f24575-73af-47d7-92b2-58b708742fe3"), "TITULAR DE LA UNIDAD DE INVESTIGACION DE DELITOS RELACIONADOS CON PERSONAS DESAPARECIDAS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("e7185ab4-a0ec-4289-a95e-21957fd8a766"), "TITULAR DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("92cfdd0d-8da6-4ab4-84f5-61782b992156"), "TITULAR DE LA UNIDAD DE INVESTIGACION DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("b82bd3c2-c76f-4d61-b86f-98e18819428d"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE SISTEMA TRADICIONAL" },
                    { new Guid("18019a21-b0da-4685-a0a2-1feac8a515c7"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN FEMINICIDIO" },
                    { new Guid("54f5889c-c2b5-4ba0-85d6-670907587424"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("ddfe691f-cd4f-4c0d-a4b4-c12a0a85b205"), "SUBDIRECTOR DE VEHICULOS Y BANCO DE ARMAS" },
                    { new Guid("ea0358fd-3bf9-468a-9c40-fed29b6a0a46"), "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("dfc96b48-a154-4a08-8213-2658eef3e96c"), "COMANDANTE, ENCARGADO DE DESPACHO DE LA DIRECCION DE INVESTIGACION DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("6665ebee-e71f-485d-8251-e447ef224abc"), "COORDINADOR DE ANALISIS ESTADISTICA Y BASE DE DATOS" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("b332cb30-abdf-440a-8efb-24e4a4b77896"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("d8bb12be-0974-49db-9dce-827cb66bccfd"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("725d14e4-876e-4f37-9779-d5d64d4ca93e"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("071353a3-9f6b-4591-96e6-412f15f79d48"), "COORDINADOR DE LITIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("a8f1ed31-fd28-4fd2-a7cd-273d85886d09"), "COORDINADOR DE LITIGACION DE LA FISCALIA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("6c8171b0-f67f-47c8-a4b7-15f4a4629327"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("dbd98461-4c45-4120-ab34-f78c5313a1e5"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("5688f90e-ce99-44e0-9ac3-ee0509ede08a"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("dd325753-82a7-4c72-916a-6ea0c92b9a15"), "COORDINADOR DE MEDIOS ALTERNATIVOS" },
                    { new Guid("2291c543-8c82-447c-a7c7-fae50247c89c"), "COORDINADOR GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("93f2b8c9-3073-4fd7-8796-0dd665b9301c"), "COMANDANTE MINISTERIAL, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("2409c6c1-4f7f-4bb9-b72c-cb3a8a8efc73"), "COORDINADOR GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("49338ddc-384b-481f-935a-47ce983cf22a"), "COORDINADOR GENERAL DE INVESTIGACION" },
                    { new Guid("885a5602-b843-4794-8a7a-afdff1fa970f"), "COORDINADOR GENERAL DE LITIGACION" },
                    { new Guid("895c6014-88aa-485f-b8d8-fbd4ff34c8aa"), "COORDINADOR GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("1dce6d2e-61e8-4334-8b5e-f82769944e29"), "COORDINADOR GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("7d7a8c16-988a-4e5e-b306-2adf54f2e8ea"), "COORDINADOR INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("3ab0ec29-af41-49a8-bf9e-8afca8266292"), "COORDINADOR(A) DE MEDIOS ALTERNATIVOS" },
                    { new Guid("111547b2-aa68-477d-8306-d5c9f6254b38"), "COORDINADORA DE INVESTIGACION" },
                    { new Guid("8a52bf74-9179-4009-95df-07bab161265c"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("a3d334ff-ed97-4cef-8b8d-999e6948af86"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN ASUNTOS INTERNOS" },
                    { new Guid("aad6bfe6-3535-49c5-80a7-d150815faa78"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("6076621e-f01f-4781-bbd0-992912cfa726"), "COORDINADORA DE INVESTIGACION, ENCARGADA DEL DESPACHO DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("1396df65-89d9-47ca-b18c-a74e4ca4ae72"), "COORDINADORA DE LITIGACION" },
                    { new Guid("f935aae2-e6a2-45af-b70b-b521962902b2"), "COORDINADOR GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("412168cb-ccdb-4e88-9286-2c2f78965b8f"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPCHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("83392577-2007-4284-aa06-45957057c044"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("72e9bdaf-beb7-485a-b0f6-971f22f01e06"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("2dfa61ea-07d3-4a8b-9611-99fe55c0ab99"), "AGENTE INVESTIGADOR" },
                    { new Guid("7b9cf555-11b6-4845-a0a8-df5a29d95126"), "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE SAN PEDRO CHOLULA)" },
                    { new Guid("b06cb8b4-8bc1-45a1-b86d-41473cf6688d"), "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE TEHUACAN)" },
                    { new Guid("7e5e7c1d-7459-4276-9f02-d99fd168336f"), "AGENTE INVESTIGADOR (ENCARGADO DE APOYO POLICIAL DE SAN ANDRES CHOLULA)" },
                    { new Guid("0161d43a-7d62-472c-a5d0-3f055a488f7f"), "AGENTE INVESTIGADOR (ENCARGADO DEL DESPACHO DE LA DIRECCION DE INTERVENCION INMEDIATA)" },
                    { new Guid("b09afe95-d2de-4104-a815-6c78bc7cd1a0"), "AGENTE INVESTIGADOR, ENCARGADA DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("14edc03e-4a2e-410a-8a12-9c8ff640d867"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("9a80f557-ba9f-4ad2-a456-a53802cf17e5"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("0d99aa00-cf91-4cb2-a701-bc3455fa77a9"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("75ecb94f-7149-4a47-8931-ee2c49090c0b"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("d6f3c297-b370-414c-803f-055025c1c488"), "AGENTE INVESTIGADOR, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("f8388d92-85f7-43eb-a462-257b2d890e78"), "AGENTE INVESTIGADOR(ENCARGADO DE APOYO POLICIAL DE CUAUTLANCINGO)" },
                    { new Guid("f7fab008-4e2f-4e8a-a20e-8a27d903a2f3"), "AGENTE MINISTERIAL" },
                    { new Guid("25a62b05-6421-4d95-a435-28e497533511"), "ANALISTA" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("a2d68287-1bc4-4178-ab5b-de07a224de26"), "ANALISTA DE INFORMACION" },
                    { new Guid("f91c3b41-4d7f-48d5-bd20-c50c0867e5e1"), "ASESOR ESPECIAL" },
                    { new Guid("f4f25387-f174-44b9-ae54-0b030d76b0d6"), "ASESOR TECNICO" },
                    { new Guid("8bdac60a-ff6e-4b70-a0f4-8895af55193e"), "ASESOR TECNICO, RESPONSABLE DEL AREA NORMATIVA DE LA DIRECCION CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("2c81d8b8-bc36-4f66-8715-c4f0b837ab38"), "ASIMILADOS" },
                    { new Guid("89dd5903-519c-41a4-bcfd-74307ed570a6"), "AUXILIAR" },
                    { new Guid("19ff0041-090c-4d11-b3c5-8c2a2223824d"), "AUXILIAR DE FACILITADOR" },
                    { new Guid("cbe20f4b-fab6-474a-a954-7686a2480b95"), "AUXILIAR DEL MINISTERIO PUBLICO" },
                    { new Guid("ae6ead9f-afc2-4cbf-9556-3900429df479"), "COMANDANTE MINISTERIAL" },
                    { new Guid("c9c91b86-c554-49bc-b959-a2a2246aba54"), "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE AMOZOC)" },
                    { new Guid("acbde854-da5a-442c-8f1b-01bf1852cea7"), "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE SAN MARTIN TEXMELUCAN)" },
                    { new Guid("12d2bc61-d63a-443c-9361-24ca0bb02aa2"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("6fae3a0c-98d5-40c5-98c3-3ca2f216dedc"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("e45511e5-58cd-40ea-8ef7-2d35affbd238"), "COORDINADORA DE LITIGACION DE LA FISCALIA DE INVESTIGACION METROPOLINATA" },
                    { new Guid("ac0aeb48-b323-4d4c-8290-f4a8b04b615d"), "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("e1d5f446-dd52-4d26-a629-4a298abfda54"), "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("a73cd09c-cdd2-4cde-bfa4-565d6a49b529"), "COORDINADORA GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("0e57d3be-bc37-446d-9248-4320c0e5dfca"), "DIRECTORA DE RESPONSABILIDADES" },
                    { new Guid("d85ba0ed-edd5-42ff-936f-d835ce6ae4f0"), "DIRECTORA DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL DE LA COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("71d00ff5-5e5b-4f29-8c77-e25b582dc15b"), "DIRECTORA DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("0ffe6709-ee56-4d5c-843a-cc19263b5efd"), "DIRECTORA DE SUPERVISION TECNICA DE LA VISITADURIA GENERAL" },
                    { new Guid("74001d2c-5dcc-4b29-8dd1-8aeafd9b6265"), "DIRECTORA GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" },
                    { new Guid("cbbb8146-1790-423e-8813-3e0447e172b6"), "DIRECTORA REGIONAL DE INVESTIGACION DE LA COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("541eeceb-0932-454d-b5a0-b74591728811"), "ENCARGADA DE DESPACHO DE LA DIRECCION DE PLANEACION, PROGRAMACION, EVALUACION Y ORGANIZACION" },
                    { new Guid("8785ba2d-226d-4b81-9a9e-efad260d2a00"), "ENCARGADA DE DESPACHO DE LA DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" },
                    { new Guid("f0311264-64ed-4c8e-8ad1-c7104101ec1b"), "ENCARGADA DE DESPACHO DE LA SUBDIRECCION DE PROYECTOS DE INVERSION Y BIENES MUEBLES E INMUEBLES" },
                    { new Guid("5920f2b9-5f39-4a47-9d0c-337ad8d30ff6"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION (TEZIUTLAN)" },
                    { new Guid("192c3dd5-e38a-42e0-b83a-4cd10fc8d355"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("67ccc547-c37b-40ca-9159-f009b59a4fa3"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE SERVICIOS PERICIALES" },
                    { new Guid("7ccebe82-0e00-4ce8-9f0b-4fc2ef284abe"), "ENCARGADO DE DESPACHO DE DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" },
                    { new Guid("9770f442-9b5a-45a1-a1a0-230fc22c1f1a"), "DIRECTORA DE PROFESIONALIZACION" },
                    { new Guid("4485aef5-3b70-445f-8fda-f4fe6c85e395"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE FLAGRANCIA (HUAUCHINANGO)" },
                    { new Guid("aefb3e89-b4c5-411b-901f-e6f4b57cc949"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN TRATA DE PERSONAS" },
                    { new Guid("5b767e62-aa3d-4174-8d47-7f19b2d66aef"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA DE COMBATE AL SECUESTRO" },
                    { new Guid("6fb54663-31bc-4acb-89f2-f590e625f042"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" },
                    { new Guid("fa946f9b-af5a-4474-86fa-6f792243efea"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" },
                    { new Guid("1910f96d-6c6e-42e1-901a-d62f597c31f3"), "ENCARGADO DE LA FISCALIA DE ZONA REGIONAL SUR (IZUCAR DE MATAMOROS)" },
                    { new Guid("e50ea911-116f-41dc-b05d-c6086f8d99da"), "ENCARGADO DEL DESPACHO DE LA SUBDIRECCION DE DESARROLLO ADMINISTRATIVO Y PLANEACION" },
                    { new Guid("79ccc402-9c9f-45ec-aa80-9b0777c32593"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" },
                    { new Guid("aa6bd72e-d8d6-4104-a274-bf970f8356dd"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE PROVEEDURIA" },
                    { new Guid("847fc085-c7ec-4ce3-b88e-93820c9b9639"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE SINIESTROS" },
                    { new Guid("79c274a3-f533-4636-964f-aeb80cacd090"), "ENCRGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d454e700-69fc-4f5d-b300-0a2e7afb0b7e"), "ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("74583456-fc73-4bfa-83a6-cc733b91f326"), "ENLACE DE APOYO ADSMINISTRATIVO Y BIENES ASEGURADOS" },
                    { new Guid("bf71b769-1f85-4ce4-8c08-1971f9bf5cad"), "ENLACE DE APOYO JURIDICO (PENDIENTE OFICIO)" },
                    { new Guid("0e3bed1a-2909-4eec-b37f-28cb26d89153"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE NARCOMENUDEO" },
                    { new Guid("730d4013-9ee0-4a60-9334-2c938846b5ce"), "COORDINADORA DE MEDIOS ALTERNATIVOS DEL AREA DE LA REGION PONIENTE" },
                    { new Guid("df0f1c68-18dd-42f0-90df-f5deceaa7b7d"), "DIRECTORA DE OPERACION DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("af980c5c-6724-46f0-b032-84473da588d4"), "DIRECTORA DE LABORATORIOS" },
                    { new Guid("fc00240f-9912-4ecf-9bad-3e0aa85e04ec"), "COORDINADORA GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("4f32a67a-7ec3-4da5-b951-b2b83966bb80"), "DIRECTOR DE APOYO Y LOGISTICA ADMINISTRATIVA DE LE VISITADURIA GENERAL" },
                    { new Guid("8febacbc-c14c-48f9-9d1a-9cae97bfcf56"), "DIRECTOR DE AREA" },
                    { new Guid("87b0b113-0dd0-4bc6-bdfb-e09001bc6634"), "DIRECTOR DE ATENCION A MANDAMIENTOS MINISTERIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("0da4c451-8bb0-47f1-bf86-579c97aa5e47"), "DIRECTOR DE ATENCION CIUDADANA DE LA COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("a6e0ffa4-77b8-4906-94a4-6d469ee6623a"), "DIRECTOR DE BIENES ASEGURADOS" },
                    { new Guid("5718aaa8-175f-4fd4-b64a-700d95c5cbd1"), "DIRECTOR DE CALIDAD" },
                    { new Guid("784afa88-cfc5-4b3f-a8cf-706fdddbd4c6"), "DIRECTOR DE COLABORACION DE LA AGENCCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("902ba59f-4bb0-48a5-b575-ef821ae3efff"), "DIRECTOR DE DESARROLLO FINANCIERO Y PRESUPUESTAL" },
                    { new Guid("38a70e96-9a03-47c6-b694-dc8836c4a94d"), "DIRECTOR DE INFORMACION" },
                    { new Guid("faac0d4d-14e5-47f7-8a68-57757c10b665"), "DIRECTOR DE INVESTIGACION DE LA VISITADURIA GENERAL" },
                    { new Guid("29483a5d-bf3a-40c6-8300-1da8580ff402"), "DIRECTORA DE LO CONTENCIOSO" },
                    { new Guid("b554a2b6-18e5-41f3-86c4-3daaea46fb0c"), "DIRECTOR DE SEGURIDAD A SERVIDORES PUBLICOS, INSTALACIONES Y EVENTOS" },
                    { new Guid("cdff54fb-1faf-41db-97b6-f973621b2e6c"), "DIRECTOR DE MANDAMINETOS JUDICIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("2f6d0e3e-fbab-4b30-a134-314f93e577e5"), "DIRECTOR DE TECNOLOGIA" },
                    { new Guid("01d19f23-ad1a-4b28-b65c-a6b79b60de50"), "DIRECTORA DE GESTION DOCUMENTAL" },
                    { new Guid("445c8b65-71e1-4add-a526-55d81593b012"), "DIRECTORA DE CRIMINALISTICA" },
                    { new Guid("d49ecd9e-8ad5-4d01-8baa-56ccca0a4028"), "DIRECTORA DE COMUNICACION SOCIAL" },
                    { new Guid("debf3e1c-9a75-4616-b758-cb3f9be909d4"), "DIRECTOR DE SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("b06c7e4e-bdc1-4606-912b-c2b7335ba572"), "DIRECTORA DE APOYO TECNICO OPERATIVO" },
                    { new Guid("c8d6628c-c764-4cdf-bafe-19f8d38ab0fd"), "DIRECTORA DE APOYO Y LOGISTICA ADMINISTRATIVA DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("b8379e9f-3688-4fba-875d-61b69a9a7b37"), "DIRECTORA DE ADMINISTRACION" },
                    { new Guid("d681e9a9-c35d-4cc3-9190-b3de4093a2da"), "DIRECTORA CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("97a00341-af59-40d2-98a8-5aef0f668df3"), "DIRECTOR GENERAL DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("3290087c-a185-4c43-b8fe-6910e6e92e60"), "DIRECTOR GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("6ffbbd49-10e3-4490-9d7a-1967fc6e7af6"), "DIRECTOR GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("113767a2-7997-4086-bb8d-6eb583866f5d"), "DIRECTORA DE APOYO A LA INVESTIGACION" },
                    { new Guid("ddcf0910-f6d2-4262-a381-ffd8a5532a85"), "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" }
                });

            migrationBuilder.InsertData(
                table: "CargoHomologado",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("44886160-7c9e-4ab7-82ea-ce1c2c684733"), "PERSONAL DE APOYO SUSTANTIVO" },
                    { new Guid("8fce62fb-a90a-4782-87e4-12db38017dfa"), "PERITO" },
                    { new Guid("148f9dad-2c97-4feb-889f-36fa41182a76"), "PERSONAL ADMINISTRATIVO" },
                    { new Guid("ab0020d1-c6c5-4603-8caa-24f587d89d51"), "FACILITADOR" },
                    { new Guid("ac02f4cb-5aa7-4060-9d12-f896def849c8"), "ANALISTA DE INFORMACION" },
                    { new Guid("d0494553-4950-4acb-99f2-00262723f367"), "AGENTE DEL MINISTERIO PUBLICO" },
                    { new Guid("66327b82-45e5-4f68-9351-67ddd2f6fb9a"), "ESTRUCTURA" }
                });

            migrationBuilder.InsertData(
                table: "CargoHomologado",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { new Guid("5a9a3825-c6ae-48bf-9cc1-ea77b41b3100"), "AGENTE INVESTIGADOR" });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d27c0e41-f4c8-44ca-8ed9-7a899c420fad"), "UNIDAD DE INVESTIGACION PIAXTLA" },
                    { new Guid("129720fe-db96-44ef-adee-b62c6087caa3"), "UNIDAD DE INVESTIGACION AMOZOC" },
                    { new Guid("085b6600-8778-4e58-9200-3f743324d907"), "UNIDAD DE INVESTIGACION ARCO ALTEPEXI" },
                    { new Guid("3325415c-6454-4f53-b09f-b73691d634af"), "UNIDAD DE INVESTIGACION ATEMPAN" },
                    { new Guid("8ba7f74b-c13b-4488-99bf-abed5cd32e8b"), "UNIDAD DE INVESTIGACION ATENCINGO" },
                    { new Guid("42aed84c-06c1-4b79-baef-35a63ae6b50d"), "UNIDAD DE INVESTIGACION ATLIXCO" },
                    { new Guid("b28dc0c0-f56b-4931-9de0-12f57313854f"), "UNIDAD DE INVESTIGACION CALPAN" },
                    { new Guid("64f91807-f178-49ec-ab2b-2af23353e8ee"), "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA" },
                    { new Guid("f5fd6ba2-9026-4154-9f02-5307869930d2"), "UNIDAD DE INVESTIGACION CHIETLA" },
                    { new Guid("d0d302c7-e4ae-44a9-9d17-de9f0e9505d3"), "UNIDAD DE INVESTIGACION CHIGNAHUAPAN" },
                    { new Guid("9d6b76da-0dbf-45c2-9ae2-138df080cb9a"), "UNIDAD DE INVESTIGACION CIUDAD SERDAN" },
                    { new Guid("1fc75a58-6547-4699-bdcc-c58b181ebac7"), "UNIDAD DE INVESTIGACION CORONANGO" },
                    { new Guid("df71cf3e-f3f2-48fe-8fad-6361e4fec2eb"), "UNIDAD DE INVESTIGACION CUAUTLANCINGO" },
                    { new Guid("a80f5ca8-80a0-45b3-8503-a65c4458db23"), "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO" },
                    { new Guid("cc6b9d12-2d15-43e4-83f2-8d5293606ba5"), "UNIDAD DE INVESTIGACION DE DELITOS RELACIONADOS CON PERSONA DESAPARECIDAS" },
                    { new Guid("d69a9d4b-54fa-4051-b3c9-a255ce595637"), "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL" },
                    { new Guid("0c524f35-9c68-4a59-88dd-957ad1347372"), "UNIDAD DE INVESTIGACION ESPERANZA" },
                    { new Guid("8cb44b58-d817-4481-b5fb-f964074e591f"), "UNIDAD DE INVESTIGACION GUADALUPE VICTORIA" },
                    { new Guid("f81a7545-3bfa-49e9-96df-7e1287a2a734"), "UNIDAD DE INVESTIGACION HUAUCHINANGO" },
                    { new Guid("effcbd7e-7f43-47e5-bbad-b51910436f52"), "UNIDAD DE INVESTIGACION HUEJOTZINGO" },
                    { new Guid("0a651df8-a636-4c2d-8741-cc95af0b4994"), "UNIDAD DE INVESTIGACION HUEYTAMALCO" },
                    { new Guid("120a4523-54ac-458f-b409-3c8a2b0d8049"), "UNIDAD DE INVESTIGACION IZUCAR DE MATAMOROS" },
                    { new Guid("7cc51782-8765-4fea-a3f4-35446d4e9b5b"), "UNIDAD DE INVESTIGACION JUAN C. BONILLA" },
                    { new Guid("3c91326b-3b77-4ece-bc3c-ed545bd900aa"), "UNIDAD DE INVESTIGACION LIBRES" },
                    { new Guid("dfacd773-55f7-4a74-827e-46cd0a6f37a5"), "UNIDAD DE INVESTIGACION METLALCOYUCA" },
                    { new Guid("f86cca42-a76d-43b8-ba2d-2b3581086f06"), "UNIDAD DE INVESTIGACION ORIENTAL" },
                    { new Guid("4b82c84f-6b14-411f-b020-96cdcfa10d9b"), "UNIDAD DE INVESTIGACION PALMAR DE BRAVO" },
                    { new Guid("83c1056a-660b-491c-ad8d-d1b603c5d0a2"), "UNIDAD DE INVESTIGACION AHUAZOTEPEC" },
                    { new Guid("538663a8-8c81-4997-bee5-c18401a59492"), "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL" },
                    { new Guid("1350ec60-66f4-46e3-8213-6f83a995c68d"), "UNIDAD DE INVESTIGACION ACATLAN" },
                    { new Guid("44665759-87c6-4570-b798-3d0cd2f88fbc"), "UNIDAD DE INVESTIGACION ACATENO" },
                    { new Guid("ea2e4723-7fca-496a-9c38-70feaf61c8c6"), "OFICINA DEL FISCAL GENERAL" },
                    { new Guid("0fdace3b-2df5-4212-be80-1b552c5f4046"), "ORGANO INTERNO DE CONTROL" },
                    { new Guid("7ee651b9-a3b0-491f-affe-ec2062c1cccc"), "PERSONAL PERICIAL EN MECANICA E IDENTIFICACION VEHICULAR" },
                    { new Guid("a27f50c0-5eed-404b-8811-554affe02e9c"), "SUBDIRECCION ACADEMICA" },
                    { new Guid("2edffd89-1d6e-42b4-9a3b-944e3b37f969"), "SUBDIRECCION DE CONTABILIDAD" },
                    { new Guid("d6c4a209-dd0b-41e4-bea7-d0ccf67db689"), "SUBDIRECCION DE CONTROL VEHICULAR Y GESTION ADMINISTRATIVA DE ARMAMENTO" },
                    { new Guid("c5147604-0ecb-4f14-abe7-a1278e8d636a"), "SUBDIRECCION DE CONTROL Y SEGUIMIENTO DOCUMENTAL" },
                    { new Guid("5b5105bd-8029-4e45-b98c-0754121d1d5e"), "SUBDIRECCION DE DESARROLLO ADMINISTRATIVO" },
                    { new Guid("867097d2-ff80-4771-ba9a-da779a5ff85c"), "SUBDIRECCION DE FONDOS Y POLITICA PRESUPUESTAL" },
                    { new Guid("be90ef27-641d-493e-a582-6620c2815417"), "SUBDIRECCION DE GLOSA GASTO CORRIENTE E INVERSION" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("6bf26815-5005-4386-84c2-2981d612e710"), "SUBDIRECCION DE PROFESIONALIZACION" },
                    { new Guid("651d9b06-71a6-4bc5-a573-e584cd42be53"), "SUBDIRECCION DE PROYECTOS DE INVERSION Y OBRA" },
                    { new Guid("edcece6f-d248-4216-9e25-67afa9050965"), "SUBDIRECCION DE RECEPCION Y DESPACHO DOCUMENTAL" },
                    { new Guid("9c022b70-e80b-40e0-8a49-a49d9d4404a8"), "UNIDAD DE INVESTIGACION ACATZINGO" },
                    { new Guid("e8d36eab-f2d1-4df1-af93-8b33364112c7"), "SUBDIRECCION DE RECLUTAMIENTO Y SELECCION" },
                    { new Guid("9145cbfd-cf7f-4008-a5e7-e30a09fbae02"), "SUBDIRECCION DE SERVICIO CIVIL DE CARRERA POLICIAL" },
                    { new Guid("5bd18ae9-c61b-4961-9a9d-2f14b78e1335"), "SUBDIRECCION DE SERVICIOS PERSONALES" },
                    { new Guid("68d16bc8-965c-49a2-a2c0-e57ae84abe6e"), "SUBDIRECCION DE SUMINISTROS" },
                    { new Guid("c3d05ca9-295f-4a99-86c8-080ef1df9bc8"), "SUBDIRECCION DE TESORERIA" },
                    { new Guid("bd346f24-16e0-4143-94c4-9a86524b00dd"), "SUBDIRECCION DEL DEPARTAMENTO TECNICO" },
                    { new Guid("35f959b4-a9a1-434b-9f35-0f33c4d751ea"), "TITULAR DE LA UNIDAD DE INVESTIGCION DE PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" },
                    { new Guid("5d14288e-6e62-462a-bbe5-1ff17cd49ecf"), "UNIDAD COORDINADORA DE ARCHIVO" },
                    { new Guid("c3e1b13b-ed22-4706-862c-d7259a43898d"), "UNIDAD DE ANALISIS Y CONTEXTO" },
                    { new Guid("4f7b93c2-e967-4c87-a43e-2a06ff9d82c9"), "UNIDAD DE APOYO PERICIAL" },
                    { new Guid("91cb0b31-52be-4aac-83e8-d2ebe6289f21"), "UNIDAD DE APOYO POLICIAL" },
                    { new Guid("e810057b-dde6-40b9-927a-3983652fc8b8"), "UNIDAD DE DERECHOS HUMANOS" },
                    { new Guid("684aee73-2525-4847-bb7e-cff33e7d4ad3"), "UNIDAD DE INVESTIGACION" },
                    { new Guid("4a25243f-4804-4b76-b221-c556f61ec2bb"), "UNIDAD DE INVESTIGACION ACAJETE" },
                    { new Guid("ad28bee5-b0ec-4f3d-9473-3b98ad36dde1"), "SUBDIRECCION DE SEGUIMIENTO AL SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("61f84f7a-c66a-4ea0-aca2-b001626fcbad"), "UNIDAD DE INVESTIGACION PUEBLA" },
                    { new Guid("8a3c11e6-b66d-48c1-a5c7-2ae1433e618f"), "UNIDAD DE INVESTIGACION SAN JOSE CHIAPA" },
                    { new Guid("4e52f8e9-3e0a-4c7c-9052-85674df0f118"), "UNIDAD DE INVESTIGACION SAN MARTIN TEXMELUCAN" },
                    { new Guid("6ca5dab9-fdd4-4362-8706-471aa6d56e62"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS COMETIDOS CONTRA PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" },
                    { new Guid("2a762c66-46c4-482f-91cd-7e0bb3fbee49"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD PUBLICA; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA; CONTRA LA SEGURIDAD COLECTIVA; CONTRA LA AUTORIDAD, Y EL DELITO DE ATAQUES PELIGROSOS" },
                    { new Guid("fbc04b5e-ad34-46cc-b3a8-356edc758358"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS" },
                    { new Guid("f95ca31f-f7ab-4a03-8e2c-a3cadaaabf40"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL" },
                    { new Guid("81fd0841-9506-4c22-b4a1-019309de7c7b"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("941f5ad8-06c9-46fe-9a9a-5c8db62a466e"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES" },
                    { new Guid("8ce48bdb-aadb-499c-a815-346fa39878f6"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE VIOLACION DE SECRETOS; DE RESPONSABILIDAD PROFESIONAL; DE DELITOS DE FALSEDAD, Y DELITOS POR INFRACCIONES A LAS LEYES Y REGLAMENTOS SOBRE INHUMACIONES Y EXHUMACIONES" },
                    { new Guid("bbf64a5a-9ddf-4a7f-8a72-e0a5296ef5ee"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE EXTORSION" },
                    { new Guid("ed371fe3-23a3-4123-bac2-b780a4d5f90e"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS" },
                    { new Guid("839ea87d-731c-433a-93ba-7d12f96a7eee"), "UNIDAD ESPECIALIZADA DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE FRAUDE Y ABUSO DE CONFIANZA" },
                    { new Guid("f3d8a56f-3505-49a4-909a-777c36275042"), "UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES" },
                    { new Guid("1a6a994d-33a9-41d3-b7f0-ff89a83226be"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" },
                    { new Guid("07d15469-2e0e-48b1-bd8b-ff0df21336ae"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LA FAMILIA" },
                    { new Guid("9a606e51-73d9-4789-b5bf-5ceafb8fde53"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LOS ANIMALES" },
                    { new Guid("a8c05f75-52de-463e-8500-8835f9183a16"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("989eb3af-5678-4aea-bbdb-877c1a3cf2ec"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" },
                    { new Guid("f334719f-de42-4a57-843a-5696bda29ba3"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE FEMINICIDIOS" },
                    { new Guid("29f13356-739d-4a34-ae6b-04a5541abc46"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE NARCOMENUDEO" },
                    { new Guid("ec6a4013-4c71-4d2c-81f0-8ef9bc21d8d3"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A CASA HABITACION" },
                    { new Guid("21ced715-f7ab-4299-af57-418356707377"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("cf10f52f-b50e-4ba2-8812-9ebf54c30f62"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" },
                    { new Guid("4b7a6650-706e-47c1-a39f-40e2104fb3a6"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" },
                    { new Guid("38a94d7a-9fb1-42dd-99bc-f1b5e7f9c918"), "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" },
                    { new Guid("e1f5947a-8da5-43ef-8b15-adfdc67212a1"), "UNIDAD METROPOLITANA DE INVESTIGACION Y LITIGACION DE DELITOS ELECTORALES" },
                    { new Guid("45ebf211-e534-4a50-949b-6e6ad17a0faf"), "UNIDAD RESOLUTORA" },
                    { new Guid("392b96c9-3e6e-49b2-88ef-a28095701d4c"), "VISITADURIA GENERAL" },
                    { new Guid("2caef6fc-e906-43e7-ba5e-c2b5d9681ce6"), "OFICINA DE ENLACE DE GESTION DOCUMENTAL" },
                    { new Guid("1fd8ce43-7b03-4827-a967-4b6bc9832437"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ASUNTOS INDIGENAS" },
                    { new Guid("e2aade10-d4e5-4077-a212-44363d0739d9"), "UNIDAD DE TRANSPARENCIA" },
                    { new Guid("cceeafea-a2db-414b-854a-e711c42eab7e"), "UNIDAD DE SUSTANCIACION" },
                    { new Guid("69fbe02c-bd31-46f4-a7ba-fb7ce2aef74f"), "UNIDAD DE SITUACION PATRIMONIAL" },
                    { new Guid("284e7e7c-c49d-46f1-928b-49d4f5f7843c"), "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA" },
                    { new Guid("7d5e5b5a-0ffb-428d-a918-32318a53cfab"), "UNIDAD DE INVESTIGACION SAN SALVADOR EL SECO" },
                    { new Guid("35b8fee4-5cfe-478f-96ed-339536485bb6"), "UNIDAD DE INVESTIGACION SANTA CLARA OCOYUCAN" },
                    { new Guid("e715ea85-5ffb-4fd2-98b5-cb0805a125de"), "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN" },
                    { new Guid("06ac4567-06b6-4f89-a4c8-0fe5826cf91b"), "UNIDAD DE INVESTIGACION TECALI DE HERRERA" },
                    { new Guid("ed2bea18-192c-4a32-b615-df814e7ecfe8"), "UNIDAD DE INVESTIGACION TECAMACHALCO" },
                    { new Guid("fbce7f02-57f2-4d28-8808-7566c9385ff4"), "UNIDAD DE INVESTIGACION TEHUACAN" },
                    { new Guid("afe59910-140c-4d65-acf5-378da9075fe9"), "UNIDAD DE INVESTIGACION TEHUITZINGO" },
                    { new Guid("6baa20c3-aa0e-4ff2-ae7f-0a99efffb4d8"), "UNIDAD DE INVESTIGACION TEPANCO DE LOPEZ" },
                    { new Guid("99559f47-8bf9-4bd1-979a-2e7c8aec9e48"), "UNIDAD DE INVESTIGACION TEPEACA" },
                    { new Guid("b5907d63-02fa-433b-add6-a0aba0186a52"), "UNIDAD DE INVESTIGACION TEPEOJUMA" },
                    { new Guid("c548a126-3f09-4b0c-be10-d0625e37ce4f"), "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ" },
                    { new Guid("db2aec03-4f0a-44be-8536-79308c9be6ae"), "UNIDAD DE INVESTIGACION TEPEYAHUALCO" },
                    { new Guid("578b8ff5-356a-46ed-b0b4-f6704ded7e84"), "UNIDAD DE INVESTIGACION SAN ANDRES CHOLULA" },
                    { new Guid("076dc28b-b28f-4dd1-bd80-b52072f73342"), "UNIDAD DE INVESTIGACION TETELA DE OCAMPO" },
                    { new Guid("21de35e3-6287-408b-bff7-f4c715abb796"), "UNIDAD DE INVESTIGACION TLACOTEPEC DE BENITO JUAREZ" },
                    { new Guid("a6aee6ed-b37a-4638-942b-df4568ffa490"), "UNIDAD DE INVESTIGACION TLAHUAPAN" },
                    { new Guid("7d9d24b8-5391-4713-a9bb-4ddec8d90b07"), "UNIDAD DE INVESTIGACION TLALTENANGO" },
                    { new Guid("0c94ab49-7a2f-48b3-a576-519e17bdb503"), "UNIDAD DE INVESTIGACION TLAOLA" },
                    { new Guid("b83f9bc7-a2b0-4aa1-ad70-eb1bc9884581"), "UNIDAD DE INVESTIGACION TLAPANALA" },
                    { new Guid("f9f7aa91-abbd-47e4-97cb-bc1b2f05af87"), "UNIDAD DE INVESTIGACION TLATLAUQUITEPEC" },
                    { new Guid("6d5ec4a3-a7b7-42b9-a327-c1627075e041"), "UNIDAD DE INVESTIGACION XICOTEPEC" },
                    { new Guid("579e3c73-044b-4c1a-830c-55a42b71b738"), "UNIDAD DE INVESTIGACION Y LITIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA" },
                    { new Guid("61319907-8b13-4176-ad2f-e035418415a1"), "UNIDAD DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("e27d709f-09d4-44f5-99eb-0b01794ca943"), "UNIDAD DE INVESTIGACION ZACAPOAXTLA" },
                    { new Guid("19442df5-fc84-4a33-b942-53b8cc30aec4"), "UNIDAD DE INVESTIGACION ZACATLAN" },
                    { new Guid("a2537a47-de40-43bb-92f2-d6da03ec0543"), "UNIDAD DE INVESTIGACION ZARAGOZA" },
                    { new Guid("d2b06cb1-ee70-42e9-a30e-166bd3722b62"), "UNIDAD DE LOCALIZACION DE PERSONAS DESAPARECIDAS" },
                    { new Guid("2668f811-6e88-40da-aca0-d72c28b9dcdc"), "UNIDAD DE INVESTIGACION TEZIUTLAN" },
                    { new Guid("4386903f-f952-4501-992d-e3b2ea24033d"), "OFICINA DE ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("27d7a43b-c96e-468d-9750-a60715a88030"), "LABORATORIO DE TOXICOLOGIA FORENSE" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0e3e3c51-92d8-45e6-b209-84d290352505"), "OFICIALIA MAYOR" },
                    { new Guid("8bb28b36-f19c-4a49-9a43-e04e253f48d9"), "DEPARTAMENTO DE EXPEDIENTES DE INVERSION Y BANCO DE PROYECTOS" },
                    { new Guid("9e4c176f-f3e0-4ca2-aa7b-48a08c35bbaf"), "DEPARTAMENTO DE EXPEDIENTES DE PERSONAL" },
                    { new Guid("28df96a6-a3a2-4fc7-8488-c1d6903bd230"), "DEPARTAMENTO DE INCIDENCIAS" },
                    { new Guid("0af17390-5171-4546-92a8-25b137739a6e"), "DEPARTAMENTO DE INFORMACION ESTADISTICA" },
                    { new Guid("7a893c56-53b1-43b8-a286-4be3607d1607"), "DEPARTAMENTO DE INFORMACION VEHICULAR" },
                    { new Guid("637b0a49-2ad9-43df-b2b9-4ec0145759ba"), "DEPARTAMENTO DE INVENTARIOS" },
                    { new Guid("e64fc2cf-b612-460f-a348-999f9ddf64ec"), "DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" },
                    { new Guid("cb1c4b57-f4bd-4908-8cf6-4524c3efbac4"), "DEPARTAMENTO DE MANUALES ADMINISTRATIVOS" },
                    { new Guid("f9954f01-6ac2-4d5f-8517-861ab2df9ed9"), "DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" },
                    { new Guid("af07a522-a7ba-4698-8723-4c334087dc32"), "DEPARTAMENTO DE NOMINA" },
                    { new Guid("ff7875d4-9898-4829-98be-8f085df5c897"), "DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA" },
                    { new Guid("8aaeac44-c66b-4150-b7a1-1b71dea1a716"), "DEPARTAMENTO DE PRODUCCION" },
                    { new Guid("e43f96ed-1c67-4fa4-9345-6561bce66fe3"), "DEPARTAMENTO DE PROVEEDURIA" },
                    { new Guid("0ca39010-2f2a-432c-b0d8-27ca18b6534f"), "DEPARTAMENTO DE RELACIONES PUBLICAS Y VINCULACION SOCIAL" },
                    { new Guid("4e331281-6f83-42c3-8062-2c18d9a3cf15"), "DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANOS" },
                    { new Guid("49af7b61-dc52-4af6-aaaf-b74166973d34"), "DEPARTAMENTO DE SERVICIOS GENERALES REGIONAL" },
                    { new Guid("b36d1699-3da6-4574-ba65-4d36e71cc291"), "DEPARTAMENTO DE SINIESTROS" },
                    { new Guid("b1bdf963-4068-48fc-ac5d-83badfd0383a"), "DEPARTAMENTO DE SOPORTE TECNICO" },
                    { new Guid("c7feee56-3ea7-461f-8b4f-5e6b16c9e330"), "DEPARTAMENTO DE TELECOMUNICACIONES" },
                    { new Guid("611e7155-040a-426b-b0c2-7ce0efb6ff55"), "DEPARTAMENTO JURIDICO" },
                    { new Guid("cac840c7-bd6c-41f0-bb25-88e071b2a8bc"), "DEPARTAMENTO TECNICO" },
                    { new Guid("1915a937-3622-4aeb-b3a0-8a5a06b09bd1"), "DIBUJO FISONOMICO Y DESCRIPTIVO" },
                    { new Guid("00ff16c1-f7a9-4b03-aef1-497d4b43f61d"), "DIRECCION CONSULTIVA Y DE NORMATIVIDAD" },
                    { new Guid("86ca9374-8217-4553-9993-e074284f0850"), "DIRECCION DE ADMINISTRACION" },
                    { new Guid("3a4cff0f-47f3-4972-91da-7c41f07cea9b"), "DIRECCION DE APOYO TECNICO OPERATIVO" },
                    { new Guid("3e787ed4-30ed-40a0-b15f-fdef92519752"), "DIRECCION DE APOYO Y LOGISTICA ADMINISTRATIVA" },
                    { new Guid("0b9c3030-b2ea-4e37-9f30-40a6d00bf2fe"), "DIRECCION DE ATENCION A MANDAMIENTOS JUDICIALES" },
                    { new Guid("5d2e6bae-c5cc-45ef-be1e-14bb91a94cb0"), "DEPARTAMENTO DE DISEÑO E IMAGEN INSTITUCIONAL" },
                    { new Guid("c787f4e7-ec7a-4dfb-a291-90ea6208c2ce"), "DEPARTAMENTO DE DISEÑO E IMAGEN" },
                    { new Guid("cb75f717-c350-4479-b974-d65c2429047d"), "DEPARTAMENTO DE DESARROLLO DE APLICACIONES" },
                    { new Guid("76d3d6d4-0e9c-4671-a872-a65862d2c3af"), "DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" },
                    { new Guid("82cbbd47-7a8c-4d33-a50b-5d79537b7e9b"), "OFICINA DE ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS" },
                    { new Guid("5c82f89b-4ac4-4746-952a-0f82545ca745"), "AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("3db1235f-2815-4778-bfc4-66b18e314fec"), "AREA METROPOLITANA ZONA NORTE" },
                    { new Guid("c0020c4c-5373-4e79-b16f-541df3bc978b"), "COORDINACION DE INVESTIGACION" },
                    { new Guid("e23c2b89-31a2-4310-8aa4-5d8d1c21f0cd"), "COORDINACION DE LITIGACION" },
                    { new Guid("c428b8ce-e1b0-43e6-bd52-b2e7011b333f"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("df6dd245-f208-4040-a4a3-35a37f898a29"), "COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("89a1c25c-e003-446b-b8e8-755fe6814270"), "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("6d4a7ec2-f4aa-4f61-98ca-0a560b34951d"), "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("2e699524-9616-4d3f-b43f-3685a1b90814"), "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("6ca84329-45df-45c2-9458-36f42a63e77b"), "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("1608a673-d735-46da-b3f5-2e756876a652"), "COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("0a601e98-c1dc-41fd-bed1-d91bf396506d"), "COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("5ac15a94-cbcc-47e5-b109-5a231b3fc8c8"), "DIRECCION DE ATENCION A MANDAMIENTOS MINISTERIALES" },
                    { new Guid("a83b5c61-128f-4faa-ad91-cee9d08da240"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("42c05b3d-cb6b-413d-81e4-aff3e668607d"), "DEPARTAMENDO DE EXPEDIENTES DE PERSONAL" },
                    { new Guid("7e47ae0d-4fa3-4c1d-bda3-c080b5c60a7b"), "DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" },
                    { new Guid("3d583e22-91fe-4ff1-9245-77df058a66b0"), "DEPARTAMENTO DE AGENDA DIGITAL E IMAGEN" },
                    { new Guid("d27bc523-d33c-4efd-9526-6a373281c82c"), "DEPARTAMENTO DE ALMACEN" },
                    { new Guid("dc82c84a-3f47-4837-bc95-e42a7166c7a5"), "DEPARTAMENTO DE ANALISIS DE DATOS" },
                    { new Guid("810ccf95-8ead-44f7-81df-db530fdb5b51"), "DEPARTAMENTO DE APOYO TECNICO" },
                    { new Guid("89a1ad30-baea-47df-a547-246b3d293612"), "DEPARTAMENTO DE ARCHIVO" },
                    { new Guid("f02e1537-6c33-4adf-a966-9cc5ca9dd50f"), "DEPARTAMENTO DE BASE DE DATOS" },
                    { new Guid("fd6a798a-d949-47c7-b249-72b711814380"), "DEPARTAMENTO DE CAPACITACION" },
                    { new Guid("2c23354a-8db6-4f7d-98ab-b7ad0e285081"), "DEPARTAMENTO DE CONTROL DE INDICIOS" },
                    { new Guid("b393c713-2f6c-4cd4-80b5-4996bc5462a3"), "DEPARTAMENTO DE CONTROL DE INMUEBLES" },
                    { new Guid("718694e0-67be-496c-96d7-38b18d4a8468"), "DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" },
                    { new Guid("654a00eb-4dcb-4c28-84b1-7fb5c0927f2c"), "DEPARTAMENTO DE CONTROL Y ABASTECIMIENTO DE COMBUSTIBLE" },
                    { new Guid("641a8023-b137-4b6c-b437-e58047130b80"), "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("5e91fba8-345f-4d6f-aca5-7f9dd340c5ac"), "DIRECCION DE ATENCION CIUDADANA" },
                    { new Guid("56fbfc33-062e-4ea9-9e31-b0518c6f6134"), "DEPARTAMENTO DE CONTROL VEHICULAR" },
                    { new Guid("6025ac23-fb86-4d7f-95b4-f1761b988483"), "DIRECCION DE BIENES ASEGURADOS" },
                    { new Guid("23b52e69-7719-4fec-9110-098eb1b80b11"), "FISCALIA DE ZONA ORIENTE" },
                    { new Guid("2fd68db9-cb3b-42c7-b604-a1dc13e35136"), "FISCALIA DE ZONA PONIENTE" },
                    { new Guid("0cc167e0-28b4-47ad-9c22-4cb34c10a397"), "FISCALIA DE ZONA SUR" },
                    { new Guid("50eb0b1e-5177-4433-8944-fccc27839605"), "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("665a8c98-73d8-4532-ad80-99773c3387a3"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("bf25368b-5ff3-457a-b554-42bdb9f8c2a4"), "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("a95965bd-801d-47d2-b86b-37bf988b3047"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("f24da380-f4b4-4619-b719-146d46eeabfa"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("705c79ec-5ce5-4dcc-849d-e396b5186f24"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("23dbcfb3-7381-4382-a818-2b62dc6922e0"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("a652de8b-691c-4986-ae4c-b5454d86007c"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("ccfd013c-eafa-452f-85a2-42274f412b9c"), "FISCALIA ESPECIALIZADA EN INVESTIGACION Y PERSECUCION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("fb241e3b-b169-48ff-9fb8-97aff7f45b13"), "FISCALIA GENERAL DEL ESTADO" },
                    { new Guid("e6b512b7-3a53-4d95-8dea-15862734f29a"), "INSPECTORIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("93e85577-2d0b-4313-8a0a-3b3525b07949"), "INSPECTORIA DE OPERACION METROPOLITANA" },
                    { new Guid("587a63a5-0221-4441-be3f-2fa4680d2c6d"), "INSPECTORIA REGIONAL DE ATENCION A MANDAMIENTOS JUDICIALES" },
                    { new Guid("d2d45837-6430-4fbc-87f8-f917d5110b85"), "INSTITUTO DE CIENCIAS FORENSES" },
                    { new Guid("8feddb6a-49e1-4658-bd06-c9a470fd3c04"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("5dbdeb83-b543-482f-9218-b606d41f5490"), "LABORATORIO DE ANALISIS DE EVIDENCIA DIGITAL Y MULTIMEDIA" },
                    { new Guid("62be0816-4206-411b-831c-194063519a21"), "LABORATORIO DE BALISTICA" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5866978c-6dd0-4e7b-b5e0-5b045eceb8ee"), "LABORATORIO DE DOCUMENTOS CUESTIONADOS" },
                    { new Guid("146dd406-8a71-405d-a0fa-c494c6d8b337"), "LABORATORIO DE GENETICA FORENSE" },
                    { new Guid("f452f0df-14dc-40c1-b647-e43bf2825741"), "LABORATORIO DE LOFOSCOPIA" },
                    { new Guid("d0631b80-ca2d-4303-b64a-c84343f971ae"), "LABORATORIO DE QUIMICA FORENSE" },
                    { new Guid("09cdeb9a-a5d4-4b71-8b2a-7a6b4884f100"), "LABORATORIO DE VETERINARIA Y ZOOTECNIA" },
                    { new Guid("4113b83d-d225-4ad9-a2a3-e3a0e863c01c"), "DIRECCION DE AUDITORIA" },
                    { new Guid("b23d7ed2-ee8e-4d96-a39f-38b97b225427"), "MEDICINA FORENSE" },
                    { new Guid("ad71baf2-ae72-467d-afeb-c32e348b72e4"), "FISCALIA DE ZONA NORTE" },
                    { new Guid("1194717a-cfe8-4eb1-b732-6c8d0bee7054"), "FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("0de05be6-6a57-4789-b24b-a03bf59c33a4"), "INSPECTORIA DE INVESTIGACION REGIONAL" },
                    { new Guid("230b178b-1306-43b8-b3a9-96ccc0ba8d3e"), "DIRECCION REGIONAL DE INVESTIGACION" },
                    { new Guid("f92a2abd-3533-499c-b025-c99cf93c75a2"), "DIRECCION DE COMUNICACION SOCIAL" },
                    { new Guid("db77e7da-a007-44cb-819f-306e0db2740c"), "DIRECCION DE CRIMINALISTICA" },
                    { new Guid("a06a896f-01db-4b92-a4f8-a2df8aca69d0"), "DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL" },
                    { new Guid("03bda19b-2fd9-4704-85cd-35e53866cd9a"), "DIRECCION DE GESTION DOCUMENTAL" },
                    { new Guid("d3e37413-fb66-4f7d-b617-5f425154692c"), "DIRECCION DE INFRAESTRUCTURA TECNOLOGICA" },
                    { new Guid("8def3bee-ebe8-47a3-9226-d23a3c7b6660"), "DIRECCION DE INTERVENCION INMEDIATA" },
                    { new Guid("71b29b11-7987-47b7-8da3-242bf3e35b9b"), "DIRECCION DE INVESTIGACION" },
                    { new Guid("1c4fdffb-ad45-4186-bd25-78f394f96165"), "DIRECCION DE LABORATORIOS" },
                    { new Guid("db03cc42-3c73-4ffe-80db-1d64bb3f0722"), "DIRECCION DE LO CONTENCIOSO" },
                    { new Guid("faaf9095-f9dc-4de6-8cc3-0213e6986b45"), "DIRECCION DE OPERACION" },
                    { new Guid("634ed18a-6c15-417f-baa7-534c5c8bfa28"), "DIRECCION DE CAPACITACION Y POLITICA CRIMINAL" },
                    { new Guid("ccf6d41b-0865-4fdb-b3eb-22133cbf4dd8"), "DIRECCION DE OPERACION Y LOGISTICA" },
                    { new Guid("970c4cb7-7416-40c3-ac92-dd5c79046dcf"), "DIRECCION DE COLABORACION" },
                    { new Guid("da24b2ea-0191-47a7-923c-8e4b8490351f"), "DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO" },
                    { new Guid("bce13477-9c05-4c3d-baa5-126cd6e6e8d6"), "DIRECCION DE RESPONSABILIDADES" },
                    { new Guid("ba21f80c-af25-4212-8f5e-eaf386d672f1"), "DIRECCION DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL" },
                    { new Guid("0b9df89a-4251-481f-93e2-67d85870d3f8"), "DIRECCION DE SEGURIDAD A SERVIDORES PUBLICOS INSTALACIONES Y EVENTOS" },
                    { new Guid("912e9e8a-0b09-4b98-b7cb-b46602b2b8d2"), "DIRECCION DE SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("adf6022a-1434-4504-859d-7541be82048b"), "DIRECCION DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("d719d728-e71a-4226-89ad-5bdb6f2353da"), "DIRECCION DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("26d841b7-3ca0-4d9a-af80-6de05aafdcbd"), "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" },
                    { new Guid("8f9708af-8d38-48d9-b5fa-1086d8faf3c1"), "DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" },
                    { new Guid("35d23656-9540-44fb-b1e6-a990dc2a2e6e"), "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("74ee6925-7e4a-4b83-bd7c-4ace0ce871b4"), "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("bbda4601-c528-4a7a-a0b2-525d8e49aa5e"), "DIRECCION DE CALIDAD" },
                    { new Guid("adbc7fba-115a-4a4f-a578-d7802fbf1d84"), "DIRECCION METROPOLITANA DE LITIGACION" },
                    { new Guid("9da48eb0-3409-4772-aa0f-b42fa822a4a4"), "DIRECCION DE PROCEDIMIENTOS CONSTITUCIONALES" },
                    { new Guid("92c505d1-82a1-4276-800c-7ef5a4d5d91d"), "FISCALIA DE INVESTIGACION METROPOLITANA" }
                });

            migrationBuilder.InsertData(
                table: "Contratacion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("17805612-54b0-43ef-9860-6964ba543617"), "HONORARIOS" },
                    { new Guid("0fb4c79b-8dfd-468a-9e42-98fd742383ff"), "CONFIANZA" },
                    { new Guid("4b7d03f3-ef7d-4e42-ad73-f520c6d65edd"), "ASIMILADOS" }
                });

            migrationBuilder.InsertData(
                table: "Contratacion",
                columns: new[] { "Id", "Nombre" },
                values: new object[] { new Guid("499c6384-159a-49b1-bb24-36f13ae9fb10"), "BASE" });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0edefd0b-7073-4b93-95da-90bbe88e5081"), "AVENIDA REYES GARCIA 57 COLONIA ERMITA, METLALTOYUCA, PUEBLA. CP 73000", new Guid("e3aac610-9d71-4750-a408-c2ba1de06a5f"), "UNIDAD DE INVESTIGACION METLALTOYUCA" },
                    { new Guid("25a13674-4e84-47c2-accd-0e79f826d0ea"), "AVENIDA MERINO FERNANDEZ ENTRE CALLE JUAREZ Y CALLE AYUNTAMIENTO, PRESIDENCIA MUNCIAL, COL. CENTRO, LOS REYES DE JUAREZ, PUE.", new Guid("89ff867f-af7d-48c5-abef-413675cf30f5"), "UNIDAD DE INVESTIGACION LOS REYES DE JUAREZ" },
                    { new Guid("29be23b3-f444-46b7-ba37-9fdf3dbd78ec"), "CALLE LERDO NUMERO 988, LIBRES, PUEBLA", new Guid("eff52198-0e70-4e53-b4dc-5fda6382aadf"), "UNIDAD DE INVESTIGACION LIBRES" },
                    { new Guid("708e475a-2a6f-4e48-9473-b2c08079e0c7"), "CARRETERA FEDERAL PACHUCA TUXPAN, COL. CENTRO, VILLA LÁZARO CARDENAS", new Guid("8cbfe7a8-447e-43c3-8756-f68e83378b67"), "UNIDAD DE INVESTIGACION LAZARO CARDENAS" },
                    { new Guid("eecc929f-781d-4970-863f-fe5394abf1e9"), "AV.105 PONIENTE ENTRE CALLE PUEBLA Y OAXACA COL.POPULAR CASTILLOTLA, PUEBLA,", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION LA POPULAR" },
                    { new Guid("89c95d42-8a77-465a-bc9f-51dba6071605"), "CAMINO AL BATAN NO. 12 COL. VILLA SATELITE LA CALERA PUEBLA", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION LA MARGARITA" },
                    { new Guid("a8b53488-e616-4a07-ba6a-9ddb524da777"), "CALLE 5 DE MAYO S/N COLONIA CENTRO, JUAN C. BONILLA, PUE.", new Guid("ecfb68ce-9d3f-4272-b670-b63f7f4a54fb"), "UNIDAD DE INVESTIGACION JUAN C BONILLA" },
                    { new Guid("6d1ca38b-8b3b-4a49-bba1-e9cf23ffbf69"), "CALLE INDEPENDENCIA ESQ. CON CALLE 5 DE MAYO S/N COL. CENTRO, HUEYTAMALCO, PUE", new Guid("812f1523-8500-4fbc-9290-2b511da5ee46"), "UNIDAD DE INVESTIGACION HUEYTAMALCO" },
                    { new Guid("b6d44237-54cf-47f6-bf7a-3c0eb2ef06da"), "CALLE JUAREZ SUR S/N COL. YALU LOCALUDAD PUTAX-EAT, HUEHUETLA, PUE.", new Guid("df498a1f-3792-452b-ad70-ff1def221d29"), "UNIDAD DE INVESTIGACION HUEHUETLA" },
                    { new Guid("44b55079-5390-4ff7-af03-dc9f239e9e1f"), "CALLE 12 NORTE SEGUNDA SECCION 22, ESPERANZA, PUE.", new Guid("dc626225-2e6c-4938-94f2-f1dc0d7c097d"), "UNIDAD DE INVESTIGACION ESPERANZA" },
                    { new Guid("938caad1-0023-4c81-9e89-aacffbd85895"), "AV. 4 ORIENTE SIN NUMERO TECOAC", new Guid("2e1a8b19-3b35-4f27-924f-c54c88206e81"), "UNIDAD DE INVESTIGACION EL SECO" },
                    { new Guid("593a6af3-829f-4639-80db-77b12e469f54"), "CALLE MIGUEL ALVARADO ESQUINA CON ABASOLO S/N COLONIA CENTRO C.P. 75040 CUETZALAN PUEBLA", new Guid("9e176192-4277-4848-a41b-9d2836d7dd71"), "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO" },
                    { new Guid("4d069907-d15e-4715-98ac-4d203f75bf2a"), "CALLE CAMINO NACIONAL ESQUINA CON AQUILES SERDAN SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO  COMPLEJO DE SEGURIDAD", new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "UNIDAD DE INVESTIGACION CUAUTLANCINGO" },
                    { new Guid("dfdca4fa-263f-44ab-ad9b-a72ca5e2e8d0"), "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310", new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA ZACATLAN" },
                    { new Guid("5cafef35-d0e7-4501-a90a-1ca4e9d97730"), "PRIVADA UNIVERSIDAD II SAN MARTIN ALCHICHICA, IZUCAR DE MATAMOROS,PUEBLA", new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA IZUCAR DE MATAMOROS" },
                    { new Guid("ea5f16aa-ee0e-4709-a84f-160b36ea3d3f"), "PERIFERICO ECOLOGÍCO ARCO SUR NO. 4000, RESERVA TERRITORIAL ATLIXCAYOTL, SAN", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "UNIDAD DE INVESTIGACION CIUDAD JUDICIAL" },
                    { new Guid("cd4cb079-f1e9-4f4a-b804-71197d520419"), "LIBRAMIENTOCHIGNAHUAPAN - ZACATLAN, KM 4.5 BARRIO TOLTEMPAN, CHIGNAHUAPAN, PUE.", new Guid("9f2ad70c-f85a-42a4-a1d1-db23a6339930"), "UNIDAD DE INVESTIGACION CHIGNAHUAPAN" },
                    { new Guid("379ecbc7-ee46-4a2d-bc76-1097dddef05a"), "CALLE RAYON NUMERO 4 COL. CENTRO", new Guid("5a2e489b-ced1-47da-8455-fa692b081959"), "UNIDAD DE INVESTIGACION CHIETLA" },
                    { new Guid("a9e48337-dfd9-498c-bb79-5f355e877e11"), "CALLE REFORMA Y 5 NORTE COLONIA CENTRO, CHIAUTLA DE TAPIA", new Guid("1e6f3b9c-f27a-49da-a02f-6975839978bd"), "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA" },
                    { new Guid("f0ef919e-c0ed-4656-abd8-8a3c90877322"), "PROLONGACION DE LA 14 SUR NUMERO 11517 COL. SAN JOSE CHAPULCO", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION CHAPULCO" },
                    { new Guid("2bd2b7d0-8f13-4837-b295-3fd7b23eb845"), "9 ORIENTE NO.1405COL.CENTRO PUEBLA PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION CENTRO" },
                    { new Guid("f2812202-d4b6-41cd-a0a6-8b490697fc10"), "AV DE LAS HUERTAS 917 CUARTO BARRIO COL. CENTRO, HUEJOTZINGO, PUEBLA, CP.: 74168", new Guid("bd268009-9447-4da5-aebc-2e5b3cea3375"), "UNIDAD DE INVESTIGACION ADSCRITA A JUZGADOS PENALES Y CIVILES" },
                    { new Guid("72a04a8c-f5aa-4545-8d68-c3fd8aef314f"), "CALLE CONSTITUCION S/N ENTRE 16 DE SEPTIEMBRE Y DOMINGO ARENAS, PRESIDENCIA MUNICIPAL CALPAN, PUE.", new Guid("3c6dac9c-1012-4ea2-bfc7-0ff6d45258c6"), "UNIDAD DE INVESTIGACION CALPAN" },
                    { new Guid("18b9bf42-e324-4fe9-ab39-9f669f5a6a8c"), "CALLE 5 DE FEBRERO ESQUINA MIGUEL HIDALGO COL LA CRUZ", new Guid("a3a7e42c-b3ae-4d43-9da8-e414fb60a7aa"), "UNIDAD DE INVESTIGACION ATENCINGO" },
                    { new Guid("90f6cba7-b81e-40dc-996f-154efa5f0c5c"), "02 ORIENTE SIN NUMERO, COLONIA CENTRO, ATEMPAN, PUEBLA", new Guid("cd8ef709-7737-4990-aea1-b105ae25f8a5"), "UNIDAD DE INVESTIGACION ATEMPAN" },
                    { new Guid("0d382eaf-bb2f-4754-accd-260199799f98"), "CALLE FRANCISCO I. MADERO 109 COLONIA CENTRO BARRIO DE SANTIAGO, AMOZOC, PUE.", new Guid("1a3d8733-aebb-4cf4-8732-cefaaf066d9f"), "UNIDAD DE INVESTIGACION AMOZOC" },
                    { new Guid("34c82967-a25e-4139-9ae5-c41b26973eee"), "CALLE GUERRERO SIN NÚMERO, AJALPAN PUEBLA", new Guid("24f40687-4afb-42e9-ae74-55fd8126a2d5"), "UNIDAD DE INVESTIGACION AJALPAN" },
                    { new Guid("3a1b93b7-30e8-4aba-bb0d-ead91b06d4db"), "PLAZA PRINCIPAL S/N PLANTA BAJA, PALACIO MUNICIPAL, COL. CENTRO, SANTA CLARA OCOYUCAN", new Guid("fd568848-1d55-4fc3-aee4-8e5ea8d9a2c4"), "UNIDAD DE INVESTIGACION OCOYUCAN" },
                    { new Guid("9e0f5696-4a56-4808-a549-e276c4dd02c5"), "CALLE HIDALGO SUR  S/N COL. CENTRO (DENTRO DE LA PRESIDENCIA MUNICIPAL", new Guid("863e7a7d-99e6-473c-824c-e58e005dedd9"), "UNIDAD DE INVESTIGACION AHUAZOTEPEC" },
                    { new Guid("58221593-419a-4d31-9547-1ba6af8de059"), "AV. 5 DE FEBRERO NORTE SIN NUMERO COL. EL MONTERO CORONANGO, PUEBLA  COMPLEJO METROPOLITANO", new Guid("cc19c5f3-be8e-43e3-8c86-fe33c1818d12"), "UNIDAD DE INVESTIGACION CORONANGO" },
                    { new Guid("7d6dd043-7963-4eab-88aa-dc62d8ae2261"), "AV. AYUNTAMIENTO NO. 3 COL. CENTRO CP 75020", new Guid("8f75b923-3632-4e2f-b4ed-7515e6186c47"), "UNIDAD DE INVESTIGACION ORIENTAL" },
                    { new Guid("205e805a-dd6f-4371-be67-dc8d8bfb2fce"), "CAMINO AL BATÁN KM2.5 COL.LOMAS DE SAN MIGUEL PUEBLA,PUE. CP.: 72573", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO DE VEHICULOS (OCRA)" },
                    { new Guid("3414abc8-08be-4deb-8516-d73fc4758626"), "CALLE NICOLAS BRAVO #504 COL. CENTRO PLAMAR DE BRAVO", new Guid("4169b1d9-9250-431b-ad0e-e376dedbbe5d"), "UNIDAD DE INVESTIGACION PALMAR DE BRAVO" },
                    { new Guid("9225f54e-32b5-4e8a-96bb-bdc02572d785"), "AV. IGNACIO ROMERO VARGAS 201 COL CENTRO CP 75150", new Guid("738bc1a9-6e14-42b5-812f-04026164c3c2"), "UNIDAD DE INVESTIGACION ACATZINGO" },
                    { new Guid("526a433b-bd0c-4f7b-a2e6-22d9c3a4099a"), "CALLE 8 ORIENTE, NUMERO 1007, COLONIA SAN FRANCISCO, PUEBLA, PUE.", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD INTEGRAL DE SERVICIOS EL ALTO" },
                    { new Guid("99a615bb-9e36-44e6-a400-b20289314022"), "CALLE 12 ORIENTE NO. 608 COL. CENTRO ,PUEBLA, PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD ESPECIALIZADA ADSCRITA A LA FISCALIA METROPOLITANA (JUZGADOS PENALES)" },
                    { new Guid("410fe8f5-f67f-4ccb-89e2-cfd3831ec6e5"), "CALLE JUVENTUD S/N COL. CENTRO", new Guid("c230a882-643e-4852-b8f6-235521115256"), "UNIDAD DE INVESTIGACION ZOQUITLAN" },
                    { new Guid("c3ea6749-ed2a-4ff8-b9f4-ce7f4a422e05"), "CALLE 3 ORIENTE 1211 COLONIA SANTA ANA, ZARAGOZA, PUE.", new Guid("6a791658-fcd5-4327-a0b5-fd6cdb7186b0"), "UNIDAD DE INVESTIGACION ZARAGOZA" },
                    { new Guid("426f19c9-435e-45df-b75c-be778b4bf5a8"), "CALLE 2 DE ABRIL SUR, EDIFICIO REVOLUCIÓN ESQUINA IGNACIO COETO ,COL. CENTRO ZACAPOAXTLA PUEBLA", new Guid("44531449-928c-44d8-ad72-08a007376f44"), "UNIDAD DE INVESTIGACION ZACAPOAXTLA" },
                    { new Guid("c27dec8f-eefc-47a7-b560-c08b46064999"), "AV. 5 DE MAYO NO.1 EXTERIOR DE LA PRESIDENCIA MUNICIPAL, GUADALUPE VICTORIA , PUEBLA", new Guid("3e191fda-da34-44ca-b4bb-250221113af2"), "UNIDAD DE INVESTIGACION Y MEDIOS ALTERNATIVOS" },
                    { new Guid("252418e4-f894-4dab-a27b-6772e6729136"), "CALLE 2 DE ABRIL 117 COLONIA CENTRO, XICOTEPEC DE JUAREZ, PUEBLA.", new Guid("42a91eae-d655-4e1d-ae93-d0f05644c956"), "UNIDAD DE INVESTIGACION XICOTEPEC DE JUAREZ" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("262e5839-3058-4fb0-99ac-a08b30f5a513"), "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM", new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "UNIDAD DE INVESTIGACION VW" },
                    { new Guid("5b29e6a3-f535-4f42-b77c-29fe81911aba"), "CALLE 21 ORIENTE NO.404, COL. EL CARMEN, PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION VIRTUAL PREDENUNCIA EL CARMEN" },
                    { new Guid("232845d9-e879-4641-9b0f-6a477185dc50"), "CALLE FRANCISCO I. MADERO NO. 07 COL. CENTRO, SAN PABLO XOCHIMEHUACAN", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION VILLA FRONTERA" },
                    { new Guid("1fedb2b2-25ed-455c-9043-7d8de47c56f1"), "BOULEVARD VALSEQUILLO ESQU. 20 DE NOVIEMBRE COL. SAN BALTAZAR CAMPECHE,PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION VALSEQUILLO" },
                    { new Guid("b5dd07e7-c359-462c-b5b9-b386a6a0bacf"), "PALACION MUNICIPAL S/N TLAPANALA PUEBLA", new Guid("1242ec1e-21fe-4df0-a3b9-19a802b81495"), "UNIDAD DE INVESTIGACION TLAPANALA" },
                    { new Guid("857aa1ad-e0c6-4411-864d-da72efabda09"), "ESQUINA QUE FORMAN LAS CALLES MORELOS Y CUAUHTEMOC NÚMERO 1, TLAOLA, PUEBLA", new Guid("537bb756-17a5-47fc-b120-422d42fbb510"), "UNIDAD DE INVESTIGACION TLAOLA" },
                    { new Guid("b8ea7fe6-2292-4b65-b514-e09d8cac64ba"), "REAL DE SAN PEDRO NO 15 COL. CENTRO, C.P.72600, TLALTENANGO, PUE.", new Guid("9c702270-caf2-4ffd-ad1c-0de66c489b5b"), "UNIDAD DE INVESTIGACION TLALTENANGO" },
                    { new Guid("985f2f6f-52da-4748-8aa9-dd8a0ed31d67"), "PLAZA COMUNITARIA CALLE AGUASCALIENTES SIN NUMERO COLONIA CENTRO 75680", new Guid("1b221df8-c8e6-4f7b-9e7d-0d4c8969f307"), "UNIDAD DE INVESTIGACION TLACOTEPEC" },
                    { new Guid("1e3c4fab-fc30-4bfb-b3ce-08d738aeed93"), "7 PONIENTE #1, COLONIA CENTRO, TETELA DE OCAMPO, PUEBLA", new Guid("554efbe1-bfdb-4795-acbc-77476dd16085"), "UNIDAD DE INVESTIGACION TETELA DE OCAMPO" },
                    { new Guid("a172a1a9-6d33-4d48-8140-222be2d29ca5"), "PLAZA EXPLANADA PALACIO MUNICIPAL S/N COL. CENTRO PRIMER PISO", new Guid("0016b4cd-c631-41ce-9f68-95548bfb6d4a"), "UNIDAD DE INVESTIGACION PIAXTLA" },
                    { new Guid("56ced837-0519-4403-a2b1-63347a0247a8"), "AVENIDA NIÑOS HEROES SIN NUMERO COLONIA EL SOL, SAN GABRIEL CHILAC, PUEBLA", new Guid("2cd2b213-bf6e-4518-bd69-aa5ee56aa419"), "UNIDAD DE INVESTIGACION SAN GABRIEL CHILAC" },
                    { new Guid("fc51337e-3ff2-4e72-9b00-08400529ee67"), "CALLE 15 NORTE SIN NÚMERO, SEGUNDO PISO, SAN MATÍAS COCOYOTLA, SAN PEDRO CHOLULA, PUE.", new Guid("912b0fd3-7578-48ee-9bab-124f90ea30d3"), "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA" },
                    { new Guid("b78c8eb5-c9f6-4fe8-8d7a-b277796e8ffd"), "CALLE MIGUEL HIDALGO S/N COL. CENTRO 74100, SANTA RITA TLAHUAPAN, PUE.", new Guid("bacd27c0-4eb5-44bf-9cb4-f9c737a6d9e3"), "UNIDAD DE INVESTIGACION SANTA RITA TLAHUAPAN" },
                    { new Guid("c40e712c-7ae3-4339-be44-b1b2292c3806"), "11 PONIENTE ENTRE 1 SUR Y AV. NACIONAL, SANTIAGO MIAHUATLAN, PUE.", new Guid("d67741af-e356-458b-94ef-4f48bd7c5aa8"), "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN" },
                    { new Guid("cd6e6ab0-c3f4-4008-982f-ac88585b78b0"), "CALLE DE HERRERA S/N COL. CENTRO, TECALI DE HERRERA", new Guid("108ca3a5-91f6-4c7c-b261-b003cc15813f"), "UNIDAD DE INVESTIGACION TECALI DE HERRERA" },
                    { new Guid("c0fc46be-a67f-434b-82b6-46bca45a0d94"), "PROLONGACIÓN 16 ORIENTE ESQ. CON LIBRAMIENTO A TEHUACAN COL. MEXICO 68", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE INVESTIGACION ORIENTE" },
                    { new Guid("09e97bae-3743-4ae4-9409-976f22c51cae"), "CALLE 10 SUR 507, BARRIO DE SAN JOSE, TECAMACHALCO, PUEBLA", new Guid("c7d4c93f-1e48-41a5-83a9-8cb883cef9de"), "UNIDAD DE INVESTIGACION TECAMACHALCO" },
                    { new Guid("e968dcde-9b00-4444-9776-3a4428ab6ccb"), "PRIV. 8 PONIENTE S/N COL. CENTRO 75800, TEPANCO DE LOPEZ, PUE.", new Guid("a53d0778-b9b0-40da-bf1f-ba7453b5f655"), "UNIDAD DE INVESTIGACION TEPANCO" },
                    { new Guid("4817859a-a50d-4d25-8947-ce688b074043"), "2 SUR ESQUINA CON 9 ORIENTE S/N COL. CENTRO, TEPATLAXCO DE HIDALGO, PRIMER PISO", new Guid("99af18a2-a030-4080-ab55-0fcb63659217"), "UNIDAD DE INVESTIGACION TEPATLAXCO" },
                    { new Guid("2dac919a-f66c-4df0-90f4-579f89899e8c"), "AVENIDA HIDALGO NÚMERO 509 A, TEPEACA PUEBLA", new Guid("d4ac176e-55a9-45e4-9053-10b44f883bd6"), "UNIDAD DE INVESTIGACION TEPEACA" },
                    { new Guid("da490ddf-d2f6-47a0-bcf2-3310363ea2fc"), "CALLE IRINEO VAZQUEZ, NÚMERO 1, TEPEOJUMA, PUEBLA", new Guid("a82fba97-2ed6-4848-8ec8-bbde9ccbfc1a"), "UNIDAD DE INVESTIGACION TEPEOJUMA" },
                    { new Guid("e61c6c1f-1910-49ff-9cb1-bc62da38c73b"), "CALLE 5 DE FEBRERO PLAZA COMUNITARIA PROF .ABEL CRUZ GARCIA , NÚMERO 3  COL CENTRO, TEPEXI DE RODRIGUEZ PUEBLA", new Guid("c76f5daa-fddd-4abb-a861-df871d4cf4b0"), "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ" },
                    { new Guid("6b3e8002-a241-4e89-899a-06261cb4b913"), "CALLE PRIMERA DE VENUSTIANO CARRANZA Y CALLE PRIMERA MORELOS S/N TEPEYAHUALCO, PUE.", new Guid("349731cc-3810-44c4-b445-71ff01c61caf"), "UNIDAD DE INVESTIGACION TEPEYAHUALCO" },
                    { new Guid("30edd360-e0bc-481b-bcd9-607794feb5d8"), "CALLE LA PRESA SECCIÓN TERCERA, TEHUITZINGO , PUEBLA", new Guid("ffd1e1de-f670-486f-a016-e78ed81fc055"), "UNIDAD DE INVESTIGACION TEHUITZINGO" },
                    { new Guid("b2d703c0-e3ea-42fb-9e3a-0b2632e689f3"), "CALLE ALLENDE NO. 1 COL. CENTRO SAN JOSÉ ACATENO", new Guid("0d8e75ba-ebe8-4eb6-ba8d-c555e67f2a1d"), "UNIDAD DE INVESTIGACION ACATENO" },
                    { new Guid("efd124dd-6502-4f6e-81a6-4d71392854ab"), "BOULEVARD EMILIANO ZAPATA SIN NUMERO, INTERIOR DEL PANTEON MUNICIPAL, CHIGNAHUAPAN,PUEBLA", new Guid("9f2ad70c-f85a-42a4-a1d1-db23a6339930"), "SEMEFO CHIGNAHUAPAN" },
                    { new Guid("602cf0c7-99b2-4d87-a9f6-bef2760365ef"), "EMILIANO ZAPATA KM2.5,COL LOMAS DE SAN MIGUEL,PUEBLA,PUE. CP.: 72573", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "UNIDAD DE IDENTIFICACION VEHICULAR" },
                    { new Guid("3061f5f9-731e-4f66-b566-7c64bbdf64e4"), "VÍA ATLIXCAYOTL NO. 1101, EDIFICIO SUR PLANTA BAJA , CONCEPCION LAS LAJAS , PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "CENTRO INTEGRAL DE SERVICIOS ANGELOPOLIS" },
                    { new Guid("0afcf63c-414f-4d18-b072-55a21c7232de"), "CALLE COMPLUTENSE ESQUINA CALLE DE LA TURBINA S/N COL. UNIVERSIDADES II, TEHUACAN ,PUE. CP.: 75723", new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), "CENTRO DE JUSTICIA PARA LAS MUJERES TEHUACAN" },
                    { new Guid("174f9f2e-1181-409f-a16e-871cf67319e7"), "CALLE 17 PONIENTE NO.1919, BARRIO DE SANTIAGO,PUEBLA, PUE. CP.: 72410", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "CENTRO DE JUSTICIA PARA LAS MUJERES PUEBLA" },
                    { new Guid("e41a2c36-5620-4def-b83c-804d2f39a52f"), "AV. REFORMA 22 COLONIA CENTRO ENTRE EMILIANO ZAPATA Y VENUSTIANO C", new Guid("0e40384a-9817-4f2f-b142-7476b8c8e8f9"), "CENTRO DE JUSTICIA PARA LAS MUJERES EN ACATLAN DE OSORIO" },
                    { new Guid("86b1f981-b967-4fd5-b577-cc4e12e1b46e"), "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN,", new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), "CASA DE JUSTICIA ZACATLAN" },
                    { new Guid("d3252b5e-1fbd-4846-8aa0-593755735163"), "CALLE LA MESILLA NO.10 COL. INDUSTRIAL, TEZIUTLÁN, PUEBLA. CP.: 73850", new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), "CASA DE JUSTICIA TEZIUTLAN" },
                    { new Guid("3e8c83ab-53a1-41c4-9aab-828933b2a723"), "BLVD. ADOLFO MATEOS NO.4, PLANTA ALTA, COL. ZONA ALTA, TEHUACAN, PUEBLA CP.: 75750", new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), "CASA DE JUSTICIA TEHUACAN" },
                    { new Guid("e152a22d-c3c4-4baf-8523-9617486c2dcf"), "CARRETERA FEDERAL KM 60+490, COL.SANTIAGO ALSESECA, TECAMACHALCO, CP.: 75480", new Guid("c7d4c93f-1e48-41a5-83a9-8cb883cef9de"), "CASA DE JUSTICIA TECAMACHALCO" },
                    { new Guid("1f55557c-964b-4bb0-85ed-b89a9113f562"), "AUTOPISTA MÉXICO -PUEBLA S/N, SAL SALVADOR EL VERDE, SAN MARTIN TEXMELUCAN,", new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), "CASA DE JUSTICIA SAN MARTIN TEXMELUCAN" },
                    { new Guid("9d715109-bb34-4a25-bf4b-3f07fc3ee517"), "PERIFÉRICO ECOLÓGICO 100 SAN BERNARDINO TLAXCALANCINGO SAN ANDRES CHOLULA", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "CASA DE JUSTICIA SAN ANDRES CHOLULA" },
                    { new Guid("884662b3-9f62-4ed9-864c-84ceb2afe84c"), "CARRETERA IZUCAR DE MATAMOROS S/N COL. TLAXCALANCINGO, CP.: 72820", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "CASA DE JUSTICIA PARA ADOLESCENTES" },
                    { new Guid("733ca58d-55f6-4b15-a177-1b2b2c96a925"), "CARRETERA FEDERAL PUEBLA-IZUCAR DE MATAMOROS NO. 2119, COL. GALARZA, IZUCAR", new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), "CASA DE JUSTICIA IZUCAR DE MATAMOROS" },
                    { new Guid("3824f09c-1fe4-401f-aa97-3d95cb54e924"), "CAMINO A CATALINA S/N COLONIA EL POTRO, HUAUCHINANGO, PUEBLA CP.: 73176", new Guid("559fc027-355b-4bad-9d08-1db4bc51e80c"), "CASA DE JUSTICIA HUAUCHINANGO" },
                    { new Guid("1fa46626-f4ca-4541-8ec5-9d7e0d8d6671"), "BOULEVARD GENERAL MORENO VALLE NO. 1604, COL. TIZAYUCA ,ATLIXCO PUE. CP.: 74200", new Guid("3e834424-91f8-4a08-9cf2-933c1a28b373"), "CASA DE JUSTICIA ATLIXCO" },
                    { new Guid("d01944c4-0b51-455b-9340-ee6d11d67a97"), "CARRETERA INTERNACIONAL MÉXICO -OAXACA KM152+200, BARRIO LA PALMA , ACATLÁN DE OSORIO PUEBLA", new Guid("0e40384a-9817-4f2f-b142-7476b8c8e8f9"), "CASA DE JUSTICIA ACATLAN DE OSORIO" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5fa90fdf-c37c-4896-9202-cf9e8965aea1"), "REFORMA 3 ORIENTE, COL. CENTRO 74000 SAN MARTIN TEXMELUCAN, PUE.", new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), "CANACO SAN MARTIN TEXMELUCAN" },
                    { new Guid("a5a3c6fa-8d1f-415f-9e00-dd6fcd9411f0"), "CARRETERA FEDERAL PUEBLA TEHUACAN 1211 O KM 114 SAN LORENZO TEOTIPILCO, TEHUACAN, PUE.", new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), "C5 TEHUACAN" },
                    { new Guid("ba320320-3b9b-4390-be0a-7c083232ebd8"), "CARRETERA MÉXICO VERACRUZ KM 166+500PALMAR DE BRAVO , PUEBLA", new Guid("4169b1d9-9250-431b-ad0e-e376dedbbe5d"), "ARCO DE SEGURIDAD PALMAR DE BRAVO" },
                    { new Guid("fc3f72b8-525e-4cd0-a25d-ed8d3fa61785"), "CARRETERA MÉXICO -PUEBLA KM100+200 HUEJOTZINGO ,PUEBLA", new Guid("bd268009-9447-4da5-aebc-2e5b3cea3375"), "ARCO DE SEGURIDAD HUEJOTZINGO" },
                    { new Guid("1cdbe3ba-156b-4c4c-bbef-ba9256f8e75d"), "CARRETERA FEDERAL IZÚCAR DE MATAMOROS KM61+800 IZUCAR DE MATAMOROS", new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), "ARCO DE SEGURIDAD DE IZUCAR DE MATAMOROS" },
                    { new Guid("5d18df07-a839-4c95-8f5c-b9458c7a2595"), "CARRETERA ESTATAL TEHUACAN TEOTITLÁN OAXACA, TRAMO DE CHILACALTEPEXI,CP.: 75914", new Guid("f5e623d2-026d-4c91-bebc-579010cb7677"), "ARCO DE SEGURIDAD DE ALTEPEXI" },
                    { new Guid("61f9d887-5a87-44c3-a114-5d0cad70c14c"), "KM 19.5 CARRETERA FEDERAL PUEBLA - TEHUACAN, COLONIA SAN JOSE LAS FLORES, CP 72980, AMOZOC", new Guid("1a3d8733-aebb-4cf4-8732-cefaaf066d9f"), "ARCHIVO Y BODEGA DE INDICIOS" },
                    { new Guid("88733808-8fef-4929-a856-7d44c3be53da"), "CALLE ORQUIDEAS NO. 6141 COLONIA BUGAMBILIAS CP 72580", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "ALMACEN GENERAL" },
                    { new Guid("aac7bf25-e85d-4adf-bd70-f2ba243cbb70"), "AV. INDEPENDENCIA NUM. 20 COL.CENTRO , TLATLAUQUITEPEC,PUEBLA", new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), "AGENCIA ESTATAL DE INVESTIGACION TLATLAUQUITEPEC" },
                    { new Guid("0172497d-18fd-42fc-b3d5-2349011b583e"), "CALLE LERDO NÚMERO 205, ALTOS COL. CENTRO. ANEXO AL CERESO, TEZIUTLAN , PUEBLA", new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), "AGENCIA ESTATAL DE INVESTIGACION TEZIUTLAN" },
                    { new Guid("b7607eff-eff8-4aba-8475-bf00219a9dfc"), "CALLE JOSE GALEANA NO. 200 COLONIA DOMINGO ARENAS, SANTA RITA TLAHUAPAN", new Guid("bacd27c0-4eb5-44bf-9cb4-f9c737a6d9e3"), "AGENCIA ESTATAL DE INVESTIGACION SANTA RITA TLAHUAPAN" },
                    { new Guid("ad4bc7f5-16a7-406d-81c7-da1c0d334bab"), "CALLE VICENTE GUERRERO NO.714 COL, MORELOS SAN MARTIN TEXMELUCAN, CP.: 74020", new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), "AGENCIA ESTATAL DE INVESTIGACION SAN MARTIN TEXMELUCAN" },
                    { new Guid("35d320b0-0c19-481c-b69c-63d419b07348"), "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE.", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "AGENCIA ESTATAL DE INVESTIGACION PUEBLA" },
                    { new Guid("0bd8e30d-31cc-4512-8e0a-8f68266ee12a"), "CALLE 2 ORIENTE ENTRE CALLE 8 NORTE Y CALLE 10 ORIENTE.", new Guid("231d563b-6511-4f4a-9e90-7257755e21b1"), "UNIDAD DE INVESTIGACION ACAJETE" },
                    { new Guid("76e9edbd-9b38-4304-bc29-d79a0c7c06bc"), "CALLE AQUILES SERDAN ESQUINA CON 20 DE NOVIEMBRE SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO", new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "CENTRO INTEGRAL DE SERVICIOS CUAUTLANCINGO" },
                    { new Guid("ed5b6ff2-9c1d-4627-8e22-51ee147e4201"), "AV. REFORMA 1305 COL CENTRO C.P. 72000", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "CENTRO INTEGRAL DE SERVICIOS SAN JAVIER" },
                    { new Guid("15a5ff14-dbd2-4fcd-b2dc-6c990cb8bdad"), "KM.28+285 CARRETERA FEDERAL EL SECO ASUMBULLA, CD. SERDAN, PUEBLA CP.: 75520", new Guid("ac27c79a-e0de-43ba-9a99-2f15de5edb65"), "CASA DE JUSTICIA CHALCHICOMULA DE SESMA" },
                    { new Guid("e7fd7d82-a762-44db-91d5-ce71bf334fc8"), "CARRETERA FEDERAL TEZIUTLAN - ACAJETE NO. 169 BARRIO DE CONTLA", new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), "CENTRO INTEGRAL DE SERVICIOS TLATLAUQUITEPEC" },
                    { new Guid("23dd0625-7e09-444f-9ca3-161916d41cf0"), "CALLE PORFIRIO DIAZ Y DOLORES PEREZ SIN NUMERO COL. CENTRO  ZACATLAN, PUEBLA", new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), "SEMEFO ZACATLAN" },
                    { new Guid("c9ecbfca-73e3-4c07-a602-e23a9945f472"), "AV HIDALGO NO.169 EDIFICIO REAL PLANTA BAJA, CENTRO. TEZIUTLAN, PUEBLA.", new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), "CENTRO INTEGRAL DE SERVICIOS TEZIUTLAN" },
                    { new Guid("51337de0-0de2-47a9-8904-5ad933b9ae40"), "CALLE 2 DE ABRIL NORTE  SIN NUMERO ESUINA FJ. ARRIAGA COL. CENTRO ZACAPOAXTLA, PUEBLA", new Guid("44531449-928c-44d8-ad72-08a007376f44"), "SEMEFO ZACAPOAXTLA" },
                    { new Guid("e1d63cf7-815d-41c2-99d9-014a9cce294c"), "AV. ZARAGOZA SIN NUMERO, XICOTEPEC DE JUAREZ", new Guid("42a91eae-d655-4e1d-ae93-d0f05644c956"), "SEMEFO XICOTEPEC DE JUAREZ" },
                    { new Guid("9de39295-08e0-4c93-b229-37499a6d6ea0"), "AV DOLORES BETANCOURT COL. CONTLA, TLATLAUQUITEPEC, PUEBLA", new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), "SEMEFO TLATLAUQUITEPEC" },
                    { new Guid("741fb5a0-3175-4db6-b46c-daae21d2a3e7"), "PANTEON MUNICIPAL CALLE DEFENSORES DEL 6 DE JUNIO SIN NUMERO, TEPEXI DE  RODRIGUEZ", new Guid("c76f5daa-fddd-4abb-a861-df871d4cf4b0"), "SEMEFO TEPEXI DE RODRIGUEZ" },
                    { new Guid("7ba2052e-3cb6-4ace-aa80-6c427d64dc9f"), "INTERIOR DEL PANTEON MUNICIPAL, CALLE 17 ORIENTE Y AVENIDA COLON SIN NUMERO, BARRIO EL  SANTUARIO", new Guid("d4ac176e-55a9-45e4-9053-10b44f883bd6"), "SEMEFO TEPEACA" },
                    { new Guid("c86f4562-6b68-44aa-b970-243e14b0a194"), "CALLE 4 ORIENTE SIN NUMERO BARRIO DE GUADALUPE", new Guid("eff52198-0e70-4e53-b4dc-5fda6382aadf"), "SEMEFO LIBRES" },
                    { new Guid("e7f14c97-e7c3-467b-ac30-5f8310d4148e"), "PROLONGACION 11 SUR 11906, COL. GUADALUPE HIDQLGO", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "SEMEFO 11 SUR" },
                    { new Guid("1dd4a281-0759-40cc-8cb8-739f6dc3a772"), "DIAGONAL CUAUHTÉMOC NO.3101 COL. VALLE DORADO PUEBLA,PUE. CP.: 72070", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("0c94b4f7-d134-4ac6-85dc-bbf58625c489"), "AV. REFORMA 2704 5° PISO COL. AMOR", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "INMUEBLE CANACINTRA" },
                    { new Guid("23ed8c1d-864d-42df-9083-23eea1af7d1e"), "PRIV. 5 B SUR NO. 3706, COL. GABRIEL PASTOR, PUEBLA, PUE CP. 72420", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "INDIGENAS PERIODISTAS LGBTTQ" },
                    { new Guid("81a3d40c-a1a2-4eed-ada6-143b31b8f30e"), "3ER RETORNO OSA MENOR NO.3, RESERVA TERRITORIAL ATLIXCAYOTL ,SAN ANDRÉS", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("44386bd7-2492-4d93-a78e-a1816ebfaf2e"), "CALLE 10 ORIENTE NO.414,COL CENTRO PUEBLA,PUE. CP.: 72530", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (CPJ)" },
                    { new Guid("9e0a8a45-f81f-4e35-beab-153ae7e53f40"), "CALLE 6 NORTE NO.1003, COL. CENTRO,PUEBLA PUE. CP.: 72000", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (BOCHAS)" },
                    { new Guid("0fafd963-361c-4b92-b795-4219f7940a2d"), "13 SUR 1910 BARRIO DE SANTIAGO PUEBLA PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "JUSTICIA CIUDADANA" },
                    { new Guid("2e915059-5071-4525-b1a3-d76e913b8998"), "TERCER RETORNO OSA MAYOR NO. 3, RESERVA TERRITORIAL ATLIXCAYOTL SAN ANDRES", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("e8321188-3639-47fa-b6e0-d8e265dc2e5b"), "CALLE 127 PONIENTE Y CALLE 11 SUR , COL.EX-HACIENDA CASTILLOTLA, PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("931ecd8f-d618-49ae-b4c2-29174eb2e59c"), "CARRETERA FEDERAL PUEBLA - TEHUACÁN KILOMETRO 114, MANANTIALES, TEHUACÁN,PUE. CP.: 75855", new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), "CENTRO INTEGRAL SERVICIOS TEHUACAN" },
                    { new Guid("45906a3d-9e8f-48ff-85ce-11ea79d4edb8"), "CAMINO A CUAYANTLA NO. 1611, SAN BERNARDINO TLAXCALANCINGO, PUEBLA", new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "COMPLEJO DE SEGURIDAD PUBLICA SAN ANDRES CHOLULA" },
                    { new Guid("cd0a1b05-ed27-4d61-b225-be46cd2529d6"), "PERIFERICO ECOLÓGICO KILÓMETRO 3.5 ANTIGUO CAMINO A SAN FRANCISCO OCOTLÁN, CUAUTLANCINGO PUEBLA", new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "COMPLEJO METROPOLITANO SEGURIDAD PUBLICA (C5)" },
                    { new Guid("2b46cfb0-cbe7-43ec-82f6-4639da38e6ad"), "REVOLUCIÓN NO. 6202, COL. EL LEÓN ATLIXCO PUE, CP.: 74360", new Guid("3e834424-91f8-4a08-9cf2-933c1a28b373"), "CENTRO INTEGRAL SERVICIOS ATLIXCO" },
                    { new Guid("3e2fb426-20af-48b2-81e7-3458afad62c1"), "DIAGONAL DEFENSORES DE LA REPÚBLICA ESQ.10 PONIENTE COL.AMOR PUEBLA,PUE. CP.: 72140", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("742b64df-f5af-45aa-93d9-e1c8035fdad6"), "MANZANA NÚMERO 5 CIUDAD MODELO", new Guid("27172024-5222-4c81-9f58-d2010f067f2c"), "CENTRO INTEGRAL SERVICIOS SAN JOSE CHIAPA" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("72d093d9-c710-407b-8d64-0eb9b8d52083"), "CAMINO AL BATÁN COL.LOMAS DE SAN MIGUEL PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "DEPOSITO DE VEHICULOS OCRA - SAN MIGUEL 2" },
                    { new Guid("1f6bc9d7-36ba-472f-9c8e-0c3282fee714"), "BOULEVARD HEROES 5 DE MAYO ESQUINA CON 31 ORIENTE COL.LADRILLERA DE BENITEZ CP.: 72530", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "EDIFICIO CENTRAL 04" },
                    { new Guid("0bca398f-a923-4b1f-bfea-c75b0fe4a285"), "KM 2.5 CARRETERA AL BATAN , EDIFICIO ADJUNTO AL CERESO DE SAN MIGUEL PUEBLA,PUE", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "EJECUCION DE SENTENCIAS" },
                    { new Guid("9c8d1d27-c114-4cc5-9928-07efffab3272"), "12 NORTE. NO.1806,COL. BARRIO DEL ALTO , PUEBLA PUE. CP.: 72146", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA DE ASUNTOS INTERNOS, ORGANO INTERNO DE CONTROL Y VISITADURIA" },
                    { new Guid("21223825-1990-4641-80b2-646d7a4aaa7c"), "CALLE 12 ORIENTE NO. 415 COL. CENTRO, PUEBLA, PUE.", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA DE DERECHOS HUMANOS" },
                    { new Guid("96476f7e-40ba-4fd7-993c-1fa19de518ab"), "AVENIDA 16 DE SEPTIEMBRE NUMERO 2904 COLONIA EL CARMEN, PUEBLA, PUE.", new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION, FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICUALRES" },
                    { new Guid("f17baa14-fec6-4d0b-91b5-f497262ea9a8"), "RIO ATOYAC # 19 SANCTORUM", new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "DEPOSITO DE VEHICULOS SANCTORUM (FINSA)" }
                });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), "TEHUACAN" },
                    { new Guid("ffd1e1de-f670-486f-a016-e78ed81fc055"), "TEHUITZINGO" },
                    { new Guid("2cd2b213-bf6e-4518-bd69-aa5ee56aa419"), "SAN GABRIEL CHILAC" },
                    { new Guid("99af18a2-a030-4080-ab55-0fcb63659217"), "TEPATLAXCO DE HIDALGO" },
                    { new Guid("a53d0778-b9b0-40da-bf1f-ba7453b5f655"), "TEPANCO DE LOPEZ" },
                    { new Guid("c7d4c93f-1e48-41a5-83a9-8cb883cef9de"), "TECAMACHALCO" },
                    { new Guid("27172024-5222-4c81-9f58-d2010f067f2c"), "SAN JOSE CHIAPA" },
                    { new Guid("d67741af-e356-458b-94ef-4f48bd7c5aa8"), "SANTIAGO MIAHUATLAN" },
                    { new Guid("bacd27c0-4eb5-44bf-9cb4-f9c737a6d9e3"), "SANTA RITA TLAHUAPAN" },
                    { new Guid("2e1a8b19-3b35-4f27-924f-c54c88206e81"), "SAN SALVADOR EL SECO" },
                    { new Guid("912b0fd3-7578-48ee-9bab-124f90ea30d3"), "SAN PEDRO CHOLULA" },
                    { new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), "SAN MARTIN TEXMELUCAN" },
                    { new Guid("d4ac176e-55a9-45e4-9053-10b44f883bd6"), "TEPEACA" },
                    { new Guid("108ca3a5-91f6-4c7c-b261-b003cc15813f"), "TECALI DE HERRERA" },
                    { new Guid("a82fba97-2ed6-4848-8ec8-bbde9ccbfc1a"), "TEPEOJUMA" },
                    { new Guid("6a791658-fcd5-4327-a0b5-fd6cdb7186b0"), "ZARAGOZA" },
                    { new Guid("c76f5daa-fddd-4abb-a861-df871d4cf4b0"), "TEPEXI DE RODRIGUEZ" },
                    { new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), "SAN ANDRES CHOLULA" },
                    { new Guid("c230a882-643e-4852-b8f6-235521115256"), "ZOQUITLAN" },
                    { new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), "ZACATLAN" },
                    { new Guid("44531449-928c-44d8-ad72-08a007376f44"), "ZACAPOAXTLA" },
                    { new Guid("42a91eae-d655-4e1d-ae93-d0f05644c956"), "XICOTEPEC DE JUAREZ" },
                    { new Guid("8cbfe7a8-447e-43c3-8756-f68e83378b67"), "VILLA LAZARO CARDENAS" },
                    { new Guid("8e782151-d63e-4ca8-872a-ae64af743095"), "TEPEXCO" },
                    { new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), "TLATLAUQUITEPEC" },
                    { new Guid("537bb756-17a5-47fc-b120-422d42fbb510"), "TLAOLA" },
                    { new Guid("9c702270-caf2-4ffd-ad1c-0de66c489b5b"), "TLALTENANGO" },
                    { new Guid("1b221df8-c8e6-4f7b-9e7d-0d4c8969f307"), "TLACOTEPEC DE BENITO JUAREZ" },
                    { new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), "TEZIUTLAN" },
                    { new Guid("554efbe1-bfdb-4795-acbc-77476dd16085"), "TETELA DE OCAMPO" },
                    { new Guid("349731cc-3810-44c4-b445-71ff01c61caf"), "TEPEYAHUALCO" },
                    { new Guid("1242ec1e-21fe-4df0-a3b9-19a802b81495"), "TLAPANALA" },
                    { new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), "PUEBLA" },
                    { new Guid("559fc027-355b-4bad-9d08-1db4bc51e80c"), "HUAUCHINANGO" },
                    { new Guid("4169b1d9-9250-431b-ad0e-e376dedbbe5d"), "PALMAR DE BRAVO" }
                });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0016b4cd-c631-41ce-9f68-95548bfb6d4a"), "PIAXTLA" },
                    { new Guid("231d563b-6511-4f4a-9e90-7257755e21b1"), "ACAJETE" },
                    { new Guid("0d8e75ba-ebe8-4eb6-ba8d-c555e67f2a1d"), "ACATENO" },
                    { new Guid("0e40384a-9817-4f2f-b142-7476b8c8e8f9"), "ACATLAN DE OSORIO" },
                    { new Guid("738bc1a9-6e14-42b5-812f-04026164c3c2"), "ACATZINGO" },
                    { new Guid("863e7a7d-99e6-473c-824c-e58e005dedd9"), "AHUAZOTEPEC" },
                    { new Guid("f5e623d2-026d-4c91-bebc-579010cb7677"), "ALTEPEXI" },
                    { new Guid("1a3d8733-aebb-4cf4-8732-cefaaf066d9f"), "AMOZOC" },
                    { new Guid("cd8ef709-7737-4990-aea1-b105ae25f8a5"), "ATEMPAN" },
                    { new Guid("a3a7e42c-b3ae-4d43-9da8-e414fb60a7aa"), "ATENCINGO" },
                    { new Guid("3e834424-91f8-4a08-9cf2-933c1a28b373"), "ATLIXCO" },
                    { new Guid("3c6dac9c-1012-4ea2-bfc7-0ff6d45258c6"), "CALPAN" },
                    { new Guid("ac27c79a-e0de-43ba-9a99-2f15de5edb65"), "CHALCHICOMULA DE SESMA" },
                    { new Guid("1e6f3b9c-f27a-49da-a02f-6975839978bd"), "CHIAUTLA DE TAPIA" },
                    { new Guid("5a2e489b-ced1-47da-8455-fa692b081959"), "CHIETLA" },
                    { new Guid("24f40687-4afb-42e9-ae74-55fd8126a2d5"), "AJALPAN" },
                    { new Guid("cc19c5f3-be8e-43e3-8c86-fe33c1818d12"), "CORONANGO" },
                    { new Guid("fd568848-1d55-4fc3-aee4-8e5ea8d9a2c4"), "OCOYUCAN" },
                    { new Guid("e3aac610-9d71-4750-a408-c2ba1de06a5f"), "METLALTOYUCA" },
                    { new Guid("89ff867f-af7d-48c5-abef-413675cf30f5"), "LOS REYES DE JUAREZ" },
                    { new Guid("eff52198-0e70-4e53-b4dc-5fda6382aadf"), "LIBRES" },
                    { new Guid("ecfb68ce-9d3f-4272-b670-b63f7f4a54fb"), "JUAN C. BONILLA" },
                    { new Guid("8f75b923-3632-4e2f-b4ed-7515e6186c47"), "ORIENTAL" },
                    { new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), "IZUCAR DE MATAMOROS" },
                    { new Guid("bd268009-9447-4da5-aebc-2e5b3cea3375"), "HUEJOTZINGO" },
                    { new Guid("df498a1f-3792-452b-ad70-ff1def221d29"), "HUEHUETLA" },
                    { new Guid("3e191fda-da34-44ca-b4bb-250221113af2"), "GUADALUPE VICTORIA" },
                    { new Guid("dc626225-2e6c-4938-94f2-f1dc0d7c097d"), "ESPERANZA" },
                    { new Guid("9e176192-4277-4848-a41b-9d2836d7dd71"), "CUETZALAN DEL PROGRESO" },
                    { new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), "CUAUTLANCINGO" },
                    { new Guid("812f1523-8500-4fbc-9290-2b511da5ee46"), "HUEYTAMALCO" },
                    { new Guid("9f2ad70c-f85a-42a4-a1d1-db23a6339930"), "CHIGNAHUAPAN" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Activo", "Nombre" },
                values: new object[,]
                {
                    { new Guid("592d923a-9d0b-424c-8bc3-0c42ff72495e"), true, "UnidadAdministrativa" },
                    { new Guid("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), true, "AllView" },
                    { new Guid("77a225a3-1266-4b1f-b11c-504969afa856"), true, "Root" },
                    { new Guid("9a39bcce-b092-4f90-9de7-9e0fb2137034"), true, "Administrador" }
                });

            migrationBuilder.InsertData(
                table: "UnidadAdministrativa",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("b3c79508-8fd1-4c74-94e3-661f2b0f6a4e"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("a94e3201-d601-4b23-831f-bd278c968fcc"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("d5e00aa7-f1ca-4438-8230-c77356cd3180"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("887a45dc-c627-4118-8fc5-0c08cbd9ded9"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA FISCALES Y RELACIONADOS" },
                    { new Guid("2fdd51f1-25b4-4f59-9c84-cc4bdabc1129"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("0432ca29-4cd7-41cc-a53e-a6c24d47a3a2"), "FISCALIA ESPECIALIZADA EN INVESTIGACION Y PERSECUCION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" }
                });

            migrationBuilder.InsertData(
                table: "UnidadAdministrativa",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("603c5f94-d51a-4870-832f-905832e7d316"), "FISCALIA GENERAL DEL ESTADO" },
                    { new Guid("dddedd77-b472-4782-9b59-5034449d5769"), "INSTITUTO DE CIENCIAS FORENSES" },
                    { new Guid("ecefee5a-aa12-4b58-acd7-d25d9a04781a"), "OFICIALIA MAYOR" },
                    { new Guid("5df421a3-da6a-45df-a09b-8f3df5afb7c1"), "OFICINA DEL FISCAL GENERAL" },
                    { new Guid("a0e0508e-f3df-4d10-a1c9-0a7c8020e264"), "ORGANO INTERNO DE CONTROL" },
                    { new Guid("f1880a2f-6d03-46e6-b80c-8e2b5f9be0f6"), "UNIDAD DE TRANSPARENCIA" },
                    { new Guid("9a281a7a-8df2-406a-ab7e-4e0ea9130562"), "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" },
                    { new Guid("84fc32d2-e3be-44bb-a657-58b1f8bf19bc"), "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("2f3bdd4f-141f-4b68-8bb1-cc9d02b0a468"), "VISITADURIA GENERAL" },
                    { new Guid("78453d3e-6561-4ad9-9027-e00a4888b2e4"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("bcc0d506-1853-4229-8e26-cac7a61d75a9"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("6482d123-1e00-41e4-bfa3-d18bf73f05ad"), "AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("8011d409-1dcb-464b-ba14-18b70305ac5f"), "FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("901cc26b-0dd7-472a-ad59-aca590690d15"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("b1b63424-b460-4ddc-951f-27e85ee09144"), "COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("df6f2571-3cf2-4f22-918b-b354986a8cbd"), "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("c255b613-a724-47dd-a762-261123565595"), "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("0e3aa015-4581-4c88-a8c9-679dd80b0d13"), "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("997134f0-1449-4e50-a9ff-7f1b4576e0c6"), "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("97f215d4-d5a6-4dea-b4f2-46133a305c5c"), "COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("699b5f80-ef84-452a-a15e-6ab46c7c1c6e"), "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("e74898ef-601c-407a-bf69-4be98c0fbe01"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("17610375-ea95-4654-a6f8-197ad8235b5c"), "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("8784e258-77d3-455b-ade0-32dd25923973"), "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" },
                    { new Guid("62a9307e-8b40-40f9-8c91-33d02582d7c3"), "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("80507965-9116-4871-94e7-9c049ef307ea"), "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("70f0cdd3-24f8-4b7c-8a52-b66745ca8072"), "FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("263332d2-bdf0-4b62-9504-85c030ba710d"), "COORDINACION GENERAL DE LITIGACION" }
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "Activo", "IdRol", "IdUnidadAdministrativa", "Nombre", "Password" },
                values: new object[,]
                {
                    { new Guid("67bb4459-8401-4b49-8ac8-67d3219fbfc8"), true, "592d923a-9d0b-424c-8bc3-0c42ff72495e", "0e3aa015-4581-4c88-a8c9-679dd80b0d13", "cgesi", "cgesi" },
                    { new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"), true, "77a225a3-1266-4b1f-b11c-504969afa856", "", "root", "root" },
                    { new Guid("061bc395-9e04-40d9-824c-0c740f63af15"), true, "9a39bcce-b092-4f90-9de7-9e0fb2137034", "", "oficialiaMayor", "oficialiaMayor" },
                    { new Guid("0524769e-c144-4772-a050-811e7d2b68ce"), true, "a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7", "", "visitaduria", "visitaduria" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asistencia");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "CargoHomologado");

            migrationBuilder.DropTable(
                name: "CentroTrabajo");

            migrationBuilder.DropTable(
                name: "Contratacion");

            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Incidencia");

            migrationBuilder.DropTable(
                name: "Inmueble");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "UnidadAdministrativa");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
