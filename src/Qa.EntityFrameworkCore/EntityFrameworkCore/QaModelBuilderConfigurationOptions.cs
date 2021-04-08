using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Qa.EntityFrameworkCore
{
    public class QaModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public QaModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}