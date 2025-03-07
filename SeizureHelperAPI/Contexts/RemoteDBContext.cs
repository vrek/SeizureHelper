﻿using Microsoft.EntityFrameworkCore;
using SeizureHelperAPI.Contexts;
using SeizureHelperAPI.Models;

public class RemoteDbContext : DbContext, IDbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medication> Medications { get; set; }
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
        optionsBuilder.UseSqlServer("Server=127.0.0.1; Database=MyDatabase; Integrated Security=true");
    }
}