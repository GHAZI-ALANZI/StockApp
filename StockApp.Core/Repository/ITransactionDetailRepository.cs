using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Data.Entity;

namespace StockApp.Core.Repository
{
    public interface ITransactionDetailRepository : IRepository<StockApp.Data.Entity.TransactionDetail>
    {
        void DeleteAllRecordByTransaction(ICollection<StockApp.Data.Entity.TransactionDetail> transactionDetails);
        Task<IEnumerable<StockApp.Data.Entity.TransactionDetail>> GetByTransactionId(int transactionId);
    }
}
