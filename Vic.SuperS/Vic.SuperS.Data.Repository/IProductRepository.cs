using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        Product Add(Product item);
        Product Update(int id, Product newValue);
        bool DeleteById(int id);
        bool Delete(Product item);
    }
}
