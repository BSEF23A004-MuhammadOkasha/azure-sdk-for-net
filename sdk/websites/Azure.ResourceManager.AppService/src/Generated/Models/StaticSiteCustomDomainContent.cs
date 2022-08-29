// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static Site Custom Domain Request Properties ARM resource. </summary>
    public partial class StaticSiteCustomDomainContent : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteCustomDomainContent. </summary>
        public StaticSiteCustomDomainContent()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteCustomDomainContent. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="validationMethod"> Validation method for adding a custom domain. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteCustomDomainContent(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string validationMethod, string kind) : base(id, name, resourceType, systemData)
        {
            ValidationMethod = validationMethod;
            Kind = kind;
        }

        /// <summary> Validation method for adding a custom domain. </summary>
        public string ValidationMethod { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
