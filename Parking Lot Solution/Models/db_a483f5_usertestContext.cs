﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Parking_Lot_Solution.Models
{
    public partial class db_a483f5_usertestContext : DbContext
    {
        public db_a483f5_usertestContext()
        {
        }

        public db_a483f5_usertestContext(DbContextOptions<db_a483f5_usertestContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<PackingRule> PackingRules { get; set; } = null!;
        public virtual DbSet<PackingTicket> PackingTickets { get; set; }
        public virtual DbSet<ParkingRule> ParkingRules { get; set; }
        public virtual DbSet<ParkingTicket> ParkingTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SQL5091.site4now.net;Database=db_a483f5_usertest;User Id=db_a483f5_usertest_admin;Password=userTester.1;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PackingRule>(entity =>
            //{
            //    entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

            //    entity.Property(e => e.RuleDescription).HasMaxLength(50);
            //});

            modelBuilder.Entity<PackingTicket>(entity =>
            {
                entity.Property(e => e.AmountToPay).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EntryTime).HasMaxLength(50);

                entity.Property(e => e.ExitTime).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
