using Core.Abstract;
using Core.Contracts.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Product_Tr : BaseEntity, IMustHaveTenant
    {
        public Product_Tr(string Dc_Zaman, string Dc_Kategori, string Dc_Olay)
        {
            dc_Zaman = Dc_Zaman;
            dc_Kategori = Dc_Kategori;
            dc_Olay = Dc_Olay;
        }
        protected Product_Tr()
        {
        }

        public string dc_Zaman { get; private set; }
        public string dc_Kategori { get; private set; }
        public string dc_Olay { get; private set; }
        public string TenantId { get; set; }
    }
}
