using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Prescriptions
{
    [Key]
    public Guid PrescriptionId { get; set; }
    public Guid PatientId { get; set; }
    public Guid MedicineId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}