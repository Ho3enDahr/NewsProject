using NewsProject.Domain.Entities.Entities;
using System.Data.Entity.ModelConfiguration;

namespace NewsProject.DataBase.EF.Configurations
{
    public class keywordConfig:EntityTypeConfiguration<Keyword>
    {
        public keywordConfig()
        {
            Property(c => c.Title).
                HasMaxLength(100).
                IsRequired().
                IsUnicode();
        }
    }
}
