using Exch.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Exch.Permissions;

public class ExchPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ExchPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ExchPermissions.MyPermission1, L("Permission:MyPermission1"));

        var transferPermission = myGroup.AddPermission(ExchPermissions.Transfer.Default, L("Permission:Transfer"));
        transferPermission.AddChild(ExchPermissions.Transfer.Create, L("Permission:Create"));
        transferPermission.AddChild(ExchPermissions.Transfer.Update, L("Permission:Update"));
        transferPermission.AddChild(ExchPermissions.Transfer.Delete, L("Permission:Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ExchResource>(name);
    }
}
