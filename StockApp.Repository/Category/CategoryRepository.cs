using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.Category
{
    public class CategoryRepository : Repository<StockApp.Data.Entity.Category>, ICategoryRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }

        public CategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
