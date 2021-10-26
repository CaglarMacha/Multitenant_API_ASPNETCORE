using Core.Abstract;
using Core.Contracts.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Product_It : BaseEntity, IMustHaveTenant
    {
        public Product_It(string Dc_Zaman, string Dc_Kategori, string Dc_Olay)
        {
            dc_Orario = Dc_Zaman;
            dc_Categoria = Dc_Kategori;
            dc_Evento = Dc_Olay;
        }
        protected Product_It()
        {
        }
        
        public string dc_Orario { get; private set; }
        public string dc_Categoria { get; private set; }
        public string dc_Evento { get; private set; }
        public string TenantId { get; set; }
    }
}
