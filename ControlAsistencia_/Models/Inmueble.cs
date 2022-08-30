using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class Inmueble
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Guid IdMunicipio { get; set; }
    }
}
