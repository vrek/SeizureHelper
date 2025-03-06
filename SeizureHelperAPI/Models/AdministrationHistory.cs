using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeizureHelperAPI.Models;

public class AdministrationHistory
{
    [Key]
    public Guid AdministrationID { get; set; }
    public Dosage Dosage { get; set; }
    public DateTime DateTime { get; set; }
    
}