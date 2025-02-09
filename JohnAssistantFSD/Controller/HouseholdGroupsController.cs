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
    public class HouseholdGroupsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public HouseholdGroupsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/HouseholdGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HouseholdGroup>>> GetHouseholdGroup()
        {
            return await _context.HouseholdGroup.ToListAsync();
        }

        // GET: api/HouseholdGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HouseholdGroup>> GetHouseholdGroup(int id)
        {
            var householdGroup = await _context.HouseholdGroup.FindAsync(id);

            if (householdGroup == null)
            {
                return NotFound();
            }

            return householdGroup;
        }

        // PUT: api/HouseholdGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHouseholdGroup(int id, HouseholdGroup householdGroup)
        {
            if (id != householdGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(householdGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HouseholdGroupExists(id))
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

        // POST: api/HouseholdGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HouseholdGroup>> PostHouseholdGroup(HouseholdGroup householdGroup)
        {
            _context.HouseholdGroup.Add(householdGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHouseholdGroup", new { id = householdGroup.Id }, householdGroup);
        }

        // DELETE: api/HouseholdGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHouseholdGroup(int id)
        {
            var householdGroup = await _context.HouseholdGroup.FindAsync(id);
            if (householdGroup == null)
            {
                return NotFound();
            }

            _context.HouseholdGroup.Remove(householdGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HouseholdGroupExists(int id)
        {
            return _context.HouseholdGroup.Any(e => e.Id == id);
        }
    }
}
