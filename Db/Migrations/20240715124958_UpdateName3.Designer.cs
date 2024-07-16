﻿// <auto-generated />
using System;
using InteractionDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace InteractionDb.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240715124958_UpdateName3")]
    partial class UpdateName3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandEmployees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<int>("InfoCentreId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("InfoCentreId");

                    b.ToTable("CustomStandEmployees");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatorIdId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorIdId");

                    b.ToTable("CustomStandInfos");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandRights", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeesI")
                        .HasColumnType("integer");

                    b.Property<int>("InfoCenterIdId")
                        .HasColumnType("integer");

                    b.Property<string>("Rights")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InfoCenterIdId");

                    b.ToTable("CustomStandRights");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Divisions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("ChiefId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("ParentDivCode")
                        .HasColumnType("integer");

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ChiefId");

                    b.HasIndex("ParentId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long?>("DivisionId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsFired")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.MirrorParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset>("InfoCenterUpdateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTimeOffset>("UpdateTimestam")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("MirrorParameters");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.PendingTasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceCallId")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceCallTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdateTimeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("UpdateTimeId");

                    b.ToTable("PandingTasks");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SessionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<string>("ErrorList")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("SessionLog");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<string>("JsonSettings")
                        .IsRequired()
                        .HasColumnType("json");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SystemInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SystemInfo");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SystemStateInfo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTimeOffset>("CheckDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ErrorLis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Result")
                        .HasColumnType("boolean");

                    b.Property<long>("SystemInfoId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("CheckDateTime");

                    b.HasIndex("SystemInfoId");

                    b.ToTable("SystemStateInfo");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.TakenTasks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmployeesId")
                        .HasColumnType("integer");

                    b.Property<DateTimeOffset>("ExpirationData")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsProjectTask")
                        .HasColumnType("boolean");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServiceCallId")
                        .HasColumnType("integer");

                    b.Property<string>("ServiceComponent")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UpdateTimeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("UpdateTimeId");

                    b.ToTable("TakenTasks");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandEmployees", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Employees")
                        .WithMany("CustomStandEmployees")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractionDb.ModelTables.CustomStandInfo", "InfoCentre")
                        .WithMany("CustomStandEmployees")
                        .HasForeignKey("InfoCentreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("InfoCentre");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandInfo", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "CreatorId")
                        .WithMany()
                        .HasForeignKey("CreatorIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatorId");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandRights", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.CustomStandInfo", "InfoCenterId")
                        .WithMany("CustomStandRights")
                        .HasForeignKey("InfoCenterIdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InfoCenterId");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Divisions", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Chef")
                        .WithMany("ChefDivisions")
                        .HasForeignKey("ChiefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractionDb.ModelTables.Divisions", "Parent")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");

                    b.Navigation("Chef");

                    b.Navigation("Parent");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Employees", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Divisions", "Divisions")
                        .WithMany("Employees")
                        .HasForeignKey("DivisionId");

                    b.Navigation("Divisions");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.PendingTasks", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Employees")
                        .WithMany("PandingTasks")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractionDb.ModelTables.MirrorParameters", "UpdateTime")
                        .WithMany("PandingTasks")
                        .HasForeignKey("UpdateTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("UpdateTime");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SessionLog", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Employees")
                        .WithMany("Logs")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Settings", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Employees")
                        .WithMany("Settings")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SystemStateInfo", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.SystemInfo", "SystemInfo")
                        .WithMany("StateInfos")
                        .HasForeignKey("SystemInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SystemInfo");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.TakenTasks", b =>
                {
                    b.HasOne("InteractionDb.ModelTables.Employees", "Employees")
                        .WithMany("TakenTasks")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InteractionDb.ModelTables.MirrorParameters", "UpdateTime")
                        .WithMany("TakenTasks")
                        .HasForeignKey("UpdateTimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("UpdateTime");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.CustomStandInfo", b =>
                {
                    b.Navigation("CustomStandEmployees");

                    b.Navigation("CustomStandRights");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Divisions", b =>
                {
                    b.Navigation("Children");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.Employees", b =>
                {
                    b.Navigation("ChefDivisions");

                    b.Navigation("CustomStandEmployees");

                    b.Navigation("Logs");

                    b.Navigation("PandingTasks");

                    b.Navigation("Settings");

                    b.Navigation("TakenTasks");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.MirrorParameters", b =>
                {
                    b.Navigation("PandingTasks");

                    b.Navigation("TakenTasks");
                });

            modelBuilder.Entity("InteractionDb.ModelTables.SystemInfo", b =>
                {
                    b.Navigation("StateInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
