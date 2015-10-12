using Chitu.Context;
using Chitu.Data;
using Chitu.Logging;
using Chitu.Security;
using Chitu.Utils;
using dhtmlx_webapi.Models;
using dhtmlx_webapi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace dhtmlx_webapi.Controllers
{
    public class LogController : ApiController
    {
        private ILogger _log;
      
        public LogController(ILoggerFactory logFactory)
        {
            _log = logFactory.CreateLogger(this.GetType());
        }
 
        public void Get(string id)
        {
            var ct = (HttpContextBase)Request.Properties["MS_HttpContext"];//获取传统context
            var hbc = ct.Request.Browser;
            var ip = RequestHelper.ClientIP;
            var os = RequestHelper.GetPlatformName(ct.Request);
            var bs = string.Format("{0}-{1}-{2}", hbc.Browser, hbc.Version, hbc.Platform);

            _log.Error("【{0}】 IP地址：{1} 操作系统：{2} 浏览器：{3}", id, ip, os, bs);
        }
    }
}
