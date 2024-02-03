using Abp.Application.Services;
using Techemy.MultiTenancy.Dto;

namespace Techemy.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

