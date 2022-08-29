// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the TopLevelDomain data model. </summary>
    public partial class TopLevelDomainData : ResourceData
    {
        /// <summary> Initializes a new instance of TopLevelDomainData. </summary>
        public TopLevelDomainData()
        {
        }

        /// <summary> Initializes a new instance of TopLevelDomainData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="hasPrivacy"> If &lt;code&gt;true&lt;/code&gt;, then the top level domain supports domain privacy; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal TopLevelDomainData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? hasPrivacy, string kind) : base(id, name, resourceType, systemData)
        {
            HasPrivacy = hasPrivacy;
            Kind = kind;
        }

        /// <summary> If &lt;code&gt;true&lt;/code&gt;, then the top level domain supports domain privacy; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? HasPrivacy { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
