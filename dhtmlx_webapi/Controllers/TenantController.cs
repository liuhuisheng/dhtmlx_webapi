using Chitu.Data;
using dhtmlx_webapi.Models;
using dhtmlx_webapi.Services;
using System.Web.Http;

//http://www.sitepoint.com/creating-crud-app-minutes-angulars-resource/
//http://angularjs.cn/A00e
//http://www.dhtmlx.com/blog/how-to-use-dhtmlxgrid-with-asp-net-mvc/ 
//https://docs.angularjs.org/api/ngResource/service/$resource

namespace dhtmlx_webapi.Controllers
{
    public class TenantController : ApiController
    {
        private ITenantService _tenantService;
        private RequestParameter _requestParameter;

        /// <summary>
        /// 注入参数及服务
        /// </summary>
        /// <param name="tenantService"></param>
        /// <param name="requestParameter"></param>
        public TenantController(ITenantService tenantService, RequestParameter requestParameter)
        {
            _tenantService = tenantService;
            _requestParameter = requestParameter;
        }
 
        /// <summary>
        /// 查询返回多条租户数据结果集
        /// </summary>
        /// <returns></returns>
        public Paging<bas_tenant> Get()
        {
            var query = _requestParameter.ReadAsQueryEntity();
            var result = _tenantService.GetTenantListWithPaging(query);
            return result;
        }
 
        /// <summary>
        /// 创建新的租户信息
        /// </summary>
        public string Post([FromBody]bas_tenant tenant)
        {
            return _tenantService.Insert(tenant);
        }

        /// <summary>
        /// 查询返回单个租户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bas_tenant Get(string id)
        {
            return _tenantService.GetTenant(id);
        }

        /// <summary>
        /// 更新租户信息
        /// </summary>
        /// <param name="id"></param>
        public void Put(string id,[FromBody]bas_tenant tenant)
        {
            _tenantService.Update(id, tenant);
        }

        /// <summary>
        /// 删除租户信息
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            _tenantService.Delete(id);
        }
    }
}
