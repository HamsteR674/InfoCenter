﻿using Microsoft.EntityFrameworkCore;
using InteractionDb.ModelTables;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;




namespace InteractionDb

{
    
    public class ApplicationContext : DbContext
    {
      
        DbSet<Employees> Employees { get; set; }
        DbSet<SessionLog> SessionLog { get; set; }
        DbSet<Divisions> Divisions { get; set; }
        DbSet<Settings> Settings { get; set; }
        DbSet<CustomStandEmployees> CustomStandEmployees { get; set; }
        DbSet<CustomStandInfo> CustomStandInfos { get; set; }
        DbSet<CustomStandRights> CustomStandRights { get; set; }
        DbSet<SystemInfo> SystemInfo { get; set; }
        DbSet <SystemStateInfo> SystemStateInfo { get; set; }
        DbSet<TakenTasks> TakenTasks { get; set; }
        DbSet<PendingTasks> PendingTasks { get; set; }
        DbSet<MirrorParameters> MirrorParameters { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Divisions>()
                .HasOne(a => a.Chef)
                .WithMany(b => b.ChefDivisions)
                .HasForeignKey(b => b.ChiefId);

            modelBuilder.Entity<Employees>()
                .HasOne(a => a.Divisions)
                .WithMany(b => b.Employees)
                .HasForeignKey(b => b.DivisionId);
        }



       public ApplicationContext(DbContextOptions<ApplicationContext> options)
        : base(options)
    {
        Database.EnsureCreated();   // создаем базу данных при первом обращении
    }

    }
   
}
