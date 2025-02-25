using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Dosage
{
    [Key]
    public Guid DosageId { get; set; }
    public Guid PrescriptionID { get; set; }
    public float DosageAmount { get; set; }
    public TimeOnly DosageTime { get; set; }
}