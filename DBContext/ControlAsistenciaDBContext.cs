﻿using ControlAsistencia_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBContext
{
    public class ControlAsistenciaDBContext : DbContext
    {
        public ControlAsistenciaDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<Asistencia> Asistencia { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Municipio> Municipio { get; set; }
        public DbSet<Inmueble> Inmueble { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<CargoHomologado> CargoHomologado { get; set; }
        public DbSet<UnidadAdministrativa> UnidadAdministrativa { get; set; }
        public DbSet<CentroTrabajo> CentroTrabajo { get; set; }
        public DbSet<Contratacion> Contratacion { get; set; }
        public DbSet<Incidencia> Incidencia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Asistencia>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Inmueble>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<CargoHomologado>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<UnidadAdministrativa>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<CentroTrabajo>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Contratacion>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Incidencia>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // Roles
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("77a225a3-1266-4b1f-b11c-504969afa856"), Nombre = "Root", Activo=true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("9a39bcce-b092-4f90-9de7-9e0fb2137034"), Nombre = "Administrador", Activo=true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), Nombre = "AllView", Activo=true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("592d923a-9d0b-424c-8bc3-0c42ff72495e"), Nombre = "UnidadAdministrativa", Activo=true });
            
            // Usuarios
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"), Nombre = "root", Password="root",IdUnidadAdministrativa= "", Activo=true, IdRol= "77a225a3-1266-4b1f-b11c-504969afa856" });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("061bc395-9e04-40d9-824c-0c740f63af15"), Nombre = "oficialiaMayor", Password= "oficialiaMayor", IdUnidadAdministrativa= "", Activo=true, IdRol= "9a39bcce-b092-4f90-9de7-9e0fb2137034" });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("67bb4459-8401-4b49-8ac8-67d3219fbfc8"), Nombre = "cgesi", Password="cgesi",IdUnidadAdministrativa= "0e3aa015-4581-4c88-a8c9-679dd80b0d13", Activo=true, IdRol= "592d923a-9d0b-424c-8bc3-0c42ff72495e" });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("0524769e-c144-4772-a050-811e7d2b68ce"), Nombre = "visitaduria", Password="visitaduria",IdUnidadAdministrativa= "", Activo=true, IdRol= "a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7" });

            //Catalogo Municipios - Nuevos

            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), Nombre = "ACAJETE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), Nombre = "ACATENO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), Nombre = "ACATLAN DE OSORIO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), Nombre = "ACATZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), Nombre = "AHUAZOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), Nombre = "AJALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), Nombre = "ALTEPEXI" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), Nombre = "AMOZOC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), Nombre = "ATEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), Nombre = "ATENCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), Nombre = "ATLIXCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), Nombre = "CALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), Nombre = "CHALCHICOMULA DE SESMA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), Nombre = "CHIAUTLA DE TAPIA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), Nombre = "CHIETLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), Nombre = "CHIGNAHUAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), Nombre = "CORONANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Nombre = "CUAUTLANCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), Nombre = "CUETZALAN DEL PROGRESO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), Nombre = "ESPERANZA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), Nombre = "GUADALUPE VICTORIA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("bf447292-6874-4d7e-8790-946362b43fae"), Nombre = "HUAUCHINANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), Nombre = "HUEHUETLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Nombre = "HUEJOTZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), Nombre = "HUEYTAMALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Nombre = "IZUCAR DE MATAMOROS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), Nombre = "JUAN C. BONILLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), Nombre = "LIBRES" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), Nombre = "LOS REYES DE JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), Nombre = "METLALTOYUCA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), Nombre = "OCOYUCAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), Nombre = "ORIENTAL" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), Nombre = "PALMAR DE BRAVO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), Nombre = "PIAXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Nombre = "PUEBLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Nombre = "SAN ANDRES CHOLULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), Nombre = "SAN GABRIEL CHILAC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), Nombre = "SAN JOSE CHIAPA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Nombre = "SAN MARTIN TEXMELUCAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), Nombre = "SAN PEDRO CHOLULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("96282c38-e892-4399-b814-568127e5dff1"), Nombre = "SAN SALVADOR EL SECO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), Nombre = "SANTA RITA TLAHUAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), Nombre = "SANTIAGO MIAHUATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), Nombre = "TECALI DE HERRERA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Nombre = "TECAMACHALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Nombre = "TEHUACAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), Nombre = "TEHUITZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), Nombre = "TEPANCO DE LOPEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), Nombre = "TEPATLAXCO DE HIDALGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), Nombre = "TEPEACA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), Nombre = "TEPEOJUMA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), Nombre = "TEPEXCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("80261179-cc03-47f8-89fe-cf001811739a"), Nombre = "TEPEXI DE RODRIGUEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), Nombre = "TEPEYAHUALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), Nombre = "TETELA DE OCAMPO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Nombre = "TEZIUTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), Nombre = "TLACOTEPEC DE BENITO JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), Nombre = "TLALTENANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), Nombre = "TLAOLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), Nombre = "TLAPANALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Nombre = "TLATLAUQUITEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), Nombre = "VILLA LAZARO CARDENAS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Nombre = "XICOTEPEC DE JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), Nombre = "ZACAPOAXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Nombre = "ZACATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), Nombre = "ZARAGOZA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { Id = new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), Nombre = "ZOQUITLAN" });


            //Tipos de Inmuebles

            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("35d320b0-0c19-481c-b69c-63d419b07348"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION PUEBLA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ad4bc7f5-16a7-406d-81c7-da1c0d334bab"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), Direccion = "CALLE VICENTE GUERRERO NO.714 COL, MORELOS SAN MARTIN TEXMELUCAN, CP.: 74020" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b7607eff-eff8-4aba-8475-bf00219a9dfc"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION SANTA RITA TLAHUAPAN", IdMunicipio = new Guid("bacd27c0-4eb5-44bf-9cb4-f9c737a6d9e3"), Direccion = "CALLE JOSE GALEANA NO. 200 COLONIA DOMINGO ARENAS, SANTA RITA TLAHUAPAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0172497d-18fd-42fc-b3d5-2349011b583e"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION TEZIUTLAN", IdMunicipio = new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), Direccion = "CALLE LERDO NÚMERO 205, ALTOS COL. CENTRO. ANEXO AL CERESO, TEZIUTLAN , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("aac7bf25-e85d-4adf-bd70-f2ba243cbb70"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION TLATLAUQUITEPEC", IdMunicipio = new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), Direccion = "AV. INDEPENDENCIA NUM. 20 COL.CENTRO , TLATLAUQUITEPEC,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("88733808-8fef-4929-a856-7d44c3be53da"), Nombre = "ALMACEN GENERAL", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE ORQUIDEAS NO. 6141 COLONIA BUGAMBILIAS CP 72580" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("61f9d887-5a87-44c3-a114-5d0cad70c14c"), Nombre = "ARCHIVO Y BODEGA DE INDICIOS", IdMunicipio = new Guid("1a3d8733-aebb-4cf4-8732-cefaaf066d9f"), Direccion = "KM 19.5 CARRETERA FEDERAL PUEBLA - TEHUACAN, COLONIA SAN JOSE LAS FLORES, CP 72980, AMOZOC" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5d18df07-a839-4c95-8f5c-b9458c7a2595"), Nombre = "ARCO DE SEGURIDAD DE ALTEPEXI", IdMunicipio = new Guid("f5e623d2-026d-4c91-bebc-579010cb7677"), Direccion = "CARRETERA ESTATAL TEHUACAN TEOTITLÁN OAXACA, TRAMO DE CHILACALTEPEXI,CP.: 75914" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1cdbe3ba-156b-4c4c-bbef-ba9256f8e75d"), Nombre = "ARCO DE SEGURIDAD DE IZUCAR DE MATAMOROS", IdMunicipio = new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), Direccion = "CARRETERA FEDERAL IZÚCAR DE MATAMOROS KM61+800 IZUCAR DE MATAMOROS" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("fc3f72b8-525e-4cd0-a25d-ed8d3fa61785"), Nombre = "ARCO DE SEGURIDAD HUEJOTZINGO", IdMunicipio = new Guid("bd268009-9447-4da5-aebc-2e5b3cea3375"), Direccion = "CARRETERA MÉXICO -PUEBLA KM100+200 HUEJOTZINGO ,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ba320320-3b9b-4390-be0a-7c083232ebd8"), Nombre = "ARCO DE SEGURIDAD PALMAR DE BRAVO", IdMunicipio = new Guid("4169b1d9-9250-431b-ad0e-e376dedbbe5d"), Direccion = "CARRETERA MÉXICO VERACRUZ KM 166+500PALMAR DE BRAVO , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a5a3c6fa-8d1f-415f-9e00-dd6fcd9411f0"), Nombre = "C5 TEHUACAN", IdMunicipio = new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), Direccion = "CARRETERA FEDERAL PUEBLA TEHUACAN 1211 O KM 114 SAN LORENZO TEOTIPILCO, TEHUACAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5fa90fdf-c37c-4896-9202-cf9e8965aea1"), Nombre = "CANACO SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), Direccion = "REFORMA 3 ORIENTE, COL. CENTRO 74000 SAN MARTIN TEXMELUCAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d01944c4-0b51-455b-9340-ee6d11d67a97"), Nombre = "CASA DE JUSTICIA ACATLAN DE OSORIO", IdMunicipio = new Guid("0e40384a-9817-4f2f-b142-7476b8c8e8f9"), Direccion = "CARRETERA INTERNACIONAL MÉXICO -OAXACA KM152+200, BARRIO LA PALMA , ACATLÁN DE OSORIO PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1fa46626-f4ca-4541-8ec5-9d7e0d8d6671"), Nombre = "CASA DE JUSTICIA ATLIXCO", IdMunicipio = new Guid("3e834424-91f8-4a08-9cf2-933c1a28b373"), Direccion = "BOULEVARD GENERAL MORENO VALLE NO. 1604, COL. TIZAYUCA ,ATLIXCO PUE. CP.: 74200" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("15a5ff14-dbd2-4fcd-b2dc-6c990cb8bdad"), Nombre = "CASA DE JUSTICIA CHALCHICOMULA DE SESMA", IdMunicipio = new Guid("ac27c79a-e0de-43ba-9a99-2f15de5edb65"), Direccion = "KM.28+285 CARRETERA FEDERAL EL SECO ASUMBULLA, CD. SERDAN, PUEBLA CP.: 75520" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3824f09c-1fe4-401f-aa97-3d95cb54e924"), Nombre = "CASA DE JUSTICIA HUAUCHINANGO", IdMunicipio = new Guid("559fc027-355b-4bad-9d08-1db4bc51e80c"), Direccion = "CAMINO A CATALINA S/N COLONIA EL POTRO, HUAUCHINANGO, PUEBLA CP.: 73176" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("733ca58d-55f6-4b15-a177-1b2b2c96a925"), Nombre = "CASA DE JUSTICIA IZUCAR DE MATAMOROS", IdMunicipio = new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), Direccion = "CARRETERA FEDERAL PUEBLA-IZUCAR DE MATAMOROS NO. 2119, COL. GALARZA, IZUCAR" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("884662b3-9f62-4ed9-864c-84ceb2afe84c"), Nombre = "CASA DE JUSTICIA PARA ADOLESCENTES", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "CARRETERA IZUCAR DE MATAMOROS S/N COL. TLAXCALANCINGO, CP.: 72820" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9d715109-bb34-4a25-bf4b-3f07fc3ee517"), Nombre = "CASA DE JUSTICIA SAN ANDRES CHOLULA", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "PERIFÉRICO ECOLÓGICO 100 SAN BERNARDINO TLAXCALANCINGO SAN ANDRES CHOLULA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1f55557c-964b-4bb0-85ed-b89a9113f562"), Nombre = "CASA DE JUSTICIA SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("2158fa61-3374-4faa-97a8-a0715c7a70cb"), Direccion = "AUTOPISTA MÉXICO -PUEBLA S/N, SAL SALVADOR EL VERDE, SAN MARTIN TEXMELUCAN," });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e152a22d-c3c4-4baf-8523-9617486c2dcf"), Nombre = "CASA DE JUSTICIA TECAMACHALCO", IdMunicipio = new Guid("c7d4c93f-1e48-41a5-83a9-8cb883cef9de"), Direccion = "CARRETERA FEDERAL KM 60+490, COL.SANTIAGO ALSESECA, TECAMACHALCO, CP.: 75480" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3e8c83ab-53a1-41c4-9aab-828933b2a723"), Nombre = "CASA DE JUSTICIA TEHUACAN", IdMunicipio = new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), Direccion = "BLVD. ADOLFO MATEOS NO.4, PLANTA ALTA, COL. ZONA ALTA, TEHUACAN, PUEBLA CP.: 75750" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d3252b5e-1fbd-4846-8aa0-593755735163"), Nombre = "CASA DE JUSTICIA TEZIUTLAN", IdMunicipio = new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), Direccion = "CALLE LA MESILLA NO.10 COL. INDUSTRIAL, TEZIUTLÁN, PUEBLA. CP.: 73850" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("86b1f981-b967-4fd5-b577-cc4e12e1b46e"), Nombre = "CASA DE JUSTICIA ZACATLAN", IdMunicipio = new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), Direccion = "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN," });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e41a2c36-5620-4def-b83c-804d2f39a52f"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES EN ACATLAN DE OSORIO", IdMunicipio = new Guid("0e40384a-9817-4f2f-b142-7476b8c8e8f9"), Direccion = "AV. REFORMA 22 COLONIA CENTRO ENTRE EMILIANO ZAPATA Y VENUSTIANO C" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("174f9f2e-1181-409f-a16e-871cf67319e7"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES PUEBLA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 17 PONIENTE NO.1919, BARRIO DE SANTIAGO,PUEBLA, PUE. CP.: 72410" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0afcf63c-414f-4d18-b072-55a21c7232de"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES TEHUACAN", IdMunicipio = new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), Direccion = "CALLE COMPLUTENSE ESQUINA CALLE DE LA TURBINA S/N COL. UNIVERSIDADES II, TEHUACAN ,PUE. CP.: 75723" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3061f5f9-731e-4f66-b566-7c64bbdf64e4"), Nombre = "CENTRO INTEGRAL DE SERVICIOS ANGELOPOLIS", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "VÍA ATLIXCAYOTL NO. 1101, EDIFICIO SUR PLANTA BAJA , CONCEPCION LAS LAJAS , PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("76e9edbd-9b38-4304-bc29-d79a0c7c06bc"), Nombre = "CENTRO INTEGRAL DE SERVICIOS CUAUTLANCINGO", IdMunicipio = new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), Direccion = "CALLE AQUILES SERDAN ESQUINA CON 20 DE NOVIEMBRE SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ed5b6ff2-9c1d-4627-8e22-51ee147e4201"), Nombre = "CENTRO INTEGRAL DE SERVICIOS SAN JAVIER", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "AV. REFORMA 1305 COL CENTRO C.P. 72000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c9ecbfca-73e3-4c07-a602-e23a9945f472"), Nombre = "CENTRO INTEGRAL DE SERVICIOS TEZIUTLAN", IdMunicipio = new Guid("1c6a5734-10e0-41a9-ba35-0732a670133f"), Direccion = "AV HIDALGO NO.169 EDIFICIO REAL PLANTA BAJA, CENTRO. TEZIUTLAN, PUEBLA." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e7fd7d82-a762-44db-91d5-ce71bf334fc8"), Nombre = "CENTRO INTEGRAL DE SERVICIOS TLATLAUQUITEPEC", IdMunicipio = new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), Direccion = "CARRETERA FEDERAL TEZIUTLAN - ACAJETE NO. 169 BARRIO DE CONTLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2b46cfb0-cbe7-43ec-82f6-4639da38e6ad"), Nombre = "CENTRO INTEGRAL SERVICIOS ATLIXCO", IdMunicipio = new Guid("3e834424-91f8-4a08-9cf2-933c1a28b373"), Direccion = "REVOLUCIÓN NO. 6202, COL. EL LEÓN ATLIXCO PUE, CP.: 74360" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("742b64df-f5af-45aa-93d9-e1c8035fdad6"), Nombre = "CENTRO INTEGRAL SERVICIOS SAN JOSE CHIAPA", IdMunicipio = new Guid("27172024-5222-4c81-9f58-d2010f067f2c"), Direccion = "MANZANA NÚMERO 5 CIUDAD MODELO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("931ecd8f-d618-49ae-b4c2-29174eb2e59c"), Nombre = "CENTRO INTEGRAL SERVICIOS TEHUACAN", IdMunicipio = new Guid("bcbf3127-960f-44c7-a38d-8f49f766c44c"), Direccion = "CARRETERA FEDERAL PUEBLA - TEHUACÁN KILOMETRO 114, MANANTIALES, TEHUACÁN,PUE. CP.: 75855" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("45906a3d-9e8f-48ff-85ce-11ea79d4edb8"), Nombre = "COMPLEJO DE SEGURIDAD PUBLICA SAN ANDRES CHOLULA", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "CAMINO A CUAYANTLA NO. 1611, SAN BERNARDINO TLAXCALANCINGO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("cd0a1b05-ed27-4d61-b225-be46cd2529d6"), Nombre = "COMPLEJO METROPOLITANO SEGURIDAD PUBLICA (C5)", IdMunicipio = new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), Direccion = "PERIFERICO ECOLÓGICO KILÓMETRO 3.5 ANTIGUO CAMINO A SAN FRANCISCO OCOTLÁN, CUAUTLANCINGO PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2e915059-5071-4525-b1a3-d76e913b8998"), Nombre = "COORDINACION GENERAL DE ANALISIS DE INFORMACION", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "TERCER RETORNO OSA MAYOR NO. 3, RESERVA TERRITORIAL ATLIXCAYOTL SAN ANDRES" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3e2fb426-20af-48b2-81e7-3458afad62c1"), Nombre = "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "DIAGONAL DEFENSORES DE LA REPÚBLICA ESQ.10 PONIENTE COL.AMOR PUEBLA,PUE. CP.: 72140" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("72d093d9-c710-407b-8d64-0eb9b8d52083"), Nombre = "DEPOSITO DE VEHICULOS OCRA - SAN MIGUEL 2", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CAMINO AL BATÁN COL.LOMAS DE SAN MIGUEL PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f17baa14-fec6-4d0b-91b5-f497262ea9a8"), Nombre = "DEPOSITO DE VEHICULOS SANCTORUM (FINSA)", IdMunicipio = new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), Direccion = "RIO ATOYAC # 19 SANCTORUM" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1f6bc9d7-36ba-472f-9c8e-0c3282fee714"), Nombre = "EDIFICIO CENTRAL 04", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "BOULEVARD HEROES 5 DE MAYO ESQUINA CON 31 ORIENTE COL.LADRILLERA DE BENITEZ CP.: 72530" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0bca398f-a923-4b1f-bfea-c75b0fe4a285"), Nombre = "EJECUCION DE SENTENCIAS", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "KM 2.5 CARRETERA AL BATAN , EDIFICIO ADJUNTO AL CERESO DE SAN MIGUEL PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9c8d1d27-c114-4cc5-9928-07efffab3272"), Nombre = "FISCALIA DE ASUNTOS INTERNOS, ORGANO INTERNO DE CONTROL Y VISITADURIA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "12 NORTE. NO.1806,COL. BARRIO DEL ALTO , PUEBLA PUE. CP.: 72146" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("21223825-1990-4641-80b2-646d7a4aaa7c"), Nombre = "FISCALIA DE DERECHOS HUMANOS", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 12 ORIENTE NO. 415 COL. CENTRO, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("96476f7e-40ba-4fd7-993c-1fa19de518ab"), Nombre = "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION, FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICUALRES", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "AVENIDA 16 DE SEPTIEMBRE NUMERO 2904 COLONIA EL CARMEN, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e8321188-3639-47fa-b6e0-d8e265dc2e5b"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 127 PONIENTE Y CALLE 11 SUR , COL.EX-HACIENDA CASTILLOTLA, PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9e0a8a45-f81f-4e35-beab-153ae7e53f40"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (BOCHAS)", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 6 NORTE NO.1003, COL. CENTRO,PUEBLA PUE. CP.: 72000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("44386bd7-2492-4d93-a78e-a1816ebfaf2e"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (CPJ)", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 10 ORIENTE NO.414,COL CENTRO PUEBLA,PUE. CP.: 72530" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("81a3d40c-a1a2-4eed-ada6-143b31b8f30e"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "3ER RETORNO OSA MENOR NO.3, RESERVA TERRITORIAL ATLIXCAYOTL ,SAN ANDRÉS" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("23ed8c1d-864d-42df-9083-23eea1af7d1e"), Nombre = "INDIGENAS PERIODISTAS LGBTTQ", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "PRIV. 5 B SUR NO. 3706, COL. GABRIEL PASTOR, PUEBLA, PUE CP. 72420" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0c94b4f7-d134-4ac6-85dc-bbf58625c489"), Nombre = "INMUEBLE CANACINTRA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "AV. REFORMA 2704 5° PISO COL. AMOR" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1dd4a281-0759-40cc-8cb8-739f6dc3a772"), Nombre = "INSTITUTO DE FORMACION PROFESIONAL", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "DIAGONAL CUAUHTÉMOC NO.3101 COL. VALLE DORADO PUEBLA,PUE. CP.: 72070" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0fafd963-361c-4b92-b795-4219f7940a2d"), Nombre = "JUSTICIA CIUDADANA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "13 SUR 1910 BARRIO DE SANTIAGO PUEBLA PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e7f14c97-e7c3-467b-ac30-5f8310d4148e"), Nombre = "SEMEFO 11 SUR", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "PROLONGACION 11 SUR 11906, COL. GUADALUPE HIDQLGO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("efd124dd-6502-4f6e-81a6-4d71392854ab"), Nombre = "SEMEFO CHIGNAHUAPAN", IdMunicipio = new Guid("9f2ad70c-f85a-42a4-a1d1-db23a6339930"), Direccion = "BOULEVARD EMILIANO ZAPATA SIN NUMERO, INTERIOR DEL PANTEON MUNICIPAL, CHIGNAHUAPAN,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c86f4562-6b68-44aa-b970-243e14b0a194"), Nombre = "SEMEFO LIBRES", IdMunicipio = new Guid("eff52198-0e70-4e53-b4dc-5fda6382aadf"), Direccion = "CALLE 4 ORIENTE SIN NUMERO BARRIO DE GUADALUPE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("7ba2052e-3cb6-4ace-aa80-6c427d64dc9f"), Nombre = "SEMEFO TEPEACA", IdMunicipio = new Guid("d4ac176e-55a9-45e4-9053-10b44f883bd6"), Direccion = "INTERIOR DEL PANTEON MUNICIPAL, CALLE 17 ORIENTE Y AVENIDA COLON SIN NUMERO, BARRIO EL  SANTUARIO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("741fb5a0-3175-4db6-b46c-daae21d2a3e7"), Nombre = "SEMEFO TEPEXI DE RODRIGUEZ", IdMunicipio = new Guid("c76f5daa-fddd-4abb-a861-df871d4cf4b0"), Direccion = "PANTEON MUNICIPAL CALLE DEFENSORES DEL 6 DE JUNIO SIN NUMERO, TEPEXI DE  RODRIGUEZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9de39295-08e0-4c93-b229-37499a6d6ea0"), Nombre = "SEMEFO TLATLAUQUITEPEC", IdMunicipio = new Guid("f1434a0e-bc9b-4ccf-8853-1ef19e4dd6ef"), Direccion = "AV DOLORES BETANCOURT COL. CONTLA, TLATLAUQUITEPEC, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e1d63cf7-815d-41c2-99d9-014a9cce294c"), Nombre = "SEMEFO XICOTEPEC DE JUAREZ", IdMunicipio = new Guid("42a91eae-d655-4e1d-ae93-d0f05644c956"), Direccion = "AV. ZARAGOZA SIN NUMERO, XICOTEPEC DE JUAREZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("51337de0-0de2-47a9-8904-5ad933b9ae40"), Nombre = "SEMEFO ZACAPOAXTLA", IdMunicipio = new Guid("44531449-928c-44d8-ad72-08a007376f44"), Direccion = "CALLE 2 DE ABRIL NORTE  SIN NUMERO ESUINA FJ. ARRIAGA COL. CENTRO ZACAPOAXTLA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("23dd0625-7e09-444f-9ca3-161916d41cf0"), Nombre = "SEMEFO ZACATLAN", IdMunicipio = new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), Direccion = "CALLE PORFIRIO DIAZ Y DOLORES PEREZ SIN NUMERO COL. CENTRO  ZACATLAN, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("602cf0c7-99b2-4d87-a9f6-bef2760365ef"), Nombre = "UNIDAD DE IDENTIFICACION VEHICULAR", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "EMILIANO ZAPATA KM2.5,COL LOMAS DE SAN MIGUEL,PUEBLA,PUE. CP.: 72573" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0bd8e30d-31cc-4512-8e0a-8f68266ee12a"), Nombre = "UNIDAD DE INVESTIGACION ACAJETE", IdMunicipio = new Guid("231d563b-6511-4f4a-9e90-7257755e21b1"), Direccion = "CALLE 2 ORIENTE ENTRE CALLE 8 NORTE Y CALLE 10 ORIENTE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b2d703c0-e3ea-42fb-9e3a-0b2632e689f3"), Nombre = "UNIDAD DE INVESTIGACION ACATENO", IdMunicipio = new Guid("0d8e75ba-ebe8-4eb6-ba8d-c555e67f2a1d"), Direccion = "CALLE ALLENDE NO. 1 COL. CENTRO SAN JOSÉ ACATENO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9225f54e-32b5-4e8a-96bb-bdc02572d785"), Nombre = "UNIDAD DE INVESTIGACION ACATZINGO", IdMunicipio = new Guid("738bc1a9-6e14-42b5-812f-04026164c3c2"), Direccion = "AV. IGNACIO ROMERO VARGAS 201 COL CENTRO CP 75150" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f2812202-d4b6-41cd-a0a6-8b490697fc10"), Nombre = "UNIDAD DE INVESTIGACION ADSCRITA A JUZGADOS PENALES Y CIVILES", IdMunicipio = new Guid("bd268009-9447-4da5-aebc-2e5b3cea3375"), Direccion = "AV DE LAS HUERTAS 917 CUARTO BARRIO COL. CENTRO, HUEJOTZINGO, PUEBLA, CP.: 74168" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9e0f5696-4a56-4808-a549-e276c4dd02c5"), Nombre = "UNIDAD DE INVESTIGACION AHUAZOTEPEC", IdMunicipio = new Guid("863e7a7d-99e6-473c-824c-e58e005dedd9"), Direccion = "CALLE HIDALGO SUR  S/N COL. CENTRO (DENTRO DE LA PRESIDENCIA MUNICIPAL" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("34c82967-a25e-4139-9ae5-c41b26973eee"), Nombre = "UNIDAD DE INVESTIGACION AJALPAN", IdMunicipio = new Guid("24f40687-4afb-42e9-ae74-55fd8126a2d5"), Direccion = "CALLE GUERRERO SIN NÚMERO, AJALPAN PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0d382eaf-bb2f-4754-accd-260199799f98"), Nombre = "UNIDAD DE INVESTIGACION AMOZOC", IdMunicipio = new Guid("1a3d8733-aebb-4cf4-8732-cefaaf066d9f"), Direccion = "CALLE FRANCISCO I. MADERO 109 COLONIA CENTRO BARRIO DE SANTIAGO, AMOZOC, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("90f6cba7-b81e-40dc-996f-154efa5f0c5c"), Nombre = "UNIDAD DE INVESTIGACION ATEMPAN", IdMunicipio = new Guid("cd8ef709-7737-4990-aea1-b105ae25f8a5"), Direccion = "02 ORIENTE SIN NUMERO, COLONIA CENTRO, ATEMPAN, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("18b9bf42-e324-4fe9-ab39-9f669f5a6a8c"), Nombre = "UNIDAD DE INVESTIGACION ATENCINGO", IdMunicipio = new Guid("a3a7e42c-b3ae-4d43-9da8-e414fb60a7aa"), Direccion = "CALLE 5 DE FEBRERO ESQUINA MIGUEL HIDALGO COL LA CRUZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("72a04a8c-f5aa-4545-8d68-c3fd8aef314f"), Nombre = "UNIDAD DE INVESTIGACION CALPAN", IdMunicipio = new Guid("3c6dac9c-1012-4ea2-bfc7-0ff6d45258c6"), Direccion = "CALLE CONSTITUCION S/N ENTRE 16 DE SEPTIEMBRE Y DOMINGO ARENAS, PRESIDENCIA MUNICIPAL CALPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2bd2b7d0-8f13-4837-b295-3fd7b23eb845"), Nombre = "UNIDAD DE INVESTIGACION CENTRO", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "9 ORIENTE NO.1405COL.CENTRO PUEBLA PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f0ef919e-c0ed-4656-abd8-8a3c90877322"), Nombre = "UNIDAD DE INVESTIGACION CHAPULCO", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "PROLONGACION DE LA 14 SUR NUMERO 11517 COL. SAN JOSE CHAPULCO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a9e48337-dfd9-498c-bb79-5f355e877e11"), Nombre = "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA", IdMunicipio = new Guid("1e6f3b9c-f27a-49da-a02f-6975839978bd"), Direccion = "CALLE REFORMA Y 5 NORTE COLONIA CENTRO, CHIAUTLA DE TAPIA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("379ecbc7-ee46-4a2d-bc76-1097dddef05a"), Nombre = "UNIDAD DE INVESTIGACION CHIETLA", IdMunicipio = new Guid("5a2e489b-ced1-47da-8455-fa692b081959"), Direccion = "CALLE RAYON NUMERO 4 COL. CENTRO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("cd4cb079-f1e9-4f4a-b804-71197d520419"), Nombre = "UNIDAD DE INVESTIGACION CHIGNAHUAPAN", IdMunicipio = new Guid("9f2ad70c-f85a-42a4-a1d1-db23a6339930"), Direccion = "LIBRAMIENTOCHIGNAHUAPAN - ZACATLAN, KM 4.5 BARRIO TOLTEMPAN, CHIGNAHUAPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ea5f16aa-ee0e-4709-a84f-160b36ea3d3f"), Nombre = "UNIDAD DE INVESTIGACION CIUDAD JUDICIAL", IdMunicipio = new Guid("aca639c6-9031-4648-a649-6dee89ae73ad"), Direccion = "PERIFERICO ECOLOGÍCO ARCO SUR NO. 4000, RESERVA TERRITORIAL ATLIXCAYOTL, SAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("58221593-419a-4d31-9547-1ba6af8de059"), Nombre = "UNIDAD DE INVESTIGACION CORONANGO", IdMunicipio = new Guid("cc19c5f3-be8e-43e3-8c86-fe33c1818d12"), Direccion = "AV. 5 DE FEBRERO NORTE SIN NUMERO COL. EL MONTERO CORONANGO, PUEBLA  COMPLEJO METROPOLITANO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5cafef35-d0e7-4501-a90a-1ca4e9d97730"), Nombre = "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA IZUCAR DE MATAMOROS", IdMunicipio = new Guid("dc815202-561f-4b8c-b1d6-0bcc345afcb9"), Direccion = "PRIVADA UNIVERSIDAD II SAN MARTIN ALCHICHICA, IZUCAR DE MATAMOROS,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("dfdca4fa-263f-44ab-ad9b-a72ca5e2e8d0"), Nombre = "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA ZACATLAN", IdMunicipio = new Guid("e940a9c3-55e2-4ac6-b6df-e45bb398b4f6"), Direccion = "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("4d069907-d15e-4715-98ac-4d203f75bf2a"), Nombre = "UNIDAD DE INVESTIGACION CUAUTLANCINGO", IdMunicipio = new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), Direccion = "CALLE CAMINO NACIONAL ESQUINA CON AQUILES SERDAN SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO  COMPLEJO DE SEGURIDAD" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("593a6af3-829f-4639-80db-77b12e469f54"), Nombre = "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO", IdMunicipio = new Guid("9e176192-4277-4848-a41b-9d2836d7dd71"), Direccion = "CALLE MIGUEL ALVARADO ESQUINA CON ABASOLO S/N COLONIA CENTRO C.P. 75040 CUETZALAN PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("938caad1-0023-4c81-9e89-aacffbd85895"), Nombre = "UNIDAD DE INVESTIGACION EL SECO", IdMunicipio = new Guid("2e1a8b19-3b35-4f27-924f-c54c88206e81"), Direccion = "AV. 4 ORIENTE SIN NUMERO TECOAC" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("44b55079-5390-4ff7-af03-dc9f239e9e1f"), Nombre = "UNIDAD DE INVESTIGACION ESPERANZA", IdMunicipio = new Guid("dc626225-2e6c-4938-94f2-f1dc0d7c097d"), Direccion = "CALLE 12 NORTE SEGUNDA SECCION 22, ESPERANZA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b6d44237-54cf-47f6-bf7a-3c0eb2ef06da"), Nombre = "UNIDAD DE INVESTIGACION HUEHUETLA", IdMunicipio = new Guid("df498a1f-3792-452b-ad70-ff1def221d29"), Direccion = "CALLE JUAREZ SUR S/N COL. YALU LOCALUDAD PUTAX-EAT, HUEHUETLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6d1ca38b-8b3b-4a49-bba1-e9cf23ffbf69"), Nombre = "UNIDAD DE INVESTIGACION HUEYTAMALCO", IdMunicipio = new Guid("812f1523-8500-4fbc-9290-2b511da5ee46"), Direccion = "CALLE INDEPENDENCIA ESQ. CON CALLE 5 DE MAYO S/N COL. CENTRO, HUEYTAMALCO, PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a8b53488-e616-4a07-ba6a-9ddb524da777"), Nombre = "UNIDAD DE INVESTIGACION JUAN C BONILLA", IdMunicipio = new Guid("ecfb68ce-9d3f-4272-b670-b63f7f4a54fb"), Direccion = "CALLE 5 DE MAYO S/N COLONIA CENTRO, JUAN C. BONILLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("89c95d42-8a77-465a-bc9f-51dba6071605"), Nombre = "UNIDAD DE INVESTIGACION LA MARGARITA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CAMINO AL BATAN NO. 12 COL. VILLA SATELITE LA CALERA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("eecc929f-781d-4970-863f-fe5394abf1e9"), Nombre = "UNIDAD DE INVESTIGACION LA POPULAR", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "AV.105 PONIENTE ENTRE CALLE PUEBLA Y OAXACA COL.POPULAR CASTILLOTLA, PUEBLA," });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("708e475a-2a6f-4e48-9473-b2c08079e0c7"), Nombre = "UNIDAD DE INVESTIGACION LAZARO CARDENAS", IdMunicipio = new Guid("8cbfe7a8-447e-43c3-8756-f68e83378b67"), Direccion = "CARRETERA FEDERAL PACHUCA TUXPAN, COL. CENTRO, VILLA LÁZARO CARDENAS" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("29be23b3-f444-46b7-ba37-9fdf3dbd78ec"), Nombre = "UNIDAD DE INVESTIGACION LIBRES", IdMunicipio = new Guid("eff52198-0e70-4e53-b4dc-5fda6382aadf"), Direccion = "CALLE LERDO NUMERO 988, LIBRES, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("25a13674-4e84-47c2-accd-0e79f826d0ea"), Nombre = "UNIDAD DE INVESTIGACION LOS REYES DE JUAREZ", IdMunicipio = new Guid("89ff867f-af7d-48c5-abef-413675cf30f5"), Direccion = "AVENIDA MERINO FERNANDEZ ENTRE CALLE JUAREZ Y CALLE AYUNTAMIENTO, PRESIDENCIA MUNCIAL, COL. CENTRO, LOS REYES DE JUAREZ, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0edefd0b-7073-4b93-95da-90bbe88e5081"), Nombre = "UNIDAD DE INVESTIGACION METLALTOYUCA", IdMunicipio = new Guid("e3aac610-9d71-4750-a408-c2ba1de06a5f"), Direccion = "AVENIDA REYES GARCIA 57 COLONIA ERMITA, METLALTOYUCA, PUEBLA. CP 73000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3a1b93b7-30e8-4aba-bb0d-ead91b06d4db"), Nombre = "UNIDAD DE INVESTIGACION OCOYUCAN", IdMunicipio = new Guid("fd568848-1d55-4fc3-aee4-8e5ea8d9a2c4"), Direccion = "PLAZA PRINCIPAL S/N PLANTA BAJA, PALACIO MUNICIPAL, COL. CENTRO, SANTA CLARA OCOYUCAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("7d6dd043-7963-4eab-88aa-dc62d8ae2261"), Nombre = "UNIDAD DE INVESTIGACION ORIENTAL", IdMunicipio = new Guid("8f75b923-3632-4e2f-b4ed-7515e6186c47"), Direccion = "AV. AYUNTAMIENTO NO. 3 COL. CENTRO CP 75020" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c0fc46be-a67f-434b-82b6-46bca45a0d94"), Nombre = "UNIDAD DE INVESTIGACION ORIENTE", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "PROLONGACIÓN 16 ORIENTE ESQ. CON LIBRAMIENTO A TEHUACAN COL. MEXICO 68" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3414abc8-08be-4deb-8516-d73fc4758626"), Nombre = "UNIDAD DE INVESTIGACION PALMAR DE BRAVO", IdMunicipio = new Guid("4169b1d9-9250-431b-ad0e-e376dedbbe5d"), Direccion = "CALLE NICOLAS BRAVO #504 COL. CENTRO PLAMAR DE BRAVO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a172a1a9-6d33-4d48-8140-222be2d29ca5"), Nombre = "UNIDAD DE INVESTIGACION PIAXTLA", IdMunicipio = new Guid("0016b4cd-c631-41ce-9f68-95548bfb6d4a"), Direccion = "PLAZA EXPLANADA PALACIO MUNICIPAL S/N COL. CENTRO PRIMER PISO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("56ced837-0519-4403-a2b1-63347a0247a8"), Nombre = "UNIDAD DE INVESTIGACION SAN GABRIEL CHILAC", IdMunicipio = new Guid("2cd2b213-bf6e-4518-bd69-aa5ee56aa419"), Direccion = "AVENIDA NIÑOS HEROES SIN NUMERO COLONIA EL SOL, SAN GABRIEL CHILAC, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("fc51337e-3ff2-4e72-9b00-08400529ee67"), Nombre = "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA", IdMunicipio = new Guid("912b0fd3-7578-48ee-9bab-124f90ea30d3"), Direccion = "CALLE 15 NORTE SIN NÚMERO, SEGUNDO PISO, SAN MATÍAS COCOYOTLA, SAN PEDRO CHOLULA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b78c8eb5-c9f6-4fe8-8d7a-b277796e8ffd"), Nombre = "UNIDAD DE INVESTIGACION SANTA RITA TLAHUAPAN", IdMunicipio = new Guid("bacd27c0-4eb5-44bf-9cb4-f9c737a6d9e3"), Direccion = "CALLE MIGUEL HIDALGO S/N COL. CENTRO 74100, SANTA RITA TLAHUAPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c40e712c-7ae3-4339-be44-b1b2292c3806"), Nombre = "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN", IdMunicipio = new Guid("d67741af-e356-458b-94ef-4f48bd7c5aa8"), Direccion = "11 PONIENTE ENTRE 1 SUR Y AV. NACIONAL, SANTIAGO MIAHUATLAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("cd6e6ab0-c3f4-4008-982f-ac88585b78b0"), Nombre = "UNIDAD DE INVESTIGACION TECALI DE HERRERA", IdMunicipio = new Guid("108ca3a5-91f6-4c7c-b261-b003cc15813f"), Direccion = "CALLE DE HERRERA S/N COL. CENTRO, TECALI DE HERRERA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("09e97bae-3743-4ae4-9409-976f22c51cae"), Nombre = "UNIDAD DE INVESTIGACION TECAMACHALCO", IdMunicipio = new Guid("c7d4c93f-1e48-41a5-83a9-8cb883cef9de"), Direccion = "CALLE 10 SUR 507, BARRIO DE SAN JOSE, TECAMACHALCO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("30edd360-e0bc-481b-bcd9-607794feb5d8"), Nombre = "UNIDAD DE INVESTIGACION TEHUITZINGO", IdMunicipio = new Guid("ffd1e1de-f670-486f-a016-e78ed81fc055"), Direccion = "CALLE LA PRESA SECCIÓN TERCERA, TEHUITZINGO , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e968dcde-9b00-4444-9776-3a4428ab6ccb"), Nombre = "UNIDAD DE INVESTIGACION TEPANCO", IdMunicipio = new Guid("a53d0778-b9b0-40da-bf1f-ba7453b5f655"), Direccion = "PRIV. 8 PONIENTE S/N COL. CENTRO 75800, TEPANCO DE LOPEZ, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("4817859a-a50d-4d25-8947-ce688b074043"), Nombre = "UNIDAD DE INVESTIGACION TEPATLAXCO", IdMunicipio = new Guid("99af18a2-a030-4080-ab55-0fcb63659217"), Direccion = "2 SUR ESQUINA CON 9 ORIENTE S/N COL. CENTRO, TEPATLAXCO DE HIDALGO, PRIMER PISO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2dac919a-f66c-4df0-90f4-579f89899e8c"), Nombre = "UNIDAD DE INVESTIGACION TEPEACA", IdMunicipio = new Guid("d4ac176e-55a9-45e4-9053-10b44f883bd6"), Direccion = "AVENIDA HIDALGO NÚMERO 509 A, TEPEACA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("da490ddf-d2f6-47a0-bcf2-3310363ea2fc"), Nombre = "UNIDAD DE INVESTIGACION TEPEOJUMA", IdMunicipio = new Guid("a82fba97-2ed6-4848-8ec8-bbde9ccbfc1a"), Direccion = "CALLE IRINEO VAZQUEZ, NÚMERO 1, TEPEOJUMA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e61c6c1f-1910-49ff-9cb1-bc62da38c73b"), Nombre = "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ", IdMunicipio = new Guid("c76f5daa-fddd-4abb-a861-df871d4cf4b0"), Direccion = "CALLE 5 DE FEBRERO PLAZA COMUNITARIA PROF .ABEL CRUZ GARCIA , NÚMERO 3  COL CENTRO, TEPEXI DE RODRIGUEZ PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6b3e8002-a241-4e89-899a-06261cb4b913"), Nombre = "UNIDAD DE INVESTIGACION TEPEYAHUALCO", IdMunicipio = new Guid("349731cc-3810-44c4-b445-71ff01c61caf"), Direccion = "CALLE PRIMERA DE VENUSTIANO CARRANZA Y CALLE PRIMERA MORELOS S/N TEPEYAHUALCO, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1e3c4fab-fc30-4bfb-b3ce-08d738aeed93"), Nombre = "UNIDAD DE INVESTIGACION TETELA DE OCAMPO", IdMunicipio = new Guid("554efbe1-bfdb-4795-acbc-77476dd16085"), Direccion = "7 PONIENTE #1, COLONIA CENTRO, TETELA DE OCAMPO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("985f2f6f-52da-4748-8aa9-dd8a0ed31d67"), Nombre = "UNIDAD DE INVESTIGACION TLACOTEPEC", IdMunicipio = new Guid("1b221df8-c8e6-4f7b-9e7d-0d4c8969f307"), Direccion = "PLAZA COMUNITARIA CALLE AGUASCALIENTES SIN NUMERO COLONIA CENTRO 75680" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b8ea7fe6-2292-4b65-b514-e09d8cac64ba"), Nombre = "UNIDAD DE INVESTIGACION TLALTENANGO", IdMunicipio = new Guid("9c702270-caf2-4ffd-ad1c-0de66c489b5b"), Direccion = "REAL DE SAN PEDRO NO 15 COL. CENTRO, C.P.72600, TLALTENANGO, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("857aa1ad-e0c6-4411-864d-da72efabda09"), Nombre = "UNIDAD DE INVESTIGACION TLAOLA", IdMunicipio = new Guid("537bb756-17a5-47fc-b120-422d42fbb510"), Direccion = "ESQUINA QUE FORMAN LAS CALLES MORELOS Y CUAUHTEMOC NÚMERO 1, TLAOLA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b5dd07e7-c359-462c-b5b9-b386a6a0bacf"), Nombre = "UNIDAD DE INVESTIGACION TLAPANALA", IdMunicipio = new Guid("1242ec1e-21fe-4df0-a3b9-19a802b81495"), Direccion = "PALACION MUNICIPAL S/N TLAPANALA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1fedb2b2-25ed-455c-9043-7d8de47c56f1"), Nombre = "UNIDAD DE INVESTIGACION VALSEQUILLO", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "BOULEVARD VALSEQUILLO ESQU. 20 DE NOVIEMBRE COL. SAN BALTAZAR CAMPECHE,PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("232845d9-e879-4641-9b0f-6a477185dc50"), Nombre = "UNIDAD DE INVESTIGACION VILLA FRONTERA", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE FRANCISCO I. MADERO NO. 07 COL. CENTRO, SAN PABLO XOCHIMEHUACAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5b29e6a3-f535-4f42-b77c-29fe81911aba"), Nombre = "UNIDAD DE INVESTIGACION VIRTUAL PREDENUNCIA EL CARMEN", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 21 ORIENTE NO.404, COL. EL CARMEN, PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("262e5839-3058-4fb0-99ac-a08b30f5a513"), Nombre = "UNIDAD DE INVESTIGACION VW", IdMunicipio = new Guid("66e2e131-1cc7-414d-a4eb-2795e11adc79"), Direccion = "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("252418e4-f894-4dab-a27b-6772e6729136"), Nombre = "UNIDAD DE INVESTIGACION XICOTEPEC DE JUAREZ", IdMunicipio = new Guid("42a91eae-d655-4e1d-ae93-d0f05644c956"), Direccion = "CALLE 2 DE ABRIL 117 COLONIA CENTRO, XICOTEPEC DE JUAREZ, PUEBLA." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c27dec8f-eefc-47a7-b560-c08b46064999"), Nombre = "UNIDAD DE INVESTIGACION Y MEDIOS ALTERNATIVOS", IdMunicipio = new Guid("3e191fda-da34-44ca-b4bb-250221113af2"), Direccion = "AV. 5 DE MAYO NO.1 EXTERIOR DE LA PRESIDENCIA MUNICIPAL, GUADALUPE VICTORIA , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("426f19c9-435e-45df-b75c-be778b4bf5a8"), Nombre = "UNIDAD DE INVESTIGACION ZACAPOAXTLA", IdMunicipio = new Guid("44531449-928c-44d8-ad72-08a007376f44"), Direccion = "CALLE 2 DE ABRIL SUR, EDIFICIO REVOLUCIÓN ESQUINA IGNACIO COETO ,COL. CENTRO ZACAPOAXTLA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c3ea6749-ed2a-4ff8-b9f4-ce7f4a422e05"), Nombre = "UNIDAD DE INVESTIGACION ZARAGOZA", IdMunicipio = new Guid("6a791658-fcd5-4327-a0b5-fd6cdb7186b0"), Direccion = "CALLE 3 ORIENTE 1211 COLONIA SANTA ANA, ZARAGOZA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("410fe8f5-f67f-4ccb-89e2-cfd3831ec6e5"), Nombre = "UNIDAD DE INVESTIGACION ZOQUITLAN", IdMunicipio = new Guid("c230a882-643e-4852-b8f6-235521115256"), Direccion = "CALLE JUVENTUD S/N COL. CENTRO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("99a615bb-9e36-44e6-a400-b20289314022"), Nombre = "UNIDAD ESPECIALIZADA ADSCRITA A LA FISCALIA METROPOLITANA (JUZGADOS PENALES)", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 12 ORIENTE NO. 608 COL. CENTRO ,PUEBLA, PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("205e805a-dd6f-4371-be67-dc8d8bfb2fce"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO DE VEHICULOS (OCRA)", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CAMINO AL BATÁN KM2.5 COL.LOMAS DE SAN MIGUEL PUEBLA,PUE. CP.: 72573" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("526a433b-bd0c-4f7b-a2e6-22d9c3a4099a"), Nombre = "UNIDAD INTEGRAL DE SERVICIOS EL ALTO", IdMunicipio = new Guid("7a56fc4a-2356-417c-88e8-cdcb5e00123d"), Direccion = "CALLE 8 ORIENTE, NUMERO 1007, COLONIA SAN FRANCISCO, PUEBLA, PUE." });


            //Tipos de Cargos Homologados

            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("d0494553-4950-4acb-99f2-00262723f367"), Nombre = "AGENTE DEL MINISTERIO PUBLICO" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("5a9a3825-c6ae-48bf-9cc1-ea77b41b3100"), Nombre = "AGENTE INVESTIGADOR" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("ac02f4cb-5aa7-4060-9d12-f896def849c8"), Nombre = "ANALISTA DE INFORMACION" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("66327b82-45e5-4f68-9351-67ddd2f6fb9a"), Nombre = "ESTRUCTURA" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("ab0020d1-c6c5-4603-8caa-24f587d89d51"), Nombre = "FACILITADOR" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("8fce62fb-a90a-4782-87e4-12db38017dfa"), Nombre = "PERITO" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("148f9dad-2c97-4feb-889f-36fa41182a76"), Nombre = "PERSONAL ADMINISTRATIVO" });
            //modelBuilder.Entity<CargoHomologado>().HasData(new Cargo { Id = new Guid("44886160-7c9e-4ab7-82ea-ce1c2c684733"), Nombre = "PERSONAL DE APOYO SUSTANTIVO" });

            //Tipos de Cargos - Nuevos
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("35f230e5-95d9-4740-9d5e-a2d6330bcbb3"), Nombre = "AGENTE DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("593c34fc-af4d-443e-a583-f2038a971e63"), Nombre = "AGENTE INVESTIGADOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9a694e5a-d4aa-41de-818f-a916f4f0a47d"), Nombre = "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE SAN PEDRO CHOLULA)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("aa32ac89-9b43-48e6-88af-18b1ec2ac0fa"), Nombre = "AGENTE INVESTIGADOR ( ENCARGADO DE APOYO POLICIAL DE TEHUACAN)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5040fa04-5492-4f84-aa6b-ae150fcd14b7"), Nombre = "AGENTE INVESTIGADOR (ENCARGADO DE APOYO POLICIAL DE SAN ANDRES CHOLULA)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("4694b457-6ef2-4963-ae78-ff7e59b198b8"), Nombre = "AGENTE INVESTIGADOR (ENCARGADO DEL DESPACHO DE LA DIRECCION DE INTERVENCION INMEDIATA)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("53d194e7-48d2-4eab-9e4d-dc76d50587e0"), Nombre = "AGENTE INVESTIGADOR(ENCARGADO DE APOYO POLICIAL DE CUAUTLANCINGO)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6a2e9821-91b9-4288-88de-b34f2bb99d9a"), Nombre = "AGENTE INVESTIGADOR, ENCARGADA DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0a7a3893-e6a1-4877-b46b-2e182c6f8489"), Nombre = "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("96917de1-28e2-43d4-b835-4b2dd1092dba"), Nombre = "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("94aa3a6a-edc9-4474-8f9a-6df79360e01a"), Nombre = "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5881b348-068f-42ee-8777-74b5a0c30c51"), Nombre = "AGENTE INVESTIGADOR, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5e5ecc06-7eb4-4285-a6e6-2b364e59d8df"), Nombre = "AGENTE INVESTIGADOR, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("4d60047d-f909-4d07-a580-ba8ead2b194f"), Nombre = "AGENTE MINISTERIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("74979f8d-97c6-46fe-8149-ec508e22e73d"), Nombre = "ANALISTA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d8dfd562-cf8a-41e6-a572-2f29b4c5de58"), Nombre = "ANALISTA " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a18fa257-fa4e-405e-a712-3b5f78250cfd"), Nombre = "ANALISTA DE INFORMACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("16c6cee1-5f83-4a8f-842f-14fd9076c65c"), Nombre = "ASESOR ESPECIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f1e6482f-9cf9-433b-8b30-047edf19467b"), Nombre = "ASESOR TECNICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("fc7cb1e0-a22b-411a-8da9-335b74606583"), Nombre = "ASESOR TECNICO, RESPONSABLE DEL AREA NORMATIVA DE LA DIRECCION CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("54101122-6e91-42a3-a458-3d4d6156d35f"), Nombre = "AUXILIAR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("7ca27770-d11b-432d-89cf-53c905d520a2"), Nombre = "AUXILIAR DE FACILITADOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0c8b53be-d105-43a5-a316-fb078427f91f"), Nombre = "AUXILIAR DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("27ec76fb-1551-4b0e-b8ec-0d8858c16cb4"), Nombre = "COMANDANTE MINISTERIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("03b07bb4-dc2b-4369-afec-133bba26da3d"), Nombre = "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE AMOZOC)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9167fc65-0416-4837-91f2-ddbd8a0c55ef"), Nombre = "COMANDANTE MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE SAN MARTIN TEXMELUCAN)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("35b34c2c-484b-4d80-82eb-ce99a3424eac"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("4ccb61b9-5693-408a-8aa0-66cf1a284552"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cae3c364-b530-4e2b-b65a-1a1b7fc965c6"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("184aa5ad-2201-4458-8916-8c7cb7688e5d"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9b54e77a-0aad-4d40-a6f6-769075bffd2d"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE DESPCHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("86c0688b-3bf3-47af-b3c6-e1bbc2bbd367"), Nombre = "COMANDANTE MINISTERIAL, ENCARGADO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("30001459-aab0-4c6f-b7cc-b6d758ae3b5a"), Nombre = "COMANDANTE, ENCARGADO DE DESPACHO DE LA DIRECCION DE INVESTIGACION DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a831d19c-b733-406d-92eb-bc9950068ce8"), Nombre = "COORDINADOR DE ANALISIS ESTADISTICA Y BASE DE DATOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("500c309a-1fca-46cb-be2b-7ef05f774bb8"), Nombre = "COORDINADOR DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("54bb2be3-9066-4002-a1e3-9fa5e556c552"), Nombre = "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a5549901-7b6c-4106-b738-6265bccb61f3"), Nombre = "COORDINADOR DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("778e91ef-b9df-4ab8-ac1c-89e64fbb48e4"), Nombre = "COORDINADOR DE LITIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0273cab0-21d4-4c77-84fb-4ecd421055d9"), Nombre = "COORDINADOR DE LITIGACION DE LA FISCALIA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d37b21d2-175f-434a-862d-76755c1baad9"), Nombre = "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c180e628-6b5e-4ae3-8324-f8cd95dbaef3"), Nombre = "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("48097932-e268-43fb-9e39-1dfe40ab1620"), Nombre = "COORDINADOR DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a58df3e0-2d4d-4124-9990-8ca6d930c241"), Nombre = "COORDINADOR DE MEDIOS ALTERNATIVOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("28409eeb-104b-47df-9fa0-d3217886c247"), Nombre = "COORDINADOR GENERAL DE ANALISIS DE INFORMACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ff52b028-e91a-4ec3-b407-c28edb7c5391"), Nombre = "COORDINADOR GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8b74cc38-c0f1-450b-bea9-2a7e3295c2eb"), Nombre = "COORDINADOR GENERAL DE DESARROLLO INSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("48f3fadd-1508-4f31-9383-53c7ca5a5346"), Nombre = "COORDINADOR GENERAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("dac27498-9d86-4196-adef-8311e24d1aec"), Nombre = "COORDINADOR GENERAL DE LITIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("bfffe331-abbe-4742-b71f-810f43e2d798"), Nombre = "COORDINADOR GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a4ae229d-36c9-4095-89ce-135b38a0f1fa"), Nombre = "COORDINADOR GENERAL DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("77af20f3-d48c-4f7b-adaa-74a35797cc6e"), Nombre = "COORDINADOR INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("62133114-2fa7-4ea9-a3ae-4eb1e2a7eb05"), Nombre = "COORDINADOR(A) DE MEDIOS ALTERNATIVOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("1f3c0415-c148-45a5-86a3-5c2c33bc38a2"), Nombre = "COORDINADORA DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0e06a1f1-7b84-4aed-aad1-aae581a415b9"), Nombre = "COORDINADORA DE INVESTIGACION DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6c9cab3c-cafa-4525-8765-c7be1c71e7a2"), Nombre = "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN ASUNTOS INTERNOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("766ad9f3-10dc-4df2-905c-05fa96f64233"), Nombre = "COORDINADORA DE INVESTIGACION DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9f6b4a71-c59b-44bc-a9f7-bbf68ce448cc"), Nombre = "COORDINADORA DE INVESTIGACION, ENCARGADA DEL DESPACHO DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("11aa1204-6cbc-4d6d-ab0c-b9082310d046"), Nombre = "COORDINADORA DE LITIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("01e70220-a3ef-4c8e-a0df-6fc8bf40f062"), Nombre = "COORDINADORA DE LITIGACION DE LA FISCALIA DE INVESTIGACION METROPOLINATA " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("63448169-d24c-43b2-8012-bce9bd81ba73"), Nombre = "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("bd1f7545-2c2c-42b8-b0cb-25d7c99c29e6"), Nombre = "COORDINADORA DE LITIGACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("34c2b5ab-f1db-4183-92c8-561e18539f21"), Nombre = "COORDINADORA DE MEDIOS ALTERNATIVOS DEL AREA DE LA REGION PONIENTE" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2ecaa075-e4e7-48e2-a8b9-0ddebeca2412"), Nombre = "COORDINADORA GENERAL DE COLABORACION INTERINSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("410c0b79-4761-4a61-9aa0-d8d0e3bccac2"), Nombre = "COORDINADORA GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b6dcca3f-5e8e-4fb6-9fc6-466a61b2d5d7"), Nombre = "DIRECTOR DE APOYO Y LOGISTICA ADMINISTRATIVA DE LE VISITADURIA GENERAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("fa627a73-0bd4-418a-8dac-8709b7566cf0"), Nombre = "DIRECTOR DE AREA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e77721de-2182-47e8-ba54-080a1b533adf"), Nombre = "DIRECTOR DE ASUNTOS INDIGENAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("360b1252-f739-4445-a6b4-98d7016adc1f"), Nombre = "DIRECTOR DE ATENCION A MANDAMIENTOS MINISTERIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5ab2e92a-a6df-4001-a357-33151dfbc900"), Nombre = "DIRECTOR DE ATENCION CIUDADANA DE LA COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("626af01f-6af9-41f8-8f9f-a98e6cb314d3"), Nombre = "DIRECTOR DE BIENES ASEGURADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("28de3497-d7ad-4d03-ac17-14aa806a2762"), Nombre = "DIRECTOR DE CALIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b95959c9-3143-4906-90dd-52a8d2e5976d"), Nombre = "DIRECTOR DE COLABORACION DE LA AGENCCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6eccb3d8-5907-4831-a59e-44aa7d18fb50"), Nombre = "DIRECTOR DE DESARROLLO FINANCIERO Y PRESUPUESTAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6d4b9970-47e6-42ea-9462-03cf99e2784b"), Nombre = "DIRECTOR DE INFORMACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ecdd7e59-084d-4372-a850-925cf303e780"), Nombre = "DIRECTOR DE INVESTIGACION DE LA VISITADURIA GENERAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c2a6c1c1-f9a5-43e7-8ec6-d1142c823a46"), Nombre = "DIRECTOR DE MANDAMINETOS JUDICIALES DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("19d94a22-f666-42e4-aa54-aae5f30d1d21"), Nombre = "DIRECTOR DE SEGURIDAD A SERVIDORES PUBLICOS, INSTALACIONES Y EVENTOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ad0ceb1f-504a-4420-a629-c9516d5e4267"), Nombre = "DIRECTOR DE SERVICIO PROFESIONAL DE CARRERA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b6a8963e-7062-4833-84e9-b37a68b24fbf"), Nombre = "DIRECTOR DE TECNOLOGIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("7fcd5229-71c2-4f71-894f-9e5653d0969d"), Nombre = "DIRECTOR GENERAL DE PLANEACION INSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8ae094bc-2d78-4d3f-85ca-704db06c6f00"), Nombre = "DIRECTOR GENERAL DE SEGURIDAD INSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f0a6f8c3-e476-45ad-ba26-0e4b1acff615"), Nombre = "DIRECTOR GENERAL DEL SERVICIO MEDICO FORENSE" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f669d723-a983-4c94-ba77-39d1363c7037"), Nombre = "DIRECTORA CONSULTIVA Y DE NORMATIVIDAD DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("da5bf6f4-3c0a-4522-9981-70659d986949"), Nombre = "DIRECTORA DE ADMINISTRACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ac53ffd6-1e6e-4ff5-82c1-93bcf64ca0c3"), Nombre = "DIRECTORA DE APOYO A LA INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cbd08941-8071-4587-8634-b16b7745ad2f"), Nombre = "DIRECTORA DE APOYO TECNICO OPERATIVO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("177313bd-de66-4d2f-9e63-32c8eb69d209"), Nombre = "DIRECTORA DE APOYO Y LOGISTICA ADMINISTRATIVA DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("fdc3bd62-b5a3-4732-bed3-df0d78817339"), Nombre = "DIRECTORA DE COMUNICACION SOCIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("222f8817-a919-42da-8efd-782f487d5bde"), Nombre = "DIRECTORA DE CRIMINALISTICA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e6702c15-b81d-4560-9a87-810d3939f5bd"), Nombre = "DIRECTORA DE GESTION DOCUMENTAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("619b37d0-c307-4745-a038-daf0700f9ffa"), Nombre = "DIRECTORA DE LABORATORIOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("38651a2e-4fa8-4ec8-9ab7-c6ce5afa82d0"), Nombre = "DIRECTORA DE LO CONTENCIOSO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("966e6431-5c8c-44c7-a80b-191c4a8715ef"), Nombre = "DIRECTORA DE OPERACION DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cbc1e1c7-fd36-48dd-9ef6-172f866be596"), Nombre = "DIRECTORA DE PROFESIONALIZACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b62ac4e9-48a7-400f-8ab7-d093b40641e5"), Nombre = "DIRECTORA DE RESPONSABILIDADES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("4aaf1b68-81d7-4490-9d41-0d78f88d69e9"), Nombre = "DIRECTORA DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL DE LA COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8ecf1984-75de-475a-8fd2-b92fc5a98736"), Nombre = "DIRECTORA DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e2eb4f41-676c-40e9-9213-0bacfaf1e55a"), Nombre = "DIRECTORA DE SUPERVISION TECNICA DE LA VISITADURIA GENERAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8cc11e9f-a13e-420a-a17c-c3c8a7ac0f5b"), Nombre = "DIRECTORA GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("dddaa1d9-e5fd-48ec-9298-0e32c4095e7f"), Nombre = "DIRECTORA REGIONAL DE INVESTIGACION DE LA COORDINACION GENERAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c4bae6f4-eb77-4bc9-953a-e47a967d052b"), Nombre = "ENCARGADA DE DESPACHO DE LA DIRECCION DE PLANEACION, PROGRAMACION, EVALUACION Y ORGANIZACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("7af398cd-7fb4-4328-ad78-4f0287482fc2"), Nombre = "ENCARGADA DE DESPACHO DE LA DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("52f954be-d31f-4cd2-8ff5-ab5823fe67f8"), Nombre = "ENCARGADA DE DESPACHO DE LA SUBDIRECCION DE PROYECTOS DE INVERSION Y BIENES MUEBLES E INMUEBLES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5f8ec1d8-4242-4da6-847c-5f20572d5288"), Nombre = "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION (TEZIUTLAN)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("934952f3-4c28-492c-be97-8630a65e2792"), Nombre = "ENCARGADA DE DESPACHO DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d28415b1-bfb9-4eb8-90d4-6e35bc1b55c7"), Nombre = "ENCARGADA DE DESPACHO DE LA UNIDAD DE SERVICIOS PERICIALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("31272963-6362-4bd7-a3d8-a0567eeadb87"), Nombre = "ENCARGADO DE DESPACHO DE DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8d744475-c50d-40c8-8d3e-91c1a5462994"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD DE FLAGRANCIA (HUAUCHINANGO)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("10301d51-7922-4e23-b7e1-f847c2cde3d1"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE NARCOMENUDEO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("261a4c97-0e35-4353-bd7d-ad1c5e061ae5"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN TRATA DE PERSONAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("bcea2722-432e-43d3-8040-46cb88669680"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA DE COMBATE AL SECUESTRO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("88c72324-a50c-4716-8e07-54c8d8017c2c"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5f4505f6-5f42-4c5d-85b6-597d4c604932"), Nombre = "ENCARGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2a04734c-c58f-4fc8-819a-ff8b326ae094"), Nombre = "ENCARGADO DE LA FISCALIA DE ZONA REGIONAL SUR (IZUCAR DE MATAMOROS)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cbb7161f-c5cc-4f08-b35b-646413c1968f"), Nombre = "ENCARGADO DEL DESPACHO DE LA SUBDIRECCION DE DESARROLLO ADMINISTRATIVO Y PLANEACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ba50798e-399f-4343-b52b-f7b53993bbee"), Nombre = "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("3c3f3bdd-6d70-47aa-86f1-44e42570f616"), Nombre = "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE PROVEEDURIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d851fe2c-ca9f-4aa0-9bd2-59e3c8610962"), Nombre = "ENCARGADO DEL DESPACHO DEL DEPARTAMENTO DE SINIESTROS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("70069f7b-fee1-4a13-aae5-da74666a9369"), Nombre = "ENCRGADO DE DESPACHO DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d4d8e18f-bea0-4547-b60b-767ab94a9f6f"), Nombre = "ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("821d8509-c900-49ec-878e-ebd255174c37"), Nombre = "ENLACE DE APOYO ADSMINISTRATIVO Y BIENES ASEGURADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8826d959-338d-47d7-965b-4017d6d386d1"), Nombre = "ENLACE DE APOYO JURIDICO (PENDIENTE OFICIO)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b91392e9-cf6a-4738-996c-e0968d587942"), Nombre = "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("df47294a-11eb-4cb7-a0f3-f26402c3847f"), Nombre = "ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ae6f888f-a3c3-4dc6-a36d-9014acacd162"), Nombre = "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5df5e537-953b-42b8-bcf8-2dc09e8f7156"), Nombre = "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION  DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a7f43660-49a0-436b-ab82-d6f08ab14056"), Nombre = "ENLACE DE GESTION DOCUMENTAL DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5f154595-96e6-49f8-ad5a-86d6eeb550de"), Nombre = "FACILITADOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("16dbcf26-c2b5-4de9-bd71-597171c7f3c2"), Nombre = "FACILITADORA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("41ffa416-1660-45b9-b5ef-bb5e3a51fc7c"), Nombre = "FISCAL DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2205d53e-82e7-4222-ae58-d24d9ed6918a"), Nombre = "FISCAL DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("203c2302-371e-44a9-9cc1-834900f29d7c"), Nombre = "FISCAL DE ZONA PONIENTE" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("3c6de366-c5c4-445c-980c-b4975cf0f4ae"), Nombre = "FISCAL DE ZONA SUR DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("eca1fb98-995c-4abb-8d9f-a6cff9bff3b0"), Nombre = "FISCAL ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES,COORDINADORA DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a336d28f-f5e3-4927-bc34-8e48b44a4c6c"), Nombre = "FISCAL ESPECIALIZADO DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c362e7cc-6169-4ef6-9966-3ee9e57ed7d0"), Nombre = "FISCAL ESPECIALIZADO DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("20458759-dac9-4579-bc14-3b20480781e0"), Nombre = "FISCAL ESPECIALIZADO EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6d2c7c85-9207-460a-ae94-a99e61a1b01d"), Nombre = "FISCAL ESPECIALIZADO EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("4ec5deb5-db2f-45e5-a99b-b7d350d8cfd8"), Nombre = "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PRECEDENCIA ILICITA, FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a491d4ce-671f-49cf-84b9-4bba51a10f53"), Nombre = "FISCAL ESPECIALIZADO EN INVESTIGACION DE LOS DELITOS DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c8a12d82-bd40-40d2-b78f-5b43ac2e8492"), Nombre = "FISCAL ESPECIALIZADO EN INVESTIGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("06d23cba-8825-4787-a76a-69acc3132609"), Nombre = "FISCAL GENERAL DEL ESTADO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("137a7a20-3692-4e98-99a0-133a882870bf"), Nombre = "HONORARIOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ee8c95f9-8438-40d2-985c-f577f50d05d8"), Nombre = "INSPECTOR GENERAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2a98f412-0d1b-487f-bc34-06fc1b6cd77b"), Nombre = "INVITADOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("908501cc-9993-4fe2-8257-c8b14514cac4"), Nombre = "JEFA DE DEPARTAMENTO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f486d22c-5d94-44d2-9d4e-52196a0867f4"), Nombre = "JEFA DE DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b8e51bdc-fca6-45ad-9f9e-97d62893f1a5"), Nombre = "JEFA DEL DEPARTAMENTO DE APOYO TECNICO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2fb58fee-a5aa-499f-87e8-63f92445959c"), Nombre = "JEFA DEL DEPARTAMENTO DE CONTROL DE INMUEBLES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("11762e06-28bd-4807-a523-67e09ff86304"), Nombre = "JEFA DEL DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("89f4699c-3bce-4e0b-9fdd-cd75027e5a20"), Nombre = "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE INVERSION Y BANCO DE PROYECTOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5c716978-4394-463c-a281-3075240b6775"), Nombre = "JEFA DEL DEPARTAMENTO DE EXPEDIENTES DE PERSONAL  DE LA SUBDIRECCION DE SERVICIOS PERSONALES DE LA DIRECCION DE ADMINISTRACION  DE LA OFICIALIA MAYOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("265b6fb1-9931-404b-8b29-8ec26effb629"), Nombre = "JEFA DEL DEPARTAMENTO DE GESTION DOCUMENTAL DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0575c16d-e0db-47f2-9edb-ea565c2fd2be"), Nombre = "JEFA DEL DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c70ba7be-da95-4e52-ac3e-823fbf058c7f"), Nombre = "JEFA DEL DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f694701a-4ed9-4808-a8e4-359a27740d69"), Nombre = "JEFA DEL DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA DE LA DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO DE LA OFICIALIA MAYOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9cee6ab6-0a39-477b-8425-2b245ccd619e"), Nombre = "JEFA DEL DEPARTAMENTO DE PROCEDIMIENTOS PARA EL DESTINO FINAL DE BIENES ASEGURADOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("19579446-96b6-476f-8eaf-e94fc311ecc3"), Nombre = "JEFE DE DEPARTAMENTO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("698c91a9-eef1-4aaa-afb5-ec3165dadbb0"), Nombre = "JEFE DE DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("bd60c318-f90f-4937-b329-4943010b5fb9"), Nombre = "JEFE DE DEPARTAMENTO DE INDICIOS Y BIENES AFECTOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("064f278b-2461-418b-90ad-5c81c5fff7d7"), Nombre = "JEFE DE DEPARTAMENTO DE INFORMACION VEHICULAR DE LA DIRECCION DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c7dffaf9-6306-46f1-9a21-7752d348678c"), Nombre = "JEFE DE GRUPO MINISTERIAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a082cd25-2262-474b-845b-20c49da7b537"), Nombre = "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE ATLIXCO)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2d4c71bf-0fb6-4420-88cd-ab5d481b98f2"), Nombre = "JEFE DE GRUPO MINISTERIAL (ENCARGADO DE APOYO POLICIAL DE TEPEACA)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d83fb7e8-d82e-4838-9b57-c3fbe7dd2d56"), Nombre = "JEFE DE GRUPO MINISTERIAL, ENCARGADO DE DESPACHO DE LA UNIDAD DE APOYO POLICIAL DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("fba77d27-28b6-4eda-97be-ee44eb4b746d"), Nombre = "JEFE DEL DEPARTAMENTO DE APOYO TECNICO " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c9fec10c-cd1d-44d4-964e-b81f434bbae6"), Nombre = "JEFE DEL DEPARTAMENTO DE CONTROL VEHICULAR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a1a4686d-46f1-4faa-ba80-567479279477"), Nombre = "JEFE DEL DEPARTAMENTO DE DISEÑO E IMAGEN INSTITUCIONAL " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("97fb1504-48ee-4460-a313-7ff4dbca6ff2"), Nombre = "JEFE DEL DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("36cd244f-d36f-4469-8b7d-f27a125c58ad"), Nombre = "JEFE DEL DEPARTAMENTO JURIDICO DE MANUALES ADMINISTRATIVOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("36fde145-e0b8-45b3-b95d-e37a4cc95d69"), Nombre = "OFICIAL A" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f080e0e7-6e1f-41dd-b432-e73906fcff63"), Nombre = "OFICIAL E" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("87d46917-7f04-4a59-975d-a72bdcc20f17"), Nombre = "OFICIAL I" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c1c81fc7-7ecb-4b38-b520-0bb93c7e85ac"), Nombre = "OFICIAL M" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("1c3267bd-dab9-4e35-a9f9-0f0a1364cc67"), Nombre = "OFICIAL R" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("76733838-b1db-4c0d-831d-d8844f26dbd3"), Nombre = "OFICIAL DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8a214f30-083a-43dd-970c-18c1ab84cdfa"), Nombre = "OFICIAL MAYOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("71f6e543-05e3-4346-b92d-ff3b515547aa"), Nombre = "PERITA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5fb3a3bf-9372-4d74-8884-a5156123e6cc"), Nombre = "PERITA EN CONTABILIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9378897d-3c18-4295-8518-21faf65f5811"), Nombre = "PERITO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("966bf88f-e037-4f6c-97c7-d30a9828d912"), Nombre = "PERITO EN CONTABILIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("746b3784-08d6-43f6-863c-ada46d4a5a12"), Nombre = "PERITO TECNICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("139887dd-0377-433a-b42f-4fd31703428e"), Nombre = "RESPONSABLE DEL AREA DE LO CONTENCIOSO DE LA COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2abf41c5-f1ca-4115-bc28-50a9e02c8294"), Nombre = "SUBDIRECTOR" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("0e9fe512-c47b-4546-9854-d6d7c47e6512"), Nombre = "SUBDIRECTOR ACADEMICO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("3c9aee73-53ec-4504-ad0f-08a4dcb3d9c2"), Nombre = "SUBDIRECTOR DE APOYO TECNICO OPERATIVO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("3a7137b4-a2de-42ee-81aa-1b13c12a807d"), Nombre = "SUBDIRECTOR DE CONTABILIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("dc6aa2a1-fff7-41d1-b26c-4be062d104cf"), Nombre = "SUBDIRECTOR DE CONTROL Y SEGUIMIENTO DOCUMENTAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("01510334-9dd9-488b-a89b-a082b4f453f4"), Nombre = "SUBDIRECTOR DE PROFESIONALIZACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e0c81eed-9072-47cd-bd5d-8598f7ac3b30"), Nombre = "SUBDIRECTOR DE RECURSOS MATERIALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("7dc71bc7-05f1-4676-82d0-54560136d092"), Nombre = "SUBDIRECTOR DE REDES DE LA DIRECCION DE INFRAESTRUCTURA TECNOLOGICA DE LA COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("3f49112f-f7f2-4433-98ec-d4f3ada920e8"), Nombre = "SUBDIRECTOR DE SUMINISTROS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("64363e08-1512-4cac-b30d-417b7e300f74"), Nombre = "SUBDIRECTOR DE TESORERIA DE LA DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8a459e96-d449-4f42-a412-961c0aea8128"), Nombre = "SUBDIRECTOR DE VEHICULOS Y BANCO DE ARMAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ac104386-d442-4203-aec8-1159745f7aa1"), Nombre = "SUBDIRECTORA DE CONTROL DE GESTION DE LA DIRECCION DE AUDITORIA DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("42a36d6f-01d7-46f6-b8c4-e90a434592e8"), Nombre = "SUBDIRECTORA DE FONDOS Y POLITICA PRESUPUESTAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("7017774e-2514-4c7f-9a08-8ef6bddd9790"), Nombre = "SUBDIRECTORA DE GLOSA DE GASTO CORRIENTE E INVERSION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6f225a75-f2b6-461f-ac76-3ecfef52046c"), Nombre = "SUBDIRECTORA DE LA DELEGACION TEHUACAN" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cda9acc4-94c0-44eb-b1a5-f579b61f0f17"), Nombre = "SUBDIRECTORA DE RECEPCION Y DESPACHO DOCUMENTAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("feef5cbb-64d4-41de-afb5-fcd8da2ed3e7"), Nombre = "SUBDIRECTORA DE SERVICIO CIVIL DE CARRERA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e903db7a-d78e-4094-84d1-8760539585e3"), Nombre = "SUBDIRECTORA DE SERVICIOS PERSONALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("de6b5495-e9b6-43eb-95c6-f447d03ed2dc"), Nombre = "SUBDIRECTORA DEL SERVICIO MEDICO FORENSE" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("bd11c0a6-75fa-46f9-a703-5842ce088c35"), Nombre = "TITULAR DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("13670d5f-bddb-4274-9679-31e24a8fd69f"), Nombre = "TITULAR DE LA DIRECCION METROPOLITANA DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d4f076ea-18cd-4899-987b-9b9e1c54137c"), Nombre = "TITULAR DE LA DIRECCION REGIONAL DE LITIGACION DE LA COORDINACION GENERAL DE LITIGACION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("828b21e9-4c4d-4428-b59b-a545b02d21c8"), Nombre = "TITULAR DE LA OFICINA DEL FISCAL GENERAL DEL ESTADO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("24f20c86-5d72-49dc-bd89-3090ea26c5fa"), Nombre = "TITULAR DE LA UNIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5f1a8517-157c-429e-8c2d-0b4340fd832a"), Nombre = "TITULAR DE LA UNIDAD  DE INVESTIGACION DE DELITOS RELACIONADOS CON PERSONAS DESAPARECIDAS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e4974367-c31e-46ab-a375-5994772bafce"), Nombre = "TITULAR DE LA UNIDAD COORDINADORA DE ARCHIVOS DE LA COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6f67d27c-38a6-4e70-a2c8-cbdd90abe529"), Nombre = "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("70a77508-cc1c-4f82-9af4-24606952a82c"), Nombre = "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("36bbd816-f0a9-48fc-a668-0b33fee64b50"), Nombre = "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("42960505-2789-4b23-82ac-e90601b3e53d"), Nombre = "TITULAR DE LA UNIDAD DE ANALISIS Y CONTEXTO DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e90e03b4-d62d-454e-b5bd-0b59c44f6935"), Nombre = "TITULAR DE LA UNIDAD DE DERECHOS HUMANOS DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8d446da1-4206-4dad-9855-bc5ddb24510e"), Nombre = "TITULAR DE LA UNIDAD DE FLAGRANCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9c66e495-7ddf-4d3f-b293-8d1cf51cb262"), Nombre = "TITULAR DE LA UNIDAD DE FLAGRANCIA CENTRAL I" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("094209ac-a783-4b99-b13e-7da82e0f7396"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL DE LA FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("988e2025-9650-45d6-b8a1-eee5812b7f15"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e15e3d5b-8fb8-4d15-8e29-549577534629"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA DE SISTEMA TRADICIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("5fd8bba5-f8a1-41b8-9bb6-8e3f67815ba8"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN DELITOS FINANCIEROS Y PATRIMONIALES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("ed158acd-e469-47f7-9ffa-c820b0b421d7"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN FEMINICIDIO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("11004dfa-721e-4834-a45c-abb0b77c0d2a"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN VIOLENCIA FAMILIAR Y DELITOS DE GENERO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("e068ed49-da14-48a5-9f89-5763cac17a81"), Nombre = "TITULAR DE LA UNIDAD DE INVESTIGCION DE PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d0e7d6a1-873f-4eae-b4b2-1d2e62727834"), Nombre = "TITULAR DE LA UNIDAD DE LOCALIZACION DE PERSONAS DESAPARECIDAS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c79ae3f9-4df9-4628-9741-0392063f2319"), Nombre = "TITULAR DE LA UNIDAD DE SITUACION PATRIMONIAL DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("f5b93b97-778c-4df4-b7f4-5e8107dc284e"), Nombre = "TITULAR DE LA UNIDAD DE SUSTANCIACION DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("23cdc855-96b5-4ddd-99a1-d57980ac0dc4"), Nombre = "TITULAR DE LA UNIDAD DE TRANSPARENCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("c48b6f63-f20e-4e43-a92e-8a584c809018"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS AMBIENTALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("49b515e1-92af-4f32-aff3-e078941daeec"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("51e230d1-a4e6-4cad-beeb-1a2bccb9da6f"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("a7c69146-2a72-4929-864e-66893241bf96"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("980e4407-af2a-45fc-9ab6-2cd2e3a216da"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("1478aaca-c922-41ab-8cab-34e6dce9aad8"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE  DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("dd55db68-ec82-47b7-b630-7941e8d67f08"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE INVESTIGACION DEL DELITO DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("75419c29-be4f-4f75-97f6-9b1af211349f"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES DE LA FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("611d87de-3f4c-44fa-8455-76822828cb8a"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("8e51c0d5-1b81-4946-b350-c175523ad26e"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LOS ANIMALES DE LA FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("538936b5-0a05-4ce7-ae22-a6be4b55a83e"), Nombre = "TITULAR DE LA UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6be4c160-2802-41d8-bc19-8da78dfa46b9"), Nombre = "TITULAR DE LA UNIDAD RESOLUTORA DE LA DIRECCION DE RESPONSABILIDADES DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("d193efc9-b89f-45d4-85ae-ed0ea8af8413"), Nombre = "TITULAR DE LA UNIDAD UNIDAD PARA LA BUSQUEDA DE MUJERES Y NIÑAS DESAPARECIDAS Y DELITOS RELACIONADOS A TRAVES DE LA APLICACION DEL PROTOCOLO ALBA Y LA COORDINACION CON LA ALERTA AMBER DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("2a2d1519-02d7-4b86-a76c-9ece94562a75"), Nombre = "TITULAR DE UNIDAD" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("6bb5329b-e07a-4c99-bd27-5994ad239e54"), Nombre = "TITULAR DE UNIDAD DE APOYO ADMINISTRATIVO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("9a790101-e4fe-4e8d-aa4c-b6e954a4db03"), Nombre = "TITULAR DEL DEPARTAMENTO DE CONTROL DE INDICIOS DE LA FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("fbd7b890-d200-4055-a7fc-973990f68c68"), Nombre = "TITULAR DEL INSTITUTO DE CIENCIAS FORENSES" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("cc85ec17-87d2-4ae2-a1ea-ea963534007b"), Nombre = "TITULAR DEL INSTITUTO DE FORMACION PROFESIONAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("057035c9-1e3d-4342-9e02-3b2c785bcae5"), Nombre = "TITULAR DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("81b47efb-2bfd-43f5-83cb-70fa069ee2c8"), Nombre = "TTITULAR DE LA UNIDAD DE INVESTIGACION ESPECIALIZADA EN ROBO A CASA HABITACION Y  ROBO A COMERCIO" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("23637a0a-a8f2-4cfd-a99d-95e4d0a2e70e"), Nombre = "VISITADOR GENERAL" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { Id = new Guid("b9ac7679-b2df-4f1c-aa1f-d54d823bcd91"), Nombre = "VISITADORA" });

            // Unidades Administrativas - NUEVOS

            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"), Nombre = "COORDINACION GENERAL DE ANALISIS DE INFORMACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"), Nombre = "COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"), Nombre = "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"), Nombre = "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"), Nombre = "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"), Nombre = "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"), Nombre = "COORDINACION GENERAL DE INVESTIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"), Nombre = "COORDINACION GENERAL DE LITIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"), Nombre = "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"), Nombre = "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"), Nombre = "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"), Nombre = "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"), Nombre = "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"), Nombre = "FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"), Nombre = "FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"), Nombre = "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"), Nombre = "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("d052658e-e743-478d-aa94-21f279ddde3d"), Nombre = "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("96559f1b-3880-4339-9c73-fed0ec116105"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"), Nombre = "FISCALIA GENERAL DEL ESTADO" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"), Nombre = "INSTITUTO DE CIENCIAS FORENSES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"), Nombre = "INSTITUTO DE FORMACION PROFESIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"), Nombre = "OFICIALIA MAYOR" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"), Nombre = "OFICINA DEL FISCAL GENERAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"), Nombre = "ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"), Nombre = "UNIDAD DE TRANSPARENCIA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"), Nombre = "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { Id = new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"), Nombre = "VISITADURIA GENERAL" });



            // Centros de Trabajo - NUEVOS 
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("14857a0c-5726-43af-9950-7b8b85084fcc"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0ec515f8-2154-463b-8df7-de4ecbd8e338"), Nombre = "ANALISIS DE DATOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("679bccff-7d12-499e-8803-ae991979d591"), Nombre = "AREA DE ANTROPOLOGIA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ed710842-48a2-4feb-9520-1a37b105e241"), Nombre = "AREA DE APOYO A LA PARTICIPACION MINISTERIAL EN EJECUCION DE SANCIONES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a49f9d38-3401-4bae-97a0-303e3eca305f"), Nombre = "AREA DE ESTOMATOLOGIA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2f299335-9020-423d-bcaa-7cc9f7da00a2"), Nombre = "COORDINACION DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a259c350-a83e-4509-b20a-af461a1c7a64"), Nombre = "COORDINACION DE LITIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("037a7ea3-76f8-4104-9c8c-f6ae6e012213"), Nombre = "COORDINACION GENERAL DE ANALISIS DE INFORMACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("53b28102-e768-4f15-a61d-3added76a7d9"), Nombre = "COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1ecf0a5b-31dd-407e-ab5f-f7b785d681df"), Nombre = "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("e871fd84-14f9-42f4-b315-ce28f91179a4"), Nombre = "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b6a594de-9c48-45e3-a3aa-37e8c8db2b58"), Nombre = "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("72937787-9da1-4935-baaf-e6c2a09f7f7b"), Nombre = "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("e4ebf95a-7447-4834-8c2b-62f31b2a5ef4"), Nombre = "COORDINACION GENERAL DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("71b9ff66-31c5-4afa-ae24-eb9797fae473"), Nombre = "COORDINACION GENERAL DE LITIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3d33f321-7b01-41c4-93c2-fe806f7193ad"), Nombre = "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7965570f-ca30-43a5-a1d9-be96f6cfef1b"), Nombre = "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("acddd9bf-9c1f-4aaf-b041-0044bb4e9a6c"), Nombre = "COORDINACION GENERAL GESTION DOCUMENTAL INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c607f860-7b53-4f7f-82ca-4d64e74d293f"), Nombre = "DEPARTAMENTO DE ADQUISICIONES Y ADJUDICACIONES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("40bb0628-1f28-4294-ad2f-959fe8983e7b"), Nombre = "DEPARTAMENTO DE AGENDA DIGITAL E IMAGEN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0156d640-b80c-4dbc-83ad-2261ef27ed2f"), Nombre = "DEPARTAMENTO DE ALMACEN GENERAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("89a94fe3-3cc4-46ee-a9b6-e08ae1abe468"), Nombre = "DEPARTAMENTO DE ANALISIS DE DATOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("94c9a231-c8b0-499e-964b-2d27859f04ea"), Nombre = "DEPARTAMENTO DE APOYO TECNICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("243c994a-8d22-4c2c-ba85-9fe06506602b"), Nombre = "DEPARTAMENTO DE BASE DE DATOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c88e59d7-a467-40d7-a0cd-121f706f0fef"), Nombre = "DEPARTAMENTO DE CAPACITACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("28456bcb-fd5d-43c4-b228-9ff61f0387c1"), Nombre = "DEPARTAMENTO DE CONTROL DE INDICIOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("cb13f2d3-d838-4fcd-ad79-5e3fc1d83349"), Nombre = "DEPARTAMENTO DE CONTROL DE INMUEBLES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("cc38fe74-70ea-415b-a9f8-209695911236"), Nombre = "DEPARTAMENTO DE CONTROL INTERNO Y FISCALIZACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("885cbb8b-eba1-42ca-a97a-862360f30d4b"), Nombre = "DEPARTAMENTO DE CONTROL Y ABASTECIMIENTO DE COMBUSTIBLE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("772a349e-edb1-485a-bc18-2670dcf8d75b"), Nombre = "DEPARTAMENTO DE DESARROLLO ADMINISTRATIVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2c174188-4853-45ed-a884-101cc0d72b09"), Nombre = "DEPARTAMENTO DE DESARROLLO DE APLICACIONES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b2336993-42ee-4694-98e1-2757e937545c"), Nombre = "DEPARTAMENTO DE EXPEDIENTES DE PERSONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("bc269e4f-eb0c-4db8-aec7-8eb0035833d1"), Nombre = "DEPARTAMENTO DE GESTION ADMINISTRATIVA DE ARMAMENTO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ecdb87c9-1fd1-4279-9416-90884206d1d4"), Nombre = "DEPARTAMENTO DE INCIDENCIAS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("139c4bf5-ad10-44e1-ad67-a217ec39889f"), Nombre = "DEPARTAMENTO DE INFORMACION ESTADISTICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2e3ae3c1-cd26-40f4-9603-51ab73f5793d"), Nombre = "DEPARTAMENTO DE INFORMACION VEHICULAR" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("241ab6a6-20dd-40a0-835e-8ea49bf1c5f4"), Nombre = "DEPARTAMENTO DE INVENTARIOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1e457c38-ab3b-4fa9-88b9-25974bfb2e68"), Nombre = "DEPARTAMENTO DE MANTENIMIENTO DE VEHICULOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9886561f-7069-407e-a68a-fa7c78b220fc"), Nombre = "DEPARTAMENTO DE MANUALES ADMINISTRATIVOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("37c3c3cd-1ec0-4fa0-b645-3ed1575a6a21"), Nombre = "DEPARTAMENTO DE MONITOREO Y ANALISIS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d7d011f7-4c2e-4463-8e98-3c94a59173c6"), Nombre = "DEPARTAMENTO DE MOVIMIENTOS Y PERCEPCIONES EXTRAORDINARIAS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b2a542d9-21e9-4a89-a548-3d4aed3ff191"), Nombre = "DEPARTAMENTO DE NOMINA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1044d758-b68e-4f43-8057-72de176f3ecc"), Nombre = "DEPARTAMENTO DE ORGANIZACION DE LA ESTRUCTURA ORGANICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("137ec4e4-d9bd-4814-8202-92cefb8b2fef"), Nombre = "DEPARTAMENTO DE PRODUCCION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a94f75d2-d82f-49bb-8e88-7e13211f6c61"), Nombre = "DEPARTAMENTO DE PROVEEDURIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b6747d6f-17a4-48ad-a15f-8e545f316329"), Nombre = "DEPARTAMENTO DE SERVICIOS GENERALES METROPOLITANOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5df8ba70-235a-448e-a391-c410e691167f"), Nombre = "DEPARTAMENTO DE SINIESTROS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9dbe42a0-2149-4dbd-acc5-1f46bfcbd0d4"), Nombre = "DEPARTAMENTO DE SOPORTE TECNICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a8937f35-bd05-4b24-a676-62d9445fe821"), Nombre = "DEPARTAMENTO DE TELECOMUNICACIONES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7ce9cffa-9978-4deb-b77e-06773772daaf"), Nombre = "DEPARTAMENTO JURIDICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a8dc6b96-798a-42a4-8bcd-0bd8a87ef5fc"), Nombre = "DEPARTAMENTO TECNICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3719b326-99b0-4d74-8dea-14bd4f419e74"), Nombre = "DIBUJO FISONOMICO Y DESCRIPTIVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("03dc23df-cbec-4f62-8fc8-84789cc972dd"), Nombre = "DIRECCION CONSULTIVA Y DE NORMATIVIDAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("207aff40-f781-44db-937a-97caa01b5a07"), Nombre = "DIRECCION DE ADMINISTRACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("4cab08b1-7745-4670-848c-9470e72b80a3"), Nombre = "DIRECCION DE APOYO TECNICO OPERATIVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b52da29c-7738-43be-84e2-ec1527e9df8c"), Nombre = "DIRECCION DE APOYO Y LOGISTICA ADMINISTRATIVA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("76c477aa-f9cf-4606-81c8-731687634314"), Nombre = "DIRECCION DE ATENCION A MANDAMIENTOS JUDICIALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0938d321-bcaa-428c-8eaa-14e7d354d2e5"), Nombre = "DIRECCION DE ATENCION A MANDAMIENTOS MINISTERIALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("782416fd-eeef-42d6-9601-e027bf0cd17b"), Nombre = "DIRECCION DE AUDITORIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9ca356ee-a17c-497a-aec3-837ba73aed31"), Nombre = "DIRECCION DE BIENES ASEGURADOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a36b19b2-6b3b-48a1-8de3-7012139aced3"), Nombre = "DIRECCION DE CALIDAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2e3b2256-a1be-4832-97d9-e8afee302086"), Nombre = "DIRECCION DE CAPACITACION Y POLITICA CRIMINAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("920bc0d0-d90b-4a2f-b4cd-4bcaef5ae735"), Nombre = "DIRECCION DE COLABORACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("06a92ca4-80d3-4eb7-ac95-4ac7a8824c2c"), Nombre = "DIRECCION DE CRIMINALISTICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9f9532cf-6664-404e-bd4a-31d3359dbd5b"), Nombre = "DIRECCION DE DESARROLLO FINANCIERO Y PRESUPUESTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1b4e1530-776b-41c7-ae6a-cc6aed8c95ed"), Nombre = "DIRECCION DE GESTION DOCUMENTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7e4e1508-6edb-49ed-8d11-4692e7620142"), Nombre = "DIRECCION DE INFRAESTRUCTURA TECNOLOGICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2d18e58d-b5ab-4d8c-a35d-133351ba10e8"), Nombre = "DIRECCION DE INTERVENCION INMEDIATA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2d0b6b32-d64d-45df-8f65-b08460273e08"), Nombre = "DIRECCION DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7620aa22-1651-4279-9782-075b9f40c974"), Nombre = "DIRECCION DE LABORATORIOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7b5a7643-da0b-4851-ac43-36e1fa18970b"), Nombre = "DIRECCION DE LO CONTENCIOSO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("45bfbce8-95dc-4280-9609-753a23721268"), Nombre = "DIRECCION DE OPERACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d8cf8195-becc-486e-bc1b-2c26a3ce0201"), Nombre = "DIRECCION DE OPERACION Y LOGISTICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("307a57f5-a06d-41f5-8d51-a40e919ce515"), Nombre = "DIRECCION DE ORGANIZACION Y DESARROLLO ADMINISTRATIVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("709fb7c8-efe7-4719-a69b-2e188b7edeea"), Nombre = "DIRECCION DE PROCEDIMIENTOS CONSTITUCIONALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f77ba83a-7ba9-45b1-87d4-6072eab942a8"), Nombre = "DIRECCION DE RESPONSABILIDADES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f2955861-8eaf-4462-846b-7218a0e18ed8"), Nombre = "DIRECCION DE SEGUIMIENTO, EVALUACION Y MEJORA INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("874c9447-6998-4338-a6cc-81b99b80b320"), Nombre = "DIRECCION DE SEGURIDAD A SERVIDORES PUBLICOS INSTALACIONES Y EVENTOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7cda7e26-4bbb-444d-914f-25d7278c63d4"), Nombre = "DIRECCION DE SERVICIO PROFESIONAL DE CARRERA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("04db10b5-c70a-46a8-a217-87176395079b"), Nombre = "DIRECCION DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("41e1a596-4062-44bb-81d6-ff2abc6ff97a"), Nombre = "DIRECCION DEL SERVICIO MEDICO FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("120caeb7-d927-45c7-9ad5-5d2e8efa20e1"), Nombre = "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL " });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("fc484510-44f8-44a8-9b48-c5235a88c441"), Nombre = "DIRECCION GENERAL DE LOS CENTROS DE JUSTICIA PARA LAS MUJERES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5bf2874d-86f6-4efa-b3d8-1efa49d2e19a"), Nombre = "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("948ad99b-28c8-4ab8-80dc-eb6d03670dfb"), Nombre = "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3775177d-6e57-4052-8c7e-b86de7e458bf"), Nombre = "DIRECCION METROPOLITANA DE LITIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9d201035-4504-4336-a71e-757fb80597f5"), Nombre = "DIRECCION REGIONAL DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("866c0af6-13bc-4c7a-b487-134903e8fb91"), Nombre = "DIRECCION REGIONAL DE LITIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("814d8a3a-9e2d-4549-a2d2-0e311665d8f8"), Nombre = "FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0742eed9-5104-41e6-9bbd-994bdd023fd4"), Nombre = "FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("02c61b7a-83d7-466d-827d-bf4b568bf980"), Nombre = "FISCALIA DE ZONA NORTE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("caa23ced-29b0-48e7-8d7c-8ce425f4ebdc"), Nombre = "FISCALIA DE ZONA ORIENTE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c5d36bd2-4df0-4406-93c5-c6570027d748"), Nombre = "FISCALIA DE ZONA PONIENTE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c4e2a663-6e84-44ad-86bc-313793f6886a"), Nombre = "FISCALIA DE ZONA SUR" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0c3bf90f-a529-440a-8541-9949ce59622a"), Nombre = "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("838f2b17-d0c6-4a95-8a84-c1fc74a244d5"), Nombre = "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("cc214ace-17c0-46f3-bbae-4f009d733b0c"), Nombre = "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1d8fad7e-5ffb-45e4-acba-21aaed6c8ed7"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d240b6fc-3eda-40b8-a321-c27c65f4f992"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("00fb4066-14d7-4b67-923f-64edfb0c0ca9"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d612a535-a2f8-4392-9c22-4fa4414bba52"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("37ed87e0-270a-4439-ac95-66eefefc8940"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA, FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b368427a-6054-4953-bae8-a490d7b9ab4c"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f5eaaa5c-84ab-4cd5-9a5b-755f3b0490a9"), Nombre = "FISCALIA GENERAL DEL ESTADO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("6073c150-4b2b-40aa-b4fd-1e5ed8852343"), Nombre = "INSPECTORIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("fb3c83c6-e5c8-4b68-b91d-d9c3d6d3e4b4"), Nombre = "INSPECTORIA REGIONAL DE ATENCION A MANDAMIENTOS JUDICIALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c81b1560-a3df-4aa5-abf5-5d1a87176c28"), Nombre = "INSTITUTO DE CIENCIAS FORENSES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a8e223ff-723f-4252-ae02-df68e9f240eb"), Nombre = "INSTITUTO DE FORMACION PROFESIONAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("49e42345-cd1d-4ea2-aada-74381adc81c2"), Nombre = "LABORATORIO DE ANALISIS DE EVIDENCIA DIGITAL Y MULTIMEDIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ab66ce22-1a78-475b-b01a-eb39c9c7e5bd"), Nombre = "LABORATORIO DE BALISTICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7781c7ea-75cc-4508-9e66-0af9d8c90424"), Nombre = "LABORATORIO DE DOCUMENTOS CUESTIONADOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("4fcd481b-1984-4218-8ef5-40e7d4eec2f1"), Nombre = "LABORATORIO DE GENETICA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b5566550-5ea4-41fb-a3b0-8ca90407b700"), Nombre = "LABORATORIO DE LOFOSCOPIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5cfa9394-371a-4ed1-8ba0-68c672617539"), Nombre = "LABORATORIO DE QUIMICA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("e91d1f13-07fa-45e6-bcce-908896f07108"), Nombre = "LABORATORIO DE TOXICOLOGIA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("349b5b67-5c44-4547-9538-0c2aa9eb9a8e"), Nombre = "LABORATORIO DE VETERINARIA Y ZOOTECNIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a96f42a9-7ea2-4883-adb5-06b61a7134d7"), Nombre = "MEDICINA FORENSE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b5e6d362-28e1-4774-a8fb-8959d14809db"), Nombre = "OFICIALIA MAYOR" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7c6f5d9e-06ad-4062-bb35-98d9ea8bd3d7"), Nombre = "OFICINA DE ENLACE DE APOYO ADMINISTRATIVO Y BIENES ASEGURADOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ec1d9727-0171-4e39-90b1-93e3c5a56780"), Nombre = "OFICINA DE ENLACE DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("157f5383-f7a5-4fb7-a3e0-8f448eebfe69"), Nombre = "OFICINA DE ENLACE DE GESTION DOCUMENTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c67577a1-881f-462d-afd9-be9dc2739e9d"), Nombre = "OFICINA DEL FISCAL GENERAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f111d895-8ae4-47df-8514-9730cffe1aa2"), Nombre = "ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("29293f3e-a959-42f9-b3c4-03f877d44a77"), Nombre = "PERSONAL PERICIAL EN MECANICA E IDENTIFICACION VEHICULAR" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b40d0254-4dd8-47bf-9b00-56f93ab2d8d3"), Nombre = "SOPORTE TECNICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5e252a0c-b26b-490b-8307-42f0d3bf0ee3"), Nombre = "SUBDIRECCION ACADEMICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("64a761af-fc93-4e89-a6b0-14cfd4e89f52"), Nombre = "SUBDIRECCION DE CONTABILIDAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("4042a56b-a0f5-4d70-ac58-ba1d3eea92d4"), Nombre = "SUBDIRECCION DE CONTROL VEHICULAR Y GESTION ADMINISTRATIVA DE ARMAMENTO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1ffae26c-0e9f-46e6-9e10-3ea79e12d4f0"), Nombre = "SUBDIRECCION DE CONTROL Y SEGUIMIENTO DOCUMENTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("271cd6f4-c9b5-4e23-bee2-961825581fdd"), Nombre = "SUBDIRECCION DE CRIMINALISTICA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("61b8c741-30b9-4922-8849-f76e75a35924"), Nombre = "SUBDIRECCION DE FONDOS Y POLITICA PRESUPUESTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("40ef13a0-a403-47eb-99ed-cbbfddc14b7e"), Nombre = "SUBDIRECCION DE GLOSA DE GASTO CORRIENTE E INVERSION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3425312a-1cf6-46d9-93b4-4fd8f08546f7"), Nombre = "SUBDIRECCION DE PROFESIONALIZACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ca19893b-40ec-4e64-8bae-5fe1c806e661"), Nombre = "SUBDIRECCION DE PROYECTOS DE INVERSION Y OBRA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f1e36322-0ebd-4bb4-a48c-b82a0bd82851"), Nombre = "SUBDIRECCION DE RECEPCION Y DESPACHO DOCUMENTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("90e7cae6-2737-488d-9e0a-2705381cd94b"), Nombre = "SUBDIRECCION DE RECLUTAMIENTO Y SELECCION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("23d08ff4-081d-4087-b058-607cac2c6f71"), Nombre = "SUBDIRECCION DE RECURSOS MATERIALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f00d62b4-cba1-42ff-a6e9-e02a20cc7378"), Nombre = "SUBDIRECCION DE SEGUIMIENTO AL SERVICIO PROFESIONAL DE CARRERA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9c8ad774-4c3f-4007-80d9-81119113da69"), Nombre = "SUBDIRECCION DE SERVICIO CIVIL DE CARRERA POLICIAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("6b78a988-6178-4975-b185-5398b39298a1"), Nombre = "SUBDIRECCION DE SERVICIOS PERSONALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ddd58013-6fd7-49ce-9238-678f52514f71"), Nombre = "SUBDIRECCION DE SUMINISTROS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("31901775-40a9-47b6-be93-b71405886737"), Nombre = "SUBDIRECCION DE TESORERIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("604c02b2-a9b7-41d6-a554-6fdf24473727"), Nombre = "SUBDIRECCION DEL DEPARTAMENTO TECNICO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5f13706d-6951-4e9d-9038-75b8f44af40a"), Nombre = "UNIDAD COORDINADORA DE ARCHIVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f2c2b4d4-0758-4674-bd31-853f49b084d5"), Nombre = "UNIDAD DE ANALISIS Y CONTEXTO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9f823392-956c-4a30-997f-2d5a8c2f138b"), Nombre = "UNIDAD DE APOYO PERICIAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ad389f36-c2ec-49e1-a986-0245364fa9cd"), Nombre = "UNIDAD DE APOYO POLICIAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f51c89b7-a52b-47b2-993b-78b6659d3ce8"), Nombre = "UNIDAD DE DERECHOS HUMANOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("8b8c8b80-9366-4ff6-abe6-45ca74a74307"), Nombre = "UNIDAD DE INVESTIGACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9b341049-dda6-4371-b944-029f12a31999"), Nombre = "UNIDAD DE INVESTIGACION ACAJETE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("50fc4491-2f92-439e-a24a-dfab03be0831"), Nombre = "UNIDAD DE INVESTIGACION ACATENO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("46899891-2ac0-4fcc-9ee2-df196b231990"), Nombre = "UNIDAD DE INVESTIGACION ACATLAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f87e04f2-f8fb-483e-a5ac-7e253a13b383"), Nombre = "UNIDAD DE INVESTIGACION ACATZINGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a7959698-67dd-486a-9d51-64e0cf62fc35"), Nombre = "UNIDAD DE INVESTIGACION AHUAZOTEPEC" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1aa0ada5-9476-4436-8f70-c58e641ae266"), Nombre = "UNIDAD DE INVESTIGACION AJALPAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("080a04dd-17a3-4e64-9b95-c927622d6b55"), Nombre = "UNIDAD DE INVESTIGACION AMOZOC" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0ad23e72-3b3c-4e2b-9b43-8e9b0f5dddab"), Nombre = "UNIDAD DE INVESTIGACION ARCO ALTEPEXI" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5b3759ce-2699-46ea-bbf0-7c2fe967f68e"), Nombre = "UNIDAD DE INVESTIGACION ATEMPAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0bb5107d-2675-4e22-9bd5-d1f1ce190b2f"), Nombre = "UNIDAD DE INVESTIGACION ATENCINGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9d4fdf2f-07b3-403a-a480-12aa4865af36"), Nombre = "UNIDAD DE INVESTIGACION ATLIXCO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("09e578c5-4254-4331-9d04-31d78e472d24"), Nombre = "UNIDAD DE INVESTIGACION CALPAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("559c527b-fb7d-4309-8abb-b5937e84dae6"), Nombre = "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d6960afd-f704-4784-be6c-9babc8b01e53"), Nombre = "UNIDAD DE INVESTIGACION CHIETLA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1f69ef84-bd7b-424a-aa2e-c73311003c7e"), Nombre = "UNIDAD DE INVESTIGACION CHIGNAHUAPAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("590193fa-dbff-419a-8f1c-34cebdb2e0d2"), Nombre = "UNIDAD DE INVESTIGACION CIUDAD SERDAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("8b528d78-1eff-4f6c-92f6-2f591a2890e8"), Nombre = "UNIDAD DE INVESTIGACION CORONANGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a50efc22-a215-48c7-b998-d833591a70ef"), Nombre = "UNIDAD DE INVESTIGACION CUAUTLANCINGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("fa84b0ce-4718-40dc-a7f0-6c3d43b96a63"), Nombre = "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b49f48d6-f6e2-4cf8-bad1-2d9dd97ed53c"), Nombre = "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO ESTATAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("061ae677-a443-4268-91a5-fb14abb3c0de"), Nombre = "UNIDAD DE INVESTIGACION DE HECHOS DE CORRUPCION EN EL AMBITO MUNICIPAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7252d7c0-8cc2-4f01-8804-cb69cf2d8768"), Nombre = "UNIDAD DE INVESTIGACION ESPERANZA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f6ee43a7-0bf8-484f-a026-308b369728d1"), Nombre = "UNIDAD DE INVESTIGACION GUADALUPE VICTORIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("52d88fe5-751f-4b06-a7b4-a1d76a61ebd5"), Nombre = "UNIDAD DE INVESTIGACION HUAUCHINANGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("65057b85-64c2-477f-bf19-71f45ef93d04"), Nombre = "UNIDAD DE INVESTIGACION HUEJOTZINGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("964b286a-42fc-40fd-9eaf-b35bc29b297d"), Nombre = "UNIDAD DE INVESTIGACION HUEYTAMALCO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c278df06-8caf-4ae3-93f6-2348ac224635"), Nombre = "UNIDAD DE INVESTIGACION IZUCAR DE MATAMOROS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("8108e8d4-65a8-48a5-97b2-0a4f737e8fa8"), Nombre = "UNIDAD DE INVESTIGACION JUAN C. BONILLA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a0931e91-e5b4-426d-995f-7bc2b27696f1"), Nombre = "UNIDAD DE INVESTIGACION LIBRES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2833c2d0-9fc6-45ff-a526-f4f96c914e4f"), Nombre = "UNIDAD DE INVESTIGACION METLALTOYUCA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("646e2888-04ed-4477-926d-b3219c33615b"), Nombre = "UNIDAD DE INVESTIGACION ORIENTAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0ed848e5-f85c-4dd3-add3-4f9133311bcd"), Nombre = "UNIDAD DE INVESTIGACION PALMAR DE BRAVO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c8c74d78-66e0-495d-a487-889dc261c729"), Nombre = "UNIDAD DE INVESTIGACION PUEBLA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("57e1b0ca-fe6f-4a77-9464-2e6c0769f448"), Nombre = "UNIDAD DE INVESTIGACION SAN ANDRES CHOLULA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ec29dde9-674a-475b-b52b-2481507775a4"), Nombre = "UNIDAD DE INVESTIGACION SAN JOSE CHIAPA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("6ece0abc-b326-4d03-b73f-bad9dc6717b9"), Nombre = "UNIDAD DE INVESTIGACION SAN MARTIN TEXMELUCAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("273c5e41-bd3e-41e2-a735-3be0df7b19e8"), Nombre = "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b80a22e6-2f02-469f-a828-d970019b8b9c"), Nombre = "UNIDAD DE INVESTIGACION SAN SALVADOR EL SECO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("97ff2834-00af-4cd4-914c-5937eccab1cf"), Nombre = "UNIDAD DE INVESTIGACION SANTA CLARA OCOYUCAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("5088ae63-9898-4611-9e21-1da84f712788"), Nombre = "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b971a047-978b-4619-9558-a9aa2fb61649"), Nombre = "UNIDAD DE INVESTIGACION TECALI DE HERRERA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("07a86883-d8a2-4bab-847b-deada8173075"), Nombre = "UNIDAD DE INVESTIGACION TECAMACHALCO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c03fceb1-fdbd-4d04-b042-39641218d680"), Nombre = "UNIDAD DE INVESTIGACION TEHUACAN " });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b9585698-a19b-446a-8c5f-5e6e511a331d"), Nombre = "UNIDAD DE INVESTIGACION TEHUITZINGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0aa7c9d3-32d3-4eac-a278-630f177434ed"), Nombre = "UNIDAD DE INVESTIGACION TEPANCO DE LOPEZ" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("52c65165-2e63-4735-ba2c-7ef5eccb2e6f"), Nombre = "UNIDAD DE INVESTIGACION TEPATLAXCO DE HIDALGO " });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a88dd458-2593-4761-8b19-db57c5bf088c"), Nombre = "UNIDAD DE INVESTIGACION TEPEACA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b167bc0e-2b8f-471a-81b6-3de89577d35e"), Nombre = "UNIDAD DE INVESTIGACION TEPEOJUMA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("91506cde-e85b-47cc-9ee3-f0cad01f1c78"), Nombre = "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0396f6fc-98a0-46f7-8c33-e0967614940a"), Nombre = "UNIDAD DE INVESTIGACION TEPEYAHUALCO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("0df254fc-84d9-424f-b0fb-60339b00b157"), Nombre = "UNIDAD DE INVESTIGACION TETELA DE OCAMPO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9067db97-1f46-4280-ab3d-e8f8117c9538"), Nombre = "UNIDAD DE INVESTIGACION TEZIUTLAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7dc91ecf-b7df-4221-97c9-054a98acc044"), Nombre = "UNIDAD DE INVESTIGACION TLACOTEPEC DE BENITO JUAREZ" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("10cb1e14-9e1a-4a86-9e8f-dd14f0aaff83"), Nombre = "UNIDAD DE INVESTIGACION TLAHUAPAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("08d89e1e-2a85-4c16-983e-09b5347dc3e5"), Nombre = "UNIDAD DE INVESTIGACION TLALTENANGO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("aa09c79f-8512-47ae-b1d1-c22a631ae31b"), Nombre = "UNIDAD DE INVESTIGACION TLAPANALA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ff7bfa57-2246-4a72-9156-23c0e1f37e3d"), Nombre = "UNIDAD DE INVESTIGACION TLATLAUQUITEPEC" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("037b9479-d1bf-4ba8-8cd6-9e89cfd391cb"), Nombre = "UNIDAD DE INVESTIGACION XICOTEPEC" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("abb2f006-3702-4d58-88a1-3cc9e6100d56"), Nombre = "UNIDAD DE INVESTIGACION Y LITIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1fb0ccfe-7174-4f44-be18-b332db3b5229"), Nombre = "UNIDAD DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE ABUSO DE CONFIANZA Y FRAUDE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("49d284a2-7dc8-4a31-ae22-6e106acaf34e"), Nombre = "UNIDAD DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("32edff8e-60f3-4206-99be-bbc7f09a9b40"), Nombre = "UNIDAD DE INVESTIGACION ZACAPOAXTLA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("ffe44e60-a6b1-448b-a753-492af3d2c81e"), Nombre = "UNIDAD DE INVESTIGACION ZACATLAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("685e1bfd-142f-4408-8c13-702cad988c18"), Nombre = "UNIDAD DE INVESTIGACION ZARAGOZA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d22487c3-13f5-409c-9bc2-01b7527813bc"), Nombre = "UNIDAD DE INVESTIGACION ZOQUITLAN" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("826c809e-bfde-4d2b-a54d-335b74c0f6ba"), Nombre = "UNIDAD DE SITUACION PATRIMONIAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("358bc209-2e8d-489e-a049-11b36b6bf522"), Nombre = "UNIDAD DE SUSTANCIACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("75567f67-1177-432d-8f58-1fefebcc6486"), Nombre = "UNIDAD DE TRANSPARENCIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("dadb6c78-8735-41ca-a82f-3d248c9f3456"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ASUNTOS INDIGENAS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("306ed62a-bbb9-4f75-bc69-aeea0f3d3dde"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS AMBIENTALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("1f5730cd-527c-414e-8da2-5ae3546c2d87"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS COMETIDOS CONTRA PERIODISTAS Y DEFENSORES DE DERECHOS HUMANOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d58d0232-5433-4107-b819-89655e29aaa4"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA EL ORDEN CONSTITUCIONAL Y LA SEGURIDAD DEL ESTADO; CONTRA LA SEGURIDAD PUBLICA; CONTRA LA SEGURIDAD DE LOS MEDIOS DE TRANSPORTE Y DE LAS VIAS DE COMUNICACION Y VIOLACION DE CORRESPONDENCIA; CONTRA LA SEGURIDAD COLECTIVA; CONTRA LA AUTORIDAD, Y EL DELITO DE ATAQUES PELIGROSOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("38c4ce35-2fba-42dc-a598-ff8a1821c66f"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA PAZ, LA SEGURIDAD Y LAS GARANTIAS DE LAS PERSONAS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("781fe163-23e8-49d2-a76b-a6c2f9f6021c"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LA VIDA Y LA INTEGRIDAD CORPORAL" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7db82bef-2bfb-4355-b3f2-bf07cd0ded6f"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS CONTRA LOS ANIMALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("9a087b39-c5bc-4f40-b6c5-81de11182da4"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE ABUSO DE CONFIANZA, FRAUDE, DESPOJO, DAÑO EN PROPIEDAD AJENA, ROBO DE GANADO, ROBO DE MAQUINARIA E IMPLEMENTOS DIVERSOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("7dd4ef95-6463-4b70-89d3-37bbb3a2c573"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE TORTURA Y OTROS TRATOS CRUELES, INHUMANOS O DEGRADANTES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("abfcd1f4-cf1c-448f-95fb-dd660ed8cb15"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE DELITOS DE VIOLACION DE SECRETOS; DE RESPONSABILIDAD PROFESIONAL; DE DELITOS DE FALSEDAD, Y DELITOS POR INFRACCIONES A LAS LEYES Y REGLAMENTOS SOBRE INHUMACIONES Y EXHUMACIONES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a5518678-d092-4efd-a7ca-b01a050923d6"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE EXTORSION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b49f3210-a4e6-45f9-85cb-b520957c0103"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE ROBO DE VEHICULOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b015c6cd-e8d9-40d8-aa88-172b2d921483"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION DE SECUESTRO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("2e953c83-3edb-4be0-a106-21d36301af92"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION EN PRIVACION ILEGAL DE LA LIBERTAD" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("c949ff63-6cab-498d-a90a-feb861f087bf"), Nombre = "UNIDAD ESPECIALIZADA DE INVESTIGACION Y LITIGACION DE LOS DELITOS DE FRAUDE Y ABUSO DE CONFIANZA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("75f12d03-a5ea-479b-bf6b-c386dedf6936"), Nombre = "UNIDAD ESPECIALIZADA DE JUSTICIA PARA ADOLESCENTES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("b01a0f03-59b0-42b9-8286-39b18e0c54ea"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS COMETIDOS CONTRA LA COMUNIDAD LGBTTTIQ" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3b724b8c-d50c-40d4-9c39-ef04cdefebe7"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LA FAMILIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a91d0881-0e6c-402e-942e-077a90b72e6e"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS CONTRA LOS ANIMALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("16f2ccf0-9ffc-4972-846b-57798b8cfe35"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ABANDONO DE PERSONAS E INCUMPLIMIENTO DE OBLIGACION ALIMENTARIA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d5b48945-a8f3-4756-b3e1-e2f42e5263d6"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("86a4d630-ad11-4aec-a50d-fec3dfdbd866"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE DELITOS SEXUALES Y CIBERACOSO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("d239099d-db3f-433d-af49-61a50c370ad5"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE FEMINICIDIOS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("cc62c36a-404a-4f0a-bb30-daa227162b38"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE NARCOMENUDEO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("af0804ec-dbcf-41c5-acbe-c9d6992b22bb"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A CASA HABITACION" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("8e74173f-b747-4fa4-ba66-1f80d170966b"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A COMERCIO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("f128b75e-079c-4ac7-bc1e-0b3884c2831f"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO A TRANSEUNTE" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("8eb9baae-845e-4fa9-bb3f-2dcd0ccdc74e"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE TRATA DE PERSONAS" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("82f7d3c6-79dc-4f90-8e0d-15be50ee2c6e"), Nombre = "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("3ee7acf0-49ff-457a-be47-8535abde541e"), Nombre = "UNIDAD METROPOLITANA DE INVESTIGACION Y LITIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("20fe1a61-e197-4dad-9883-fdabda526f35"), Nombre = "UNIDAD RESOLUTORA" });
            modelBuilder.Entity<CentroTrabajo>().HasData(new CentroTrabajo { Id = new Guid("a5696d9d-1881-4cf2-920b-2cd085157448"), Nombre = "VISITADURIA GENERAL" });


            //Tipo Contrato - Nuevos

            //modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("4b7d03f3-ef7d-4e42-ad73-f520c6d65edd"), Nombre = "ASIMILADOS" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("499c6384-159a-49b1-bb24-36f13ae9fb10"), Nombre = "BASE" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("0fb4c79b-8dfd-468a-9e42-98fd742383ff"), Nombre = "CONFIANZA" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("17805612-54b0-43ef-9860-6964ba543617"), Nombre = "HONORARIOS" });

        }
    }
}
