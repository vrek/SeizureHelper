using Microsoft.AspNetCore.Mvc;
using SeizureHelperAPI.Contexts;
using SeizureHelperAPI.Models;

namespace SeizureHelperAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SeizureController : ControllerBase
{
    
    private readonly IDbContext _context;

    public SeizureController(IDbContext context)
    {
        _context = context;
    }

    // POST: api/SeizureEvents
    [HttpPost]
    public async Task<ActionResult<Seizures>> PostSeizureEvent([FromBody] Seizures seizureEvent)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _context.Seizures.Add(seizureEvent);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSeizureEvent), new { id = seizureEvent.SeizureEventID }, seizureEvent);
    }
// GET: api/SeizureEvents/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Seizures>> GetSeizureEvent(Guid id)
    {
        var _seizureEvent = await _context.Seizures.FindAsync(id);

        if (_seizureEvent == null)
        {
            return NotFound();
        }

        return _seizureEvent;
    }
}
