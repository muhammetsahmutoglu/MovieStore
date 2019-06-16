using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MovieStore.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.MapCore
{
    public class CoreMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {

        public void Configure(EntityTypeBuilder<T> entity)
        {
            entity.HasKey(x => x.ID);
            entity.Property(x => x.AddDate);
            entity.Property(x => x.DeleteDate);
            entity.Property(x => x.UpdateDate);
            entity.Property(x => x.Status);

        }

            
    }
}
