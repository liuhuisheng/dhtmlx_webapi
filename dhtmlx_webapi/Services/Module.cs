using Autofac;
using Chitu.Context;
using Chitu.Data;
using Chitu.Security;
using dhtmlx_webapi.Services;
using Module = Autofac.Module;

namespace dhtmlx_webapi.Service
{
    public class ServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TenantService>().As<ITenantService>().InstancePerLifetimeScope();
            builder.RegisterType<AppService>().As<IAppService>().InstancePerLifetimeScope();
        }
    }
}