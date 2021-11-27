using System;

namespace TimeTracker.DataAccess.Entities
{
    public class EntityBase
    {
        public bool IsDeleted { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
