using System;

namespace TimeTracker.DataAccess.Entities
{
    public class ActivityEntity : EntityBase
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int ActivityTemplateId { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual ActivityTemplateEntity ActivityTemplate {get; set;}
}
}


