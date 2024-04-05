using Abp.Domain.Repositories;
using Abp.Events.Bus;
using Abp.UI;
using System.Threading.Tasks;

namespace Techemy.Prospects
{
    public class ProspectManager : IProspectManager
    {
        public IEventBus EventBus { get; set; }

        private readonly IRepository<Prospect, int> _prospectRepository;

        public ProspectManager(
            IRepository<Prospect, int> prospectRepository)
        {
           
            _prospectRepository = prospectRepository;

            EventBus = NullEventBus.Instance;
        }

        public async Task<Prospect> GetAsync(int id)
        {
            var @prospect = await _prospectRepository.FirstOrDefaultAsync(id);
            if (@prospect == null)
            {
                throw new UserFriendlyException("Could not find the prospect!");
            }

            return @prospect;
        }

        public async Task CreateAsync(Prospect @prospect)
        {
            await _prospectRepository.InsertAsync(@prospect);
        }
    }
}

