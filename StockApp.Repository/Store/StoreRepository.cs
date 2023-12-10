using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.Store
{
    public class StoreRepository : Repository<StockApp.Data.Entity.Store>, IStoreRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }

        public StoreRepository(DbContext context) : base(context)
        {
        }
    }
}
