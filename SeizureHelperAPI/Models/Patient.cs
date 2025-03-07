﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SeizureHelperAPI.Models;

public class Patient
{
    [Key]
    public Guid PatientID { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    

   

    
    //Navigation Properties
    public List<Seizures> Seizures { get; set; }
    
    public List<Prescriptions> Prescriptions { get; set; }
    
    public List<CareGiver> CareGivers { get; set; }

    
}
