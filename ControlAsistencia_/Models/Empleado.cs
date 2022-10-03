using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Curp { get; set; }
        public string NumeroExpediente { get; set; }
        public string FechaIngreso { get; set; }
        public string UR { get; set; }
        public string Horario { get; set; }
        public byte[] Huella { get; set; }
        public bool Activo { get; set; }
        public Guid IdMunicipio { get; set; }
        public Guid IdInmueble { get; set; }
        public Guid IdCargo { get; set; }
        //public Guid IdCargoHomologado { get; set; }
        public Guid IdCentroTrabajo { get; set; }
        public Guid IdUnidadAdministrativa { get; set; }
        public Guid IdContratacion { get; set; }
    }
}
