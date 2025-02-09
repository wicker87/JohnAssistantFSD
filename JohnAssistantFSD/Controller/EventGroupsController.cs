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
    public class EventGroupsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public EventGroupsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/EventGroups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventGroup>>> GetEventGroup()
        {
            return await _context.EventGroup.ToListAsync();
        }

        // GET: api/EventGroups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventGroup>> GetEventGroup(int id)
        {
            var eventGroup = await _context.EventGroup.FindAsync(id);

            if (eventGroup == null)
            {
                return NotFound();
            }

            return eventGroup;
        }

        // PUT: api/EventGroups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEventGroup(int id, EventGroup eventGroup)
        {
            if (id != eventGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(eventGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventGroupExists(id))
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

        // POST: api/EventGroups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EventGroup>> PostEventGroup(EventGroup eventGroup)
        {
            _context.EventGroup.Add(eventGroup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEventGroup", new { id = eventGroup.Id }, eventGroup);
        }

        // DELETE: api/EventGroups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEventGroup(int id)
        {
            var eventGroup = await _context.EventGroup.FindAsync(id);
            if (eventGroup == null)
            {
                return NotFound();
            }

            _context.EventGroup.Remove(eventGroup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EventGroupExists(int id)
        {
            return _context.EventGroup.Any(e => e.Id == id);
        }
    }
}
