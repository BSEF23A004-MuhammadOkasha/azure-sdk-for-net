// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MachineLearningServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> A class representing the BatchDeploymentData data model. </summary>
    public partial class BatchDeploymentDataData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of BatchDeploymentDataData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public BatchDeploymentDataData(AzureLocation location, BatchDeploymentDetails properties) : base(location)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of BatchDeploymentDataData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Managed service identity (system assigned and/or user assigned identities). </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </param>
        /// <param name="properties"> Additional attributes of the entity. </param>
        /// <param name="sku"> Sku details required for ARM contract for Autoscaling. </param>
        internal BatchDeploymentDataData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string kind, BatchDeploymentDetails properties, MachineLearningServicesSku sku) : base(id, name, type, systemData, tags, location)
        {
            Identity = identity;
            Kind = kind;
            Properties = properties;
            Sku = sku;
        }

        /// <summary> Managed service identity (system assigned and/or user assigned identities). </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type. </summary>
        public string Kind { get; set; }
        /// <summary> Additional attributes of the entity. </summary>
        public BatchDeploymentDetails Properties { get; set; }
        /// <summary> Sku details required for ARM contract for Autoscaling. </summary>
        public MachineLearningServicesSku Sku { get; set; }
    }
}
