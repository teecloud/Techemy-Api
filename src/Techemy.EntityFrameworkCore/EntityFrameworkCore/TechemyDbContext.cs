using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Techemy.Authorization.Roles;
using Techemy.Authorization.Users;
using Techemy.MultiTenancy;

namespace Techemy.EntityFrameworkCore
{
    public class TechemyDbContext : AbpZeroDbContext<Tenant, Role, User, TechemyDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TechemyDbContext(DbContextOptions<TechemyDbContext> options)
            : base(options)
        {
        }
    }
}
