using Qa.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Qa
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(QaEntityFrameworkCoreTestModule)
        )]
    public class QaDomainTestModule : AbpModule
    {
        
    }
}
