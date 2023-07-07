﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SampOnetoManyAPI.Models;

#nullable disable

namespace SampOnetoManyAPI.Migrations
{
    [DbContext(typeof(ProCatContext))]
    [Migration("20230525141741_sample")]
    partial class sample
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SampOnetoManyAPI.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatId"));

                    b.Property<string>("CatName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CatId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.Product", b =>
                {
                    b.Property<int>("ProId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProId"));

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("categoryCatId")
                        .HasColumnType("int");

                    b.HasKey("ProId");

                    b.HasIndex("categoryCatId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.Product", b =>
                {
                    b.HasOne("SampOnetoManyAPI.Models.Category", "category")
                        .WithMany("Products")
                        .HasForeignKey("categoryCatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("category");
                });

            modelBuilder.Entity("SampOnetoManyAPI.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
