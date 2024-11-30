using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinalProjectMVC.Models;

namespace FinalProjectMVC.Data.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");

            // Set the primary key
            builder.HasKey(r => r.Id);

            // Configure the foreign key for AppUser
            builder.HasOne(r => r.AppUser)
                .WithMany(au => au.Reservations)
                .HasForeignKey(r => r.UserId);

            // Configure the foreign key for Car
            builder.HasOne(r => r.Car)
                .WithMany()
                .HasForeignKey(r => r.CarId);

            // Configure properties
            builder.Property(r => r.StartDate)
                .IsRequired();

            builder.Property(r => r.EndDate)
                .IsRequired();

            builder.Property(r => r.TotalPrice)
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.Status)
                .HasMaxLength(50);
        }
    }
}