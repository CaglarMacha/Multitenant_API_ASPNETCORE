using Core.Settings.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Settings.Abstract
{
    public interface ITenantService
    {
        
        public string GetDatabaseProvider();
        public string GetConnectionString();
        public Tenant GetTenant();
    
}
}
