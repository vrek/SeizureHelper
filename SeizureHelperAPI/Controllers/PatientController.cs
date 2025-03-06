using Microsoft.AspNetCore.Mvc;
using SeizureHelperAPI.Contexts;
using SeizureHelperAPI.Models;

namespace SeizureHelperAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
    private readonly IDbContext _context;

    public PatientController(IDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<Patient>> Patient([FromBody] Patient patient)
    {
        _context.Patients.Add(patient);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(Patient), new {id = patient.PatientID}, patient);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> GetPatientById(Guid id)
    {
        Patient _patient = await _context.Patients.FindAsync(id);
        if (_patient == null)
        {
            return NotFound();
        }
        return _patient;
    }
    
}