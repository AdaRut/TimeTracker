﻿using System.Collections.Generic;

namespace TimeTracker.DataAccess.Entities
{
    public class ActivityTemplate : EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual List<Activity> Activities { get; set; }
       
    }
}