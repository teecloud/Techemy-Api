using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using Techemy.Prospects;

namespace Techemy.Contacts.Dto
{
    [AutoMapTo(typeof(Prospect))]
    public class CreateProspectInput
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<CreateAddressInput> Addresses { get; set; }
        public string TelephoneNumber { get; set; }
    }
}
