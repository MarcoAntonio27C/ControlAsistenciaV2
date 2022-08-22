using DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ILogger<PersonalController> _logger;
        private readonly ControlAsistenciaDBContext _context;

        public PersonalController(ILogger<PersonalController> logger, ControlAsistenciaDBContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Personal()
        {
            return View();
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult> Empleados()
        {
            var empleados = await _context.Empleado.Join(_context.Inmueble, empleado => empleado.IdInmueble,
                inmueble => inmueble.Id, (empleado, inmueble) => new { empleado, inmueble }).Select(
                x => new
                {
                    x.empleado.Id,
                    x.empleado.Nombre,
                    x.empleado.ApellidoPaterno,
                    x.empleado.ApellidoMaterno,
                    NombreInmueble = x.inmueble.Nombre,
                    x.empleado.Adscripcion,
                    x.empleado.NumeroExpediente
                }
                ).ToListAsync();

            return Ok(empleados);
        }
    }
}
