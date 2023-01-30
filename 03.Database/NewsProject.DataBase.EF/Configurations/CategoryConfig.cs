using NewsProject.Domain.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace NewsProject.DataBase.EF.Configurations
{
    public class CategoryConfig:EntityTypeConfiguration<Category>
    {
        public CategoryConfig()
        {
            Property(c => c.Title).
                HasMaxLength(100).
                IsRequired().
                IsUnicode();
            HasOptional(c => c.Parent)
                .WithMany(c => c.Children)
                .HasForeignKey(c => c.ParentId);
        }
    }
}
