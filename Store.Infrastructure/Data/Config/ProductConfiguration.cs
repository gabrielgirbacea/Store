﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Core.Entities;

namespace Store.Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(p => p.Id).IsRequired();

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Price).HasColumnType("decimal(18,2)");

            builder.Property(p => p.PictureUrl).IsRequired();

            builder.HasOne(b => b.Brand)
                .WithMany()
                .HasForeignKey(p => p.BrandId);

            builder.HasOne(b => b.Type)
                .WithMany()
                .HasForeignKey(p => p.TypeId);
        }
    }
}
