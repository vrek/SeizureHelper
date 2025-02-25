using Microsoft.EntityFrameworkCore;

using SeizureHelperAPI.Models;

namespace SeizureHelperAPI.Contexts;

public class MySQLiteDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Prescriptions> Prescriptions { get; set; }
    public DbSet<Dosage> Dosages { get; set; }
    public DbSet<AdministrationHistory> AdministrationHistories { get; set; }
    public DbSet<Seizures> SeizureEvents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=localDatabase.db");
    }
}
