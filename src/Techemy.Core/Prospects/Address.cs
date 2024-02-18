using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Techemy.Prospects
{
    [Table("AppAddresses")]
    public class Address : FullAuditedEntity<Guid>, IMustHaveTenant
    {
        public Address() { }
        public virtual int TenantId { get; set; }
        [Required]
        public virtual string StreetAddress1 { get; set; }
        public virtual string StreetAddress2 { get; set; }
        public virtual string StreetAddress3 { get; set; }
        [Required]
        public virtual string City { get; set; }
        [Required]
        public virtual string State { get; set; }
        [Required]
        public virtual string PostalCode { get; set; }

    }
}
