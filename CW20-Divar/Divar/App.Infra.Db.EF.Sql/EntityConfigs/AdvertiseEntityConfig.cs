using App.Domain.Core.Advertise.Entities;
using App.Domain.Core.User.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Db.EF.Sql.EntityConfigs
{
    internal class AdvertiseEntityConfig : IEntityTypeConfiguration<Advertise>
    {
        public void Configure(EntityTypeBuilder<Advertise> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(a => a.Title)
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(a => a.ShortDescription)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(a => a.Description)
                .HasMaxLength(4000)
                .IsRequired();

            builder
                .HasOne(a => a.City)
                .WithMany(c => c.AdvertisesList);

            builder
                .HasOne(a => a.Category)
                .WithMany(c => c.AdvertisesList);

            builder
                .HasOne(a => a.Owner)
                .WithMany(u => u.UserAdvertises);

            builder
                .HasMany(a => a.BookMarks)
                .WithMany(u => u.UserBookMarks)
                .UsingEntity<BookMark>(
                    j => j
                        .HasOne(b => b.User)
                        .WithMany(u => u.BookMarksJunction)
                        .HasForeignKey(b => b.UserId)
                        .OnDelete(DeleteBehavior.ClientCascade),
                    j => j
                        .HasOne(b => b.Advertise)
                        .WithMany(a => a.BookMarksJunction)
                        .HasForeignKey(b => b.AdvertiseId)
                        .OnDelete(DeleteBehavior.ClientCascade),
                    j =>
                    {
                        j.HasKey(t => new { t.UserId, t.AdvertiseId });
                    }
                    //{
                    //    j.HasKey(a => new { UserId = a.UserId, AdvertiseId = a.AdvertiseId });
                    //}
                );

            //builder
            //    .HasMany(e => e.BookMarks)
            //    .WithMany(e => e.UserBookMarks)
            //    .UsingEntity<BookMark>(
            // l => l.HasOne<User>().WithMany().HasForeignKey(e => e.UserId),
            // r => r.HasOne<Advertise>().WithMany().HasForeignKey(e => e.AdvertiseId));

        }
    }
}
