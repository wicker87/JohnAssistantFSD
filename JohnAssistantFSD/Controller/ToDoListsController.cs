﻿using System;
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
    public class ToDoListsController : ControllerBase
    {
        private readonly JohnAssistantFSDContext _context;

        public ToDoListsController(JohnAssistantFSDContext context)
        {
            _context = context;
        }

        // GET: api/ToDoLists
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ToDoList>>> GetToDoList()
        {
            return await _context.ToDoList.ToListAsync();
        }

        // GET: api/ToDoLists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ToDoList>> GetToDoList(int id)
        {
            var toDoList = await _context.ToDoList.FindAsync(id);

            if (toDoList == null)
            {
                return NotFound();
            }

            return toDoList;
        }

        // PUT: api/ToDoLists/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutToDoList(int id, ToDoList toDoList)
        {
            if (id != toDoList.Id)
            {
                return BadRequest();
            }

            _context.Entry(toDoList).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToDoListExists(id))
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

        // POST: api/ToDoLists
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ToDoList>> PostToDoList(ToDoList toDoList)
        {
            _context.ToDoList.Add(toDoList);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetToDoList", new { id = toDoList.Id }, toDoList);
        }

        // DELETE: api/ToDoLists/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteToDoList(int id)
        {
            var toDoList = await _context.ToDoList.FindAsync(id);
            if (toDoList == null)
            {
                return NotFound();
            }

            _context.ToDoList.Remove(toDoList);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ToDoListExists(int id)
        {
            return _context.ToDoList.Any(e => e.Id == id);
        }
    }
}
