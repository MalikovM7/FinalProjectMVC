using FinalProjectMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Configurations
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasKey(bp => bp.Id);

            builder.Property(bp => bp.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(bp => bp.Content)
                .IsRequired();

            builder.Property(bp => bp.CreatedAt)
                .IsRequired();

            // Foreign key relationship with Car
            builder.HasOne(bp => bp.Car)
                .WithMany()
                .HasForeignKey(bp => bp.CarId)
                .OnDelete(DeleteBehavior.Cascade); // Optional: defines delete behavior
        }
    }
}
