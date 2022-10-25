// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary> A class representing the IntegrationRuntimeResource data model. </summary>
    public partial class IntegrationRuntimeResourceData : ResourceData
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeResourceData. </summary>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public IntegrationRuntimeResourceData(IntegrationRuntime properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties">
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </param>
        /// <param name="etag"> Resource Etag. </param>
        internal IntegrationRuntimeResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IntegrationRuntime properties, ETag? etag) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            ETag = etag;
        }

        /// <summary>
        /// Integration runtime properties.
        /// Please note <see cref="IntegrationRuntime"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ManagedIntegrationRuntime"/> and <see cref="SelfHostedIntegrationRuntime"/>.
        /// </summary>
        public IntegrationRuntime Properties { get; set; }
        /// <summary> Resource Etag. </summary>
        public ETag? ETag { get; }
    }
}
