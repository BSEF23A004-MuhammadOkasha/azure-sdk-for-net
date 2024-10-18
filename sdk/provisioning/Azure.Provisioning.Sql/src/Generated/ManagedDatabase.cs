// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// ManagedDatabase.
/// </summary>
public partial class ManagedDatabase : Resource
{
    /// <summary>
    /// The name of the database.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// Whether to auto complete restore of this managed database.
    /// </summary>
    public BicepValue<bool> AllowAutoCompleteRestore { get => _allowAutoCompleteRestore; set => _allowAutoCompleteRestore.Assign(value); }
    private readonly BicepValue<bool> _allowAutoCompleteRestore;

    /// <summary>
    /// Collation of the metadata catalog.
    /// </summary>
    public BicepValue<CatalogCollationType> CatalogCollation { get => _catalogCollation; set => _catalogCollation.Assign(value); }
    private readonly BicepValue<CatalogCollationType> _catalogCollation;

    /// <summary>
    /// Collation of the managed database.
    /// </summary>
    public BicepValue<string> Collation { get => _collation; set => _collation.Assign(value); }
    private readonly BicepValue<string> _collation;

    /// <summary>
    /// Managed database create mode. PointInTimeRestore: Create a database by
    /// restoring a point in time backup of an existing database.
    /// SourceDatabaseName, SourceManagedInstanceName and PointInTime must be
    /// specified. RestoreExternalBackup: Create a database by restoring from
    /// external backup files. Collation, StorageContainerUri and
    /// StorageContainerSasToken must be specified. Recovery: Creates a
    /// database by restoring a geo-replicated backup. RecoverableDatabaseId
    /// must be specified as the recoverable database resource ID to restore.
    /// RestoreLongTermRetentionBackup: Create a database by restoring from a
    /// long term retention backup (longTermRetentionBackupResourceId
    /// required).
    /// </summary>
    public BicepValue<ManagedDatabaseCreateMode> CreateMode { get => _createMode; set => _createMode.Assign(value); }
    private readonly BicepValue<ManagedDatabaseCreateMode> _createMode;

    /// <summary>
    /// The restorable cross-subscription dropped database resource id to
    /// restore when creating this database.
    /// </summary>
    public BicepValue<ResourceIdentifier> CrossSubscriptionRestorableDroppedDatabaseId { get => _crossSubscriptionRestorableDroppedDatabaseId; set => _crossSubscriptionRestorableDroppedDatabaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _crossSubscriptionRestorableDroppedDatabaseId;

    /// <summary>
    /// The resource identifier of the cross-subscription source database
    /// associated with create operation of this database.
    /// </summary>
    public BicepValue<ResourceIdentifier> CrossSubscriptionSourceDatabaseId { get => _crossSubscriptionSourceDatabaseId; set => _crossSubscriptionSourceDatabaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _crossSubscriptionSourceDatabaseId;

    /// <summary>
    /// Target managed instance id used in cross-subscription restore.
    /// </summary>
    public BicepValue<ResourceIdentifier> CrossSubscriptionTargetManagedInstanceId { get => _crossSubscriptionTargetManagedInstanceId; set => _crossSubscriptionTargetManagedInstanceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _crossSubscriptionTargetManagedInstanceId;

    /// <summary>
    /// Whether or not this database is a ledger database, which means all
    /// tables in the database are ledger tables. Note: the value of this
    /// property cannot be changed after the database has been created.
    /// </summary>
    public BicepValue<bool> IsLedgerOn { get => _isLedgerOn; set => _isLedgerOn.Assign(value); }
    private readonly BicepValue<bool> _isLedgerOn;

    /// <summary>
    /// Last backup file name for restore of this managed database.
    /// </summary>
    public BicepValue<string> LastBackupName { get => _lastBackupName; set => _lastBackupName.Assign(value); }
    private readonly BicepValue<string> _lastBackupName;

    /// <summary>
    /// The name of the Long Term Retention backup to be used for restore of
    /// this managed database.
    /// </summary>
    public BicepValue<ResourceIdentifier> LongTermRetentionBackupResourceId { get => _longTermRetentionBackupResourceId; set => _longTermRetentionBackupResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _longTermRetentionBackupResourceId;

    /// <summary>
    /// The resource identifier of the recoverable database associated with
    /// create operation of this database.
    /// </summary>
    public BicepValue<ResourceIdentifier> RecoverableDatabaseId { get => _recoverableDatabaseId; set => _recoverableDatabaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _recoverableDatabaseId;

    /// <summary>
    /// The restorable dropped database resource id to restore when creating
    /// this database.
    /// </summary>
    public BicepValue<ResourceIdentifier> RestorableDroppedDatabaseId { get => _restorableDroppedDatabaseId; set => _restorableDroppedDatabaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _restorableDroppedDatabaseId;

    /// <summary>
    /// Conditional. If createMode is PointInTimeRestore, this value is
    /// required. Specifies the point in time (ISO8601 format) of the source
    /// database that will be restored to create the new database.
    /// </summary>
    public BicepValue<DateTimeOffset> RestorePointInTime { get => _restorePointInTime; set => _restorePointInTime.Assign(value); }
    private readonly BicepValue<DateTimeOffset> _restorePointInTime;

    /// <summary>
    /// The resource identifier of the source database associated with create
    /// operation of this database.
    /// </summary>
    public BicepValue<ResourceIdentifier> SourceDatabaseId { get => _sourceDatabaseId; set => _sourceDatabaseId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _sourceDatabaseId;

    /// <summary>
    /// Conditional. If createMode is RestoreExternalBackup, this value is
    /// used. Specifies the identity used for storage container
    /// authentication. Can be &apos;SharedAccessSignature&apos; or
    /// &apos;ManagedIdentity&apos;; if not specified
    /// &apos;SharedAccessSignature&apos; is assumed.
    /// </summary>
    public BicepValue<string> StorageContainerIdentity { get => _storageContainerIdentity; set => _storageContainerIdentity.Assign(value); }
    private readonly BicepValue<string> _storageContainerIdentity;

    /// <summary>
    /// Conditional. If createMode is RestoreExternalBackup and
    /// storageContainerIdentity is not ManagedIdentity, this value is
    /// required. Specifies the storage container sas token.
    /// </summary>
    public BicepValue<string> StorageContainerSasToken { get => _storageContainerSasToken; set => _storageContainerSasToken.Assign(value); }
    private readonly BicepValue<string> _storageContainerSasToken;

    /// <summary>
    /// Conditional. If createMode is RestoreExternalBackup, this value is
    /// required. Specifies the uri of the storage container where backups for
    /// this restore are stored.
    /// </summary>
    public BicepValue<Uri> StorageContainerUri { get => _storageContainerUri; set => _storageContainerUri.Assign(value); }
    private readonly BicepValue<Uri> _storageContainerUri;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Creation date of the database.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn { get => _createdOn; }
    private readonly BicepValue<DateTimeOffset> _createdOn;

    /// <summary>
    /// Geo paired region.
    /// </summary>
    public BicepValue<AzureLocation> DefaultSecondaryLocation { get => _defaultSecondaryLocation; }
    private readonly BicepValue<AzureLocation> _defaultSecondaryLocation;

    /// <summary>
    /// Earliest restore point in time for point in time restore.
    /// </summary>
    public BicepValue<DateTimeOffset> EarliestRestorePoint { get => _earliestRestorePoint; }
    private readonly BicepValue<DateTimeOffset> _earliestRestorePoint;

    /// <summary>
    /// Instance Failover Group resource identifier that this managed database
    /// belongs to.
    /// </summary>
    public BicepValue<ResourceIdentifier> FailoverGroupId { get => _failoverGroupId; }
    private readonly BicepValue<ResourceIdentifier> _failoverGroupId;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Status of the database.
    /// </summary>
    public BicepValue<ManagedDatabaseStatus> Status { get => _status; }
    private readonly BicepValue<ManagedDatabaseStatus> _status;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ManagedInstance.
    /// </summary>
    public ManagedInstance? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ManagedInstance> _parent;

    /// <summary>
    /// Creates a new ManagedDatabase.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ManagedDatabase resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedDatabase.</param>
    public ManagedDatabase(string identifierName, string? resourceVersion = default)
        : base(identifierName, "Microsoft.Sql/managedInstances/databases", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"], isRequired: true);
        _allowAutoCompleteRestore = BicepValue<bool>.DefineProperty(this, "AllowAutoCompleteRestore", ["properties", "autoCompleteRestore"]);
        _catalogCollation = BicepValue<CatalogCollationType>.DefineProperty(this, "CatalogCollation", ["properties", "catalogCollation"]);
        _collation = BicepValue<string>.DefineProperty(this, "Collation", ["properties", "collation"]);
        _createMode = BicepValue<ManagedDatabaseCreateMode>.DefineProperty(this, "CreateMode", ["properties", "createMode"]);
        _crossSubscriptionRestorableDroppedDatabaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CrossSubscriptionRestorableDroppedDatabaseId", ["properties", "crossSubscriptionRestorableDroppedDatabaseId"]);
        _crossSubscriptionSourceDatabaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CrossSubscriptionSourceDatabaseId", ["properties", "crossSubscriptionSourceDatabaseId"]);
        _crossSubscriptionTargetManagedInstanceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CrossSubscriptionTargetManagedInstanceId", ["properties", "crossSubscriptionTargetManagedInstanceId"]);
        _isLedgerOn = BicepValue<bool>.DefineProperty(this, "IsLedgerOn", ["properties", "isLedgerOn"]);
        _lastBackupName = BicepValue<string>.DefineProperty(this, "LastBackupName", ["properties", "lastBackupName"]);
        _longTermRetentionBackupResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "LongTermRetentionBackupResourceId", ["properties", "longTermRetentionBackupResourceId"]);
        _recoverableDatabaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "RecoverableDatabaseId", ["properties", "recoverableDatabaseId"]);
        _restorableDroppedDatabaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "RestorableDroppedDatabaseId", ["properties", "restorableDroppedDatabaseId"]);
        _restorePointInTime = BicepValue<DateTimeOffset>.DefineProperty(this, "RestorePointInTime", ["properties", "restorePointInTime"]);
        _sourceDatabaseId = BicepValue<ResourceIdentifier>.DefineProperty(this, "SourceDatabaseId", ["properties", "sourceDatabaseId"]);
        _storageContainerIdentity = BicepValue<string>.DefineProperty(this, "StorageContainerIdentity", ["properties", "storageContainerIdentity"]);
        _storageContainerSasToken = BicepValue<string>.DefineProperty(this, "StorageContainerSasToken", ["properties", "storageContainerSasToken"]);
        _storageContainerUri = BicepValue<Uri>.DefineProperty(this, "StorageContainerUri", ["properties", "storageContainerUri"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _createdOn = BicepValue<DateTimeOffset>.DefineProperty(this, "CreatedOn", ["properties", "creationDate"], isOutput: true);
        _defaultSecondaryLocation = BicepValue<AzureLocation>.DefineProperty(this, "DefaultSecondaryLocation", ["properties", "defaultSecondaryLocation"], isOutput: true);
        _earliestRestorePoint = BicepValue<DateTimeOffset>.DefineProperty(this, "EarliestRestorePoint", ["properties", "earliestRestorePoint"], isOutput: true);
        _failoverGroupId = BicepValue<ResourceIdentifier>.DefineProperty(this, "FailoverGroupId", ["properties", "failoverGroupId"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _status = BicepValue<ManagedDatabaseStatus>.DefineProperty(this, "Status", ["properties", "status"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ManagedInstance>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported ManagedDatabase resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01-preview.
        /// </summary>
        public static readonly string V2024_05_01_preview = "2024-05-01-preview";

        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing ManagedDatabase.
    /// </summary>
    /// <param name="identifierName">
    /// The the Bicep identifier name of the ManagedDatabase resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the ManagedDatabase.</param>
    /// <returns>The existing ManagedDatabase resource.</returns>
    public static ManagedDatabase FromExisting(string identifierName, string? resourceVersion = default) =>
        new(identifierName, resourceVersion) { IsExistingResource = true };
}
