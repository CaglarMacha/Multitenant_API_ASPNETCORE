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
        Task<Product_Tr> CreateAsync(string dc_Zaman, string dc_Kategori, string dc_Olay);
        Task<Product_Tr> GetByIdAsync(int ID);
        Task<IReadOnlyList<Product_Tr>> GetAllAsync();
    }
}
