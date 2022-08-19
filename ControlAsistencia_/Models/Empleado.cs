using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class Empleado
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string CURP { get; set; }
        public string Cargo { get; set; }
        public string NumeroExpediente { get; set; }
        public string Adscripcion { get; set; }
        public string FechaIngreso { get; set; }
        public byte[] Huella { get; set; }
        public Guid IdInmueble { get; set; }
    }
}
