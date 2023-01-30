using NewsProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
   public class Content:BaseEntity<int>
    {
        public EnumContentType   ContentType { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public DateTime? PublishDate { get; set; }
        public int NFileId { get; set; }
        public NFile DefaultImage { get; set; }
        public int CategoryId { get; set; }
        public Category DefaultCategory { get; set; }

        public List<NFile> RelatedFiles { get; set; }
        public List<Category> RelatedCategories { get; set; }
        public List<Keyword> Keywords { get; set; }
        public int? ParentId { get; set; }
        public List<Content> RelatedContents { get; set; }
        public List<OnlinePlcae> OnlinePlcaes { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
