// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// Open API 2.0 Specs for Azure RecoveryServices Backup service
    /// </summary>
    public partial interface IRecoveryServicesBackupClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// The subscription Id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBackupFabricsOperations.
        /// </summary>
        IBackupFabricsOperations BackupFabrics { get; }

        /// <summary>
        /// Gets the IScopedBackupPoliciesOperations.
        /// </summary>
        IScopedBackupPoliciesOperations ScopedBackupPolicies { get; }

        /// <summary>
        /// Gets the IScopedProtectionPoliciesOperations.
        /// </summary>
        IScopedProtectionPoliciesOperations ScopedProtectionPolicies { get; }

        /// <summary>
        /// Gets the IScopedProtectionPolicyOperationResultsOperations.
        /// </summary>
        IScopedProtectionPolicyOperationResultsOperations ScopedProtectionPolicyOperationResults { get; }

        /// <summary>
        /// Gets the IScopedProtectionPolicyOperationStatusesOperations.
        /// </summary>
        IScopedProtectionPolicyOperationStatusesOperations ScopedProtectionPolicyOperationStatuses { get; }

        /// <summary>
        /// Gets the IBackupProtectionContainersInFabricOperations.
        /// </summary>
        IBackupProtectionContainersInFabricOperations BackupProtectionContainersInFabric { get; }

        /// <summary>
        /// Gets the IBackupProtectedItemsInContainerOperations.
        /// </summary>
        IBackupProtectedItemsInContainerOperations BackupProtectedItemsInContainer { get; }

        /// <summary>
        /// Gets the IProtectionContainersOperations.
        /// </summary>
        IProtectionContainersOperations ProtectionContainers { get; }

        /// <summary>
        /// Gets the IProtectionIntentOperations.
        /// </summary>
        IProtectionIntentOperations ProtectionIntent { get; }

        /// <summary>
        /// Gets the IBackupStatusOperations.
        /// </summary>
        IBackupStatusOperations BackupStatus { get; }

        /// <summary>
        /// Gets the IFeatureSupportOperations.
        /// </summary>
        IFeatureSupportOperations FeatureSupport { get; }

        /// <summary>
        /// Gets the IBackupJobsOperations.
        /// </summary>
        IBackupJobsOperations BackupJobs { get; }

        /// <summary>
        /// Gets the IJobDetailsOperations.
        /// </summary>
        IJobDetailsOperations JobDetails { get; }

        /// <summary>
        /// Gets the IExportJobsOperationResultsOperations.
        /// </summary>
        IExportJobsOperationResultsOperations ExportJobsOperationResults { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the IBackupPoliciesOperations.
        /// </summary>
        IBackupPoliciesOperations BackupPolicies { get; }

        /// <summary>
        /// Gets the IBackupProtectedItemsOperations.
        /// </summary>
        IBackupProtectedItemsOperations BackupProtectedItems { get; }

        /// <summary>
        /// Gets the IBackupProtectionIntentOperations.
        /// </summary>
        IBackupProtectionIntentOperations BackupProtectionIntent { get; }

        /// <summary>
        /// Gets the IBackupUsageSummariesOperations.
        /// </summary>
        IBackupUsageSummariesOperations BackupUsageSummaries { get; }

        /// <summary>
        /// Gets the IOperationOperations.
        /// </summary>
        IOperationOperations Operation { get; }

        /// <summary>
        /// Gets the IBackupResourceVaultConfigsOperations.
        /// </summary>
        IBackupResourceVaultConfigsOperations BackupResourceVaultConfigs { get; }

        /// <summary>
        /// Gets the IBackupEnginesOperations.
        /// </summary>
        IBackupEnginesOperations BackupEngines { get; }

        /// <summary>
        /// Gets the IProtectionContainerRefreshOperationResultsOperations.
        /// </summary>
        IProtectionContainerRefreshOperationResultsOperations ProtectionContainerRefreshOperationResults { get; }

        /// <summary>
        /// Gets the IProtectableContainersOperations.
        /// </summary>
        IProtectableContainersOperations ProtectableContainers { get; }

        /// <summary>
        /// Gets the IBackupWorkloadItemsOperations.
        /// </summary>
        IBackupWorkloadItemsOperations BackupWorkloadItems { get; }

        /// <summary>
        /// Gets the IProtectionContainerOperationResultsOperations.
        /// </summary>
        IProtectionContainerOperationResultsOperations ProtectionContainerOperationResults { get; }

        /// <summary>
        /// Gets the IProtectedItemsOperations.
        /// </summary>
        IProtectedItemsOperations ProtectedItems { get; }

        /// <summary>
        /// Gets the IBackupsOperations.
        /// </summary>
        IBackupsOperations Backups { get; }

        /// <summary>
        /// Gets the IProtectedItemOperationResultsOperations.
        /// </summary>
        IProtectedItemOperationResultsOperations ProtectedItemOperationResults { get; }

        /// <summary>
        /// Gets the IProtectedItemOperationStatusesOperations.
        /// </summary>
        IProtectedItemOperationStatusesOperations ProtectedItemOperationStatuses { get; }

        /// <summary>
        /// Gets the IRecoveryPointsOperations.
        /// </summary>
        IRecoveryPointsOperations RecoveryPoints { get; }

        /// <summary>
        /// Gets the IItemLevelRecoveryConnectionsOperations.
        /// </summary>
        IItemLevelRecoveryConnectionsOperations ItemLevelRecoveryConnections { get; }

        /// <summary>
        /// Gets the IRestoresOperations.
        /// </summary>
        IRestoresOperations Restores { get; }

        /// <summary>
        /// Gets the IJobCancellationsOperations.
        /// </summary>
        IJobCancellationsOperations JobCancellations { get; }

        /// <summary>
        /// Gets the IJobOperationResultsOperations.
        /// </summary>
        IJobOperationResultsOperations JobOperationResults { get; }

        /// <summary>
        /// Gets the IBackupOperationResultsOperations.
        /// </summary>
        IBackupOperationResultsOperations BackupOperationResults { get; }

        /// <summary>
        /// Gets the IBackupOperationStatusesOperations.
        /// </summary>
        IBackupOperationStatusesOperations BackupOperationStatuses { get; }

        /// <summary>
        /// Gets the IProtectionPoliciesOperations.
        /// </summary>
        IProtectionPoliciesOperations ProtectionPolicies { get; }

        /// <summary>
        /// Gets the IProtectionPolicyOperationResultsOperations.
        /// </summary>
        IProtectionPolicyOperationResultsOperations ProtectionPolicyOperationResults { get; }

        /// <summary>
        /// Gets the IProtectionPolicyOperationStatusesOperations.
        /// </summary>
        IProtectionPolicyOperationStatusesOperations ProtectionPolicyOperationStatuses { get; }

        /// <summary>
        /// Gets the IBackupProtectableItemsOperations.
        /// </summary>
        IBackupProtectableItemsOperations BackupProtectableItems { get; }

        /// <summary>
        /// Gets the IBackupProtectionContainersOperations.
        /// </summary>
        IBackupProtectionContainersOperations BackupProtectionContainers { get; }

        /// <summary>
        /// Gets the ISecurityPINsOperations.
        /// </summary>
        ISecurityPINsOperations SecurityPINs { get; }

        /// <summary>
        /// Gets the IBackupResourceStorageConfigsOperations.
        /// </summary>
        IBackupResourceStorageConfigsOperations BackupResourceStorageConfigs { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

    }
}
