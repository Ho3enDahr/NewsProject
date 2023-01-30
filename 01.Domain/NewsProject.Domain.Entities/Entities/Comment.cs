using NewsProject.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsProject.Domain.Entities.Entities
{
   public class Comment:BaseEntity<int>
    {
        public Content Content { get; set; }
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Message  { get; set; }
        public EnumCommentStatus CommentStatus { get; set; }
        public int? ParentCommentId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string IP { get; set; }
        public List<Comment> Children { get; set; }
        public Comment Parent { get; set; }
    }
}
