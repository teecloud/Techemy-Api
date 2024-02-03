using System.Threading.Tasks;
using Abp.Application.Services;
using Techemy.Authorization.Accounts.Dto;

namespace Techemy.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
