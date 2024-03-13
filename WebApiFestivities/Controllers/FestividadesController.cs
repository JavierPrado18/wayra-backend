
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiFestivities.Models;

namespace WebApiFestivities.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestividadesController : ControllerBase
    {
        private readonly FestividadesDBContext _context;

        public FestividadesController(FestividadesDBContext context)
        {
            _context = context;
        }

        // GET: api/Festividades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Festividad>>> GetFestividades()
        {
            return await _context.Festividades.ToListAsync();
        }

        // GET: api/Festividades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Festividad>> GetFestividad(int id)
        {
            var festividad = await _context.Festividades.FindAsync(id);

            if (festividad == null)
            {
                return NotFound();
            }

            return festividad;
        }

        // PUT: api/Festividades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFestividad(int id, Festividad festividad)
        {
            if (id != festividad.Id)
            {
                return BadRequest();
            }

            _context.Entry(festividad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FestividadExists(id))
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

        // POST: api/Festividades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Festividad>> PostFestividad(Festividad festividad)
        {
            _context.Festividades.Add(festividad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFestividad", new { id = festividad.Id }, festividad);
        }

        // DELETE: api/Festividades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFestividad(int id)
        {
            var festividad = await _context.Festividades.FindAsync(id);
            if (festividad == null)
            {
                return NotFound();
            }

            _context.Festividades.Remove(festividad);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FestividadExists(int id)
        {
            return _context.Festividades.Any(e => e.Id == id);
        }
    }
}
