using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StockApp.Core.Repository
{
    public interface IUserRepository : IRepository<StockApp.Data.Entity.User>
    {
        Task<bool> EmailValidationCreateUser(string email);
        Task<bool> EmailValidationUpdateUser(string email, int Id);
        Task<bool> Login(string email, string password);
    }
}
