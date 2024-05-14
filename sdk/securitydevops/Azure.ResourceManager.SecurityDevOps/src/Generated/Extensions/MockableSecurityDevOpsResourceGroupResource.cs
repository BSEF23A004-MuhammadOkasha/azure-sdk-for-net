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
using Azure.ResourceManager.SecurityDevOps;

namespace Azure.ResourceManager.SecurityDevOps.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableSecurityDevOpsResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableSecurityDevOpsResourceGroupResource"/> class for mocking. </summary>
        protected MockableSecurityDevOpsResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableSecurityDevOpsResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableSecurityDevOpsResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of AzureDevOpsConnectorResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of AzureDevOpsConnectorResources and their operations over a AzureDevOpsConnectorResource. </returns>
        public virtual AzureDevOpsConnectorCollection GetAzureDevOpsConnectors()
        {
            return GetCachedClient(client => new AzureDevOpsConnectorCollection(client, Id));
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureDevOpsConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<AzureDevOpsConnectorResource>> GetAzureDevOpsConnectorAsync(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            return await GetAzureDevOpsConnectors().GetAsync(azureDevOpsConnectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored AzureDevOps Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/azureDevOpsConnectors/{azureDevOpsConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AzureDevOpsConnector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="AzureDevOpsConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="azureDevOpsConnectorName"> Name of the AzureDevOps Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureDevOpsConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="azureDevOpsConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<AzureDevOpsConnectorResource> GetAzureDevOpsConnector(string azureDevOpsConnectorName, CancellationToken cancellationToken = default)
        {
            return GetAzureDevOpsConnectors().Get(azureDevOpsConnectorName, cancellationToken);
        }

        /// <summary> Gets a collection of GitHubConnectorResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of GitHubConnectorResources and their operations over a GitHubConnectorResource. </returns>
        public virtual GitHubConnectorCollection GetGitHubConnectors()
        {
            return GetCachedClient(client => new GitHubConnectorCollection(client, Id));
        }

        /// <summary>
        /// Returns a monitored GitHub Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubConnectorName"> Name of the GitHub Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="gitHubConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<GitHubConnectorResource>> GetGitHubConnectorAsync(string gitHubConnectorName, CancellationToken cancellationToken = default)
        {
            return await GetGitHubConnectors().GetAsync(gitHubConnectorName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a monitored GitHub Connector resource for a given ID.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SecurityDevOps/gitHubConnectors/{gitHubConnectorName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GitHubConnector_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-09-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="GitHubConnectorResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="gitHubConnectorName"> Name of the GitHub Connector. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="gitHubConnectorName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="gitHubConnectorName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<GitHubConnectorResource> GetGitHubConnector(string gitHubConnectorName, CancellationToken cancellationToken = default)
        {
            return GetGitHubConnectors().Get(gitHubConnectorName, cancellationToken);
        }
    }
}
