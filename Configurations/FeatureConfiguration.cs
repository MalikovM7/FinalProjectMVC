using FinalProjectMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectMVC.Configurations
{
    public class FeatureConfiguration : IEntityTypeConfiguration<Feature>
    {
        public void Configure(EntityTypeBuilder<Feature> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(f => f.Title).IsRequired().HasMaxLength(100);
            builder.Property(f => f.IconClass).HasMaxLength(100);
        }
    }
}
