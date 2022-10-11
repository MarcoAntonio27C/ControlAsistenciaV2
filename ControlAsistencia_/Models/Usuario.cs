using System;
using System.Collections.Generic;
using System.Text;

namespace ControlAsistencia_.Models
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Administrador { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string IdUnidadAdministrativa { get; set; }
        public bool Activo { get; set; }
        public string IdRol { get; set; }
    }
}
