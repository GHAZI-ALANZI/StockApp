using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.TransactionType
{
    public class TransactionTypeRepository : Repository<StockApp.Data.Entity.TransactionType>, ITransactionTypeRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }
        public TransactionTypeRepository(DbContext context) : base(context)
        {
        }
    }
}
