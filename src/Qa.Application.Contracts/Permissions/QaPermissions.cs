using Volo.Abp.Reflection;

namespace Qa.Permissions
{
    public class QaPermissions
    {
        public const string GroupName = "Qa";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(QaPermissions));
        }
    }
}