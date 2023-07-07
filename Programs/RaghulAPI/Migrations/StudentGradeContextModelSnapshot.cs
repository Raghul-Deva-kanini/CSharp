﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RaghulAPI.Models;

#nullable disable

namespace RaghulAPI.Migrations
{
    [DbContext(typeof(StudentGradeContext))]
    partial class StudentGradeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RaghulAPI.Models.Grade", b =>
                {
                    b.Property<int>("gradeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("gradeid"));

                    b.Property<string>("gradename")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gradeid");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("RaghulAPI.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<string>("Studname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gradeid")
                        .HasColumnType("int");

                    b.HasKey("StudentID");

                    b.HasIndex("gradeid");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("RaghulAPI.Models.Student", b =>
                {
                    b.HasOne("RaghulAPI.Models.Grade", "grade")
                        .WithMany()
                        .HasForeignKey("gradeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("grade");
                });
#pragma warning restore 612, 618
        }
    }
}
