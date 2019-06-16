using MovieStore.Core.EntityBase;
using MovieStore.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Entity
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
