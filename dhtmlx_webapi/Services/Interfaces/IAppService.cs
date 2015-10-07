using Chitu.Data;
using dhtmlx_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhtmlx_webapi.Services
{
    public interface IAppService
    {
        Paging<bas_app> GetAppListWithPaging(QueryEntity qe);
    }
}
