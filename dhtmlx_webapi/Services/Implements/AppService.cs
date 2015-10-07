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
    public class AppService : IAppService
    {
        private IUser _user;
        private IDbContext _db;

        public AppService(IUser user, IDbContext db) 
        {
            _user = user;
            _db = db;
        }
 
        public Paging<bas_app> GetAppListWithPaging(QueryEntity qe)
        {
            var result = _db.Select("*")
                .From("bas_app")
                .Where<_StartWith>("app_id", qe).IgnoreEmpty()          //编码使用startwith查询           忽略空值
                .Where<_Like>("app_name,app_name_en", qe).IgnoreEmpty() //中文名及英文名都使用like查询    忽略空值
                .Where<_Eq>("*", qe).IgnoreEmpty()                      //剩下的其它的字段都使用equal查询 忽略空值
                .Paging(qe, "app_id")                                   //分页参数在qe中 默认按编码排序
                .QueryManyWithPaging<bas_app>();
             
            return result;
        }
    }
}
