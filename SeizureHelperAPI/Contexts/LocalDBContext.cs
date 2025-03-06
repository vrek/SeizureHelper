using Microsoft.EntityFrameworkCore;

using SeizureHelperAPI.Models;


namespace SeizureHelperAPI.Contexts;

public class LocalDbContext : DbContext, IDbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Medication> MedicationList { get; set; }
    public DbSet<Prescriptions> Prescriptions { get; set; }
    public DbSet<Dosage> Dosages { get; set; }
    public DbSet<AdministrationHistory> AdministrationHistories { get; set; }
    public DbSet<Seizures> Seizures { get; set; }
    public DbSet<CareGiver> CareGivers { get; set; }

    public Task<int> SaveChangesAsync()
    {
        return base.SaveChangesAsync();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    {
        optionsBuilder.UseSqlite("Data Source=localDatabase.db");
    }
}
