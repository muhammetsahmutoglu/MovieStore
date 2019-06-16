using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.MapCore;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Map
{
   public class AppUserMap:CoreMap<AppUser>
    {

        public new void Configure(EntityTypeBuilder<AppUser> entity)
        {

            entity.Property(x => x.FirstName);
            entity.Property(x => x.LastName);
            entity.Property(x => x.UserName);
            entity.Property(x => x.Role);
            entity.Property(x => x.Password);

        }
    }
}
