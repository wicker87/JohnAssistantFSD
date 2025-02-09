using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JohnAssistantFSD.Data;
using JohnAssistantFSD.Domain;

namespace JohnAssistantFSD.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseholdsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public HouseholdsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/Households
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Household>>> GetHousehold()
        {
            return await _context.Household.ToListAsync();
        }

        // GET: api/Households/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Household>> GetHousehold(int id)
        {
            var household = await _context.Household.FindAsync(id);

            if (household == null)
            {
                return NotFound();
            }

            return household;
        }

        // PUT: api/Households/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHousehold(int id, Household household)
        {
            if (id != household.Id)
            {
                return BadRequest();
            }

            _context.Entry(household).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HouseholdExists(id))
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

        // POST: api/Households
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Household>> PostHousehold(Household household)
        {
            _context.Household.Add(household);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHousehold", new { id = household.Id }, household);
        }

        // DELETE: api/Households/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHousehold(int id)
        {
            var household = await _context.Household.FindAsync(id);
            if (household == null)
            {
                return NotFound();
            }

            _context.Household.Remove(household);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HouseholdExists(int id)
        {
            return _context.Household.Any(e => e.Id == id);
        }
    }
}
