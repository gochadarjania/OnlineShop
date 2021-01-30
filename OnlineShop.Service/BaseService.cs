using OnlineShop.Domain.Interfaces.Repository;
using OnlineShop.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Service
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected IBaseRepository<T> _repository;
        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
    }
}
