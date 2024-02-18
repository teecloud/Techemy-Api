using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using Abp.UI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Techemy.Domain.Events;


namespace Techemy.Prospects
{
    [Table("AppProspects")]
    public class Prospect : FullAuditedEntity<int>, IMustHaveTenant
    {
        public virtual int TenantId { get; set; }
        [Required]
        public virtual string FirstName { get; set; }
        [Required]
        public virtual string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public virtual string Email { get; set;}
        [ForeignKey("ProspectId")]
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual string TelephoneNumber { get; set; }

        public Prospect() { }

    }
}
