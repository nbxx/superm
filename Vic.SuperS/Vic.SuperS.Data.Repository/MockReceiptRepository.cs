using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public class MockReceiptRepository : IReceiptRepository
    {
        private readonly List<Receipt> _receipts = new List<Receipt>();

        public Receipt Create()
        {
            int currentMaxId = 0;

            if (_receipts.Any())
            {
                currentMaxId = _receipts.Max(i => i.Id);
            }

            currentMaxId++;

            var result = new Receipt
            {
                Id = currentMaxId,
            };

            _receipts.Add(result);
            return result;
        }

        public Receipt GetById(int id)
        {
            return _receipts.First(i => i.Id == id);
        }

        public Receipt Update(int id, Receipt newValue)
        {
            var old = _receipts.FirstOrDefault(i => i.Id == id);

            if (old != null)
            {
                old.Created = newValue.Created;
                old.ShoppingCartId = newValue.ShoppingCartId;
                old.ShoppingItems = newValue.ShoppingItems;
                old.TotalPrice = newValue.TotalPrice;
            }

            return old;
        }
    }
}
