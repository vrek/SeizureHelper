using Microsoft.EntityFrameworkCore;
using SeizureHelperAPI.Models;

public class MySQLServerDbContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medication> Medications { get; set; }
    public DbSet<Prescriptions> Prescriptions { get; set; }
    public DbSet<Dosage> Dosages { get; set; }
    public DbSet<AdministrationHistory> AdministrationHistories { get; set; }
    public DbSet<Seizures> SeizureEvents { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=127.0.0.1; Database=MyDatabase; Integrated Security=true");
    }
}