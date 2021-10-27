using Business.Concrete;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService 
    {
        Task<Product> CreateAsync(string dc_Zaman, string dc_Kategori, string dc_Olay);
        Task<Product> GetByIdAsync(int ID);
        Task<IReadOnlyList<Product>> GetAllAsync();
    }
}
