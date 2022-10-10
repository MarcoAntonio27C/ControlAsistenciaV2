using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
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

        public async Task<IActionResult> Inicio()
        {
            var idUnidadAdministrativa = User.Claims.ElementAt(1).Value;
            if (User.IsInRole("592d923a-9d0b-424c-8bc3-0c42ff72495e"))
            {
                var empleadosUnidad = await _context.Empleado.Where(x => x.IdUnidadAdministrativa.Equals(Guid.Parse(idUnidadAdministrativa))).ToListAsync();
                ViewData["empleados"] = empleadosUnidad;
                return View();
            }else
            {
                var empleados = await _context.Empleado.ToListAsync();
                ViewData["empleados"] = empleados;
                return View();
            }

        }

        public IActionResult Agregar()
        {
            ViewData["mensaje"] = "";
            ViewData["error"] = false;
            return View();
        }

        public async Task<IActionResult> ActualizarAsync(string idEmpleado)
        {
            Empleado empleado = new Empleado();
            DatosEmpleado datosEmpleado = new DatosEmpleado();
            datosEmpleado = await DatosGenerales(idEmpleado);
            empleado = await _context.Empleado.FindAsync(Guid.Parse(idEmpleado));
            ViewData["empleado"] = empleado; 
            ViewData["datosEmpleado"] = datosEmpleado;
            ViewData["mensaje"] = "";
            ViewData["error"] = false;
            return View();
        }

        public async Task<IActionResult> BuscarPorUnidad(string nombre)
        {
            var idUnidadAdministrativa = User.Claims.ElementAt(1).Value;
            var empleadosUnidad = await _context.Empleado.Where(x => x.NombreCompleto.Contains(nombre) && x.IdUnidadAdministrativa.Equals(Guid.Parse(idUnidadAdministrativa))).ToListAsync();
            ViewData["empleados"] = empleadosUnidad;
            return View("Inicio");
        }

        public async Task<IActionResult> BuscarGeneral(string nombre)
        {
            var empleadosUnidad = await _context.Empleado.Where(x => x.NombreCompleto.Contains(nombre)).ToListAsync();
            ViewData["empleados"] = empleadosUnidad;
            return View("Inicio");
        }

        public async Task<IActionResult> GuardarDatosAsync(IFormCollection form)
        {
            Empleado empleado = new Empleado();
            empleado.NombreCompleto = form["nombreCompleto"];
            empleado.Curp = form["curp"];
            empleado.NumeroExpediente = form["numeroExpediente"];
            empleado.FechaIngreso = form["fechaIngreso"];
            empleado.UR = form["ur"];
            empleado.Horario = form["horario"];
            empleado.Activo = true;
            empleado.IdMunicipio = Guid.Parse(form["municipio"]);
            empleado.IdInmueble = Guid.Parse(form["inmueble"]);
            empleado.IdCargo = Guid.Parse(form["cargo"]);
            empleado.IdCentroTrabajo = Guid.Parse(form["centroTrabajo"]);
            empleado.IdUnidadAdministrativa = Guid.Parse(form["unidadAdministrativa"]);
            empleado.IdContratacion = Guid.Parse(form["contratacion"]);
            _context.Empleado.Add(empleado);

            var exist = await isExisteAsync(form["curp"]);

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

        [HttpGet]
        [Produces("application/json")]
        public async Task<IActionResult> ActualizarDatosAsync(DatosEmpleado valdata)
        {
            var id = valdata.Id.ToString();
            var empleado = await _context.Empleado.FindAsync(Guid.Parse(id));
   

            empleado.NombreCompleto = valdata.NombreCompleto;
            empleado.NumeroExpediente = valdata.NumeroExpediente;
            empleado.FechaIngreso = valdata.FechaIngreso;
            empleado.UR = valdata.UR;
            empleado.Curp = valdata.Curp;
            empleado.Horario = valdata.Horario;
            empleado.IdMunicipio = Guid.Parse(valdata.Municipio);
            empleado.IdInmueble = Guid.Parse(valdata.Inmueble);
            empleado.IdCargo = Guid.Parse(valdata.Cargo);
            //empleado.IdCargoHomologado = Guid.Parse(valdata.CargoHomologado);
            empleado.IdCentroTrabajo = Guid.Parse(valdata.CentroTrabajo);
            empleado.IdUnidadAdministrativa = Guid.Parse(valdata.UnidadAdministrativa);
            empleado.IdContratacion = Guid.Parse(valdata.Contratacion);
            _context.Entry(empleado).State = EntityState.Modified;

            var empleados = await _context.Empleado.Where(x => x.Curp.Equals(valdata.Curp) && !x.Id.Equals(empleado.Id)).CountAsync();

            if(empleados == 0)
            {
                if (await _context.SaveChangesAsync() != 0)
                {
                    return Ok("Ok");
                }
            }
            return Ok("Error");
        }

        async Task<bool> isExisteAsync(string curp)
        {
            var x = await _context.Empleado.Where(e => e.Curp.Equals(curp)).ToListAsync();

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
        public async Task<DatosEmpleado> DatosGenerales(string idEmpleado)
        {
            Empleado empleado = new Empleado();
            empleado = await _context.Empleado.Where(x => x.Id.Equals(Guid.Parse(idEmpleado))).FirstAsync();
            DatosEmpleado datos = new DatosEmpleado();

            var municipio = await _context.Municipio.Where(x => x.Id.Equals(empleado.IdMunicipio)).FirstAsync();
            var inmueble = await _context.Inmueble.Where(x => x.Id.Equals(empleado.IdInmueble)).FirstAsync();
            var cargo = await _context.Cargo.Where(x => x.Id.Equals(empleado.IdCargo)).FirstAsync();
            //var cargoHomologado = await _context.CargoHomologado.Where(x => x.Id.Equals(empleado.IdCargoHomologado)).FirstAsync();
            var centroTrabajo = await _context.CentroTrabajo.Where(x => x.Id.Equals(empleado.IdCentroTrabajo)).FirstAsync();
            var unidadAdministrativa = await _context.UnidadAdministrativa.Where(x => x.Id.Equals(empleado.IdUnidadAdministrativa)).FirstAsync();
            var contratacion = await _context.Contratacion.Where(x => x.Id.Equals(empleado.IdContratacion)).FirstAsync();

            datos.Id = empleado.Id;
            datos.NombreCompleto = empleado.NombreCompleto;
            datos.NumeroExpediente = empleado.NumeroExpediente;
            datos.FechaIngreso = empleado.FechaIngreso;
            datos.UR = empleado.UR;
            datos.Horario = empleado.Horario;
            datos.Activo = empleado.Activo;
            datos.Municipio = municipio.Nombre;
            datos.Inmueble = inmueble.Nombre;
            datos.Direccion = inmueble.Direccion;
            datos.Cargo = cargo.Nombre;
            datos.CentroTrabajo = centroTrabajo.Nombre;
            //datos.CargoHomologado = cargoHomologado.Nombre;
            datos.UnidadAdministrativa = unidadAdministrativa.Nombre;
            datos.Contratacion = contratacion.Nombre;
            return datos;
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

        //[HttpGet]
        //[Produces("application/json")]
        //public async Task<ActionResult<IEnumerable<CargoHomologado>>> GetCargoHomologado()
        //{
        //    var cargoHomologado = await _context.CargoHomologado.OrderBy(n => n.Nombre).ToListAsync();
        //    return cargoHomologado;
        //}

        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<Contratacion>>> GetContratacion()
        {
            var contratacion = await _context.Contratacion.OrderBy(n => n.Nombre).ToListAsync();
            return contratacion;
        }

    }
}
