using Core.Constant;
using Core.Settings.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Settings.Concrete
{
    public class TenantService : ITenantService
    {
        private readonly TenantSettings _tenantSettings;
        private HttpContext _httpContext;
        private Tenant tenant;
        public TenantService(IOptions<TenantSettings> tenantSettings,IHttpContextAccessor contextAccessor)
        {
            _tenantSettings = tenantSettings.Value;
            _httpContext = contextAccessor.HttpContext;
            if (_httpContext != null)
            {
                if (_httpContext.Request.Headers.TryGetValue("tenant", out var tenantId))
                {
                    SetTenant(tenantId);
                }
                else
                {
                    throw new Exception(ErrorMessages.Invalid_Tenant);
                }
            }
        }




        public string GetConnectionString()
        {
            throw new NotImplementedException();
        }

        public string GetDatabaseProvider()
        {
            throw new NotImplementedException();
        }

        public Tenant GetTenant()
        {
            throw new NotImplementedException();
        }
    }
}
