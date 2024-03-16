using App.Domain.Core.Advertise.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.EF.Sql.EntityConfigs
{
    internal class CityEntityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.Id)
                .IsRequired();

            builder
                .Property(c => c.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(c => c.Name)
                .HasMaxLength(50)
                .IsRequired();

            //builder
            //    .HasMany(c => c.AdvertisesList)
            //    .WithOne(a => a.City)
            //    .HasForeignKey(a => a.CityId);
        }

    }
}
