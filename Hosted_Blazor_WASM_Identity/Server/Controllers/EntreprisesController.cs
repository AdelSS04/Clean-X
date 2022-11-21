using Hosted_Blazor_WASM_Identity.Server.Data;
using Hosted_Blazor_WASM_Identity.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hosted_Blazor_WASM_Identity.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntreprisesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EntreprisesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Entreprises
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entreprise>>> GetEntreprise()
        {
            return await _context.Entreprise.ToListAsync();
        }

        // GET: api/Entreprises/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entreprise>> GetEntreprise(int id)
        {
            var entreprise = await _context.Entreprise.FindAsync(id);

            if (entreprise == null)
            {
                return NotFound();
            }

            return entreprise;
        }

        // PUT: api/Entreprises/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntreprise(int id, Entreprise entreprise)
        {
            if (id != entreprise.Id)
            {
                return BadRequest();
            }

            _context.Entry(entreprise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntrepriseExists(id))
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

        // POST: api/Entreprises
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Entreprise>> PostEntreprise(Entreprise entreprise)
        {
            _context.Entreprise.Add(entreprise);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntreprise", new { id = entreprise.Id }, entreprise);
        }

        // DELETE: api/Entreprises/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEntreprise(int id)
        {
            var entreprise = await _context.Entreprise.FindAsync(id);
            if (entreprise == null)
            {
                return NotFound();
            }

            _context.Entreprise.Remove(entreprise);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntrepriseExists(int id)
        {
            return _context.Entreprise.Any(e => e.Id == id);
        }
    }
}
