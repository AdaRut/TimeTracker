using System.Collections.Generic;

namespace TimeTracker.DataAccess.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public virtual List<ActivityTemplateEntity> ActivityTemplates { get; set; }
        public virtual List<ActivityEntity> Activities { get; set; }
    }
}
