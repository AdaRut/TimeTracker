using Microsoft.EntityFrameworkCore;
using TimeTracker.DataAccess.Configurations;
using TimeTracker.DataAccess.Entities;

namespace TimeTracker.DataAccess
{
    public class TimeTrackerDbContext: DbContext
    {
        public DbSet<ActivityEntity> Activities { get; set; }
        public DbSet<ActivityTemplateEntity> ActivityTemplates { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        public TimeTrackerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<ActivityEntity>(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration<ActivityTemplateEntity>(new ActivityTemplateConfiguration());
            modelBuilder.ApplyConfiguration<CategoryEntity>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<UserEntity>(new UserConfiguration());
        }
    }
}
