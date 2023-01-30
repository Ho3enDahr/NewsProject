using NewsProject.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace NewsProject.DataBase.EF.Configurations
{
   public class ContentConfig:EntityTypeConfiguration<Content>
    {
        public ContentConfig()
        {
            HasMany(c => c.Keywords).
                WithMany().
                Map(c=>c.ToTable("ContentKeywords").
                MapLeftKey("ContentId").
                MapRightKey("KeywordId"));
            HasMany(c => c.RelatedCategories).
                WithMany().
                Map(c => c.ToTable("ContentCats").
                MapLeftKey("ContentId").
                MapRightKey("CategoryId"));
            HasMany(c => c.OnlinePlcaes).
                WithMany().
                Map(c => c.ToTable("ContentOnlinePlcaes").
                MapLeftKey("ContentId").
                MapRightKey("OnlinePlcaeId"));
            HasMany(c => c.RelatedFiles).
                WithMany().
                Map(c => c.ToTable("ContentFiles").
                MapLeftKey("ContentId").
                MapRightKey("FileId"));
            HasMany(c => c.RelatedContents).
                WithOptional().
                HasForeignKey(c => c.ParentId);
            HasRequired(c => c.DefaultCategory).
                WithMany().
                HasForeignKey(c => c.CategoryId);
            HasRequired(c => c.DefaultImage).
                WithMany().
                HasForeignKey(c => c.NFileId);
            HasMany(c => c.Comments).
                WithRequired(c => c.Content).
                HasForeignKey(c => c.ContentId);
            Property(c => c.Title).
                HasMaxLength(100).
                IsRequired();
            Property(c => c.ShortDescription).
                IsRequired().
                
                HasMaxLength(500);
        }
    }
}
