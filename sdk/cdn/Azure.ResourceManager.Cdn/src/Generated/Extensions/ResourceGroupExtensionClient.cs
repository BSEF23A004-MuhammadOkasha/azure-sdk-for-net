// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class to add extension methods to ResourceGroup. </summary>
    internal partial class ResourceGroupExtensionClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class for mocking. </summary>
        protected ResourceGroupExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourceGroupExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ResourceGroupExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of Profiles in the Profile. </summary>
        /// <returns> An object representing collection of Profiles and their operations over a Profile. </returns>
        public virtual ProfileCollection GetProfiles()
        {
            return new ProfileCollection(Client, Id);
        }

        /// <summary> Gets a collection of CdnWebApplicationFirewallPolicies in the CdnWebApplicationFirewallPolicy. </summary>
        /// <returns> An object representing collection of CdnWebApplicationFirewallPolicies and their operations over a CdnWebApplicationFirewallPolicy. </returns>
        public virtual CdnWebApplicationFirewallPolicyCollection GetCdnWebApplicationFirewallPolicies()
        {
            return new CdnWebApplicationFirewallPolicyCollection(Client, Id);
        }
    }
}
