// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters to create and update Cosmos DB Graph resource. </summary>
    public partial class GraphResourceGetResultCreateOrUpdateContent : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultCreateOrUpdateContent"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Graph resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resource"/> is null. </exception>
        public GraphResourceGetResultCreateOrUpdateContent(AzureLocation location, WritableSubResource resource) : base(location)
        {
            Argument.AssertNotNull(resource, nameof(resource));

            Resource = resource;
        }

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultCreateOrUpdateContent"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="resource"> The standard JSON format of a Graph resource. </param>
        /// <param name="options"> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GraphResourceGetResultCreateOrUpdateContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, WritableSubResource resource, CosmosDBCreateUpdateConfig options, ManagedServiceIdentity identity, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Resource = resource;
            Options = options;
            Identity = identity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GraphResourceGetResultCreateOrUpdateContent"/> for deserialization. </summary>
        internal GraphResourceGetResultCreateOrUpdateContent()
        {
        }

        /// <summary> The standard JSON format of a Graph resource. </summary>
        internal WritableSubResource Resource { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier ResourceId
        {
            get => Resource is null ? default : Resource.Id;
            set
            {
                if (Resource is null)
                    Resource = new WritableSubResource();
                Resource.Id = value;
            }
        }

        /// <summary> A key-value pair of options to be applied for the request. This corresponds to the headers sent with the request. </summary>
        public CosmosDBCreateUpdateConfig Options { get; set; }
        /// <summary> Identity for the resource. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
