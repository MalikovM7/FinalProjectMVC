using FinalProjectMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Brand)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Model)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Year)
                .IsRequired();

            builder.Property(c => c.Color)
                .HasMaxLength(30);

            builder.Property(c => c.LicensePlate)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.PricePerDay)
                .IsRequired()
                .HasColumnType("decimal(10,2)");

            builder.Property(c => c.IsAvailable)
                .IsRequired();

            builder.Property(c => c.ImagePath)
                .HasMaxLength(200);

            builder.Property(c => c.Location)
    .IsRequired() // Ensure Location is required
    .HasMaxLength(100); // Set maximum length for Location

            builder.Property(c => c.AvailabilityStart)
                .IsRequired(); // Ensure AvailabilityStart is required

            builder.Property(c => c.AvailabilityEnd)
                .IsRequired(); // Ensure AvailabilityEnd is required

            // Optional: Relationships (if necessary)
            // Example: One-to-Many with BlogPosts or FAQs
            builder.HasMany<BlogPost>()
                   .WithOne()
                   .HasForeignKey(bp => bp.CarId);
        }
    }

}
