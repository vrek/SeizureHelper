namespace SeizureHelperAPI.Models;

public class Prescriptions
{
    public Guid PrescriptionId { get; set; }
    public Guid PatientId { get; set; }
    public Guid MedicineId { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
}