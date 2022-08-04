using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DummyProject.Domain;
using DummyProject.Infraestructure;

namespace DummyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DummiesController : ControllerBase
    {
        private readonly BDContext _context;

        public DummiesController(BDContext context)
        {
            _context = context;
        }

        // GET: api/Dummies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dummy>>> GetDummy()
        {
            return await _context.Dummy.ToListAsync();
        }

        // GET: api/Dummies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Dummy>> GetDummy(int id)
        {
            var dummy = await _context.Dummy.FindAsync(id);

            if (dummy == null)
            {
                return NotFound();
            }

            return dummy;
        }

        // PUT: api/Dummies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDummy(int id, Dummy dummy)
        {
            if (id != dummy.id)
            {
                return BadRequest();
            }

            _context.Entry(dummy).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DummyExists(id))
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

        // POST: api/Dummies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dummy>> PostDummy(Dummy dummy)
        {
            _context.Dummy.Add(dummy);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDummy", new { id = dummy.id }, dummy);
        }

        // DELETE: api/Dummies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDummy(int id)
        {
            var dummy = await _context.Dummy.FindAsync(id);
            if (dummy == null)
            {
                return NotFound();
            }

            _context.Dummy.Remove(dummy);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DummyExists(int id)
        {
            return _context.Dummy.Any(e => e.id == id);
        }
    }
}
