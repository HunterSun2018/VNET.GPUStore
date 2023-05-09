using VNET.GPUStore.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VNET.GPUStore.Permissions;

public class GPUStorePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(GPUStorePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(GPUStorePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<GPUStoreResource>(name);
    }
}
