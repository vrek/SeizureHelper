using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Dosage
{
    [Key]
    public Guid DosageId { get; set; }
    public Prescriptions Prescription { get; set; }
    public float DosageAmount { get; set; }
    public TimeOnly DosageTime { get; set; }
    
    //Navigation Property
    public List<AdministrationHistory> AdministrationHistory { get; set; }
    
}