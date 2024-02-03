using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Techemy.EntityFrameworkCore;
using Techemy.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Techemy.Web.Tests
{
    [DependsOn(
        typeof(TechemyWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TechemyWebTestModule : AbpModule
    {
        public TechemyWebTestModule(TechemyEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TechemyWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TechemyWebMvcModule).Assembly);
        }
    }
}