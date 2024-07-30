using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Melodie.API.Data.Entities;

namespace Melodie.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TempEntitiesController : ControllerBase
{
    private readonly MelodieAPIContext _context;

    public TempEntitiesController(MelodieAPIContext context)
    {
        _context = context;
    }

    // GET: api/TempEntities
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TempEntity>>> GetTempEntity()
    {
        return await _context.TempEntity.ToListAsync();
    }

    // GET: api/TempEntities/5
    [HttpGet("{id}")]
    public async Task<ActionResult<TempEntity>> GetTempEntity(Guid id)
    {
        var tempEntity = await _context.TempEntity.FindAsync(id);

        if (tempEntity == null)
        {
            return NotFound();
        }

        return tempEntity;
    }

    // PUT: api/TempEntities/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTempEntity(Guid id, TempEntity tempEntity)
    {
        if (id != tempEntity.Id)
        {
            return BadRequest();
        }

        _context.Entry(tempEntity).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TempEntityExists(id))
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

    // POST: api/TempEntities
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<TempEntity>> PostTempEntity(TempEntity tempEntity)
    {
        _context.TempEntity.Add(tempEntity);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTempEntity", new { id = tempEntity.Id }, tempEntity);
    }

    // DELETE: api/TempEntities/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTempEntity(Guid id)
    {
        var tempEntity = await _context.TempEntity.FindAsync(id);
        if (tempEntity == null)
        {
            return NotFound();
        }

        _context.TempEntity.Remove(tempEntity);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TempEntityExists(Guid id)
    {
        return _context.TempEntity.Any(e => e.Id == id);
    }
}
