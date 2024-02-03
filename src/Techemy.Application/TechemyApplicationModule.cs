using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Techemy.Authorization;

namespace Techemy
{
    [DependsOn(
        typeof(TechemyCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TechemyApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TechemyAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(TechemyApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
