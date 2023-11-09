// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing the RedisLinkedServerWithProperty data model.
    /// Response to put/get linked server (with properties) for Redis cache.
    /// </summary>
    public partial class RedisLinkedServerWithPropertyData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisLinkedServerWithPropertyData"/>. </summary>
        public RedisLinkedServerWithPropertyData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RedisLinkedServerWithPropertyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="linkedRedisCacheId"> Fully qualified resourceId of the linked redis cache. </param>
        /// <param name="linkedRedisCacheLocation"> Location of the linked redis cache. </param>
        /// <param name="serverRole"> Role of the linked server. </param>
        /// <param name="geoReplicatedPrimaryHostName"> The unchanging DNS name which will always point to current geo-primary cache among the linked redis caches for seamless Geo Failover experience. </param>
        /// <param name="primaryHostName"> The changing DNS name that resolves to the current geo-primary cache among the linked redis caches before or after the Geo Failover. </param>
        /// <param name="provisioningState"> Terminal state of the link between primary and secondary redis cache. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisLinkedServerWithPropertyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier linkedRedisCacheId, AzureLocation? linkedRedisCacheLocation, RedisLinkedServerRole? serverRole, string geoReplicatedPrimaryHostName, string primaryHostName, string provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            LinkedRedisCacheId = linkedRedisCacheId;
            LinkedRedisCacheLocation = linkedRedisCacheLocation;
            ServerRole = serverRole;
            GeoReplicatedPrimaryHostName = geoReplicatedPrimaryHostName;
            PrimaryHostName = primaryHostName;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully qualified resourceId of the linked redis cache. </summary>
        public ResourceIdentifier LinkedRedisCacheId { get; set; }
        /// <summary> Location of the linked redis cache. </summary>
        public AzureLocation? LinkedRedisCacheLocation { get; set; }
        /// <summary> Role of the linked server. </summary>
        public RedisLinkedServerRole? ServerRole { get; set; }
        /// <summary> The unchanging DNS name which will always point to current geo-primary cache among the linked redis caches for seamless Geo Failover experience. </summary>
        public string GeoReplicatedPrimaryHostName { get; }
        /// <summary> The changing DNS name that resolves to the current geo-primary cache among the linked redis caches before or after the Geo Failover. </summary>
        public string PrimaryHostName { get; }
        /// <summary> Terminal state of the link between primary and secondary redis cache. </summary>
        public string ProvisioningState { get; }
    }
}
