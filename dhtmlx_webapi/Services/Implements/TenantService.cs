using Chitu.Context;
using Chitu.Data;
using Chitu.Security;
using dhtmlx_webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dhtmlx_webapi.Services
{
    [Connection("default")] //不同service可以配置不同连接字符串，没有此属性时默认default
    public class TenantService : ITenantService
    {
        private IUser _user;
        private IDbContext _db;

        public TenantService(IUser user,IDbContext db) 
        {
            _user = user;
            _db = db;
        }
 
        //不分页查询
        public List<bas_tenant> GetTenantList()
        {
            var result = _db.Select("*")
                .From("bas_tenant")
                .QueryMany<bas_tenant>();

            return result;
        }

        //分页查询
        public Paging<bas_tenant> GetTenantListWithPaging(QueryEntity qe)
        {
            var result = _db.Select("*")
                .From("bas_tenant")
                .Where<_StartWith>("tenant_id,tel", qe).IgnoreEmpty()               //商户编码、手机号     使用startwith查询 忽略空值
                .Where<_Like>("tenant_name,charge_person,addr", qe).IgnoreEmpty()   //商户名、责任人、地址 使用like查询      忽略空值
                .Where<_Eq>("*", qe).IgnoreEmpty()                                  //剩下的其它的字段都   使用equal查询     忽略空值 
                .Paging(qe, "tenant_id")                                            //分页参数在qe中 默认按商户编码排序
                .QueryManyWithPaging<bas_tenant>();
             
            return result;
        }

        //获取单条记录
        public bas_tenant GetTenant(string id)
        {
            var result = _db.Select("*")
                .From("bas_tenant")
                .Where("tenant_id",id)
                .QuerySingle<bas_tenant>();

            return result;
        }

        //更新
        public int Update(string id, bas_tenant tenant)
        {
            var result = _db.Update("bas_tenant", tenant)
                .AutoMap(x => x.tenant_id)
                .Where("tenant_id", id)
                .Execute();

            return result;
        }

        //添加
        public string Insert(bas_tenant tenant)
        {
            tenant.tenant_id = "T" + (new Random().Next(100) + 500).ToString();

            var result = _db.Insert("bas_tenant", tenant)
                .AutoMap()
                .Execute();

            return tenant.tenant_id;
        }

        //删除
        public int Delete(string id)
        {
            var result = _db.Delete("bas_tenant")
                .Where("tenant_id", id)
                .Execute();

            return result;
        }
    }
}
