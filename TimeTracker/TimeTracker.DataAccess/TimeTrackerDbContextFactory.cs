using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TimeTracker
{
    public class TimeTrackerDbContextFactory : IDesignTimeDbContextFactory<TimeTrackerDbContext>
    {
        public TimeTrackerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TimeTrackerDbContext>();
            optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=TimeTrackerDb;MultipleActiveResultSets=true;Integrated Security=true");
            return new TimeTrackerDbContext(optionsBuilder.Options);
        }
    }
}
