using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TimeTracker.DataAccess.Entities;

namespace TimeTracker.DataAccess.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<ActivityEntity>
    {
        public void Configure(EntityTypeBuilder<ActivityEntity> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.DateFrom)
                .IsRequired();
            builder.Property(r => r.DateTo)
                .IsRequired();
            builder.Property(r => r.ModifiedBy)
               .IsRequired(false);
            builder.Property(r => r.CreatedBy)
                .IsRequired();
            builder.Property(r => r.ActivityTemplateId)
                .IsRequired();
            builder.Property(r => r.IsDeleted)
                .IsRequired();
            builder.Property(r => r.UserId)
                .IsRequired();
            builder.Property(r => r.CreationDate)
                .IsRequired();
            builder.Property(r => r.ModificationDate)
                .IsRequired(false);
        }
    }
}
