using ControlAsistencia_.Models;
using DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly ControlAsistenciaDBContext _context;

        public EmpleadoController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }

        // GET: api/Empleado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleado(Guid id)
        {
            var Empleado = await _context.Empleado.FindAsync(id);

            if (Empleado == null)
            {
                return NotFound();
            }

            return Empleado;
        }

        // GET: api/Empleado/5
        [HttpGet("NumeroExpediente/{numeroExpediente}")]
        public async Task<ActionResult<Empleado>> GetEmpleadoNumeroExpediente(string numeroExpediente)
        {
            var Empleado = await _context.Empleado.Where(x => x.NumeroExpediente.Equals(numeroExpediente)).FirstAsync();

            if (Empleado == null)
            {
                return NotFound();
            }

            return Empleado;
        }

        // GET: api/Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleados()
        {
            return await _context.Empleado.Where(x => x.Huella != null).ToListAsync();
        }

        [HttpGet("EmpleadosPorInmueble/{idInmueble}")]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleadosInmueble(string idInmueble)
        {
            return await _context.Empleado.Where(x => (!x.Huella.Equals(null)) && (x.IdInmueble.Equals(Guid.Parse(idInmueble)))).ToListAsync();
        }

        // POST: api/EmpleadoCreatedAtAction
        [HttpPost]
        public async Task<ActionResult<Empleado>> AddEmpleado(Empleado Empleado)
        {
            _context.Empleado.Add(Empleado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleado", new { id = Empleado.Id }, Empleado);
        }

        // DELETE: api/Empleado
        [HttpPost("{id}")]
        public async Task<IActionResult> DeleteEmpleado(Guid id)
        {
            var Empleado = await _context.Empleado.FindAsync(id);
            if (Empleado == null)
            {
                return NotFound();
            }

            _context.Empleado.Remove(Empleado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPost("Actualizar")]
        public async Task<IActionResult> PutEmpleado(Empleado Empleado)
        {
            Empleado.Activo = true;
            _context.Entry(Empleado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadoExists(Empleado.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool EmpleadoExists(Guid id)
        {
            return _context.Empleado.Any(e => e.Id == id);
        }
    }
}
