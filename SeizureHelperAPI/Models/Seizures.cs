using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Seizures
{
    [Key]
    public Guid SeizureEventID { get; set; }
    public required int PatientID { get; set; }
    public required DateTime SeizureDateTime { get; set; }
    public required int SeizureSeverity { get; set; }
    public required float SeizueDurationMinutes { get; set; }
    public string? SeizureComments { get; set; }

}
