using OnlineShop.Domain;
using OnlineShop.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepoitory
    {
        public ProductRepository(OnlineShopDbContext context) : base(context)
        {

        }
    }
}
