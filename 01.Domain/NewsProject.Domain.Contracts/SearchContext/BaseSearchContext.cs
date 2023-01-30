using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Contracts.SearchContext
{
   public class BaseSearchContext
    {
        public int PageSize { get; set; }
        public int PageCount { get; set; }
    }
}
