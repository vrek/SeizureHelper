﻿using System.ComponentModel.DataAnnotations;

namespace SeizureHelperAPI.Models;

public class Patient
{
    [Key]
    public Guid PatientID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int MedicationListID { get; set; }
    public int SeizureListID { get; set; }
}
