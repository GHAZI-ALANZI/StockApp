﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace StockApp.Data.Configurations
{
    internal class UnitOfMeasureConfiguration : IEntityTypeConfiguration<UnitOfMeasure>
    {
        public void Configure(EntityTypeBuilder<UnitOfMeasure> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.UnitOfMeasureName).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Isocode).IsRequired().HasMaxLength(3);
        }
    }
}
