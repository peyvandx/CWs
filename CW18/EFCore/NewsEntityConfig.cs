using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Metadata;

namespace EntityConfigs
{
    public class NewsEntityConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder
            .HasKey(n => n.Id);

            builder
            .Property(n => n.Id)
            .IsRequired();

            builder
            .Property(n => n.Heading)
            .IsRequired();

            builder
            .Property(n => n.Heading)
            .HasMaxLength (500);

            builder
                .Property(n => n.Description)
                .HasMaxLength(4000)
                .IsRequired();

            builder
            .Property(n => n.ImgPath)
            .IsRequired();

            builder 
            .Property(n => n.ImgPath)
            .HasMaxLength (1000);

            builder
                .Property(n => n.ViewImgPath)
                .IsRequired();

            builder
                .Property(n => n.ViewImgPath)
                .HasMaxLength(1000);

            builder
            .HasOne<NewsWriter>(n => n.NewsWriter)
            .WithMany(nw => nw.NewsList)
            .HasForeignKey(n => n.NewsWriterId);

            builder
                .HasOne<Admin>(n => n.ConfirmedBy)
                .WithMany(a => a.NewsQueueToBeConfirmed)
                .HasForeignKey(n => n.AdminId);

            builder
            .HasOne<Category>(n => n.Category)
            .WithMany(c => c.NewsList)
            .HasForeignKey(n => n.CategoryId);

        }
    }
}
