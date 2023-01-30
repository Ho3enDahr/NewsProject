using NewsProject.Domain.Contracts.SearchContext;
using NewsProject.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Contracts.Contracts
{
   public interface IKeywordRepository
    {
        void Add(Keyword keyword);
        void Update(Keyword keyword);
        void Delete(int id);
        SearchResult<Keyword> Search(KeywordSearchContext context);
    }
}
