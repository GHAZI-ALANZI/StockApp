using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace StockApp.Data.Configurations
{
    internal class TransactionDetailConfiguration : IEntityTypeConfiguration<TransactionDetail>
    {
        public void Configure(EntityTypeBuilder<TransactionDetail> builder)
        {
            builder.HasKey(x => new { x.TransactionId, x.ProductId });
            builder.Property(x => x.Amount).HasColumnType("decimal(18,2)");
            builder.ToTable("TransactionDetail");
        }
    }
}
