using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using FinalProjectMVC.Models;

namespace FinalProjectMVC.Data.Configurations
{
    public class ContactFormConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            // Define the table name
            builder.ToTable("Contacts");

            // Set the primary key
            builder.HasKey(c => c.Id);

            // Configure properties
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Subject)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.Message)
                .IsRequired()
                .HasMaxLength(1000);
        }
    }
}
