using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Qa.MongoDB
{
    [ConnectionStringName(QaDbProperties.ConnectionStringName)]
    public class QaMongoDbContext : AbpMongoDbContext, IQaMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureQa();
        }
    }
}