using Chitu.Data;
using dhtmlx_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhtmlx_webapi.Services
{
    public interface ITenantService
    {
        List<bas_tenant> GetTenantList();
        Paging<bas_tenant> GetTenantListWithPaging(QueryEntity qe);
        bas_tenant GetTenant(string id);
        int Update(string id, bas_tenant tenant);
        string Insert(bas_tenant tenant);
        int Delete(string id);
    }
}
