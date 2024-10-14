// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Resources;

/// <summary>
/// ManagementLock.
/// </summary>
public partial class ManagementLock : Resource
{
    /// <summary>
    /// The name of lock.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The level of the lock. Possible values are: NotSpecified, CanNotDelete,
    /// ReadOnly. CanNotDelete means authorized users are able to read and
    /// modify the resources, but not delete. ReadOnly means authorized users
    /// can only read from a resource, but they can&apos;t modify or delete it.
    /// </summary>
    public BicepValue<ManagementLockLevel> Level { get => _level; set => _level.Assign(value); }
    private readonly BicepValue<ManagementLockLevel> _level;

    /// <summary>
    /// Notes about the lock. Maximum of 512 characters.
    /// </summary>
    public BicepValue<string> Notes { get => _notes; set => _notes.Assign(value); }
    private readonly BicepValue<string> _notes;

    /// <summary>
    /// The owners of the lock.
    /// </summary>
    public BicepList<ManagementLockOwner> Owners { get => _owners; set => _owners.Assign(value); }
    private readonly BicepList<ManagementLockOwner> _owners;

    /// <summary>
    /// Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Azure Resource Manager metadata containing createdBy and modifiedBy
    /// information.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Creates a new ManagementLock.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ManagementLock resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementLock.</param>
    public ManagementLock(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Authorization/locks", resourceVersion ?? "2020-05-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _level = BicepValue<ManagementLockLevel>.DefineProperty(this, "Level", ["properties", "level"], isRequired: true);
        _notes = BicepValue<string>.DefineProperty(this, "Notes", ["properties", "notes"]);
        _owners = BicepList<ManagementLockOwner>.DefineProperty(this, "Owners", ["properties", "owners"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
    }

    /// <summary>
    /// Supported ManagementLock resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2020-05-01.
        /// </summary>
        public static readonly string V2020_05_01 = "2020-05-01";

        /// <summary>
        /// 2017-04-01.
        /// </summary>
        public static readonly string V2017_04_01 = "2017-04-01";

        /// <summary>
        /// 2016-09-01.
        /// </summary>
        public static readonly string V2016_09_01 = "2016-09-01";

        /// <summary>
        /// 2015-06-01.
        /// </summary>
        public static readonly string V2015_06_01 = "2015-06-01";

        /// <summary>
        /// 2015-01-01.
        /// </summary>
        public static readonly string V2015_01_01 = "2015-01-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagementLock.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ManagementLock resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagementLock.</param>
    /// <returns>The existing ManagementLock resource.</returns>
    public static ManagementLock FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this ManagementLock resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 1, maxLength: 90, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen | ResourceNameCharacters.Underscore | ResourceNameCharacters.Period);
}
