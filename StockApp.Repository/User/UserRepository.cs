using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockApp.Core.Repository;
using StockApp.Data.Context;
using StockApp.Repository.Base;

namespace StockApp.Repository.User
{
    public class UserRepository : Repository<StockApp.Data.Entity.User>, IUserRepository
    {
        private EasyStockManagerDbContext dbContext { get => _context as EasyStockManagerDbContext; }

        public UserRepository(DbContext context) : base(context)
        {
        }

        public async Task<bool> EmailValidationCreateUser(string email)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email);
        }

        public async Task<bool> EmailValidationUpdateUser(string email, int Id)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email && x.Id != Id);
        }
        public async Task<bool> Login(string email, string password)
        {
            return await dbContext.User.AnyAsync(x => x.Email == email && x.Password == password);
        }
    }
}
