using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using StockApp.Model.Domain;
using StockApp.Model.Service;

namespace StockApp.Core.Service
{
    public interface IUserService : IService<UserDTO>
    {
        Task<ServiceResult> Login(string email, string password);
    }
}
