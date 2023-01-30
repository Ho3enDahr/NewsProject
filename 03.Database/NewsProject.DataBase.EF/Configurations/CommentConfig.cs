using NewsProject.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace NewsProject.DataBase.EF.Configurations
{
   public class CommentConfig:EntityTypeConfiguration<Comment>
    {
        public CommentConfig()
        {
            Property(c => c.IP).HasMaxLength(15).IsRequired();
            Property(c => c.Message).HasMaxLength(400).IsRequired();
            Property(c => c.Name).HasMaxLength(100);
            Property(c => c.Title).HasMaxLength(100).IsRequired();
            Property(c => c.Email).HasMaxLength(100);

            HasOptional(c => c.Parent).WithMany(c => c.Children).HasForeignKey(c => c.ParentCommentId).WillCascadeOnDelete(true);
        }
    }
}
