// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.Storage;

/// <summary>
/// StorageTable.
/// </summary>
public partial class StorageTable : ProvisionableResource
{
    /// <summary>
    /// A table name must be unique within a storage account and must be
    /// between 3 and 63 characters.The name must comprise of only
    /// alphanumeric characters and it cannot begin with a numeric character.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// List of stored access policies specified on the table.
    /// </summary>
    public BicepList<StorageTableSignedIdentifier> SignedIdentifiers 
    {
        get { Initialize(); return _signedIdentifiers!; }
        set { Initialize(); _signedIdentifiers!.Assign(value); }
    }
    private BicepList<StorageTableSignedIdentifier>? _signedIdentifiers;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Table name under the specified account.
    /// </summary>
    public BicepValue<string> TableName 
    {
        get { Initialize(); return _tableName!; }
    }
    private BicepValue<string>? _tableName;

    /// <summary>
    /// Gets or sets a reference to the parent TableService.
    /// </summary>
    public TableService? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<TableService>? _parent;

    /// <summary>
    /// Creates a new StorageTable.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StorageTable resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StorageTable.</param>
    public StorageTable(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Storage/storageAccounts/tableServices/tables", resourceVersion ?? "2024-01-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of StorageTable.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _signedIdentifiers = DefineListProperty<StorageTableSignedIdentifier>("SignedIdentifiers", ["properties", "signedIdentifiers"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _tableName = DefineProperty<string>("TableName", ["properties", "tableName"], isOutput: true);
        _parent = DefineResource<TableService>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported StorageTable resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-01-01.
        /// </summary>
        public static readonly string V2024_01_01 = "2024-01-01";

        /// <summary>
        /// 2023-05-01.
        /// </summary>
        public static readonly string V2023_05_01 = "2023-05-01";

        /// <summary>
        /// 2023-04-01.
        /// </summary>
        public static readonly string V2023_04_01 = "2023-04-01";

        /// <summary>
        /// 2023-01-01.
        /// </summary>
        public static readonly string V2023_01_01 = "2023-01-01";

        /// <summary>
        /// 2022-09-01.
        /// </summary>
        public static readonly string V2022_09_01 = "2022-09-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";

        /// <summary>
        /// 2021-09-01.
        /// </summary>
        public static readonly string V2021_09_01 = "2021-09-01";

        /// <summary>
        /// 2021-08-01.
        /// </summary>
        public static readonly string V2021_08_01 = "2021-08-01";

        /// <summary>
        /// 2021-06-01.
        /// </summary>
        public static readonly string V2021_06_01 = "2021-06-01";

        /// <summary>
        /// 2021-05-01.
        /// </summary>
        public static readonly string V2021_05_01 = "2021-05-01";

        /// <summary>
        /// 2021-04-01.
        /// </summary>
        public static readonly string V2021_04_01 = "2021-04-01";

        /// <summary>
        /// 2021-02-01.
        /// </summary>
        public static readonly string V2021_02_01 = "2021-02-01";

        /// <summary>
        /// 2021-01-01.
        /// </summary>
        public static readonly string V2021_01_01 = "2021-01-01";

        /// <summary>
        /// 2019-06-01.
        /// </summary>
        public static readonly string V2019_06_01 = "2019-06-01";

        /// <summary>
        /// 2019-04-01.
        /// </summary>
        public static readonly string V2019_04_01 = "2019-04-01";

        /// <summary>
        /// 2018-11-01.
        /// </summary>
        public static readonly string V2018_11_01 = "2018-11-01";

        /// <summary>
        /// 2018-07-01.
        /// </summary>
        public static readonly string V2018_07_01 = "2018-07-01";

        /// <summary>
        /// 2018-02-01.
        /// </summary>
        public static readonly string V2018_02_01 = "2018-02-01";

        /// <summary>
        /// 2017-10-01.
        /// </summary>
        public static readonly string V2017_10_01 = "2017-10-01";

        /// <summary>
        /// 2017-06-01.
        /// </summary>
        public static readonly string V2017_06_01 = "2017-06-01";

        /// <summary>
        /// 2016-12-01.
        /// </summary>
        public static readonly string V2016_12_01 = "2016-12-01";

        /// <summary>
        /// 2016-05-01.
        /// </summary>
        public static readonly string V2016_05_01 = "2016-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing StorageTable.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the StorageTable resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the StorageTable.</param>
    /// <returns>The existing StorageTable resource.</returns>
    public static StorageTable FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this StorageTable resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 63, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.UppercaseLetters | ResourceNameCharacters.Numbers);
}
