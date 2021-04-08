using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;

namespace Qa.EntityFrameworkCore
{
    public class QaHttpApiHostMigrationsDbContext : AbpDbContext<QaHttpApiHostMigrationsDbContext>
    {
        public QaHttpApiHostMigrationsDbContext(DbContextOptions<QaHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureQa();
        }
    }
}
