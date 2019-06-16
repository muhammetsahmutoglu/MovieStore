
using MovieStore.Core.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Entity
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }

        public virtual List<Movie> Movies { get; set; }
    }
}
