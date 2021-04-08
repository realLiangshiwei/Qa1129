using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Qa.MongoDB
{
    public static class QaMongoDbContextExtensions
    {
        public static void ConfigureQa(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new QaMongoModelBuilderConfigurationOptions(
                QaDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}