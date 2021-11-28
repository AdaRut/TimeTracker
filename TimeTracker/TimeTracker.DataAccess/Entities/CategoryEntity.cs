using System.Collections.Generic;

namespace TimeTracker.DataAccess.Entities
{
    public class CategoryEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<ActivityTemplateEntity> ActivityTemplates { get; set; }

    }
}
