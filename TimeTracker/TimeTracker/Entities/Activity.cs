using System;

namespace TimeTracker.Entities
{
    public class Activity : EntityBase
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int ActivityTemplateId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ActivityTemplate ActivityTemplate {get; set;}
}
}


