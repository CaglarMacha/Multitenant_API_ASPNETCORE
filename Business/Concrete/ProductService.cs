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
    public class ProductService : IProductService
    {
        private readonly MultitenantDbContext _context;

        public ProductService(MultitenantDbContext context)
        {
            _context = context;
        }

        public async Task<Product> CreateAsync(string Dc_Zaman, string Dc_Kategori, string Dc_Olay)
        {
            var product = new Product(Dc_Zaman, Dc_Kategori, Dc_Olay);
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<IReadOnlyList<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }
        public async Task<Product> GetByIdAsync(int ID)
        {
            return await _context.Products.FindAsync(ID);
        }
        public async Task<Product> GetByTenantIdAsync(string TenantId)
        {
            string tenantId = TenantId;          
            List<Product> products=  GetListAsync(tenantId);         
            return await _context.Products.FindAsync(TenantId);
        }
        public  List<Product> GetListAsync(string TenantId)
        {
            return  _context.Products.Where(c => c.TenantId == TenantId).ToList();
        }



    }
}
