using ControlAsistencia_.Models;
using DBContext;
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
    public class MunicipioController : Controller
    {
        private readonly ControlAsistenciaDBContext _context;

        public MunicipioController(ControlAsistenciaDBContext context)
        {
            _context = context;
        }

        // GET: api/Municipio/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Municipio>> GetMunicipio(Guid id)
        {
            var municipio = await _context.Municipio.FindAsync(id);
            if (municipio == null)
            {
                return NotFound();
            }
            return municipio;
        }

        // GET: api/Municipios
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Municipio>>> GetMunicipios()
        {
            return await _context.Municipio.OrderBy(x => x.Nombre).ToListAsync();
        }

    }
}
