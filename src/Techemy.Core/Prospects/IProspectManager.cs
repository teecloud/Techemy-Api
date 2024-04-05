using Abp.Domain.Services;
using System.Threading.Tasks;
using Techemy.Events;

namespace Techemy.Prospects
{
    public interface IProspectManager : IDomainService
    {
        Task CreateAsync(Prospect prospect);
    }
}