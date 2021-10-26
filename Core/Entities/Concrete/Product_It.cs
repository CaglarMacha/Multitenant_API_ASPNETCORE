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
        public Product_It(string dc_Orario, string dc_Categoria, string dc_Evento)
        {
            dc_Orario = dc_Orario;
            dc_Categoria = dc_Categoria;
            dc_Evento = dc_Evento;
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
