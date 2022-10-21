using ControlAsistencia_.Models;
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
        //public DbSet<CargoHomologado> CargoHomologado { get; set; }
        public DbSet<UnidadAdministrativa> UnidadAdministrativa { get; set; }
        public DbSet<CentroTrabajo> CentroTrabajo { get; set; }
        public DbSet<Contratacion> Contratacion { get; set; }
        public DbSet<Incidencia> Incidencia { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

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

            //modelBuilder.Entity<CargoHomologado>(entity =>
            //{
            //    entity.HasKey(e => e.Id);
            //});

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

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            // Categoria

            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("3af153fd-fe52-4fdb-8e8f-494f4df51752"), Nombre = "G0003", Descripcion = "OFICIAL M" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("b072f69c-913e-4f29-b6b8-fec68c0548e0"), Nombre = "G0020", Descripcion = "OFICIAL R" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("938b12b1-0d36-4676-ac48-ecb8ffea54f7"), Nombre = "G0905", Descripcion = "AGENTE DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("3faf5fe9-74d6-4254-938c-860fe5d6ecc6"), Nombre = "G0907", Descripcion = "OFICIAL I" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("cc1a9117-feea-485c-a9d2-7c9887e1bb3f"), Nombre = "G0911", Descripcion = "OFICIAL E" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("fe7271b2-cb0e-46f5-a742-16e3e4fc5926"), Nombre = "G1301", Descripcion = "OFICIAL A" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("b789a7eb-9e69-4105-bbea-be0531ada765"), Nombre = "G1601", Descripcion = "AGENTE MINISTERIAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("b75eeeea-94b0-412b-b290-90bc5f565518"), Nombre = "H3001", Descripcion = "HONORARIOS" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("d538ee39-7911-4722-aad7-67047ef095f6"), Nombre = "M01A1", Descripcion = "FISCAL GENERAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("a4f89176-b60b-4b8a-a292-1ef98b3f288c"), Nombre = "N02A1", Descripcion = "FISCAL ESPECIAL O REGIONAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("c0f55aec-b749-4aa6-85be-a7b206074f89"), Nombre = "N03A1", Descripcion = "OFICIAL MAYOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("d706b04f-41e4-4cd4-9c94-ad9cc0c1f47a"), Nombre = "N03B2", Descripcion = "JEFE DE LA OFICINA DEL FISCAL GENERAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("3089d436-6c78-4178-b2e0-0e04e316c538"), Nombre = "O03A1", Descripcion = "TITULAR DE LA AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("92d0bb9f-8db1-4b18-8a2b-0841169fad5d"), Nombre = "O03A2", Descripcion = "TITULAR DEL INSTITUTO DE CIENCIAS FORENSES" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("f5ffbd42-3523-4f50-a9ac-88a110872e2d"), Nombre = "O03A3", Descripcion = "TITULAR DEL ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("64adafa4-9440-473e-8b8f-c9ab1e97035e"), Nombre = "O03A4", Descripcion = "TITULAR DE LA VISITADURIA GENERAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("4159806c-af91-4b2d-ada6-b0274036431e"), Nombre = "O03A5", Descripcion = "TITULAR DEL INSTITUTO DE FORMACION PROFESIONAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("868361a4-d6b8-4b49-8cc2-b1ad373a43ea"), Nombre = "O04A1", Descripcion = "COORDINADOR GENERAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("15e40268-c5ec-4b11-acae-cf743fb4e6c2"), Nombre = "O04C3", Descripcion = "DIRECTOR DE AREA" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("c37f714f-d746-4bd3-9a65-4727a129209f"), Nombre = "P004A5", Descripcion = "COORDINADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("0eb6dc3e-500a-450e-a799-9a560723dc0b"), Nombre = "P04A5", Descripcion = "COORDINADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("f4cfe54d-60aa-4853-96c3-002fa5380098"), Nombre = "P06A1", Descripcion = "TITULAR DE UNIDAD" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("baf11cee-b98d-403f-82fe-3133353c5eaf"), Nombre = "P06B2", Descripcion = "FISCAL " });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("6d1258c0-13bd-4254-9574-94735a902766"), Nombre = "P06C3", Descripcion = "DIRECTOR DE AREA" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("d3d7f48b-3ac9-45b1-8abf-d3b5c1b6f978"), Nombre = "Q09A1", Descripcion = "ASESOR ESPECIAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("f1e3746f-a8ab-4c8d-9596-10b3a3fb6ed3"), Nombre = "Q10D4", Descripcion = "VISITADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("7a2ae1c5-a1ea-4639-a813-5b423642388f"), Nombre = "Q11C3", Descripcion = "ASESOR TECNICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("3463e60f-7b48-4d37-9656-7cc6a26f098b"), Nombre = "R12C3", Descripcion = "COORDINADOR DE MEDIOS ALTERNATIVOS" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("994a0ed5-4eee-4d10-9459-59c43455b5b0"), Nombre = "R12D4", Descripcion = "SUBDIRECTOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("81070038-3f51-450d-bb21-9b0a7bde8ff5"), Nombre = "R13A1", Descripcion = "AGENTE DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("7c67824a-890a-4749-90de-cfbcccee02f6"), Nombre = "R13A4", Descripcion = "FISCAL INVESTIGADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("672e609a-7c35-4746-b362-eda8862f2198"), Nombre = "R14A1", Descripcion = "COMANDANTE MINISTERIAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("afcc3719-7d77-462d-b811-8fde6ca6ffde"), Nombre = "R16A1", Descripcion = "INSPECTOR GENERAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("88c28bb3-eb4c-4de3-bd94-07f6b7f548d1"), Nombre = "S18B2", Descripcion = "JEFE DE GRUPO MINISTERIAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("60fd3fb1-8546-4446-968c-804c54bd1dc8"), Nombre = "S20A1", Descripcion = "JEFE DE DEPARTAMENTO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("da8a0b96-e23c-464d-b09d-c2f9c55cafb0"), Nombre = "T21C1", Descripcion = "OFICIAL MINISTERIAL" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("6644b65a-7b20-428f-9f4e-054cc8fdef8a"), Nombre = "T21C3", Descripcion = "AGENTE INVESTIGADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("96dc08e2-a9a9-4809-829d-13a42bafcc42"), Nombre = "T22A2", Descripcion = "PERITO JEFE" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("b4c2c672-e8a4-4bd3-b65b-8eae657dc765"), Nombre = "T23A2", Descripcion = "PERITO SUPERIOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("6d9c83c1-20c8-4a49-9a04-bd8d6ba5c1e0"), Nombre = "T23B1", Descripcion = "PERITO ESPECIALIZADO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("5e5504f6-8688-4ff1-b6e1-46ab08d5f21e"), Nombre = "T24A2", Descripcion = "PERITO TECNICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("cc60dd4d-29b3-442d-9d63-d8356f9aa333"), Nombre = "T25A2", Descripcion = "FACILITADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("ad961859-cc43-4901-a820-81c5f77283b0"), Nombre = "T26A1", Descripcion = "AUXILIAR FACILITADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("a713a84f-5b5a-4a3a-98f7-043d054d507b"), Nombre = "T27A1", Descripcion = "INVITADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("c5ad47f8-a385-4762-8d6c-18dfb69d8fa5"), Nombre = "T28C3", Descripcion = "AUXILIAR DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("1e15c6ca-7cdf-46ee-a390-cf4c2eeeb36e"), Nombre = "T29A1", Descripcion = "OFICIAL DEL MINISTERIO PUBLICO" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("3974fee6-7964-443a-b5a0-5853047b7731"), Nombre = "U30A4", Descripcion = "ANALISTA INVESTIGADOR" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("efb112b6-40e9-470b-9b2b-dade1a3205ea"), Nombre = "U30C3", Descripcion = "ANALISTA" });
            modelBuilder.Entity<Categoria>().HasData(new Categoria { Id = new Guid("1046ec42-4fe0-47f7-b3dc-29987941ff5d"), Nombre = "V31C4", Descripcion = "AUXILIAR" });


            //Roles
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("77a225a3-1266-4b1f-b11c-504969afa856"), Nombre = "Root", Activo = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("9a39bcce-b092-4f90-9de7-9e0fb2137034"), Nombre = "Administrador", Activo = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), Nombre = "AllView", Activo = true });
            modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("592d923a-9d0b-424c-8bc3-0c42ff72495e"), Nombre = "UnidadAdministrativa", Activo = true });

            //// Usuarios
            modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"), NombreUsuario = "root", Password = "root", IdUnidadAdministrativa = "", Activo = true, IdRol = "77a225a3-1266-4b1f-b11c-504969afa856" });
            //modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("061bc395-9e04-40d9-824c-0c740f63af15"), NombreUsuario = "oficialiaMayor", Password = "oficialiaMayor", IdUnidadAdministrativa = "", Activo = true, IdRol = "9a39bcce-b092-4f90-9de7-9e0fb2137034" });
            //modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("67bb4459-8401-4b49-8ac8-67d3219fbfc8"), NombreUsuario = "cgesi", Password = "cgesi", IdUnidadAdministrativa = "0e3aa015-4581-4c88-a8c9-679dd80b0d13", Activo = true, IdRol = "592d923a-9d0b-424c-8bc3-0c42ff72495e" });
            //modelBuilder.Entity<Usuario>().HasData(new Usuario { Id = new Guid("0524769e-c144-4772-a050-811e7d2b68ce"), NombreUsuario = "visitaduria", Password = "visitaduria", IdUnidadAdministrativa = "", Activo = true, IdRol = "a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7" });

            ////Catalogo Municipios - Nuevos

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


            ////Tipos de Inmuebles - Nuevos

            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("118aaca6-1d12-4a62-af7d-0df98082cfc2"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("401abaf7-b298-4325-8e9a-5b1975afc4ff"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION DE TECALI DE HERRERA", IdMunicipio = new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), Direccion = "17 SUR NUMERO 304 COLONIA BARRIO DE ANALCO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("32320271-ec9f-4d49-90ac-76f208d781b4"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION HUEJOTZINGO", IdMunicipio = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Direccion = "BLVD. 18 DE MARZO NUMERO 52 COLONIA EL PARAISO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9079c655-0486-4c2d-9e11-1d36245deb3f"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION PUEBLA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV. 25 ORIENTE  #1610 BELLA VISTA, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0edc808d-da15-4c0d-8d29-0d74600a270b"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Direccion = "CALLE VICENTE GUERRERO NO.714 COL, MORELOS SAN MARTIN TEXMELUCAN, CP.: 74020" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0c564c67-db2a-4e6e-b5ac-8970e8f8c949"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION SANTA RITA TLAHUAPAN", IdMunicipio = new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), Direccion = "CALLE JOSE GALEANA NO. 200 COLONIA DOMINGO ARENAS, SANTA RITA TLAHUAPAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("de2850ce-4292-4dad-936c-0861fc8b5e07"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION TEZIUTLAN", IdMunicipio = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Direccion = "CALLE LERDO NUMERO 205, ALTOS COL. CENTRO. ANEXO AL CERESO, TEZIUTLAN , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b4941e30-8996-4c68-a0ce-2f91034d2718"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION TLATLAUQUITEPEC", IdMunicipio = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Direccion = "AV. INDEPENDENCIA NUM. 20 COL.CENTRO , TLATLAUQUITEPEC,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0a3623f2-b594-4434-87fc-668e158f84c1"), Nombre = "ALMACEN GENERAL", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE ORQUIDEAS NO. 6141 COLONIA BUGAMBILIAS CP 72580" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b6b13bcb-4fdb-4e48-b034-9489005f4e24"), Nombre = "ARCHIVO Y BODEGA DE INDICIOS", IdMunicipio = new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), Direccion = "KM 19.5 CARRETERA FEDERAL PUEBLA - TEHUACAN, COLONIA SAN JOSE LAS FLORES, CP 72980, AMOZOC" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1b80e5a4-76bf-40d1-9bcf-a8fa138ea807"), Nombre = "ARCO DE SEGURIDAD DE ALTEPEXI", IdMunicipio = new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), Direccion = "CARRETERA ESTATAL TEHUACAN TEOTITLAN OAXACA, TRAMO DE CHILACALTEPEXI, CP.: 75914" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5dc4b9d0-6ff1-402a-8d00-78816aa818ec"), Nombre = "ARCO DE SEGURIDAD DE IZUCAR DE MATAMOROS", IdMunicipio = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Direccion = "CARRETERA FEDERAL IZUCAR DE MATAMOROS KM61+800 IZUCAR DE MATAMOROS" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("734c27ec-4f4c-47db-8598-f8c41cc57a42"), Nombre = "ARCO DE SEGURIDAD HUEJOTZINGO", IdMunicipio = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Direccion = "CARRETERA MEXICO -PUEBLA KM100+200 HUEJOTZINGO ,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ee3e8fc4-7795-43a9-8c82-3222e66c827b"), Nombre = "ARCO DE SEGURIDAD PALMAR DE BRAVO", IdMunicipio = new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), Direccion = "CARRETERA MEXICO VERACRUZ KM 166+500PALMAR DE BRAVO , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8ac38361-c5c2-4e8c-a6af-7d02a13ff1f7"), Nombre = "C5 TEHUACAN", IdMunicipio = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Direccion = "CARRETERA FEDERAL PUEBLA TEHUACAN 1211 O KM 114 SAN LORENZO TEOTIPILCO, TEHUACAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0a686c58-9c0e-4db0-9444-cde555f01414"), Nombre = "CANACO SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Direccion = "REFORMA 3 ORIENTE, COL. CENTRO 74000 SAN MARTIN TEXMELUCAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8e2007d1-cc1a-4be1-8667-f057d0df5d96"), Nombre = "CASA DE JUSTICIA ACATLAN DE OSORIO ", IdMunicipio = new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), Direccion = "CARRETERA INTERNACIONAL MÉXICO -OAXACA KM152+200, BARRIO LA PALMA , ACATLÁN DE OSORIO PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a6c8f21a-3b98-4047-8e32-3df0c5be736d"), Nombre = "CASA DE JUSTICIA ATLIXCO", IdMunicipio = new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), Direccion = "BOULEVARD GENERAL MORENO VALLE NO. 1604, COL. TIZAYUCA ,ATLIXCO PUE. CP.: 74200" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3f4c7c72-5643-41d3-8095-6d1b41f2c414"), Nombre = "CASA DE JUSTICIA CHALCHICOMULA DE SESMA", IdMunicipio = new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), Direccion = "KM.28+285 CARRETERA FEDERAL EL SECO ASUMBULLA, CD. SERDAN, PUEBLA CP.: 75520" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("73271645-4d1c-4f4a-af02-58be6274c89c"), Nombre = "CASA DE JUSTICIA HUAUCHINANGO", IdMunicipio = new Guid("bf447292-6874-4d7e-8790-946362b43fae"), Direccion = "CAMINO A CATALINA S/N COLONIA EL POTRO, HUAUCHINANGO, PUEBLA CP.: 73176" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b9604444-4813-4b5d-b76d-7392c18f279d"), Nombre = "CASA DE JUSTICIA IZUCAR DE MATAMOROS", IdMunicipio = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Direccion = "CARRETERA FEDERAL PUEBLA-IZUCAR DE MATAMOROS NO. 2119, COL. GALARZA, IZUCAR DE MATAMOROS, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("422d23cf-e65b-4bf0-b61b-c00e8fd6fbe3"), Nombre = "CASA DE JUSTICIA LIBRES", IdMunicipio = new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), Direccion = "CALLE LERDO NUMERO 988, LIBRES, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("14c2010b-677b-402c-aa34-f3296ae8626a"), Nombre = "CASA DE JUSTICIA PARA ADOLESCENTES", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "CARRETERA IZUCAR DE MATAMOROS S/N COL. TLAXCALANCINGO, CP.: 72820" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("21ffa18e-393f-4c30-9a30-55e382bf0665"), Nombre = "CASA DE JUSTICIA SAN ANDRES CHOLULA", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "PERIFERICO ECOLOGICO 100 SAN BERNARDINO TLAXCALANCINGO SAN ANDRES CHOLULA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("703a1034-f89f-4bd1-ba72-16edc7580308"), Nombre = "CASA DE JUSTICIA SAN MARTIN TEXMELUCAN", IdMunicipio = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Direccion = "AUTOPISTA MEXICO -PUEBLA S/N, SAL SALVADOR EL VERDE, SAN MARTIN TEXMELUCAN," });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("14de72a4-aea4-4e61-b139-687eab6621e4"), Nombre = "CASA DE JUSTICIA TECAMACHALCO", IdMunicipio = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Direccion = "CARRETERA FEDERAL KM 60+490, COL.SANTIAGO ALSESECA, TECAMACHALCO, CP.: 75480" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d59c29d6-c763-45b1-9939-8ae9fcef20e8"), Nombre = "CASA DE JUSTICIA TEHUACAN", IdMunicipio = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Direccion = "BLVD. ADOLFO MATEOS NO.4, PLANTA ALTA, COL. ZONA ALTA, TEHUACAN, PUEBLA CP.: 75750" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f0a98b00-3578-4ae4-9d41-0f23acbffba0"), Nombre = "CASA DE JUSTICIA TEZIUTLAN", IdMunicipio = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Direccion = "CALLE LA MESILLA NO.10 COL. INDUSTRIAL, TEZIUTLAN, PUEBLA. CP.: 73850" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("78500fc7-73ca-4146-ba67-c51f0b5b2606"), Nombre = "CASA DE JUSTICIA ZACATLAN", IdMunicipio = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Direccion = "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2ad2d44a-81f9-4adf-8a00-44268f1b17c1"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES EN ACATLAN DE OSORIO", IdMunicipio = new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), Direccion = "AV. REFORMA 22 COLONIA CENTRO ENTRE EMILIANO ZAPATA Y VENUSTIANO C" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("694935bb-752f-431c-b1ac-e4948e5915b8"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES PUEBLA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 17 PONIENTE NO.1919, BARRIO DE SANTIAGO,PUEBLA, PUE. CP.: 72410" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("24e9ef97-7465-498b-a82d-fe7d0251468e"), Nombre = "CENTRO DE JUSTICIA PARA LAS MUJERES TEHUACAN", IdMunicipio = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Direccion = "CALLE COMPUTENSE ESQUINA CALLE DE LA TURBINA S/N COL. UNIVERSIDADES II, TEHUACAN ,PUE. CP.: 75723" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8a21266b-0130-4e8d-8097-f3012a895c8b"), Nombre = "CENTRO INTEGRAL DE SERVICIOS ANGELOPOLIS", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "VIA ATLIXCAYOTL NO. 1101, EDIFICIO SUR PLANTA BAJA , CONCEPCION LAS LAJAS , PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("35e4e36c-ca29-458d-ae13-b0801108ff22"), Nombre = "CENTRO INTEGRAL DE SERVICIOS CUAUTLANCINGO", IdMunicipio = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Direccion = "CALLE AQUILES SERDAN ESQUINA CON 20 DE NOVIEMBRE SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f4d02ed2-cd7c-418e-9af2-9fc5b8ffd360"), Nombre = "CENTRO INTEGRAL DE SERVICIOS SAN JAVIER", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV. REFORMA 1305 COL CENTRO C.P. 72000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("78b2c8ec-26ed-4c94-ba19-125a63ea10ac"), Nombre = "CENTRO INTEGRAL DE SERVICIOS TEZIUTLAN", IdMunicipio = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Direccion = "AV HIDALGO NO.169 EDIFICIO REAL PLANTA BAJA, CENTRO. TEZIUTLAN, PUEBLA." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f9f7bdb4-1757-4161-be8e-373c973309f9"), Nombre = "CENTRO INTEGRAL DE SERVICIOS TLATLAUQUITEPEC", IdMunicipio = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Direccion = "CARRETERA FEDERAL TEZIUTLAN - ACAJETE NO. 169 BARRIO DE CONTLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("35d32a53-7149-4351-ae5f-662e64f852bb"), Nombre = "CENTRO INTEGRAL SERVICIOS ATLIXCO", IdMunicipio = new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), Direccion = "REVOLUCION NO. 6202, COL. EL LEON ATLIXCO PUE, CP.: 74360" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("a62436ce-7e41-41f3-adc1-f737860abb40"), Nombre = "CENTRO INTEGRAL SERVICIOS SAN JOSE CHIAPA", IdMunicipio = new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), Direccion = "MANZANA NUMERO 5 CIUDAD MODELO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e9fbeb54-1704-4ecc-b4c2-aa8d4c0455ce"), Nombre = "CENTRO INTEGRAL SERVICIOS TEHUACAN", IdMunicipio = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Direccion = "CARRETERA FEDERAL PUEBLA - TEHUACAN KILOMETRO 114, MANANTIALES, TEHUACAN, PUE. CP.: 75855" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8edc1737-319d-4033-826c-e5d8adfad62f"), Nombre = "CENTRO INTEGRAL SERVICIOS XICOTEPEC DE JUAREZ", IdMunicipio = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Direccion = "CALLE FCO. JAVIER MINA NO. 303, COL. LA RIVERA XICOTEPEC DE JUAREZ, PUE. CP.: 73080" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c193a612-80ce-4a1f-bb88-91b457e058cc"), Nombre = "CENTRO INTEGRAL SERVICIOS ZACATLAN", IdMunicipio = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Direccion = "COLONIA 2 CAMINOS ZACATLAN , PUE. BARRIO TECOJOTAL, CP.: 73310" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("aafaace9-e721-4a81-acda-e75576df0677"), Nombre = "COMPLEJO DE SEGURIDAD PUBLICA SAN ANDRES CHOLULA", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "CAMINO A CUAYANTLA NO. 1611, SAN BERNARDINO TLAXCALANCINGO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f88c3266-a2d0-40f0-9ddb-23c2f1bf6df0"), Nombre = "COMPLEJO METROPOLITANO SEGURIDAD PUBLICA (C5)", IdMunicipio = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Direccion = "PERIFERICO ECOLOGICO KILOMETRO 3.5 ANTIGUO CAMINO A SAN FRANCISCO OCOTLAN, CUAUTLANCINGO PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b3603609-3175-4c5e-8d63-54256de13d5c"), Nombre = "COORDINACION GENERAL DE ANALISIS DE INFORMACION", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "TERCER RETORNO OSA MAYOR NO. 3, RESERVA TERRITORIAL ATLIXCAYOTL SAN ANDRES" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("db461974-5ebb-4810-984a-e6c3a0de8f83"), Nombre = "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "DIAGONAL DEFENSORES DE LA REPUBLICA ESQ.10 PONIENTE COL.AMOR PUEBLA,PUE. CP.: 72140" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2507e9f2-220c-47f9-97c2-b1832e82bb66"), Nombre = "DEPOSITO DE VEHICULOS CUAUTLANCINGO (CAPULIN)", IdMunicipio = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Direccion = "CARRETERA A TLAXCALA KM 10 CUAUTLANCINGO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d958d50f-782f-43e9-85ff-c4de0337ea7a"), Nombre = "DEPOSITO DE VEHICULOS OCRA - SAN MIGUEL 2", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CAMINO AL BATAN COL.LOMAS DE SAN MIGUEL PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6aee5b48-89b4-41f3-8dad-29b506104565"), Nombre = "DEPOSITO DE VEHICULOS SANCTORUM (FINSA)", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "RIO ATOYAC # 19 SANCTORUM" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3d8285b3-2b75-4b20-b0ba-9df53140482b"), Nombre = "EDIFICIO CENTRAL 04", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "BOULEVARD HEROES 5 DE MAYO ESQUINA CON 31 ORIENTE COL.LADRILLERA DE BENITEZ CP.: 72530" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("4802db29-73e1-4166-99eb-937538da946a"), Nombre = "EJECUCION DE SENTENCIAS", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "KM 2.5 CARRETERA AL BATAN , EDIFICIO ADJUNTO AL CERESO DE SAN MIGUEL PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("90edf16d-e382-4e9a-8bd6-406e947940ea"), Nombre = "FISCALIA DE DERECHOS HUMANOS", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 12 ORIENTE NO. 415 COL. CENTRO, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("bcee5fc4-0a08-4059-b907-8c9727dd795e"), Nombre = "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS, ORGANO INTERNO DE CONTROL Y VISITADURIA GENERAL", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "12 NORTE. NO.1806,COL. BARRIO DEL ALTO , PUEBLA PUE. CP.: 72146" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ce342b44-57a3-40ad-a236-fc75b2ef3238"), Nombre = "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION, FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICUALRES", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AVENIDA 16 DE SEPTIEMBRE NUMERO 2904 COLONIA EL CARMEN, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("bd6800b3-6de6-40d5-b03c-93406ad2c5fb"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 127 PONIENTE Y CALLE 11 SUR , COL.EX-HACIENDA CASTILLOTLA, PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9a860a3a-cfcb-489e-8b66-68ccbc4fe7ff"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (BOCHAS)", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 6 NORTE NO.1003, COL. CENTRO,PUEBLA PUE. CP.: 72000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("606d1b6d-b034-4332-9dbe-a517c8196262"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES (CPJ)", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 10 ORIENTE NO.414,COL CENTRO PUEBLA,PUE. CP.: 72530" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b82a5e81-0f09-4bff-88f2-2bef98440c36"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "3ER RETORNO OSA MENOR NO.3, RESERVA TERRITORIAL ATLIXCAYOTL ,SAN ANDRES" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("eba4eced-43dc-4325-8e65-b120db654c0a"), Nombre = "INDIGENAS PERIODISTAS LGBTTQ", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "PRIV. 5 B SUR NO. 3706, COL. GABRIEL PASTOR, PUEBLA, PUE CP. 72420" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c65da3df-92b1-4e36-a120-1fa7677f57b3"), Nombre = "INMUEBLE CANACINTRA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV. REFORMA 2704 5° PISO COL. AMOR" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2c1b82e6-125b-4ec0-8437-fbf42620e181"), Nombre = "INSTITUTO DE FORMACION PROFESIONAL", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "DIAGONAL CUAUHTEMOC NO.3101 COL. VALLE DORADO PUEBLA,PUE. CP.: 72070" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1dca3b9f-42c2-46a4-b001-2c0027680993"), Nombre = "JUSTICIA CIUDADANA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "13 SUR 1910 BARRIO DE SANTIAGO PUEBLA PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("faf6cdd7-e45d-4fdc-849a-4c37ec57d280"), Nombre = "SEMEFO 11 SUR", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "PROLONGACION 11 SUR 11906, COL. GUADALUPE HIDALGO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b2daaab4-50c3-4610-a4fc-34a770f339ec"), Nombre = "SEMEFO CHIGNAHUAPAN", IdMunicipio = new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), Direccion = "BOULEVARD EMILIANO ZAPATA SIN NUMERO, INTERIOR DEL PANTEON MUNICIPAL, CHIGNAHUAPAN,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("50d4a1df-7d34-4991-8c5c-dfb726d7cb28"), Nombre = "SEMEFO HUAUCHINANGO", IdMunicipio = new Guid("bf447292-6874-4d7e-8790-946362b43fae"), Direccion = "CALLE TIRZO TELLEZ SIN NUMERO COL. EL CRISTO, HUAUCCHINANGO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("4c56ddec-6394-423a-82dc-c476fa6efad6"), Nombre = "SEMEFO IZUCAR DE MATAMOROS", IdMunicipio = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Direccion = "PANTEON MUNICIPAL, BARRIO DE SANTA CRUZ, TEXCOCO, CALLE REVOLUCION Y HERCULANO SANCHEZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("9eeb64a5-572d-4a82-8146-78d3343a2686"), Nombre = "SEMEFO LIBRES", IdMunicipio = new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), Direccion = "CALLE 4 ORIENTE SIN NUMERO BARRIO DE GUADALUPE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("61fca298-cc9a-4b4b-9a76-e91a7521793f"), Nombre = "SEMEFO TECAMACHALCO", IdMunicipio = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Direccion = "A.V. GUERRERO ENTRE CALLE 31 SUR, Y CARRETERA A SAN MATEO TLAIXCAPAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2c64762a-ea5c-4513-83b4-b6ae3d0e6703"), Nombre = "SEMEFO TEHUACAN", IdMunicipio = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Direccion = "CALLE 19 PONIENTE SIN NUMERO PANTEON MUNICIPAL, TEHUACAN PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5db4e0a1-d8f2-4371-8550-9852d2be90bb"), Nombre = "SEMEFO TEPEACA", IdMunicipio = new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), Direccion = "INTERIOR DEL PANTEON MUNICIPAL, CALLE 17 ORIENTE Y AVENIDA COLON SIN NUMERO, BARRIO EL SANTUARIO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3815194e-8e7f-49ba-a9a3-75590030188c"), Nombre = "SEMEFO TEPEXI DE RODRIGUEZ", IdMunicipio = new Guid("80261179-cc03-47f8-89fe-cf001811739a"), Direccion = "PANTEON MUNICIPAL CALLE DEFENSORES DEL 6 DE JUNIO SIN NUMERO, TEPEXI DE RODRIGUEZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1dea035e-ae34-4781-8d49-5854708d4cd8"), Nombre = "SEMEFO TEZIUTLAN", IdMunicipio = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Direccion = "CALLE COSTADO SUR DEL PANTEON MUNICIPAL, SIN NUMERO, TEZIUTLAN, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("996235b7-d04e-4a8a-a906-a494ca3af685"), Nombre = "SEMEFO TLATLAUQUITEPEC", IdMunicipio = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Direccion = "AV DOLORES BETANCOURT COL. CONTLA, TLATLAUQUITEPEC, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("41a3adc9-0d37-4fd3-9d52-37a1f0253b81"), Nombre = "SEMEFO XICOTEPEC DE JUAREZ", IdMunicipio = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Direccion = "AV. ZARAGOZA SIN NUMERO, XICOTEPEC DE JUAREZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("907c09d4-b11e-420d-88cc-ce54498dff9b"), Nombre = "SEMEFO ZACAPOAXTLA", IdMunicipio = new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), Direccion = "CALLE 2 DE ABRIL NORTE SIN NUMERO ESQUINA FJ. ARRIAGA COL. CENTRO ZACAPOAXTLA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("eb9d27e2-dd2f-4543-8e0e-ec0c7a94e361"), Nombre = "SEMEFO ZACATLAN", IdMunicipio = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Direccion = "CALLE PORFIRIO DIAZ Y DOLORES PEREZ SIN NUMERO COL. CENTRO ZACATLAN, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("7ae2fa67-eef9-4540-b625-8ddb7a32fabc"), Nombre = "UNIDAD DE IDENTIFICACION VEHICULAR", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "EMILIANO ZAPATA KM2.5,COL LOMAS DE SAN MIGUEL,PUEBLA,PUE. CP.: 72573" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("464488e1-a398-4dea-ad31-826a94b03e3c"), Nombre = "UNIDAD DE IDENTIFICACION VEHICULAR", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE EMILIANO ZAPATA  KM 2.5" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e53d5d9b-486b-4308-8c17-2e02bd4b5cbf"), Nombre = "UNIDAD DE INVESTIGACION ACAJETE", IdMunicipio = new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), Direccion = "CALLE 2 ORIENTE ENTRE CALLE 8 NORTE Y CALLE 10 ORIENTE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8e074fe8-23d0-4021-83a8-9b5897e73885"), Nombre = "UNIDAD DE INVESTIGACION ACATENO", IdMunicipio = new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), Direccion = "CALLE ALLENDE NO. 1 COL. CENTRO SAN JOSE ACATENO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("7428a257-0814-4737-aeff-29c88320ac31"), Nombre = "UNIDAD DE INVESTIGACION ACATZINGO", IdMunicipio = new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), Direccion = "AV. IGNACIO ROMERO VARGAS 201 COL CENTRO CP 75150" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0b458221-becd-49b7-b478-ae0c73d623c1"), Nombre = "UNIDAD DE INVESTIGACION ADSCRITA A JUZGADOS PENALES Y CIVILES", IdMunicipio = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Direccion = "AV DE LAS HUERTAS 917 CUARTO BARRIO COL. CENTRO, HUEJOTZINGO, PUEBLA, CP.: 74168" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("054610f3-bfd4-46e4-8e31-22f19a3c7c17"), Nombre = "UNIDAD DE INVESTIGACION AHUAZOTEPEC", IdMunicipio = new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), Direccion = "CALLE HIDALGO SUR S/N COL. CENTRO (DENTRO DE LA PRESIDENCIA MUNICIPAL" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0f3ced7d-1596-422c-9a75-3f72cfbc354a"), Nombre = "UNIDAD DE INVESTIGACION AJALPAN", IdMunicipio = new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), Direccion = "CALLE GUERRERO SIN NUMERO, AJALPAN PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("210b9661-a88c-419c-92fa-1cff3645df36"), Nombre = "UNIDAD DE INVESTIGACION AMOZOC", IdMunicipio = new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), Direccion = "FRANCISCO I. MADERO 109, BARRIO DE SANTIAGO, CP. 72980, AMOZOC, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("95cd766f-0357-4b63-a9a8-66ea27a84fda"), Nombre = "UNIDAD DE INVESTIGACION ATEMPAN", IdMunicipio = new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), Direccion = "02 ORIENTE SIN NUMERO, COLONIA CENTRO, ATEMPAN, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6c9d057a-6965-4219-bda2-584ba3bb5aa8"), Nombre = "UNIDAD DE INVESTIGACION ATENCINGO", IdMunicipio = new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), Direccion = "CALLE 5 DE FEBRERO ESQUINA MIGUEL HIDALGO COL LA CRUZ" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("438505d2-999b-44a5-be32-88129783347f"), Nombre = "UNIDAD DE INVESTIGACION CALPAN", IdMunicipio = new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), Direccion = "CALLE CONSTITUCION S/N ENTRE 16 DE SEPTIEMBRE Y DOMINGO ARENAS, PRESIDENCIA MUNICIPAL CALPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5d81a5cf-8c13-46fb-918d-59136826b39e"), Nombre = "UNIDAD DE INVESTIGACION CENTRO", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "9 ORIENTE NO.1405COL.CENTRO PUEBLA PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("efa3a2ce-0219-42c4-b9f0-cdea1a11dde0"), Nombre = "UNIDAD DE INVESTIGACION CHAPULCO", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "PROLONGACION DE LA 14 SUR NUMERO 11517 COL. SAN JOSE CHAPULCO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("fc023dba-d692-45ee-8714-9d1b48afd811"), Nombre = "UNIDAD DE INVESTIGACION CHIAUTLA DE TAPIA", IdMunicipio = new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), Direccion = "CALLE REFORMA Y 5 NORTE COLONIA CENTRO, CHIAUTLA DE TAPIA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("33327808-e6fc-455f-bd73-22bc1ac2ccf7"), Nombre = "UNIDAD DE INVESTIGACION CHIETLA", IdMunicipio = new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), Direccion = "CALLE RAYON NUMERO 4 COL. CENTRO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("2ac1cdfa-bdbe-40c7-bc32-8d6ad64f1ba5"), Nombre = "UNIDAD DE INVESTIGACION CHIGNAHUAPAN", IdMunicipio = new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), Direccion = "LIBRAMIENTO CHIGNAHUAPAN - ZACATLAN, KM 4.5 BARRIO TOLTEMPAN, CHIGNAHUAPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1df5ac02-a63a-477b-8e06-5fa2e39abf3e"), Nombre = "UNIDAD DE INVESTIGACION CIUDAD JUDICIAL", IdMunicipio = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Direccion = "PERIFERICO ECOLOGICO ARCO SUR NO. 4000, RESERVA TERRITORIAL ATLIXCAYOTL, SAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("141489d3-20eb-40f2-8a6f-c7d20c557565"), Nombre = "UNIDAD DE INVESTIGACION CORONANGO", IdMunicipio = new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), Direccion = "AV. 5 DE FEBRERO NORTE SIN NUMERO COL. EL MONTERO CORONANGO, PUEBLA  COMPLEJO METROPOLITANO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5e2df904-41e1-490c-aa33-4b1c304cbc9c"), Nombre = "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA IZUCAR DE MATAMOROS", IdMunicipio = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Direccion = "PRIVADA UNIVERSIDAD II SAN MARTIN ALCHICHICA, IZUCAR DE MATAMOROS,PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("54d00327-5c52-43c1-9ad0-9acc5a938341"), Nombre = "UNIDAD DE INVESTIGACION CRIMINAL Y UNIDAD DE ATENCION TEMPRANA ZACATLAN", IdMunicipio = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Direccion = "LIBRAMIENTO CARRETERA ZACATLAN -TEJOCOTAL, BARRIO DE MAQUIXTLA, ZACATLAN, PUEBLA CP.: 73310" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6f47f8c9-c0c0-4d2d-83fb-9375a0f628c4"), Nombre = "UNIDAD DE INVESTIGACION CUAUTLANCINGO", IdMunicipio = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Direccion = "CALLE CAMINO NACIONAL ESQUINA CON AQUILES SERDAN SIN NUMERO, COLONIA BELLO HORIZONTE, CUAUTLANCINGO  COMPLEJO DE SEGURIDAD" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("189c69b5-51fa-4dae-b6b3-c76149d03e76"), Nombre = "UNIDAD DE INVESTIGACION CUETZALAN DEL PROGRESO", IdMunicipio = new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), Direccion = "CALLE MIGUEL ALVARADO ESQUINA CON ABASOLO S/N COLONIA CENTRO C.P. 75040 CUETZALAN PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("39001a4a-69a2-49e9-a020-c826b1244e8e"), Nombre = "UNIDAD DE INVESTIGACION EL SECO", IdMunicipio = new Guid("96282c38-e892-4399-b814-568127e5dff1"), Direccion = "AV. 4 ORIENTE SIN NUMERO TECOAC" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6ba0096c-52ea-46b5-8180-363b167bb583"), Nombre = "UNIDAD DE INVESTIGACION ESPERANZA", IdMunicipio = new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), Direccion = "CALLE 12 NORTE SEGUNDA SECCION 22, ESPERANZA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("fbea9995-eeae-4c4c-947c-51168cac8272"), Nombre = "UNIDAD DE INVESTIGACION HUEHUETLA", IdMunicipio = new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), Direccion = "CALLE JUAREZ SUR S/N COL. YALU LOCALUDAD PUTAX-EAT, HUEHUETLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("6b3a3dc3-eb1f-4899-ba97-57ce94e8a7af"), Nombre = "UNIDAD DE INVESTIGACION HUEYTAMALCO", IdMunicipio = new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), Direccion = "CALLE MIGUEL HIDALGO NUMERO 35 HUEYTAMALCO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("14e434cb-36e8-429c-8502-8cff43f5447c"), Nombre = "UNIDAD DE INVESTIGACION JUAN C BONILLA", IdMunicipio = new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), Direccion = "CALLE 5 DE MAYO S/N COLONIA CENTRO, JUAN C. BONILLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ef49e1c2-c8d8-443b-ac97-f407016a6e08"), Nombre = "UNIDAD DE INVESTIGACION LA MARGARITA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CAMINO AL BATAN NO. 12 COL. VILLA SATELITE LA CALERA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("76ad67f0-eb7a-4229-a236-577f69645711"), Nombre = "UNIDAD DE INVESTIGACION LA POPULAR", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV.105 PONIENTE ENTRE CALLE PUEBLA Y OAXACA COL.POPULAR CASTILLOTLA, PUEBLA," });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("48cec3ac-4642-4c9f-940b-de9eaa564982"), Nombre = "UNIDAD DE INVESTIGACION LAZARO CARDENAS", IdMunicipio = new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), Direccion = "CARRETERA FEDERAL PACHUCA TUXPAN, COL. CENTRO, VILLA LAZARO CARDENAS" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("1b61ba6a-1282-4ed6-8362-7e9419e4443f"), Nombre = "UNIDAD DE INVESTIGACION LOS REYES DE JUAREZ", IdMunicipio = new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), Direccion = "AVENIDA MERINO FERNANDEZ ENTRE CALLE JUAREZ Y CALLE AYUNTAMIENTO, PRESIDENCIA MUNCIAL, COL. CENTRO, LOS REYES DE JUAREZ, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ab04e890-44a2-425c-a1f2-8d3c403bcbcb"), Nombre = "UNIDAD DE INVESTIGACION METLALTOYUCA", IdMunicipio = new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), Direccion = "AVENIDA REYES GARCIA 57 COLONIA ERMITA, METLALTOYUCA, PUEBLA. CP 73000" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("c333a4e2-dd07-4aea-bb11-25d590812a01"), Nombre = "UNIDAD DE INVESTIGACION OCOYUCAN", IdMunicipio = new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), Direccion = "PLAZA PRINCIPAL S/N PLANTA BAJA, PALACIO MUNICIPAL, COL. CENTRO, SANTA CLARA OCOYUCAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("99e905b3-3140-4cad-9d7b-cbf9cd72215e"), Nombre = "UNIDAD DE INVESTIGACION ORIENTAL", IdMunicipio = new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), Direccion = "AV. AYUNTAMIENTO NO. 3 COL. CENTRO CP 75020" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("f488f977-a522-4c07-9698-d43ef7ba6e91"), Nombre = "UNIDAD DE INVESTIGACION ORIENTE", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "PROLONGACION 16 ORIENTE ESQ. CON LIBRAMIENTO A TEHUACAN COL. MEXICO 68" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d527b0e5-55a2-466a-b87f-e4299c4f2b35"), Nombre = "UNIDAD DE INVESTIGACION PALMAR DE BRAVO", IdMunicipio = new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), Direccion = "CALLE NICOLAS BRAVO #504 COL. CENTRO PALMAR DE BRAVO " });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("fe7d641a-eab3-493e-a903-dbfbb70b0f8e"), Nombre = "UNIDAD DE INVESTIGACION PIAXTLA", IdMunicipio = new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), Direccion = "PLAZA EXPLANADA PALACIO MUNICIPAL S/N COL. CENTRO PRIMER PISO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("37d5e2ee-137b-44c1-b250-500fcb46f633"), Nombre = "UNIDAD DE INVESTIGACION SAN GABRIEL CHILAC", IdMunicipio = new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), Direccion = "AVENIDA NIÑOS HEROES SIN NUMERO COLONIA EL SOL, SAN GABRIEL CHILAC, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("21eb5fdf-ef14-4a57-bfdd-5dc97facc294"), Nombre = "UNIDAD DE INVESTIGACION SAN PEDRO CHOLULA", IdMunicipio = new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), Direccion = "CALLE 15 NORTE SIN NUMERO, SEGUNDO PISO, SAN MATIAS COCOYOTLA, SAN PEDRO CHOLULA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("218cdd1f-0187-4d83-b3bf-155e6fa19c52"), Nombre = "UNIDAD DE INVESTIGACION SANTA RITA TLAHUAPAN", IdMunicipio = new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), Direccion = "CALLE MIGUEL HIDALGO S/N COL. CENTRO 74100, SANTA RITA TLAHUAPAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("01afc650-4da8-4e2f-964b-0921d8e92b84"), Nombre = "UNIDAD DE INVESTIGACION SANTIAGO MIAHUATLAN", IdMunicipio = new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), Direccion = "11 PONIENTE ENTRE 1 SUR Y AV. NACIONAL, SANTIAGO MIAHUATLAN, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("8d533986-b29a-4ab7-a6ec-b309ed6b479c"), Nombre = "UNIDAD DE INVESTIGACION TECALI DE HERRERA", IdMunicipio = new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), Direccion = "CALLE DE HERRERA S/N COL. CENTRO, TECALI DE HERRERA, COMPLEJO DE SEGURIDAD" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("961eb405-becb-47e9-9cf5-257ba73d7c65"), Nombre = "UNIDAD DE INVESTIGACION TECAMACHALCO", IdMunicipio = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Direccion = "10 SUR 507, BARRIO DE SAN JOSE, TECAMACHALCO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ed8318b4-bd88-401c-b66e-716afe38aa79"), Nombre = "UNIDAD DE INVESTIGACION TEHUITZINGO", IdMunicipio = new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), Direccion = "CALLE LA PRESA SECCION TERCERA, TEHUITZINGO , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("499936a0-60f7-46b6-bd6d-12741108db1a"), Nombre = "UNIDAD DE INVESTIGACION TEPANCO", IdMunicipio = new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), Direccion = "PRIV. 8 PONIENTE S/N COL. CENTRO 75800, TEPANCO DE LOPEZ, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e72d4e7b-acf3-404a-a1fe-661cc0a022e1"), Nombre = "UNIDAD DE INVESTIGACION TEPATLAXCO", IdMunicipio = new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), Direccion = "2 SUR ESQUINA CON 9 ORIENTE S/N COL. CENTRO, TEPATLAXCO DE HIDALGO, PRIMER PISO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("57e53aab-5e28-4a36-a5a3-7ef9f279c130"), Nombre = "UNIDAD DE INVESTIGACION TEPEACA", IdMunicipio = new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), Direccion = "AVENIDA HIDALGO NUMERO 509 A, TEPEACA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b4f96b50-317f-4e22-8ece-f6202e5c19ea"), Nombre = "UNIDAD DE INVESTIGACION TEPEOJUMA", IdMunicipio = new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), Direccion = "CALLE IRINEO VAZQUEZ, NUMERO 1, TEPEOJUMA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("18ebe402-bd81-4ef1-9ccf-2f43e85e8af5"), Nombre = "UNIDAD DE INVESTIGACION TEPEXI DE RODRIGUEZ", IdMunicipio = new Guid("80261179-cc03-47f8-89fe-cf001811739a"), Direccion = "CALLE 5 DE FEBRERO PLAZA COMUNITARIA PROF .ABEL CRUZ GARCIA , COL CENTRO, TEPEXI DE RODRIGUEZ PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("662a30c4-f879-40ee-9274-08c9c73ea4b3"), Nombre = "UNIDAD DE INVESTIGACION TEPEYAHUALCO", IdMunicipio = new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), Direccion = "CALLE PRIMERA DE VENUSTIANO CARRANZA Y CALLE PRIMERA MORELOS S/N TEPEYAHUALCO, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("45c93253-ac00-47b7-b967-9254155a1fe6"), Nombre = "UNIDAD DE INVESTIGACION TETELA DE OCAMPO", IdMunicipio = new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), Direccion = "7 PONIENTE #1, COLONIA CENTRO, TETELA DE OCAMPO, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0da231e4-9913-4069-8d6c-a2a1f108055b"), Nombre = "UNIDAD DE INVESTIGACION TLACOTEPEC", IdMunicipio = new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), Direccion = "PLAZA COMUNITARIA CALLE AGUASCALIENTES SIN NUMERO COLONIA CENTRO 75680" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("afc105ec-69aa-433e-ac8c-512ad8b1e31b"), Nombre = "UNIDAD DE INVESTIGACION TLALTENANGO", IdMunicipio = new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), Direccion = "REAL DE SAN PEDRO NO 15 COL. CENTRO, C.P.72600, TLALTENANGO, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("e49d9f92-3355-40cb-bd71-1b913c009016"), Nombre = "UNIDAD DE INVESTIGACION TLAOLA", IdMunicipio = new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), Direccion = "ESQUINA QUE FORMAN LAS CALLES MORELOS Y CUAUHTEMOC NUMERO 1, TLAOLA, PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("b9d3db38-da85-481b-944a-633373082ed8"), Nombre = "UNIDAD DE INVESTIGACION TLAPANALA", IdMunicipio = new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), Direccion = "PALACION MUNICIPAL S/N TLAPANALA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5bf9b4f8-09c8-41b2-be84-669f8c33315c"), Nombre = "UNIDAD DE INVESTIGACION VALSEQUILLO", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "BOULEVARD VALSEQUILLO ESQU. 20 DE NOVIEMBRE COL. SAN BALTAZAR CAMPECHE, PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("50f25f15-b89f-411f-bd4c-5ad1b4a79c8d"), Nombre = "UNIDAD DE INVESTIGACION VILLA FRONTERA", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE FRANCISCO I. MADERO NO. 07 COL. CENTRO, SAN PABLO XOCHIMEHUACAN" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("4d660027-551b-4d1a-8859-8c0cacbda642"), Nombre = "UNIDAD DE INVESTIGACION VIRTUAL PREDENUNCIA EL CARMEN", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 21 ORIENTE NO.404, COL. EL CARMEN, PUEBLA,PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("0ca58122-89b9-47dd-b9f7-7a9c48db28e5"), Nombre = "UNIDAD DE INVESTIGACION VW", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3aff1abc-7309-40a0-a7b4-307cb324bff4"), Nombre = "UNIDAD DE INVESTIGACION VW", IdMunicipio = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Direccion = "AV. SAN LORENZO ALMECATLA SIN NUMERO PLAZA MOVAR SANCTORUM" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("12776070-7f37-4000-89bf-7f97bdfc5f7e"), Nombre = "UNIDAD DE INVESTIGACION XICOTEPEC DE JUAREZ", IdMunicipio = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Direccion = "CALLE 2 DE ABRIL 117 COLONIA CENTRO, XICOTEPEC DE JUAREZ, PUEBLA." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("ea5891e7-267a-47f9-8605-22c0f749fdc3"), Nombre = "UNIDAD DE INVESTIGACION Y MEDIOS ALTERNATIVOS", IdMunicipio = new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), Direccion = "AV. 5 DE MAYO NO.1 EXTERIOR DE LA PRESIDENCIA MUNICIPAL, GUADALUPE VICTORIA , PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("64429efc-2ebe-42c6-bd85-9d3210074cc1"), Nombre = "UNIDAD DE INVESTIGACION ZACAPOAXTLA", IdMunicipio = new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), Direccion = "CALLE 2 DE ABRIL SUR, EDIFICIO REVOLUCION ESQUINA IGNACIO COETO ,COL. CENTRO ZACAPOAXTLA PUEBLA" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("56a52026-ecbf-40cc-83a0-b7e62b8ce21b"), Nombre = "UNIDAD DE INVESTIGACION ZARAGOZA", IdMunicipio = new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), Direccion = "CALLE 3 ORIENTE 1211 COLONIA SANTA ANA, ZARAGOZA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("5dbcd279-f866-405f-ab9d-59ddbd147011"), Nombre = "UNIDAD DE INVESTIGACION ZOQUITLAN", IdMunicipio = new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), Direccion = "CALLE JUVENTUD S/N COL. CENTRO" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("55fce514-8946-49b4-9506-3d11385e76df"), Nombre = "UNIDAD ESPECIALIZADA ADSCRITA A LA FISCALIA METROPOLITANA (JUZGADOS PENALES)", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 12 ORIENTE NO. 608 COL. CENTRO ,PUEBLA, PUE" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("bae9be67-391c-4909-89f7-213d6a2d017f"), Nombre = "UNIDAD ESPECIALIZADA EN INVESTIGACION DE ROBO DE VEHICULOS (OCRA)", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CAMINO AL BATAN KM 2.5 COL.LOMAS DE SAN MIGUEL PUEBLA,PUE. CP.: 72573" });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("3f6bab12-2484-4ec2-a57b-c3eb5b564ed7"), Nombre = "UNIDAD INTEGRAL DE SERVICIOS EL ALTO", IdMunicipio = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Direccion = "CALLE 8 ORIENTE, NUMERO 1007, COLONIA SAN FRANCISCO, PUEBLA, PUE." });
            modelBuilder.Entity<Inmueble>().HasData(new Inmueble { Id = new Guid("d10476c9-09f1-4595-aaf4-dfb1a092c230"), Nombre = "UNIDAD MOVIL (TRANSPORTE TIPO VAN PARA USO DE FISCALIA)", IdMunicipio = new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), Direccion = "UNIDAD MOVIL (TRANSPORTE TIPO VAN PARA USO DE FISCALIA)" });




            ////Tipos de Cargos - Nuevos
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

            //// Unidades Administrativas - NUEVOS

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



            //// Centros de Trabajo - NUEVOS 
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


            ////Tipo Contrato - Nuevos

            //modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("4b7d03f3-ef7d-4e42-ad73-f520c6d65edd"), Nombre = "ASIMILADOS" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("499c6384-159a-49b1-bb24-36f13ae9fb10"), Nombre = "BASE" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("0fb4c79b-8dfd-468a-9e42-98fd742383ff"), Nombre = "CONFIANZA" });
            modelBuilder.Entity<Contratacion>().HasData(new CentroTrabajo { Id = new Guid("17805612-54b0-43ef-9860-6964ba543617"), Nombre = "HONORARIOS" });

        }
    }
}
