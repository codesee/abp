﻿using System.Threading.Tasks;
using Volo.Abp.Permissions;

namespace Volo.Abp.Session
{
    //TODO: This should be located under Identity, or we should create a Volo.Abp.Roles package (with role store implementation)...!

    //public class RolePermissionValueProvider : PermissionValueProvider
    //{
    //    public const string ProviderName = "Role";

    //    public override string Name => ProviderName;

    //    protected ICurrentUser CurrentUser { get; }

    //    public RolePermissionValueProvider(IPermissionStore permissionStore, ICurrentUser currentUser)
    //        : base(permissionStore)
    //    {
    //        CurrentUser = currentUser;
    //    }

    //    public override async Task<bool?> IsGrantedAsync(PermissionDefinition permission, string providerKey)
    //    {
    //        if (providerKey == null)
    //        {
    //            if (CurrentUser.Id == null)
    //            {
    //                return null;
    //            }

    //            providerKey = CurrentUser.Id.ToString();
    //        }

    //        return await PermissionStore.IsGrantedAsync(permission.Name, Name, providerKey);
    //    }

    //    public override Task SetAsync(PermissionDefinition permission, bool isGranted, string providerKey)
    //    {
    //        return PermissionStore.SetAsync(permission.Name, isGranted, Name, providerKey);
    //    }

    //    public override Task ClearAsync(PermissionDefinition permission, string providerKey)
    //    {
    //        return PermissionStore.DeleteAsync(permission.Name, Name, providerKey);
    //    }
    //}
}
