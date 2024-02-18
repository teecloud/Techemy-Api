using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.Collections.Generic;
using Abp.Domain.Entities;
using Techemy.Prospects;

namespace Techemy.Contacts.Dto
{
    [AutoMap(typeof(Prospect))]
    public class ProspectDto : EntityDto, IMustHaveTenant
    {
        public int TenantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
