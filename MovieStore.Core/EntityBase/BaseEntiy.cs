using MovieStore.Core.Enum;
using MovieStore.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.EntityBase
{
    public class BaseEntity : ICoreEntity
    {
        public int ID { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeleteDate { get; set; }
        public Status Status { get; set; }
    }
}
