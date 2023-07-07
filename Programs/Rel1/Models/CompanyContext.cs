﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Rel1.Models;

public partial class CompanyContext : DbContext
{
    public CompanyContext()
    {
    }

    public CompanyContext(DbContextOptions<CompanyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Dept> Depts { get; set; }

    public virtual DbSet<Emp> Emps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Dept>(entity =>
        {
            entity.HasKey(e => e.Deptno).HasName("PK__Dept__BE2C337DEFE96CB7");

            entity.ToTable("Dept");

            entity.Property(e => e.Deptno)
                .ValueGeneratedNever()
                .HasColumnName("deptno");
            entity.Property(e => e.Deptname)
                .HasMaxLength(20)
                .HasColumnName("deptname");
        });

        modelBuilder.Entity<Emp>(entity =>
        {
            entity.HasKey(e => e.Empid).HasName("PK__Emp__AF4CE86597594D70");

            entity.ToTable("Emp");

            entity.Property(e => e.Empid)
                .ValueGeneratedNever()
                .HasColumnName("empid");
            entity.Property(e => e.Deptno).HasColumnName("deptno");
            entity.Property(e => e.Ename)
                .HasMaxLength(30)
                .HasColumnName("ename");

            entity.HasOne(d => d.DeptnoNavigation).WithMany(p => p.Emps)
                .HasForeignKey(d => d.Deptno)
                .HasConstraintName("FK__Emp__deptno__5FB337D6");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
