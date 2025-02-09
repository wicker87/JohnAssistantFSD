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
    public class TDListGroupsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public TDListGroupsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/TDListGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TDListGroup>>> GetTDListGroup()
        {
            return await _context.TDListGroup.ToListAsync();
        }

        // GET: api/TDListGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TDListGroup>> GetTDListGroup(int id)
        {
            var tDListGroup = await _context.TDListGroup.FindAsync(id);

            if (tDListGroup == null)
            {
                return NotFound();
            }

            return tDListGroup;
        }

        // PUT: api/TDListGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTDListGroup(int id, TDListGroup tDListGroup)
        {
            if (id != tDListGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(tDListGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TDListGroupExists(id))
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

        // POST: api/TDListGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TDListGroup>> PostTDListGroup(TDListGroup tDListGroup)
        {
            _context.TDListGroup.Add(tDListGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTDListGroup", new { id = tDListGroup.Id }, tDListGroup);
        }

        // DELETE: api/TDListGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTDListGroup(int id)
        {
            var tDListGroup = await _context.TDListGroup.FindAsync(id);
            if (tDListGroup == null)
            {
                return NotFound();
            }

            _context.TDListGroup.Remove(tDListGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TDListGroupExists(int id)
        {
            return _context.TDListGroup.Any(e => e.Id == id);
        }
    }
}
