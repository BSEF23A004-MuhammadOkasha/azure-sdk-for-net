// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmServiceBusModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusNamespaceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of SKU. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="minimumTlsVersion"> The minimum TLS version for the cluster to support, e.g. '1.2'. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace. </param>
        /// <param name="status"> Status of the namespace. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="isZoneRedundant"> Enabling this property creates a Premium Service Bus Namespace in regions supported availability zones. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Service Bus namespace. </param>
        /// <param name="alternateName"> Alternate name for namespace. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="premiumMessagingPartitions"> The number of partitions of a Service Bus namespace. This property is only applicable to Premium SKU namespaces. The default value is 1 and possible values are 1, 2 and 4. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusNamespaceData"/> instance for mocking. </returns>
        public static ServiceBusNamespaceData ServiceBusNamespaceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ServiceBusSku sku = null, ManagedServiceIdentity identity = null, ServiceBusMinimumTlsVersion? minimumTlsVersion = null, string provisioningState = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, string serviceBusEndpoint = null, string metricId = null, bool? isZoneRedundant = null, ServiceBusEncryption encryption = null, IEnumerable<ServiceBusPrivateEndpointConnectionData> privateEndpointConnections = null, bool? disableLocalAuth = null, string alternateName = null, ServiceBusPublicNetworkAccess? publicNetworkAccess = null, int? premiumMessagingPartitions = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<ServiceBusPrivateEndpointConnectionData>();

            return new ServiceBusNamespaceData(id, name, resourceType, systemData, tags, location, sku, identity, minimumTlsVersion, provisioningState, status, createdOn, updatedOn, serviceBusEndpoint, metricId, isZoneRedundant, encryption, privateEndpointConnections?.ToList(), disableLocalAuth, alternateName, publicNetworkAccess, premiumMessagingPartitions, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusPrivateEndpointConnectionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> The Private Endpoint resource for this Connection. </param>
        /// <param name="connectionState"> Details about the state of the connection. </param>
        /// <param name="provisioningState"> Provisioning state of the Private Endpoint Connection. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static ServiceBusPrivateEndpointConnectionData ServiceBusPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, ServiceBusPrivateLinkServiceConnectionState connectionState = null, ServiceBusPrivateEndpointConnectionProvisioningState? provisioningState = null, AzureLocation? location = null)
        {
            return new ServiceBusPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceBusNamespacePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> Properties of SKU. </param>
        /// <param name="identity"> Properties of BYOK Identity description. </param>
        /// <param name="provisioningState"> Provisioning state of the namespace. </param>
        /// <param name="status"> Status of the namespace. </param>
        /// <param name="createdOn"> The time the namespace was created. </param>
        /// <param name="updatedOn"> The time the namespace was updated. </param>
        /// <param name="serviceBusEndpoint"> Endpoint you can use to perform Service Bus operations. </param>
        /// <param name="metricId"> Identifier for Azure Insights metrics. </param>
        /// <param name="encryption"> Properties of BYOK Encryption description. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections. </param>
        /// <param name="disableLocalAuth"> This property disables SAS authentication for the Service Bus namespace. </param>
        /// <param name="alternateName"> Alternate name for namespace. </param>
        /// <returns> A new <see cref="Models.ServiceBusNamespacePatch"/> instance for mocking. </returns>
        public static ServiceBusNamespacePatch ServiceBusNamespacePatch(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ServiceBusSku sku = null, ManagedServiceIdentity identity = null, string provisioningState = null, string status = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, string serviceBusEndpoint = null, string metricId = null, ServiceBusEncryption encryption = null, IEnumerable<ServiceBusPrivateEndpointConnectionData> privateEndpointConnections = null, bool? disableLocalAuth = null, string alternateName = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<ServiceBusPrivateEndpointConnectionData>();

            return new ServiceBusNamespacePatch(id, name, resourceType, systemData, tags, location, sku, identity, provisioningState, status, createdOn, updatedOn, serviceBusEndpoint, metricId, encryption, privateEndpointConnections?.ToList(), disableLocalAuth, alternateName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceBusPrivateLinkResource"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="groupId"></param>
        /// <param name="requiredMembers"> Required Members. </param>
        /// <param name="requiredZoneNames"> Required Zone Names. </param>
        /// <returns> A new <see cref="Models.ServiceBusPrivateLinkResource"/> instance for mocking. </returns>
        public static ServiceBusPrivateLinkResource ServiceBusPrivateLinkResource(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string groupId = null, IEnumerable<string> requiredMembers = null, IEnumerable<string> requiredZoneNames = null)
        {
            requiredMembers ??= new List<string>();
            requiredZoneNames ??= new List<string>();

            return new ServiceBusPrivateLinkResource(id, name, resourceType, systemData, groupId, requiredMembers?.ToList(), requiredZoneNames?.ToList(), serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusDisasterRecoveryData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of the Alias(Disaster Recovery configuration) - possible values 'Accepted' or 'Succeeded' or 'Failed'. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="partnerNamespace"> ARM Id of the Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="alternateName"> Primary/Secondary eventhub namespace name, which is part of GEO DR pairing. </param>
        /// <param name="role"> role of namespace in GEO DR - possible values 'Primary' or 'PrimaryNotReplicating' or 'Secondary'. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusDisasterRecoveryData"/> instance for mocking. </returns>
        public static ServiceBusDisasterRecoveryData ServiceBusDisasterRecoveryData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ServiceBusDisasterRecoveryProvisioningState? provisioningState = null, long? pendingReplicationOperationsCount = null, string partnerNamespace = null, string alternateName = null, ServiceBusDisasterRecoveryRole? role = null, AzureLocation? location = null)
        {
            return new ServiceBusDisasterRecoveryData(id, name, resourceType, systemData, provisioningState, pendingReplicationOperationsCount, partnerNamespace, alternateName, role, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.MigrationConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning state of Migration Configuration. </param>
        /// <param name="pendingReplicationOperationsCount"> Number of entities pending to be replicated. </param>
        /// <param name="targetServiceBusNamespace"> Existing premium Namespace ARM Id name which has no entities, will be used for migration. </param>
        /// <param name="postMigrationName"> Name to access Standard Namespace after migration. </param>
        /// <param name="migrationState"> State in which Standard to Premium Migration is, possible values : Unknown, Reverting, Completing, Initiating, Syncing, Active. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.MigrationConfigurationData"/> instance for mocking. </returns>
        public static MigrationConfigurationData MigrationConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string provisioningState = null, long? pendingReplicationOperationsCount = null, ResourceIdentifier targetServiceBusNamespace = null, string postMigrationName = null, string migrationState = null, AzureLocation? location = null)
        {
            return new MigrationConfigurationData(id, name, resourceType, systemData, provisioningState, pendingReplicationOperationsCount, targetServiceBusNamespace, postMigrationName, migrationState, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusNetworkRuleSetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="isTrustedServiceAccessEnabled"> Value that indicates whether Trusted Service Access is Enabled or not. </param>
        /// <param name="defaultAction"> Default Action for Network Rule Set. </param>
        /// <param name="virtualNetworkRules"> List VirtualNetwork Rules. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="publicNetworkAccess"> This determines if traffic is allowed over public network. By default it is enabled. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusNetworkRuleSetData"/> instance for mocking. </returns>
        public static ServiceBusNetworkRuleSetData ServiceBusNetworkRuleSetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, bool? isTrustedServiceAccessEnabled = null, ServiceBusNetworkRuleSetDefaultAction? defaultAction = null, IEnumerable<ServiceBusNetworkRuleSetVirtualNetworkRules> virtualNetworkRules = null, IEnumerable<ServiceBusNetworkRuleSetIPRules> ipRules = null, ServiceBusPublicNetworkAccessFlag? publicNetworkAccess = null, AzureLocation? location = null)
        {
            virtualNetworkRules ??= new List<ServiceBusNetworkRuleSetVirtualNetworkRules>();
            ipRules ??= new List<ServiceBusNetworkRuleSetIPRules>();

            return new ServiceBusNetworkRuleSetData(id, name, resourceType, systemData, isTrustedServiceAccessEnabled, defaultAction, virtualNetworkRules?.ToList(), ipRules?.ToList(), publicNetworkAccess, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusAuthorizationRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="rights"> The rights associated with the rule. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusAuthorizationRuleData"/> instance for mocking. </returns>
        public static ServiceBusAuthorizationRuleData ServiceBusAuthorizationRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IEnumerable<ServiceBusAccessRight> rights = null, AzureLocation? location = null)
        {
            rights ??= new List<ServiceBusAccessRight>();

            return new ServiceBusAuthorizationRuleData(id, name, resourceType, systemData, rights?.ToList(), location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceBusAccessKeys"/>. </summary>
        /// <param name="primaryConnectionString"> Primary connection string of the created namespace authorization rule. </param>
        /// <param name="secondaryConnectionString"> Secondary connection string of the created namespace authorization rule. </param>
        /// <param name="aliasPrimaryConnectionString"> Primary connection string of the alias if GEO DR is enabled. </param>
        /// <param name="aliasSecondaryConnectionString"> Secondary  connection string of the alias if GEO DR is enabled. </param>
        /// <param name="primaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="secondaryKey"> A base64-encoded 256-bit primary key for signing and validating the SAS token. </param>
        /// <param name="keyName"> A string that describes the authorization rule. </param>
        /// <returns> A new <see cref="Models.ServiceBusAccessKeys"/> instance for mocking. </returns>
        public static ServiceBusAccessKeys ServiceBusAccessKeys(string primaryConnectionString = null, string secondaryConnectionString = null, string aliasPrimaryConnectionString = null, string aliasSecondaryConnectionString = null, string primaryKey = null, string secondaryKey = null, string keyName = null)
        {
            return new ServiceBusAccessKeys(primaryConnectionString, secondaryConnectionString, aliasPrimaryConnectionString, aliasSecondaryConnectionString, primaryKey, secondaryKey, keyName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceBusRegenerateAccessKeyContent"/>. </summary>
        /// <param name="keyType"> The access key to regenerate. </param>
        /// <param name="key"> Optional, if the key value provided, is reset for KeyType value or autogenerate Key value set for keyType. </param>
        /// <returns> A new <see cref="Models.ServiceBusRegenerateAccessKeyContent"/> instance for mocking. </returns>
        public static ServiceBusRegenerateAccessKeyContent ServiceBusRegenerateAccessKeyContent(ServiceBusAccessKeyType keyType = default, string key = null)
        {
            return new ServiceBusRegenerateAccessKeyContent(keyType, key, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusQueueData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="countDetails"> Message Count Details. </param>
        /// <param name="createdOn"> The exact time the message was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="accessedOn"> Last time a message was sent, or the last time there was a receive request to this queue. </param>
        /// <param name="sizeInBytes"> The size of the queue, in bytes. </param>
        /// <param name="messageCount"> The number of messages in the queue. </param>
        /// <param name="lockDuration"> ISO 8601 timespan duration of a peek-lock; that is, the amount of time that the message is locked for other receivers. The maximum value for LockDuration is 5 minutes; the default value is 1 minute. </param>
        /// <param name="maxSizeInMegabytes"> The maximum size of the queue in megabytes, which is the size of memory allocated for the queue. Default is 1024. </param>
        /// <param name="maxMessageSizeInKilobytes"> Maximum size (in KB) of the message payload that can be accepted by the queue. This property is only used in Premium today and default is 1024. </param>
        /// <param name="requiresDuplicateDetection"> A value indicating if this queue requires duplicate detection. </param>
        /// <param name="requiresSession"> A value that indicates whether the queue supports the concept of sessions. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8601 default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="deadLetteringOnMessageExpiration"> A value that indicates whether this queue has dead letter support when a message expires. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="maxDeliveryCount"> The maximum delivery count. A message is automatically deadlettered after this number of deliveries. default value is 10. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8061 timeSpan idle interval after which the queue is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="enablePartitioning"> A value that indicates whether the queue is to be partitioned across multiple message brokers. </param>
        /// <param name="enableExpress"> A value that indicates whether Express Entities are enabled. An express queue holds a message in memory temporarily before writing it to persistent storage. </param>
        /// <param name="forwardTo"> Queue/Topic name to forward the messages. </param>
        /// <param name="forwardDeadLetteredMessagesTo"> Queue/Topic name to forward the Dead Letter message. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusQueueData"/> instance for mocking. </returns>
        public static ServiceBusQueueData ServiceBusQueueData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MessageCountDetails countDetails = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, DateTimeOffset? accessedOn = null, long? sizeInBytes = null, long? messageCount = null, TimeSpan? lockDuration = null, int? maxSizeInMegabytes = null, long? maxMessageSizeInKilobytes = null, bool? requiresDuplicateDetection = null, bool? requiresSession = null, TimeSpan? defaultMessageTimeToLive = null, bool? deadLetteringOnMessageExpiration = null, TimeSpan? duplicateDetectionHistoryTimeWindow = null, int? maxDeliveryCount = null, ServiceBusMessagingEntityStatus? status = null, bool? enableBatchedOperations = null, TimeSpan? autoDeleteOnIdle = null, bool? enablePartitioning = null, bool? enableExpress = null, string forwardTo = null, string forwardDeadLetteredMessagesTo = null, AzureLocation? location = null)
        {
            return new ServiceBusQueueData(id, name, resourceType, systemData, countDetails, createdOn, updatedOn, accessedOn, sizeInBytes, messageCount, lockDuration, maxSizeInMegabytes, maxMessageSizeInKilobytes, requiresDuplicateDetection, requiresSession, defaultMessageTimeToLive, deadLetteringOnMessageExpiration, duplicateDetectionHistoryTimeWindow, maxDeliveryCount, status, enableBatchedOperations, autoDeleteOnIdle, enablePartitioning, enableExpress, forwardTo, forwardDeadLetteredMessagesTo, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.MessageCountDetails"/>. </summary>
        /// <param name="activeMessageCount"> Number of active messages in the queue, topic, or subscription. </param>
        /// <param name="deadLetterMessageCount"> Number of messages that are dead lettered. </param>
        /// <param name="scheduledMessageCount"> Number of scheduled messages. </param>
        /// <param name="transferMessageCount"> Number of messages transferred to another queue, topic, or subscription. </param>
        /// <param name="transferDeadLetterMessageCount"> Number of messages transferred into dead letters. </param>
        /// <returns> A new <see cref="Models.MessageCountDetails"/> instance for mocking. </returns>
        public static MessageCountDetails MessageCountDetails(long? activeMessageCount = null, long? deadLetterMessageCount = null, long? scheduledMessageCount = null, long? transferMessageCount = null, long? transferDeadLetterMessageCount = null)
        {
            return new MessageCountDetails(activeMessageCount, deadLetterMessageCount, scheduledMessageCount, transferMessageCount, transferDeadLetterMessageCount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusTopicData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInBytes"> Size of the topic, in bytes. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="accessedOn"> Last time the message was sent, or a request was received, for this topic. </param>
        /// <param name="subscriptionCount"> Number of subscriptions. </param>
        /// <param name="countDetails"> Message count details. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8601 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="maxSizeInMegabytes"> Maximum size of the topic in megabytes, which is the size of the memory allocated for the topic. Default is 1024. </param>
        /// <param name="maxMessageSizeInKilobytes"> Maximum size (in KB) of the message payload that can be accepted by the topic. This property is only used in Premium today and default is 1024. </param>
        /// <param name="requiresDuplicateDetection"> Value indicating if this topic requires duplicate detection. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO8601 timespan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="supportOrdering"> Value that indicates whether the topic supports ordering. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8601 timespan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="enablePartitioning"> Value that indicates whether the topic to be partitioned across multiple message brokers is enabled. </param>
        /// <param name="enableExpress"> Value that indicates whether Express Entities are enabled. An express topic holds a message in memory temporarily before writing it to persistent storage. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusTopicData"/> instance for mocking. </returns>
        public static ServiceBusTopicData ServiceBusTopicData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? sizeInBytes = null, DateTimeOffset? createdOn = null, DateTimeOffset? updatedOn = null, DateTimeOffset? accessedOn = null, int? subscriptionCount = null, MessageCountDetails countDetails = null, TimeSpan? defaultMessageTimeToLive = null, int? maxSizeInMegabytes = null, long? maxMessageSizeInKilobytes = null, bool? requiresDuplicateDetection = null, TimeSpan? duplicateDetectionHistoryTimeWindow = null, bool? enableBatchedOperations = null, ServiceBusMessagingEntityStatus? status = null, bool? supportOrdering = null, TimeSpan? autoDeleteOnIdle = null, bool? enablePartitioning = null, bool? enableExpress = null, AzureLocation? location = null)
        {
            return new ServiceBusTopicData(id, name, resourceType, systemData, sizeInBytes, createdOn, updatedOn, accessedOn, subscriptionCount, countDetails, defaultMessageTimeToLive, maxSizeInMegabytes, maxMessageSizeInKilobytes, requiresDuplicateDetection, duplicateDetectionHistoryTimeWindow, enableBatchedOperations, status, supportOrdering, autoDeleteOnIdle, enablePartitioning, enableExpress, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="action"> Represents the filter actions which are allowed for the transformation of a message that have been matched by a filter expression. </param>
        /// <param name="filterType"> Filter type that is evaluated against a BrokeredMessage. </param>
        /// <param name="sqlFilter"> Properties of sqlFilter. </param>
        /// <param name="correlationFilter"> Properties of correlationFilter. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusRuleData"/> instance for mocking. </returns>
        public static ServiceBusRuleData ServiceBusRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ServiceBusFilterAction action = null, ServiceBusFilterType? filterType = null, ServiceBusSqlFilter sqlFilter = null, ServiceBusCorrelationFilter correlationFilter = null, AzureLocation? location = null)
        {
            return new ServiceBusRuleData(id, name, resourceType, systemData, action, filterType, sqlFilter, correlationFilter, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ServiceBus.ServiceBusSubscriptionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="messageCount"> Number of messages. </param>
        /// <param name="createdOn"> Exact time the message was created. </param>
        /// <param name="accessedOn"> Last time there was a receive request to this subscription. </param>
        /// <param name="updatedOn"> The exact time the message was updated. </param>
        /// <param name="countDetails"> Message count details. </param>
        /// <param name="lockDuration"> ISO 8061 lock duration timespan for the subscription. The default value is 1 minute. </param>
        /// <param name="requiresSession"> Value indicating if a subscription supports the concept of sessions. </param>
        /// <param name="defaultMessageTimeToLive"> ISO 8061 Default message timespan to live value. This is the duration after which the message expires, starting from when the message is sent to Service Bus. This is the default value used when TimeToLive is not set on a message itself. </param>
        /// <param name="deadLetteringOnFilterEvaluationExceptions"> Value that indicates whether a subscription has dead letter support on filter evaluation exceptions. </param>
        /// <param name="deadLetteringOnMessageExpiration"> Value that indicates whether a subscription has dead letter support when a message expires. </param>
        /// <param name="duplicateDetectionHistoryTimeWindow"> ISO 8601 timeSpan structure that defines the duration of the duplicate detection history. The default value is 10 minutes. </param>
        /// <param name="maxDeliveryCount"> Number of maximum deliveries. </param>
        /// <param name="status"> Enumerates the possible values for the status of a messaging entity. </param>
        /// <param name="enableBatchedOperations"> Value that indicates whether server-side batched operations are enabled. </param>
        /// <param name="autoDeleteOnIdle"> ISO 8061 timeSpan idle interval after which the topic is automatically deleted. The minimum duration is 5 minutes. </param>
        /// <param name="forwardTo"> Queue/Topic name to forward the messages. </param>
        /// <param name="forwardDeadLetteredMessagesTo"> Queue/Topic name to forward the Dead Letter message. </param>
        /// <param name="isClientAffine"> Value that indicates whether the subscription has an affinity to the client id. </param>
        /// <param name="clientAffineProperties"> Properties specific to client affine subscriptions. </param>
        /// <param name="location"> The geo-location where the resource lives. </param>
        /// <returns> A new <see cref="ServiceBus.ServiceBusSubscriptionData"/> instance for mocking. </returns>
        public static ServiceBusSubscriptionData ServiceBusSubscriptionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? messageCount = null, DateTimeOffset? createdOn = null, DateTimeOffset? accessedOn = null, DateTimeOffset? updatedOn = null, MessageCountDetails countDetails = null, TimeSpan? lockDuration = null, bool? requiresSession = null, TimeSpan? defaultMessageTimeToLive = null, bool? deadLetteringOnFilterEvaluationExceptions = null, bool? deadLetteringOnMessageExpiration = null, TimeSpan? duplicateDetectionHistoryTimeWindow = null, int? maxDeliveryCount = null, ServiceBusMessagingEntityStatus? status = null, bool? enableBatchedOperations = null, TimeSpan? autoDeleteOnIdle = null, string forwardTo = null, string forwardDeadLetteredMessagesTo = null, bool? isClientAffine = null, ServiceBusClientAffineProperties clientAffineProperties = null, AzureLocation? location = null)
        {
            return new ServiceBusSubscriptionData(id, name, resourceType, systemData, messageCount, createdOn, accessedOn, updatedOn, countDetails, lockDuration, requiresSession, defaultMessageTimeToLive, deadLetteringOnFilterEvaluationExceptions, deadLetteringOnMessageExpiration, duplicateDetectionHistoryTimeWindow, maxDeliveryCount, status, enableBatchedOperations, autoDeleteOnIdle, forwardTo, forwardDeadLetteredMessagesTo, isClientAffine, clientAffineProperties, location, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ServiceBusNameAvailabilityResult"/>. </summary>
        /// <param name="message"> The detailed info regarding the reason associated with the namespace. </param>
        /// <param name="isNameAvailable"> Value indicating namespace is availability, true if the namespace is available; otherwise, false. </param>
        /// <param name="reason"> The reason for unavailability of a namespace. </param>
        /// <returns> A new <see cref="Models.ServiceBusNameAvailabilityResult"/> instance for mocking. </returns>
        public static ServiceBusNameAvailabilityResult ServiceBusNameAvailabilityResult(string message = null, bool? isNameAvailable = null, ServiceBusNameUnavailableReason? reason = null)
        {
            return new ServiceBusNameAvailabilityResult(message, isNameAvailable, reason, serializedAdditionalRawData: null);
        }
    }
}
