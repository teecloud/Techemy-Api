using Abp.Application.Services;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using Techemy.Contacts.Dto;
using Techemy.Prospects;

namespace Techemy.Contacts
{
    public class ProspectAppService : TechemyAppServiceBase, IProspectAppService
    {
        private readonly IRepository<Prospect, int> _prospectRepository;
        private readonly IProspectManager _prospectManager;
        public ProspectAppService(IProspectManager prospectManager, IRepository<Prospect, int> prospectRepository)
        { 
            _prospectManager = prospectManager;
            _prospectRepository = prospectRepository;
        }

        public async Task<ProspectDto> CreateAsync(CreateProspectInput input)
        {
            var prospect = ObjectMapper.Map<Prospect>(input);
            prospect.TenantId = AbpSession.TenantId.Value;
            await _prospectManager.CreateAsync(prospect);
            return ObjectMapper.Map<ProspectDto>(prospect);
        }

        public Task<List<ProspectDto>> GetProspectsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProspectDto> UpdateAsync(ProspectDto input)
        {
            throw new System.NotImplementedException();
        }
    }
}
