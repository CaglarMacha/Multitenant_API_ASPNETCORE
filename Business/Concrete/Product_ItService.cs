using Business.Abstract;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Product_ItService : IProductService<Product_It>
    {
        public Task<Product_It> CreateAsync(string name, string description, int rate)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<Product_It>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product_It> GetByIdAsync(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
