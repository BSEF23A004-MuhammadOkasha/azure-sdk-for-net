// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Volume definitions for the Container App.
/// </summary>
public partial class ContainerAppVolume : ProvisionableConstruct
{
    /// <summary>
    /// Volume name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Storage type for the volume. If not provided, use EmptyDir.
    /// </summary>
    public BicepValue<ContainerAppStorageType> StorageType 
    {
        get { Initialize(); return _storageType!; }
        set { Initialize(); _storageType!.Assign(value); }
    }
    private BicepValue<ContainerAppStorageType>? _storageType;

    /// <summary>
    /// Name of storage resource. No need to provide for EmptyDir and Secret.
    /// </summary>
    public BicepValue<string> StorageName 
    {
        get { Initialize(); return _storageName!; }
        set { Initialize(); _storageName!.Assign(value); }
    }
    private BicepValue<string>? _storageName;

    /// <summary>
    /// List of secrets to be added in volume. If no secrets are provided, all
    /// secrets in collection will be added to volume.
    /// </summary>
    public BicepList<SecretVolumeItem> Secrets 
    {
        get { Initialize(); return _secrets!; }
        set { Initialize(); _secrets!.Assign(value); }
    }
    private BicepList<SecretVolumeItem>? _secrets;

    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a
    /// comma-separated string.
    /// </summary>
    public BicepValue<string> MountOptions 
    {
        get { Initialize(); return _mountOptions!; }
        set { Initialize(); _mountOptions!.Assign(value); }
    }
    private BicepValue<string>? _mountOptions;

    /// <summary>
    /// Creates a new ContainerAppVolume.
    /// </summary>
    public ContainerAppVolume()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppVolume.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _storageType = DefineProperty<ContainerAppStorageType>("StorageType", ["storageType"]);
        _storageName = DefineProperty<string>("StorageName", ["storageName"]);
        _secrets = DefineListProperty<SecretVolumeItem>("Secrets", ["secrets"]);
        _mountOptions = DefineProperty<string>("MountOptions", ["mountOptions"]);
    }
}
