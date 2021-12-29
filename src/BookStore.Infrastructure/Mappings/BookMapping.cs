using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Domain.Mappings
{
    public class BookMapping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            //throw new NotImplementedException();
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Name)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.Author)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(b => b.Description)
                .HasColumnType("varchar(500)");

            builder.Property(b => b.PublishDate)
                .IsRequired();

            builder.Property(b => b.Value)
                .IsRequired();

            builder.Property(b => b.CategoryId)
                .IsRequired();

            builder.ToTable("Books");

        }
    }
}
