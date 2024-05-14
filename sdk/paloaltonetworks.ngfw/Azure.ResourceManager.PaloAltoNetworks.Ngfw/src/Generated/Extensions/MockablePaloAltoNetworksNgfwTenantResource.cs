// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockablePaloAltoNetworksNgfwTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockablePaloAltoNetworksNgfwTenantResource"/> class for mocking. </summary>
        protected MockablePaloAltoNetworksNgfwTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockablePaloAltoNetworksNgfwTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockablePaloAltoNetworksNgfwTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of GlobalRulestackResources in the TenantResource. </summary>
        /// <returns> An object representing collection of GlobalRulestackResources and their operations over a GlobalRulestackResource. </returns>
        public virtual GlobalRulestackCollection GetGlobalRulestacks()
        {
            return GetCachedClient(client => new GlobalRulestackCollection(client, Id));
        }

        /// <summary>
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<GlobalRulestackResource>> GetGlobalRulestackAsync(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            return await GetGlobalRulestacks().GetAsync(globalRulestackName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a GlobalRulestackResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/PaloAltoNetworks.Cloudngfw/globalRulestacks/{globalRulestackName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GlobalRulestack_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-09-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GlobalRulestackResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="globalRulestackName"> GlobalRulestack resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="globalRulestackName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="globalRulestackName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<GlobalRulestackResource> GetGlobalRulestack(string globalRulestackName, CancellationToken cancellationToken = default)
        {
            return GetGlobalRulestacks().Get(globalRulestackName, cancellationToken);
        }
    }
}
