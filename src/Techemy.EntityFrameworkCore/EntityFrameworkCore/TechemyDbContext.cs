using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Techemy.Authorization.Roles;
using Techemy.Authorization.Users;
using Techemy.MultiTenancy;
using Techemy.Events;
using Techemy.Prospects;

namespace Techemy.EntityFrameworkCore
{
    public class TechemyDbContext : AbpZeroDbContext<Tenant, Role, User, TechemyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Event> Events { get; set; }

        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }

        public virtual DbSet<Prospect> Prospects { get; set; }

        public virtual DbSet<Address> Addresses { get; set; }
        public TechemyDbContext(DbContextOptions<TechemyDbContext> options)
            : base(options)
        {
        }
    }
}
