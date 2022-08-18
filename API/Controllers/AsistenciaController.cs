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
    public class AsistenciaController : ControllerBase
    {
        private readonly ControlAsistenciaDBContext _context;

        public AsistenciaController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }

        // GET: api/Asistencia/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asistencia>> GetAsistencia(Guid id)
        {
            var Asistencia = await _context.Asistencia.FindAsync(id);

            if (Asistencia == null)
            {
                return NotFound();
            }

            return Asistencia;
        }

        // GET: api/Asistencias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asistencia>>> GetAsistencias()
        {
            return await _context.Asistencia.ToListAsync();
        }

        // POST: api/Asistencia
        [HttpPost]
        public async Task<ActionResult<Asistencia>> AddAsistencia(Asistencia Asistencia)
        {
            _context.Asistencia.Add(Asistencia);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAsistencia", new { id = Asistencia.Id }, Asistencia);
        }

        // DELETE: api/Asistencia
        [HttpPost("{id}")]
        public async Task<IActionResult> DeleteAsistencia(Guid id)
        {
            var Asistencia = await _context.Asistencia.FindAsync(id);
            if (Asistencia == null)
            {
                return NotFound();
            }

            _context.Asistencia.Remove(Asistencia);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsistencia(Guid id, Asistencia Asistencia)
        {
            if (id != Asistencia.Id)
            {
                return BadRequest();
            }

            _context.Entry(Asistencia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsistenciaExists(id))
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

        private bool AsistenciaExists(Guid id)
        {
            return _context.Asistencia.Any(e => e.Id == id);
        }
    }
}
