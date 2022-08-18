using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class Asistencia
    {
        public Guid Id { get; set; }
        public Guid IdEmpleado { get; set; }
        public string Tipo { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
