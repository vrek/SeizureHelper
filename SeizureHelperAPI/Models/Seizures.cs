using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeizureHelperAPI.Models;

public class Seizures
{
    [Key]
    public Guid SeizureEventID { get; set; }

    public required DateTime SeizureDateTime { get; set; }
    public required int SeizureSeverity { get; set; }
    public required float SeizueDurationMinutes { get; set; }
    public string? SeizureComments { get; set; }
    
    //Navigations Properties
    public Patient patient { get; set; }

}
