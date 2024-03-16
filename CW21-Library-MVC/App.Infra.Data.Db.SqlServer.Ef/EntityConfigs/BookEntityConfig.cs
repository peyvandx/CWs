using App.Domain.Core.Book.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infra.Data.Db.SqlServer.Ef.EntityConfigs
{
    internal class BookEntityConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder
                .HasKey(b => b.Id);

            builder
                .Property(b => b.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            builder
                .Property(b => b.Title)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(b => b.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder
                .Property(b => b.IsBorrowed)
                .IsRequired();

            builder
                .Property(b => b.IsDeleted)
                .IsRequired();

            builder
                .HasOne(b => b.Category)
                .WithMany(c => c.Books);

            builder
                .HasOne(b => b.User)
                .WithMany(u => u.BorrowedBooks);

            builder
                .HasOne(b => b.Librarian)
                .WithMany(l => l.Books);
        }
    }
}
