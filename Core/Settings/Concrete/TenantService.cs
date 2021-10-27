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
        private Tenant _currentTenant;
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
                    
                    if (_currentTenant == null) throw new Exception(ErrorMessages.Invalid_Tenant);
                    if (string.IsNullOrEmpty(_currentTenant.ConnectionString))
                    {
                        SetDefaultConnectionStringToCurrentTenant();
                    }
                }
            }
            
        }
        public string GetConnectionString()
        {
            try
            {
                return _currentTenant?.ConnectionString;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }          
        }
        public string GetDatabaseProvider()
        {
            try
            {
                return _tenantSettings.Defaults?.DBProvider;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
        }

        public Tenant GetTenant()
        {
            try
            {
                return _currentTenant;
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }                    
        }

        private void SetDefaultConnectionStringToCurrentTenant()
        {
            _currentTenant.ConnectionString = _tenantSettings.Defaults.ConnectionString;
        }
        private void SetTenant(string tenantId)
        {
            _currentTenant = _tenantSettings.Tenants.Where(k => k.TID == tenantId).FirstOrDefault();

        }
    }
}
