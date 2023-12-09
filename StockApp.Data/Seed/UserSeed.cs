using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockApp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Common.Extensions;


namespace StockApp.Data.Seed
{
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        string adminPassword = "12345";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User { Id = 1, Email = "admin@admin.com", Name = "Admin", Surname = "Admin", Password = adminPassword.MD5Hash(), CreateDate = DateTime.Now });
        }
    }
}
