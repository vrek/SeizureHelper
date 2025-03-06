using Microsoft.EntityFrameworkCore;
using SeizureHelperAPI.Models;

namespace SeizureHelperAPI.Contexts;

public interface IDbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Prescriptions> Prescriptions { get; set; }
    public DbSet<Dosage> Dosages { get; set; }
    public DbSet<AdministrationHistory> AdministrationHistories { get; set; }
    public DbSet<Seizures> Seizures { get; set; }
    public DbSet<CareGiver> CareGivers { get; set; }

    Task<int> SaveChangesAsync();
}