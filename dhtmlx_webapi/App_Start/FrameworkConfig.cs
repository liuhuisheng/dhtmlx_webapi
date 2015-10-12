using Chitu.Configurations;
using Chitu.Data;
using Chitu.Environment;
using Chitu.Logging;
using System;
using System.Web.Mvc;

namespace dhtmlx_webapi
{
    public class FrameworkConfig
    {
        //配置框架
        public static void Register()
        {
            Configuration.Instance()
                .RegisterComponents()
                .RegisterDependencyResolver()
                .RegisterProjectModules()
                .RegisterHttpCorsSupport()
                .RegisterDisposeFilter()
                .ConfigEditPageAutoInsert(EditPageAutoInser)
                .ConfigEditPageAutoUpdate(EditPageAutoUpdate)
                .ConfigDefaultDbContextExecuting(DbContextExecuting);
        }

        //配置自动插入字段
        static void EditPageAutoInser(EditAutoColsArgs e)
        {
            e.SetValue("create_person", e.user.Id);
            e.SetValue("create_date", DateTime.Now);
            e.SetValue("update_person", e.user.Id);
            e.SetValue("update_date", DateTime.Now);
        }

        //配置自动更新字段
        static void EditPageAutoUpdate(EditAutoColsArgs e)
        {
            e.SetValue("update_person", e.user.Id);
            e.SetValue("update_date", DateTime.Now);
        }

        //SQL执行前，DEBUG可在此处取得SQL
        static void DbContextExecuting(CommandEventArgs e)
        {
            var sql = e.Command.CommandText;
        }
    }

}