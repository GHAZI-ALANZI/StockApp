using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.StoreStock
{
    public class StoreStockRepository : Repository<StockApp.Data.Entity.StoreStock>, IStoreStockRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }
        public StoreStockRepository(DbContext context) : base(context)
        {
        }

        public async Task RemoveByStoreAndProductId(int productId, int storeId)
        {
            var entity = await dbContext.StoreStock.FirstOrDefaultAsync(x => x.StoreId == storeId && x.ProductId == productId);
            if (entity != null)
                dbContext.StoreStock.Remove(entity);
        }

        public async Task<StockApp.Data.Entity.StoreStock> GetByStoreAndProductId(int productId, int storeId)
        {
            var entity = await dbContext.StoreStock.FirstOrDefaultAsync(x => x.StoreId == storeId && x.ProductId == productId);
            return entity;
        }

        
    }
}
