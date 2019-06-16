using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.MapCore;
using MovieStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Moviestore.Map
{
    public class CategoryMap:CoreMap<Category>
    {
        public new void Configure(EntityTypeBuilder<Category> entity)
        {

            entity.Property(x => x.CategoryName);
            entity.Property(x => x.CategoryDescription);
            entity.Property(x => x.Movies);
            
        }
    }
}
