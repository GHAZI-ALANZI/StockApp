using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.TransactionDetail
{
    public class TransactionDetailRepository : Repository<StockApp.Data.Entity.TransactionDetail>, ITransactionDetailRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }
        public TransactionDetailRepository(DbContext context) : base(context)
        {
        }

        public void DeleteAllRecordByTransaction(ICollection<StockApp.Data.Entity.TransactionDetail> transactionDetails)
        {
            dbContext.RemoveRange(transactionDetails);
        }

        public async Task<IEnumerable<StockApp.Data.Entity.TransactionDetail>> GetByTransactionId(int transactionId)
        {
            return await dbContext.TransactionDetail.Include(x => x.Product).ThenInclude(x=> x.UnitOfMeasure).Where(x => x.TransactionId == transactionId).ToListAsync();
        }
    }
}
