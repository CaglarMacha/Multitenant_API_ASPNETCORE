using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Product_TrService : IProductService<Product_Tr>
    {



        public Task<Product_Tr> CreateAsync(string name, string description, int rate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product_Tr>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product_Tr> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
