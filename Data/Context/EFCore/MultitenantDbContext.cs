using Core.Settings.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context.EFCore
{
    public class MultitenantDbContext: DbContext
    {
        public string TenantId { get; set; }
        private readonly ITenantService _tenantService;

    }
}
