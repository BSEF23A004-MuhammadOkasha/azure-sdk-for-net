// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// The Azure SQL Database management API provides a RESTful set of web
    /// services that interact with Azure SQL Database services to manage your
    /// databases. The API enables you to create, retrieve, update, and delete
    /// databases.
    /// </summary>
    public partial interface ISqlManagementClient : System.IDisposable
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
        /// The subscription ID that identifies an Azure subscription.
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
        /// Gets the IRecoverableDatabasesOperations.
        /// </summary>
        IRecoverableDatabasesOperations RecoverableDatabases { get; }

        /// <summary>
        /// Gets the IRestorableDroppedDatabasesOperations.
        /// </summary>
        IRestorableDroppedDatabasesOperations RestorableDroppedDatabases { get; }

        /// <summary>
        /// Gets the IServerConnectionPoliciesOperations.
        /// </summary>
        IServerConnectionPoliciesOperations ServerConnectionPolicies { get; }

        /// <summary>
        /// Gets the IDatabaseThreatDetectionPoliciesOperations.
        /// </summary>
        IDatabaseThreatDetectionPoliciesOperations DatabaseThreatDetectionPolicies { get; }

        /// <summary>
        /// Gets the IDataMaskingPoliciesOperations.
        /// </summary>
        IDataMaskingPoliciesOperations DataMaskingPolicies { get; }

        /// <summary>
        /// Gets the IDataMaskingRulesOperations.
        /// </summary>
        IDataMaskingRulesOperations DataMaskingRules { get; }

        /// <summary>
        /// Gets the IFirewallRulesOperations.
        /// </summary>
        IFirewallRulesOperations FirewallRules { get; }

        /// <summary>
        /// Gets the IGeoBackupPoliciesOperations.
        /// </summary>
        IGeoBackupPoliciesOperations GeoBackupPolicies { get; }

        /// <summary>
        /// Gets the IDatabasesOperations.
        /// </summary>
        IDatabasesOperations Databases { get; }

        /// <summary>
        /// Gets the IElasticPoolsOperations.
        /// </summary>
        IElasticPoolsOperations ElasticPools { get; }

        /// <summary>
        /// Gets the IRecommendedElasticPoolsOperations.
        /// </summary>
        IRecommendedElasticPoolsOperations RecommendedElasticPools { get; }

        /// <summary>
        /// Gets the IReplicationLinksOperations.
        /// </summary>
        IReplicationLinksOperations ReplicationLinks { get; }

        /// <summary>
        /// Gets the IServerCommunicationLinksOperations.
        /// </summary>
        IServerCommunicationLinksOperations ServerCommunicationLinks { get; }

        /// <summary>
        /// Gets the IServiceObjectivesOperations.
        /// </summary>
        IServiceObjectivesOperations ServiceObjectives { get; }

        /// <summary>
        /// Gets the IElasticPoolActivitiesOperations.
        /// </summary>
        IElasticPoolActivitiesOperations ElasticPoolActivities { get; }

        /// <summary>
        /// Gets the IElasticPoolDatabaseActivitiesOperations.
        /// </summary>
        IElasticPoolDatabaseActivitiesOperations ElasticPoolDatabaseActivities { get; }

        /// <summary>
        /// Gets the IServiceTierAdvisorsOperations.
        /// </summary>
        IServiceTierAdvisorsOperations ServiceTierAdvisors { get; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionsOperations.
        /// </summary>
        ITransparentDataEncryptionsOperations TransparentDataEncryptions { get; }

        /// <summary>
        /// Gets the ITransparentDataEncryptionActivitiesOperations.
        /// </summary>
        ITransparentDataEncryptionActivitiesOperations TransparentDataEncryptionActivities { get; }

        /// <summary>
        /// Gets the IServerUsagesOperations.
        /// </summary>
        IServerUsagesOperations ServerUsages { get; }

        /// <summary>
        /// Gets the IDatabaseUsagesOperations.
        /// </summary>
        IDatabaseUsagesOperations DatabaseUsages { get; }

        /// <summary>
        /// Gets the IDatabaseAutomaticTuningOperations.
        /// </summary>
        IDatabaseAutomaticTuningOperations DatabaseAutomaticTuning { get; }

        /// <summary>
        /// Gets the IEncryptionProtectorsOperations.
        /// </summary>
        IEncryptionProtectorsOperations EncryptionProtectors { get; }

        /// <summary>
        /// Gets the IFailoverGroupsOperations.
        /// </summary>
        IFailoverGroupsOperations FailoverGroups { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the IServerKeysOperations.
        /// </summary>
        IServerKeysOperations ServerKeys { get; }

        /// <summary>
        /// Gets the ISyncAgentsOperations.
        /// </summary>
        ISyncAgentsOperations SyncAgents { get; }

        /// <summary>
        /// Gets the ISubscriptionUsagesOperations.
        /// </summary>
        ISubscriptionUsagesOperations SubscriptionUsages { get; }

        /// <summary>
        /// Gets the IVirtualClustersOperations.
        /// </summary>
        IVirtualClustersOperations VirtualClusters { get; }

        /// <summary>
        /// Gets the IVirtualNetworkRulesOperations.
        /// </summary>
        IVirtualNetworkRulesOperations VirtualNetworkRules { get; }

        /// <summary>
        /// Gets the IExtendedDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        IExtendedDatabaseBlobAuditingPoliciesOperations ExtendedDatabaseBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IExtendedServerBlobAuditingPoliciesOperations.
        /// </summary>
        IExtendedServerBlobAuditingPoliciesOperations ExtendedServerBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IServerBlobAuditingPoliciesOperations.
        /// </summary>
        IServerBlobAuditingPoliciesOperations ServerBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IDatabaseBlobAuditingPoliciesOperations.
        /// </summary>
        IDatabaseBlobAuditingPoliciesOperations DatabaseBlobAuditingPolicies { get; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        IDatabaseVulnerabilityAssessmentRuleBaselinesOperations DatabaseVulnerabilityAssessmentRuleBaselines { get; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        IDatabaseVulnerabilityAssessmentsOperations DatabaseVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the IJobAgentsOperations.
        /// </summary>
        IJobAgentsOperations JobAgents { get; }

        /// <summary>
        /// Gets the IJobCredentialsOperations.
        /// </summary>
        IJobCredentialsOperations JobCredentials { get; }

        /// <summary>
        /// Gets the IJobExecutionsOperations.
        /// </summary>
        IJobExecutionsOperations JobExecutions { get; }

        /// <summary>
        /// Gets the IJobsOperations.
        /// </summary>
        IJobsOperations Jobs { get; }

        /// <summary>
        /// Gets the IJobStepExecutionsOperations.
        /// </summary>
        IJobStepExecutionsOperations JobStepExecutions { get; }

        /// <summary>
        /// Gets the IJobStepsOperations.
        /// </summary>
        IJobStepsOperations JobSteps { get; }

        /// <summary>
        /// Gets the IJobTargetExecutionsOperations.
        /// </summary>
        IJobTargetExecutionsOperations JobTargetExecutions { get; }

        /// <summary>
        /// Gets the IJobTargetGroupsOperations.
        /// </summary>
        IJobTargetGroupsOperations JobTargetGroups { get; }

        /// <summary>
        /// Gets the IJobVersionsOperations.
        /// </summary>
        IJobVersionsOperations JobVersions { get; }

        /// <summary>
        /// Gets the ILongTermRetentionBackupsOperations.
        /// </summary>
        ILongTermRetentionBackupsOperations LongTermRetentionBackups { get; }

        /// <summary>
        /// Gets the IBackupLongTermRetentionPoliciesOperations.
        /// </summary>
        IBackupLongTermRetentionPoliciesOperations BackupLongTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IManagedBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        IManagedBackupShortTermRetentionPoliciesOperations ManagedBackupShortTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        IManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesOperations ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IServerAutomaticTuningOperations.
        /// </summary>
        IServerAutomaticTuningOperations ServerAutomaticTuning { get; }

        /// <summary>
        /// Gets the IServerDnsAliasesOperations.
        /// </summary>
        IServerDnsAliasesOperations ServerDnsAliases { get; }

        /// <summary>
        /// Gets the IServerSecurityAlertPoliciesOperations.
        /// </summary>
        IServerSecurityAlertPoliciesOperations ServerSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the IRestorableDroppedManagedDatabasesOperations.
        /// </summary>
        IRestorableDroppedManagedDatabasesOperations RestorableDroppedManagedDatabases { get; }

        /// <summary>
        /// Gets the IRestorePointsOperations.
        /// </summary>
        IRestorePointsOperations RestorePoints { get; }

        /// <summary>
        /// Gets the IManagedDatabaseSecurityAlertPoliciesOperations.
        /// </summary>
        IManagedDatabaseSecurityAlertPoliciesOperations ManagedDatabaseSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the IManagedServerSecurityAlertPoliciesOperations.
        /// </summary>
        IManagedServerSecurityAlertPoliciesOperations ManagedServerSecurityAlertPolicies { get; }

        /// <summary>
        /// Gets the ISensitivityLabelsOperations.
        /// </summary>
        ISensitivityLabelsOperations SensitivityLabels { get; }

        /// <summary>
        /// Gets the IManagedInstanceAdministratorsOperations.
        /// </summary>
        IManagedInstanceAdministratorsOperations ManagedInstanceAdministrators { get; }

        /// <summary>
        /// Gets the IDatabaseOperations.
        /// </summary>
        IDatabaseOperations DatabaseOperations { get; }

        /// <summary>
        /// Gets the IElasticPoolOperations.
        /// </summary>
        IElasticPoolOperations ElasticPoolOperations { get; }

        /// <summary>
        /// Gets the IDatabaseVulnerabilityAssessmentScansOperations.
        /// </summary>
        IDatabaseVulnerabilityAssessmentScansOperations DatabaseVulnerabilityAssessmentScans { get; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentRuleBaselinesOperations.
        /// </summary>
        IManagedDatabaseVulnerabilityAssessmentRuleBaselinesOperations ManagedDatabaseVulnerabilityAssessmentRuleBaselines { get; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentScansOperations.
        /// </summary>
        IManagedDatabaseVulnerabilityAssessmentScansOperations ManagedDatabaseVulnerabilityAssessmentScans { get; }

        /// <summary>
        /// Gets the IManagedDatabaseVulnerabilityAssessmentsOperations.
        /// </summary>
        IManagedDatabaseVulnerabilityAssessmentsOperations ManagedDatabaseVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the IInstanceFailoverGroupsOperations.
        /// </summary>
        IInstanceFailoverGroupsOperations InstanceFailoverGroups { get; }

        /// <summary>
        /// Gets the ITdeCertificatesOperations.
        /// </summary>
        ITdeCertificatesOperations TdeCertificates { get; }

        /// <summary>
        /// Gets the IManagedInstanceTdeCertificatesOperations.
        /// </summary>
        IManagedInstanceTdeCertificatesOperations ManagedInstanceTdeCertificates { get; }

        /// <summary>
        /// Gets the IManagedInstanceKeysOperations.
        /// </summary>
        IManagedInstanceKeysOperations ManagedInstanceKeys { get; }

        /// <summary>
        /// Gets the IManagedInstanceEncryptionProtectorsOperations.
        /// </summary>
        IManagedInstanceEncryptionProtectorsOperations ManagedInstanceEncryptionProtectors { get; }

        /// <summary>
        /// Gets the IRecoverableManagedDatabasesOperations.
        /// </summary>
        IRecoverableManagedDatabasesOperations RecoverableManagedDatabases { get; }

        /// <summary>
        /// Gets the IManagedInstanceVulnerabilityAssessmentsOperations.
        /// </summary>
        IManagedInstanceVulnerabilityAssessmentsOperations ManagedInstanceVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the IServerVulnerabilityAssessmentsOperations.
        /// </summary>
        IServerVulnerabilityAssessmentsOperations ServerVulnerabilityAssessments { get; }

        /// <summary>
        /// Gets the IManagedDatabaseSensitivityLabelsOperations.
        /// </summary>
        IManagedDatabaseSensitivityLabelsOperations ManagedDatabaseSensitivityLabels { get; }

        /// <summary>
        /// Gets the IInstancePoolsOperations.
        /// </summary>
        IInstancePoolsOperations InstancePools { get; }

        /// <summary>
        /// Gets the IUsagesOperations.
        /// </summary>
        IUsagesOperations Usages { get; }

        /// <summary>
        /// Gets the IPrivateEndpointConnectionsOperations.
        /// </summary>
        IPrivateEndpointConnectionsOperations PrivateEndpointConnections { get; }

        /// <summary>
        /// Gets the IPrivateLinkResourcesOperations.
        /// </summary>
        IPrivateLinkResourcesOperations PrivateLinkResources { get; }

        /// <summary>
        /// Gets the IServersOperations.
        /// </summary>
        IServersOperations Servers { get; }

        /// <summary>
        /// Gets the ICapabilitiesOperations.
        /// </summary>
        ICapabilitiesOperations Capabilities { get; }

        /// <summary>
        /// Gets the ILongTermRetentionManagedInstanceBackupsOperations.
        /// </summary>
        ILongTermRetentionManagedInstanceBackupsOperations LongTermRetentionManagedInstanceBackups { get; }

        /// <summary>
        /// Gets the IManagedInstanceLongTermRetentionPoliciesOperations.
        /// </summary>
        IManagedInstanceLongTermRetentionPoliciesOperations ManagedInstanceLongTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IWorkloadGroupsOperations.
        /// </summary>
        IWorkloadGroupsOperations WorkloadGroups { get; }

        /// <summary>
        /// Gets the IWorkloadClassifiersOperations.
        /// </summary>
        IWorkloadClassifiersOperations WorkloadClassifiers { get; }

        /// <summary>
        /// Gets the IManagedInstanceOperations.
        /// </summary>
        IManagedInstanceOperations ManagedInstanceOperations { get; }

        /// <summary>
        /// Gets the IServerAzureADAdministratorsOperations.
        /// </summary>
        IServerAzureADAdministratorsOperations ServerAzureADAdministrators { get; }

        /// <summary>
        /// Gets the ISyncGroupsOperations.
        /// </summary>
        ISyncGroupsOperations SyncGroups { get; }

        /// <summary>
        /// Gets the ISyncMembersOperations.
        /// </summary>
        ISyncMembersOperations SyncMembers { get; }

        /// <summary>
        /// Gets the IManagedInstancesOperations.
        /// </summary>
        IManagedInstancesOperations ManagedInstances { get; }

        /// <summary>
        /// Gets the IBackupShortTermRetentionPoliciesOperations.
        /// </summary>
        IBackupShortTermRetentionPoliciesOperations BackupShortTermRetentionPolicies { get; }

        /// <summary>
        /// Gets the IManagedDatabaseRestoreDetailsOperations.
        /// </summary>
        IManagedDatabaseRestoreDetailsOperations ManagedDatabaseRestoreDetails { get; }

        /// <summary>
        /// Gets the IManagedDatabasesOperations.
        /// </summary>
        IManagedDatabasesOperations ManagedDatabases { get; }

        /// <summary>
        /// Gets the IServerAzureADOnlyAuthenticationsOperations.
        /// </summary>
        IServerAzureADOnlyAuthenticationsOperations ServerAzureADOnlyAuthentications { get; }

        /// <summary>
        /// Gets the IImportExportOperations.
        /// </summary>
        IImportExportOperations ImportExport { get; }

        /// <summary>
        /// Gets the IManagedInstanceAzureADOnlyAuthenticationsOperations.
        /// </summary>
        IManagedInstanceAzureADOnlyAuthenticationsOperations ManagedInstanceAzureADOnlyAuthentications { get; }

        /// <summary>
        /// Gets the IServerTrustGroupsOperations.
        /// </summary>
        IServerTrustGroupsOperations ServerTrustGroups { get; }

        /// <summary>
        /// Gets the IServerDevOpsAuditPoliciesOperations.
        /// </summary>
        IServerDevOpsAuditPoliciesOperations ServerDevOpsAuditPolicies { get; }

    }
}
