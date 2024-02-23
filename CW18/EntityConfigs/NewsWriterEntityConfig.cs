using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConfigs
{
    public class NewsWriterEntityConfig : IEntityTypeConfiguration<NewsWriter>
    {
        public void Configure(EntityTypeBuilder<NewsWriter> builder)
        {
            builder
            .Property(nw => nw.Id)
            .IsRequired();

            builder
            .HasKey(nw => nw.Id);

            builder
            .Property(nw => nw.FirstName)
            .IsRequired();

            builder
            .Property(nw => nw.LastName)
            .IsRequired();
        }
    }
}
