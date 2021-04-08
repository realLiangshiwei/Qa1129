using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Qa.EntityFrameworkCore
{
    [ConnectionStringName(QaDbProperties.ConnectionStringName)]
    public interface IQaDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}