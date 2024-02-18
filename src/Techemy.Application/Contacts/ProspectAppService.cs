using Abp.Application.Services;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Techemy.Contacts.Dto;
using Techemy.Prospects;

namespace Techemy.Contact
{
    public class ProspectAppService : AsyncCrudAppService<Prospect, ProspectDto>
    {
        public ProspectAppService(IRepository<Prospect, int> repository)
            : base(repository) { }
    }
}
