using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockApp.Model.Domain;
using StockApp.Model.Service;

namespace StockApp.Core.Service
{
    public interface IProductService : IService<ProductDTO>
    {
        Task<ServiceResult> DeleteProductImage(int id);
        Task<ServiceResult<IEnumerable<ProductDTO>>> GetProductsByBarcodeAndName(string term);
    }
}
