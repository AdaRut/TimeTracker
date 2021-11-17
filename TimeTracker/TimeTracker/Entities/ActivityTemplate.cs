using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Entities
{
    public class ActivityTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual User user { get; set; }
        public virtual List<Activity> Activities { get; set; }
       
    }
}
