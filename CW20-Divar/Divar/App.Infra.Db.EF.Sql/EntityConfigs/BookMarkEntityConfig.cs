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
    internal class BookMarkEntityConfig : IEntityTypeConfiguration<BookMark>
    {
        public void Configure(EntityTypeBuilder<BookMark> builder)
        {
            //builder
            //    .HasKey(bm => bm.Id);

            //builder
            //    .Property(bm => bm.Id)
            //    .IsRequired();
        }
    }
}
