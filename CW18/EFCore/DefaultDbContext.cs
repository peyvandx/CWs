using Entities;
using EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata;
namespace AppDbContext
{
    public class DefaultDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PEYVAND\SQLEXPRESS;Initial Catalog=CW18-NewsWebSite;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //baraye in ke NewsEntityConfig apply shavad
            modelBuilder.ApplyConfiguration(new NewsEntityConfig());
        }

        public DbSet<News> News { get; set; }
        public DbSet<NewsWriter> NewsWriters { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
