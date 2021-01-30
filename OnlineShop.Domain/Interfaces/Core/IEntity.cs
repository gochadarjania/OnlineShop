using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Domain.Interfaces.Core
{
    public interface IEntity
    {
        SystemFields SystemFields { get; set; }
    }
}
