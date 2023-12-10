using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.Transaction
{
    public class TransactionRepository : Repository<StockApp.Data.Entity.Transaction>, ITransactionRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }
        public TransactionRepository(DbContext context) : base(context)
        {
        }
        public async Task<StockApp.Data.Entity.Transaction> GetWithDetailById(int id)
        {
            return await dbContext.Transaction.Include(x => x.TransactionDetail).FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task<StockApp.Data.Entity.Transaction> GetWithDetailAndProductById(int id)
        {
            return await dbContext.Transaction.Include(x => x.TransactionDetail).ThenInclude(x=> x.Product).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
