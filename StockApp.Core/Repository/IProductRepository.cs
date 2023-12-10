using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repository
{
    public interface IProductRepository : IRepository<StockApp.Data.Entity.Product>
    {
        Task DeleteProductImage(int id);
        Task<IEnumerable<StockApp.Data.Entity.Product>> GetProductsByBarcodeAndName(string term);
    }
}
