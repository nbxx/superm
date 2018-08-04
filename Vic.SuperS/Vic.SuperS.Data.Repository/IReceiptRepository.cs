using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vic.SuperS.Data.Model;

namespace Vic.SuperS.Data.Repository
{
    public interface IReceiptRepository
    {
        Receipt GetById(int id);
        Receipt Create();
        Receipt Update(int id, Receipt newValue);
    }
}
