using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techemy.Contacts.Dto;

namespace Techemy.Contacts
{
    internal interface IProspectAppService : IApplicationService
    {
        Task<ProspectDto> CreateAsync(CreateProspectInput input);
        Task<List<ProspectDto>> GetProspectsAsync();
    }
}