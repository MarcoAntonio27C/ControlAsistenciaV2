using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Http;
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
            ViewData["mensaje"] = "";
            ViewData["error"] = false;
            return View();
        }

        public async Task<IActionResult> GuardarDatosAsync(IFormCollection form)
        {
            Empleado empleado = new Empleado();
            empleado.Nombre = form["nombre"];
            empleado.ApellidoPaterno = form["apellidoPaterno"];
            empleado.ApellidoMaterno = form["apellidoMaterno"];
            empleado.CURP = form["curp"];
            empleado.Cargo = form["cargo"];
            empleado.NumeroExpediente = form["numeroExpediente"];
            empleado.Adscripcion = form["adscripcion"];
            empleado.FechaIngreso = form["fechaIngreso"];
            empleado.IdInmueble = Guid.Parse(form["inmueble"]);
            _context.Empleado.Add(empleado);

            var exist = await isExisteAsync(form["curp"]);

            if (exist)
            {
                ViewData["error"] = true;
                ViewData["mensaje"] = "Ya existe un registro con el mismo CURP, verifique la información";
                return View("Agregar");
            }

            if (await _context.SaveChangesAsync() == 0)
            {
                ViewData["error"] = true;
                ViewData["mensaje"] = "No se guardo correctamente la información, intentelo de nuevo";
                return View("Agregar");
            }
            ViewData["error"] = false;
            ViewData["mensaje"] = "La información se guardo correctamente";
            return View("Agregar");
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

        async Task<bool> isExisteAsync(string curp)
        {
            var x = await _context.Empleado.Where(e => e.CURP.Equals(curp)).ToListAsync();

            if (x.Count > 0)
            {
                return true;
            }
            return false;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Inmueble>>> GetInmuebles()
        {
            var inmuebles = await _context.Inmueble.OrderBy(x => x.Nombre).ToListAsync();
            return inmuebles;
        }
    }
}
