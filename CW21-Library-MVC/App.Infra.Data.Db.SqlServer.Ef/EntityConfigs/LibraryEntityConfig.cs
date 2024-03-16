using App.Domain.Core.Librarian.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Db.SqlServer.Ef.EntityConfigs
{
    internal class LibraryEntityConfig : IEntityTypeConfiguration<Librarian>
    {
        public void Configure(EntityTypeBuilder<Librarian> builder)
        {
            builder
                .HasKey(l => l.Id);

            builder
                .Property(l => l.Id)
                .IsRequired();

            builder
                .Property(l => l.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(l => l.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(l => l.LastName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(l => l.Email)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(l => l.Password)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(l => l.ConfirmPassword)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
