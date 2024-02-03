using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Techemy.EntityFrameworkCore
{
    public static class TechemyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TechemyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TechemyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
