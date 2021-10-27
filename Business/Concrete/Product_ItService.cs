using Business.Abstract;
using Core.Entities.Concrete;
using Data.Context.EFCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Product_ItService : IProductServiceIt
    {
        private readonly MultitenantDbContext _context;

        public Product_ItService(MultitenantDbContext context)
        {
            _context = context;
        }

        public Task<Product_It> CreateAsync(string Dc_Zaman, string Dc_Kategori, string Dc_Olay)
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
