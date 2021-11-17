using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int ActivityTemplateId { get; set; }
        public virtual User user { get; set; }
        public virtual ActivityTemplate ActivityTemplate {get; set;}
}
}


