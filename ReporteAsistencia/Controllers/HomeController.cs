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
            var empleado = await _context.Empleado.Where(x => x.Curp.Equals(curp)).ToListAsync();
        
            if (empleado.Count > 0)
            {
                ViewData["empleado"] = await DatosGeneralesAsync(empleado.ElementAt(0));
                return View("Asistencias");
            }
            ViewData["error"] = true;
            return View("Index");
        }

        public async Task<DatosEmpleado> DatosGeneralesAsync(Empleado empleado)
        {
            DatosEmpleado datos = new DatosEmpleado();

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
            datos.Inmueble = inmueble.Nombre;
            datos.Direccion = inmueble.Direccion;
            datos.Cargo = cargo.Nombre;
            datos.CentroTrabajo = centroTrabajo.Nombre;
            datos.UnidadAdministrativa = unidadAdministrativa.Nombre;
            datos.Contratacion = contratacion.Nombre;
            return datos;
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
        public List<AsistenciaOrdenada> OrdenarAsistencias(List<Asistencia> asistencias, List<Incidencia> incidencias)
        {
            List<AsistenciaOrdenada> Order = new List<AsistenciaOrdenada>();
            List<Asistencia> temporal = new List<Asistencia>();

            foreach(var asistencia in asistencias)
            {
                Asistencia tmp = new Asistencia();
                tmp.FechaHora = asistencia.FechaHora;
                tmp.Tipo = asistencia.Tipo;
                temporal.Add(tmp);
            }

            foreach (var asistencia in incidencias)
            {
                Asistencia tmp = new Asistencia();
                tmp.FechaHora = asistencia.FechaHora;
                tmp.Tipo = asistencia.Tipo;
                temporal.Add(tmp);
            }

            var tmpDias = temporal.OrderBy(x => x.FechaHora).ToList();

            var dias = GetDias(tmpDias);
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
            var asistencias = await _context.Asistencia.Where(x => x.IdEmpleado.Equals(Guid.Parse(idEmpleado)) && x.FechaHora.Month.Equals(fecha.Month) && x.FechaHora.Year.Equals(fecha.Year)).OrderBy(x => x.FechaHora).ToListAsync();
            var incidencias = await _context.Incidencia.Where(x => x.IdEmpleado.Equals(Guid.Parse(idEmpleado)) && x.FechaHora.Month.Equals(fecha.Month) && x.FechaHora.Year.Equals(fecha.Year)).OrderBy(x => x.FechaHora).ToListAsync();
            var tmpIncidencias = incidencias;

            var order = OrdenarAsistencias(asistencias,incidencias);
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

                    if (tmpIncidencias.Count > 0)
                    {
                        if (item.Dia.Day.Equals(tmpIncidencias.First().FechaHora.Day))
                        {
                            asistencia.Entrada = tmpIncidencias.First().Tipo;
                            asistencia.SalidaComida = tmpIncidencias.First().Tipo;
                            asistencia.RegresoComida = tmpIncidencias.First().Tipo;
                            asistencia.Salida = tmpIncidencias.First().Tipo;
                            tmpIncidencias.RemoveAt(0);
                        }
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
            var Datos_Generales = await DatosGeneralesAsync(empleado);
            var asistencias = await _context.Asistencia.Where(x => x.IdEmpleado.Equals(Guid.Parse(idEmpleado)) && x.FechaHora.Year.Equals(date.Year) && x.FechaHora.Month.Equals(date.Month)).OrderBy(x => x.FechaHora).ToListAsync();
            var incidencias = await _context.Incidencia.Where(x => x.IdEmpleado.Equals(empleado.Id) && x.FechaHora.Year.Equals(date.Year) && x.FechaHora.Month.Equals(date.Month)).OrderBy(x => x.FechaHora).ToListAsync();
           
            var entradas = GetEntradas(asistencias);
            var salidas = GetSalidas(asistencias);

            CrearReporte reporte = new CrearReporte();
            string filepath = System.IO.Path.GetTempFileName().Replace(".tmp", ".pdf");
            return reporte.Crear(Datos_Generales,entradas, salidas,incidencias ,filepath);
        }

    }
}
