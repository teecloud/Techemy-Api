using System.Threading.Tasks;
using Abp.Application.Services;
using Techemy.Sessions.Dto;

namespace Techemy.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
