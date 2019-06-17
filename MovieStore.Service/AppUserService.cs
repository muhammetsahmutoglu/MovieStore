using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Service
{
    public class AppUserService : ServiceBase.BaseService<AppUser>
    {
        public bool CheckCredentials(string userName, string password)
        {
            return Any(x => x.UserName == userName && x.Password == password);
        }

        public AppUser FindByUserName(string userName)
        {
            return GetByDefault(x => x.UserName == userName);
        }
    }
}
