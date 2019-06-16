using MovieStore.Core.EntityBase;
using MovieStore.Core.Enum;

using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Entity
{
    public class Movie:BaseEntity
    {
        public string MovieName { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
