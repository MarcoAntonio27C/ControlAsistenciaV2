using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class TablaEmpleado
    {
        public Guid Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Inmueble { get; set; }
        public string Adscripcion { get; set; }
        public string RegistroHuella { get; set; }
        public string Activo { get; set; }
    }
}
