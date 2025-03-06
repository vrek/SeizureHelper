using System.ComponentModel.DataAnnotations;


namespace SeizureHelperAPI.Models;

public class Prescriptions
{
    [Key]
    public Guid PrescriptionId { get; set; }



    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    
    //Navigation
    public Patient Patient { get; set; }

    public Medication Medicine { get; set; }
    
    public List<AdministrationHistory> AdministrationHistory { get; set; }
    
    public List<Dosage> Dosage { get; set; }
    
}