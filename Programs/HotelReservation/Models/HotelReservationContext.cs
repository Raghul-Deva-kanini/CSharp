using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Models;

public partial class HotelReservationContext : DbContext
{
    public HotelReservationContext()
    {
    }

    public HotelReservationContext(DbContextOptions<HotelReservationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Booking> Bookings { get; set; }

    public virtual DbSet<RoomDetail> RoomDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source = .\\SQLEXPRESS; initial catalog = HotelReservation; integrated security=SSPI;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Booking>(entity =>
        {
            entity.HasKey(e => e.BookingId).HasName("PK__Bookings__73951ACD0ECAA107");

            entity.Property(e => e.BookingId)
                .ValueGeneratedNever()
                .HasColumnName("BookingID");
            entity.Property(e => e.CustomerName).HasMaxLength(255);

            entity.HasOne(d => d.RoomNumberNavigation).WithMany(p => p.Bookings)
                .HasForeignKey(d => d.RoomNumber)
                .HasConstraintName("FK__Bookings__RoomNu__619B8048");
        });

        modelBuilder.Entity<RoomDetail>(entity =>
        {
            entity.HasKey(e => e.RoomNumber).HasName("PK__RoomDeta__AE10E07B72BB8808");

            entity.Property(e => e.RoomNumber).ValueGeneratedNever();
            entity.Property(e => e.RoomType).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
