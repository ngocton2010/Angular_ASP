#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASPWebAngular.Model;

namespace ASPWebAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufactureController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public ManufactureController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Manufacture
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Manufacture>>> GetManufactures()
        {
            return await _context.Manufactures.ToListAsync();
        }

        // GET: api/Manufacture/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Manufacture>> GetManufacture(int id)
        {
            var manufacture = await _context.Manufactures.FindAsync(id);

            if (manufacture == null)
            {
                return NotFound();
            }

            return manufacture;
        }

        // PUT: api/Manufacture/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutManufacture(int id, Manufacture manufacture)
        {
            if (id != manufacture.MaNCC)
            {
                return BadRequest();
            }

            _context.Entry(manufacture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufactureExists(id))
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

        // POST: api/Manufacture
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Manufacture>> PostManufacture(Manufacture manufacture)
        {
            _context.Manufactures.Add(manufacture);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetManufacture", new { id = manufacture.MaNCC }, manufacture);
        }

        // DELETE: api/Manufacture/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteManufacture(int id)
        {
            var manufacture = await _context.Manufactures.FindAsync(id);
            if (manufacture == null)
            {
                return NotFound();
            }

            _context.Manufactures.Remove(manufacture);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ManufactureExists(int id)
        {
            return _context.Manufactures.Any(e => e.MaNCC == id);
        }
    }
}
