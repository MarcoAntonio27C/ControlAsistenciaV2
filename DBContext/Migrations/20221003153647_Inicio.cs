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
                    Curp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroExpediente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaIngreso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huella = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    IdMunicipio = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdInmueble = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCargo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    { new Guid("35f230e5-95d9-4740-9d5e-a2d6330bcbb3"), "AGENTE DEL MINISTERIO PUBLICO" },
                    { new Guid("698c91a9-eef1-4aaa-afb5-ec3165dadbb0"), "JEFE DE DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" },
                    { new Guid("bd60c318-f90f-4937-b329-4943010b5fb9"), "JEFE DE DEPARTAMENTO DE INDICIOS Y BIENES AFECTOS" },
                    { new Guid("064f278b-2461-418b-90ad-5c81c5fff7d7"), "JEFE DE DEPARTAMENTO DE INFORMACION VEHICULAR DE LA DIRECCION DE INVESTIGACION" },
                    { new Guid("c7dffaf9-6306-46f1-9a21-7752d348678c"), "JEFE DE GRUPO MINISTERIAL" },
                    { new Guid("a082cd25-2262-474b-845b-20c49da7b537"), "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE ATLIXCO)" },
                    { new Guid("2d4c71bf-0fb6-4420-88cd-ab5d481b98f2"), "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE TEPEACA)" },
                    { new Guid("d83fb7e8-d82e-4838-9b57-c3fbe7dd2d56"), "JEFE DE GRUPO MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("fba77d27-28b6-4eda-97be-ee44eb4b746d"), "JEFE DEL DEPARTAMENTO DE APOYO TECNICO " },
                    { new Guid("c9fec10c-cd1d-44d4-964e-b81f434bbae6"), "JEFE DEL DEPARTAMENTO DE CONTROL VEHICULAR" },
                    { new Guid("a1a4686d-46f1-4faa-ba80-567479279477"), "JEFE DEL DEPARTAMENTO DE DISEÑO E IMAGEN INSTITUCIONAL " },
                    { new Guid("97fb1504-48ee-4460-a313-7ff4dbca6ff2"), "JEFE DEL DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANA" },
                    { new Guid("36cd244f-d36f-4469-8b7d-f27a125c58ad"), "JEFE DEL DEPARTAMENTO JURIDICO DE MANUALES ADMINISTRATIVOS" },
                    { new Guid("36fde145-e0b8-45b3-b95d-e37a4cc95d69"), "OFICIAL A" },
                    { new Guid("f080e0e7-6e1f-41dd-b432-e73906fcff63"), "OFICIAL E" },
                    { new Guid("87d46917-7f04-4a59-975d-a72bdcc20f17"), "OFICIAL I" },
                    { new Guid("c1c81fc7-7ecb-4b38-b520-0bb93c7e85ac"), "OFICIAL M" },
                    { new Guid("1c3267bd-dab9-4e35-a9f9-0f0a1364cc67"), "OFICIAL R" },
                    { new Guid("76733838-b1db-4c0d-831d-d8844f26dbd3"), "OFICIAL DEL MINISTERIO PUBLICO" },
                    { new Guid("8a214f30-083a-43dd-970c-18c1ab84cdfa"), "OFICIAL MAYOR" },
                    { new Guid("71f6e543-05e3-4346-b92d-ff3b515547aa"), "PERITA" },
                    { new Guid("5fb3a3bf-9372-4d74-8884-a5156123e6cc"), "PERITA EN CONTABILIDAD" },
                    { new Guid("9378897d-3c18-4295-8518-21faf65f5811"), "PERITO" },
                    { new Guid("966bf88f-e037-4f6c-97c7-d30a9828d912"), "PERITO EN CONTABILIDAD" },
                    { new Guid("746b3784-08d6-43f6-863c-ada46d4a5a12"), "PERITO TECNICO" },
                    { new Guid("139887dd-0377-433a-b42f-4fd31703428e"), "RESPONSABLE DEL AREA DE LO CONTENCIOSO DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("2abf41c5-f1ca-4115-bc28-50a9e02c8294"), "SUBDIRECTOR" },
                    { new Guid("0e9fe512-c47b-4546-9854-d6d7c47e6512"), "SUBDIRECTOR ACADEMICO" },
                    { new Guid("19579446-96b6-476f-8eaf-e94fc311ecc3"), "JEFE DE DEPARTAMENTO" },
                    { new Guid("3c9aee73-53ec-4504-ad0f-08a4dcb3d9c2"), "SUBDIRECTOR DE APOYO TECNICO OPERATIVO" },
                    { new Guid("9cee6ab6-0a39-477b-8425-2b245ccd619e"), "JEFA DEL DEPARTAMENTO DE PROCEDIMIENTOS PARA EL DESTINO FINAL DE BIENES ASEGURADOS" },
                    { new Guid("c70ba7be-da95-4e52-ac3e-823fbf058c7f"), "JEFA DEL DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" },
                    { new Guid("5f154595-96e6-49f8-ad5a-86d6eeb550de"), "FACILITADOR" },
                    { new Guid("16dbcf26-c2b5-4de9-bd71-597171c7f3c2"), "FACILITADORA" },
                    { new Guid("41ffa416-1660-45b9-b5ef-bb5e3a51fc7c"), "FISCAL DE INVESTIGACION METROPOLITANA" },
                    { new Guid("2205d53e-82e7-4222-ae58-d24d9ed6918a"), "FISCAL DE INVESTIGACION REGIONAL" },
                    { new Guid("203c2302-371e-44a9-9cc1-834900f29d7c"), "FISCAL DE ZONA PONIENTE" },
                    { new Guid("3c6de366-c5c4-445c-980c-b4975cf0f4ae"), "FISCAL DE ZONA SUR DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("eca1fb98-995c-4abb-8d9f-a6cff9bff3b0"), "FISCAL ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES,COORDINADORA DE INVESTIGACION" },
                    { new Guid("a336d28f-f5e3-4927-bc34-8e48b44a4c6c"), "FISCAL ESPECIALIZADO DE ASUNTOS INTERNOS" },
                    { new Guid("c362e7cc-6169-4ef6-9966-3ee9e57ed7d0"), "FISCAL ESPECIALIZADO DE COMBATE A LA CORRUPCION" },
                    { new Guid("20458759-dac9-4579-bc14-3b20480781e0"), "FISCAL ESPECIALIZADO EN DERECHOS HUMANOS" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("6d2c7c85-9207-460a-ae94-a99e61a1b01d"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("4ec5deb5-db2f-45e5-a99b-b7d350d8cfd8"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PRECEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("a491d4ce-671f-49cf-84b9-4bba51a10f53"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("c8a12d82-bd40-40d2-b78f-5b43ac2e8492"), "FISCAL ESPECIALIZADO EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("06d23cba-8825-4787-a76a-69acc3132609"), "FISCAL GENERAL DEL ESTADO" },
                    { new Guid("137a7a20-3692-4e98-99a0-133a882870bf"), "HONORARIOS" },
                    { new Guid("ee8c95f9-8438-40d2-985c-f577f50d05d8"), "INSPECTOR GENERAL" },
                    { new Guid("2a98f412-0d1b-487f-bc34-06fc1b6cd77b"), "INVITADOR" },
                    { new Guid("908501cc-9993-4fe2-8257-c8b14514cac4"), "JEFA DE DEPARTAMENTO" },
                    { new Guid("f486d22c-5d94-44d2-9d4e-52196a0867f4"), "JEFA DE DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("b8e51bdc-fca6-45ad-9f9e-97d62893f1a5"), "JEFA DEL DEPARTAMENTO DE APOYO TECNICO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("2fb58fee-a5aa-499f-87e8-63f92445959c"), "JEFA DEL DEPARTAMENTO DE CONTROL DE INMUEBLES" },
                    { new Guid("11762e06-28bd-4807-a523-67e09ff86304"), "JEFA DEL DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" },
                    { new Guid("89f4699c-3bce-4e0b-9fdd-cd75027e5a20"), "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE INVERSION Y BANCO DE PROYECTOS" },
                    { new Guid("5c716978-4394-463c-a281-3075240b6775"), "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE PERSONAL  DE LA SUBDIRECCION DE SERVICIOS PERSONALES DE LA DIRECCION DE ADMINISTRACION  DE LA OFICIALIA MAYOR" },
                    { new Guid("265b6fb1-9931-404b-8b29-8ec26effb629"), "JEFA DEL DEPARTAMENTO DE GESTION DOCUMENTAL DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("0575c16d-e0db-47f2-9edb-ea565c2fd2be"), "JEFA DEL DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" },
                    { new Guid("f694701a-4ed9-4808-a8e4-359a27740d69"), "JEFA DEL DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA DE LA DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO DE LA OFICIALIA MAYOR" },
                    { new Guid("dc6aa2a1-fff7-41d1-b26c-4be062d104cf"), "SUBDIRECTOR DE CONTROL Y SEGUIMIENTO DOCUMENTAL" },
                    { new Guid("01510334-9dd9-488b-a89b-a082b4f453f4"), "SUBDIRECTOR DE PROFESIONALIZACION" },
                    { new Guid("e0c81eed-9072-47cd-bd5d-8598f7ac3b30"), "SUBDIRECTOR DE RECURSOS MATERIALES" },
                    { new Guid("e068ed49-da14-48a5-9f89-5763cac17a81"), "TITULAR DE LA UNIDAD DE INVESTIGCION DE PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" },
                    { new Guid("d0e7d6a1-873f-4eae-b4b2-1d2e62727834"), "TITULAR DE LA UNIDAD DE LOCALIZACION DE PERSONAS DESAPARECIDAS" },
                    { new Guid("c79ae3f9-4df9-4628-9741-0392063f2319"), "TITULAR DE LA UNIDAD DE SITUACION PATRIMONIAL DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("f5b93b97-778c-4df4-b7f4-5e8107dc284e"), "TITULAR DE LA UNIDAD DE SUSTANCIACION DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("23cdc855-96b5-4ddd-99a1-d57980ac0dc4"), "TITULAR DE LA UNIDAD DE TRANSPARENCIA" },
                    { new Guid("c48b6f63-f20e-4e43-a92e-8a584c809018"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS AMBIENTALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("49b515e1-92af-4f32-aff3-e078941daeec"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("51e230d1-a4e6-4cad-beeb-1a2bccb9da6f"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("a7c69146-2a72-4929-864e-66893241bf96"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("980e4407-af2a-45fc-9ab6-2cd2e3a216da"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("1478aaca-c922-41ab-8cab-34e6dce9aad8"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE  DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("dd55db68-ec82-47b7-b630-7941e8d67f08"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DEL DELITO DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("75419c29-be4f-4f75-97f6-9b1af211349f"), "TITULAR DE LA UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("611d87de-3f4c-44fa-8455-76822828cb8a"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" },
                    { new Guid("8e51c0d5-1b81-4946-b350-c175523ad26e"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("538936b5-0a05-4ce7-ae22-a6be4b55a83e"), "TITULAR DE LA UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" },
                    { new Guid("6be4c160-2802-41d8-bc19-8da78dfa46b9"), "TITULAR DE LA UNIDAD RESOLUTORA DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("d193efc9-b89f-45d4-85ae-ed0ea8af8413"), "TITULAR DE LA UNIDAD UNIDAD PARA LA BUSQUEDA DE MUJERES Y NIÑAS DESAPARECIDAS Y DELITOS RELACIONADOS A TRAVES DE LA APLICACION DEL PROTOCOLO ALBA Y LA COORDINACION CON LA ALERTA AMBER DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("2a2d1519-02d7-4b86-a76c-9ece94562a75"), "TITULAR DE UNIDAD" },
                    { new Guid("6bb5329b-e07a-4c99-bd27-5994ad239e54"), "TITULAR DE UNIDAD DE APOYO ADMINISTRATIVO" },
                    { new Guid("9a790101-e4fe-4e8d-aa4c-b6e954a4db03"), "TITULAR DEL DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("fbd7b890-d200-4055-a7fc-973990f68c68"), "TITULAR DEL INSTITUTO DE CIENCIAS FORENSES" },
                    { new Guid("cc85ec17-87d2-4ae2-a1ea-ea963534007b"), "TITULAR DEL INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("057035c9-1e3d-4342-9e02-3b2c785bcae5"), "TITULAR DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("81b47efb-2bfd-43f5-83cb-70fa069ee2c8"), "TTITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN ROBO A CASA HABITACION Y  ROBO A COMERCIO" },
                    { new Guid("23637a0a-a8f2-4cfd-a99d-95e4d0a2e70e"), "VISITADOR GENERAL" },
                    { new Guid("b9ac7679-b2df-4f1c-aa1f-d54d823bcd91"), "VISITADORA" },
                    { new Guid("11004dfa-721e-4834-a45c-abb0b77c0d2a"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN VIOLENCIA FAMILIAR Y DELITOS DE GENERO" },
                    { new Guid("ed158acd-e469-47f7-9ffa-c820b0b421d7"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN FEMINICIDIO" },
                    { new Guid("5fd8bba5-f8a1-41b8-9bb6-8e3f67815ba8"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN DELITOS FINANCIEROS Y PATRIMONIALES" },
                    { new Guid("e15e3d5b-8fb8-4d15-8e29-549577534629"), "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE SISTEMA TRADICIONAL" },
                    { new Guid("7dc71bc7-05f1-4676-82d0-54560136d092"), "SUBDIRECTOR DE REDES DE LA DIRECCION DE INFRAESTRUCTURA TECNOLOGICA DE LA COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("3f49112f-f7f2-4433-98ec-d4f3ada920e8"), "SUBDIRECTOR DE SUMINISTROS" },
                    { new Guid("64363e08-1512-4cac-b30d-417b7e300f74"), "SUBDIRECTOR DE TESORERIA DE LA DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL " },
                    { new Guid("8a459e96-d449-4f42-a412-961c0aea8128"), "SUBDIRECTOR DE VEHICULOS Y BANCO DE ARMAS" },
                    { new Guid("ac104386-d442-4203-aec8-1159745f7aa1"), "SUBDIRECTORA DE CONTROL DE GESTION DE LA DIRECCION DE AUDITORIA DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("42a36d6f-01d7-46f6-b8c4-e90a434592e8"), "SUBDIRECTORA DE FONDOS Y POLITICA PRESUPUESTAL" },
                    { new Guid("7017774e-2514-4c7f-9a08-8ef6bddd9790"), "SUBDIRECTORA DE GLOSA DE GASTO CORRIENTE E INVERSION" },
                    { new Guid("6f225a75-f2b6-461f-ac76-3ecfef52046c"), "SUBDIRECTORA DE LA DELEGACION TEHUACAN" },
                    { new Guid("cda9acc4-94c0-44eb-b1a5-f579b61f0f17"), "SUBDIRECTORA DE RECEPCION Y DESPACHO DOCUMENTAL" },
                    { new Guid("feef5cbb-64d4-41de-afb5-fcd8da2ed3e7"), "SUBDIRECTORA DE SERVICIO CIVIL DE CARRERA" },
                    { new Guid("e903db7a-d78e-4094-84d1-8760539585e3"), "SUBDIRECTORA DE SERVICIOS PERSONALES" },
                    { new Guid("de6b5495-e9b6-43eb-95c6-f447d03ed2dc"), "SUBDIRECTORA DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("bd11c0a6-75fa-46f9-a703-5842ce088c35"), "TITULAR DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("a7f43660-49a0-436b-ab82-d6f08ab14056"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("13670d5f-bddb-4274-9679-31e24a8fd69f"), "TITULAR DE LA DIRECCION METROPOLITANA DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("828b21e9-4c4d-4428-b59b-a545b02d21c8"), "TITULAR DE LA OFICINA DEL FISCAL GENERAL DEL ESTADO" },
                    { new Guid("24f20c86-5d72-49dc-bd89-3090ea26c5fa"), "TITULAR DE LA UNIDAD" },
                    { new Guid("5f1a8517-157c-429e-8c2d-0b4340fd832a"), "TITULAR DE LA UNIDAD  DE INVESTIGACION DE DELITOS RELACIONADOS CON PERSONAS DESAPARECIDAS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("e4974367-c31e-46ab-a375-5994772bafce"), "TITULAR DE LA UNIDAD COORDINADORA DE ARCHIVOS DE LA COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("6f67d27c-38a6-4e70-a2c8-cbdd90abe529"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("70a77508-cc1c-4f82-9af4-24606952a82c"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("36bbd816-f0a9-48fc-a668-0b33fee64b50"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("42960505-2789-4b23-82ac-e90601b3e53d"), "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("e90e03b4-d62d-454e-b5bd-0b59c44f6935"), "TITULAR DE LA UNIDAD DE DERECHOS HUMANOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("8d446da1-4206-4dad-9855-bc5ddb24510e"), "TITULAR DE LA UNIDAD DE FLAGRANCIA" },
                    { new Guid("9c66e495-7ddf-4d3f-b293-8d1cf51cb262"), "TITULAR DE LA UNIDAD DE FLAGRANCIA CENTRAL I" },
                    { new Guid("094209ac-a783-4b99-b13e-7da82e0f7396"), "TITULAR DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("988e2025-9650-45d6-b8a1-eee5812b7f15"), "TITULAR DE LA UNIDAD DE INVESTIGACION DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" },
                    { new Guid("d4f076ea-18cd-4899-987b-9b9e1c54137c"), "TITULAR DE LA DIRECCION REGIONAL DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("5df5e537-953b-42b8-bcf8-2dc09e8f7156"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION  DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("3a7137b4-a2de-42ee-81aa-1b13c12a807d"), "SUBDIRECTOR DE CONTABILIDAD" },
                    { new Guid("df47294a-11eb-4cb7-a0f3-f26402c3847f"), "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("a831d19c-b733-406d-92eb-bc9950068ce8"), "COORDINADOR DE ANALISIS ESTADISTICA Y BASE DE DATOS" },
                    { new Guid("500c309a-1fca-46cb-be2b-7ef05f774bb8"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("54bb2be3-9066-4002-a1e3-9fa5e556c552"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("a5549901-7b6c-4106-b738-6265bccb61f3"), "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("778e91ef-b9df-4ab8-ac1c-89e64fbb48e4"), "COORDINADOR DE LITIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("0273cab0-21d4-4c77-84fb-4ecd421055d9"), "COORDINADOR DE LITIGACION DE LA FISCALIA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("d37b21d2-175f-434a-862d-76755c1baad9"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("c180e628-6b5e-4ae3-8324-f8cd95dbaef3"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("48097932-e268-43fb-9e39-1dfe40ab1620"), "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("a58df3e0-2d4d-4124-9990-8ca6d930c241"), "COORDINADOR DE MEDIOS ALTERNATIVOS" },
                    { new Guid("28409eeb-104b-47df-9fa0-d3217886c247"), "COORDINADOR GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("ff52b028-e91a-4ec3-b407-c28edb7c5391"), "COORDINADOR GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("8b74cc38-c0f1-450b-bea9-2a7e3295c2eb"), "COORDINADOR GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("48f3fadd-1508-4f31-9383-53c7ca5a5346"), "COORDINADOR GENERAL DE INVESTIGACION" },
                    { new Guid("dac27498-9d86-4196-adef-8311e24d1aec"), "COORDINADOR GENERAL DE LITIGACION" },
                    { new Guid("bfffe331-abbe-4742-b71f-810f43e2d798"), "COORDINADOR GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("a4ae229d-36c9-4095-89ce-135b38a0f1fa"), "COORDINADOR GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("77af20f3-d48c-4f7b-adaa-74a35797cc6e"), "COORDINADOR INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("62133114-2fa7-4ea9-a3ae-4eb1e2a7eb05"), "COORDINADOR(A) DE MEDIOS ALTERNATIVOS" },
                    { new Guid("1f3c0415-c148-45a5-86a3-5c2c33bc38a2"), "COORDINADORA DE INVESTIGACION" },
                    { new Guid("0e06a1f1-7b84-4aed-aad1-aae581a415b9"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("6c9cab3c-cafa-4525-8765-c7be1c71e7a2"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN ASUNTOS INTERNOS" },
                    { new Guid("766ad9f3-10dc-4df2-905c-05fa96f64233"), "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("9f6b4a71-c59b-44bc-a9f7-bbf68ce448cc"), "COORDINADORA DE INVESTIGACION, ENCARGADA DEL DESPACHO DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("11aa1204-6cbc-4d6d-ab0c-b9082310d046"), "COORDINADORA DE LITIGACION" },
                    { new Guid("01e70220-a3ef-4c8e-a0df-6fc8bf40f062"), "COORDINADORA DE LITIGACION DE LA FISCALIA DE INVESTIGACION METROPOLINATA " },
                    { new Guid("63448169-d24c-43b2-8012-bce9bd81ba73"), "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("30001459-aab0-4c6f-b7cc-b6d758ae3b5a"), "COMANDANTE, ENCARGADO DE DESPACHO DE LA DIRECCION DE INVESTIGACION DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("86c0688b-3bf3-47af-b3c6-e1bbc2bbd367"), "COMANDANTE MINISTERIAL, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("9b54e77a-0aad-4d40-a6f6-769075bffd2d"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPCHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("184aa5ad-2201-4458-8916-8c7cb7688e5d"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("ae6f888f-a3c3-4dc6-a36d-9014acacd162"), "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("9a694e5a-d4aa-41de-818f-a916f4f0a47d"), "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE SAN PEDRO CHOLULA)" },
                    { new Guid("aa32ac89-9b43-48e6-88af-18b1ec2ac0fa"), "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE TEHUACAN)" },
                    { new Guid("5040fa04-5492-4f84-aa6b-ae150fcd14b7"), "AGENTE INVESTIGADOR (ENCARGADO DE APOYO POLICIAL DE SAN ANDRES CHOLULA)" },
                    { new Guid("4694b457-6ef2-4963-ae78-ff7e59b198b8"), "AGENTE INVESTIGADOR (ENCARGADO DEL DESPACHO DE LA DIRECCION DE INTERVENCION INMEDIATA)" },
                    { new Guid("53d194e7-48d2-4eab-9e4d-dc76d50587e0"), "AGENTE INVESTIGADOR(ENCARGADO DE APOYO POLICIAL DE CUAUTLANCINGO)" },
                    { new Guid("6a2e9821-91b9-4288-88de-b34f2bb99d9a"), "AGENTE INVESTIGADOR, ENCARGADA DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("0a7a3893-e6a1-4877-b46b-2e182c6f8489"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("96917de1-28e2-43d4-b835-4b2dd1092dba"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("94aa3a6a-edc9-4474-8f9a-6df79360e01a"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("5881b348-068f-42ee-8777-74b5a0c30c51"), "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5e5ecc06-7eb4-4285-a6e6-2b364e59d8df"), "AGENTE INVESTIGADOR, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("4d60047d-f909-4d07-a580-ba8ead2b194f"), "AGENTE MINISTERIAL" },
                    { new Guid("bd1f7545-2c2c-42b8-b0cb-25d7c99c29e6"), "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("74979f8d-97c6-46fe-8149-ec508e22e73d"), "ANALISTA" },
                    { new Guid("a18fa257-fa4e-405e-a712-3b5f78250cfd"), "ANALISTA DE INFORMACION" },
                    { new Guid("16c6cee1-5f83-4a8f-842f-14fd9076c65c"), "ASESOR ESPECIAL" },
                    { new Guid("f1e6482f-9cf9-433b-8b30-047edf19467b"), "ASESOR TECNICO" },
                    { new Guid("fc7cb1e0-a22b-411a-8da9-335b74606583"), "ASESOR TECNICO, RESPONSABLE DEL AREA NORMATIVA DE LA DIRECCION CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("54101122-6e91-42a3-a458-3d4d6156d35f"), "AUXILIAR" },
                    { new Guid("7ca27770-d11b-432d-89cf-53c905d520a2"), "AUXILIAR DE FACILITADOR" },
                    { new Guid("0c8b53be-d105-43a5-a316-fb078427f91f"), "AUXILIAR DEL MINISTERIO PUBLICO" },
                    { new Guid("27ec76fb-1551-4b0e-b8ec-0d8858c16cb4"), "COMANDANTE MINISTERIAL" },
                    { new Guid("03b07bb4-dc2b-4369-afec-133bba26da3d"), "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE AMOZOC)" },
                    { new Guid("9167fc65-0416-4837-91f2-ddbd8a0c55ef"), "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE SAN MARTIN TEXMELUCAN)" },
                    { new Guid("35b34c2c-484b-4d80-82eb-ce99a3424eac"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("4ccb61b9-5693-408a-8aa0-66cf1a284552"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("cae3c364-b530-4e2b-b65a-1a1b7fc965c6"), "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("d8dfd562-cf8a-41e6-a572-2f29b4c5de58"), "ANALISTA " },
                    { new Guid("34c2b5ab-f1db-4183-92c8-561e18539f21"), "COORDINADORA DE MEDIOS ALTERNATIVOS DEL AREA DE LA REGION PONIENTE" },
                    { new Guid("593c34fc-af4d-443e-a583-f2038a971e63"), "AGENTE INVESTIGADOR" },
                    { new Guid("b91392e9-cf6a-4738-996c-e0968d587942"), "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("4aaf1b68-81d7-4490-9d41-0d78f88d69e9"), "DIRECTORA DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL DE LA COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("8ecf1984-75de-475a-8fd2-b92fc5a98736"), "DIRECTORA DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("e2eb4f41-676c-40e9-9213-0bacfaf1e55a"), "DIRECTORA DE SUPERVISION TECNICA DE LA VISITADURIA GENERAL" },
                    { new Guid("8cc11e9f-a13e-420a-a17c-c3c8a7ac0f5b"), "DIRECTORA GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" },
                    { new Guid("dddaa1d9-e5fd-48ec-9298-0e32c4095e7f"), "DIRECTORA REGIONAL DE INVESTIGACION DE LA COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("c4bae6f4-eb77-4bc9-953a-e47a967d052b"), "ENCARGADA DE DESPACHO DE LA DIRECCION DE PLANEACION, PROGRAMACION, EVALUACION Y ORGANIZACION" },
                    { new Guid("7af398cd-7fb4-4328-ad78-4f0287482fc2"), "ENCARGADA DE DESPACHO DE LA DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" },
                    { new Guid("52f954be-d31f-4cd2-8ff5-ab5823fe67f8"), "ENCARGADA DE DESPACHO DE LA SUBDIRECCION DE PROYECTOS DE INVERSION Y BIENES MUEBLES E INMUEBLES" },
                    { new Guid("5f8ec1d8-4242-4da6-847c-5f20572d5288"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION (TEZIUTLAN)" },
                    { new Guid("934952f3-4c28-492c-be97-8630a65e2792"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("d28415b1-bfb9-4eb8-90d4-6e35bc1b55c7"), "ENCARGADA DE DESPACHO DE LA UNIDAD DE SERVICIOS PERICIALES" },
                    { new Guid("8d744475-c50d-40c8-8d3e-91c1a5462994"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE FLAGRANCIA (HUAUCHINANGO)" },
                    { new Guid("10301d51-7922-4e23-b7e1-f847c2cde3d1"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE NARCOMENUDEO" },
                    { new Guid("261a4c97-0e35-4353-bd7d-ad1c5e061ae5"), "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN TRATA DE PERSONAS" },
                    { new Guid("bcea2722-432e-43d3-8040-46cb88669680"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA DE COMBATE AL SECUESTRO" },
                    { new Guid("88c72324-a50c-4716-8e07-54c8d8017c2c"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" },
                    { new Guid("5f4505f6-5f42-4c5d-85b6-597d4c604932"), "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" },
                    { new Guid("2a04734c-c58f-4fc8-819a-ff8b326ae094"), "ENCARGADO DE LA FISCALIA DE ZONA REGIONAL SUR (IZUCAR DE MATAMOROS)" },
                    { new Guid("cbb7161f-c5cc-4f08-b35b-646413c1968f"), "ENCARGADO DEL DESPACHO DE LA SUBDIRECCION DE DESARROLLO ADMINISTRATIVO Y PLANEACION" },
                    { new Guid("ba50798e-399f-4343-b52b-f7b53993bbee"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" },
                    { new Guid("3c3f3bdd-6d70-47aa-86f1-44e42570f616"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE PROVEEDURIA" }
                });

            migrationBuilder.InsertData(
                table: "Cargo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d851fe2c-ca9f-4aa0-9bd2-59e3c8610962"), "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE SINIESTROS" },
                    { new Guid("70069f7b-fee1-4a13-aae5-da74666a9369"), "ENCRGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" },
                    { new Guid("d4d8e18f-bea0-4547-b60b-767ab94a9f6f"), "ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("821d8509-c900-49ec-878e-ebd255174c37"), "ENLACE DE APOYO ADSMINISTRATIVO Y BIENES ASEGURADOS" },
                    { new Guid("8826d959-338d-47d7-965b-4017d6d386d1"), "ENLACE DE APOYO JURIDICO (PENDIENTE OFICIO)" },
                    { new Guid("2ecaa075-e4e7-48e2-a8b9-0ddebeca2412"), "COORDINADORA GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("b62ac4e9-48a7-400f-8ab7-d093b40641e5"), "DIRECTORA DE RESPONSABILIDADES" },
                    { new Guid("cbc1e1c7-fd36-48dd-9ef6-172f866be596"), "DIRECTORA DE PROFESIONALIZACION" },
                    { new Guid("31272963-6362-4bd7-a3d8-a0567eeadb87"), "ENCARGADO DE DESPACHO DE DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" },
                    { new Guid("38651a2e-4fa8-4ec8-9ab7-c6ce5afa82d0"), "DIRECTORA DE LO CONTENCIOSO" },
                    { new Guid("966e6431-5c8c-44c7-a80b-191c4a8715ef"), "DIRECTORA DE OPERACION DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("b6dcca3f-5e8e-4fb6-9fc6-466a61b2d5d7"), "DIRECTOR DE APOYO Y LOGISTICA ADMINISTRATIVA DE LE VISITADURIA GENERAL" },
                    { new Guid("fa627a73-0bd4-418a-8dac-8709b7566cf0"), "DIRECTOR DE AREA" },
                    { new Guid("e77721de-2182-47e8-ba54-080a1b533adf"), "DIRECTOR DE ASUNTOS INDIGENAS" },
                    { new Guid("360b1252-f739-4445-a6b4-98d7016adc1f"), "DIRECTOR DE ATENCION A MANDAMIENTOS MINISTERIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("5ab2e92a-a6df-4001-a357-33151dfbc900"), "DIRECTOR DE ATENCION CIUDADANA DE LA COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("626af01f-6af9-41f8-8f9f-a98e6cb314d3"), "DIRECTOR DE BIENES ASEGURADOS" },
                    { new Guid("28de3497-d7ad-4d03-ac17-14aa806a2762"), "DIRECTOR DE CALIDAD" },
                    { new Guid("6eccb3d8-5907-4831-a59e-44aa7d18fb50"), "DIRECTOR DE DESARROLLO FINANCIERO Y PRESUPUESTAL" },
                    { new Guid("6d4b9970-47e6-42ea-9462-03cf99e2784b"), "DIRECTOR DE INFORMACION" },
                    { new Guid("ecdd7e59-084d-4372-a850-925cf303e780"), "DIRECTOR DE INVESTIGACION DE LA VISITADURIA GENERAL" },
                    { new Guid("c2a6c1c1-f9a5-43e7-8ec6-d1142c823a46"), "DIRECTOR DE MANDAMINETOS JUDICIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("19d94a22-f666-42e4-aa54-aae5f30d1d21"), "DIRECTOR DE SEGURIDAD A SERVIDORES PUBLICOS, INSTALACIONES Y EVENTOS" },
                    { new Guid("ad0ceb1f-504a-4420-a629-c9516d5e4267"), "DIRECTOR DE SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("b95959c9-3143-4906-90dd-52a8d2e5976d"), "DIRECTOR DE COLABORACION DE LA AGENCCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("410c0b79-4761-4a61-9aa0-d8d0e3bccac2"), "COORDINADORA GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("b6a8963e-7062-4833-84e9-b37a68b24fbf"), "DIRECTOR DE TECNOLOGIA" },
                    { new Guid("e6702c15-b81d-4560-9a87-810d3939f5bd"), "DIRECTORA DE GESTION DOCUMENTAL" },
                    { new Guid("222f8817-a919-42da-8efd-782f487d5bde"), "DIRECTORA DE CRIMINALISTICA" },
                    { new Guid("fdc3bd62-b5a3-4732-bed3-df0d78817339"), "DIRECTORA DE COMUNICACION SOCIAL" },
                    { new Guid("177313bd-de66-4d2f-9e63-32c8eb69d209"), "DIRECTORA DE APOYO Y LOGISTICA ADMINISTRATIVA DE LA AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("cbd08941-8071-4587-8634-b16b7745ad2f"), "DIRECTORA DE APOYO TECNICO OPERATIVO" },
                    { new Guid("619b37d0-c307-4745-a038-daf0700f9ffa"), "DIRECTORA DE LABORATORIOS" },
                    { new Guid("da5bf6f4-3c0a-4522-9981-70659d986949"), "DIRECTORA DE ADMINISTRACION" },
                    { new Guid("f669d723-a983-4c94-ba77-39d1363c7037"), "DIRECTORA CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("f0a6f8c3-e476-45ad-ba26-0e4b1acff615"), "DIRECTOR GENERAL DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("8ae094bc-2d78-4d3f-85ca-704db06c6f00"), "DIRECTOR GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("7fcd5229-71c2-4f71-894f-9e5653d0969d"), "DIRECTOR GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("ac53ffd6-1e6e-4ff5-82c1-93bcf64ca0c3"), "DIRECTORA DE APOYO A LA INVESTIGACION" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("b49f48d6-f6e2-4cf8-bad1-2d9dd97ed53c"), "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL" },
                    { new Guid("fa84b0ce-4718-40dc-a7f0-6c3d43b96a63"), "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO" },
                    { new Guid("a50efc22-a215-48c7-b998-d833591a70ef"), "UNIDAD DE INVESTIGACION CUAUTLANCINGO" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("8b528d78-1eff-4f6c-92f6-2f591a2890e8"), "UNIDAD DE INVESTIGACION CORONANGO" },
                    { new Guid("590193fa-dbff-419a-8f1c-34cebdb2e0d2"), "UNIDAD DE INVESTIGACION CIUDAD SERDAN" },
                    { new Guid("559c527b-fb7d-4309-8abb-b5937e84dae6"), "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA" },
                    { new Guid("d6960afd-f704-4784-be6c-9babc8b01e53"), "UNIDAD DE INVESTIGACION CHIETLA" },
                    { new Guid("09e578c5-4254-4331-9d04-31d78e472d24"), "UNIDAD DE INVESTIGACION CALPAN" },
                    { new Guid("9d4fdf2f-07b3-403a-a480-12aa4865af36"), "UNIDAD DE INVESTIGACION ATLIXCO" },
                    { new Guid("0bb5107d-2675-4e22-9bd5-d1f1ce190b2f"), "UNIDAD DE INVESTIGACION ATENCINGO" },
                    { new Guid("061ae677-a443-4268-91a5-fb14abb3c0de"), "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL" },
                    { new Guid("1f69ef84-bd7b-424a-aa2e-c73311003c7e"), "UNIDAD DE INVESTIGACION CHIGNAHUAPAN" },
                    { new Guid("7252d7c0-8cc2-4f01-8804-cb69cf2d8768"), "UNIDAD DE INVESTIGACION ESPERANZA" },
                    { new Guid("6ece0abc-b326-4d03-b73f-bad9dc6717b9"), "UNIDAD DE INVESTIGACION SAN MARTIN TEXMELUCAN" },
                    { new Guid("52d88fe5-751f-4b06-a7b4-a1d76a61ebd5"), "UNIDAD DE INVESTIGACION HUAUCHINANGO" },
                    { new Guid("65057b85-64c2-477f-bf19-71f45ef93d04"), "UNIDAD DE INVESTIGACION HUEJOTZINGO" },
                    { new Guid("964b286a-42fc-40fd-9eaf-b35bc29b297d"), "UNIDAD DE INVESTIGACION HUEYTAMALCO" },
                    { new Guid("c278df06-8caf-4ae3-93f6-2348ac224635"), "UNIDAD DE INVESTIGACION IZUCAR DE MATAMOROS" },
                    { new Guid("8108e8d4-65a8-48a5-97b2-0a4f737e8fa8"), "UNIDAD DE INVESTIGACION JUAN C. BONILLA" },
                    { new Guid("a0931e91-e5b4-426d-995f-7bc2b27696f1"), "UNIDAD DE INVESTIGACION LIBRES" },
                    { new Guid("2833c2d0-9fc6-45ff-a526-f4f96c914e4f"), "UNIDAD DE INVESTIGACION METLALTOYUCA" },
                    { new Guid("646e2888-04ed-4477-926d-b3219c33615b"), "UNIDAD DE INVESTIGACION ORIENTAL" },
                    { new Guid("0ed848e5-f85c-4dd3-add3-4f9133311bcd"), "UNIDAD DE INVESTIGACION PALMAR DE BRAVO" },
                    { new Guid("c8c74d78-66e0-495d-a487-889dc261c729"), "UNIDAD DE INVESTIGACION PUEBLA" },
                    { new Guid("57e1b0ca-fe6f-4a77-9464-2e6c0769f448"), "UNIDAD DE INVESTIGACION SAN ANDRES CHOLULA" },
                    { new Guid("ec29dde9-674a-475b-b52b-2481507775a4"), "UNIDAD DE INVESTIGACION SAN JOSE CHIAPA" },
                    { new Guid("5b3759ce-2699-46ea-bbf0-7c2fe967f68e"), "UNIDAD DE INVESTIGACION ATEMPAN" },
                    { new Guid("f6ee43a7-0bf8-484f-a026-308b369728d1"), "UNIDAD DE INVESTIGACION GUADALUPE VICTORIA" },
                    { new Guid("0ad23e72-3b3c-4e2b-9b43-8e9b0f5dddab"), "UNIDAD DE INVESTIGACION ARCO ALTEPEXI" },
                    { new Guid("5e252a0c-b26b-490b-8307-42f0d3bf0ee3"), "SUBDIRECCION ACADEMICA" },
                    { new Guid("1aa0ada5-9476-4436-8f70-c58e641ae266"), "UNIDAD DE INVESTIGACION AJALPAN" },
                    { new Guid("273c5e41-bd3e-41e2-a735-3be0df7b19e8"), "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA" },
                    { new Guid("64a761af-fc93-4e89-a6b0-14cfd4e89f52"), "SUBDIRECCION DE CONTABILIDAD" },
                    { new Guid("4042a56b-a0f5-4d70-ac58-ba1d3eea92d4"), "SUBDIRECCION DE CONTROL VEHICULAR Y GESTION ADMINISTRATIVA DE ARMAMENTO" },
                    { new Guid("271cd6f4-c9b5-4e23-bee2-961825581fdd"), "SUBDIRECCION DE CRIMINALISTICA" },
                    { new Guid("61b8c741-30b9-4922-8849-f76e75a35924"), "SUBDIRECCION DE FONDOS Y POLITICA PRESUPUESTAL" },
                    { new Guid("40ef13a0-a403-47eb-99ed-cbbfddc14b7e"), "SUBDIRECCION DE GLOSA DE GASTO CORRIENTE E INVERSION" },
                    { new Guid("3425312a-1cf6-46d9-93b4-4fd8f08546f7"), "SUBDIRECCION DE PROFESIONALIZACION" },
                    { new Guid("ca19893b-40ec-4e64-8bae-5fe1c806e661"), "SUBDIRECCION DE PROYECTOS DE INVERSION Y OBRA" },
                    { new Guid("f1e36322-0ebd-4bb4-a48c-b82a0bd82851"), "SUBDIRECCION DE RECEPCION Y DESPACHO DOCUMENTAL" },
                    { new Guid("90e7cae6-2737-488d-9e0a-2705381cd94b"), "SUBDIRECCION DE RECLUTAMIENTO Y SELECCION" },
                    { new Guid("23d08ff4-081d-4087-b058-607cac2c6f71"), "SUBDIRECCION DE RECURSOS MATERIALES" },
                    { new Guid("f00d62b4-cba1-42ff-a6e9-e02a20cc7378"), "SUBDIRECCION DE SEGUIMIENTO AL SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("9c8ad774-4c3f-4007-80d9-81119113da69"), "SUBDIRECCION DE SERVICIO CIVIL DE CARRERA POLICIAL" },
                    { new Guid("080a04dd-17a3-4e64-9b95-c927622d6b55"), "UNIDAD DE INVESTIGACION AMOZOC" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("6b78a988-6178-4975-b185-5398b39298a1"), "SUBDIRECCION DE SERVICIOS PERSONALES" },
                    { new Guid("31901775-40a9-47b6-be93-b71405886737"), "SUBDIRECCION DE TESORERIA" },
                    { new Guid("604c02b2-a9b7-41d6-a554-6fdf24473727"), "SUBDIRECCION DEL DEPARTAMENTO TECNICO" },
                    { new Guid("5f13706d-6951-4e9d-9038-75b8f44af40a"), "UNIDAD COORDINADORA DE ARCHIVO" },
                    { new Guid("f2c2b4d4-0758-4674-bd31-853f49b084d5"), "UNIDAD DE ANALISIS Y CONTEXTO" },
                    { new Guid("9f823392-956c-4a30-997f-2d5a8c2f138b"), "UNIDAD DE APOYO PERICIAL" },
                    { new Guid("ad389f36-c2ec-49e1-a986-0245364fa9cd"), "UNIDAD DE APOYO POLICIAL" },
                    { new Guid("f51c89b7-a52b-47b2-993b-78b6659d3ce8"), "UNIDAD DE DERECHOS HUMANOS" },
                    { new Guid("8b8c8b80-9366-4ff6-abe6-45ca74a74307"), "UNIDAD DE INVESTIGACION" },
                    { new Guid("9b341049-dda6-4371-b944-029f12a31999"), "UNIDAD DE INVESTIGACION ACAJETE" },
                    { new Guid("50fc4491-2f92-439e-a24a-dfab03be0831"), "UNIDAD DE INVESTIGACION ACATENO" },
                    { new Guid("46899891-2ac0-4fcc-9ee2-df196b231990"), "UNIDAD DE INVESTIGACION ACATLAN" },
                    { new Guid("f87e04f2-f8fb-483e-a5ac-7e253a13b383"), "UNIDAD DE INVESTIGACION ACATZINGO" },
                    { new Guid("a7959698-67dd-486a-9d51-64e0cf62fc35"), "UNIDAD DE INVESTIGACION AHUAZOTEPEC" },
                    { new Guid("ddd58013-6fd7-49ce-9238-678f52514f71"), "SUBDIRECCION DE SUMINISTROS" },
                    { new Guid("b80a22e6-2f02-469f-a828-d970019b8b9c"), "UNIDAD DE INVESTIGACION SAN SALVADOR EL SECO" },
                    { new Guid("dadb6c78-8735-41ca-a82f-3d248c9f3456"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ASUNTOS INDIGENAS" },
                    { new Guid("5088ae63-9898-4611-9e21-1da84f712788"), "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN" },
                    { new Guid("781fe163-23e8-49d2-a76b-a6c2f9f6021c"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL" },
                    { new Guid("7db82bef-2bfb-4355-b3f2-bf07cd0ded6f"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LOS ANIMALES" },
                    { new Guid("9a087b39-c5bc-4f40-b6c5-81de11182da4"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("7dd4ef95-6463-4b70-89d3-37bbb3a2c573"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES" },
                    { new Guid("abfcd1f4-cf1c-448f-95fb-dd660ed8cb15"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE VIOLACION DE SECRETOS; DE RESPONSABILIDAD PROFESIONAL; DE DELITOS DE FALSEDAD, Y DELITOS POR INFRACCIONES A LAS LEYES Y REGLAMENTOS SOBRE INHUMACIONES Y EXHUMACIONES" },
                    { new Guid("a5518678-d092-4efd-a7ca-b01a050923d6"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE EXTORSION" },
                    { new Guid("b49f3210-a4e6-45f9-85cb-b520957c0103"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS" },
                    { new Guid("b015c6cd-e8d9-40d8-aa88-172b2d921483"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE SECUESTRO" },
                    { new Guid("2e953c83-3edb-4be0-a106-21d36301af92"), "UNIDAD ESPECIALIZADA DE INVESTIGACION EN PRIVACION ILEGAL DE LA LIBERTAD" },
                    { new Guid("c949ff63-6cab-498d-a90a-feb861f087bf"), "UNIDAD ESPECIALIZADA DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE FRAUDE Y ABUSO DE CONFIANZA" },
                    { new Guid("75f12d03-a5ea-479b-bf6b-c386dedf6936"), "UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES" },
                    { new Guid("b01a0f03-59b0-42b9-8286-39b18e0c54ea"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" },
                    { new Guid("3b724b8c-d50c-40d4-9c39-ef04cdefebe7"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LA FAMILIA" },
                    { new Guid("a91d0881-0e6c-402e-942e-077a90b72e6e"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LOS ANIMALES" },
                    { new Guid("16f2ccf0-9ffc-4972-846b-57798b8cfe35"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ABANDONO DE PERSONAS E INCUMPLIMIENTO DE OBLIGACION ALIMENTARIA" },
                    { new Guid("d5b48945-a8f3-4756-b3e1-e2f42e5263d6"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("86a4d630-ad11-4aec-a50d-fec3dfdbd866"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" },
                    { new Guid("d239099d-db3f-433d-af49-61a50c370ad5"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE FEMINICIDIOS" },
                    { new Guid("cc62c36a-404a-4f0a-bb30-daa227162b38"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE NARCOMENUDEO" },
                    { new Guid("af0804ec-dbcf-41c5-acbe-c9d6992b22bb"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A CASA HABITACION" },
                    { new Guid("8e74173f-b747-4fa4-ba66-1f80d170966b"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" },
                    { new Guid("f128b75e-079c-4ac7-bc1e-0b3884c2831f"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" },
                    { new Guid("8eb9baae-845e-4fa9-bb3f-2dcd0ccdc74e"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" },
                    { new Guid("82f7d3c6-79dc-4f90-8e0d-15be50ee2c6e"), "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("3ee7acf0-49ff-457a-be47-8535abde541e"), "UNIDAD METROPOLITANA DE INVESTIGACION Y LITIGACION DE DELITOS ELECTORALES" },
                    { new Guid("20fe1a61-e197-4dad-9883-fdabda526f35"), "UNIDAD RESOLUTORA" },
                    { new Guid("a5696d9d-1881-4cf2-920b-2cd085157448"), "VISITADURIA GENERAL" },
                    { new Guid("38c4ce35-2fba-42dc-a598-ff8a1821c66f"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS" },
                    { new Guid("d58d0232-5433-4107-b819-89655e29aaa4"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD PUBLICA; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA; CONTRA LA SEGURIDAD COLECTIVA; CONTRA LA AUTORIDAD, Y EL DELITO DE ATAQUES PELIGROSOS" },
                    { new Guid("1f5730cd-527c-414e-8da2-5ae3546c2d87"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS COMETIDOS CONTRA PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" },
                    { new Guid("306ed62a-bbb9-4f75-bc69-aeea0f3d3dde"), "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS AMBIENTALES" },
                    { new Guid("b971a047-978b-4619-9558-a9aa2fb61649"), "UNIDAD DE INVESTIGACION TECALI DE HERRERA" },
                    { new Guid("07a86883-d8a2-4bab-847b-deada8173075"), "UNIDAD DE INVESTIGACION TECAMACHALCO" },
                    { new Guid("c03fceb1-fdbd-4d04-b042-39641218d680"), "UNIDAD DE INVESTIGACION TEHUACAN " },
                    { new Guid("b9585698-a19b-446a-8c5f-5e6e511a331d"), "UNIDAD DE INVESTIGACION TEHUITZINGO" },
                    { new Guid("0aa7c9d3-32d3-4eac-a278-630f177434ed"), "UNIDAD DE INVESTIGACION TEPANCO DE LOPEZ" },
                    { new Guid("52c65165-2e63-4735-ba2c-7ef5eccb2e6f"), "UNIDAD DE INVESTIGACION TEPATLAXCO DE HIDALGO " },
                    { new Guid("a88dd458-2593-4761-8b19-db57c5bf088c"), "UNIDAD DE INVESTIGACION TEPEACA" },
                    { new Guid("b167bc0e-2b8f-471a-81b6-3de89577d35e"), "UNIDAD DE INVESTIGACION TEPEOJUMA" },
                    { new Guid("91506cde-e85b-47cc-9ee3-f0cad01f1c78"), "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ" },
                    { new Guid("0396f6fc-98a0-46f7-8c33-e0967614940a"), "UNIDAD DE INVESTIGACION TEPEYAHUALCO" },
                    { new Guid("0df254fc-84d9-424f-b0fb-60339b00b157"), "UNIDAD DE INVESTIGACION TETELA DE OCAMPO" },
                    { new Guid("9067db97-1f46-4280-ab3d-e8f8117c9538"), "UNIDAD DE INVESTIGACION TEZIUTLAN" },
                    { new Guid("7dc91ecf-b7df-4221-97c9-054a98acc044"), "UNIDAD DE INVESTIGACION TLACOTEPEC DE BENITO JUAREZ" },
                    { new Guid("97ff2834-00af-4cd4-914c-5937eccab1cf"), "UNIDAD DE INVESTIGACION SANTA CLARA OCOYUCAN" },
                    { new Guid("10cb1e14-9e1a-4a86-9e8f-dd14f0aaff83"), "UNIDAD DE INVESTIGACION TLAHUAPAN" },
                    { new Guid("aa09c79f-8512-47ae-b1d1-c22a631ae31b"), "UNIDAD DE INVESTIGACION TLAPANALA" },
                    { new Guid("ff7bfa57-2246-4a72-9156-23c0e1f37e3d"), "UNIDAD DE INVESTIGACION TLATLAUQUITEPEC" },
                    { new Guid("037b9479-d1bf-4ba8-8cd6-9e89cfd391cb"), "UNIDAD DE INVESTIGACION XICOTEPEC" },
                    { new Guid("abb2f006-3702-4d58-88a1-3cc9e6100d56"), "UNIDAD DE INVESTIGACION Y LITIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA" },
                    { new Guid("1fb0ccfe-7174-4f44-be18-b332db3b5229"), "UNIDAD DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE ABUSO DE CONFIANZA Y FRAUDE" },
                    { new Guid("49d284a2-7dc8-4a31-ae22-6e106acaf34e"), "UNIDAD DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" },
                    { new Guid("32edff8e-60f3-4206-99be-bbc7f09a9b40"), "UNIDAD DE INVESTIGACION ZACAPOAXTLA" },
                    { new Guid("ffe44e60-a6b1-448b-a753-492af3d2c81e"), "UNIDAD DE INVESTIGACION ZACATLAN" },
                    { new Guid("685e1bfd-142f-4408-8c13-702cad988c18"), "UNIDAD DE INVESTIGACION ZARAGOZA" },
                    { new Guid("d22487c3-13f5-409c-9bc2-01b7527813bc"), "UNIDAD DE INVESTIGACION ZOQUITLAN" },
                    { new Guid("826c809e-bfde-4d2b-a54d-335b74c0f6ba"), "UNIDAD DE SITUACION PATRIMONIAL" },
                    { new Guid("358bc209-2e8d-489e-a049-11b36b6bf522"), "UNIDAD DE SUSTANCIACION" },
                    { new Guid("75567f67-1177-432d-8f58-1fefebcc6486"), "UNIDAD DE TRANSPARENCIA" },
                    { new Guid("08d89e1e-2a85-4c16-983e-09b5347dc3e5"), "UNIDAD DE INVESTIGACION TLALTENANGO" },
                    { new Guid("b40d0254-4dd8-47bf-9b00-56f93ab2d8d3"), "SOPORTE TECNICO" },
                    { new Guid("1ffae26c-0e9f-46e6-9e10-3ea79e12d4f0"), "SUBDIRECCION DE CONTROL Y SEGUIMIENTO DOCUMENTAL" },
                    { new Guid("f111d895-8ae4-47df-8514-9730cffe1aa2"), "ORGANO INTERNO DE CONTROL" },
                    { new Guid("bc269e4f-eb0c-4db8-aec7-8eb0035833d1"), "DEPARTAMENTO DE GESTION ADMINISTRATIVA DE ARMAMENTO" },
                    { new Guid("ecdb87c9-1fd1-4279-9416-90884206d1d4"), "DEPARTAMENTO DE INCIDENCIAS" },
                    { new Guid("139c4bf5-ad10-44e1-ad67-a217ec39889f"), "DEPARTAMENTO DE INFORMACION ESTADISTICA" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("2e3ae3c1-cd26-40f4-9603-51ab73f5793d"), "DEPARTAMENTO DE INFORMACION VEHICULAR" },
                    { new Guid("241ab6a6-20dd-40a0-835e-8ea49bf1c5f4"), "DEPARTAMENTO DE INVENTARIOS" },
                    { new Guid("1e457c38-ab3b-4fa9-88b9-25974bfb2e68"), "DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" },
                    { new Guid("9886561f-7069-407e-a68a-fa7c78b220fc"), "DEPARTAMENTO DE MANUALES ADMINISTRATIVOS" },
                    { new Guid("37c3c3cd-1ec0-4fa0-b645-3ed1575a6a21"), "DEPARTAMENTO DE MONITOREO Y ANALISIS" },
                    { new Guid("d7d011f7-4c2e-4463-8e98-3c94a59173c6"), "DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" },
                    { new Guid("b2a542d9-21e9-4a89-a548-3d4aed3ff191"), "DEPARTAMENTO DE NOMINA" },
                    { new Guid("1044d758-b68e-4f43-8057-72de176f3ecc"), "DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA" },
                    { new Guid("137ec4e4-d9bd-4814-8202-92cefb8b2fef"), "DEPARTAMENTO DE PRODUCCION" },
                    { new Guid("a94f75d2-d82f-49bb-8e88-7e13211f6c61"), "DEPARTAMENTO DE PROVEEDURIA" },
                    { new Guid("b6747d6f-17a4-48ad-a15f-8e545f316329"), "DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANOS" },
                    { new Guid("5df8ba70-235a-448e-a391-c410e691167f"), "DEPARTAMENTO DE SINIESTROS" },
                    { new Guid("9dbe42a0-2149-4dbd-acc5-1f46bfcbd0d4"), "DEPARTAMENTO DE SOPORTE TECNICO" },
                    { new Guid("a8937f35-bd05-4b24-a676-62d9445fe821"), "DEPARTAMENTO DE TELECOMUNICACIONES" },
                    { new Guid("7ce9cffa-9978-4deb-b77e-06773772daaf"), "DEPARTAMENTO JURIDICO" },
                    { new Guid("a8dc6b96-798a-42a4-8bcd-0bd8a87ef5fc"), "DEPARTAMENTO TECNICO" },
                    { new Guid("3719b326-99b0-4d74-8dea-14bd4f419e74"), "DIBUJO FISONOMICO Y DESCRIPTIVO" },
                    { new Guid("03dc23df-cbec-4f62-8fc8-84789cc972dd"), "DIRECCION CONSULTIVA Y DE NORMATIVIDAD" },
                    { new Guid("207aff40-f781-44db-937a-97caa01b5a07"), "DIRECCION DE ADMINISTRACION" },
                    { new Guid("4cab08b1-7745-4670-848c-9470e72b80a3"), "DIRECCION DE APOYO TECNICO OPERATIVO" },
                    { new Guid("b52da29c-7738-43be-84e2-ec1527e9df8c"), "DIRECCION DE APOYO Y LOGISTICA ADMINISTRATIVA" },
                    { new Guid("76c477aa-f9cf-4606-81c8-731687634314"), "DIRECCION DE ATENCION A MANDAMIENTOS JUDICIALES" },
                    { new Guid("0938d321-bcaa-428c-8eaa-14e7d354d2e5"), "DIRECCION DE ATENCION A MANDAMIENTOS MINISTERIALES" },
                    { new Guid("782416fd-eeef-42d6-9601-e027bf0cd17b"), "DIRECCION DE AUDITORIA" },
                    { new Guid("b2336993-42ee-4694-98e1-2757e937545c"), "DEPARTAMENTO DE EXPEDIENTES DE PERSONAL" },
                    { new Guid("2c174188-4853-45ed-a884-101cc0d72b09"), "DEPARTAMENTO DE DESARROLLO DE APLICACIONES" },
                    { new Guid("772a349e-edb1-485a-bc18-2670dcf8d75b"), "DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" },
                    { new Guid("885cbb8b-eba1-42ca-a97a-862360f30d4b"), "DEPARTAMENTO DE CONTROL Y ABASTECIMIENTO DE COMBUSTIBLE" },
                    { new Guid("29293f3e-a959-42f9-b3c4-03f877d44a77"), "PERSONAL PERICIAL EN MECANICA E IDENTIFICACION VEHICULAR" },
                    { new Guid("14857a0c-5726-43af-9950-7b8b85084fcc"), "AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("0ec515f8-2154-463b-8df7-de4ecbd8e338"), "ANALISIS DE DATOS" },
                    { new Guid("679bccff-7d12-499e-8803-ae991979d591"), "AREA DE ANTROPOLOGIA FORENSE" },
                    { new Guid("ed710842-48a2-4feb-9520-1a37b105e241"), "AREA DE APOYO A LA PARTICIPACION MINISTERIAL EN EJECUCION DE SANCIONES" },
                    { new Guid("a49f9d38-3401-4bae-97a0-303e3eca305f"), "AREA DE ESTOMATOLOGIA FORENSE" },
                    { new Guid("2f299335-9020-423d-bcaa-7cc9f7da00a2"), "COORDINACION DE INVESTIGACION" },
                    { new Guid("a259c350-a83e-4509-b20a-af461a1c7a64"), "COORDINACION DE LITIGACION" },
                    { new Guid("037a7ea3-76f8-4104-9c8c-f6ae6e012213"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("53b28102-e768-4f15-a61d-3added76a7d9"), "COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("1ecf0a5b-31dd-407e-ab5f-f7b785d681df"), "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("e871fd84-14f9-42f4-b315-ce28f91179a4"), "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("b6a594de-9c48-45e3-a3aa-37e8c8db2b58"), "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("9ca356ee-a17c-497a-aec3-837ba73aed31"), "DIRECCION DE BIENES ASEGURADOS" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("72937787-9da1-4935-baaf-e6c2a09f7f7b"), "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("71b9ff66-31c5-4afa-ae24-eb9797fae473"), "COORDINACION GENERAL DE LITIGACION" },
                    { new Guid("3d33f321-7b01-41c4-93c2-fe806f7193ad"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("7965570f-ca30-43a5-a1d9-be96f6cfef1b"), "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("acddd9bf-9c1f-4aaf-b041-0044bb4e9a6c"), "COORDINACION GENERAL GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("c607f860-7b53-4f7f-82ca-4d64e74d293f"), "DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" },
                    { new Guid("40bb0628-1f28-4294-ad2f-959fe8983e7b"), "DEPARTAMENTO DE AGENDA DIGITAL E IMAGEN" },
                    { new Guid("0156d640-b80c-4dbc-83ad-2261ef27ed2f"), "DEPARTAMENTO DE ALMACEN GENERAL" },
                    { new Guid("89a94fe3-3cc4-46ee-a9b6-e08ae1abe468"), "DEPARTAMENTO DE ANALISIS DE DATOS" },
                    { new Guid("94c9a231-c8b0-499e-964b-2d27859f04ea"), "DEPARTAMENTO DE APOYO TECNICO" },
                    { new Guid("243c994a-8d22-4c2c-ba85-9fe06506602b"), "DEPARTAMENTO DE BASE DE DATOS" },
                    { new Guid("28456bcb-fd5d-43c4-b228-9ff61f0387c1"), "DEPARTAMENTO DE CONTROL DE INDICIOS" },
                    { new Guid("cb13f2d3-d838-4fcd-ad79-5e3fc1d83349"), "DEPARTAMENTO DE CONTROL DE INMUEBLES" },
                    { new Guid("cc38fe74-70ea-415b-a9f8-209695911236"), "DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" },
                    { new Guid("e4ebf95a-7447-4834-8c2b-62f31b2a5ef4"), "COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("a36b19b2-6b3b-48a1-8de3-7012139aced3"), "DIRECCION DE CALIDAD" },
                    { new Guid("c88e59d7-a467-40d7-a0cd-121f706f0fef"), "DEPARTAMENTO DE CAPACITACION" },
                    { new Guid("920bc0d0-d90b-4a2f-b4cd-4bcaef5ae735"), "DIRECCION DE COLABORACION" },
                    { new Guid("838f2b17-d0c6-4a95-8a84-c1fc74a244d5"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("cc214ace-17c0-46f3-bbae-4f009d733b0c"), "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("1d8fad7e-5ffb-45e4-acba-21aaed6c8ed7"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("d240b6fc-3eda-40b8-a321-c27c65f4f992"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("00fb4066-14d7-4b67-923f-64edfb0c0ca9"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("d612a535-a2f8-4392-9c22-4fa4414bba52"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("37ed87e0-270a-4439-ac95-66eefefc8940"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" },
                    { new Guid("b368427a-6054-4953-bae8-a490d7b9ab4c"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("f5eaaa5c-84ab-4cd5-9a5b-755f3b0490a9"), "FISCALIA GENERAL DEL ESTADO" },
                    { new Guid("6073c150-4b2b-40aa-b4fd-1e5ed8852343"), "INSPECTORIA DE INVESTIGACION REGIONAL" },
                    { new Guid("fb3c83c6-e5c8-4b68-b91d-d9c3d6d3e4b4"), "INSPECTORIA REGIONAL DE ATENCION A MANDAMIENTOS JUDICIALES" },
                    { new Guid("c81b1560-a3df-4aa5-abf5-5d1a87176c28"), "INSTITUTO DE CIENCIAS FORENSES" },
                    { new Guid("a8e223ff-723f-4252-ae02-df68e9f240eb"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("49e42345-cd1d-4ea2-aada-74381adc81c2"), "LABORATORIO DE ANALISIS DE EVIDENCIA DIGITAL Y MULTIMEDIA" },
                    { new Guid("ab66ce22-1a78-475b-b01a-eb39c9c7e5bd"), "LABORATORIO DE BALISTICA" },
                    { new Guid("4fcd481b-1984-4218-8ef5-40e7d4eec2f1"), "LABORATORIO DE GENETICA FORENSE" },
                    { new Guid("b5566550-5ea4-41fb-a3b0-8ca90407b700"), "LABORATORIO DE LOFOSCOPIA" },
                    { new Guid("5cfa9394-371a-4ed1-8ba0-68c672617539"), "LABORATORIO DE QUIMICA FORENSE" },
                    { new Guid("e91d1f13-07fa-45e6-bcce-908896f07108"), "LABORATORIO DE TOXICOLOGIA FORENSE" },
                    { new Guid("349b5b67-5c44-4547-9538-0c2aa9eb9a8e"), "LABORATORIO DE VETERINARIA Y ZOOTECNIA" },
                    { new Guid("a96f42a9-7ea2-4883-adb5-06b61a7134d7"), "MEDICINA FORENSE" },
                    { new Guid("b5e6d362-28e1-4774-a8fb-8959d14809db"), "OFICIALIA MAYOR" },
                    { new Guid("7c6f5d9e-06ad-4062-bb35-98d9ea8bd3d7"), "OFICINA DE ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS" },
                    { new Guid("ec1d9727-0171-4e39-90b1-93e3c5a56780"), "OFICINA DE ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION" }
                });

            migrationBuilder.InsertData(
                table: "CentroTrabajo",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("157f5383-f7a5-4fb7-a3e0-8f448eebfe69"), "OFICINA DE ENLACE DE GESTION DOCUMENTAL" },
                    { new Guid("2e3b2256-a1be-4832-97d9-e8afee302086"), "DIRECCION DE CAPACITACION Y POLITICA CRIMINAL" },
                    { new Guid("c67577a1-881f-462d-afd9-be9dc2739e9d"), "OFICINA DEL FISCAL GENERAL" },
                    { new Guid("0c3bf90f-a529-440a-8541-9949ce59622a"), "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("c4e2a663-6e84-44ad-86bc-313793f6886a"), "FISCALIA DE ZONA SUR" },
                    { new Guid("7781c7ea-75cc-4508-9e66-0af9d8c90424"), "LABORATORIO DE DOCUMENTOS CUESTIONADOS" },
                    { new Guid("caa23ced-29b0-48e7-8d7c-8ce425f4ebdc"), "FISCALIA DE ZONA ORIENTE" },
                    { new Guid("06a92ca4-80d3-4eb7-ac95-4ac7a8824c2c"), "DIRECCION DE CRIMINALISTICA" },
                    { new Guid("9f9532cf-6664-404e-bd4a-31d3359dbd5b"), "DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL" },
                    { new Guid("c5d36bd2-4df0-4406-93c5-c6570027d748"), "FISCALIA DE ZONA PONIENTE" },
                    { new Guid("1b4e1530-776b-41c7-ae6a-cc6aed8c95ed"), "DIRECCION DE GESTION DOCUMENTAL" },
                    { new Guid("7e4e1508-6edb-49ed-8d11-4692e7620142"), "DIRECCION DE INFRAESTRUCTURA TECNOLOGICA" },
                    { new Guid("2d18e58d-b5ab-4d8c-a35d-133351ba10e8"), "DIRECCION DE INTERVENCION INMEDIATA" },
                    { new Guid("2d0b6b32-d64d-45df-8f65-b08460273e08"), "DIRECCION DE INVESTIGACION" },
                    { new Guid("7b5a7643-da0b-4851-ac43-36e1fa18970b"), "DIRECCION DE LO CONTENCIOSO" },
                    { new Guid("45bfbce8-95dc-4280-9609-753a23721268"), "DIRECCION DE OPERACION" },
                    { new Guid("d8cf8195-becc-486e-bc1b-2c26a3ce0201"), "DIRECCION DE OPERACION Y LOGISTICA" },
                    { new Guid("307a57f5-a06d-41f5-8d51-a40e919ce515"), "DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO" },
                    { new Guid("709fb7c8-efe7-4719-a69b-2e188b7edeea"), "DIRECCION DE PROCEDIMIENTOS CONSTITUCIONALES" },
                    { new Guid("f77ba83a-7ba9-45b1-87d4-6072eab942a8"), "DIRECCION DE RESPONSABILIDADES" },
                    { new Guid("f2955861-8eaf-4462-846b-7218a0e18ed8"), "DIRECCION DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL" },
                    { new Guid("7620aa22-1651-4279-9782-075b9f40c974"), "DIRECCION DE LABORATORIOS" },
                    { new Guid("7cda7e26-4bbb-444d-914f-25d7278c63d4"), "DIRECCION DE SERVICIO PROFESIONAL DE CARRERA" },
                    { new Guid("04db10b5-c70a-46a8-a217-87176395079b"), "DIRECCION DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("02c61b7a-83d7-466d-827d-bf4b568bf980"), "FISCALIA DE ZONA NORTE" },
                    { new Guid("41e1a596-4062-44bb-81d6-ff2abc6ff97a"), "DIRECCION DEL SERVICIO MEDICO FORENSE" },
                    { new Guid("120caeb7-d927-45c7-9ad5-5d2e8efa20e1"), "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL " },
                    { new Guid("fc484510-44f8-44a8-9b48-c5235a88c441"), "DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" },
                    { new Guid("5bf2874d-86f6-4efa-b3d8-1efa49d2e19a"), "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("948ad99b-28c8-4ab8-80dc-eb6d03670dfb"), "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("0742eed9-5104-41e6-9bbd-994bdd023fd4"), "FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("3775177d-6e57-4052-8c7e-b86de7e458bf"), "DIRECCION METROPOLITANA DE LITIGACION" },
                    { new Guid("9d201035-4504-4336-a71e-757fb80597f5"), "DIRECCION REGIONAL DE INVESTIGACION" },
                    { new Guid("814d8a3a-9e2d-4549-a2d2-0e311665d8f8"), "FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("874c9447-6998-4338-a6cc-81b99b80b320"), "DIRECCION DE SEGURIDAD A SERVIDORES PUBLICOS INSTALACIONES Y EVENTOS" },
                    { new Guid("866c0af6-13bc-4c7a-b487-134903e8fb91"), "DIRECCION REGIONAL DE LITIGACION" }
                });

            migrationBuilder.InsertData(
                table: "Contratacion",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("0fb4c79b-8dfd-468a-9e42-98fd742383ff"), "CONFIANZA" },
                    { new Guid("17805612-54b0-43ef-9860-6964ba543617"), "HONORARIOS" },
                    { new Guid("499c6384-159a-49b1-bb24-36f13ae9fb10"), "BASE" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("76ad67f0-eb7a-4229-a236-577f69645711"), "AV.105 PONIENTE ENTRE CALLE PUEBLA Y OAXACA COL.POPULAR CASTILLOTLA, PUEBLA,", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION LA POPULAR" },
                    { new Guid("141489d3-20eb-40f2-8a6f-c7d20c557565"), "AV. 5 DE FEBRERO NORTE SIN NUMERO COL. EL MONTERO CORONANGO, PUEBLA  COMPLEJO METROPOLITANO", new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), "UNIDAD DE INVESTIGACION CORONANGO" },
                    { new Guid("5e2df904-41e1-490c-aa33-4b1c304cbc9c"), "PRIVADA UNIVERSIDAD II SAN MARTIN ALCHICHICA, IZUCAR DE MATAMOROS,PUEBLA", new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA IZUCAR DE MATAMOROS" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("54d00327-5c52-43c1-9ad0-9acc5a938341"), "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310", new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA ZACATLAN" },
                    { new Guid("6f47f8c9-c0c0-4d2d-83fb-9375a0f628c4"), "CALLE CAMINO NACIONAL ESQUINA CON AQUILES SERDAN SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO  COMPLEJO DE SEGURIDAD", new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "UNIDAD DE INVESTIGACION CUAUTLANCINGO" },
                    { new Guid("189c69b5-51fa-4dae-b6b3-c76149d03e76"), "CALLE MIGUEL ALVARADO ESQUINA CON ABASOLO S/N COLONIA CENTRO C.P. 75040 CUETZALAN PUEBLA", new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO" },
                    { new Guid("39001a4a-69a2-49e9-a020-c826b1244e8e"), "AV. 4 ORIENTE SIN NUMERO TECOAC", new Guid("96282c38-e892-4399-b814-568127e5dff1"), "UNIDAD DE INVESTIGACION EL SECO" },
                    { new Guid("6ba0096c-52ea-46b5-8180-363b167bb583"), "CALLE 12 NORTE SEGUNDA SECCION 22, ESPERANZA, PUE.", new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), "UNIDAD DE INVESTIGACION ESPERANZA" },
                    { new Guid("fbea9995-eeae-4c4c-947c-51168cac8272"), "CALLE JUAREZ SUR S/N COL. YALU LOCALUDAD PUTAX-EAT, HUEHUETLA, PUE.", new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), "UNIDAD DE INVESTIGACION HUEHUETLA" },
                    { new Guid("1df5ac02-a63a-477b-8e06-5fa2e39abf3e"), "PERIFERICO ECOLOGICO ARCO SUR NO. 4000, RESERVA TERRITORIAL ATLIXCAYOTL, SAN", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "UNIDAD DE INVESTIGACION CIUDAD JUDICIAL" },
                    { new Guid("6b3a3dc3-eb1f-4899-ba97-57ce94e8a7af"), "CALLE MIGUEL HIDALGO NUMERO 35 HUEYTAMALCO, PUEBLA", new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), "UNIDAD DE INVESTIGACION HUEYTAMALCO" },
                    { new Guid("14e434cb-36e8-429c-8502-8cff43f5447c"), "CALLE 5 DE MAYO S/N COLONIA CENTRO, JUAN C. BONILLA, PUE.", new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), "UNIDAD DE INVESTIGACION JUAN C BONILLA" },
                    { new Guid("ef49e1c2-c8d8-443b-ac97-f407016a6e08"), "CAMINO AL BATAN NO. 12 COL. VILLA SATELITE LA CALERA PUEBLA", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION LA MARGARITA" },
                    { new Guid("1b61ba6a-1282-4ed6-8362-7e9419e4443f"), "AVENIDA MERINO FERNANDEZ ENTRE CALLE JUAREZ Y CALLE AYUNTAMIENTO, PRESIDENCIA MUNCIAL, COL. CENTRO, LOS REYES DE JUAREZ, PUE.", new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), "UNIDAD DE INVESTIGACION LOS REYES DE JUAREZ" },
                    { new Guid("48cec3ac-4642-4c9f-940b-de9eaa564982"), "CARRETERA FEDERAL PACHUCA TUXPAN, COL. CENTRO, VILLA LAZARO CARDENAS", new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), "UNIDAD DE INVESTIGACION LAZARO CARDENAS" },
                    { new Guid("2ac1cdfa-bdbe-40c7-bc32-8d6ad64f1ba5"), "LIBRAMIENTO CHIGNAHUAPAN - ZACATLAN, KM 4.5 BARRIO TOLTEMPAN, CHIGNAHUAPAN, PUE.", new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), "UNIDAD DE INVESTIGACION CHIGNAHUAPAN" },
                    { new Guid("464488e1-a398-4dea-ad31-826a94b03e3c"), "CALLE EMILIANO ZAPATA  KM 2.5", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE IDENTIFICACION VEHICULAR" },
                    { new Guid("fc023dba-d692-45ee-8714-9d1b48afd811"), "CALLE REFORMA Y 5 NORTE COLONIA CENTRO, CHIAUTLA DE TAPIA", new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA" },
                    { new Guid("eb9d27e2-dd2f-4543-8e0e-ec0c7a94e361"), "CALLE PORFIRIO DIAZ Y DOLORES PEREZ SIN NUMERO COL. CENTRO ZACATLAN, PUEBLA", new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), "SEMEFO ZACATLAN" },
                    { new Guid("ab04e890-44a2-425c-a1f2-8d3c403bcbcb"), "AVENIDA REYES GARCIA 57 COLONIA ERMITA, METLALTOYUCA, PUEBLA. CP 73000", new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), "UNIDAD DE INVESTIGACION METLALTOYUCA" },
                    { new Guid("7ae2fa67-eef9-4540-b625-8ddb7a32fabc"), "EMILIANO ZAPATA KM2.5,COL LOMAS DE SAN MIGUEL,PUEBLA,PUE. CP.: 72573", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE IDENTIFICACION VEHICULAR" },
                    { new Guid("e53d5d9b-486b-4308-8c17-2e02bd4b5cbf"), "CALLE 2 ORIENTE ENTRE CALLE 8 NORTE Y CALLE 10 ORIENTE.", new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), "UNIDAD DE INVESTIGACION ACAJETE" },
                    { new Guid("8e074fe8-23d0-4021-83a8-9b5897e73885"), "CALLE ALLENDE NO. 1 COL. CENTRO SAN JOSE ACATENO", new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), "UNIDAD DE INVESTIGACION ACATENO" },
                    { new Guid("7428a257-0814-4737-aeff-29c88320ac31"), "AV. IGNACIO ROMERO VARGAS 201 COL CENTRO CP 75150", new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), "UNIDAD DE INVESTIGACION ACATZINGO" },
                    { new Guid("0b458221-becd-49b7-b478-ae0c73d623c1"), "AV DE LAS HUERTAS 917 CUARTO BARRIO COL. CENTRO, HUEJOTZINGO, PUEBLA, CP.: 74168", new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), "UNIDAD DE INVESTIGACION ADSCRITA A JUZGADOS PENALES Y CIVILES" },
                    { new Guid("054610f3-bfd4-46e4-8e31-22f19a3c7c17"), "CALLE HIDALGO SUR S/N COL. CENTRO (DENTRO DE LA PRESIDENCIA MUNICIPAL", new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), "UNIDAD DE INVESTIGACION AHUAZOTEPEC" },
                    { new Guid("0f3ced7d-1596-422c-9a75-3f72cfbc354a"), "CALLE GUERRERO SIN NUMERO, AJALPAN PUEBLA", new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), "UNIDAD DE INVESTIGACION AJALPAN" },
                    { new Guid("210b9661-a88c-419c-92fa-1cff3645df36"), "FRANCISCO I. MADERO 109, BARRIO DE SANTIAGO, CP. 72980, AMOZOC, PUEBLA", new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), "UNIDAD DE INVESTIGACION AMOZOC" },
                    { new Guid("95cd766f-0357-4b63-a9a8-66ea27a84fda"), "02 ORIENTE SIN NUMERO, COLONIA CENTRO, ATEMPAN, PUEBLA", new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), "UNIDAD DE INVESTIGACION ATEMPAN" },
                    { new Guid("6c9d057a-6965-4219-bda2-584ba3bb5aa8"), "CALLE 5 DE FEBRERO ESQUINA MIGUEL HIDALGO COL LA CRUZ", new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), "UNIDAD DE INVESTIGACION ATENCINGO" },
                    { new Guid("438505d2-999b-44a5-be32-88129783347f"), "CALLE CONSTITUCION S/N ENTRE 16 DE SEPTIEMBRE Y DOMINGO ARENAS, PRESIDENCIA MUNICIPAL CALPAN, PUE.", new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), "UNIDAD DE INVESTIGACION CALPAN" },
                    { new Guid("5d81a5cf-8c13-46fb-918d-59136826b39e"), "9 ORIENTE NO.1405COL.CENTRO PUEBLA PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION CENTRO" },
                    { new Guid("efa3a2ce-0219-42c4-b9f0-cdea1a11dde0"), "PROLONGACION DE LA 14 SUR NUMERO 11517 COL. SAN JOSE CHAPULCO", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION CHAPULCO" },
                    { new Guid("33327808-e6fc-455f-bd73-22bc1ac2ccf7"), "CALLE RAYON NUMERO 4 COL. CENTRO", new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), "UNIDAD DE INVESTIGACION CHIETLA" },
                    { new Guid("c333a4e2-dd07-4aea-bb11-25d590812a01"), "PLAZA PRINCIPAL S/N PLANTA BAJA, PALACIO MUNICIPAL, COL. CENTRO, SANTA CLARA OCOYUCAN", new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), "UNIDAD DE INVESTIGACION OCOYUCAN" },
                    { new Guid("56a52026-ecbf-40cc-83a0-b7e62b8ce21b"), "CALLE 3 ORIENTE 1211 COLONIA SANTA ANA, ZARAGOZA, PUE.", new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), "UNIDAD DE INVESTIGACION ZARAGOZA" },
                    { new Guid("f488f977-a522-4c07-9698-d43ef7ba6e91"), "PROLONGACION 16 ORIENTE ESQ. CON LIBRAMIENTO A TEHUACAN COL. MEXICO 68", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION ORIENTE" },
                    { new Guid("b9d3db38-da85-481b-944a-633373082ed8"), "PALACION MUNICIPAL S/N TLAPANALA PUEBLA", new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), "UNIDAD DE INVESTIGACION TLAPANALA" },
                    { new Guid("5bf9b4f8-09c8-41b2-be84-669f8c33315c"), "BOULEVARD VALSEQUILLO ESQU. 20 DE NOVIEMBRE COL. SAN BALTAZAR CAMPECHE, PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION VALSEQUILLO" },
                    { new Guid("50f25f15-b89f-411f-bd4c-5ad1b4a79c8d"), "CALLE FRANCISCO I. MADERO NO. 07 COL. CENTRO, SAN PABLO XOCHIMEHUACAN", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION VILLA FRONTERA" },
                    { new Guid("4d660027-551b-4d1a-8859-8c0cacbda642"), "CALLE 21 ORIENTE NO.404, COL. EL CARMEN, PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION VIRTUAL PREDENUNCIA EL CARMEN" },
                    { new Guid("0ca58122-89b9-47dd-b9f7-7a9c48db28e5"), "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD DE INVESTIGACION VW" },
                    { new Guid("3aff1abc-7309-40a0-a7b4-307cb324bff4"), "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM", new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "UNIDAD DE INVESTIGACION VW" },
                    { new Guid("12776070-7f37-4000-89bf-7f97bdfc5f7e"), "CALLE 2 DE ABRIL 117 COLONIA CENTRO, XICOTEPEC DE JUAREZ, PUEBLA.", new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), "UNIDAD DE INVESTIGACION XICOTEPEC DE JUAREZ" },
                    { new Guid("ea5891e7-267a-47f9-8605-22c0f749fdc3"), "AV. 5 DE MAYO NO.1 EXTERIOR DE LA PRESIDENCIA MUNICIPAL, GUADALUPE VICTORIA , PUEBLA", new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), "UNIDAD DE INVESTIGACION Y MEDIOS ALTERNATIVOS" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("64429efc-2ebe-42c6-bd85-9d3210074cc1"), "CALLE 2 DE ABRIL SUR, EDIFICIO REVOLUCION ESQUINA IGNACIO COETO ,COL. CENTRO ZACAPOAXTLA PUEBLA", new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), "UNIDAD DE INVESTIGACION ZACAPOAXTLA" },
                    { new Guid("5dbcd279-f866-405f-ab9d-59ddbd147011"), "CALLE JUVENTUD S/N COL. CENTRO", new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), "UNIDAD DE INVESTIGACION ZOQUITLAN" },
                    { new Guid("55fce514-8946-49b4-9506-3d11385e76df"), "CALLE 12 ORIENTE NO. 608 COL. CENTRO ,PUEBLA, PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD ESPECIALIZADA ADSCRITA A LA FISCALIA METROPOLITANA (JUZGADOS PENALES)" },
                    { new Guid("bae9be67-391c-4909-89f7-213d6a2d017f"), "CAMINO AL BATAN KM 2.5 COL.LOMAS DE SAN MIGUEL PUEBLA,PUE. CP.: 72573", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO DE VEHICULOS (OCRA)" },
                    { new Guid("3f6bab12-2484-4ec2-a57b-c3eb5b564ed7"), "CALLE 8 ORIENTE, NUMERO 1007, COLONIA SAN FRANCISCO, PUEBLA, PUE.", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "UNIDAD INTEGRAL DE SERVICIOS EL ALTO" },
                    { new Guid("d10476c9-09f1-4595-aaf4-dfb1a092c230"), "UNIDAD MOVIL (TRANSPORTE TIPO VAN PARA USO DE FISCALIA)", new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), "UNIDAD MOVIL (TRANSPORTE TIPO VAN PARA USO DE FISCALIA)" },
                    { new Guid("907c09d4-b11e-420d-88cc-ce54498dff9b"), "CALLE 2 DE ABRIL NORTE SIN NUMERO ESQUINA FJ. ARRIAGA COL. CENTRO ZACAPOAXTLA, PUEBLA", new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), "SEMEFO ZACAPOAXTLA" },
                    { new Guid("e49d9f92-3355-40cb-bd71-1b913c009016"), "ESQUINA QUE FORMAN LAS CALLES MORELOS Y CUAUHTEMOC NUMERO 1, TLAOLA, PUEBLA", new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), "UNIDAD DE INVESTIGACION TLAOLA" },
                    { new Guid("99e905b3-3140-4cad-9d7b-cbf9cd72215e"), "AV. AYUNTAMIENTO NO. 3 COL. CENTRO CP 75020", new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), "UNIDAD DE INVESTIGACION ORIENTAL" },
                    { new Guid("afc105ec-69aa-433e-ac8c-512ad8b1e31b"), "REAL DE SAN PEDRO NO 15 COL. CENTRO, C.P.72600, TLALTENANGO, PUE.", new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), "UNIDAD DE INVESTIGACION TLALTENANGO" },
                    { new Guid("45c93253-ac00-47b7-b967-9254155a1fe6"), "7 PONIENTE #1, COLONIA CENTRO, TETELA DE OCAMPO, PUEBLA", new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), "UNIDAD DE INVESTIGACION TETELA DE OCAMPO" },
                    { new Guid("d527b0e5-55a2-466a-b87f-e4299c4f2b35"), "CALLE NICOLAS BRAVO #504 COL. CENTRO PALMAR DE BRAVO ", new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), "UNIDAD DE INVESTIGACION PALMAR DE BRAVO" },
                    { new Guid("fe7d641a-eab3-493e-a903-dbfbb70b0f8e"), "PLAZA EXPLANADA PALACIO MUNICIPAL S/N COL. CENTRO PRIMER PISO", new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), "UNIDAD DE INVESTIGACION PIAXTLA" },
                    { new Guid("37d5e2ee-137b-44c1-b250-500fcb46f633"), "AVENIDA NIÑOS HEROES SIN NUMERO COLONIA EL SOL, SAN GABRIEL CHILAC, PUEBLA", new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), "UNIDAD DE INVESTIGACION SAN GABRIEL CHILAC" },
                    { new Guid("21eb5fdf-ef14-4a57-bfdd-5dc97facc294"), "CALLE 15 NORTE SIN NUMERO, SEGUNDO PISO, SAN MATIAS COCOYOTLA, SAN PEDRO CHOLULA, PUE.", new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA" },
                    { new Guid("218cdd1f-0187-4d83-b3bf-155e6fa19c52"), "CALLE MIGUEL HIDALGO S/N COL. CENTRO 74100, SANTA RITA TLAHUAPAN, PUE.", new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), "UNIDAD DE INVESTIGACION SANTA RITA TLAHUAPAN" },
                    { new Guid("01afc650-4da8-4e2f-964b-0921d8e92b84"), "11 PONIENTE ENTRE 1 SUR Y AV. NACIONAL, SANTIAGO MIAHUATLAN, PUE.", new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN" },
                    { new Guid("8d533986-b29a-4ab7-a6ec-b309ed6b479c"), "CALLE DE HERRERA S/N COL. CENTRO, TECALI DE HERRERA, COMPLEJO DE SEGURIDAD", new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), "UNIDAD DE INVESTIGACION TECALI DE HERRERA" },
                    { new Guid("961eb405-becb-47e9-9cf5-257ba73d7c65"), "10 SUR 507, BARRIO DE SAN JOSE, TECAMACHALCO, PUEBLA", new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), "UNIDAD DE INVESTIGACION TECAMACHALCO" },
                    { new Guid("ed8318b4-bd88-401c-b66e-716afe38aa79"), "CALLE LA PRESA SECCION TERCERA, TEHUITZINGO , PUEBLA", new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), "UNIDAD DE INVESTIGACION TEHUITZINGO" },
                    { new Guid("499936a0-60f7-46b6-bd6d-12741108db1a"), "PRIV. 8 PONIENTE S/N COL. CENTRO 75800, TEPANCO DE LOPEZ, PUE.", new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), "UNIDAD DE INVESTIGACION TEPANCO" },
                    { new Guid("e72d4e7b-acf3-404a-a1fe-661cc0a022e1"), "2 SUR ESQUINA CON 9 ORIENTE S/N COL. CENTRO, TEPATLAXCO DE HIDALGO, PRIMER PISO", new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), "UNIDAD DE INVESTIGACION TEPATLAXCO" },
                    { new Guid("57e53aab-5e28-4a36-a5a3-7ef9f279c130"), "AVENIDA HIDALGO NUMERO 509 A, TEPEACA PUEBLA", new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), "UNIDAD DE INVESTIGACION TEPEACA" },
                    { new Guid("b4f96b50-317f-4e22-8ece-f6202e5c19ea"), "CALLE IRINEO VAZQUEZ, NUMERO 1, TEPEOJUMA, PUEBLA", new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), "UNIDAD DE INVESTIGACION TEPEOJUMA" },
                    { new Guid("18ebe402-bd81-4ef1-9ccf-2f43e85e8af5"), "CALLE 5 DE FEBRERO PLAZA COMUNITARIA PROF .ABEL CRUZ GARCIA , COL CENTRO, TEPEXI DE RODRIGUEZ PUEBLA", new Guid("80261179-cc03-47f8-89fe-cf001811739a"), "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ" },
                    { new Guid("662a30c4-f879-40ee-9274-08c9c73ea4b3"), "CALLE PRIMERA DE VENUSTIANO CARRANZA Y CALLE PRIMERA MORELOS S/N TEPEYAHUALCO, PUE.", new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), "UNIDAD DE INVESTIGACION TEPEYAHUALCO" },
                    { new Guid("0da231e4-9913-4069-8d6c-a2a1f108055b"), "PLAZA COMUNITARIA CALLE AGUASCALIENTES SIN NUMERO COLONIA CENTRO 75680", new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), "UNIDAD DE INVESTIGACION TLACOTEPEC" },
                    { new Guid("41a3adc9-0d37-4fd3-9d52-37a1f0253b81"), "AV. ZARAGOZA SIN NUMERO, XICOTEPEC DE JUAREZ", new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), "SEMEFO XICOTEPEC DE JUAREZ" },
                    { new Guid("b2daaab4-50c3-4610-a4fc-34a770f339ec"), "BOULEVARD EMILIANO ZAPATA SIN NUMERO, INTERIOR DEL PANTEON MUNICIPAL, CHIGNAHUAPAN,PUEBLA", new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), "SEMEFO CHIGNAHUAPAN" },
                    { new Guid("1dea035e-ae34-4781-8d49-5854708d4cd8"), "CALLE COSTADO SUR DEL PANTEON MUNICIPAL, SIN NUMERO, TEZIUTLAN, PUEBLA", new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), "SEMEFO TEZIUTLAN" },
                    { new Guid("73271645-4d1c-4f4a-af02-58be6274c89c"), "CAMINO A CATALINA S/N COLONIA EL POTRO, HUAUCHINANGO, PUEBLA CP.: 73176", new Guid("bf447292-6874-4d7e-8790-946362b43fae"), "CASA DE JUSTICIA HUAUCHINANGO" },
                    { new Guid("b9604444-4813-4b5d-b76d-7392c18f279d"), "CARRETERA FEDERAL PUEBLA-IZUCAR DE MATAMOROS NO. 2119, COL. GALARZA, IZUCAR DE MATAMOROS, PUEBLA", new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), "CASA DE JUSTICIA IZUCAR DE MATAMOROS" },
                    { new Guid("422d23cf-e65b-4bf0-b61b-c00e8fd6fbe3"), "CALLE LERDO NUMERO 988, LIBRES, PUEBLA", new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), "CASA DE JUSTICIA LIBRES" },
                    { new Guid("14c2010b-677b-402c-aa34-f3296ae8626a"), "CARRETERA IZUCAR DE MATAMOROS S/N COL. TLAXCALANCINGO, CP.: 72820", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "CASA DE JUSTICIA PARA ADOLESCENTES" },
                    { new Guid("21ffa18e-393f-4c30-9a30-55e382bf0665"), "PERIFERICO ECOLOGICO 100 SAN BERNARDINO TLAXCALANCINGO SAN ANDRES CHOLULA", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "CASA DE JUSTICIA SAN ANDRES CHOLULA" },
                    { new Guid("703a1034-f89f-4bd1-ba72-16edc7580308"), "AUTOPISTA MEXICO -PUEBLA S/N, SAL SALVADOR EL VERDE, SAN MARTIN TEXMELUCAN,", new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), "CASA DE JUSTICIA SAN MARTIN TEXMELUCAN" },
                    { new Guid("a6c8f21a-3b98-4047-8e32-3df0c5be736d"), "BOULEVARD GENERAL MORENO VALLE NO. 1604, COL. TIZAYUCA ,ATLIXCO PUE. CP.: 74200", new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), "CASA DE JUSTICIA ATLIXCO" },
                    { new Guid("14de72a4-aea4-4e61-b139-687eab6621e4"), "CARRETERA FEDERAL KM 60+490, COL.SANTIAGO ALSESECA, TECAMACHALCO, CP.: 75480", new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), "CASA DE JUSTICIA TECAMACHALCO" },
                    { new Guid("f0a98b00-3578-4ae4-9d41-0f23acbffba0"), "CALLE LA MESILLA NO.10 COL. INDUSTRIAL, TEZIUTLAN, PUEBLA. CP.: 73850", new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), "CASA DE JUSTICIA TEZIUTLAN" },
                    { new Guid("78500fc7-73ca-4146-ba67-c51f0b5b2606"), "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310", new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), "CASA DE JUSTICIA ZACATLAN" },
                    { new Guid("2ad2d44a-81f9-4adf-8a00-44268f1b17c1"), "AV. REFORMA 22 COLONIA CENTRO ENTRE EMILIANO ZAPATA Y VENUSTIANO C", new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), "CENTRO DE JUSTICIA PARA LAS MUJERES EN ACATLAN DE OSORIO" },
                    { new Guid("694935bb-752f-431c-b1ac-e4948e5915b8"), "CALLE 17 PONIENTE NO.1919, BARRIO DE SANTIAGO,PUEBLA, PUE. CP.: 72410", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "CENTRO DE JUSTICIA PARA LAS MUJERES PUEBLA" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("24e9ef97-7465-498b-a82d-fe7d0251468e"), "CALLE COMPUTENSE ESQUINA CALLE DE LA TURBINA S/N COL. UNIVERSIDADES II, TEHUACAN ,PUE. CP.: 75723", new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "CENTRO DE JUSTICIA PARA LAS MUJERES TEHUACAN" },
                    { new Guid("8a21266b-0130-4e8d-8097-f3012a895c8b"), "VIA ATLIXCAYOTL NO. 1101, EDIFICIO SUR PLANTA BAJA , CONCEPCION LAS LAJAS , PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "CENTRO INTEGRAL DE SERVICIOS ANGELOPOLIS" },
                    { new Guid("d59c29d6-c763-45b1-9939-8ae9fcef20e8"), "BLVD. ADOLFO MATEOS NO.4, PLANTA ALTA, COL. ZONA ALTA, TEHUACAN, PUEBLA CP.: 75750", new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "CASA DE JUSTICIA TEHUACAN" },
                    { new Guid("8e2007d1-cc1a-4be1-8667-f057d0df5d96"), "CARRETERA INTERNACIONAL MÉXICO -OAXACA KM152+200, BARRIO LA PALMA , ACATLÁN DE OSORIO PUEBLA", new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), "CASA DE JUSTICIA ACATLAN DE OSORIO " },
                    { new Guid("0a686c58-9c0e-4db0-9444-cde555f01414"), "REFORMA 3 ORIENTE, COL. CENTRO 74000 SAN MARTIN TEXMELUCAN, PUE.", new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), "CANACO SAN MARTIN TEXMELUCAN" },
                    { new Guid("8ac38361-c5c2-4e8c-a6af-7d02a13ff1f7"), "CARRETERA FEDERAL PUEBLA TEHUACAN 1211 O KM 114 SAN LORENZO TEOTIPILCO, TEHUACAN, PUE.", new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "C5 TEHUACAN" },
                    { new Guid("996235b7-d04e-4a8a-a906-a494ca3af685"), "AV DOLORES BETANCOURT COL. CONTLA, TLATLAUQUITEPEC, PUEBLA", new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), "SEMEFO TLATLAUQUITEPEC" },
                    { new Guid("118aaca6-1d12-4a62-af7d-0df98082cfc2"), "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE.", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("401abaf7-b298-4325-8e9a-5b1975afc4ff"), "17 SUR NUMERO 304 COLONIA BARRIO DE ANALCO", new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), "AGENCIA ESTATAL DE INVESTIGACION DE TECALI DE HERRERA" },
                    { new Guid("32320271-ec9f-4d49-90ac-76f208d781b4"), "BLVD. 18 DE MARZO NUMERO 52 COLONIA EL PARAISO", new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), "AGENCIA ESTATAL DE INVESTIGACION HUEJOTZINGO" },
                    { new Guid("9079c655-0486-4c2d-9e11-1d36245deb3f"), "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE.", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "AGENCIA ESTATAL DE INVESTIGACION PUEBLA" },
                    { new Guid("0edc808d-da15-4c0d-8d29-0d74600a270b"), "CALLE VICENTE GUERRERO NO.714 COL, MORELOS SAN MARTIN TEXMELUCAN, CP.: 74020", new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), "AGENCIA ESTATAL DE INVESTIGACION SAN MARTIN TEXMELUCAN" },
                    { new Guid("0c564c67-db2a-4e6e-b5ac-8970e8f8c949"), "CALLE JOSE GALEANA NO. 200 COLONIA DOMINGO ARENAS, SANTA RITA TLAHUAPAN", new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), "AGENCIA ESTATAL DE INVESTIGACION SANTA RITA TLAHUAPAN" },
                    { new Guid("de2850ce-4292-4dad-936c-0861fc8b5e07"), "CALLE LERDO NUMERO 205, ALTOS COL. CENTRO. ANEXO AL CERESO, TEZIUTLAN , PUEBLA", new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), "AGENCIA ESTATAL DE INVESTIGACION TEZIUTLAN" },
                    { new Guid("b4941e30-8996-4c68-a0ce-2f91034d2718"), "AV. INDEPENDENCIA NUM. 20 COL.CENTRO , TLATLAUQUITEPEC,PUEBLA", new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), "AGENCIA ESTATAL DE INVESTIGACION TLATLAUQUITEPEC" },
                    { new Guid("0a3623f2-b594-4434-87fc-668e158f84c1"), "CALLE ORQUIDEAS NO. 6141 COLONIA BUGAMBILIAS CP 72580", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "ALMACEN GENERAL" },
                    { new Guid("b6b13bcb-4fdb-4e48-b034-9489005f4e24"), "KM 19.5 CARRETERA FEDERAL PUEBLA - TEHUACAN, COLONIA SAN JOSE LAS FLORES, CP 72980, AMOZOC", new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), "ARCHIVO Y BODEGA DE INDICIOS" },
                    { new Guid("1b80e5a4-76bf-40d1-9bcf-a8fa138ea807"), "CARRETERA ESTATAL TEHUACAN TEOTITLAN OAXACA, TRAMO DE CHILACALTEPEXI, CP.: 75914", new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), "ARCO DE SEGURIDAD DE ALTEPEXI" },
                    { new Guid("5dc4b9d0-6ff1-402a-8d00-78816aa818ec"), "CARRETERA FEDERAL IZUCAR DE MATAMOROS KM61+800 IZUCAR DE MATAMOROS", new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), "ARCO DE SEGURIDAD DE IZUCAR DE MATAMOROS" },
                    { new Guid("734c27ec-4f4c-47db-8598-f8c41cc57a42"), "CARRETERA MEXICO -PUEBLA KM100+200 HUEJOTZINGO ,PUEBLA", new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), "ARCO DE SEGURIDAD HUEJOTZINGO" },
                    { new Guid("ee3e8fc4-7795-43a9-8c82-3222e66c827b"), "CARRETERA MEXICO VERACRUZ KM 166+500PALMAR DE BRAVO , PUEBLA", new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), "ARCO DE SEGURIDAD PALMAR DE BRAVO" },
                    { new Guid("35e4e36c-ca29-458d-ae13-b0801108ff22"), "CALLE AQUILES SERDAN ESQUINA CON 20 DE NOVIEMBRE SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO", new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "CENTRO INTEGRAL DE SERVICIOS CUAUTLANCINGO" },
                    { new Guid("f4d02ed2-cd7c-418e-9af2-9fc5b8ffd360"), "AV. REFORMA 1305 COL CENTRO C.P. 72000", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "CENTRO INTEGRAL DE SERVICIOS SAN JAVIER" },
                    { new Guid("3f4c7c72-5643-41d3-8095-6d1b41f2c414"), "KM.28+285 CARRETERA FEDERAL EL SECO ASUMBULLA, CD. SERDAN, PUEBLA CP.: 75520", new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), "CASA DE JUSTICIA CHALCHICOMULA DE SESMA" },
                    { new Guid("f9f7bdb4-1757-4161-be8e-373c973309f9"), "CARRETERA FEDERAL TEZIUTLAN - ACAJETE NO. 169 BARRIO DE CONTLA", new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), "CENTRO INTEGRAL DE SERVICIOS TLATLAUQUITEPEC" },
                    { new Guid("9a860a3a-cfcb-489e-8b66-68ccbc4fe7ff"), "CALLE 6 NORTE NO.1003, COL. CENTRO,PUEBLA PUE. CP.: 72000", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (BOCHAS)" },
                    { new Guid("606d1b6d-b034-4332-9dbe-a517c8196262"), "CALLE 10 ORIENTE NO.414,COL CENTRO PUEBLA,PUE. CP.: 72530", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (CPJ)" },
                    { new Guid("b82a5e81-0f09-4bff-88f2-2bef98440c36"), "3ER RETORNO OSA MENOR NO.3, RESERVA TERRITORIAL ATLIXCAYOTL ,SAN ANDRES", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("eba4eced-43dc-4325-8e65-b120db654c0a"), "PRIV. 5 B SUR NO. 3706, COL. GABRIEL PASTOR, PUEBLA, PUE CP. 72420", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "INDIGENAS PERIODISTAS LGBTTQ" },
                    { new Guid("c65da3df-92b1-4e36-a120-1fa7677f57b3"), "AV. REFORMA 2704 5° PISO COL. AMOR", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "INMUEBLE CANACINTRA" },
                    { new Guid("2c1b82e6-125b-4ec0-8437-fbf42620e181"), "DIAGONAL CUAUHTEMOC NO.3101 COL. VALLE DORADO PUEBLA,PUE. CP.: 72070", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("1dca3b9f-42c2-46a4-b001-2c0027680993"), "13 SUR 1910 BARRIO DE SANTIAGO PUEBLA PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "JUSTICIA CIUDADANA" },
                    { new Guid("faf6cdd7-e45d-4fdc-849a-4c37ec57d280"), "PROLONGACION 11 SUR 11906, COL. GUADALUPE HIDALGO", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "SEMEFO 11 SUR" },
                    { new Guid("50d4a1df-7d34-4991-8c5c-dfb726d7cb28"), "CALLE TIRZO TELLEZ SIN NUMERO COL. EL CRISTO, HUAUCCHINANGO, PUEBLA", new Guid("bf447292-6874-4d7e-8790-946362b43fae"), "SEMEFO HUAUCHINANGO" },
                    { new Guid("4c56ddec-6394-423a-82dc-c476fa6efad6"), "PANTEON MUNICIPAL, BARRIO DE SANTA CRUZ, TEXCOCO, CALLE REVOLUCION Y HERCULANO SANCHEZ", new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), "SEMEFO IZUCAR DE MATAMOROS" },
                    { new Guid("9eeb64a5-572d-4a82-8146-78d3343a2686"), "CALLE 4 ORIENTE SIN NUMERO BARRIO DE GUADALUPE", new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), "SEMEFO LIBRES" },
                    { new Guid("61fca298-cc9a-4b4b-9a76-e91a7521793f"), "A.V. GUERRERO ENTRE CALLE 31 SUR, Y CARRETERA A SAN MATEO TLAIXCAPAN", new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), "SEMEFO TECAMACHALCO" },
                    { new Guid("2c64762a-ea5c-4513-83b4-b6ae3d0e6703"), "CALLE 19 PONIENTE SIN NUMERO PANTEON MUNICIPAL, TEHUACAN PUEBLA", new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "SEMEFO TEHUACAN" },
                    { new Guid("78b2c8ec-26ed-4c94-ba19-125a63ea10ac"), "AV HIDALGO NO.169 EDIFICIO REAL PLANTA BAJA, CENTRO. TEZIUTLAN, PUEBLA.", new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), "CENTRO INTEGRAL DE SERVICIOS TEZIUTLAN" },
                    { new Guid("3815194e-8e7f-49ba-a9a3-75590030188c"), "PANTEON MUNICIPAL CALLE DEFENSORES DEL 6 DE JUNIO SIN NUMERO, TEPEXI DE RODRIGUEZ", new Guid("80261179-cc03-47f8-89fe-cf001811739a"), "SEMEFO TEPEXI DE RODRIGUEZ" },
                    { new Guid("bd6800b3-6de6-40d5-b03c-93406ad2c5fb"), "CALLE 127 PONIENTE Y CALLE 11 SUR , COL.EX-HACIENDA CASTILLOTLA, PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("ce342b44-57a3-40ad-a236-fc75b2ef3238"), "AVENIDA 16 DE SEPTIEMBRE NUMERO 2904 COLONIA EL CARMEN, PUEBLA, PUE.", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION, FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICUALRES" }
                });

            migrationBuilder.InsertData(
                table: "Inmueble",
                columns: new[] { "Id", "Direccion", "IdMunicipio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5db4e0a1-d8f2-4371-8550-9852d2be90bb"), "INTERIOR DEL PANTEON MUNICIPAL, CALLE 17 ORIENTE Y AVENIDA COLON SIN NUMERO, BARRIO EL SANTUARIO", new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), "SEMEFO TEPEACA" },
                    { new Guid("90edf16d-e382-4e9a-8bd6-406e947940ea"), "CALLE 12 ORIENTE NO. 415 COL. CENTRO, PUEBLA, PUE.", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA DE DERECHOS HUMANOS" },
                    { new Guid("bcee5fc4-0a08-4059-b907-8c9727dd795e"), "12 NORTE. NO.1806,COL. BARRIO DEL ALTO , PUEBLA PUE. CP.: 72146", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS, ORGANO INTERNO DE CONTROL Y VISITADURIA GENERAL" },
                    { new Guid("35d32a53-7149-4351-ae5f-662e64f852bb"), "REVOLUCION NO. 6202, COL. EL LEON ATLIXCO PUE, CP.: 74360", new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), "CENTRO INTEGRAL SERVICIOS ATLIXCO" },
                    { new Guid("a62436ce-7e41-41f3-adc1-f737860abb40"), "MANZANA NUMERO 5 CIUDAD MODELO", new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), "CENTRO INTEGRAL SERVICIOS SAN JOSE CHIAPA" },
                    { new Guid("e9fbeb54-1704-4ecc-b4c2-aa8d4c0455ce"), "CARRETERA FEDERAL PUEBLA - TEHUACAN KILOMETRO 114, MANANTIALES, TEHUACAN, PUE. CP.: 75855", new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "CENTRO INTEGRAL SERVICIOS TEHUACAN" },
                    { new Guid("8edc1737-319d-4033-826c-e5d8adfad62f"), "CALLE FCO. JAVIER MINA NO. 303, COL. LA RIVERA XICOTEPEC DE JUAREZ, PUE. CP.: 73080", new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), "CENTRO INTEGRAL SERVICIOS XICOTEPEC DE JUAREZ" },
                    { new Guid("c193a612-80ce-4a1f-bb88-91b457e058cc"), "COLONIA 2 CAMINOS ZACATLAN , PUE. BARRIO TECOJOTAL, CP.: 73310", new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), "CENTRO INTEGRAL SERVICIOS ZACATLAN" },
                    { new Guid("f88c3266-a2d0-40f0-9ddb-23c2f1bf6df0"), "PERIFERICO ECOLOGICO KILOMETRO 3.5 ANTIGUO CAMINO A SAN FRANCISCO OCOTLAN, CUAUTLANCINGO PUEBLA", new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "COMPLEJO METROPOLITANO SEGURIDAD PUBLICA (C5)" },
                    { new Guid("aafaace9-e721-4a81-acda-e75576df0677"), "CAMINO A CUAYANTLA NO. 1611, SAN BERNARDINO TLAXCALANCINGO, PUEBLA", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "COMPLEJO DE SEGURIDAD PUBLICA SAN ANDRES CHOLULA" },
                    { new Guid("db461974-5ebb-4810-984a-e6c3a0de8f83"), "DIAGONAL DEFENSORES DE LA REPUBLICA ESQ.10 PONIENTE COL.AMOR PUEBLA,PUE. CP.: 72140", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("2507e9f2-220c-47f9-97c2-b1832e82bb66"), "CARRETERA A TLAXCALA KM 10 CUAUTLANCINGO, PUEBLA", new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "DEPOSITO DE VEHICULOS CUAUTLANCINGO (CAPULIN)" },
                    { new Guid("d958d50f-782f-43e9-85ff-c4de0337ea7a"), "CAMINO AL BATAN COL.LOMAS DE SAN MIGUEL PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "DEPOSITO DE VEHICULOS OCRA - SAN MIGUEL 2" },
                    { new Guid("6aee5b48-89b4-41f3-8dad-29b506104565"), "RIO ATOYAC # 19 SANCTORUM", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "DEPOSITO DE VEHICULOS SANCTORUM (FINSA)" },
                    { new Guid("3d8285b3-2b75-4b20-b0ba-9df53140482b"), "BOULEVARD HEROES 5 DE MAYO ESQUINA CON 31 ORIENTE COL.LADRILLERA DE BENITEZ CP.: 72530", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "EDIFICIO CENTRAL 04" },
                    { new Guid("4802db29-73e1-4166-99eb-937538da946a"), "KM 2.5 CARRETERA AL BATAN , EDIFICIO ADJUNTO AL CERESO DE SAN MIGUEL PUEBLA,PUE", new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "EJECUCION DE SENTENCIAS" },
                    { new Guid("b3603609-3175-4c5e-8d63-54256de13d5c"), "TERCER RETORNO OSA MAYOR NO. 3, RESERVA TERRITORIAL ATLIXCAYOTL SAN ANDRES", new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" }
                });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), "TEHUACAN" },
                    { new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), "TEPANCO DE LOPEZ" },
                    { new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), "TEHUITZINGO" },
                    { new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), "TEPATLAXCO DE HIDALGO" },
                    { new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), "TECAMACHALCO" },
                    { new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), "SAN JOSE CHIAPA" },
                    { new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), "SANTIAGO MIAHUATLAN" },
                    { new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), "SANTA RITA TLAHUAPAN" },
                    { new Guid("96282c38-e892-4399-b814-568127e5dff1"), "SAN SALVADOR EL SECO" },
                    { new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), "SAN PEDRO CHOLULA" },
                    { new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), "SAN MARTIN TEXMELUCAN" },
                    { new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), "TEPEACA" },
                    { new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), "SAN GABRIEL CHILAC" },
                    { new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), "TECALI DE HERRERA" },
                    { new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), "TEPEOJUMA" },
                    { new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), "TLALTENANGO" },
                    { new Guid("80261179-cc03-47f8-89fe-cf001811739a"), "TEPEXI DE RODRIGUEZ" },
                    { new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), "SAN ANDRES CHOLULA" },
                    { new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), "ZOQUITLAN" },
                    { new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), "ZARAGOZA" },
                    { new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), "ZACATLAN" },
                    { new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), "ZACAPOAXTLA" },
                    { new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), "XICOTEPEC DE JUAREZ" },
                    { new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), "TEPEXCO" },
                    { new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), "VILLA LAZARO CARDENAS" }
                });

            migrationBuilder.InsertData(
                table: "Municipio",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), "TLAPANALA" },
                    { new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), "TLAOLA" },
                    { new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), "TLACOTEPEC DE BENITO JUAREZ" },
                    { new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), "TEZIUTLAN" },
                    { new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), "TETELA DE OCAMPO" },
                    { new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), "TEPEYAHUALCO" },
                    { new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), "TLATLAUQUITEPEC" },
                    { new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), "PUEBLA" },
                    { new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), "CUETZALAN DEL PROGRESO" },
                    { new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), "PALMAR DE BRAVO" },
                    { new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), "PIAXTLA" },
                    { new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), "ACAJETE" },
                    { new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), "ACATENO" },
                    { new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), "ACATLAN DE OSORIO" },
                    { new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), "ACATZINGO" },
                    { new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), "AHUAZOTEPEC" },
                    { new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), "ALTEPEXI" },
                    { new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), "AMOZOC" },
                    { new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), "ATEMPAN" },
                    { new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), "ATENCINGO" },
                    { new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), "ATLIXCO" },
                    { new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), "CALPAN" },
                    { new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), "CHALCHICOMULA DE SESMA" },
                    { new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), "CHIAUTLA DE TAPIA" },
                    { new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), "CHIETLA" },
                    { new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), "AJALPAN" },
                    { new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), "CORONANGO" },
                    { new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), "OCOYUCAN" },
                    { new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), "METLALTOYUCA" },
                    { new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), "LOS REYES DE JUAREZ" },
                    { new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), "LIBRES" },
                    { new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), "JUAN C. BONILLA" },
                    { new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), "ORIENTAL" },
                    { new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), "IZUCAR DE MATAMOROS" },
                    { new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), "HUEJOTZINGO" },
                    { new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), "HUEHUETLA" },
                    { new Guid("bf447292-6874-4d7e-8790-946362b43fae"), "HUAUCHINANGO" },
                    { new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), "GUADALUPE VICTORIA" },
                    { new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), "ESPERANZA" },
                    { new Guid("6e090986-3e32-4a13-b648-cf7844752930"), "CUAUTLANCINGO" },
                    { new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), "HUEYTAMALCO" },
                    { new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), "CHIGNAHUAPAN" }
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
                    { new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" },
                    { new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" },
                    { new Guid("96559f1b-3880-4339-9c73-fed0ec116105"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" },
                    { new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" },
                    { new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA FISCALES Y RELACIONADOS" },
                    { new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"), "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" },
                    { new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"), "FISCALIA GENERAL DEL ESTADO" },
                    { new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"), "INSTITUTO DE CIENCIAS FORENSES" },
                    { new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"), "OFICIALIA MAYOR" },
                    { new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"), "OFICINA DEL FISCAL GENERAL" },
                    { new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"), "ORGANO INTERNO DE CONTROL" },
                    { new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"), "UNIDAD DE TRANSPARENCIA" },
                    { new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"), "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" },
                    { new Guid("d052658e-e743-478d-aa94-21f279ddde3d"), "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" },
                    { new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"), "VISITADURIA GENERAL" },
                    { new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"), "INSTITUTO DE FORMACION PROFESIONAL" },
                    { new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"), "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" },
                    { new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"), "AGENCIA ESTATAL DE INVESTIGACION" },
                    { new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"), "FISCALIA DE INVESTIGACION REGIONAL" },
                    { new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"), "COORDINACION GENERAL DE ANALISIS DE INFORMACION" },
                    { new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"), "COORDINACION GENERAL DE ASUNTOS JURIDICOS" },
                    { new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"), "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" },
                    { new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"), "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" },
                    { new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"), "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" },
                    { new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"), "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" },
                    { new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"), "COORDINACION GENERAL DE INVESTIGACION" },
                    { new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"), "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" },
                    { new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"), "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" },
                    { new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"), "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" },
                    { new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"), "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" },
                    { new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"), "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" },
                    { new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"), "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" },
                    { new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"), "FISCALIA DE INVESTIGACION METROPOLITANA" },
                    { new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"), "COORDINACION GENERAL DE LITIGACION" }
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
