using Microsoft.EntityFrameworkCore;
using TimeTracker.Configurations;
using TimeTracker.Entities;

namespace TimeTracker
{
    public class TimeTrackerDbContext: DbContext
    {
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityTemplate> ActivityTemplates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }

        public TimeTrackerDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Activity>(new ActivityConfiguration());
            modelBuilder.ApplyConfiguration<ActivityTemplate>(new ActivityTemplateConfiguration());
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<User>(new UserConfiguration());
        }
    }
}
