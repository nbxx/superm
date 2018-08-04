using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public class MockProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new List<Product>
        {
            new Product{ Id=1, Name="apple", Price=1.2m, Descript="this is an apple, not apple computer" },
            new Product{ Id=2, Name="cd", Price=1.2m, Descript="" },
            new Product{ Id=3, Name="milk", Price=1.2m, Descript="" },
            new Product{ Id=4, Name="book", Price=1.2m, Descript="" },
            new Product{ Id=5, Name="laptop", Price=1.2m, Descript="" },
            new Product{ Id=6, Name="pill", Price=1.2m, Descript="" },
        };

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Product item is null");
            }

            if (this._products.Any(i => i.Id == item.Id))
            {
                throw new ArgumentException($"Product id: {item.Id} already exists");
            }

            this._products.Add(item);

            return item;
        }

        public bool Delete(Product item)
        {
            if (item == null)
            {
                return false;
            }

            if (this._products.Any(i => i.Id == item.Id))
            {
                this._products.RemoveAll(i => i.Id == item.Id);
                return true;
            }

            return false;
        }

        public bool DeleteById(int id)
        {
            if (this._products.Any(i => i.Id == id))
            {
                this._products.RemoveAll(i => i.Id == id);
                return true;
            }

            return false;
        }

        public List<Product> GetAll()
        {
            return this._products;
        }

        public Product GetById(int id)
        {
            return _products.First(i => i.Id == id);
        }

        public Product Update(int id, Product newValue)
        {
            var product = _products.FirstOrDefault(i => i.Id == id);

            if (product != null)
            {
                product.Name = newValue.Name;
                product.Price = newValue.Price;
                product.Descript = newValue.Descript;
            }

            return product;
        }
    }
}
