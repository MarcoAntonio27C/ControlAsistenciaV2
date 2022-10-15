using DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using ReporteAsistencia.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ControlAsistencia_.Models;
using ReportePDF;

namespace ReporteAsistencia.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ControlAsistenciaDBContext _context;

        //public HomeController(ILogger<HomeController> logger, ControlAsistenciaDBContext context)
        public HomeController(ControlAsistenciaDBContext context)
        {
            //_logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["error"] = false;
            return View();
        }

        public async Task<IActionResult> BuscarCurp(string curp)
        {
            var empleado = await _context.Empleado.Where(x => x.CURP.Equals(curp)).ToListAsync();

            if (empleado.Count > 0)
            {

                ViewData["empleado"] = empleado.ElementAt(0);
                return View("Asistencias");
            }
            ViewData["error"] = true;
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public List<DateTime> GetDias(List<Asistencia> asistencias)
        {
            List<DateTime> Dias = new List<DateTime>();
            foreach(var asistencia in asistencias)
            {
                if (Dias.Count > 0)
                {
                    if (Dias.Last().Day < asistencia.FechaHora.Day)
                    {
                        Dias.Add(asistencia.FechaHora);
                    }
                }
                else
                {
                    Dias.Add(asistencia.FechaHora);
                }
            }
            return Dias;
        }

        public List<DateTime> GetEntradas(List<Asistencia> asistencias)
        {
            List<DateTime> Entradas = new List<DateTime>();
            foreach(var asistencia in asistencias)
            {
                if (asistencia.Tipo.Equals("Entrada"))
                {
                    if (Entradas.Count > 0)
                    {
                        if(Entradas.Last().Day < asistencia.FechaHora.Day)
                        {
                            Entradas.Add(asistencia.FechaHora);
                        }
                    }
                    else
                    {
                        Entradas.Add(asistencia.FechaHora);
                    }
                }
            }

            return Entradas;
        }
        public List<DateTime> GetSalidasComida(List<Asistencia> asistencias)
        {
            List<DateTime> SalidasComida = new List<DateTime>();
            foreach (var asistencia in asistencias)
            {
                if (asistencia.Tipo.Equals("SalidaComida"))
                {
                    if (SalidasComida.Count > 0)
                    {
                        if (SalidasComida.Last().Day < asistencia.FechaHora.Day)
                        {
                            SalidasComida.Add(asistencia.FechaHora);
                        }
                    }
                    else
                    {
                        SalidasComida.Add(asistencia.FechaHora);
                    }
                }
            }
            return SalidasComida;
        }

        public List<DateTime> GetRegresosComida(List<Asistencia> asistencias)
        {
            List<DateTime> RegresosComida = new List<DateTime>();
            foreach (var asistencia in asistencias)
            {
                if (asistencia.Tipo.Equals("RegresoComida"))
                {
                    if (RegresosComida.Count > 0)
                    {
                        if (RegresosComida.Last().Day < asistencia.FechaHora.Day)
                        {
                            RegresosComida.Add(asistencia.FechaHora);
                        }
                    }
                    else
                    {
                        RegresosComida.Add(asistencia.FechaHora);
                    }
                }
            }
            return RegresosComida;
        }

        public List<DateTime> GetSalidas(List<Asistencia> asistencias)
        {
            List<DateTime> Salidas = new List<DateTime>();
            foreach (var asistencia in asistencias)
            {
                if (asistencia.Tipo.Equals("Salida"))
                {
                    if (Salidas.Count > 0)
                    {
                        if (Salidas.Last().Day < asistencia.FechaHora.Day)
                        {
                            Salidas.Add(asistencia.FechaHora);
                        }
                    }
                    else
                    {
                        Salidas.Add(asistencia.FechaHora);
                    }
                }
            }
            return Salidas;
        }

        public List<AsistenciaOrdenada> OrdenarAsistencias(List<Asistencia> asistencias)
        {
            List<AsistenciaOrdenada> Order = new List<AsistenciaOrdenada>();
            var dias = GetDias(asistencias);
            var entradas = GetEntradas(asistencias);
            var salidasComida = GetSalidasComida(asistencias);
            var regresoComidas = GetRegresosComida(asistencias);
            var salidas = GetSalidas(asistencias);

            if (dias.Count > 0)
            {
                foreach(var dia in dias)
                {
                    AsistenciaOrdenada asistencia = new AsistenciaOrdenada();
                    asistencia.Dia = dia;
                    Order.Add(asistencia);
                }

                foreach(var entrada in entradas)
                {
                    foreach(var x in Order)
                    {
                        if (entrada.Day.Equals(x.Dia.Day))
                        {
                            x.Entrada = entrada;
                        }
                    }
                }

                foreach (var salidaComida in salidasComida)
                {
                    foreach (var x in Order)
                    {
                        if (salidaComida.Day.Equals(x.Dia.Day))
                        {
                            x.SalidaComida = salidaComida;
                        }
                    }
                }

                foreach (var regresoComida in regresoComidas)
                {
                    foreach (var x in Order)
                    {
                        if (regresoComida.Day.Equals(x.Dia.Day))
                        {
                            x.RegresoComida = regresoComida;
                        }
                    }
                }

                foreach (var salida in salidas)
                {
                    foreach (var x in Order)
                    {
                        if (salida.Day.Equals(x.Dia.Day))
                        {
                            x.Salida = salida;
                        }
                    }
                }

                return Order;
            }
            return null;
        }

        [HttpPost]
        [Produces("application/json")]
        public async Task<ActionResult<IEnumerable<TablaAsistencias>>> GetAsistencias(string idEmpleado, string mes)
        {
            
            List<TablaAsistencias> tabla = new List<TablaAsistencias>();
            DateTime fecha = DateTime.Parse(mes);
            var asistencias = await _context.Asistencia.Where(x => x.IdEmpleado.Equals(Guid.Parse(idEmpleado)) && x.FechaHora.Month.Equals(fecha.Month)).OrderBy(x => x.FechaHora).ToListAsync();
            var order = OrdenarAsistencias(asistencias);
            if (order != null)
            {
                foreach (var item in order)
                {
                    TablaAsistencias asistencia = new TablaAsistencias();
                    if (!item.Dia.Year.Equals(1))
                    {
                        asistencia.Dia = item.Dia.ToString("M");
                    }
                    if (!item.Entrada.Year.Equals(1))
                    {
                        asistencia.Entrada = item.Entrada.ToString("t");
                    }
                    else
                    {
                        asistencia.Entrada = "";
                    }

                    if (!item.SalidaComida.Year.Equals(1))
                    {
                        asistencia.SalidaComida = item.SalidaComida.ToString("t");
                    }
                    else
                    {
                        asistencia.SalidaComida = "";
                    }

                    if (!item.RegresoComida.Year.Equals(1))
                    {
                        asistencia.RegresoComida = item.RegresoComida.ToString("t");
                    }
                    else
                    {
                        asistencia.RegresoComida = "";
                    }

                    if (!item.Salida.Year.Equals(1))
                    {
                        asistencia.Salida = item.Salida.ToString("t");
                    }
                    else
                    {
                        asistencia.Salida = "";
                    }

                    tabla.Add(asistencia);
                }
                return tabla;
            }

            return null;
        }

        public async Task<FileResult> DescargarPDFAsync(string idEmpleado, string mes)
        {
            DateTime date = DateTime.Parse(mes);
            var empleado = await _context.Empleado.FindAsync(Guid.Parse(idEmpleado));
            var asistencias = await _context.Asistencia.Where(x => x.IdEmpleado.Equals(Guid.Parse(idEmpleado)) && x.FechaHora.Month.Equals(date.Month)).OrderBy(x => x.FechaHora).ToListAsync();
           
           
            var entradas = GetEntradas(asistencias);
            var salidas = GetSalidas(asistencias);

            CrearReporte reporte = new CrearReporte();
            string filepath = System.IO.Path.GetTempFileName().Replace(".tmp", ".pdf");
            return reporte.Crear(empleado,entradas, salidas, filepath);
        }

    }
}
