namespace SeizureHelperAPI.Models;

public class AdministrationHistory
{
    public Guid AdministrationID { get; set; }
    public Guid DosageID { get; set; }
    public DateTime DateTime { get; set; }
    
}