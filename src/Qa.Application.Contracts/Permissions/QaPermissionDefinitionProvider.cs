using Qa.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qa.Permissions
{
    public class QaPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(QaPermissions.GroupName, L("Permission:Qa"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<QaResource>(name);
        }
    }
}