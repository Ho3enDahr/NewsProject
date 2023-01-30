using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
    public class Category : BaseEntity<int>
    {
        public string Title { get; set; }
        public Category Parent { get; set; }
        public List<Category> Children { get; set; }
        public int?  ParentId { get; set; }
    }
}
