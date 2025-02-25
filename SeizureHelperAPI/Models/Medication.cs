using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Medication
{
    [Key]
    public required Guid MedicationId { get; set; }
    public required string MedicationName { get; set; }
    public string? MedicationGenericName { get; set; }
}
