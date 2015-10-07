using Chitu.Context;
using Chitu.Data;
using Chitu.Security;
using dhtmlx_webapi.Models;
using dhtmlx_webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dhtmlx_webapi.Controllers
{
    public class AppController : ApiController
    {
        private IAppService _appService;
        private RequestParameter _requestParameter;

        public AppController(IAppService appService, RequestParameter requestParameter)
        {
            _appService = appService;
            _requestParameter = requestParameter;
        }

        /// <summary>
        /// 查询返回多条应用数据结果集
        /// </summary>
        /// <returns></returns>
        public Paging<bas_app> Get()
        {
            var query = _requestParameter.ReadAsQueryEntity();
            var result = _appService.GetAppListWithPaging(query);
            return result;
        }
    }
}
