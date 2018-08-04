using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public class ProductRepositorySqlServer : IProductRepository
    {
        public ProductRepositorySqlServer()
        {
            // open sql connection
        }

        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Product item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            // sql connection run select * from Products where Id = id

            throw new NotImplementedException();
        }

        public Product Update(int id, Product newValue)
        {
            throw new NotImplementedException();
        }
    }
}
