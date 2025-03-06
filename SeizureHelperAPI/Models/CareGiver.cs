using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeizureHelperAPI.Models;

public class CareGiver
{
    [Key]
    public Guid CareGiverID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    [Required]
    [MaxLength(100)]
    public string Email {get; set;}

    
    public List<Guid> PatientID { get; set; }
    
}