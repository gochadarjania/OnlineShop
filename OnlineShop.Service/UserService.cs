using OnlineShop.Domain;
using OnlineShop.Domain.Interfaces.Repository;
using OnlineShop.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Service
{
    public class UserService : BaseService<User>, IUserService
    {
        public UserService(IUserRepository repository) : base(repository)
        {

        }        
    }
}
