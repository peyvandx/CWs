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
    internal class UserEntityConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Id)
                .IsRequired();

            builder
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Password)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.ConfirmPassword)
                .HasMaxLength(50)
                .IsRequired();

            //builder
            //    .Property(u => u.PhoneNumber)
            //    .HasMaxLength(20)
            //    .IsRequired();

            //builder
            //    .HasMany(u => u.UserAdvertises)
            //    .WithOne(a => a.Owner)
            //    .HasForeignKey(a => a.OwnerId);

        }
    }
}
