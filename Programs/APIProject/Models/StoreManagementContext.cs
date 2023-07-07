using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Models;

public partial class StoreManagementContext : DbContext
{
    public StoreManagementContext()
    {
    }

    public StoreManagementContext(DbContextOptions<StoreManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerProd> CustomerProds { get; set; }

    public virtual DbSet<ProductDatum> ProductData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = StoreManagement; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__CD65CB8577DB22D1");

            entity.ToTable("Customer");

            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(30)
                .HasColumnName("customer_name");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .HasColumnName("email");
            entity.Property(e => e.Phone).HasColumnName("phone");
        });

        modelBuilder.Entity<CustomerProd>(entity =>
        {
            entity.HasKey(e => e.ItemNo).HasName("PK__Customer__727D9FE4D53DB4B6");

            entity.ToTable("CustomerProd");

            entity.Property(e => e.ItemNo).ValueGeneratedNever();
            entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .HasColumnName("product_id");
            entity.Property(e => e.ProductQuantity).HasColumnName("productQuantity");
            entity.Property(e => e.TotalCost)
                .HasColumnType("money")
                .HasColumnName("total_cost");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerProds)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerP__custo__72C60C4A");

            entity.HasOne(d => d.Product).WithMany(p => p.CustomerProds)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CustomerP__produ__73BA3083");
        });

        modelBuilder.Entity<ProductDatum>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__ProductD__47027DF539C9C045");

            entity.Property(e => e.ProductId)
                .HasMaxLength(10)
                .HasColumnName("product_id");
            entity.Property(e => e.Cost)
                .HasColumnType("money")
                .HasColumnName("cost");
            entity.Property(e => e.ProductName)
                .HasMaxLength(20)
                .HasColumnName("product_name");
            entity.Property(e => e.QuantityAvailable).HasColumnName("quantity_available");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
