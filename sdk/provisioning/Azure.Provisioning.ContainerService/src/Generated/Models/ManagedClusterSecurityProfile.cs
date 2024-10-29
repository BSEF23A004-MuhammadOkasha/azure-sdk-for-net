// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Security profile for the container service cluster.
/// </summary>
public partial class ManagedClusterSecurityProfile : ProvisionableConstruct
{
    /// <summary>
    /// Microsoft Defender settings for the security profile.
    /// </summary>
    public ManagedClusterSecurityProfileDefender Defender 
    {
        get { Initialize(); return _defender!; }
        set { Initialize(); AssignOrReplace(ref _defender, value); }
    }
    private ManagedClusterSecurityProfileDefender? _defender;

    /// <summary>
    /// Azure Key Vault [key management
    /// service](https://kubernetes.io/docs/tasks/administer-cluster/kms-provider/)
    /// settings for the security profile.
    /// </summary>
    public ManagedClusterSecurityProfileKeyVaultKms AzureKeyVaultKms 
    {
        get { Initialize(); return _azureKeyVaultKms!; }
        set { Initialize(); AssignOrReplace(ref _azureKeyVaultKms, value); }
    }
    private ManagedClusterSecurityProfileKeyVaultKms? _azureKeyVaultKms;

    /// <summary>
    /// Whether to enable workload identity.
    /// </summary>
    public BicepValue<bool> IsWorkloadIdentityEnabled 
    {
        get { Initialize(); return _isWorkloadIdentityEnabled!; }
        set { Initialize(); _isWorkloadIdentityEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isWorkloadIdentityEnabled;

    /// <summary>
    /// Image Cleaner settings for the security profile.
    /// </summary>
    public ManagedClusterSecurityProfileImageCleaner ImageCleaner 
    {
        get { Initialize(); return _imageCleaner!; }
        set { Initialize(); AssignOrReplace(ref _imageCleaner, value); }
    }
    private ManagedClusterSecurityProfileImageCleaner? _imageCleaner;

    /// <summary>
    /// Creates a new ManagedClusterSecurityProfile.
    /// </summary>
    public ManagedClusterSecurityProfile()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ManagedClusterSecurityProfile.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _defender = DefineModelProperty<ManagedClusterSecurityProfileDefender>("Defender", ["defender"]);
        _azureKeyVaultKms = DefineModelProperty<ManagedClusterSecurityProfileKeyVaultKms>("AzureKeyVaultKms", ["azureKeyVaultKms"]);
        _isWorkloadIdentityEnabled = DefineProperty<bool>("IsWorkloadIdentityEnabled", ["workloadIdentity", "enabled"]);
        _imageCleaner = DefineModelProperty<ManagedClusterSecurityProfileImageCleaner>("ImageCleaner", ["imageCleaner"]);
    }
}
