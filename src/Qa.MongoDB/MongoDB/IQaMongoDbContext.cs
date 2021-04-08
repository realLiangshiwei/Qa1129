using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Qa.MongoDB
{
    [ConnectionStringName(QaDbProperties.ConnectionStringName)]
    public interface IQaMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
