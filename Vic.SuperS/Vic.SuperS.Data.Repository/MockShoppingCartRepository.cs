using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public class MockShoppingCartRepository : IShoppingCartRepository
    {
        private readonly List<ShoppingCart> _shoppingCarts = new List<ShoppingCart>();

        public ShoppingCart Create()
        {
            int currentMaxId = 0;

            if (_shoppingCarts.Any())
            {
                currentMaxId = _shoppingCarts.Max(i => i.Id);
            }

            currentMaxId++;

            var result = new ShoppingCart
            {
                Id = currentMaxId,
            };

            _shoppingCarts.Add(result);
            return result;
        }

        public ShoppingCart GetById(int id)
        {
            return _shoppingCarts.First(i => i.Id == id);
        }

        public ShoppingCart Update(int id, ShoppingCart newValue)
        {
            var old = _shoppingCarts.FirstOrDefault(i => i.Id == id);

            if (old != null)
            {
                old.ShoppingItems = newValue.ShoppingItems;
                old.Created = newValue.Created;
            }

            return old;
        }
    }
}
