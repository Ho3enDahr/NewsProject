using NewsProject.Domain.Entities.Entities;
using System.Data.Entity;

namespace NewsProject.DataBase.EF.AppDbContext
{
    public class NewsDbContext:DbContext
    {
        public NewsDbContext():base("cnn")
        {

        }
        public DbSet<Keyword> Keywords { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NFile> NFiles { get; set; }
        public DbSet<OnlinePlcae> OnlinePlcaes { get; set; }
        public DbSet<Content> Contents { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }
}
