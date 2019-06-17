using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStore.Core.Interface
{
    public interface ICoreEntity
    {
         int ID { get; set; }
         DateTime AddDate { get; set; }
         DateTime UpdateDate { get; set; }
         DateTime DeleteDate { get; set; }
    }
}
