﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace StockApp.Data.Configurations
{
    internal class StoreStockConfiguration : IEntityTypeConfiguration<StoreStock>
    {
        public void Configure(EntityTypeBuilder<StoreStock> builder)
        {
            builder.HasKey(x => new { x.StoreId, x.ProductId });
            builder.Property(x => x.Stock).HasColumnType("decimal(18,2)");
            builder.ToTable("StoreStock");
        }
    }
}
