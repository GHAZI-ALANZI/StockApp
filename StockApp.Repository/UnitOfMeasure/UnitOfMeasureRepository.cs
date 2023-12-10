using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.UnitOfMeasure
{
    public class UnitOfMeasureRepository : Repository<StockApp.Data.Entity.UnitOfMeasure>, IUnitOfMeasureRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }
        public UnitOfMeasureRepository(DbContext context) : base(context)
        {
        }
    }
}
