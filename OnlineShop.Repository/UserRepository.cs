using OnlineShop.Domain;
using OnlineShop.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(OnlineShopDbContext context) : base(context)
        {

        }
    }
}
