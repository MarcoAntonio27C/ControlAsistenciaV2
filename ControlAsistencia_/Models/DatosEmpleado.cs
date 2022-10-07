using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class DatosEmpleado
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroExpediente { get; set; }
        public string Curp { get; set; }
        public string FechaIngreso { get; set; }
        public string UR { get; set; }
        public string Horario { get; set; }
        public byte[] Huella { get; set; }
        public bool Activo { get; set; }
        public string Municipio { get; set; }
        public string Inmueble { get; set; }
        public string Direccion { get; set; }
        public string Cargo { get; set; }
        public string CargoHomologado { get; set; }
        public string CentroTrabajo { get; set; }
        public string UnidadAdministrativa { get; set; }
        public string Contratacion { get; set; }
    }
}
