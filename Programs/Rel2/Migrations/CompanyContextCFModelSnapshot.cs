﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rel2.models;

#nullable disable

namespace Rel2.Migrations
{
    [DbContext(typeof(CompanyContextCF))]
    partial class CompanyContextCFModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Rel2.models.Dept", b =>
                {
                    b.Property<int>("Deptno")
                        .HasColumnType("int");

                    b.Property<string>("Deptname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Deptno");

                    b.ToTable("Depts");
                });

            modelBuilder.Entity("Rel2.models.Emp", b =>
                {
                    b.Property<int>("Empno")
                        .HasColumnType("int");

                    b.Property<int?>("Deptno")
                        .HasColumnType("int");

                    b.Property<int?>("DeptnoRefDeptno")
                        .HasColumnType("int");

                    b.Property<string>("Empname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Empno");

                    b.HasIndex("DeptnoRefDeptno");

                    b.ToTable("Emp");
                });

            modelBuilder.Entity("Rel2.models.EmpDetails", b =>
                {
                    b.Property<int>("empno")
                        .HasColumnType("int");

                    b.Property<long>("aadharno")
                        .HasColumnType("bigint");

                    b.Property<string>("panno")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("empno");

                    b.ToTable("EmpDetails_1");
                });

            modelBuilder.Entity("Rel2.models.Emp", b =>
                {
                    b.HasOne("Rel2.models.Dept", "DeptnoRef")
                        .WithMany("Emps")
                        .HasForeignKey("DeptnoRefDeptno");

                    b.Navigation("DeptnoRef");
                });

            modelBuilder.Entity("Rel2.models.Dept", b =>
                {
                    b.Navigation("Emps");
                });
#pragma warning restore 612, 618
        }
    }
}
