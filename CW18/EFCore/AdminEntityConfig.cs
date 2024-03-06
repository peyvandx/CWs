using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class AdminEntityConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder
            .HasKey(a => a.Id);

            builder
            .Property(a => a.Id)
            .IsRequired();

            builder
                .Property(a => a.FirstName)
                .HasMaxLength(100)
                .IsRequired();

            //builder
            //.Property(a => a.FirstName)
            //.HasMaxLength(100);

            builder
            .Property(a => a.LastName)
            .IsRequired();

            builder
            .Property(a => a.LastName)
            .HasMaxLength(100);

            builder
            .Property(a => a.Email)
            .IsRequired();

            builder
            .Property(a => a.Email)
            .HasMaxLength(500);

            builder
            .Property(a => a.Password)
            .IsRequired();

            builder
            .Property(a => a.Password)
            .HasMaxLength(500);

            builder
                .Property(a => a.ConfirmPassword)
                .HasMaxLength(500);

        }
    }
}
