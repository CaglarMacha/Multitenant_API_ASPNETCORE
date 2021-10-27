using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multitenant_API_ASPNETCORE.Controllers
{
    public class Product_TrController : Controller
    {
        private readonly IProductService<Product_Tr> _service;
        public Product_TrController(IProductService<Product_Tr> service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAsync(int id)
        {
            var productDetails = await _service.GetByIdAsync(id);
            return Ok(productDetails);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateProductRequest request)
        {
            return Ok(await _service.CreateAsync(request.dc_Zaman, request.dc_Kategori, request.dc_Olay));
        }
    }
    public class CreateProductRequest
    {
        public string dc_Zaman { get; private set; }
        public string dc_Kategori { get; private set; }
        public string dc_Olay { get; private set; }
    
    }
}
}
