// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Definition of ARM tracked top level resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DataCollectionEndpointResource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpointResource
        /// class.
        /// </summary>
        public DataCollectionEndpointResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataCollectionEndpointResource
        /// class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives.</param>
        /// <param name="description">Description of the data collection
        /// endpoint.</param>
        /// <param name="immutableId">The immutable ID of this data collection
        /// endpoint resource. This property is READ-ONLY.</param>
        /// <param name="configurationAccess">The endpoint used by agents to
        /// access their configuration.</param>
        /// <param name="logsIngestion">The endpoint used by clients to ingest
        /// logs.</param>
        /// <param name="networkAcls">Network access control rules for the
        /// endpoints.</param>
        /// <param name="provisioningState">The resource provisioning state.
        /// This property is READ-ONLY. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed'</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="kind">The kind of the resource. Possible values
        /// include: 'Linux', 'Windows'</param>
        /// <param name="id">Fully qualified ID of the resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="etag">Resource entity tag (ETag).</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        public DataCollectionEndpointResource(string location, string description = default(string), string immutableId = default(string), DataCollectionEndpointConfigurationAccess configurationAccess = default(DataCollectionEndpointConfigurationAccess), DataCollectionEndpointLogsIngestion logsIngestion = default(DataCollectionEndpointLogsIngestion), DataCollectionEndpointNetworkAcls networkAcls = default(DataCollectionEndpointNetworkAcls), string provisioningState = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string kind = default(string), string id = default(string), string name = default(string), string type = default(string), string etag = default(string), DataCollectionEndpointResourceSystemData systemData = default(DataCollectionEndpointResourceSystemData))
        {
            Description = description;
            ImmutableId = immutableId;
            ConfigurationAccess = configurationAccess;
            LogsIngestion = logsIngestion;
            NetworkAcls = networkAcls;
            ProvisioningState = provisioningState;
            Location = location;
            Tags = tags;
            Kind = kind;
            Id = id;
            Name = name;
            Type = type;
            Etag = etag;
            SystemData = systemData;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets description of the data collection endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets the immutable ID of this data collection endpoint resource.
        /// This property is READ-ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutableId")]
        public string ImmutableId { get; private set; }

        /// <summary>
        /// Gets or sets the endpoint used by agents to access their
        /// configuration.
        /// </summary>
        [JsonProperty(PropertyName = "properties.configurationAccess")]
        public DataCollectionEndpointConfigurationAccess ConfigurationAccess { get; set; }

        /// <summary>
        /// Gets or sets the endpoint used by clients to ingest logs.
        /// </summary>
        [JsonProperty(PropertyName = "properties.logsIngestion")]
        public DataCollectionEndpointLogsIngestion LogsIngestion { get; set; }

        /// <summary>
        /// Gets or sets network access control rules for the endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public DataCollectionEndpointNetworkAcls NetworkAcls { get; set; }

        /// <summary>
        /// Gets the resource provisioning state. This property is READ-ONLY.
        /// Possible values include: 'Creating', 'Updating', 'Deleting',
        /// 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the geo-location where the resource lives.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the kind of the resource. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets fully qualified ID of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets resource entity tag (ETag).
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets metadata pertaining to creation and last modification of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "systemData")]
        public DataCollectionEndpointResourceSystemData SystemData { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
