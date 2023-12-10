using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repository
{
    public interface ITransactionRepository : IRepository<StockApp.Data.Entity.Transaction>
    {
        Task<StockApp.Data.Entity.Transaction> GetWithDetailById(int id);
        Task<StockApp.Data.Entity.Transaction> GetWithDetailAndProductById(int id);
    }
}
