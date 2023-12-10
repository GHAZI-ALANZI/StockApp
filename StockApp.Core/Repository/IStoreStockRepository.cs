using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repository
{
    public interface IStoreStockRepository : IRepository<StockApp.Data.Entity.StoreStock>
    {
        Task RemoveByStoreAndProductId(int productId, int storeId);
        Task<StockApp.Data.Entity.StoreStock> GetByStoreAndProductId(int productId, int storeId);
    }
}
