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
    public class SListGroupsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public SListGroupsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/SListGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SListGroup>>> GetSListGroup()
        {
            return await _context.SListGroup.ToListAsync();
        }

        // GET: api/SListGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SListGroup>> GetSListGroup(int id)
        {
            var sListGroup = await _context.SListGroup.FindAsync(id);

            if (sListGroup == null)
            {
                return NotFound();
            }

            return sListGroup;
        }

        // PUT: api/SListGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSListGroup(int id, SListGroup sListGroup)
        {
            if (id != sListGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(sListGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SListGroupExists(id))
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

        // POST: api/SListGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SListGroup>> PostSListGroup(SListGroup sListGroup)
        {
            _context.SListGroup.Add(sListGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSListGroup", new { id = sListGroup.Id }, sListGroup);
        }

        // DELETE: api/SListGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSListGroup(int id)
        {
            var sListGroup = await _context.SListGroup.FindAsync(id);
            if (sListGroup == null)
            {
                return NotFound();
            }

            _context.SListGroup.Remove(sListGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SListGroupExists(int id)
        {
            return _context.SListGroup.Any(e => e.Id == id);
        }
    }
}
