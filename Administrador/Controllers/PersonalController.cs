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

        private readonly ControlAsistenciaDBContext _context;

        public PersonalController(ControlAsistenciaDBContext context)
        {
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

        public async Task<IActionResult> DetallesAsync(string idEmpleado)
        {
            var empleado = await _context.Empleado.FindAsync(Guid.Parse(idEmpleado));
            ViewData["empleado"] = empleado;
            return View();
        }
        public async Task<IActionResult> GuardarDatosAsync(IFormCollection form)
        {
            Empleado empleado = new Empleado();
            empleado.NombreCompleto = form["nombreCompleto"];
            empleado.NumeroExpediente = form["numeroExpediente"];
            empleado.FechaIngreso = form["fechaIngreso"];
            empleado.UR = form["ur"];
            empleado.Horario = form["horario"];
            empleado.Activo = true;
            empleado.IdMunicipio = Guid.Parse(form["municipio"]);
            empleado.IdInmueble = Guid.Parse(form["inmueble"]);
            empleado.IdCargo = Guid.Parse(form["cargo"]);
            empleado.IdCargoHomologado = Guid.Parse(form["cargoHomologado"]);
            empleado.IdCentroTrabajo = Guid.Parse(form["centroTrabajo"]);
            empleado.IdUnidadAdministrativa = Guid.Parse(form["unidadAdministrativa"]);
            empleado.IdContratacion = Guid.Parse(form["contratacion"]);
            _context.Empleado.Add(empleado);

            var exist = await isExisteAsync(form["numeroExpediente"]);

            if (exist)
            {
                ViewData["error"] = true;
                ViewData["mensaje"] = "Ya existe un registro con el mismo numero de Expediente, verifique la información";
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





        async Task<bool> isExisteAsync(string numeroExpediente)
        {
            var x = await _context.Empleado.Where(e => e.NumeroExpediente.Equals(numeroExpediente)).ToListAsync();

            if (x.Count > 0)
            {
                return true;
            }
            return false;
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
                    x.empleado.NombreCompleto,
                    NombreInmueble = x.inmueble.Nombre,
                    x.empleado.NumeroExpediente
                }
                ).ToListAsync();

            return Ok(empleados);
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipios()
        {
            var municipios = await _context.Municipio.OrderBy(x => x.Nombre).ToListAsync();
            return municipios;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Inmueble>>> GetInmueblesMunicipio(Guid id)
        {
            var inmuebles = await _context.Inmueble.Where(x => x.IdMunicipio.Equals(id)).OrderBy(n => n.Nombre).ToListAsync();
            return inmuebles;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<UnidadAdministrativa>>> GetUnidadAdministrativa()
        {
            var unidadAdministrativas = await _context.UnidadAdministrativa.OrderBy(n => n.Nombre).ToListAsync();
            return unidadAdministrativas;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<CentroTrabajo>>> GetCentroTrabajo()
        {
            var centroTrabajo = await _context.CentroTrabajo.OrderBy(n => n.Nombre).ToListAsync();
            return centroTrabajo;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Cargo>>> GetCargo()
        {
            var cargo = await _context.Cargo.OrderBy(n => n.Nombre).ToListAsync();
            return cargo;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<CargoHomologado>>> GetCargoHomologado()
        {
            var cargoHomologado = await _context.CargoHomologado.OrderBy(n => n.Nombre).ToListAsync();
            return cargoHomologado;
        }

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Contratacion>>> GetContratacion()
        {
            var contratacion = await _context.Contratacion.OrderBy(n => n.Nombre).ToListAsync();
            return contratacion;
        }

    }
}
