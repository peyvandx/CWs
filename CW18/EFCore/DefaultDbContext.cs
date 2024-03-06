using EFCore;
using Entities;
using EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace AppDbContext
{
    public class DefaultDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=PEYVAND\SQLEXPRESS;Initial Catalog=CW18-NewsWebSite;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = master; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //baraye in ke NewsEntityConfig apply shavad
            modelBuilder.ApplyConfiguration(new NewsEntityConfig());
            modelBuilder.ApplyConfiguration(new NewsWriterEntityConfig());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfig());
            modelBuilder.ApplyConfiguration(new AdminEntityConfig());
        }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<NewsWriter> NewsWriters { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
