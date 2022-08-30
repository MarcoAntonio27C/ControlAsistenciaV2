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
    public class InmuebleController : ControllerBase
    {
        private readonly ControlAsistenciaDBContext _context;

        public InmuebleController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }

        // GET: api/Inmueble/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Inmueble>> GetInmueble(Guid id)
        {
            var inmueble = await _context.Inmueble.FindAsync(id);

            if (inmueble == null)
            {
                return NotFound();
            }

            return inmueble;
        }

        // GET: api/Inmuebles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Inmueble>>> GetInmuebles()
        {
            return await _context.Inmueble.OrderBy(x => x.Nombre).ToListAsync();
        }

        [HttpGet("Municipio/{id}")]
        public async Task<ActionResult<IEnumerable<Inmueble>>> GetInmueblesMunicipio(Guid id)
        {
            return await _context.Inmueble.Where(x => x.IdMunicipio.Equals(id)).OrderBy(n => n.Nombre).ToListAsync();
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutInmueble(Guid id, Inmueble inmueble)
        {
            if (id != inmueble.Id)
            {
                return BadRequest();
            }

            _context.Entry(inmueble).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InmuebleExists(id))
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

        private bool InmuebleExists(Guid id)
        {
            return _context.Inmueble.Any(e => e.Id == id);
        }
    }
}
