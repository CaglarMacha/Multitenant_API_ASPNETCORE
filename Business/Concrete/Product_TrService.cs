﻿using Business.Abstract;
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
    public class Product_TrService : IProductService<Product_Tr>
    {
        private readonly MultitenantDbContext _context;

        public Product_TrService(MultitenantDbContext context)
        {
            _context = context;
        }

        public async Task<Product_Tr> CreateAsync(string dc_Zaman, string dc_Kategori, string dc_Olay)
        {
            var product = new Product_Tr(dc_Zaman, dc_Kategori, dc_Olay);
            _context.Product_Trs.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
        public async Task<IReadOnlyList<Product_Tr>> GetAllAsync()
        {
            return await _context.Product_Trs.ToListAsync();
        }
        public async Task<Product_Tr> GetByIdAsync(int ID)
        {
            return await _context.Product_Trs.FindAsync(ID);
        }



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
