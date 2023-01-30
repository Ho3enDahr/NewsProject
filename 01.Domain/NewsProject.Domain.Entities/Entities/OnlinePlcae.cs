using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
   public class OnlinePlcae:BaseEntity<int>
    {
        public string Title { get; set; }
        public int Count { get; set; }
    }
}
