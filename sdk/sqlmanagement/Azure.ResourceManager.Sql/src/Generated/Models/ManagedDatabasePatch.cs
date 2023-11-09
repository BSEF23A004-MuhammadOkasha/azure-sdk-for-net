// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> An managed database update. </summary>
    public partial class ManagedDatabasePatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedDatabasePatch"/>. </summary>
        public ManagedDatabasePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedDatabasePatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="collation"> Collation of the managed database. </param>
        /// <param name="status"> Status of the database. </param>
        /// <param name="createdOn"> Creation date of the database. </param>
        /// <param name="earliestRestorePoint"> Earliest restore point in time for point in time restore. </param>
        /// <param name="restorePointInTime"> Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="defaultSecondaryLocation"> Geo paired region. </param>
        /// <param name="catalogCollation"> Collation of the metadata catalog. </param>
        /// <param name="createMode"> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </param>
        /// <param name="storageContainerUri"> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored. </param>
        /// <param name="sourceDatabaseId"> The resource identifier of the source database associated with create operation of this database. </param>
        /// <param name="crossSubscriptionSourceDatabaseId"> The resource identifier of the cross-subscription source database associated with create operation of this database. </param>
        /// <param name="restorableDroppedDatabaseId"> The restorable dropped database resource id to restore when creating this database. </param>
        /// <param name="crossSubscriptionRestorableDroppedDatabaseId"> The restorable cross-subscription dropped database resource id to restore when creating this database. </param>
        /// <param name="storageContainerIdentity"> Conditional. If createMode is RestoreExternalBackup, this value is used. Specifies the identity used for storage container authentication. Can be 'SharedAccessSignature' or 'ManagedIdentity'; if not specified 'SharedAccessSignature' is assumed. </param>
        /// <param name="storageContainerSasToken"> Conditional. If createMode is RestoreExternalBackup and storageContainerIdentity is not ManagedIdentity, this value is required. Specifies the storage container sas token. </param>
        /// <param name="failoverGroupId"> Instance Failover Group resource identifier that this managed database belongs to. </param>
        /// <param name="recoverableDatabaseId"> The resource identifier of the recoverable database associated with create operation of this database. </param>
        /// <param name="longTermRetentionBackupResourceId"> The name of the Long Term Retention backup to be used for restore of this managed database. </param>
        /// <param name="allowAutoCompleteRestore"> Whether to auto complete restore of this managed database. </param>
        /// <param name="lastBackupName"> Last backup file name for restore of this managed database. </param>
        /// <param name="crossSubscriptionTargetManagedInstanceId"> Target managed instance id used in cross-subscription restore. </param>
        /// <param name="isLedgerOn"> Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedDatabasePatch(IDictionary<string, string> tags, string collation, ManagedDatabaseStatus? status, DateTimeOffset? createdOn, DateTimeOffset? earliestRestorePoint, DateTimeOffset? restorePointInTime, AzureLocation? defaultSecondaryLocation, CatalogCollationType? catalogCollation, ManagedDatabaseCreateMode? createMode, Uri storageContainerUri, ResourceIdentifier sourceDatabaseId, ResourceIdentifier crossSubscriptionSourceDatabaseId, ResourceIdentifier restorableDroppedDatabaseId, ResourceIdentifier crossSubscriptionRestorableDroppedDatabaseId, string storageContainerIdentity, string storageContainerSasToken, ResourceIdentifier failoverGroupId, ResourceIdentifier recoverableDatabaseId, ResourceIdentifier longTermRetentionBackupResourceId, bool? allowAutoCompleteRestore, string lastBackupName, ResourceIdentifier crossSubscriptionTargetManagedInstanceId, bool? isLedgerOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Collation = collation;
            Status = status;
            CreatedOn = createdOn;
            EarliestRestorePoint = earliestRestorePoint;
            RestorePointInTime = restorePointInTime;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            CatalogCollation = catalogCollation;
            CreateMode = createMode;
            StorageContainerUri = storageContainerUri;
            SourceDatabaseId = sourceDatabaseId;
            CrossSubscriptionSourceDatabaseId = crossSubscriptionSourceDatabaseId;
            RestorableDroppedDatabaseId = restorableDroppedDatabaseId;
            CrossSubscriptionRestorableDroppedDatabaseId = crossSubscriptionRestorableDroppedDatabaseId;
            StorageContainerIdentity = storageContainerIdentity;
            StorageContainerSasToken = storageContainerSasToken;
            FailoverGroupId = failoverGroupId;
            RecoverableDatabaseId = recoverableDatabaseId;
            LongTermRetentionBackupResourceId = longTermRetentionBackupResourceId;
            AllowAutoCompleteRestore = allowAutoCompleteRestore;
            LastBackupName = lastBackupName;
            CrossSubscriptionTargetManagedInstanceId = crossSubscriptionTargetManagedInstanceId;
            IsLedgerOn = isLedgerOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Collation of the managed database. </summary>
        public string Collation { get; set; }
        /// <summary> Status of the database. </summary>
        public ManagedDatabaseStatus? Status { get; }
        /// <summary> Creation date of the database. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Earliest restore point in time for point in time restore. </summary>
        public DateTimeOffset? EarliestRestorePoint { get; }
        /// <summary> Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </summary>
        public DateTimeOffset? RestorePointInTime { get; set; }
        /// <summary> Geo paired region. </summary>
        public AzureLocation? DefaultSecondaryLocation { get; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </summary>
        public ManagedDatabaseCreateMode? CreateMode { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored. </summary>
        public Uri StorageContainerUri { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public ResourceIdentifier SourceDatabaseId { get; set; }
        /// <summary> The resource identifier of the cross-subscription source database associated with create operation of this database. </summary>
        public ResourceIdentifier CrossSubscriptionSourceDatabaseId { get; set; }
        /// <summary> The restorable dropped database resource id to restore when creating this database. </summary>
        public ResourceIdentifier RestorableDroppedDatabaseId { get; set; }
        /// <summary> The restorable cross-subscription dropped database resource id to restore when creating this database. </summary>
        public ResourceIdentifier CrossSubscriptionRestorableDroppedDatabaseId { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is used. Specifies the identity used for storage container authentication. Can be 'SharedAccessSignature' or 'ManagedIdentity'; if not specified 'SharedAccessSignature' is assumed. </summary>
        public string StorageContainerIdentity { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup and storageContainerIdentity is not ManagedIdentity, this value is required. Specifies the storage container sas token. </summary>
        public string StorageContainerSasToken { get; set; }
        /// <summary> Instance Failover Group resource identifier that this managed database belongs to. </summary>
        public ResourceIdentifier FailoverGroupId { get; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public ResourceIdentifier RecoverableDatabaseId { get; set; }
        /// <summary> The name of the Long Term Retention backup to be used for restore of this managed database. </summary>
        public ResourceIdentifier LongTermRetentionBackupResourceId { get; set; }
        /// <summary> Whether to auto complete restore of this managed database. </summary>
        public bool? AllowAutoCompleteRestore { get; set; }
        /// <summary> Last backup file name for restore of this managed database. </summary>
        public string LastBackupName { get; set; }
        /// <summary> Target managed instance id used in cross-subscription restore. </summary>
        public ResourceIdentifier CrossSubscriptionTargetManagedInstanceId { get; set; }
        /// <summary> Whether or not this database is a ledger database, which means all tables in the database are ledger tables. Note: the value of this property cannot be changed after the database has been created. </summary>
        public bool? IsLedgerOn { get; set; }
    }
}
