using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService<T> where T:class
    {
        Task<T> CreateAsync(string dc_Zaman, string dc_Kategori, string dc_Olay);
        Task<T> GetByIdAsync(int ID);
        Task<IReadOnlyList<T>> GetAllAsync();
    }
}
