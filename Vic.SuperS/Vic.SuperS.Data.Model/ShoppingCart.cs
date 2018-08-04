using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SuperS.Data.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public List<ShoppingItem> ShoppingItems { get; set; } = new List<ShoppingItem>();
        public DateTimeOffset Created { get; set; } = DateTimeOffset.Now;
    }
}
