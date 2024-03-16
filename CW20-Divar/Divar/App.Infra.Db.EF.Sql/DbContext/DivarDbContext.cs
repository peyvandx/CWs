using App.Domain.Core.Advertise.Entities;
using App.Domain.Core.User.Entities;
using App.Infra.Db.EF.Sql.EntityConfigs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace App.Infra.Db.EF.Sql.DbContext
{
    internal class DivarDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=REZA\SQLEXPRESS;Initial Catalog=CW20-Divar;Integrated Security=True;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer(@"Data Source=PEYVAND\SQLEXPRESS;Initial Catalog=CW20-Divar;Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AdvertiseEntityConfig());
            modelBuilder.ApplyConfiguration(new BookMarkEntityConfig());
            modelBuilder.ApplyConfiguration(new CategoryEntityConfig());
            modelBuilder.ApplyConfiguration(new CityEntityConfig());
            modelBuilder.ApplyConfiguration(new UserEntityConfig());
        }

        public DbSet<Advertise> Advertises { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<BookMark> BookMarks { get; set; }
    }
}
