using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FinalProjectMVC.Areas.Identity.Data;
using FinalProjectMVC.Models;

namespace FinalProjectMVC.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(x => x.FullName).HasMaxLength(100);
            builder.Property(u => u.Email)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.Property(u => u.PasswordHash)
                   .IsRequired();

            builder.HasOne(au => au.DriverLicense)
              .WithOne()
              .HasForeignKey<DriverLicense>(dl => dl.Id) // Assuming DriverLicense.Id is used as FK
              .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
