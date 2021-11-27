using System.Collections.Generic;

namespace TimeTracker.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<ActivityTemplate> ActivityTemplates { get; set; }

    }
}
