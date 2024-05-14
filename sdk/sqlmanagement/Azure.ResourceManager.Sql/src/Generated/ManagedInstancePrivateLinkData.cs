// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstancePrivateLink data model.
    /// A private link resource
    /// </summary>
    public partial class ManagedInstancePrivateLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ManagedInstancePrivateLinkData"/>. </summary>
        public ManagedInstancePrivateLinkData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstancePrivateLinkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource group id. </param>
        internal ManagedInstancePrivateLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedInstancePrivateLinkProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> The private link resource group id. </summary>
        public ManagedInstancePrivateLinkProperties Properties { get; }
    }
}
