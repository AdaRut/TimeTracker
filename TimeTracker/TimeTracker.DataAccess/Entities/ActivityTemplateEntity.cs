using System.Collections.Generic;

namespace TimeTracker.DataAccess.Entities
{
    public class ActivityTemplateEntity : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public virtual CategoryEntity Category { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual List<ActivityEntity> Activities { get; set; }
       
    }
}
