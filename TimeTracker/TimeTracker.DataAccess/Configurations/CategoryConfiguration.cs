using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.DataAccess.Entities;

namespace TimeTracker.DataAccess.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasMany(r => r.ActivityTemplates)
                .WithOne(r => r.Category)
                .HasForeignKey(r => r.CategoryId);
        }
    }
}
