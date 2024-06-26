﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace StockApp.Data.Seed
{   internal class TransactionTypeSeed : IEntityTypeConfiguration<TransactionType>
    {
        public void Configure(EntityTypeBuilder<TransactionType> builder)
        {
            builder.HasData(new TransactionType { Id = 1, TransactionTypeName = "Stock Receipt", CreateDate = DateTime.Now },
                            new TransactionType { Id = 2, TransactionTypeName = "Stock Out", CreateDate = DateTime.Now },
                            new TransactionType { Id = 3, TransactionTypeName = "Transfer", CreateDate = DateTime.Now });
        }
    }
}
