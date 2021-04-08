using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Qa.EntityFrameworkCore
{
    [ConnectionStringName(QaDbProperties.ConnectionStringName)]
    public class QaDbContext : AbpDbContext<QaDbContext>, IQaDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public QaDbContext(DbContextOptions<QaDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureQa();
        }
    }
}