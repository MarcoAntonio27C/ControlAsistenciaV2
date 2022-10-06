using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Administrador.Controllers
{
    public class IncidenciasController : Controller
    {
        private readonly ControlAsistenciaDBContext _context;

        public IncidenciasController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }
        // GET: IncidenciasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IncidenciasController/Details/5
        public async Task<ActionResult> EmpleadoAsync(string idEmpleado, string mes)
        {
            Empleado empleado = await _context.Empleado.FindAsync(Guid.Parse(idEmpleado));
            DateTime fecha = DateTime.Parse(mes);
            List<Incidencia> incidencias = new List<Incidencia>();
            incidencias = await _context.Incidencia.Where(x => x.IdEmpleado.Equals(empleado.Id) && x.FechaHora.Year.Equals(fecha.Year) && x.FechaHora.Month.Equals(fecha.Month)).OrderBy(x => x.FechaHora).ToListAsync();
            ViewData["empleado"] = empleado;
            ViewData["tabla"] = incidencias;
            ViewData["fecha"] = fecha.ToString("yyyy-MM-01");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> AgregarAsync(string idEmpleado, string dia, string tipo)
        {
            Empleado empleado = await _context.Empleado.FindAsync(Guid.Parse(idEmpleado));
            DateTime fecha = DateTime.Parse(dia);
            Incidencia incidencia = new Incidencia();
            incidencia.Id = Guid.NewGuid();
            incidencia.IdEmpleado = Guid.Parse(idEmpleado);
            incidencia.Tipo = tipo;
            incidencia.FechaHora = DateTime.Parse(dia);

            _context.Incidencia.Add(incidencia);
            await _context.SaveChangesAsync();

            return RedirectToAction("Empleado", "Incidencias", new {/* routeValues, for example: */ idEmpleado = idEmpleado,mes = dia });

        }


        public async Task<ActionResult> Delete(string idIncidencia)
        {
            Incidencia incidencia = await _context.Incidencia.FindAsync(Guid.Parse(idIncidencia));
            _context.Incidencia.Remove(incidencia);
            await _context.SaveChangesAsync();
            return RedirectToAction("Empleado", "Incidencias", new {/* routeValues, for example: */ idEmpleado = incidencia.IdEmpleado, mes = DateTime.Now.ToString("d") });
            //return Content(idIncidencia);
        }
    }
}
