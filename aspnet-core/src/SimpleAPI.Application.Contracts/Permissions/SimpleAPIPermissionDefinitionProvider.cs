using SimpleAPI.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SimpleAPI.Permissions;

public class SimpleAPIPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SimpleAPIPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SimpleAPIPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SimpleAPIResource>(name);
    }
}
