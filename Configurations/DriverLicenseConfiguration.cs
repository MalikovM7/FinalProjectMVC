using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinalProjectMVC.Models;

namespace FinalProjectMVC.Data.Configurations
{
    public class DriverLicenseConfiguration : IEntityTypeConfiguration<DriverLicense>
    {
        public void Configure(EntityTypeBuilder<DriverLicense> builder)
        {
            builder.ToTable("DriverLicenses");

            // Set the primary key
            builder.HasKey(dl => dl.Id);

            // Configure the foreign key
            builder.HasOne(dl => dl.AppUser)
                .WithOne(au => au.DriverLicense)
                .HasForeignKey<DriverLicense>(dl => dl.AppUserId);

            // Configure properties
            builder.Property(dl => dl.LicenseNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(dl => dl.ImagePath)
                .HasMaxLength(255);
        }
    }
}