using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class AdministrationHistory
{
    [Key]
    public Guid AdministrationID { get; set; }
    public Guid DosageID { get; set; }
    public DateTime DateTime { get; set; }
    
}