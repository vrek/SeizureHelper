namespace SeizureHelperAPI.Models;

public class Medication
{
    public required Guid MedicationId { get; set; }
    public required string MedicationName { get; set; }
    public string? MedicationGenericName { get; set; }
}
