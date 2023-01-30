using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewsProject.Domain.Contracts.SearchContext
{
   public class SearchResult<T> where T:new()
    {
        public SearchResult()
        {
            Result = new List<T>();
        }
        public List<T> Result { get; set; }
        public int TotalCount  { get; set; }
        public bool HasValue => Result.Any();
    }
}
