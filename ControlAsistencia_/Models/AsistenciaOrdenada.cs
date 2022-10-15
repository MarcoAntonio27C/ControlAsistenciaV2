using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class AsistenciaOrdenada
    {
        public DateTime Dia { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime SalidaComida { get; set; }
        public DateTime RegresoComida { get; set; }
        public DateTime Salida { get; set; }
    }
}
