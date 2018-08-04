using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public interface IShoppingCartRepository
    {
        ShoppingCart GetById(int id);
        ShoppingCart Create();
        ShoppingCart Update(int id, ShoppingCart newValue);
    }
}
