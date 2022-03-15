// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Class representing an Event Grid data connection.
    /// </summary>
    [Newtonsoft.Json.JsonObject("EventGrid")]
    [Rest.Serialization.JsonTransformation]
    public partial class EventGridDataConnection : DataConnection
    {
        /// <summary>
        /// Initializes a new instance of the EventGridDataConnection class.
        /// </summary>
        public EventGridDataConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EventGridDataConnection class.
        /// </summary>
        /// <param name="storageAccountResourceId">The resource ID of the
        /// storage account where the data resides.</param>
        /// <param name="eventHubResourceId">The resource ID where the event
        /// grid is configured to send events.</param>
        /// <param name="consumerGroup">The event hub consumer group.</param>
        /// <param name="id">Fully qualified resource ID for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. E.g.
        /// "Microsoft.Compute/virtualMachines" or
        /// "Microsoft.Storage/storageAccounts"</param>
        /// <param name="location">Resource location.</param>
        /// <param name="eventGridResourceId">The resource ID of the event grid
        /// that is subscribed to the storage account events.</param>
        /// <param name="tableName">The table where the data should be
        /// ingested. Optionally the table information can be added to each
        /// message.</param>
        /// <param name="mappingRuleName">The mapping rule to be used to ingest
        /// the data. Optionally the mapping information can be added to each
        /// message.</param>
        /// <param name="dataFormat">The data format of the message. Optionally
        /// the data format can be added to each message. Possible values
        /// include: 'MULTIJSON', 'JSON', 'CSV', 'TSV', 'SCSV', 'SOHSV', 'PSV',
        /// 'TXT', 'RAW', 'SINGLEJSON', 'AVRO', 'TSVE', 'PARQUET', 'ORC',
        /// 'APACHEAVRO', 'W3CLOGFILE'</param>
        /// <param name="ignoreFirstRecord">A Boolean value that, if set to
        /// true, indicates that ingestion should ignore the first record of
        /// every file</param>
        /// <param name="blobStorageEventType">The name of blob storage event
        /// type to process. Possible values include:
        /// 'Microsoft.Storage.BlobCreated',
        /// 'Microsoft.Storage.BlobRenamed'</param>
        /// <param name="managedIdentityResourceId">The resource ID of a
        /// managed identity (system or user assigned) to be used to
        /// authenticate with event hub and storage account.</param>
        /// <param name="managedIdentityObjectId">The object ID of
        /// managedIdentityResourceId</param>
        /// <param name="databaseRouting">Indication for database routing
        /// information from the data connection, by default only database
        /// routing information is allowed. Possible values include: 'Single',
        /// 'Multi'</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed', 'Moving'</param>
        public EventGridDataConnection(string storageAccountResourceId, string eventHubResourceId, string consumerGroup, string id = default(string), string name = default(string), string type = default(string), string location = default(string), string eventGridResourceId = default(string), string tableName = default(string), string mappingRuleName = default(string), string dataFormat = default(string), bool? ignoreFirstRecord = default(bool?), string blobStorageEventType = default(string), string managedIdentityResourceId = default(string), string managedIdentityObjectId = default(string), string databaseRouting = default(string), string provisioningState = default(string))
            : base(id, name, type, location)
        {
            StorageAccountResourceId = storageAccountResourceId;
            EventGridResourceId = eventGridResourceId;
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            IgnoreFirstRecord = ignoreFirstRecord;
            BlobStorageEventType = blobStorageEventType;
            ManagedIdentityResourceId = managedIdentityResourceId;
            ManagedIdentityObjectId = managedIdentityObjectId;
            DatabaseRouting = databaseRouting;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource ID of the storage account where the data
        /// resides.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageAccountResourceId")]
        public string StorageAccountResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of the event grid that is subscribed
        /// to the storage account events.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventGridResourceId")]
        public string EventGridResourceId { get; set; }

        /// <summary>
        /// Gets or sets the resource ID where the event grid is configured to
        /// send events.
        /// </summary>
        [JsonProperty(PropertyName = "properties.eventHubResourceId")]
        public string EventHubResourceId { get; set; }

        /// <summary>
        /// Gets or sets the event hub consumer group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consumerGroup")]
        public string ConsumerGroup { get; set; }

        /// <summary>
        /// Gets or sets the table where the data should be ingested.
        /// Optionally the table information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the mapping rule to be used to ingest the data.
        /// Optionally the mapping information can be added to each message.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mappingRuleName")]
        public string MappingRuleName { get; set; }

        /// <summary>
        /// Gets or sets the data format of the message. Optionally the data
        /// format can be added to each message. Possible values include:
        /// 'MULTIJSON', 'JSON', 'CSV', 'TSV', 'SCSV', 'SOHSV', 'PSV', 'TXT',
        /// 'RAW', 'SINGLEJSON', 'AVRO', 'TSVE', 'PARQUET', 'ORC',
        /// 'APACHEAVRO', 'W3CLOGFILE'
        /// </summary>
        [JsonProperty(PropertyName = "properties.dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value that, if set to true, indicates that
        /// ingestion should ignore the first record of every file
        /// </summary>
        [JsonProperty(PropertyName = "properties.ignoreFirstRecord")]
        public bool? IgnoreFirstRecord { get; set; }

        /// <summary>
        /// Gets or sets the name of blob storage event type to process.
        /// Possible values include: 'Microsoft.Storage.BlobCreated',
        /// 'Microsoft.Storage.BlobRenamed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.blobStorageEventType")]
        public string BlobStorageEventType { get; set; }

        /// <summary>
        /// Gets or sets the resource ID of a managed identity (system or user
        /// assigned) to be used to authenticate with event hub and storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedIdentityResourceId")]
        public string ManagedIdentityResourceId { get; set; }

        /// <summary>
        /// Gets the object ID of managedIdentityResourceId
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedIdentityObjectId")]
        public string ManagedIdentityObjectId { get; private set; }

        /// <summary>
        /// Gets or sets indication for database routing information from the
        /// data connection, by default only database routing information is
        /// allowed. Possible values include: 'Single', 'Multi'
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseRouting")]
        public string DatabaseRouting { get; set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountResourceId");
            }
            if (EventHubResourceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "EventHubResourceId");
            }
            if (ConsumerGroup == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConsumerGroup");
            }
        }
    }
}
