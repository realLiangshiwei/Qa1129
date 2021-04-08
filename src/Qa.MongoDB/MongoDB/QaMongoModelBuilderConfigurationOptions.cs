using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Qa.MongoDB
{
    public class QaMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public QaMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}