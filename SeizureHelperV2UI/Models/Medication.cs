namespace SeizureHelperV2UI.Models;

internal class Medication
{
    public required string Name { get; set; }
    public float Dosage { get; set; }
    public required string DosageUnits { get; set; }
    public TimeOnly Dose1 { get; set; }
    public TimeOnly Dose2 { get; set; }
    public TimeOnly Dose3 { get; set; }
    public bool UpToDate { get; set; }

}
